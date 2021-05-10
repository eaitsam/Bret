using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System.Configuration;
using Xunit;

namespace FrameworkAutomation.PageObjectModel
{
    public class Homepage
    {
        #region PageObjects
        public string HomepageUrl = ConfigurationManager.AppSettings["Website"];
        public By MyAccountLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_MyAccountHyperLink");
        public By ManageUsersLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_ManageUsersHyperLink");
        public By ImpersonateRoleLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_ImpersonateRoleHyperLink");
        public By LookupUICLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_UICLookupLink");
        public By LookupSMLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_SMLookupHyperLink");
        public By CreateNewCaseLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_4_CreateNewCaseHyperLink");
        public By ContactUsLink => By.Id("ContactUsMenu");
        public By LogoutLink => By.Id("FixedLogout");
        public By PageTitle => By.Id("MedchartPageTitle");
        public By ManageUsersPageTitle => By.XPath("//div[contains(text(), 'Manage Active Users')]");
        public By LookupUICPageTitle => By.XPath("//div[contains(text(), 'Lookup UIC')]");
        public By LookupSMPageTitle => By.XPath("//div[contains(text(), 'Lookup SM')]");
        public By CreateCasePageTitle => By.XPath("//div[contains(text(), 'Create Case')]");
        public By AdminLink => By.CssSelector("#MasterMenun11 > table:nth-child(1) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > a:nth-child(1)");
        public By UserManagementLink => By.XPath("//a[contains(text(), 'User Management')]");
        public By ManageAllUsersLink => By.XPath("//*[@id='MasterMenun12']/td/table/tbody/tr/td/a");
        public By SystemMessagesGrid => By.Id("systemMessageGrid");
        public By SystemMessageClass => By.ClassName("SystemMessage");
        public By UserBandwidthLink => By.XPath("//*[@id='MasterMenun18']/td/table/tbody/tr/td/a");
        public By UserLookUpLink => By.Id("MasterMenun13");
        public By AdminDropdown => By.XPath("/html/body/form/div[3]/div[2]/div/div/div[1]/table/tbody");
        #endregion
        #region Page Methods
        public void SelectMEDCHARTTileLink(string link)
        {
            switch (link)
            {
                case "Manage Users":
                    {
                        UIActions.JSClickElement(ManageUsersLink);
                        WaitMethods.WaitForPageToLoad(60);
                        break;
                    }
                case "My Account":
                    {
                        UIActions.JSClickElement(MyAccountLink);
                        break;
                    }
                case "Lookup SM":
                    {
                        UIActions.JSClickElement(LookupSMLink);
                        WaitMethods.WaitForPageToLoad(60);
                        break;
                    }
                case "Lookup UIC":
                    {
                        UIActions.JSClickElement(LookupUICLink);
                        WaitMethods.WaitForPageToLoad(60);
                        break;
                    }
                case "Create a New Case":
                    {
                        UIActions.JSClickElement(CreateNewCaseLink);
                        WaitMethods.WaitForPageToLoad(60);
                        break;
                    }
                default:
                    {
                        //Assert.Fail("Invalid link name");
                        break;
                    }
            }
        }

        #endregion
    }
}
