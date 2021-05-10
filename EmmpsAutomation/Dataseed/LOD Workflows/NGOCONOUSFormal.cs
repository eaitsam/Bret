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
    public class NGOCONOUSFormal
    {
        //Test Case 54916
        readonly string fileName = "NGOCONOUSFormal.xlsx";
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


        public NGOCONOUSFormal()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            myLOD = new MyLODMenuNav();         
            startNewLOD = new StartNewLODPage();
            soldierTab = new LODSoldierTab();
            medicalTab = new LODMedicalTab();
            unitTab = new LODUnitTabPage();
            formFindingsTab = new LODFormFindingsTab();
            apptTab = new LODApptTab();
            investigationTab = new LODInvestigationTab();
            docs = new LODDocuments();
            nextActionTab = new LODNextActionTab();
            searchPage = new LODSearchPage();
        }

        [Fact]
        public void NGOCONOUSFormalStartLOD()
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
        public void NGOCONOUSFormalUnitCommander()
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
        public void NGOCONOUSFormalIntermediateCommand()
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
        public void NGOCONOUSFormalAppointingAuthority()
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
        public void NGOCONOUSFormalInvestigatingOfficer()
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
        public void NGOCONOUSFormalAppointingAuthority2()
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
        public void NGOCONOUSFormalStateAdmin()
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
        public void NGOCONOUSFormalStateApproval()
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
        public void NGOCONOUSFormalNGBReviewer()
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
        public void NGOCONOUSFormalNGBApproval()
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

        
        public void StartLOD(string edipin, string id)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink, navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                startNewLOD.SoldierSSNSearch(id);
                UIActions.TypeInTextBoxAndEnter(startNewLOD.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-180));
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.TypeInTextBox(startNewLOD.ExceptionToPolicyCommentBox, "New NG Oconous Formal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);
                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "NG OCONUS (Formal)");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                UIActions.JSClickElement(startNewLOD.ABCMRCase);

                startNewLOD.VerifyRankSelected("Private (PV2)");

                UIActions.JSClickElement(startNewLOD.CreateLODButton);


                //soldier tab
                soldierTab.UpdateRequiredFieldsSoldierTab("22 NoWhere Street", "Fairfax", "Virginia", "22039", "test@mail.mil", "703-111-1111");

                //Medical Tab 
                UIActions.JSClickElement(myLOD.LODMedicalMenuLinkButtonLinkText);
                //parameters hospitaltype, patientdisposition, natureofincident, bloodalcohol, injurycode, accidentDetails, physicianDate, physicianName, drugs, mentallySound, resultInClaim, dateAdmitted, dateExamined
                //change injury code to sleep related one
                medicalTab.NewLODMedicalTabBasicRequiredFieldsEntry("Military", "Out Patient", "Disease", "Yes", "A011", "Automation Test", "-5", "Dr. Test", "No", "No", "Yes", "-5", "-5");
                medicalTab.UpdateMedicalTabBasisOfOpinion("Automation Test");

                //Unit Tab 
                UIActions.JSClickElement(myLOD.LODUnitMenuLinkButtonLinkText);
                //parameters IncidentDate, IncidentCity, IncidentRegion, IncidentPOC, DutyStatus, IndivWasOn, Details
                unitTab.UpdateRequiredFieldsUnitTab("-5", "Somewhere", "Maryland", "Self", "Present For Duty", "Active Duty", "Automation Test");
                unitTab.UpdateUnitTabInjuryIncurredLineOfDuty("Yes");
                
                //documents tab
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                WaitMethods.Wait(docs.MedicalDocsCivMil, 60);

                docs.ClickUploadDcoumentLink(docs.MedicalDocsCivMil, "UploadButton");
                docs.UploadFile("This is a requred document", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(docs.AuthOrdersDutyStatus, "UploadButton");
                docs.UploadFile("This is a requred document", docs.TESTFILE);
                Thread.Sleep(500);

                //Next Action Tab
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

        
        public void UnitCommander(string edipin, string intcommandreview)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Unit Commander LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //appt tab
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);
                if (ObjectRepository.Driver.FindElements(apptTab.ChangeButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeButton).Click();
                }
                UIActions.SelectElementByText(apptTab.LODAppointmentIntermediateCommandDropDownList, intcommandreview);
                UIActions.JSClickElement(apptTab.LODAppointmentIntermediateCommandSelectButton);


                //next action tab
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

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Intermediate Command Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //next action
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

        
        public void AppointingAuthority(string edipin, string investigateofficer)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Appointing Authority Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //appt tab
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);

                if (ObjectRepository.Driver.FindElements(apptTab.ChangeButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeButton).Click();
                }
                UIActions.SelectElementByText(apptTab.LODAppointmentInvestigationOfficerDropDownList, investigateofficer);
                UIActions.JSClickElement(apptTab.LODAppointmentInvestigationOfficerSelectButton);


                //next action
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To I/O Investigation");
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
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //investigation tab
                UIActions.JSClickElement(myLOD.LODInvestigationMenuLinkButtonLinkText);
                //parms for UpdateRequiredFieldsInvestigationTab(reportDate, investigationOf, circumstanceDate, place, substained, medDiagnosis, presentForDuty, misconductOrNeglect, mentallySound, remarks, finding, organizationAndStation, ifAbsentFromDuty)
                investigationTab.UpdateRequiredFieldsInvestigationTab("-30", "Disease", "-120", "Disease", "Zombie Bite", "Zombie Infection", "No", "No", "Yes", "Automation Test", "In Line Of Duty", "National Guard", "With Authority");
                investigationTab.UpdateInvestigationCalledOrOrderedToAD("Yes", "30 Days or Less");
                //LODCaseMenuNav.UpdateInvestigationInactiveDutyTraining("Yes", "-100", "-60");

                //next action
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
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //form findings tab
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                UIActions.TypeInTextBox(formFindingsTab.LODFormFindingsAppointingUICTextBox, "WX58AD");
                formFindingsTab.UpdateFormFindingsAppointingAuthorityFindings("Approved");
                formFindingsTab.UpdateFormFindingsAppointingAuthorityReasons("This is for automation");

                //next action
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
                //******************************add filter to get last case for current user type
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "State Admin LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                ////documents
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                WaitMethods.Wait(docs.SoldiersRightsWarningsStatement, 60);

                docs.ClickUploadDcoumentLink(docs.SoldiersRightsWarningsStatement, "UploadButton");
                docs.UploadFile("This is a requred document", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(docs.DisabilityCounselingBrief, "UploadButton");
                docs.UploadFile("Briefing", docs.TESTFILE);
                Thread.Sleep(500);

                //next action tab
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

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "State Approval LOD Review (NG)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //form findings tab
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                //UIActions.TypeInTextBox(formFindingsTab.LODFormFindingsAppointingUICTextBox, "WX58AD");
                formFindingsTab.UpdateFormFindingsReviewingAuthorityFindings("Approved", "This is for automation and identification of zombies");

                //next action tab
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
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //next action tab
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
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "NG OCONUS (Formal)");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);


                //form findings tab
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                //UIActions.TypeInTextBox(formFindingsTab.LODFormFindingsAppointingUICTextBox, "WX58AD");
                formFindingsTab.UpdateFormFindingsFinalApprovalFindings("confirmed zombie", "This is for automation and identification of zombies");


                //next action tab
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
