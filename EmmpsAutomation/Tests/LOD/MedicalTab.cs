using EmmpsAutomation.PageObjectModel.LOD;
using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Xunit;

namespace EmmpsAutomation.LOD
{
    public class MedicalTab
    {

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        StartNewLODPage _startnewlod;
        SearchFilterObjects _searchFilter;
        MiscPageOjects _miscPageOjects;
        MyLODMenuNav _mylodMenuNav;
        LODMedicalTab _medicalTab;

        public MedicalTab()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _startnewlod = new StartNewLODPage();
            _searchFilter = new SearchFilterObjects();
            _miscPageOjects = new MiscPageOjects();
            _mylodMenuNav = new MyLODMenuNav();
            _medicalTab = new LODMedicalTab();
        }


        [Fact]
        public void LODMedicalTabValidations()
        {
            //try
            //{
                //login
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");

                //Navigate to start NewLod
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //MEDCHARTContent_EmmpsContent_ucSoldierSearch_SSNText

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "367009658");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-183));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");
                UIActions.JSClickElement(_startnewlod.NextButton);


                UIActions.TypeInTextBoxAndEnter(_startnewlod.ExceptionToPolicyCommentBox, "Start New LOD");
                UIActions.SelectElementByText(_startnewlod.RowsPerPage, "50");
                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, ("NG Title 10 (Informal)"));
                UIActions.JSClickElement(_startnewlod.CreateLODButton);

                //click Medical Tab
                UIActions.ClickElement(_mylodMenuNav.LODMedicalMenuLinkButton);

                /////////////

                UIActions.SelectElementByText(_medicalTab.LODMedPatientDisposition, "Out Patient");

                UIActions.SelectElementByText(_medicalTab.LODMedicalHospitalTypeDropDown, "Military");

                UIActions.ClearTextBox(_medicalTab.LODMedicalHospitalNameTextBox);
                UIActions.GetElement(_medicalTab.LODMedicalHospitalNameValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_medicalTab.LODMedicalHospitalNameValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_medicalTab.LODMedicalHospitalNameTextBox);
                UIActions.TypeInTextBoxAndEnter(_medicalTab.LODMedicalHospitalNameTextBox, "Our Lady of MacGuffin");
                ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalHospitalNameValidationMess).Count.Should().Be(0);

                UIActions.TypeInTextBoxAndEnter(_medicalTab.LODMedicalDateAdmittedTextBox, (UIActions.SelectDate(Convert.ToInt32(-181)) + " 0000"));
                UIActions.TypeInTextBoxAndEnter(_medicalTab.LODMedicalDateExamTextBox, (UIActions.SelectDate(Convert.ToInt32(-180)) + " 0000"));

                //does not work for death workflows because the dropdown box become a label
                UIActions.SelectElementByText(_medicalTab.LODMedNatureofIncident, "Injury");

                //broken validation
                //UIActions.GetElement(_medicalTab.LODMedicalDiagnosisValidateMess).Displayed.Should().BeTrue();
                //UIActions.GetElement(_medicalTab.LODMedicalDiagnosisValidateMess).Text.Should().BeEquivalentTo("Required");
                //UIActions.JSClickElement(_medicalTab.LODMedicalShowDiagnosisPanel);
                //UIActions.JSClickElement(_medicalTab.MedExactMatch);
                //UIActions.ClickElement(_medicalTab.MedicalDiagnosisFirstEntry);
                //WaitMethods.WaitForAnimationtoComplete(_miscPageOjects.WaitingAnimationDiv, 60);
                //UIActions.TypeInTextBoxAndEnter(_medicalTab.MedExactMatchSearchTextBox, "A011");
                //UIActions.JSClickElement(_medicalTab.MedSearchDiagnosisButton);
                //UIActions.JSClickElement(_medicalTab.MedAddDiagnosisButton);
                //ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalDiagnosisValidateMess).Count.Should().Be(0);


                UIActions.GetElement(_medicalTab.LODMedicalMedOpinAlcoholValidateMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_medicalTab.LODMedicalMedOpinAlcoholValidateMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_medicalTab.MedYesInfluenceofAlcohol);
                ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalMedOpinAlcoholValidateMess).Count.Should().Be(0);

                UIActions.GetElement(_medicalTab.LODMedicalMedOpinionDrugsValidateMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_medicalTab.LODMedicalMedOpinionDrugsValidateMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_medicalTab.MedYesInfluenceofDrugs);
                UIActions.TypeInTextBox(_medicalTab.MedUndertheInfluenceDrugsTextBox, "Test");
                ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalMedOpinionDrugsValidateMess).Count.Should().Be(0);


                //add Injury occurrence tests here UI



                UIActions.TypeInTextBox(_medicalTab.LODMedicalOpinionBasisTextBox, "I am the finest doctor in all the realm");
                WaitMethods.Wait(_medicalTab.MedYesBloodAlcoholTestMade, 60);

                //add Resut of disability here UI

                UIActions.JSClickElement(_medicalTab.MedYesBloodAlcoholTestMade);

                UIActions.SelectElementByIndex(_medicalTab.MedMgBloodAlcoholTest, 3);

                UIActions.GetElement(_medicalTab.LODMedicalDetailsofAccidentValidateMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_medicalTab.LODMedicalDetailsofAccidentValidateMess).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_medicalTab.LODMedicalOpinionBasisDetailsTextBox, "Fever");
                ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalDetailsofAccidentValidateMess).Count.Should().Be(0);


                //WaitMethods.Wait(LODMedicalAttPhysNameTextBox, 60);
                UIActions.GetElement(_medicalTab.LODMedicalAttPhysicianNameValidateMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_medicalTab.LODMedicalAttPhysicianNameValidateMess).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_medicalTab.LODMedicalAttPhysNameTextBox, "Dr. Frankenstine");
                ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalAttPhysicianNameValidateMess).Count.Should().Be(0);

                //WaitMethods.Wait(LODMedicalAttPhysDate, 60);
                UIActions.GetElement(_medicalTab.LODMedicalAttPhysicianDateValidateMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_medicalTab.LODMedicalAttPhysicianDateValidateMess).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_medicalTab.LODMedicalAttPhysDate, (UIActions.SelectDate(Convert.ToInt32(-170))));
                ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalAttPhysicianDateValidateMess).Count.Should().Be(0);

                //UIActions.GetElement(_medicalTab.LODMedicalMedOpinionsFutureDisabilityValidateMess).Displayed.Should().BeTrue();
                //UIActions.GetElement(_medicalTab.LODMedicalMedOpinionsFutureDisabilityValidateMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_medicalTab.MedYesLikelyClaim);
                //ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalMedOpinionsFutureDisabilityValidateMess).Count.Should().Be(0);

                //WaitMethods.Wait(MedYesMentallySound, 60);
                UIActions.GetElement(_medicalTab.LODMedicalMedOpinionsMentalSoundValidateMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_medicalTab.LODMedicalMedOpinionsMentalSoundValidateMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_medicalTab.MedYesMentallySound);
                ObjectRepository.Driver.FindElements(_medicalTab.LODMedicalMedOpinionsMentalSoundValidateMess).Count.Should().Be(0);

                ///////////////////////////////////////            

                //all required Medical Tab fields are updated 
                UIActions.JSClickElement(_mylodMenuNav.LODDocumentsMenuLinkButtonLinkText);
                UIActions.JSClickElement(_mylodMenuNav.LODMedicalMenuLinkButtonLinkText);

                //Verify no Required messages exist
            //}




            //finally
            //{
            //    _driverInit.TearDown();
            //}





        }
        [Fact]
        public void LODMedicalTabValidations2()
        {
            try
            { 

                //login
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");

                //Navigate to start NewLod
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //MEDCHARTContent_EmmpsContent_ucSoldierSearch_SSNText

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "367009658");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-183));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");
                UIActions.JSClickElement(_startnewlod.NextButton);


                UIActions.TypeInTextBoxAndEnter(_startnewlod.ExceptionToPolicyCommentBox, "Start New LOD");
                UIActions.SelectElementByText(_startnewlod.RowsPerPage, "50");
                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, ("NG Title 10 (Informal)"));
                UIActions.JSClickElement(_startnewlod.CreateLODButton);

                //click Medical Tab
                UIActions.ClickElement(_mylodMenuNav.LODMedicalMenuLinkButton);


                //Verify Required fields
                WaitMethods.Wait(_medicalTab.LODMedPatientDisposition, 60);
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalDispositionPatienteValidationMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalHospitalNameValidationMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalNatureIncidentValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalMedOpinAlcoholValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalMedOpinionDrugsValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalMedOpinionsMentalSoundValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalMedOpinionsFutureDisabilityValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalDetailsofAccidentValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalAttPhysicianDateValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalAttPhysicianNameValidateMess));
                Assert.True(UIActions.IsElementPresent(_medicalTab.LODMedicalDiagnosisValidateMess));

                //click yes to display dropdown list for Blood Alcohol Test Made
                UIActions.JSClickElement(_medicalTab.MedYesBloodAlcoholTestMade);

                //Verify dropdownlist
                Assert.True(UIActions.ComboboxInnerTextValidator(_medicalTab.LODMedPatientDisposition, new List<string> { "Select", "Admitted", "Out Patient", "Dead on Arrival" }));
                Assert.True(UIActions.ComboboxInnerTextValidator(_medicalTab.LODMedicalHospitalTypeDropDown, new List<string> { "Select", "Civilian", "Military" }));
                Assert.True(UIActions.ComboboxInnerTextValidator(_medicalTab.LODMedNatureofIncident, new List<string> { "Select", "Disease", "Injury", "Illness" }));
                Assert.True(UIActions.ComboboxInnerTextValidator(_medicalTab.LODMedicalDisabilityResultDropDown, new List<string> { "Select", "Temporary", "Permanent Partial", "Permanent Total", "None" }));
                Assert.True(UIActions.ComboboxInnerTextValidator(_medicalTab.MedMgBloodAlcoholTest, new List<string> { "Select", "Inconclusive", "< 0.01", "0.01", "0.02", "0.03", "0.04", "0.05", "0.06", "0.07", "0.08", "0.09", "0.10", "0.11", "0.12", "0.13", "0.14", "0.15", "0.16", "0.17", "0.18", "0.19", "0.20", "0.21", "0.22", "0.23", "0.24", "0.25", "> 0.26" }));

                //verify numeric fields
            
                string textBoxValue = string.Empty;
                UIActions.TypeInTextBox(_medicalTab.LODMedicalDateAdmittedTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_medicalTab.LODMedicalDateAdmittedTextBox);
                Assert.False(textBoxValue.Length > 0, "LOD Medical Date Admitted TextBox should not except alphanumeric data");
                
                textBoxValue = string.Empty;

                UIActions.TypeInTextBox(_medicalTab.LODMedicalAttPhysDate, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_medicalTab.LODMedicalAttPhysDate);
                Assert.False(textBoxValue.Length > 0, "LOD DMedica lAttending Physican Date should not except alphanumeric data");

                textBoxValue = string.Empty;

                UIActions.TypeInTextBox(_medicalTab.LODMedicalDateExamTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_medicalTab.LODMedicalDateExamTextBox);
                Assert.False(textBoxValue.Length > 0, "LOD Medical Hour Date Examined TextBox should not except alphanumeric data ");

                textBoxValue = string.Empty;

            }




            finally
            {
                _driverInit.TearDown();
            }

        }



        //		Feature: LODMedicalTab
        //	In order to avoid silly mistakes
        //	As a math idiot
        //	I want to be told the sum of two numbers

        //@TestCase37391
        //Scenario Outline: Test 37391 LOD Medical Tab - Validations
        //	Given I am Logged in as <Role> using EDIPIN<PIN>
        //	And I have navigated to "Start New LOD" tab in "eMMPS"
        //	And I have created a New LOD in <Workflow> and<Status> and<SSN> and<EndOfAuthorizedDutyStatusDate> and <ExceptionToPolicy> and<Comments> and <RowsPerPage>
        //	When I click the "Medical" Tab in "LOD"
        //	Then all the fields in the Medical Tab should be displayed <DispositionofPatient> and<TypeOfHospitalOrTreatmentFacility> and <NameOfHospitalOrTreatmentFacility> and<DateAdmitted> and <DateExam> and<NatureIncident> and <Diagnosis> and<Alcohol> and <Dru_navMenu> and<MentallySound> and <ResultInClaim> and<InjuryInLOD> and <LikelyReoccur> and<AccidentDetails> and <PhysicianDate> and<PhysicianName> and <InjuryCode>

        //	And all the required Medical Tab fields are updated

        //	Scenarios: 
        //	| Role       | PIN        | SSN       | Workflow               | Status    | EndOfAuthorizedDutyStatusDate | ExceptionToPolicy | Comments      | RowsPerPage | DispositionofPatient | TypeOfHospitalOrTreatmentFacility | NameOfHospitalOrTreatmentFacility | DateAdmitted | DateExam | NatureIncident | Diagnosis | Alcohol | Dru_navMenu | MentallySound | ResultInClaim | InjuryInLOD | LikelyReoccur | AccidentDetails | PhysicianDate | PhysicianName | InjuryCode |
        //	| Unit Admin | 8880070115 | 367009658 | NG Title 10 (Informal) | -- All -- | -181                          | Other             | Start New LOD | 50          | Out Patient          | Military                          | Test Hospital                     | -181         | -180     | Injury         | Fever     | Yes     | Yes   | Yes           | No            | No          | No            | Automation Test | -170          | Dr.Test      | A011       |



        //Scenario Outline: Test 37391 LOD Medical Tab - Input Validations
        //	Given I am Logged in as <Role> using EDIPIN <PIN>
        //	And I have navigated to "Start New LOD" tab in "eMMPS"
        //	And I have created a New LOD in <Workflow> and<Status> and<SSN> and<EndOfAuthorizedDutyStatusDate> and <ExceptionToPolicy> and<Comments> and <RowsPerPage>
        //	When I click the "Medical" Tab in "LOD"
        //	Then all the required Medical Tab fields are displayed
        //	And the options for the drop downs in the Medical Tab are correct
        //	And all the Medical Tab numeric fields have been validated

        //	Scenarios: 
        //	| Role       | PIN        | SSN       | Workflow               | Status    | EndOfAuthorizedDutyStatusDate | ExceptionToPolicy | Comments      | RowsPerPage | DispositionofPatient | TypeOfHospitalOrTreatmentFacility | NameOfHospitalOrTreatmentFacility | DateAdmitted | DateExam | NatureIncident | Diagnosis | Alcohol | Dru_navMenu | MentallySound | ResultInClaim | InjuryInLOD | LikelyReoccur | AccidentDetails | PhysicianDate | PhysicianName | InjuryCode |
        //	| Unit Admin | 8880070115 | 367009658 | NG Title 10 (Informal) | -- All -- | -181                          | Other             | Start New LOD | 50          | Out Patient          | Military                          | Test Hospital                     | -181         | -180     | Injury         | Fever     | Yes     | Yes   | Yes           | No            | No          | No            | Automation Test | -170          | Dr.Test      | A011       |


    }
}
