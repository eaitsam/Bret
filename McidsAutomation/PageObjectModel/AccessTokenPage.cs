using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System.Linq;

namespace McidsAutomation.PageObjectModel
{
    public class AccessTokenPage
    {
        private readonly string _clientId;

        public AccessTokenPage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By AccessTokenLink => By.Id("accessTokenLink");
        private By AccessTokenMessage => By.Id("accessTokenMessage");
        private By AccessTokenPageHeading => By.Id("accessTokenPageHeading");

        #endregion By Elements

        #region String Elements

        public string AccessTokenPageHeadingActual => "Access Token - " + _clientId;
        public string AccessTokenNotAuthorizedMessageActual => "You are not authorized!!!";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public void ClickAccessTokenLink() => UIActions.ClickElement(AccessTokenLink);

        public string GetAccessTokenMessage() => UIActions.GetAllElements(AccessTokenMessage).ElementAt(0).Text;

        public string GetAccessTokenPageHeading() => UIActions.GetElement(AccessTokenPageHeading).Text;

        #endregion Page Methods
    }
}