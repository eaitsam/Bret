using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public class LoggedInPage
    {
        private readonly string _clientId;

        public LoggedInPage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By LoggedInPageHeading => By.Id("loggedInPageHeading");

        #endregion By Elements

        #region String Elements

        public string LoggedInPageHeadingActual => "You are now logged in to " + _clientId + ".";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public string GetLoggedInPageHeading() => UIActions.GetElement(LoggedInPageHeading).Text;

        #endregion Page Methods
    }
}