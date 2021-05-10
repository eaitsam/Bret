using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public static class TopMenuItems
    {
        #region Page Objects

        #region By Elements

        private static By GatewayApiLink => By.Id("callGatewayLink");
        private static By HomeLink => By.Id("homeLink");
        private static By LoginLink => By.Id("loginLink");
        private static By LogoutLink => By.Id("logoutLink");
        private static By ImpersonateRoleLink => By.Id("impersonateRoleLink");
        private static By ImpersonateUserLink => By.Id("impersonateUserLink");
        private static By StartMaintenanceModeLink => By.Id("startMaintenanceModeLink");
        private static By StopImpersonationLink => By.Id("stopImpersonationLink");
        private static By StopMaintenanceModeLink => By.Id("stopMaintenanceModeLink");
        private static By UserInfoLink => By.Id("userInfoLink");

        #endregion By Elements

        #endregion Page Objects

        #region Page Methods

        public static void ClickGatewayApiLink() => UIActions.ClickElement(GatewayApiLink);

        public static void ClickHomeLink() => UIActions.ClickElement(HomeLink);

        public static void ClickImpersonateRoleLink() => UIActions.ClickElement(ImpersonateRoleLink);

        public static void ClickImpersonateUserLink() => UIActions.ClickElement(ImpersonateUserLink);

        public static void ClickLoginLink() => UIActions.ClickElement(LoginLink);

        public static void ClickLogoutLink() => UIActions.ClickElement(LogoutLink);

        public static void ClickStartMaintenanceModeLink() => UIActions.ClickElement(StartMaintenanceModeLink);

        public static void ClickStopImpersonationLink() => UIActions.ClickElement(StopImpersonationLink);

        public static void ClickStopMaintenanceModeLink() => UIActions.ClickElement(StopMaintenanceModeLink);

        public static void ClickUserInfoLink() => UIActions.ClickElement(UserInfoLink);

        #endregion Page Methods
    }
}