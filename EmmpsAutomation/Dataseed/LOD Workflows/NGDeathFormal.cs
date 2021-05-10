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
    public class NGDeathFormal
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
        //Radio Button for Death workflow xpath different for this
       
        #endregion

        readonly string fileName = "NGDeathFormal.xlsx";
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


        public NGDeathFormal()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            myLOD = new MyLODMenuNav();
            soldierTab = new LODSoldierTab();
            medicalTab = new LODMedicalTab();
            unitTab = new LODUnitTabPage();
            formFindingsTab = new LODFormFindingsTab();
            apptTab = new LODApptTab();
            investigationTab = new LODInvestigationTab();
            startNewLOD = new StartNewLODPage();
            docs = new LODDocuments();
            nextActionTab = new LODNextActionTab();
            searchPage = new LODSearchPage();
        }

        [Fact]
        public void NGDeathFormalStartLOD()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();
            
            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));                
            }


        }

        [Fact]
        public void NGDeathFormalUnitCommander()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
            }


        }

        [Fact]
        public void NGDeathFormalIntermediateCommand()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
            }


        }

        [Fact]
        public void NGDeathFormalAppointingAuthority()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
            }


        }

        [Fact]
        public void NGDeathFormalInvestigatingOfficer()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
            }


        }

        [Fact]
        public void NGDeathFormalAppointingAuthority2()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
                AppointingAuthority2(ExcelUtil.ReadData(i, "AppointingAuthority2Pin"));
            }


        }

        [Fact]
        public void NGDeathFormalStateAdmin()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
                AppointingAuthority2(ExcelUtil.ReadData(i, "AppointingAuthority2Pin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
            }


        }

        [Fact]
        public void NGDeathFormalStateApproval()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
                AppointingAuthority2(ExcelUtil.ReadData(i, "AppointingAuthority2Pin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
            }


        }

        [Fact]
        public void NGDeathFormalNGBReviewer()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
                AppointingAuthority2(ExcelUtil.ReadData(i, "AppointingAuthority2Pin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
                NGBReviewer(ExcelUtil.ReadData(i, "NGBReviewerPin"));
            }


        }

        [Fact]
        public void NGDeathFormalNGBApproval()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
                AppointingAuthority2(ExcelUtil.ReadData(i, "AppointingAuthority2Pin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
                NGBReviewer(ExcelUtil.ReadData(i, "NGBReviewerPin"));
                NGBApproval(ExcelUtil.ReadData(i, "NGBApprovalPin"));
            }


        }

        [Fact]
        public void NGDeathFormalHRCReviewer()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i,"InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
                AppointingAuthority2(ExcelUtil.ReadData(i, "AppointingAuthority2Pin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
                NGBReviewer(ExcelUtil.ReadData(i, "NGBReviewerPin"));
                NGBApproval(ExcelUtil.ReadData(i, "NGBApprovalPin"));
                HRCReviewer(ExcelUtil.ReadData(i, "HRCReviewerPin"));
            }


        }

        [Fact]
        public void NGDeathFormalLeadHRCReviewer()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\LOD\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartLOD(ExcelUtil.ReadData(i, "StartLodPin"), ExcelUtil.ReadData(i, "Id"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"), ExcelUtil.ReadData(i, "IntermediateCommandAssignment"));
                IntermediateCommand(ExcelUtil.ReadData(i, "IntermediateCommandPin"));
                AppointingAuthority(ExcelUtil.ReadData(i, "AppointingAuthorityPin"), ExcelUtil.ReadData(i, "InvestigatingOfficerAssignment"));
                InvestigatingOfficer(ExcelUtil.ReadData(i, "InvestigatingOfficerPin"));
                AppointingAuthority2(ExcelUtil.ReadData(i, "AppointingAuthority2Pin"));
                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
                NGBReviewer(ExcelUtil.ReadData(i, "NGBReviewerPin"));
                NGBApproval(ExcelUtil.ReadData(i, "NGBApprovalPin"));
                HRCReviewer(ExcelUtil.ReadData(i, "HRCReviewerPin"));
                LeadHRCReviewer(ExcelUtil.ReadData(i, "LeadHRCReviewerPin"));
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
                UIActions.TypeInTextBoxAndEnter(startNewLOD.ExceptionToPolicyCommentBox, "New NG Death Formal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "NG Death (Formal)");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);
                startNewLOD.VerifyRankSelected("Private (PV2)");
                //UIActions.JSClickElement(startNewLOD.ABCMRCase);
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
                WaitMethods.Wait(docs.MedicalDocsCivMil, 60);

                docs.ClickUploadDcoumentLink(docs.MedicalDocsCivMil, "UploadButton");
                docs.UploadFile("Medical Documents", docs.TESTFILE);
                Thread.Sleep(500);

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

        
        public void UnitCommander(string edipin, string intermediatecommand)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                //******************************add filter to get last case for current user type
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Unit Commander LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Appt Tab
                //UIActions.JSClickElement(LODCaseMenuNav.LODApptMenuLinkButton);
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);
                if (ObjectRepository.Driver.FindElements(apptTab.ChangeButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeButton).Click();
                }
                UIActions.SelectElementByText(apptTab.LODAppointmentIntermediateCommandDropDownList, intermediatecommand);
                UIActions.JSClickElement(apptTab.LODAppointmentIntermediateCommandSelectButton);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Intermediate Command Review");
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

        
        public void IntermediateCommand(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //******************************add filter to get last case for current user type
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Intermediate Command Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
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
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }


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
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //******************************add filter to get last case for current user type
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Appointing Authority Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Appt Tab
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);
                if (ObjectRepository.Driver.FindElements(apptTab.ChangeButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeButton).Click();
                }
                UIActions.SelectElementByText(apptTab.LODAppointmentInvestigationOfficerDropDownList, investigatingofficer);
                UIActions.JSClickElement(apptTab.LODAppointmentInvestigationOfficerSelectButton);


                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To I/O - Investigation");
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

        
        public void InvestigatingOfficer(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "I/O - Investigation (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Investigation Tab
                UIActions.JSClickElement(myLOD.LODInvestigationMenuLinkButtonLinkText);  //Temp fixed because xpath link not working
                //parms for UpdateRequiredFieldsInvestigationTab(reportDate, investigationOf, circumstanceDate, place, substained, medDiagnosis, presentForDuty, misconductOrNeglect, mentallySound, remarks, finding, organizationAndStation, ifAbsentFromDuty)
                investigationTab.UpdateRequiredFieldsInvestigationTab("-30", "", "-120", "Death", "Death", "Death", "No", "No", "Yes", "Automation Test", "In Line Of Duty", "National Guard", "With Authority");
                investigationTab.UpdateInvestigationInactiveDutyTraining("Yes", "-100", "-60");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Investigation Review");
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

        
        public void AppointingAuthority2(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Investigation Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Form Findings
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsAppointingAuthorityFindings("Approved");
                formFindingsTab.UpdateFormFindingsAppointingAuthorityReasons("Automation Test");

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
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Documents Tab 
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                WaitMethods.Wait(docs.DeathCert, 60);

                docs.ClickUploadDcoumentLink(docs.DeathCert, "UploadButton");
                docs.UploadFile("Death Certificate", docs.TESTFILE);
                Thread.Sleep(500);

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

        
        public void StateApproval(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                
                //find out the status and plug it in
                //UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "")
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Form Findings Tab
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsReviewingAuthorityFindings("Approved", "This is for automation and identification of zombies");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To NGB LOD Review");
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
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
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
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //Form Findings Tab
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsFinalApprovalFindings("Confirmed Zombie", "This is for automation and identification of zombies");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To HRC Admin LOD Review");
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

        
        public void HRCReviewer(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "HRC Admin LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To HRC Approval LOD Review");
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


        
        public void LeadHRCReviewer(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "HRC Approval LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG Death (Formal)");
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
