using FluentAssertions;
using McidsAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace McidsAutomation
{
    public class AccessToken
    {
        private readonly AccessTokenPage _accessTokenPage;
        private readonly Configurations _config;
        private readonly HomePage _homePage;
        private readonly LoggedInPage _loggedInPage;
        private readonly string _mcidsWebsiteUrl;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;

        private const string ediLogin = "9990009999";
        private const string moduleName = "MRR";

        public AccessToken()
        {
            _accessTokenPage = new AccessTokenPage(moduleName);
            _config = new Configurations();
            _homePage = new HomePage(moduleName);
            _loggedInPage = new LoggedInPage(moduleName);
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("MRRWebsiteUrl");
        }

        [Fact]
        public void GetAccessToken_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Access Token - Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page conten
                VerifyHomePageContent(_homePage.GetBodyText());

                // click login link
                TopMenuItems.ClickLoginLink();
                DebuggingHelpers.Logger().Info(" Clicked " + moduleName + " login link ");

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // login with ediLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLogin);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // click link to go to access token page
                _accessTokenPage.ClickAccessTokenLink();
                DebuggingHelpers.Logger().Info(" Clicked access token link ");

                // verify you are on the access token page
                _accessTokenPage.GetAccessTokenPageHeading().Should().Be(_accessTokenPage.AccessTokenPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded access token page ");

                // verify you are authorized to view access token
                string accessTokenAuthorizedMessage = _accessTokenPage.GetAccessTokenMessage();
                accessTokenAuthorizedMessage.Should().NotBe(_accessTokenPage.AccessTokenNotAuthorizedMessageActual);
                accessTokenAuthorizedMessage.Should().NotBe("");
                DebuggingHelpers.Logger().Info(" Verified that " + ediLogin + " logged into " + moduleName + " and was authorized to view access token ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Access Token - Authorized test case ***");
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
        public void GetAccessToken_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Access Token - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent(_homePage.GetBodyText());

                // click link to go to access token page
                _accessTokenPage.ClickAccessTokenLink();
                DebuggingHelpers.Logger().Info(" Clicked access token link ");

                // verify you are on the access token page
                _accessTokenPage.GetAccessTokenPageHeading().Should().Be(_accessTokenPage.AccessTokenPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded access token page ");

                // verify you are not logged in and cannot view access token
                string accessTokenNotAuthorizedMessage = _accessTokenPage.GetAccessTokenMessage();
                accessTokenNotAuthorizedMessage.Should().Be(_accessTokenPage.AccessTokenNotAuthorizedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to view access token ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Access Token - Not Logged In test case ***");
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