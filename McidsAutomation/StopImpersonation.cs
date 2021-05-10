using FluentAssertions;
using McidsAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace McidsAutomation
{
    public class StopImpersonation
    {
        private readonly Configurations _config;
        private readonly HomePage _homePage;
        private readonly ImpersonateRolePage _impersonateRolePage;
        private readonly ImpersonateUserPage _impersonateUserPage;
        private readonly LoggedInPage _loggedInPage;
        private readonly string _mcidsWebsiteUrl;
        private readonly StopImpersonationPage _stopImpersonationPage;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;

        private const string ediLoginAuthorizedToImpersonate = "9990009999";
        private const string ediToImpersonate = "8880007032";
        private const string moduleName = "MRR";

        private const string roleToImpersonate = "[{\"M\":\"4\",\"R\":\"14\",\"dP\":\"-1,24,25,32,4002,4006\",\"eP\":\"\"}]";

        public StopImpersonation()
        {
            _config = new Configurations();
            _homePage = new HomePage(moduleName);
            _impersonateRolePage = new ImpersonateRolePage(moduleName);
            _impersonateUserPage = new ImpersonateUserPage(moduleName);
            _loggedInPage = new LoggedInPage(moduleName);
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _stopImpersonationPage = new StopImpersonationPage(moduleName);
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("MRRWebsiteUrl");
        }

        #region Stop Role Impersonation

        [Fact]
        public void StopRoleImpersonation_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Stop Impersonation Role - Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with ediLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLoginAuthorizedToImpersonate);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // make sure impersonation for ediLoginAuthorizedToImpersonate is cleared
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are on the stop impersonation page
                _stopImpersonationPage.GetStopImpersonationPageHeading().Should().Be(_stopImpersonationPage.StopImpersonationPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop impersonation page ");

                // click impersonate role link
                TopMenuItems.ClickImpersonateRoleLink();
                DebuggingHelpers.Logger().Info(" Clicked impersonate role link ");

                // enter roleToImpersonate in textbox
                _impersonateRolePage.EnterRoleToImpersonate(roleToImpersonate);
                DebuggingHelpers.Logger().Info(" Entered role to impersonate ");

                // click impersonate role button
                _impersonateRolePage.ClickImpersonateRoleButton();
                DebuggingHelpers.Logger().Info(" Clicked impersonate role button ");

                // click stop impersonation link and button
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are authorized to stop impersonation role
                string impersonateRoleAuthorizedMessage = _impersonateRolePage.GetImpersonateRoleMessage();
                impersonateRoleAuthorizedMessage.Should().NotBe(_impersonateRolePage.ImpersonateRoleNotAuthorizedMessageActual);
                impersonateRoleAuthorizedMessage.Should().Be("");
                DebuggingHelpers.Logger().Info(" Verified authorized to stop impersonation role ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Stop Impersonation Role - Authorized test case ***");
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

        #endregion Stop Role Impersonation

        #region Stop User Impersonation

        [Fact]
        public void StopUserImpersonation_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Stop Impersonation User - Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with ediLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLoginAuthorizedToImpersonate);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // make sure impersonation for ediLoginAuthorizedToImpersonate is cleared
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are on the stop impersonation page
                _stopImpersonationPage.GetStopImpersonationPageHeading().Should().Be(_stopImpersonationPage.StopImpersonationPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop impersonation page ");

                // click impersonate user link
                TopMenuItems.ClickImpersonateUserLink();
                DebuggingHelpers.Logger().Info(" Clicked impersonate user link ");

                // enter ediToImpersonate in textbox
                _impersonateUserPage.EnterEdiToImpersonate(ediToImpersonate);
                DebuggingHelpers.Logger().Info(" Entered EDI to impersonate ");

                // click impersonate user button
                _impersonateUserPage.ClickImpersonateUserButton();
                DebuggingHelpers.Logger().Info(" Clicked impersonate user button ");

                // click stop impersonation link and button
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation user link and button ");

                // verify you are authorized to stop impersonation user
                string impersonateUserAuthorizedMessage = _impersonateUserPage.GetImpersonateUserMessage();
                impersonateUserAuthorizedMessage.Should().NotBe(_impersonateUserPage.ImpersonateUserNotAuthorizedMessageActual);
                impersonateUserAuthorizedMessage.Should().Be("");
                DebuggingHelpers.Logger().Info(" Verified authorized to stop impersonation user ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Stop Impersonation User - Authorized test case ***");
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

        #endregion Stop User Impersonation

        [Fact]
        public void StopImpersonation_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Stop Impersonation  - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click stop impersonation link and button
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are not logged in and do not have access to stop impersonation
                _stopImpersonationPage.GetStopImpersonationMessage().Should().NotBe(_stopImpersonationPage.StopImpersonationAccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to stop impersonation ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Stop Impersonation - Authorized test case ***");
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

        private void VerifyHomePageContent(string homePageBodyText)
        {
            homePageBodyText.Should().Contain(_homePage.BodyTextActual);
            homePageBodyText.Should().Contain(_homePage.TestOnlyMessageActual);
            homePageBodyText.Should().Contain(_homePage.DescriptionActual);
            DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " home page ");
        }

        #endregion Private Methods
    }
}