using FluentAssertions;
using McidsAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace McidsAutomation
{
    public class ImpersonateRole
    {
        private readonly Configurations _config;
        private readonly HomePage _homePage;
        private readonly ImpersonateRolePage _impersonateRolePage;
        private readonly LoggedInPage _loggedInPage;
        private readonly string _mcidsWebsiteUrl;
        private readonly StopImpersonationPage _stopImpersonationPage;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;

        private const string ediLoginAuthorizedToImpersonateRole = "9990009999";
        private const string ediLoginNotAuthorizedToImpersonateRole = "1404485081";
        private const string moduleName = "MRR";
        private const string roleToImpersonate = "[{\"M\":\"4\",\"R\":\"14\",\"dP\":\"-1,24,25,32,4002,4006\",\"eP\":\"\"}]";

        public ImpersonateRole()
        {
            _config = new Configurations();
            _homePage = new HomePage(moduleName);
            _impersonateRolePage = new ImpersonateRolePage(moduleName);
            _loggedInPage = new LoggedInPage(moduleName);
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _stopImpersonationPage = new StopImpersonationPage(moduleName);
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("MRRWebsiteUrl");
        }

        [Fact]
        public void ImpersonateRole_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Impersonate Role - Authorized test case ***");
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
                McidsLoginPage.EnterEdiAndSubmit(ediLoginAuthorizedToImpersonateRole);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // make sure impersonation for ediLoginAuthorizedToImpersonateRole is cleared
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are on the stop impersonation page
                _stopImpersonationPage.GetStopImpersonationPageHeading().Should().Be(_stopImpersonationPage.StopImpersonationPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop impersonation page ");

                // click impersonate role link and verify page
                ClickImpersonateRoleLinkAndVerifyPage();

                // enter roleToImpersonate in textbox
                _impersonateRolePage.EnterRoleToImpersonate(roleToImpersonate);
                DebuggingHelpers.Logger().Info(" Entered role to impersonate ");

                // click impersonate role button
                _impersonateRolePage.ClickImpersonateRoleButton();
                DebuggingHelpers.Logger().Info(" Clicked impersonate role button ");

                // verify you are authorized to impersonate role
                string impersonateRoleAuthorizedMessage = _impersonateRolePage.GetImpersonateRoleMessage();
                impersonateRoleAuthorizedMessage.Should().NotBe(_impersonateRolePage.ImpersonateRoleNotAuthorizedMessageActual);
                impersonateRoleAuthorizedMessage.Should().Be("");

                // verify that the role is different from the role before impersonating
                _impersonateRolePage.GetRoleAfterImpersonating().Should().Be(roleToImpersonate);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginAuthorizedToImpersonateRole + " logged into " + moduleName + " and was authorized to impersonate " + roleToImpersonate + " ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Impersonate Role - Authorized test case ***");
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
        public void ImpersonateRole_UsingMcids_UserNotAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Impersonate Role - Not Authorized test case ***");
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
                McidsLoginPage.EnterEdiAndSubmit(ediLoginNotAuthorizedToImpersonateRole);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // make sure impersonation for ediLoginNotAuthorizedToImpersonateRole is cleared
                TopMenuItems.ClickStopImpersonationLink();
                _stopImpersonationPage.ClickStopImpersonationButton();
                DebuggingHelpers.Logger().Info(" Clicked stop impersonation role link and button ");

                // verify you are on the stop impersonation page
                _stopImpersonationPage.GetStopImpersonationPageHeading().Should().Be(_stopImpersonationPage.StopImpersonationPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop impersonation page ");

                // click impersonate role link and verify page
                ClickImpersonateRoleLinkAndVerifyPage();

                // enter roleToImpersonate in textbox
                _impersonateRolePage.EnterRoleToImpersonate(roleToImpersonate);
                DebuggingHelpers.Logger().Info(" Entered role to impersonate for " + moduleName + " ");

                // click impersonate role button
                _impersonateRolePage.ClickImpersonateRoleButton();
                DebuggingHelpers.Logger().Info(" Clicked " + moduleName + " impersonate role button ");

                // verify you are not authorized to impersonate role
                _impersonateRolePage.GetImpersonateRoleMessage().Should().Be(_impersonateRolePage.ImpersonateRoleNotAuthorizedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginNotAuthorizedToImpersonateRole + " logged in but was not authorized to impersonate a role ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Impersonate Role - Not Authorized test case ***");
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
        public void ImpersonateRole_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Impersonate Role - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click impersonate role link and verify page
                ClickImpersonateRoleLinkAndVerifyPage();

                // click link to go to impersonate role page
                TopMenuItems.ClickImpersonateRoleLink();
                DebuggingHelpers.Logger().Info(" Clicked impersonate role link for ");

                // verify you are on the impersonate role page
                _impersonateRolePage.GetImpersonateRolePageHeading().Should().Be(_impersonateRolePage.ImpersonateRolePageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded impersonate role page ");

                // verify access denied for impersonate role
                _impersonateRolePage.GetImpersonateRolePageHeading().Should().Be(_impersonateRolePage.ImpersonateRoleAccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to impersonate role ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Impersonate Role - Not Logged In test case ***");
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

        private void ClickImpersonateRoleLinkAndVerifyPage()
        {
            // click link to go to impersonate role page
            TopMenuItems.ClickImpersonateRoleLink();
            DebuggingHelpers.Logger().Info(" Clicked impersonate role link for " + moduleName + " ");

            // verify you are on the impersonate role page
            _impersonateRolePage.GetImpersonateRolePageHeading().Should().Be(_impersonateRolePage.ImpersonateRolePageHeadingActual);
            DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " impersonate role page ");
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