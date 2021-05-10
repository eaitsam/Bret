using EmmpsAutomation.PageObjectModel.LOD;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using MedchartSeleniumAutomationCore.Core_Tools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Xunit;

namespace EMMPSDataseed.Workflows.LOD
{
    public class NGPreApprovedInformal
    {
        readonly string fileName = "NGPreApprovedInformal.xlsx";
        readonly string ErrorLogName = "ErrorLog.txt";

        public string currentId = string.Empty;
        public By TitleHeader = By.Id("MedchartPageTitle");

        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly NavMenuObjects navMenu;
        readonly StartNewLODPage startNewLOD;
        readonly MyLODMenuNav myLOD;
        readonly LODDocuments docs;
        readonly LODNextActionTab nextActionTab;
        readonly LODSearchPage searchPage;
        readonly MiscPageOjects misc;


        public NGPreApprovedInformal()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            myLOD = new MyLODMenuNav();
            startNewLOD = new StartNewLODPage();
            docs = new LODDocuments();
            nextActionTab = new LODNextActionTab();
            searchPage = new LODSearchPage();
        }

        [Fact]
        public void NGPreApprovedInformalStartLOD()
        {
            //test = extent.CreateTest("NGPreApprovedInformalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void NGPreapprovedInformalStateAdminReview()
        {

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                StateAdminReview(ExcelUtil.ReadData(i, "StateAdminReviewPin"));
            }


        }

        [Fact]
        public void NGPreapprovedInformalStateApprovalLODReview()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                StateAdminReview(ExcelUtil.ReadData(i, "StateAdminReviewPin"));
                StateApprovalLODReview(ExcelUtil.ReadData(i, "StateApprovalLODReviewPin"));
            }

        }

        public void StartLOD(string edipin, string Id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink, navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                startNewLOD.SoldierSSNSearch(Id);
                UIActions.TypeInTextBoxAndEnter(startNewLOD.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-180));
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.TypeInTextBox(startNewLOD.ExceptionToPolicyCommentBox, "New NG Pre-Approved Informal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "NG Pre-Approved (Informal)");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                UIActions.JSClickElement(startNewLOD.ABCMRCase);

                startNewLOD.VerifyRankSelected("Private (PV2)");

                UIActions.JSClickElement(startNewLOD.CreateLODButton);

                // need to do this manually in the app because you only need to do it once
                //// fill out To Address section of Soldier Tab (Geetha's request)
                //UIActions.JSClickElement(LODCaseMenuNav.LODSoldierToAddressMakeDefaultChkBox);
                //UIActions.JSEnterText(LODCaseMenuNav.LODSoldierToAddressUnitTextBox, "G Unit");
                //UIActions.JSEnterText(LODCaseMenuNav.LODSoldierToAddressStreetTextBox, "123 Sesame Street");
                //UIActions.JSEnterText(LODCaseMenuNav.LODSoldierToAddressCityTextBox, "Gotham");
                //UIActions.JSEnterText(LODCaseMenuNav.LODSoldierToAddressZipTextBox, "20413");
                //UIActions.SelectElementByText(LODCaseMenuNav.LODSoldierToAddressRegionDropDown, "District of Columbia");

                //Upload Documents Section            

                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                WaitMethods.Wait(docs.MedicalDocsCivMil, 60);

                docs.ClickUploadDcoumentLink(docs.LODDocumentation, "UploadButton");
                docs.UploadFile("This is a required document", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(docs.DAForm3349, "UploadButton");
                docs.UploadFile("This is a required document for ADOP", docs.TESTFILE);
                Thread.Sleep(500);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To State Admin Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }


            }

            finally
            {
                driverInit.TearDown();
            }



        }

        public void StateAdminReview(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "State Admin LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Pre-Approved (Informal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To State Approval LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }


            }

            finally
            {
                driverInit.TearDown();
            }
        }

        public void StateApprovalLODReview(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
               
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "State Approval LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Pre-Approved (Informal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Approve – ILD");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }


            }

            finally
            {
                driverInit.TearDown();
            }

        }
    }
}
