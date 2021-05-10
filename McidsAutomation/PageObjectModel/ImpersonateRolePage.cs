using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System.Linq;

namespace McidsAutomation.PageObjectModel
{
    public class ImpersonateRolePage
    {
        private readonly string _clientId;

        public ImpersonateRolePage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By ImpersonatedRoledEdiTextBox => By.Id("RolesToImpersonate");
        private By ImpersonateRoleButton => By.Name("impersonateRole");
        private By ImpersonateRoleMessage => By.Id("impersonateRoleMessage");
        private By ImpersonateRolePageHeading => By.Id("impersonateRolePageHeading");
        private By Role => By.XPath("//tr[@id='role']/td[2]");

        #endregion By Elements

        #region String Elements

        public string ImpersonateRoleAccessDeniedMessageActual => "Access Denied.";
        public string ImpersonateRolePageHeadingActual => "Impersonate Role - " + _clientId;
        public string ImpersonateRoleNotAuthorizedMessageActual => "You are not authorized!!!";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public void EnterRoleToImpersonate(string edipin) => UIActions.TypeInTextBox(ImpersonatedRoledEdiTextBox, edipin);

        public void ClickImpersonateRoleButton() => UIActions.ClickElement(ImpersonateRoleButton);

        public string GetRoleAfterImpersonating() => UIActions.GetElement(Role).Text;

        public string GetImpersonateRoleMessage() => UIActions.GetAllElements(ImpersonateRoleMessage).ElementAt(0).Text;

        public string GetImpersonateRolePageHeading() => UIActions.GetElement(ImpersonateRolePageHeading).Text;

        #endregion Page Methods
    }
}