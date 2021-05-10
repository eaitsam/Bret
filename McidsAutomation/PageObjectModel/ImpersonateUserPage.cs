using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System.Linq;

namespace McidsAutomation.PageObjectModel
{
    public class ImpersonateUserPage
    {
        private readonly string _clientId;

        public ImpersonateUserPage(string clientId)
        {
            _clientId = clientId;
        }

        #region Page Objects

        #region By Elements

        private By ImpersonatedUserEdiTextBox => By.Id("ImpersonatedUserEdi");
        private By ImpersonateUserButton => By.Name("impersonateUser");
        private By ImpersonateUserMessage => By.Id("impersonateUserMessage");
        private By ImpersonateUserPageHeading => By.Id("impersonateUserPageHeading");
        private By Role => By.XPath("//tr[@id='role']/td[2]");

        #endregion By Elements

        #region String Elements

        public string ImpersonateUserAccessDeniedMessageActual => "Access Denied.";
        public string ImpersonateUserPageHeadingActual => "Impersonate User - " + _clientId;
        public string ImpersonateUserNotAuthorizedMessageActual => "You are not authorized!!!";

        #endregion String Elements

        #endregion Page Objects

        #region Page Methods

        public void EnterEdiToImpersonate(string edipin) => UIActions.TypeInTextBox(ImpersonatedUserEdiTextBox, edipin);

        public void ClickImpersonateUserButton() => UIActions.ClickElement(ImpersonateUserButton);

        public string GetRoleAfterImpersonating() => UIActions.GetElement(Role).Text;

        public string GetRoleBeforeImpersonating() => UIActions.GetElement(Role).Text;

        public string GetImpersonateUserMessage() => UIActions.GetAllElements(ImpersonateUserMessage).ElementAt(0).Text;

        public string GetImpersonateUserPageHeading() => UIActions.GetElement(ImpersonateUserPageHeading).Text;

        #endregion Page Methods
    }
}