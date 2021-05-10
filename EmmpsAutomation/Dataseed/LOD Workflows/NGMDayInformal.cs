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
using Xunit;

namespace EMMPSDataseed.Workflows.LOD
{
    public class NGMDayInformal
    {
        //Test Script 54769
        readonly string fileName = "NGMDayInformal.xlsx";
        private string currentId = string.Empty;

        readonly LODSearchPage searchPage;
        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly NavMenuObjects navMenu;
        readonly StartNewLODPage startNewLOD;
        readonly LODSoldierTab soldierTab;
        readonly LODMedicalTab medicalTab;
        readonly LODUnitTabPage unitTab;
        readonly MyLODMenuNav myLOD;
        readonly LODDocuments docs;
        readonly LODNextActionTab nextActionTab;
        readonly MiscPageOjects misc;

        public NGMDayInformal()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            myLOD = new MyLODMenuNav();
            soldierTab = new LODSoldierTab();
            medicalTab = new LODMedicalTab();
            unitTab = new LODUnitTabPage();
            startNewLOD = new StartNewLODPage();
            docs = new LODDocuments();
            nextActionTab = new LODNextActionTab();
            searchPage = new LODSearchPage();
        }

        [Fact]
        public void NGMDayInformalStartLOD()
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
        public void NGMDayInformalUnitCommander()
        {
            //test = extent.CreateTest("NGPreApprovedInformalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
            }


        }

       
        [Fact]
        public void NGMDayInformalStateAdmin()
        {
            //test = extent.CreateTest("NGPreApprovedInformalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
            }


        }

        [Fact]
        public void NGMDayInformalStateApproval()
        {
            //test = extent.CreateTest("NGPreApprovedInformalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
            }


        }

        [Fact]
        public void NGMDayInformalNGBReviewer()
        {
            //test = extent.CreateTest("NGPreApprovedInformalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
                NGBReviewer(ExcelUtil.ReadData(i, "NGBReviewerPin"));
            }

        }
               
        [Fact]
        public void NGMDayInformalNGBApproval()
        {
            //test = extent.CreateTest("NGPreApprovedInformalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
                NGBReviewer(ExcelUtil.ReadData(i, "NGBReviewerPin"));
                NGBApproval(ExcelUtil.ReadData(i, "NGBApprovalPin"));
            }
        }


        public void StartLOD(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink, navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                startNewLOD.SoldierSSNSearch(id);
                UIActions.TypeInTextBoxAndEnter(startNewLOD.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-90));
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.TypeInTextBox(startNewLOD.ExceptionToPolicyCommentBox, "New NG M-Day Informal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "NG M-Day (Informal)");
                //UIActions.TypeInTextBox(MemberUIC, "W77749");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                UIActions.JSClickElement(startNewLOD.ABCMRCase);
                startNewLOD.VerifyRankSelected("Private (PV2)");

                UIActions.JSClickElement(startNewLOD.CreateLODButton);

                // Soldier Tab

                //verify all required fields have values on soldier tab
                //parameters contactStreet, contactCity, contactState, contactZip, contactAKOEmail, contactHmPhone, contactCellPhone
                soldierTab.UpdateRequiredFieldsSoldierTab("22 NoWhere Street", "Fairfax", "Virginia", "11111", "test@mail.mil", "703-111-1111");

                //Medical Tab 
                UIActions.JSClickElement(myLOD.LODMedicalMenuLinkButtonLinkText);
                //parameters hospitaltype, patientdisposition, natureofincident, bloodalcohol, injurycode, accidentDetails, physicianDate, physicianName, drugs, mentallySound, resultInClaim, dateAdmitted, dateExamined
                medicalTab.NewLODMedicalTabBasicRequiredFieldsEntry("Military", "Admitted", "Injury", "Yes", "I70743", "Automation Test", "-50", "Dr. Test", "Yes", "Yes", "Yes", "-60", "-60");
                medicalTab.UpdateMedicalTabBasisOfOpinion("Automation Test");


                //Unit Tab 
                UIActions.JSClickElement(myLOD.LODUnitMenuLinkButtonLinkText);
                //parameters IncidentDate, IncidentCity, IncidentRegion, IncidentPOC, DutyStatus, IndivWasOn, Details
                unitTab.UpdateRequiredFieldsUnitTab("-90", "Somewhere", "Maryland", "Self", "Present For Duty", "Active Duty", "Automation Test");


                //Documents Tab 

                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                WaitMethods.Wait(docs.MedicalDocsCivMil, 60);

                docs.ClickUploadDcoumentLink(docs.MedicalDocsCivMil, "UploadButton");
                docs.UploadFile("Medical Documents", docs.TESTFILE);

                docs.ClickUploadDcoumentLink(docs.AuthOrdersDutyStatus, "UploadButton");
                docs.UploadFile("Authorization Orders", docs.TESTFILE);

                docs.ClickUploadDcoumentLink(docs.DAForm1379, "UploadButton");
                docs.UploadFile("DA Form 1379", docs.TESTFILE);

                docs.ClickUploadDcoumentLink(docs.DAForm3349, "UploadButton");
                docs.UploadFile("DA Form 3349", docs.TESTFILE);

                //Next Action
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Unit Commander LOD Review");
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

        public void UnitCommander(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Unit Commander LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG M-Day (Informal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To State Admin LOD Review");
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
        

        public void StateAdmin(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "State Admin LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG M-Day (Informal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To State Approval");
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


        public void StateApproval(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "State Approval LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG M-Day (Informal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To NGB Review");
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


        public void NGBReviewer(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "NGB LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG M-Day (Informal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To NGB Approval LOD Review");
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


        public void NGBApproval(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "NGB Approval LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG M-Day (Informal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Approve - ILD");
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
