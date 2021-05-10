using FluentAssertions;
using McidsAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace McidsAutomation
{
    public class MaintenanceMode
    {
        private readonly Configurations _config;
        private readonly HomePage _homePage;
        private readonly LoggedInPage _loggedInPage;
        private readonly string _mcidsWebsiteUrl;
        private readonly StartMaintenanceModePage _startMaintenanceModePage;
        private readonly StopMaintenanceModePage _stopMaintenanceModePage;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;

        private const string ediLoginAuthorizedToStartAndStopMaintenanceMode = "9990001100";
        private const string ediLoginNotAuthorizedToStartOrStopMaintenanceMode = "9990009999";
        private const string moduleName = "MRR";

        public MaintenanceMode()
        {
            _config = new Configurations();
            _homePage = new HomePage(moduleName);
            _loggedInPage = new LoggedInPage(moduleName);
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");

            _startMaintenanceModePage = new StartMaintenanceModePage(moduleName);
            _stopMaintenanceModePage = new StopMaintenanceModePage(moduleName);
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("MRRWebsiteUrl");
        }

        [Fact]
        public void StartAndStopMaintenanceMode_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Start/Stop Maintenance Mode - Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with EdiLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLoginAuthorizedToStartAndStopMaintenanceMode);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                #region Start Maintenance Mode

                // click start maintenance mode link
                TopMenuItems.ClickStartMaintenanceModeLink();

                // verify you are on the start maintenance mode page
                _startMaintenanceModePage.GetStartMaintenanceModePageHeading().Should().Be(_startMaintenanceModePage.StartMaintenanceModePageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded start maintenance mode page ");

                // click start maintenance mode button
                _startMaintenanceModePage.ClickStartMaintenanceModeButton();
                DebuggingHelpers.Logger().Info(" Clicked start maintenance mode button ");

                // verify you are authorized to start maintenance mode
                _startMaintenanceModePage.GetStartMaintenanceModeAuthorizedMessage().Should().NotBe(_startMaintenanceModePage.StartMaintenanceModeUserNotAuthorizedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginAuthorizedToStartAndStopMaintenanceMode + " logged in and was authorized to start maintenance mode ");

                // verify maintenance mode started
                _startMaintenanceModePage.GetStartMaintenanceModeMessage().Should().Be(_startMaintenanceModePage.StartMaintenanceModeMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that maintenance mode was started ");

                #endregion Start Maintenance Mode

                #region Stop Maintenance Mode

                // click stop maintenance mode link
                TopMenuItems.ClickStopMaintenanceModeLink();

                // verify you are on the stop maintenance mode page
                _stopMaintenanceModePage.GetStopMaintenanceModePageHeading().Should().Be(_stopMaintenanceModePage.StopMaintenanceModePageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop maintenance mode page ");

                // click stop maintenance mode button
                _stopMaintenanceModePage.ClickStopMaintenanceModeButton();
                DebuggingHelpers.Logger().Info(" Clicked stop maintenance mode button ");

                string stopMaintenanceModeMessage = _stopMaintenanceModePage.GetStopMaintenanceModeMessage();

                // verify you are authorized to stop maintenance mode
                stopMaintenanceModeMessage.Should().NotBe(_stopMaintenanceModePage.StopMaintenanceModeUserNotAuthorizedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginAuthorizedToStartAndStopMaintenanceMode + " logged in and was authorized to stop maintenance mode ");

                // verify maintenance mode stopped
                stopMaintenanceModeMessage.Should().Be(_stopMaintenanceModePage.StopMaintenanceModeMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that maintenance mode was stopped ");

                #endregion Stop Maintenance Mode

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Start/Stop Maintenance Mode - Authorized test case ***");
            }
            catch
            {
                DebuggingHelpers.Logger().Info(" *** Test case ended with an error ***");
            }
            finally
            {
                // tear down and dispose
                TearDownAndDispose();
            }
        }

        [Fact]
        public void StartMaintenanceMode_UsingMcids_UserNotAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Start Maintenance Mode - Not Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with EdiLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLoginNotAuthorizedToStartOrStopMaintenanceMode);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // click start maintenance mode link
                TopMenuItems.ClickStartMaintenanceModeLink();

                // verify you are on the start maintenance mode page
                _startMaintenanceModePage.GetStartMaintenanceModePageHeading().Should().Be(_startMaintenanceModePage.StartMaintenanceModePageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded start maintenance mode page ");

                // click start maintenance mode button
                _startMaintenanceModePage.ClickStartMaintenanceModeButton();
                DebuggingHelpers.Logger().Info(" Clicked start maintenance mode button ");

                // verify you are not authorized to start maintenance mode
                _startMaintenanceModePage.GetStartMaintenanceModeAuthorizedMessage().Should().Be(_startMaintenanceModePage.StartMaintenanceModeUserNotAuthorizedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginNotAuthorizedToStartOrStopMaintenanceMode + " logged in but was not authorized to start maintenance mode ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Start Maintenance Mode - Not Authorized test case ***");
            }
            catch
            {
                DebuggingHelpers.Logger().Info(" *** Test case ended with an error ***");
            }
            finally
            {
                // tear down and dispose
                TearDownAndDispose();
            }
        }

        [Fact]
        public void StartMaintenanceMode_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Start Maintenance Mode - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click start maintenance mode link
                TopMenuItems.ClickStartMaintenanceModeLink();

                // verify you are on the start maintenance mode page
                _startMaintenanceModePage.GetStartMaintenanceModePageHeading().Should().Be(_startMaintenanceModePage.StartMaintenanceModePageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded start maintenance mode page ");

                // click start maintenance mode button
                _startMaintenanceModePage.ClickStartMaintenanceModeButton();
                DebuggingHelpers.Logger().Info(" Clicked start maintenance mode button ");

                // verify you are not logged in and cannot stop maintenance mode
                _startMaintenanceModePage.GetStartMaintenanceModeMessage().Should().Be(_startMaintenanceModePage.StartMaintenanceModeAccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to start maintenance mode ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Start Maintenance Mode - Not Logged In test case ***");
            }
            catch
            {
                DebuggingHelpers.Logger().Info(" *** Test case ended with an error ***");
            }
            finally
            {
                // tear down and dispose
                TearDownAndDispose();
            }
        }

        [Fact]
        public void StopMaintenanceMode_UsingMcids_UserNotAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Stop MCIDS Stop Maintenance Mode - Not Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with EdiLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLoginNotAuthorizedToStartOrStopMaintenanceMode);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // click stop maintenance mode link
                TopMenuItems.ClickStopMaintenanceModeLink();

                // verify you are on the stop maintenance mode page
                _stopMaintenanceModePage.GetStopMaintenanceModePageHeading().Should().Be(_stopMaintenanceModePage.StopMaintenanceModePageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded stop maintenance mode page ");

                // click stop maintenance mode button
                _stopMaintenanceModePage.ClickStopMaintenanceModeButton();
                DebuggingHelpers.Logger().Info(" Clicked stop maintenance mode button ");

                // verify you are not authorized to stop maintenance mode
                _stopMaintenanceModePage.GetStopMaintenanceModeMessage().Should().Be(_stopMaintenanceModePage.StopMaintenanceModeUserNotAuthorizedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified that " + ediLoginNotAuthorizedToStartOrStopMaintenanceMode + " logged in but was not authorized to stop maintenance mode for " + moduleName + " ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Stop Maintenance Mode - Not Authorized test case ***");
            }
            catch
            {
                DebuggingHelpers.Logger().Info(" *** Test case ended with an error ***");
            }
            finally
            {
                // tear down and dispose
                TearDownAndDispose();
            }
        }

        [Fact]
        public void StopMaintenanceMode_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Stop MCIDS Stop Maintenance Mode - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click stop maintenance mode link
                TopMenuItems.ClickStopMaintenanceModeLink();

                // verify you are on the stop maintenance mode page
                _stopMaintenanceModePage.GetStopMaintenanceModePageHeading().Should().Be(_stopMaintenanceModePage.StopMaintenanceModePageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " Stop Maintenance Mode page ");

                // click stop maintenance mode button
                _stopMaintenanceModePage.ClickStopMaintenanceModeButton();
                DebuggingHelpers.Logger().Info(" Clicked stop maintenance mode button ");

                // verify you are not logged in and cannot stop maintenance mode
                _stopMaintenanceModePage.GetStopMaintenanceModeMessage().Should().Be(_stopMaintenanceModePage.StopMaintenanceModeAccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to stop maintenance mode ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Stop Maintenance Mode - Not Logged In test case ***");
            }
            catch
            {
                DebuggingHelpers.Logger().Info(" *** Test case ended with an error ***");
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