using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;
using McidsAutomation.PageObjectModel;
using FluentAssertions;
using OpenQA.Selenium;
using System.Linq;
using MedchartSeleniumAutomationCore.Core_Framework;
using System;

namespace McidsAutomation
{
    public class SingleSignOn
    {
        private readonly Configurations _config;

        private readonly GatewayApiPage _weatherApiPageMrr;
        private readonly HomePage _homePageMrr;
        private readonly LoggedInPage _loggedInPageMrr;
        private readonly UserInfoPage _userInfoPageMrr;
        private readonly string _webSiteUrlMrr;

        private readonly GatewayApiPage _weatherApiPageAvs;
        private readonly HomePage _homePageAvs;
        private readonly LoggedInPage _loggedInPageAvs;
        private readonly UserInfoPage _userInfoPageAvs;
        private readonly string _webSiteUrlAvs;

        private readonly string _mcidsWebsiteUrl;
        private readonly BaseDriverInit _webDriver;

        private const string ediLogin = "1404485081";
        private const string moduleNameFirstSignOn = "MRR";
        private const string moduleNameSecondSignOn = "AVS";

        public SingleSignOn()
        {
            _config = new Configurations();
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _webDriver = new BaseDriverInit();

            _weatherApiPageMrr = new GatewayApiPage(moduleNameFirstSignOn);
            _homePageMrr = new HomePage(moduleNameFirstSignOn);
            _loggedInPageMrr = new LoggedInPage(moduleNameFirstSignOn);
            _userInfoPageMrr = new UserInfoPage(moduleNameFirstSignOn);
            _webSiteUrlMrr = _config.GetConfigValue("MRRWebsiteUrl");

            _weatherApiPageAvs = new GatewayApiPage(moduleNameSecondSignOn);
            _homePageAvs = new HomePage(moduleNameSecondSignOn);
            _loggedInPageAvs = new LoggedInPage(moduleNameSecondSignOn);
            _userInfoPageAvs = new UserInfoPage(moduleNameSecondSignOn);
            _webSiteUrlAvs = _config.GetConfigValue("AVSWebsiteUrl");
        }

