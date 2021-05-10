using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public class LoggedOutPage
    {
        private readonly string _clientId;

        public LoggedOutPage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By LoggedOutPageHeading => By.Id("loggedOutPageHeading");

        #endregion By Elements

        #region String Elements

        public string LoggedOutPageHeadingActual => "You are now logged out from " + _clientId + '.';

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public string GetLoggedOutPageHeading() => UIActions.GetElement(LoggedOutPageHeading).Text;

        #endregion Page Methods
    }
}