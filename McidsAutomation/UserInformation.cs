using FluentAssertions;
using McidsAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace McidsAutomation
{
    public class UserInformation
    {
        private readonly Configurations _config;
        private readonly HomePage _homePage;
        private readonly LoggedInPage _loggedInPage;
        private readonly string _mcidsWebsiteUrl;
        private readonly UserInfoPage _userInfoPage;
        private readonly BaseDriverInit _webDriver;
        private readonly string _webSiteUrl;

        private const string ediLogin = "1404485081";
        private const string moduleName = "MRR";

        public UserInformation()
        {
            _config = new Configurations();
            _homePage = new HomePage(moduleName);
            _loggedInPage = new LoggedInPage(moduleName);
            _mcidsWebsiteUrl = _config.GetConfigValue("McidsWebsiteUrl");
            _userInfoPage = new UserInfoPage(moduleName);
            _webDriver = new BaseDriverInit();
            _webSiteUrl = _config.GetConfigValue("MRRWebsiteUrl");
        }

        [Fact]
        public void UserInformation_UsingMcids_UserAuthorized()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Get User Information - Authorized test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent();

                // click login link
                TopMenuItems.ClickLoginLink();

                // verify you are on the login page
                var driver = ObjectRepository.Driver;
                driver.Url.Should().Contain(_mcidsWebsiteUrl);

                // use MCIDS to login with ediLogin
                McidsLoginPage.EnterEdiAndSubmit(ediLogin);

                // verify you are on the logged in page
                _loggedInPage.GetLoggedInPageHeading().Should().Be(_loggedInPage.LoggedInPageHeadingActual);
                DebuggingHelpers.Logger().Info(" Logged into " + moduleName + " ");

                // click user info link
                TopMenuItems.ClickUserInfoLink();

                // verify you are on the user info page
                _userInfoPage.GetUserInfoPageHeading().Should().Be(_userInfoPage.UserInfoPageHeadingActual);

                // verify access is not denied
                _userInfoPage.GetAccessDeniedMessage().Should().NotBe(_userInfoPage.AccessDeniedMessageActual);

                // verify that a table that holds user information is present and that the role information is present
                _userInfoPage.TableElementExists().Should().BeTrue();
                _userInfoPage.DoUserRolesExists().Should().BeTrue();
                DebuggingHelpers.Logger().Info(" Verified access to user info ");

                // click logout link
                TopMenuItems.ClickLogoutLink();
                DebuggingHelpers.Logger().Info(" Logged out of " + moduleName + " ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Get User Information - Authorized test case ***");
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
        public void UserInformation_UsingMcids_UserNotLoggedIn()
        {
            try
            {
                DebuggingHelpers.Logger().Info(" *** Start MCIDS Get User Information - Not Logged In test case ***");
                _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _webSiteUrl);

                // verify home page content
                VerifyHomePageContent();

                // click user info link
                TopMenuItems.ClickUserInfoLink();

                // verify you are on the user info page
                _userInfoPage.GetUserInfoPageHeading().Should().Be(_userInfoPage.UserInfoPageHeadingActual);

                // verify you are not logged in and do not have access to view user information
                _userInfoPage.GetAccessDeniedMessage().Should().Be(_userInfoPage.AccessDeniedMessageActual);

                // verify that a table that holds user information is present and that the role information is present
                _userInfoPage.TableElementExists().Should().BeTrue();
                _userInfoPage.DoUserRolesExists().Should().BeTrue();
                DebuggingHelpers.Logger().Info(" Verified not logged in and do not have access to user info ");

                DebuggingHelpers.Logger().Info(" *** End MCIDS Get User Information - Not Logged In test case ***");
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

        private void VerifyHomePageContent()
        {
            string homePageBodyText = _homePage.GetBodyText();
            homePageBodyText.Should().Contain(_homePage.BodyTextActual);
            homePageBodyText.Should().Contain(_homePage.TestOnlyMessageActual);
            homePageBodyText.Should().Contain(_homePage.DescriptionActual);
            DebuggingHelpers.Logger().Info(" Loaded " + moduleName + " home page ");
        }

        #endregion Private Methods
    }
}