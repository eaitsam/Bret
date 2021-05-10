using FluentAssertions;
using McidsAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace McidsAutomation
{
    public class GatewayApi
    {
        private readonly Configurations _config;
        private readonly HomePage _homePage;
        private readonly LoggedInPage _loggedInPage;
        private readonly string _mcidsWebsiteUrl;
        private readonly GatewayApiPage _weatherApiPage;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;

        private const string ediLogin = "1404485081";
        private const string moduleName = "MRR";

        public GatewayApi()
        {
            _config = new Configurations();
            _homePage = new HomePage(moduleName);
            _loggedInPage = new LoggedInPage(moduleName);
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _weatherApiPage = new GatewayApiPage(moduleName);
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("MRRWebsiteUrl");
        }

        [Fact]
        public void LoadWeatherApi_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Weather API - Authorized test case ***");
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

                // click link to go to weather API page
                _weatherApiPage.ClickWeatherApiLink();
                DebuggingHelpers.Logger().Info(" Clicked weather API link ");

                // verify you are on the weather API page
                _weatherApiPage.GetWeatherApiPageHeading().Should().Be(_weatherApiPage.WeatherApiPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded weather API page ");

                // verify you are authorized to view weather API results
                string accessTokenAuthorizedMessage = _weatherApiPage.GetWeatherApiResults();
                accessTokenAuthorizedMessage.Should().NotBe(_weatherApiPage.AccessDeniedMessageActual);
                accessTokenAuthorizedMessage.Should().NotBe("");
                DebuggingHelpers.Logger().Info(" Verified authorized to view weather API results ");

                DebuggingHelpers.Logger().Info(" Verified that " + ediLogin + " logged into " + moduleName + " and was authorized to go to weather API page and view results");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Weather API - Authorized test case ***");
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
        public void LoadWeatherApi_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Weather API - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page conten
                VerifyHomePageContent(_homePage.GetBodyText());

                // click link to go to weather API page
                _weatherApiPage.ClickWeatherApiLink();
                DebuggingHelpers.Logger().Info(" Clicked weather API link ");

                // verify you are on the weather API page
                _weatherApiPage.GetWeatherApiPageHeading().Should().Be(_weatherApiPage.WeatherApiPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded weather API page ");

                // verify you are not logged in and cannot view weather API results
                string weatherApiAuthorizedMessage = _weatherApiPage.GetWeatherApiResults();
                weatherApiAuthorizedMessage.Should().Be(_weatherApiPage.AccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to go to weather API page and view results");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Weather API - Not Logged In test case ***");
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