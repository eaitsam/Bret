using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;
using McidsAutomation.PageObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using System.Linq;
using MedchartSeleniumAutomationCore.Core_Framework;

namespace McidsAutomation
{
    public class SingleSignOut
    {
        private readonly Configurations _config;

        private readonly HomePage _homePageMrr;
        private readonly LoggedInPage _loggedInPageMrr;
        private readonly UserInfoPage _userInfoPageMrr;
        private readonly string _webSiteUrlMrr;

        private readonly HomePage _homePageAvs;
        private readonly LoggedInPage _loggedInPageAvs;
        private readonly LoggedOutPage _loggedOutPageAvs;
        private readonly string _webSiteUrlAvs;

        private readonly string _mcidsWebsiteUrl;
        private readonly BaseDriverInit _webDriver;

        private const string ediLogin = "1404485081";
        private const string moduleNameFirstSignOn = "MRR";
        private const string moduleNameSecondSignOn = "AVS";

        public SingleSignOut()
        {
            _config = new Configurations();
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _webDriver = new BaseDriverInit();

            _homePageMrr = new HomePage(moduleNameFirstSignOn);
            _loggedInPageMrr = new LoggedInPage(moduleNameFirstSignOn);
            _userInfoPageMrr = new UserInfoPage(moduleNameFirstSignOn);
            _webSiteUrlMrr = _config.GetConfigValue("MRRWebsiteUrl");

            _homePageAvs = new HomePage(moduleNameSecondSignOn);
            _loggedInPageAvs = new LoggedInPage(moduleNameSecondSignOn);
            _loggedOutPageAvs = new LoggedOutPage(moduleNameSecondSignOn);
            _webSiteUrlAvs = _config.GetConfigValue("AVSWebsiteUrl");
        }

        [Fact]
        public void SingleSignOut_UsingMcids_WithTwoClientApps()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Single Sign-out test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrlMrr);

                // verify home page content for MRR
                VerifyHomePageContent(_homePageMrr.GetBodyText(), moduleNameFirstSignOn);

                #region Login for MRR (moduleNameFirstSignOn)

                // click login link for MRR
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page for MRR
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // use MCIDS to login to MRR
                McidsLoginPage.EnterEdiAndSubmit(ediLogin);

                // verify you are on the logged in page for MRR
                _loggedInPageMrr.GetLoggedInPageHeading().Should().Be(_loggedInPageMrr.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleNameFirstSignOn + " ");

                #endregion Login for MRR (moduleNameFirstSignOn)

                #region Login for AVS (moduleNameSecondSignOn)

                // open a new tab for AVS

                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                DebuggingHelpers.Logger().Info(" Opened a new tab for " + moduleNameSecondSignOn + " ");

                // navigate to new AVS tab
                driver.Navigate().GoToUrl(_webSiteUrlAvs);
                DebuggingHelpers.Logger().Info(" Navigated to new tab for " + moduleNameSecondSignOn + " ");

                // verify home page content for AVS
                VerifyHomePageContent(_homePageAvs.GetBodyText(), moduleNameSecondSignOn);

                // click login link for AVS
                TopMenuItems.ClickLoginLink();

                // verify user is logged in automatically for AVS
                _loggedInPageAvs.GetLoggedInPageHeading().Should().Be(_loggedInPageAvs.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Verified user logged into " + moduleNameSecondSignOn + " automatically without asking for EDI ");

                #endregion Login for AVS (moduleNameSecondSignOn)

                #region Logout for AVS (moduleNameSecondSignOn)

                // click logout link to log out of AVS
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleNameSecondSignOn + " ");

                // verify you are on the logout page for AVS
                _loggedOutPageAvs.GetLoggedOutPageHeading().Should().Be(_loggedOutPageAvs.LoggedOutPageHeadingActual);

                #endregion Logout for AVS (moduleNameSecondSignOn)

                #region Logout for MRR (moduleNameFirstSignOn)

                // switch back to MRR site
                driver.SwitchTo().Window(driver.WindowHandles.First());

                // verify you are on the login page for MRR
                driver.Url.Should().Contain(_webSiteUrlMrr);

                // click login link for MRR
                TopMenuItems.ClickUserInfoLink();

                // verify access is now denied for MRR
                _userInfoPageMrr.GetAccessDeniedMessage().Should().Be(_userInfoPageMrr.AccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified access to user info in " + moduleNameFirstSignOn + " is now denied ");

                #endregion Logout for MRR (moduleNameFirstSignOn)

                DebuggingHelpers.Logger().Info(" *** End MCIDS Single Sign-out test case ***");
            }
            catch
            {
                DebuggingHelpers.Logger().Info(" *** Test ended with an error ***");
            }
            finally
            {
                // tear down and dispose
                TearDownAndDispose();
            }
        }

        #region Private Methods

        private void TearDownAndDispose()
        {
            _webDriver.TearDown();
            _webDriver.Dispose();
            DebuggingHelpers.Logger().Info(" Tear down and dispose ");
        }

        private void VerifyHomePageContent(string homePageBodyText, string moduleName)
        {
            homePageBodyText.Should().Contain(_homePageAvs.BodyTextActual);
            homePageBodyText.Should().Contain(_homePageAvs.TestOnlyMessageActual);
            homePageBodyText.Should().Contain(_homePageAvs.DescriptionActual);
            DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " home page ");
        }

        #endregion Private Methods
    }
}