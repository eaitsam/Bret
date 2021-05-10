using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public class HomePage
    {
        private readonly string _clientId;

        public HomePage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By PageBodyElement => By.TagName("body");

        #endregion By Elements

        #region String Elements

        public string BodyTextActual => "Client Module: " + _clientId;
        public string TestOnlyMessageActual => "For Testing Purposes ONLY!";
        public string DescriptionActual => "This is a test client application for Medchart IdentityServer (MCIDS).";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public string GetBodyText() => UIActions.GetElement(PageBodyElement).Text;

        #endregion Page Methods
    }
}