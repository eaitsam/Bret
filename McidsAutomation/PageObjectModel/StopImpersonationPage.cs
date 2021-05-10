using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public class StopImpersonationPage
    {
        private readonly string _clientId;

        public StopImpersonationPage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By StopImpersonationButton => By.Name("stopImpersonation");
        private By StopImpersonationMessage => By.Id("stopImpersonationMessage");
        private By StopImpersonationPageHeading => By.Id("stopImpersonationPageHeading");

        #endregion By Elements

        #region String Elements

        public string StopImpersonationPageHeadingActual => "Stop Impersonation - " + _clientId;
        public string StopImpersonationMessageActual => "Stop Impersonation - " + _clientId;
        public string StopImpersonationAccessDeniedMessageActual => "Access Denied.";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public void ClickStopImpersonationButton() => UIActions.ClickElement(StopImpersonationButton);

        public string GetStopImpersonationMessage() => UIActions.GetElement(StopImpersonationMessage).Text;

        public string GetStopImpersonationPageHeading() => UIActions.GetElement(StopImpersonationPageHeading).Text;

        #endregion Page Methods
    }
}