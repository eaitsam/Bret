using FluentAssertions;
using FrameworkAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.Tests.System_Misc
{
    public class ManageMessages
	{

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        ManageMessagesPage _message;
        Homepage _home;

        public ManageMessages()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _home = new Homepage();
            _message = new ManageMessagesPage();
        }

        [Fact]
        public void ManageMessagesPageValidation()
        {
            try
            {
                //login
                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");

                //Navigate to Manage Messages
                List<By> tabs = new List<By> { _navMenu.AdminMenuBarID, _navMenu.ManageMessagesMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);


                //select all roles on page
                ManageMessagesPage.ModuleObject moduleObject;
                WaitMethods.Wait(_message.SubmitButton, 30);

                foreach (string module in _message.moduleList)
                {
                    moduleObject = _message.GetModuleObject(module);
                    UIActions.GetElement(moduleObject.GetModuleSelectButton()).Click();
                }
                UIActions.GetElement(_message.SubmitButton).Click();

                UIActions.GetElement(_message.MessageEndDateRequiredFieldValidator).Displayed.Should().BeTrue();
                UIActions.GetElement(_message.MessageStartDateRequiredFieldValidator).Displayed.Should().BeTrue();
                UIActions.GetElement(_message.MessageTitleRequiredFieldValidator).Displayed.Should().BeTrue();

                foreach (string module in _message.moduleList)
                {
                    moduleObject = _message.GetModuleObject(module);

                    foreach (By checkbox in moduleObject.GetListOfRolesCheckBox())
                    {
                        UIActions.GetElement(checkbox).Selected.Should().BeTrue();
                    }
                }

            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        [Fact]
        public void ManageMessagesCreateMessage()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");

                //Navigate to Manage Messages
                List<By> tabs = new List<By> { _navMenu.AdminMenuBarID, _navMenu.ManageMessagesMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                int startDays = 0;
                int endDays = 0;

                //Select ARNG Manager role for AVS to send a message (That is the first role)
                ManageMessagesPage.ModuleObject moduleObject;
                moduleObject = _message.GetModuleObject("AVS");
                By roleCheckboxLocation = moduleObject.GetListOfRolesCheckBox()[0];

                UIActions.GetElement(roleCheckboxLocation).Click();

                //Select Start Date
                var startDateTextBox = UIActions.GetElement(_message.StartDateDateTime);
                startDateTextBox.Click();

                DateTime now = DateTime.Now.AddDays(Convert.ToInt32(startDays));
                UIActions.SetDateForDateTimePicker(_message.StartDateCalendar, now.Year, now.Month, now.Day);
                startDateTextBox.Click();

                //Select End Date
                var endDateTextBox = UIActions.GetElement(_message.EndDateDateTime);
                endDateTextBox.Click();

                now = DateTime.Now.AddDays(Convert.ToInt32(endDays + 1));
                UIActions.SetDateForDateTimePicker(_message.EndDateCalendar, now.Year, now.Month, now.Day);
                endDateTextBox.Click();

                //Enter Message in the Message Box
                UIActions.TypeInTextBox(_message.MessageTextBox, _message.message);

                //Enter Message in the Extended Information Box
                UIActions.TypeInTextBox(_message.ExtendedInformationTextBox, _message.message);

                UIActions.GetElement(_message.SubmitButton).Click();

                List<By> home = new List<By> { _navMenu.HomeMasterMenuBarCss };
                MasterMenuNavigation.StartTabSelectionMethod(home);

                UIActions.GetElement(_home.SystemMessagesGrid).Text.Should()
                    .StartWith("Reference Role MEDCHART ARNG Manager (" + DateTime.Now.ToString("MM/dd/yyyy"));

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void EditMessage()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");

                //Navigate to Manage Messages
                List<By> tabs = new List<By> { _navMenu.AdminMenuBarID, _navMenu.ManageMessagesMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.GetElement(_message.MySystemMessagesTab).Click();

                //Select First Row and edit message
                UIActions.GetElement(_message.MySystemMessagesTab).Click();


                UIActions.GetElement(_message.SystemMessagesGridViewFirstEditButton).Click();
                UIActions.GetElement(_message.SystemMessagesEditMessageTextBox).Clear();
                UIActions.GetElement(_message.SystemMessagesEditMessageTextBox).SendKeys(_message.editedMessage);
                UIActions.GetElement(_message.SystemMessagesSaveButton).Click();

                UIActions.GetElement(_message.SystemMessagesGridViewFirstMessageCell).Text.Should().Be(_message.editedMessage);
            }
            finally
            {
                _driverInit.TearDown();
            }

        }

    }
}
