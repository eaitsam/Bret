using MedchartSeleniumAutomationCore.Core_Framework;
using Xunit;
using OpenQA.Selenium;
using System;
using System.Threading;
using FluentAssertions;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class StartNewAdopPage
    {
        #region Page Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//
        #region Text Boxes
        public By SsnBox = By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SSNText");
        public By MemberUic = By.Id("MEDCHARTContent_EmmpsContent_MemberUicTextbox");
        #endregion
        #region Buttons 
        //public By SearchButton = By.Id("MEDCHARTContent_EmmpsContent_FindSsnButton");

        public By SearchButton = By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SearchButton");
        public By CreateADOPButton = By.Id("MEDCHARTContent_EmmpsContent_CreateAdopArDoDIButton");
        public By StartOverDodiADOPButton = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonDodiStartOver");
        public By VerifyUicButton = By.Id("MEDCHARTContent_EmmpsContent_VerifyButton");
        #endregion
        #region DropDowns
        public By SruDutyStatus = By.Id("MEDCHARTContent_EmmpsContent_DropDownListSruDutyStatus");
        public By WorkflowDropDownBox = By.Id("MEDCHARTContent_EmmpsContent_WorkflowDropDownList");
        public By Region = By.Id("MEDCHARTContent_EmmpsContent_RegionDropDownList");
        public By Rank = By.Id("MEDCHARTContent_EmmpsContent_RankDropDownList");

        #endregion
        #region Checkboxes
        public By CreateAdop = By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_75_eMMPS_PermissionGroup_75_PermissionCheckBoxesDataList_PermissionCheckBox_3");
        public By AdopSruDraft = By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_75_eMMPS_PermissionGroup_75_PermissionCheckBoxesDataList_PermissionCheckBox_1");
        public By AdopUsarDraft = By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_75_eMMPS_PermissionGroup_75_PermissionCheckBoxesDataList_PermissionCheckBox_5");
        #endregion
        #region Html-Pane
        public By ADOPpermissionTab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_75");
        #endregion

        #region Page Methods
        public void SoldierSSNSearch(string SSN)
        {
            UIActions.TypeInTextBox(SsnBox, SSN);
            UIActions.JSClickElement(SearchButton);
            Thread.Sleep(9000);
        }

        

        public void EnterUIC(string UIC)
        {
            UIActions.ClearTextBox(MemberUic);
            UIActions.TypeInTextBox(MemberUic, UIC);
            UIActions.JSClickElement(VerifyUicButton);
            Thread.Sleep(9000);
        }

        public void VerifyRankSelected(string rank)
        {
            WaitMethods.Wait(Rank, 60);
            string checkRank = UIActions.GetDropdownSelectedValue(Rank);

            if (checkRank == "-- Select --")
            {
                UIActions.SelectElementByText(Rank, rank);
            }
        }

        public void VerifyCreateAdopAndSruDraftPermission()
        {
            UIActions.JSClickElement(ADOPpermissionTab);
            Thread.Sleep(4000);
            Assert.True(UIActions.IsElementSelected(CreateAdop));
            Assert.True(UIActions.IsElementSelected(AdopSruDraft));
        }

        public void VerifyUsarDraftAndSruDraftPermission()
        {
            UIActions.JSClickElement(ADOPpermissionTab);
            Thread.Sleep(4000);
            Assert.True(UIActions.IsElementSelected(AdopUsarDraft));
            Assert.True(UIActions.IsElementSelected(AdopSruDraft));
        }

        public void VerifySruDraftAndNotUsarDraftPermission()
        {
            UIActions.JSClickElement(ADOPpermissionTab);
            Thread.Sleep(4000);
            Assert.False(UIActions.IsElementSelected(AdopUsarDraft));
            Assert.True(UIActions.IsElementSelected(AdopSruDraft));
        }

        #endregion

        #endregion
    }
}
