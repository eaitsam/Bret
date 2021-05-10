using OpenQA.Selenium;
using System.Threading;
using MedchartSeleniumAutomationCore.Core_Framework;

namespace EmmpsAutomation.PageObjectModel.Usermanagement
{
    public class ManageUsersPage
    {
        #region Page Objects
        
        //---------------------------------
        //My LODs Search and Filter Objects
        //---------------------------------
        //--HTMLComboBox--//
        public By OrganazitionComboBox => By.Id("MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList");
       
        //--Hyperlinks and Buttons--//
        public By ManageUserLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_ManageUsersHyperLink");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_StartSearch");
        public By FirstSearchResultRecord => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[3]/div/div[2]/div/table/tbody/tr[2]/td[9]/a ");
        public By UserDetailsButton => By.Id("MEDCHARTContent_MedchartPagesContent_GetUserDetailsButton");


        //--TextBoxes--//
        public By EdipinTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_EdipnTextBox");


        #endregion Page Objects
               

        public void ClickOnManageUsersLink()
        {
            UIActions.JSClickElement(ManageUserLink);
            Thread.Sleep(5000);

        }

        public void EnterEdipinTextbox(string edipin)
        {
            Thread.Sleep(3000);
            UIActions.TypeInTextBox(EdipinTextbox, edipin);
            Thread.Sleep(2000);
        }

        public void SelectOrganizationdropdown(string organization)
        {
            UIActions.SelectElementByText(OrganazitionComboBox, organization);

        }

        public void ClickSearchButton()
        {
            UIActions.JSClickElement(SearchButton);
            Thread.Sleep(3000);
        }

        public void SelectFirstRecordSearchResults()
        {
            UIActions.JSClickElement(FirstSearchResultRecord);
            Thread.Sleep(3000);
        }

        public void ClickUserDetailsButton()
        {
            UIActions.JSClickElement(UserDetailsButton);
            Thread.Sleep(3000);
        }


    }
}
