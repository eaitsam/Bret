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
    public class ARDeathFormal
    {
        //Test Script 60803

        #region Page Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//

        //---------------------------------
        //My LODs Search and Filter Objects
        //---------------------------------
        //--HTMLComboBox--//
        public By LODComboBoxStatus => By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By LODComboBoxWorkflow => By.Id("MEDCHARTContent_EmmpsContent_DropDownListWorkflow");

        //--Hyperlinks and Buttons--//
        public By MyLODsFilterButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterMyLods");
        public By NextButton = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonNext");
        public By AppointmentTab = By.Id("MEDCHARTContent_EmmpsContent_soldierControl_CaseHeader1_LODAppointmentMenuLinkButton");
        public By InvestigationTab = By.Id("MEDCHARTContent_EmmpsContent_soldierControl_CaseHeader1_LODInvestigationMenuLinkButton");
        public By FormFindingsTab = By.Id("MEDCHARTContent_EmmpsContent_soldierControl_CaseHeader1_LODForm FindingsMenuLinkButton");
        public By MemberUIC = By.Id("MEDCHARTContent_EmmpsContent_MemberUicTextbox");
        public By EndOfAuthorizedDutyDatePicker = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/table/tbody/tr/td[2]/img");

        #endregion

        readonly string fileName = "ARDeathFormal.xlsx";
        private string currentId = string.Empty;

        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly NavMenuObjects navMenu;
        readonly StartNewLODPage startNewLOD;
        readonly LODSoldierTab soldierTab;
        readonly LODMedicalTab medicalTab;
        readonly LODUnitTabPage unitTab;
        readonly LODFormFindingsTab formFindingsTab;
        readonly LODInvestigationTab investigationTab;
        readonly LODApptTab apptTab;
        readonly MyLODMenuNav myLOD;
        readonly LODDocuments docs;
        readonly LODNextActionTab nextActionTab;
        readonly MiscPageOjects misc;
        readonly LODSearchPage searchPage;
        

        public ARDeathFormal()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            startNewLOD = new StartNewLODPage();
            soldierTab = new LODSoldierTab();
            medicalTab = new LODMedicalTab();
            unitTab = new LODUnitTabPage();
            formFindingsTab = new LODFormFindingsTab();
            investigationTab = new LODInvestigationTab();
            apptTab = new LODApptTab();
            myLOD = new MyLODMenuNav();
            docs = new LODDocuments();
            nextActionTab = new LODNextActionTab();
            searchPage = new LODSearchPage();
        }

        

        [Fact]
        public void ARDeathFormalStartLOD()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalUnitCommander()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
            }


        }

        [Fact]
        public void ARDeathFormalMSCAdmin()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalAppointingAuthority()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
            }


        }

        [Fact]
        public void ARDeathFormalInvestigatingOfficer()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalLegalReview()
        {


            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
                DivRLegalReview(ExcelUtil.ReadData(i, "LegalReviewPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }


        [Fact]
        public void ARDeathFormalDivRAdmin()
        {


            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
                DivRLegalReview(ExcelUtil.ReadData(i, "LegalReviewPin"), ExcelUtil.ReadData(i, "Id"));
                DivRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalDivRApproval()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
                DivRLegalReview(ExcelUtil.ReadData(i, "LegalReviewPin"), ExcelUtil.ReadData(i, "Id"));
                DivRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"), ExcelUtil.ReadData(i, "Id"));
                DivRApproval(ExcelUtil.ReadData(i, "DivRApprovalPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalUSARCAdmin()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
                DivRLegalReview(ExcelUtil.ReadData(i, "LegalReviewPin"), ExcelUtil.ReadData(i, "Id"));
                DivRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"), ExcelUtil.ReadData(i, "Id"));
                DivRApproval(ExcelUtil.ReadData(i, "DivRApprovalPin"), ExcelUtil.ReadData(i, "Id"));
                USARCAdmin(ExcelUtil.ReadData(i, "USARCAdminPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalUSARCApproval()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
                DivRLegalReview(ExcelUtil.ReadData(i, "LegalReviewPin"), ExcelUtil.ReadData(i, "Id"));
                DivRAdmin(ExcelUtil.ReadData(i, "DIVRAdminPin"), ExcelUtil.ReadData(i, "Id"));
                DivRApproval(ExcelUtil.ReadData(i, "DIVRApprovalPin"), ExcelUtil.ReadData(i, "Id"));
                USARCAdmin(ExcelUtil.ReadData(i, "USARCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                USARCApproval(ExcelUtil.ReadData(i, "USARCApprovalPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalHRCReviewer()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
                DivRLegalReview(ExcelUtil.ReadData(i, "LegalReviewPin"), ExcelUtil.ReadData(i, "Id"));
                DivRAdmin(ExcelUtil.ReadData(i, "DIVRAdminPin"), ExcelUtil.ReadData(i, "Id"));
                DivRApproval(ExcelUtil.ReadData(i, "DIVRApprovalPin"), ExcelUtil.ReadData(i, "Id"));
                USARCAdmin(ExcelUtil.ReadData(i, "USARCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                USARCApproval(ExcelUtil.ReadData(i, "USARCApprovalPin"), ExcelUtil.ReadData(i, "Id"));
                HRCReviewer(ExcelUtil.ReadData(i, "HRCReviewerPin"), ExcelUtil.ReadData(i, "Id"));
            }


        }

        [Fact]
        public void ARDeathFormalLeadHRCReviwer()
        {
            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "MSCAdminAssignment"));
                MSCAdmin(ExcelUtil.ReadData(i, "MSCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"), ExcelUtil.ReadData(i, "Id"));
                DivRLegalReview(ExcelUtil.ReadData(i, "LegalReviewPin"), ExcelUtil.ReadData(i, "Id"));
                DivRAdmin(ExcelUtil.ReadData(i, "DIVRAdminPin"), ExcelUtil.ReadData(i, "Id"));
                DivRApproval(ExcelUtil.ReadData(i, "DIVRApprovalPin"), ExcelUtil.ReadData(i, "Id"));
                USARCAdmin(ExcelUtil.ReadData(i, "USARCAdminPin"), ExcelUtil.ReadData(i, "Id"));
                USARCApproval(ExcelUtil.ReadData(i, "USARCApprovalPin"), ExcelUtil.ReadData(i, "Id"));
                HRCReviewer(ExcelUtil.ReadData(i, "HRCReviewerPin"), ExcelUtil.ReadData(i, "Id"));
                LeadHRCReviewer(ExcelUtil.ReadData(i, "LeadHRCReviewerPin"), ExcelUtil.ReadData(i, "Id"));
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
                UIActions.TypeInTextBoxAndEnter(startNewLOD.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-183));
                UIActions.SelectElementByText(startNewLOD.ExceptionToPolicy, "Death");

                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.TypeInTextBox(startNewLOD.ExceptionToPolicyCommentBox, "New  AR Death Formal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "AR Death (Formal)");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);
                startNewLOD.VerifyRankSelected("Private (PV2)");

                UIActions.JSClickElement(startNewLOD.CreateLODButton);

                // Soldier Tab

                //verify all required fields have values on soldier tab
                //contactStreet, contactCity, contactState, contactZip, contactAKOEmail, contactHmPhone, contactCellPhone
                soldierTab.UpdateRequiredFieldsSoldierTab("22 NoWhere Street", "Fairfax", "Virginia", "11111", "test@mail.mil", "703-111-1111");

                //Medical Tab 
                UIActions.JSClickElement(myLOD.LODMedicalMenuLinkButtonLinkText);
                //parameters hospitaltype, patientdisposition, natureofincident, bloodalcohol, injurycode, accidentDetails, physicianDate, physicianName, drugs, mentallySound, resultInClaim, dateAdmitted, dateExamined
                medicalTab.NewLODMedicalTabBasicRequiredFieldsEntry("Military", "", "", "No", "S061X7A", "Automation Test", "-5", "Dr. Test", "Yes", "Yes", "Yes", "-5", "-5");
                medicalTab.UpdateMedicalTabBasisOfOpinion("Automation Test");

                //Unit Tab 
                UIActions.JSClickElement(myLOD.LODUnitMenuLinkButtonLinkText);
                //parameters IncidentDate, IncidentCity, IncidentRegion, IncidentPOC, DutyStatus, IndivWasOn, Details
                unitTab.UpdateRequiredFieldsUnitTab("-5", "Somewhere", "Maryland", "Self", "Present For Duty", "Active Duty", "Automation Test");
                unitTab.UpdateUnitTabDutyStatusAtTimeOfDeath("Present For Duty");
                unitTab.UpdateUnitTabReservistDiedOfInjuriesRecievedProceeding("Directly To Training");
                UIActions.JSClickElement(unitTab.LODUnitNoInjuryIncurredInLineOfDuty);

                //Documents Tab 
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                //WaitMethods.Wait(docs.MedicalDocsCivMil, 60);

                docs.ClickUploadDcoumentLink(docs.MedicalDocsCivMil, "UploadButton");
                Thread.Sleep(500);
                docs.UploadFile("Medical Documents", docs.TESTFILE);
                Thread.Sleep(500);

                //Next Action
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Unit Commander LOD Review");

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

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

        
        public void UnitCommander(string edipin, string mscappoint)
        {
            try
            {                
                driverInit.InitWebdriver();
                MyLODMenuNav myLOD = new MyLODMenuNav();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Unit Commander LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");

                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Appointment Tab
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);
                if (ObjectRepository.Driver.FindElements(apptTab.ChangeButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeButton).Click();
                }

                UIActions.SelectElementByText(apptTab.LODAppointmentIntermediateCommandDropDownList, mscappoint);
                UIActions.JSClickElement(apptTab.LODAppointmentIntermediateCommandSelectButton);


                //docs tab
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButton);
                WaitMethods.Wait(docs.MedicalDocsCivMil, 60);

                docs.ClickUploadDcoumentLink(docs.LODCorrespondence, "UploadButton");
                UIActions.JSClickElement(docs.LODCorrespondenceMemoConfirmButton);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                UIActions.ClickElement(docs.SaveSubmitMemoButton);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MSC LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);


                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }
        }
                
        public void MSCAdmin(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //SearchandFilterCases.LODCaseFilter(LODCaseMenuNav.LODTextBoxSSNSearch, searchPage.LODComboBoxStatus, searchPage.LODComboBoxWorkflow, id, "Unit Commander LOD Review (AR)", "AR Death (Formal)");
                UIActions.TypeInTextBox(searchPage.LODTextBoxSSNSearch, id);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "MSC LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");

                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Appointing Authority Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }
        }

        
        public void AppointingAuthority(string edipin, string investigatingofficer)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                //******************************add filter to get last case for current user type
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Appointing Authority Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");

                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Appointment Tab
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);
                //apptTab.UpdateInvestigationOfficerAppointmentTab("PV2 AR Investigator 88th RSC");
                if (ObjectRepository.Driver.FindElements(apptTab.ChangeButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeButton).Click();
                }
                UIActions.SelectElementByText(apptTab.LODAppointmentInvestigationOfficerDropDownList, investigatingofficer);
                UIActions.JSClickElement(apptTab.LODAppointmentInvestigationOfficerSelectButton);


                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To I/O Investigation");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }
        }

       
        public void InvestigatingOfficer(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //******************************add filter to get last case for current user type
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "I/O - Investigation (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Investigation Tab
                UIActions.JSClickElement(myLOD.LODInvestigationMenuLinkButtonLinkText);
                //parms for UpdateRequiredFieldsInvestigationTab(reportDate, investigationOf, circumstanceDate, place, substained, medDiagnosis, presentForDuty, misconductOrNeglect, mentallySound, remarks, finding, organizationAndStation, ifAbsentFromDuty)
                investigationTab.UpdateRequiredFieldsInvestigationTab("-30", "", "-120", "Death", "Death", "Death", "No", "No", "Yes", "Automation Test", "In Line Of Duty", "National Guard", "Without Authority");
                investigationTab.UpdateInvestigationLODShortTourOfAdForTraining("Yes", "-100", "-60");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward to DIV(R) Legal Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }
        }

        
        public void DivRLegalReview(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "DIV(R) LOD Legal Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Return To DIV(R) LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

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

       
        public void DivRAdmin(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "DIV(R) LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Form Findings
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsReviewingAuthorityFindings("Approved", "Automation Test");

                //Documents Tab 
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                WaitMethods.Wait(docs.DeathCert, 60);

                docs.ClickUploadDcoumentLink(docs.DeathCert, "UploadButton");
                docs.UploadFile("Death Certificate", docs.TESTFILE);
                Thread.Sleep(500);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);

                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To DIV(R) Approval LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }
        }

        
        public void DivRApproval(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "DIV(R) Approval LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To USARC Admin LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }

        }

        
        public void USARCAdmin(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "USARC Admin LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To USARC Approval LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }
        }

        
        public void USARCApproval(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "USARC Approval LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Form Findings Tab
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsFinalApprovalFindings("Approved", "Automation Test");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To HRC Admin LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

                if(UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }

                //UIActions.JSClickElement(misc.LogoutButton);
            }

            finally
            {
                driverInit.TearDown();
            }
        }

        
        public void HRCReviewer(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "HRC Admin LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");

                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To HRC Approval LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

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


       
        public void LeadHRCReviewer(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarCss, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "HRC Approval LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Approve - ILD");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                WaitMethods.Wait(nextActionTab.NextActionSignButton, 60);

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
