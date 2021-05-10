using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODMedicalTab
    {
        readonly MiscPageOjects misc = new MiscPageOjects();

        //--------------------------//
        //My LOD Medical Tab Objects
        //--------------------------//

        //--HTML Div--//
        public By LODMedicalMenuDiv => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODMedicalMenuDiv");
        public By LODMedicalHospitalNameValidationMess => By.Id("validationMessage1");
        public By LODMedicalDispositionPatienteValidationMess => By.Id("validationMessage0");
        public By LODMedicalExaminedDateValidationMess => By.Id("validationMessage3");
        public By LODMedicalSpecifyValidationMess => By.Id("validationMessage7");
        public By LODMedicalMedOpinAlcoholValidateMess => By.Id("validationMessage8");
        public By LODMedicalNatureIncidentValidateMess => By.Id("validationMessage5");
        public By LODMedicalMedOpinionDrugsValidateMess => By.Id("validationMessage10");
        public By LODMedicalMedOpinionsMentalSoundValidateMess => By.Id("validationMessage11");
        public By LODMedicalMgAlcoholValidateMess => By.Id("validationMessage12");
        public By LODMedicalMedOpinionsFutureDisabilityValidateMess => By.Id("validationMessage9");
        public By LODMedicalDetailsofAccidentValidateMess => By.Id("validationMessage13");
        public By LODMedicalAttPhysicianDateValidateMess => By.Id("validationMessage15");
        public By LODMedicalAttPhysicianNameValidateMess => By.Id("validationMessage14");
        public By LODMedicalDiagnosisValidateMess => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DiagnosisDivLabel");
        public By LODMedicalAttPhysicianDateInvalidValidateMess => By.Id("validationMessage17");


        //--HTML Comboboxes--//
        public By LODMedicalHospitalTypeDropDown => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_HospitalTypeDropDownList");
        public By LODMedicalDisabilityResultDropDown => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DisabilityResultDropdownList");
        public By LODMedPatientDisposition => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DispositionOfPatientDropDownList");
        public By LODMedNatureofIncident => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_NatureOfIncidentDropDownList");
        public By MedMgBloodAlcoholTest => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_BloodAlcoholLevelDropDownList");
        public By MedDiagnosisSelectBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_icd10DropDown_ICD10ResultsListBox");

        //--HTMLEdit--//
        public By LODMedicalHospitalNameTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_HospitalNameTextbox");
        public By LODMedicalDateAdmittedTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DateAdmittedTextbox");
        public By LODMedicalHourAdmittedTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_HourAdmittedTextbox");

        public By LODMedicalDateExamTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DateExaminedTextbox");
        public By LODMedicalHourExamTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_HourExaminedTextbox");
        public By LODMedicalOpinionBasisTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_BasisForOpinionTextbox");
        public By LODMedicalOpinionBasisDetailsTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DetailsTextbox");
        public By LODMedicalAttPhysDate => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_AttendingPhysicianDateTextbox");
        public By LODMedicalAttPhysNameTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_PhysicianNameTextbox");
        public By MedExactMatchSearchTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_icd10DropDown_ExactSearchTextBox");
        public By MedPartialMatchSearchTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_icd10DropDown_PartialSearchTextBox");
        public By MedUndertheInfluenceDrugsTextBox => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_InfluenceSpecifyTextbox");


        //-- HTML Hyperlinks--//
        public By LODMedicalShowDiagnosisPanel = By.Id("MEDCHARTContent_EmmpsContent_medicalControl_ShowDiagnosisPanelButton");
        public By MedSearchDiagnosisButton = By.Id("MEDCHARTContent_EmmpsContent_medicalControl_icd10DropDown_SearchButton");
        public By MedAddDiagnosisButton = By.Id("MEDCHARTContent_EmmpsContent_medicalControl_AddDiagnosisButton");

        //--Radial Buttons--//
        //public By MedYesInfluenceofAlcohol => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_AlcoholRadioButtonList_0");
        //public By MedNoInfluenceofAlcohol => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_AlcoholRadioButtonList_1");
        public By MedYesInfluenceofAlcohol => By.XPath("/ html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[2]/td[3]/span/label[1]");
        public By MedNoInfluenceofAlcohol => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[2]/td[3]/span/label[2]");

        //public By MedYesInfluenceofDrugs => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DrugsRadioButtonList_0");
        //public By MedNoInfluenceofDrugs => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_DrugsRadioButtonList_1");
        //public By MedYesMentallySound => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_MentallySoundRadioButtonList_0");
        //public By MedNoMentallySound => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_MentallySoundRadioButtonList_1");
        //public By MedYesLikelyClaim => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_LikelyClaimRadioButtonList_0");
        //public By MedNoLikelyClaim => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_LikelyClaimRadioButtonList_1");
        //public By MedYesInjuryLOD => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_LodRadioButtonList_0");
        //public By MedNoInjuryLOD => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_LodRadioButtonList_1");
        //public By MedYesLikelyReoccur => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_LikelyToRecurRadioButtonList_0");
        //public By MedNoLikelyReoccur => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_LikelyToRecurRadioButtonList_1");
        //public By MedYesPreexistToService => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_ExistedPriorRadioButtonList_0");
        //public By MedNoPreexistToService => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_ExistedPriorRadioButtonList_1");
        //public By MedUnknownPreexistToService => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_ExistedPriorRadioButtonList_2");
        //public By MedYesBloodAlcoholTestMade => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_BloodAlcoholRadioButtonList_0");
        //public By MedNoBloodAlcoholTestMade => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_BloodAlcoholRadioButtonList_1");
        public By MedYesInfluenceofDrugs => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[3]/td[3]/span/label[1]");

        public By MedNoInfluenceofDrugs => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[3]/td[3]/span/label[2]");
        public By MedYesMentallySound => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[5]/td[3]/span/label[1]");
        public By MedNoMentallySound => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[5]/td[3]/span/label[2]");
        public By MedYesLikelyClaim => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[6]/td[3]/span/label[1]");
        public By MedNoLikelyClaim => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[6]/td[3]/span/label[2]");
        public By MedYesInjuryLOD => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[7]/td[3]/span/label[1]");
        public By MedNoInjuryLOD => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[7]/td[3]/span/label[2]");
        public By MedYesLikelyReoccur => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[8]/td[3]/span/label[1]");
        public By MedNoLikelyReoccur => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[8]/td[3]/span/label[2]");
        public By MedYesPreexistToService => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[9]/td[3]/span/label[1]");
        public By MedNoPreexistToService => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[9]/td[3]/span/label[2]");
        public By MedUnknownPreexistToService => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[3]/table/tbody/tr[9]/td[3]/span/label[3]");
        public By MedYesBloodAlcoholTestMade => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/table/tbody/tr[3]/td[3]/span/label[1]");
        public By MedNoBloodAlcoholTestMade => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/table/tbody/tr[3]/td[3]/span/label[2]");


        //--Medical Diagnosis--//
        public By MedicalDiagnosisFirstEntry => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/div/div/table/tbody/tr[10]/td/select/option");
        //public By MedicalDiagnosisFirstEntry => By.XPath("//option[@value='J45991']");




        //--HTML CheckBoxes--//
        public By MedExactMatch => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_icd10DropDown_ExactSearchCheckBox");
        public By MedPartialMatch => By.Id("MEDCHARTContent_EmmpsContent_medicalControl_icd10DropDown_PartialSearchCheckBox");


        #region Medical Tab Methods

        public void NewLODMedicalTabBasicRequiredFieldsEntry(string hospitaltype, string patientdisposition, string natureofincident, string bloodalcohol, string injurycode, string accidentDetails, string physicianDate, string physicianName, string drugs, string mentallySound, string resultInClaim, string dateAdmitted, string dateExamined)
        {
            if (!string.IsNullOrEmpty(patientdisposition))
            {
                UIActions.SelectElementByText(LODMedPatientDisposition, patientdisposition);
            }
            UIActions.TypeInTextBox(LODMedicalDateAdmittedTextBox, (UIActions.SelectDate(Convert.ToInt32(dateAdmitted)) + " 0000"));
            UIActions.SelectElementByText(LODMedicalHospitalTypeDropDown, hospitaltype);
            UIActions.TypeInTextBox(LODMedicalDateExamTextBox, (UIActions.SelectDate(Convert.ToInt32(dateExamined)) + " 0000"));
            UIActions.JSClickElement(LODMedicalHospitalNameTextBox);
            UIActions.TypeInTextBox(LODMedicalHospitalNameTextBox, "Our Lady of MacGuffin");

            UIActions.JSClickElement(LODMedicalShowDiagnosisPanel);
            UIActions.JSClickElement(MedExactMatch);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 10);
            UIActions.TypeInTextBox(MedExactMatchSearchTextBox, injurycode);
            UIActions.JSClickElement(MedSearchDiagnosisButton);
            UIActions.ClickElement(MedicalDiagnosisFirstEntry);
            UIActions.JSClickElement(MedAddDiagnosisButton);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

            if (!string.IsNullOrEmpty(natureofincident))
            {
                UIActions.SelectElementByText(LODMedNatureofIncident, natureofincident);
            }
            if (bloodalcohol == "Yes")
            {
                UIActions.JSClickElement(MedYesInfluenceofAlcohol);
            }
            else
            {
                UIActions.JSClickElement(MedNoInfluenceofAlcohol);
            }
            if (drugs == "Yes")
            {
                UIActions.JSClickElement(MedYesInfluenceofDrugs);
                UIActions.TypeInTextBox(MedUndertheInfluenceDrugsTextBox, "Test");
            }
            else
            {
                UIActions.JSClickElement(MedNoInfluenceofDrugs);
            }
            UIActions.TypeInTextBox(LODMedicalOpinionBasisTextBox, "I am the finest doctor in all the realm");
            UIActions.JSClickElement(MedYesBloodAlcoholTestMade);
            UIActions.SelectElementByIndex(MedMgBloodAlcoholTest, 3);
            UIActions.TypeInTextBox(LODMedicalOpinionBasisDetailsTextBox, accidentDetails);
            UIActions.TypeInTextBox(LODMedicalAttPhysNameTextBox, physicianName);
            UIActions.TypeInTextBox(LODMedicalAttPhysDate, (UIActions.SelectDate(Convert.ToInt32(physicianDate))));
            if (resultInClaim == "Yes")
            {
                UIActions.JSClickElement(MedYesLikelyClaim);
            }
            else
            {
                UIActions.JSClickElement(MedNoLikelyClaim);
            }
            if (mentallySound == "Yes")
            {
                UIActions.JSClickElement(MedYesMentallySound);
            }
            else
            {
                UIActions.JSClickElement(MedNoMentallySound);
            }
        }

        public void UpdateMedicalTabBasisOfOpinion(string basisOfOpinion)
        {
            UIActions.TypeInTextBox(LODMedicalOpinionBasisDetailsTextBox, basisOfOpinion);
        }

        public void VerifyDropDownListMedicalTab()
        {
            //click yes to display dropdown list for Blood Alcohol Test Made
            UIActions.JSClickElement(MedYesBloodAlcoholTestMade);

            //Verify dropdownlist
            Assert.True(UIActions.ComboboxInnerTextValidator(LODMedPatientDisposition, new List<string> { "Select", "Admitted", "Out Patient", "Dead on Arrival" }));
            Assert.True(UIActions.ComboboxInnerTextValidator(LODMedicalHospitalTypeDropDown, new List<string> { "Select", "Civilian", "Military" }));
            Assert.True(UIActions.ComboboxInnerTextValidator(LODMedNatureofIncident, new List<string> { "Select", "Disease", "Injury", "Illness" }));
            Assert.True(UIActions.ComboboxInnerTextValidator(LODMedicalDisabilityResultDropDown, new List<string> { "Select", "Temporary", "Permanent Partial", "Permanent Total", "None" }));
            Assert.True(UIActions.ComboboxInnerTextValidator(MedMgBloodAlcoholTest, new List<string> { "Select", "Inconclusive", "< 0.01", "0.01", "0.02", "0.03", "0.04", "0.05", "0.06", "0.07", "0.08", "0.09", "0.10", "0.11", "0.12", "0.13", "0.14", "0.15", "0.16", "0.17", "0.18", "0.19", "0.20", "0.21", "0.22", "0.23", "0.24", "0.25", "> 0.26" }));

        }

        public void VerifyNumericOnlyFieldsMedicalTab()
        {
            string textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODMedicalDateAdmittedTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODMedicalDateAdmittedTextBox);
            Assert.False(textBoxValue.Length > 0, "LOD Medical Date Admitted TextBox should not except alphanumeric data");

            //textBoxValue = string.Empty;

            //UIActions.TypeInTextBox(LODMedicalHourAdmittedTextBox, "alpha");
            //textBoxValue = UIActions.GetTextBoxTextValue(LODMedicalHourAdmittedTextBox);
            //Assert.False(textBoxValue.Length > 0, "LOD Medical Hour Admitted TextBox should not except alphanumeric data ");

            textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODMedicalAttPhysDate, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODMedicalAttPhysDate);
            Assert.False(textBoxValue.Length > 0, "LOD DMedica lAttending Physican Date should not except alphanumeric data");

            textBoxValue = string.Empty;

            UIActions.TypeInTextBox(LODMedicalDateExamTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODMedicalDateExamTextBox);
            Assert.False(textBoxValue.Length > 0, "LOD Medical Hour Date Examined TextBox should not except alphanumeric data ");

            textBoxValue = string.Empty;

            //UIActions.TypeInTextBox(LODMedicalHourExamTextBox, "alpha");
            //textBoxValue = UIActions.GetTextBoxTextValue(LODMedicalHourExamTextBox);
            //Assert.False(textBoxValue.Length > 0, "LOD Medical Hour Examined TextBox should not except alphanumeric data ");

        }

        #endregion

        public void VerifyValidations()
        {
            UIActions.GetElement(LODMedicalDispositionPatienteValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalDispositionPatienteValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODMedPatientDisposition, "Out Patient");
            ObjectRepository.Driver.FindElements(LODMedicalDispositionPatienteValidationMess).Count.Should().Be(0);

            UIActions.ClearTextBox(LODMedicalHospitalNameTextBox);
            UIActions.GetElement(LODMedicalHospitalNameValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalHospitalNameValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODMedicalHospitalNameTextBox);
            UIActions.TypeInTextBoxAndEnter(LODMedicalHospitalNameTextBox, "Our Lady of MacGuffin");
            ObjectRepository.Driver.FindElements(LODMedicalHospitalNameValidationMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalNatureIncidentValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalNatureIncidentValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODMedNatureofIncident, "Injury");
            ObjectRepository.Driver.FindElements(LODMedicalNatureIncidentValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalDiagnosisValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalDiagnosisValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODMedicalShowDiagnosisPanel);
            UIActions.JSClickElement(MedExactMatch);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 10);
            UIActions.TypeInTextBox(MedExactMatchSearchTextBox, "S061X7A");
            UIActions.JSClickElement(MedSearchDiagnosisButton);
            UIActions.ClickElement(MedicalDiagnosisFirstEntry);
            UIActions.JSClickElement(MedAddDiagnosisButton);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
            ObjectRepository.Driver.FindElements(LODMedicalDiagnosisValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinAlcoholValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinAlcoholValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesInfluenceofAlcohol);
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinAlcoholValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinionDrugsValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinionDrugsValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesInfluenceofDrugs);
            UIActions.TypeInTextBox(MedUndertheInfluenceDrugsTextBox, "Test");
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinionDrugsValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalDetailsofAccidentValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalDetailsofAccidentValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODMedicalOpinionBasisDetailsTextBox, "Fever");
            ObjectRepository.Driver.FindElements(LODMedicalDetailsofAccidentValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalAttPhysicianNameValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalAttPhysicianNameValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODMedicalAttPhysNameTextBox, "Dr. Frankenstine");
            ObjectRepository.Driver.FindElements(LODMedicalAttPhysicianNameValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalAttPhysicianDateValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalAttPhysicianDateValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODMedicalAttPhysDate, (UIActions.SelectDate(Convert.ToInt32(-170))));
            ObjectRepository.Driver.FindElements(LODMedicalAttPhysicianDateValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinionsFutureDisabilityValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinionsFutureDisabilityValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesLikelyClaim);
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinionsFutureDisabilityValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinionsMentalSoundValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinionsMentalSoundValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesMentallySound);
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinionsMentalSoundValidateMess).Count.Should().Be(0);
        }

        public void VerifyValidationsFormal()
        {
            UIActions.GetElement(LODMedicalDispositionPatienteValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalDispositionPatienteValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODMedPatientDisposition, "Out Patient");
            ObjectRepository.Driver.FindElements(LODMedicalDispositionPatienteValidationMess).Count.Should().Be(0);

            UIActions.ClearTextBox(LODMedicalHospitalNameTextBox);
            UIActions.GetElement(LODMedicalHospitalNameValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalHospitalNameValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODMedicalHospitalNameTextBox);
            UIActions.TypeInTextBoxAndEnter(LODMedicalHospitalNameTextBox, "Our Lady of MacGuffin");
            ObjectRepository.Driver.FindElements(LODMedicalHospitalNameValidationMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalNatureIncidentValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalNatureIncidentValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODMedNatureofIncident, "Injury");
            ObjectRepository.Driver.FindElements(LODMedicalNatureIncidentValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalDiagnosisValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalDiagnosisValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODMedicalShowDiagnosisPanel);
            UIActions.JSClickElement(MedExactMatch);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 10);
            UIActions.TypeInTextBox(MedExactMatchSearchTextBox, "S061X7A");
            UIActions.JSClickElement(MedSearchDiagnosisButton);
            UIActions.ClickElement(MedicalDiagnosisFirstEntry);
            UIActions.JSClickElement(MedAddDiagnosisButton);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
            ObjectRepository.Driver.FindElements(LODMedicalDiagnosisValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinAlcoholValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinAlcoholValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesInfluenceofAlcohol);
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinAlcoholValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinionDrugsValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinionDrugsValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesInfluenceofDrugs);
            UIActions.GetElement(LODMedicalSpecifyValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalSpecifyValidationMess).Text.Should().BeEquivalentTo("Required");          
            UIActions.TypeInTextBox(MedUndertheInfluenceDrugsTextBox, "Test");
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinionDrugsValidateMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODMedicalSpecifyValidationMess).Count.Should().Be(1);

            UIActions.GetElement(LODMedicalDetailsofAccidentValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalDetailsofAccidentValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODMedicalOpinionBasisDetailsTextBox, "Fever");
            ObjectRepository.Driver.FindElements(LODMedicalDetailsofAccidentValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalAttPhysicianNameValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalAttPhysicianNameValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODMedicalAttPhysNameTextBox, "Dr. Frankenstine");
            ObjectRepository.Driver.FindElements(LODMedicalAttPhysicianNameValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalAttPhysicianDateValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalAttPhysicianDateValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(LODMedicalAttPhysDate, (UIActions.SelectDate(Convert.ToInt32(-170))));
            ObjectRepository.Driver.FindElements(LODMedicalAttPhysicianDateValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinionsFutureDisabilityValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinionsFutureDisabilityValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesLikelyClaim);
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinionsFutureDisabilityValidateMess).Count.Should().Be(0);

            UIActions.GetElement(LODMedicalMedOpinionsMentalSoundValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMedOpinionsMentalSoundValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(MedYesMentallySound);
            ObjectRepository.Driver.FindElements(LODMedicalMedOpinionsMentalSoundValidateMess).Count.Should().Be(0);

            UIActions.TypeInTextBox(LODMedicalDateAdmittedTextBox, (UIActions.SelectDate(0) + " 0000"));
            UIActions.TypeInTextBox(LODMedicalDateExamTextBox, (UIActions.SelectDate(-1) + " 0000"));
            UIActions.GetElement(LODMedicalExaminedDateValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalExaminedDateValidationMess).Text.Should().BeEquivalentTo("Examination Date must be after the Admission Date.");
            UIActions.ClearTextBox(LODMedicalDateExamTextBox);
            UIActions.TypeInTextBox(LODMedicalDateExamTextBox, (UIActions.SelectDate(1) + " 0000"));
            ObjectRepository.Driver.FindElements(LODMedicalExaminedDateValidationMess).Count.Should().Be(1);

            UIActions.JSClickElement(MedYesBloodAlcoholTestMade);
            UIActions.GetElement(LODMedicalMgAlcoholValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalMgAlcoholValidateMess).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByIndex(MedMgBloodAlcoholTest, 3);
            ObjectRepository.Driver.FindElements(LODMedicalMgAlcoholValidateMess).Count.Should().Be(0);

            UIActions.TypeInTextBox(LODMedicalAttPhysDate, (UIActions.SelectDate(Convert.ToInt32(-1))));
            UIActions.GetElement(LODMedicalAttPhysicianDateInvalidValidateMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODMedicalAttPhysicianDateInvalidValidateMess).Text.Should().BeEquivalentTo("Attending Physician Date must be after the Admission Date.");
            UIActions.ClearTextBox(LODMedicalAttPhysDate);
            UIActions.TypeInTextBox(LODMedicalAttPhysDate, (UIActions.SelectDate(1) + " 0000"));
            ObjectRepository.Driver.FindElements(LODMedicalAttPhysicianDateInvalidValidateMess).Count.Should().Be(1);
        }
    }
}
