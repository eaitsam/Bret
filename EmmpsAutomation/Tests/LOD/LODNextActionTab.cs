using EmmpsAutomation.PageObjectModel.LOD;
using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace EmmpsAutomation.Tests.LOD
{
    public class LODNextActionTab
    {
        readonly LODSearchPage searchPage;
        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly NavMenuObjects navMenu;
        readonly StartNewLODPage startNewLOD;
        readonly LODSoldierTab soldierTab;
        readonly LODMedicalTab medicalTab;
        readonly LODUnitTabPage unitTab;
        readonly LODApptTab apptTab;
        readonly LODInvestigationTab investigationTab;
        readonly LODFormFindingsTab formFindingsTab;
        readonly MyLODMenuNav myLOD;
        readonly LODDocuments docs;
        readonly EmmpsAutomation.PageObjectModel.LOD.LODNextActionTab nextActionTab;
        readonly MiscPageOjects misc;

        public LODNextActionTab()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            searchPage = new LODSearchPage();
            startNewLOD = new StartNewLODPage();
            myLOD = new MyLODMenuNav();
            soldierTab = new LODSoldierTab();
            medicalTab = new LODMedicalTab();
            unitTab = new LODUnitTabPage();
            apptTab = new LODApptTab();
            investigationTab = new LODInvestigationTab();
            formFindingsTab = new LODFormFindingsTab();
            docs = new LODDocuments();
            nextActionTab = new EmmpsAutomation.PageObjectModel.LOD.LODNextActionTab();
        }

        [Fact]
        public void ARInformalNextActionValidation()
        {
            //Test Script 71138
            ARInformalValidation("8880070022", "036008608");
        }

        [Fact]
        public void ARFormalNextActionValidation()
        {
            //Test Script 71027
            ARFormalValidation("8880070022", "035008719");
            ARFormalUnitCommanderValidation("8880070023", "88th DIV(R) (W89QAA)");
            ARFormalMSCAdminValidation("8880070028");
            ARFormalAppointingAuthorityValidation("8880070029", "PV2 AR Investigator 88th DIV(R)");
            ARFormalInvestigatingOfficerValidation("8880070024");
            ARFormalAppointingAuthorityFormFindingsValidation("8880070029");
            ARFormalUsarManagerValidation("8880070054");
            ARFormalUsarManagerValidation2("8880070054");
            ARFormalUsarManagerValidation3("8880070054");
            ARFormalUsarManagerValidation4("8880070054");
        }

        public void ARInformalValidation(string edipin, string id)
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
                UIActions.TypeInTextBox(startNewLOD.ExceptionToPolicyCommentBox, "New AR Informal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);

                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "AR Informal");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                UIActions.ClickElement(startNewLOD.AGRCase);
                startNewLOD.VerifyRankSelected("Specialist (SPC)");
                UIActions.JSClickElement(startNewLOD.CreateLODButton);

                //Soldier
                soldierTab.VerifyValidations();
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Should().BeEquivalentTo("Medical: Disposition - Required");

                //Medical
                UIActions.JSClickElement(myLOD.LODMedicalMenuLinkButtonLinkText);
                medicalTab.VerifyValidations();
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Should().BeEquivalentTo("Unit: Incident Date - Required");

                //Unit
                UIActions.JSClickElement(myLOD.LODUnitMenuLinkButtonLinkText);
                unitTab.VerifyValidations();
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Should().BeEquivalentTo("Documents: Medical Documents - Required");

                //Documents
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                docs.VerifyValidations();

                //Next Action
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.NoValidMess).Text.Trim().Should().BeEquivalentTo("No Validation Errors Exist");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Unit Commander LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalValidation(string edipin, string id)
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
                UIActions.TypeInTextBox(startNewLOD.ExceptionToPolicyCommentBox, "New AR Formal Workflow");
                UIActions.JSClickElement(startNewLOD.NextButton);

                //check to make sure the rank field is selected if not sets it
                startNewLOD.VerifyRankSelected("Specialist (SPC)");
                UIActions.SelectElementByText(startNewLOD.WorkflowDropDownBox, "AR Formal");
                UIActions.JSClickElement(startNewLOD.AGRCase);
                UIActions.JSClickElement(startNewLOD.CreateLODButton);

                //Soldier
                soldierTab.VerifyFormalValidations();
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Should().BeEquivalentTo("Soldier: Attached UIC - Required");
                UIActions.JSClickElement(myLOD.LODSoldierMenuLinkText);
                soldierTab.VerifyAttachedUnitValidations();
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Should().BeEquivalentTo("Medical: Disposition - Required");

                //Medical
                UIActions.JSClickElement(myLOD.LODMedicalMenuLinkButtonLinkText);
                medicalTab.VerifyValidationsFormal();
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Should().BeEquivalentTo("Unit: Incident Date - Required");

                //Unit
                UIActions.JSClickElement(myLOD.LODUnitMenuLinkButtonLinkText);
                unitTab.VerifyFormalValidations();
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Should().BeEquivalentTo("Documents: Medical Documents - Required");

                //Documents
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                docs.VerifyValidations();
                UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
                docs.ClickUploadDcoumentLink(docs.AppealofDetermineDocs, "UploadButton");
                docs.UploadFile("Appeal Documents", docs.TESTFILE);
                Thread.Sleep(500);
                docs.ClickUploadDcoumentLink(docs.SurgeonReview, "UploadButton");
                docs.UploadFile("Surgeon Review Documents", docs.TESTFILE);
                Thread.Sleep(500);
                docs.ClickUploadDcoumentLink(docs.SoldiersRightsWarningsStatement, "UploadButton");
                docs.UploadFile("Soldier Rights Documents", docs.TESTFILE);
                Thread.Sleep(500);

                //Next Action
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Investigation: Report Date - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Unit Commander LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.TypeInTextBoxAndEnter(nextActionTab.NextActionCommentTextBox, "Comment");
                    UIActions.JSClickElement(nextActionTab.NextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
                }
            }
            finally
            {
                driverInit.TearDown();
            }
        }

        public void ARFormalUnitCommanderValidation(string edipin, string mscadmin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Unit Commander LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Appt tab
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);
                if (ObjectRepository.Driver.FindElements(apptTab.ChangeButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeButton).Click();
                }
                UIActions.SelectElementByText(apptTab.LODAppointmentIntermediateCommandDropDownList, "--Select--");
                UIActions.GetElement(apptTab.LODAppointmentValidationMess).Displayed.Should().BeTrue();
                UIActions.SelectElementByText(apptTab.LODAppointmentIntermediateCommandDropDownList, mscadmin);
                ObjectRepository.Driver.FindElements(apptTab.LODAppointmentValidationMess).Count.Should().Be(0);
                UIActions.JSClickElement(apptTab.LODAppointmentIntermediateCommandSelectButton);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Investigation: Report Date - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MSC LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalMSCAdminValidation(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "MSC LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To Appointing Authority Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalAppointingAuthorityValidation(string edipin, string investigatorassign)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                Thread.Sleep(3000);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "Appointing Authority Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //appt tab
                UIActions.JSClickElement(myLOD.LODAptMenuLinkButtonLinkText);
                if (ObjectRepository.Driver.FindElements(apptTab.ChangeOfficerButton).Count == 1)
                {
                    UIActions.GetElement(apptTab.ChangeOfficerButton).Click();
                }
                UIActions.SelectElementByText(apptTab.LODAppointmentInvestigationOfficerDropDownList, "--Select--");
                UIActions.GetElement(apptTab.LODAppointmentValidationMess).Displayed.Should().BeTrue();
                UIActions.SelectElementByText(apptTab.LODAppointmentInvestigationOfficerDropDownList, investigatorassign);
                ObjectRepository.Driver.FindElements(apptTab.LODAppointmentValidationMess).Count.Should().Be(0);
                UIActions.JSClickElement(apptTab.LODAppointmentInvestigationOfficerSelectButton);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Investigation: Report Date - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To I/O Investigation");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalInvestigatingOfficerValidation(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                Thread.Sleep(3000);
                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "I/O - Investigation (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Investigation Tab
                UIActions.JSClickElement(myLOD.LODInvestigationMenuLinkButtonLinkText);
                //parms for UpdateRequiredFieldsInvestigationTab(reportDate, investigationOf, circumstanceDate, place, substained, medDiagnosis, presentForDuty, misconductOrNeglect, mentallySound, remarks, finding, organizationAndStation, ifAbsentFromDuty)
                investigationTab.UpdateRequiredFieldsInvestigationTab("-30", "Injury", "-60", "Asthma", "Shortness of breath", "Unknown", "No", "No", "Yes", "Automation Test", "In Line Of Duty", "National Guard", "Without Authority");
                investigationTab.UpdateInvestigationLODShortTourOfAdForTraining("Yes", "-80", "-45");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Form Findings: Appointing Authority Findings - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MSC Approval LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalAppointingAuthorityFormFindingsValidation(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "MSC Approval LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Form Findings
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsAppointingAuthorityFindings("Approved");
                formFindingsTab.UpdateFormFindingsAppointingAuthorityReasons("Automation Test");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Form Findings: Reviewing Authority Findings - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To DIV(R) LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalUsarManagerValidation(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "DIV(R) LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Form Findings: Reviewing Authority Findings - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To DIV(R) Approval LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalUsarManagerValidation2(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "DIV(R) Approval LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Form Findings
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsReviewingAuthorityFindings("Approved", "Automation Test");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Form Findings: Final Approval Findings - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To USARC Admin LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalUsarManagerValidation3(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "USARC Admin LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.FirstValidMess).Text.Trim().Should().BeEquivalentTo("Form Findings: Final Approval Findings - Required");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To USARC Approval LOD Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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

        public void ARFormalUsarManagerValidation4(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.LODMenuBarLink, navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(searchPage.LODComboBoxStatus, "USARC Approval LOD Review (AR)");
                UIActions.SelectElementByText(searchPage.LODComboBoxWorkflow, "AR Formal");
                SearchandFilterCases.FilterbyRecentCaseandSelect(searchPage.MyLODsFilterButton, searchPage.FilterByDateCreated, misc.WaitingAnimationDiv, searchPage.FilterResultsRow0CaseIDLink, searchPage.SearchFilterResultsRow0CaseIDLink);

                //Form Findings
                UIActions.JSClickElement(myLOD.LODFormfindingsMenuLinkButtonLinkText);
                formFindingsTab.UpdateFormFindingsFinalApprovalFindings("Approved", "Automation Test");

                //Next Action Tab
                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
                UIActions.GetElement(nextActionTab.NoValidMess).Text.Trim().Should().BeEquivalentTo("No Validation Errors Exist");
                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Approve - ILD");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(nextActionTab.NextActionSignButton))
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
