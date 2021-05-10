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
    public class ARRestrictedAssaultInformal
    {
        //Test Script 54731


        readonly string fileName = "ARRestrictedAssaultInformal.xlsx";
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


        public ARRestrictedAssaultInformal()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();            
            startNewLOD = new StartNewLODPage();
            myLOD = new MyLODMenuNav();
            soldierTab = new LODSoldierTab();
            medicalTab = new LODMedicalTab();
            unitTab = new LODUnitTabPage();
            docs = new LODDocuments();
            nextActionTab = new LODNextActionTab();
            searchPage = new LODSearchPage();
        }


        [Fact]
        public void ARRestrictedAssaultInformalStartLOD()
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
        public void ARRestrictedAssaultInformalUsarcSarcManager()
        {
            //test = extent.CreateTest("NGPreApprovedInformalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UsarcSarcManager(ExcelUtil.ReadData(i, "UsarcSarcManagerPin"));
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
                UIActions.TypeInTextBox(startNewLOD.ExceptionToPolicyCommentBox, "New AR Restricted Assault Informal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);

                //check to make sure the rank field is selected if not sets it
                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "AR Restricted Assault (Informal)");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                UIActions.ClickElement(startNewLOD.BehavioralHealthCase);
                startNewLOD.VerifyRankSelected("Specialist (SPC)");
                UIActions.JSClickElement(startNewLOD.CreateLODButton);

                // Soldier Tab

                //verify all required fields have values on soldier tab
                //contactStreet, contactCity, contactState, contactZip, contactAKOEmail, contactHmPhone, contactCellPhone
                soldierTab.UpdateRequiredFieldsSoldierTab("22 NoWhere Street", "Fairfax", "Virginia", "11111", "test@mail.mil", "703-111-1111");

                //Medical Tab 
                UIActions.JSClickElement(myLOD.LODMedicalMenuLinkButtonLinkText);
                //parameters hospitaltype, patientdisposition, natureofincident, bloodalcohol, injurycode, accidentDetails, physicianDate, physicianName, drugs, mentallySound, resultInClaim, dateAdmitted, dateExamined
                medicalTab.NewLODMedicalTabBasicRequiredFieldsEntry("Military", "Out Patient", "Illness", "No", "A011", "Automation Test", "-50", "Dr. Test", "Yes", "Yes", "Yes", "-60", "-60");
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
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(docs.AuthOrdersDutyStatus, "UploadButton");
                docs.UploadFile("Authorization Orders", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(docs.DAForm3349, "UploadButton");
                docs.UploadFile("DA Form 3349", docs.TESTFILE);
                Thread.Sleep(500);

                //Next Action
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To USARC Assault Approval Review");
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

        
        public void UsarcSarcManager(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "USARC Assault Approval Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Restricted Assault (Informal)");
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
