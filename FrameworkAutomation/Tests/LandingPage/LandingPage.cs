using FluentAssertions;
using FrameworkAutomation.PageObjectModel;
using FrameworkAutomation.PageObjectModel.LandingPage;
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

namespace FrameworkAutomation.Tests.LandingPage
{
    public class LandingPage
    {
        private Login _login;
        private NavMenuObjects _navMenu;
        private BaseDriverInit _driverInit;
        private AccessLogPage _accessLog;
        private AuditLog _auditLogPage;
        private Landing_Page _landingPage;
        public LandingPage()
        {
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _driverInit = new BaseDriverInit();
            _accessLog = new AccessLogPage();
            _auditLogPage = new AuditLog();
            _landingPage = new Landing_Page();

        }
        [Fact]
        public void LandingPageValidation()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");
                Assert.True(UIActions.GetElement(_landingPage.HippaWarning).Displayed);
                UIActions.ClickElement(_landingPage.DDWebSiteLink);
                Assert.True(UIActions.GetElement(_landingPage.DDWebSiteLinkPage).Displayed);
            }
            finally
            {
                _driverInit.TearDown();
            }
        }
    }
}