        [Fact]
        public void SingleSignOn_UsingMcids_WithTwoClientApps()
        {
            
          
            
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Single Sign-on test case ");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrlMrr);

                // verify home page content for MRR
                VerifyHomePageContentMrr(_homePageMrr.GetBodyText(), moduleNameFirstSignOn);

                #region Access Denied to MRR (moduleNameFirstSignOn)

                // click user info link for MRR
                TopMenuItems.ClickUserInfoLink();

                // verify you are on the user info page for MRR
                _userInfoPageMrr.GetUserInfoPageHeading().Should().Be(_userInfoPageMrr.UserInfoPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleNameFirstSignOn + " user info page ");

                // verify user info access denied for MRR
                _userInfoPageMrr.GetAccessDeniedMessage().Should().Be(_userInfoPageMrr.AccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified " + moduleNameFirstSignOn + " access denied to user info page ");

                // click gateway weather api link for MRR
                TopMenuItems.ClickGatewayApiLink();

                // verify you are on the gateway weather api page for MRR
                _weatherApiPageMrr.GetWeatherApiPageHeading().Should().Be(_weatherApiPageMrr.WeatherApiPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleNameFirstSignOn + " gateway weather API page ");

                // verify gateway weather api access denied for MRR
                _weatherApiPageMrr.GetWeatherApiResults().Should().Be(_weatherApiPageMrr.AccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified access denied for " + moduleNameFirstSignOn + " gateway weather API page ");

                // open a new tab for AVS
                var driver = ObjectRepository.Driver;
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                DebuggingHelpers.Logger().Info(" Opened a new tab for " + moduleNameSecondSignOn + " ");

                // navigate to new AVS tab
                driver.Navigate().GoToUrl(_webSiteUrlAvs);
                DebuggingHelpers.Logger().Info(" Navigated to new tab for " + moduleNameSecondSignOn + " ");

                #endregion Access Denied to MRR (moduleNameFirstSignOn)

                #region Access Denied to AVS (moduleNameSecondSignOn)

                // verify home page content for AVS
                VerifyHomePageContentAvs(_homePageAvs.GetBodyText(), moduleNameSecondSignOn);

                // click user info link for AVS
                TopMenuItems.ClickUserInfoLink();

                // verify you are on the user info page for AVS
                _userInfoPageAvs.GetUserInfoPageHeading().Should().Be(_userInfoPageAvs.UserInfoPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleNameFirstSignOn + " user info page ");

                // verify access denied for AVS
                _userInfoPageAvs.GetAccessDeniedMessage().Should().Be(_userInfoPageAvs.AccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified access denied for " + moduleNameSecondSignOn + " user info page ");

                // click gateway weather api link for AVS
                TopMenuItems.ClickGatewayApiLink();

                // verify you are on the gateway weather api page for AVS
                _weatherApiPageAvs.GetWeatherApiPageHeading().Should().Be(_weatherApiPageAvs.WeatherApiPageHeadingActual);

                // verify access denied for AVS
                _weatherApiPageAvs.GetWeatherApiResults().Should().Be(_weatherApiPageAvs.AccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified access denied for " + moduleNameSecondSignOn + " gateway weather API page ");

                // click login link for AVS
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page for AVS
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // use MCIDS to login to AVS
                McidsLoginPage.EnterEdiAndSubmit(ediLogin);

                // verify you are on the logged in page for AVS
                _loggedInPageAvs.GetLoggedInPageHeading().Should().Be(_loggedInPageAvs.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleNameSecondSignOn + " ");

                #endregion Access Denied to AVS (moduleNameSecondSignOn)

                #region Log into to AVS (moduleNameSecondSignOn)

                // click user info link for AVS
                TopMenuItems.ClickUserInfoLink();
                _userInfoPageAvs.GetUserInfoPageHeading().Should().Be(_userInfoPageAvs.UserInfoPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleNameSecondSignOn + " user info page ");

                // verify access is no longer denied for AVS
                _userInfoPageAvs.GetAccessDeniedMessage().Should().NotBe(_userInfoPageAvs.AccessDeniedMessageActual);
                _userInfoPageAvs.TableElementExists().Should().BeTrue();
                DebuggingHelpers.Logger().Info(" Verified access to user info in " + moduleNameSecondSignOn + " ");

                #endregion Log into to AVS (moduleNameSecondSignOn)

                #region Access Approved for AVS (moduleNameSecondSignOn)

                // click gateway weather api link for AVS
                TopMenuItems.ClickGatewayApiLink();
                _weatherApiPageAvs.GetWeatherApiPageHeading().Should().Be(_weatherApiPageAvs.WeatherApiPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleNameSecondSignOn + " gateway weather API page ");

                // verify access is no longer denied for AVS
                _weatherApiPageAvs.GetWeatherApiResults().Should().NotBe(_weatherApiPageAvs.AccessDeniedMessageActual);

                // verify weather forecast data is displayed for AVS
                _weatherApiPageAvs.GetWeatherApiResults().Should().Contain("temperatureF");
                DebuggingHelpers.Logger().Info(" Verified access to weather forecast data for " + moduleNameSecondSignOn + " ");

                #endregion Access Approved for AVS (moduleNameSecondSignOn)

                #region Access Approved for MRR (moduleNameFirstSignOn)

                // switch back to MRR site
                driver.SwitchTo().Window(driver.WindowHandles.First());

                // verify you are on the login page for MRR
                driver.Url.Should().Contain(_webSiteUrlMrr);
                DebuggingHelpers.Logger().Info(" Switched back to " + moduleNameFirstSignOn + " site tab ");

                // click login link for MRR
                TopMenuItems.ClickLoginLink();

                // verify user is logged in automatically for MRR
                _loggedInPageMrr.GetLoggedInPageHeading().Should().Be(_loggedInPageMrr.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Verified user logged into " + moduleNameFirstSignOn + " automatically without asking for EDI ");

                // click user info link for MRR
                TopMenuItems.ClickUserInfoLink();

                // verify user info is displayed in a table for MRR
                _userInfoPageMrr.TableElementExists().Should().BeTrue();
                DebuggingHelpers.Logger().Info(" Loaded " + moduleNameFirstSignOn + " user info page ");

                // verify access is no longer denied for MRR
                _userInfoPageMrr.GetAccessDeniedMessage().Should().NotBe(_userInfoPageMrr.AccessDeniedMessageActual);
                DebuggingHelpers.Logger().Info(" Verified access to user info in " + moduleNameFirstSignOn + " ");

                // click gateway weather api link for MRR
                TopMenuItems.ClickGatewayApiLink();

                // verify weather forecast data is displayed for MRR
                _weatherApiPageMrr.GetWeatherApiPageHeading().Should().Be(_weatherApiPageMrr.WeatherApiPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Loaded " + moduleNameFirstSignOn + " gateway weather API page ");

                // verify access is no longer denied for MRR
                _weatherApiPageMrr.GetWeatherApiResults().Should().NotBe(_weatherApiPageMrr.AccessDeniedMessageActual);

                // verify weather forecast data is displayed for MRR
                _weatherApiPageMrr.GetWeatherApiResults().Should().Contain("temperatureF");
                DebuggingHelpers.Logger().Info(" Verified access to weather forecast data for " + moduleNameFirstSignOn + " ");

                #endregion Access Approved for MRR (moduleNameFirstSignOn)

                // click logout link for MRR and AVS
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleNameFirstSignOn + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Single Sign-on test case ");
            }
            catch (Exception ex)
            {
                DebuggingHelpers.Logger().Error("Error: " + ex.Message);

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

        private void VerifyHomePageContentMrr(string homePageBodyText, string moduleName)
        {
            homePageBodyText.Should().Contain(_homePageMrr.BodyTextActual);
            homePageBodyText.Should().Contain(_homePageMrr.TestOnlyMessageActual);
            homePageBodyText.Should().Contain(_homePageMrr.DescriptionActual);
            DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " Home page ");
        }

        private void VerifyHomePageContentAvs(string homePageBodyText, string moduleName)
        {
            homePageBodyText.Should().Contain(_homePageAvs.BodyTextActual);
            homePageBodyText.Should().Contain(_homePageAvs.TestOnlyMessageActual);
            homePageBodyText.Should().Contain(_homePageAvs.DescriptionActual);
            DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " Home page ");
        }

        #endregion Private Methods
    }
}