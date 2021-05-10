using FluentAssertions;
using FrameworkAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.Tests.ContactUs
{    
        
        public class ContactUs
        {
            BaseDriverInit _driverInit;
            Login _login;
            ManageMessagesPage _message;
            MedchartSplashPage _splashPage;
            ContactUsPage _contactUsPage;

        public ContactUs()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _message = new ManageMessagesPage();
            _splashPage = new MedchartSplashPage();
            _contactUsPage = new ContactUsPage();

        }

        [Fact]
        public void HelpDeskEmailValidation()
        {
            try
            {
                _driverInit.InitWebdriver();               
                UIActions.ClickElement(_splashPage.ContactUsLink);
                UIActions.GetElement(_contactUsPage.MedchartHelpEmailLink);
                UIActions.GetElement(_message.PageDecription).Text.Should().Be(_message.contactUsPageDescription);
            }
            finally
            {
                _driverInit.TearDown();
            };
        }
    }

    
}
