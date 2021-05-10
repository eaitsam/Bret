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

namespace FrameworkAutomation.Tests.AuditLogFrameWorkActions
{
    public class AuditLogFrameworkActions
    {

        private Login _login;
        private NavMenuObjects _navMenu;
        private BaseDriverInit _driverInit;
        private AccessLogPage _accessLog;
        private AuditLog _auditLogPage;


        public AuditLogFrameworkActions()
        {
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _driverInit = new BaseDriverInit();
            _accessLog = new AccessLogPage();
            _auditLogPage = new AuditLog();


        }
        [Fact]
        public void IncludeFrameworkActions()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");
                List<By> tabs = new List<By> { _navMenu.AdminMenuBarXpath, _navMenu.ViewAuditLogMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.GetElement(_accessLog.PageDecriptionLabel).Text.Should().Be(_accessLog.AuditLogPageDescription);
                UIActions.IsElementSelected(_auditLogPage.FrameworkActionCheckbox);


                foreach (string module in _auditLogPage.moduleList)
                {
                    _auditLogPage.IncludeframeworkActionCheckboxvalidation(module);

                }
                UIActions.ClickElement(_auditLogPage.FrameworkActionCheckbox);
                foreach (string module in _auditLogPage.moduleList)
                {
                    _auditLogPage.IncludeframeworkActionUnCheckboxvalidation(module);

                }
                UIActions.ClickElement(_auditLogPage.SearchButton);
                UIActions.IsElementPresent(_accessLog.AccessLogGridView);
            }
            finally
            {
                _driverInit.TearDown();
            }

        }
       
    }

}



