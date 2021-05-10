using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public class StartMaintenanceModePage
    {
        private readonly string _clientId;

        public StartMaintenanceModePage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By StartMaintenanceModeAuthorizedMessage => By.Id("startMaintenanceModeMessage");
        private By StartMaintenanceModeButton => By.Name("StartMaintenanceMode");
        private By StartMaintenanceModeMessage => By.Id("startMaintenanceModeMessage");
        private By StartMaintenanceModePageHeading => By.Id("startMaintenanceModePageHeading");

        #endregion By Elements

        #region String Elements

        public string StartMaintenanceModeMessageActual => "Maintenance mode started!!!";
        public string StartMaintenanceModePageHeadingActual => "Start Maintenance - " + _clientId;
        public string StartMaintenanceModeUserNotAuthorizedMessageActual => "You are not authorized!!!";
        public string StartMaintenanceModeAccessDeniedMessageActual => "Access Denied.";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public void ClickStartMaintenanceModeButton() => UIActions.ClickElement(StartMaintenanceModeButton);

        public string GetStartMaintenanceModeAccessDeniedMessage() => UIActions.GetElement(StartMaintenanceModeMessage).Text;

        public string GetStartMaintenanceModeAuthorizedMessage() => UIActions.GetElement(StartMaintenanceModeAuthorizedMessage).Text;

        public string GetStartMaintenanceModeMessage() => UIActions.GetElement(StartMaintenanceModeMessage).Text;

        public string GetStartMaintenanceModePageHeading() => UIActions.GetElement(StartMaintenanceModePageHeading).Text;

        #endregion Page Methods
    }
}