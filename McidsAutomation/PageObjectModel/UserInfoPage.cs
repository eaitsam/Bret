using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System.Linq;

namespace McidsAutomation.PageObjectModel
{
    public class UserInfoPage
    {
        private readonly string _clientId;

        public UserInfoPage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By AccessDeniedMessage => By.Id("userInfoResults");

        private By TableElement => By.TagName("table");
        private By UserInfoPageHeading => By.Id("userInfoPageHeading");

        private By UserRolesExists => By.XPath("//tr[@id='role']/td[2]");

        #endregion By Elements

        #region String Elements

        public string AccessDeniedMessageActual => "Access Denied.";
        public string UserInfoPageHeadingActual => "User Info - " + _clientId;

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public bool DoUserRolesExists() => UIActions.GetElement(UserRolesExists).IsDisplayed();

        public string GetAccessDeniedMessage() => UIActions.GetElement(AccessDeniedMessage).Text;

        public string GetUserInfoPageHeading() => UIActions.GetElement(UserInfoPageHeading).Text;

        public bool TableElementExists() => UIActions.GetElement(TableElement).IsDisplayed();

        #endregion Page Methods
    }
}