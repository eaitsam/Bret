using FluentAssertions;
using McidsAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace McidsAutomation
{
    public class ImpersonateUser
    {
        private readonly Configurations _config;
        private readonly HomePage _homePage;
        private readonly ImpersonateUserPage _impersonateUserPage;
        private readonly LoggedInPage _loggedInPage;
        private readonly string _mcidsWebsiteUrl;
        private readonly StopImpersonationPage _stopImpersonationPage;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;

        private const string ediLoginAuthorizedToImpersonateUser = "9990009999";
        private const string ediLoginNotAuthorizedToImpersonateUser = "1404485081";
        private const string ediToImpersonate = "8880007032";
        private const string moduleName = "MRR";

        public ImpersonateUser()
        {
            _config = new Configurations();
            _homePage = new HomePage(moduleName);
            _impersonateUserPage = new ImpersonateUserPage(moduleName);
            _loggedInPage = new LoggedInPage(moduleName);
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _stopImpersonationPage = new StopImpersonationPage(moduleName);
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("MRRWebsiteUrl");
        }

        [Fact]
        public void ImpersonateUser_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Impersonate User - Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();
                DebuggingHelpers.Logger().Info(" Clicked " + moduleName + " login link ");

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with ediLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLoginAuthorizedToImpersonateUser);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // make sure impersonation for ediLoginAuthorizedToImpersonateUser is cleared
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are on the stop impersonation page
                _stopImpersonationPage.GetStopImpersonationPageHeading().Should().Be(_stopImpersonationPage.StopImpersonationPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop impersonation page ");

                // click impersonate user link and verify page
                ClickImpersonateUserLinkAndVerifyPage();

                //capture role of user before impersonating a different user
                string userRoleBeforeImpersonating = _impersonateUserPage.GetRoleBeforeImpersonating();

                // enter EdiToImpersonate in textbox
                _impersonateUserPage.EnterEdiToImpersonate(ediToImpersonate);
                DebuggingHelpers.Logger().Info(" Entered EDI to impersonate ");

                // click impersonate user button
                _impersonateUserPage.ClickImpersonateUserButton();
                DebuggingHelpers.Logger().Info(" Clicked impersonate user button ");

                // verify you are authorized to impersonate use
                string impersonateUserAuthorizedMessage = _impersonateUserPage.GetImpersonateUserMessage();
                impersonateUserAuthorizedMessage.Should().NotBe(_impersonateUserPage.ImpersonateUserNotAuthorizedMessageActual);
                impersonateUserAuthorizedMessage.Should().Be("");

                // verify that the role is different from the role before impersonating
                _impersonateUserPage.GetRoleAfterImpersonating().Should().NotBe(userRoleBeforeImpersonating);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginAuthorizedToImpersonateUser + " logged into " + moduleName + " and was authorized to impersonate " + ediToImpersonate + " ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Impersonate User - Authorized test case ***");
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

        [Fact]
        public void ImpersonateUser_UsingMcids_UserNotAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Impersonate User - Not Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();
                DebuggingHelpers.Logger().Info(" Clicked " + moduleName + " login link ");

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with ediLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLoginNotAuthorizedToImpersonateUser);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // make sure impersonation for ediLoginNotAuthorizedToImpersonateUser is cleared
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are on the stop impersonation page
                _stopImpersonationPage.GetStopImpersonationPageHeading().Should().Be(_stopImpersonationPage.StopImpersonationPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop impersonation page ");

                // click impersonate user link and verify page
                ClickImpersonateUserLinkAndVerifyPage();

                // enter EdiToImpersonate in textbox
                _impersonateUserPage.EnterEdiToImpersonate(ediToImpersonate);
                DebuggingHelpers.Logger().Info(" Entered EDI to impersonate user ");

                // click impersonate user button
                _impersonateUserPage.ClickImpersonateUserButton();
                DebuggingHelpers.Logger().Info(" Clicked impersonate user button ");

                // verify you are not authorized to impersonate user
                _impersonateUserPage.GetImpersonateUserMessage().Should().Be(_impersonateUserPage.ImpersonateUserNotAuthorizedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginNotAuthorizedToImpersonateUser + " logged in but was not authorized to impersonate a user ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Impersonate User - Not Authorized test case ***");
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

        [Fact]
        public void ImpersonateUser_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Impersonate Role - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click impersonate role link and verify page
                ClickImpersonateUserLinkAndVerifyPage();

                // click link to go to impersonate user page
                TopMenuItems.ClickImpersonateUserLink();
                DebuggingHelpers.Logger().Info(" Clicked impersonate user link for " + moduleName + " ");

                // verify you are on the impersonate user page
                _impersonateUserPage.GetImpersonateUserPageHeading().Should().Be(_impersonateUserPage.ImpersonateUserPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " impersonate user page ");

                // verify access denied for impersonate user
                _impersonateUserPage.GetImpersonateUserPageHeading().Should().Be(_impersonateUserPage.ImpersonateUserAccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to impersonate user ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Impersonate User - Not Logged In test case ***");
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

        private void ClickImpersonateUserLinkAndVerifyPage()
        {
            // click link to go to impersonate user page
            TopMenuItems.ClickImpersonateUserLink();

            // verify you are on the impersonate user page
            _impersonateUserPage.GetImpersonateUserPageHeading().Should().Be(_impersonateUserPage.ImpersonateUserPageHeadingActual);
            DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " Impersonate User Page ");
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