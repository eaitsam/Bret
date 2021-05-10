using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedchartSeleniumAutomationCore.Core_PageObjects
{
    public class MiscPageOjects
    {

        #region Logout
        public By LogoutButton => By.Id("FixedLogout");
        public By LogoutLinkToSystem => By.XPath("/html/body/form/div[5]/div/div/div/div[2]/p[2]/a");
        public By ClickHereLogoutLink => By.LinkText("click here");

        #endregion

        #region Homepage
        public By MyAccountLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_MyAccountHyperLink");
        public By ManageUsersLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_ManageUsersHyperLink");

        #endregion

        public By WaitingAnimationDiv => By.Id("waitDiv");
        public By uiwidget => By.CssSelector("ui-widget-overlay ui-front");

        public By DynamSoftAnimation => By.ClassName("dynamsoft-backdrop");
        public By UpdatingpermmodalAnimation => By.ClassName("jqUpdatingModalDialog ui-dialog-content ui-widget-content");
    }
}
