using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public class StopMaintenanceModePage
    {
        private readonly string _clientId;

        public StopMaintenanceModePage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By StopMaintenanceModeButton => By.Name("StopMaintenanceMode");
        private By StopMaintenanceModeMessage => By.Id("stopMaintenanceModeMessage");
        private By StopMaintenanceModePageHeading => By.Id("stopMaintenanceModePageHeading");

        #endregion By Elements

        #region String Elements

        public string StopMaintenanceModeMessageActual => "Maintenance mode stopped!!!";
        public string StopMaintenanceModePageHeadingActual => "Stop Maintenance - " + _clientId;
        public string StopMaintenanceModeUserNotAuthorizedMessageActual => "You are not authorized!!!";
        public string StopMaintenanceModeAccessDeniedMessageActual => "Access Denied.";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public void ClickStopMaintenanceModeButton() => UIActions.ClickElement(StopMaintenanceModeButton);

        public string GetStopMaintenanceModeMessage() => UIActions.GetElement(StopMaintenanceModeMessage).Text;

        public string GetStopMaintenanceModePageHeading() => UIActions.GetElement(StopMaintenanceModePageHeading).Text;

        #endregion Page Methods
    }
}