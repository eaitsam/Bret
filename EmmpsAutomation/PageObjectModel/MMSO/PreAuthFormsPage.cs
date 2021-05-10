using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class PreAuthFormsPage
    {
        #region My Pre-Auth MMSO Forms Tab Objects

        #region HTML Div
        public By MMSOFormsMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOMMSO FormsMenuDiv");


        #endregion
        #region HTML Text Boxes

        public By MMSOFormsUnitPhoneTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_CurrentUnitPhoneTextBox1");
        public By MMSOFormsUnitAddressTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_CurrentUnitAddressTextBox1");
        public By MMSOFormsUnitAssignmentNameTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_CurrentUnitOfAssignmentTextBox1");
        public By MMSOFormsMilitaryTreatmentFacilityTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_NearestMtfTextBox1");
        public By MMSOFormsCurrentUnitUICTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_MmsoCurrentUnitUicTextBox1");
        public By MMSOFormsCurrentUnitPOCTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_CurrentUnitPocTextBox1");
        public By MMSOFormsCurrentUnitPOCPhoneTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_CurrentUnitPocPhoneTextBox1");
        public By MMSOFormsCurrentUnitPOCEmailTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_UnitPocEmailTextBox1");
        public By MMSOFormsDistanceToMTFTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_DistanceToMtfTextBox1");
        public By MMSOFormsPatientEmailTextboxForm01 = By.Id("PatientEmailTextBox1");
        public By MMSOFormsPatientPhoneTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_PatientPhoneTextBox1");
        public By MMSOFormsDutyDateFromTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_DutyDateFromTextBox1");
        public By MMSOFormsDutyDateToTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_DutyDateToTextBox1");
        public By MMSOFormsIllnessDateTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_DateOfInjuryTextBox1");
        public By MMSOFormsTreatmentDateToTextboxForm01 = By.Id("MEDCHARTContent_EmmpsContent_TreatedOnTextBox1");
        public By MMSOFormsAddDiagnosisExactMatchTextBoxForm01 = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown1_ExactSearchTextBox");
        public By MMSOFormsFollowUpCareTabFollowupTextboxForm1 = By.Id("MEDCHARTContent_EmmpsContent_FollowUpCareTextBox");
        public By MMSOFormsFollowUpCareTabPreAuthTextboxForm1 = By.Id("MEDCHARTContent_EmmpsContent_PreAuthTextBox");
        public By MMSOFormsFollowUpCareTabPreAuthCorrespondingTextboxForm1 = By.Id("MEDCHARTContent_EmmpsContent_PreAuthCorrespondingTextbox");
        public By MMSOFormsPatientAddressTextbox = By.Id("MEDCHARTContent_EmmpsContent_PatientAddressTextBox2");
        public By MMSOFormsPatientEmailTextbox = By.Id("MEDCHARTContent_EmmpsContent_PatientEmailTextBox2");
        public By MMSOFormsPatientPhoneTextbox = By.Id("MEDCHARTContent_EmmpsContent_PatientPhoneTextBox2");
        public By MMSOFormsDateOfInjuryTextbox = By.Id("MEDCHARTContent_EmmpsContent_DateOfInjuryTextBox2");
        public By MMSOFormsDutyDateFromTextbox = By.Id("MEDCHARTContent_EmmpsContent_DutyDateFromTextBox2");
        public By MMSOFormsDutyDateToTextbox = By.Id("MEDCHARTContent_EmmpsContent_DutyDateToTextBox2");
        public By MMSOFormsEligibilityDocumentDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_EligibilityDocumentDateTextBox2");
        public By MMSOFormsFollowUpCareTextbox = By.Id("MEDCHARTContent_EmmpsContent_FollowUpCareTextBox2");
        public By MMSOFormsSpecialtyRequestedTextbox = By.Id("MEDCHARTContent_EmmpsContent_SpecialtyRequestedTextBox2");
        public By MMSOFormsMedicalBoardStartDateAndMTFNameTextbox = By.Id("MEDCHARTContent_EmmpsContent_MedicalBoardStartDateAndMtfNameTextBox2");
        public By MMSOFormsNearestMTFTextbox = By.Id("MEDCHARTContent_EmmpsContent_NearestMtfTextBox2");
        public By MMSOFormsCurrentUnitOfAssignmentTextbox = By.Id("MEDCHARTContent_EmmpsContent_CurrentunitOfAssignmentTextBox2");
        public By MMSOFormsDistanceToMTFTextbox = By.Id("MEDCHARTContent_EmmpsContent_DistanceToMtfTextBox2");
        public By MMSOFormsCurrentUnitUICTextbox = By.Id("MEDCHARTContent_EmmpsContent_MmsoCurrentUnitUicTextBox2");
        public By MMSOFormsCurrentUnitPOCTextbox = By.Id("MEDCHARTContent_EmmpsContent_CurrentUnitPocTextBox2");
        public By MMSOFormsCurrentUnitPOCPhoneTextbox = By.Id("MEDCHARTContent_EmmpsContent_CurrentUnitPocPhoneTextBox2");
        public By MMSOFormsCurrentUnitPOCEmailTextbox = By.Id("MEDCHARTContent_EmmpsContent_UnitPocEmailTextBox2");
        public By SsnBox = By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SSNText");
        public By MMSOFormsAddDiagnosisExactMatchTextBox = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown2_ExactSearchTextBox");
        public By MMSOFormsFollowUpCareTabFollowupTextbox = By.Id("MEDCHARTContent_EmmpsContent_FollowUpCareTextBox");
        public By MMSOFormsFollowUpCareTabPreAuthTextbox = By.Id("MEDCHARTContent_EmmpsContent_PreAuthTextBox");
        public By MMSOFormsFollowUpCareTabPreAuthCorrespondingTextbox = By.Id("MEDCHARTContent_EmmpsContent_PreAuthCorrespondingTextbox");
        public By MMSOFormsSurgeryDateRequestTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_DateOfRequestTextBox");
        public By MMSOFormsSurgeryDateOfSurgeryTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_DateOfSurgeryTextBox");
        public By MMSOFormsSurgicalProcedureInformationTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_SurgicalProcedureInformationTextBox");
        public By MMSOFormsSurgeryAddProcedureSearchTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_hcpcsCptCodeSearch_TextBoxKeywordOrCode");
        public By MMSOFormsSurgeryUnitPOCTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_UnitPocNameTextBox");
        public By MMSOFormsSurgeryUnitPOCRankTitleTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_UnitPocRankAndTitleTextBox");
        public By MMSOFormsSurgeryPOCPhoneTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_UnitPocPhoneTextBox");
        public By MMSOFormsSurgeryPOCFaxTextboxForm06 = By.Id("MEDCHARTContent_EmmpsContent_UnitPocFaxNumberTextBox");
        public By MMSOFormsAddDiagnosisExactMatchTextBoxForm06 = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown3_ExactSearchTextBox");

        #endregion
        #region HTML Combo Boxes
        public By MMSOFormsBranchOfServiceComboBox = By.Id("MEDCHARTContent_EmmpsContent_BranchOfServiceDropdownList2");
        public By MMSOFormsRankComboBox = By.Id("MEDCHARTContent_EmmpsContent_RankDropDownList2");
        public By MMSOComboBoxStatus => By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By MMSOComboBoxWorkflow => By.Id("MEDCHARTContent_EmmpsContent_DropDownListWorkflow");
        public By MMSOFllowupCarePriortyComboBox => By.Id("MEDCHARTContent_EmmpsContent_PriorityDropDownList");

        #endregion
        #region HTML Radio Buttons
        public By MMSOFormsTricareRegionNorthButton = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[1]/div[3]/div[4]/div[2]/table/tbody/tr/td[1]/label");
        public By MMSOFormsTricareRegionSouthButton = By.Id("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[1]/div[3]/div[4]/div[2]/table/tbody/tr/td[2]/label");
        public By MMSOFormsTricareRegionWestButton = By.Id("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[1]/div[3]/div[4]/div[2]/table/tbody/tr/td[3]/label");
        public By MMSOFormsMedicalBoardInProcessYesButton = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[2]/div/div[5]/div[1]/div/span/span/label[1]");
        public By MMSOFormsMedicalBoardInProcessNoButton = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[2]/div/div[5]/div[1]/div/span/span/label[2]");
        public By MMSOFormsMTFLocationFromDutyButtonForm02 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[3]/div[1]/div[1]/div[7]/table/tbody/tr/td[1]/label");
        public By MMSOFormsMTFLocationFromResidenceButtonForm02 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[3]/div[1]/div[1]/div[7]/table/tbody/tr/td[2]/label");
        public By MMSOFormsMTFLocationFromDutyButtonForm01 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[3]/div[2]/div[1]/div[7]/table/tbody/tr/td[1]/label");
        public By MMSOFormsMTFLocationFromResidenceButtonForm01 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[3]/div[2]/div[1]/div[7]/table/tbody/tr/td[2]/label");
        public By MMSOFormTypesOfOrdersOtherButtonForm01 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[3]/div[1]/div[1]/div[2]/table/tbody/tr/td[3]/label");
        public By MMSOFormTypesOfOrdersAnnualTrainingButtonForm01 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[3]/div[1]/div[1]/div[2]/table/tbody/tr/td[2]/label");
        public By MMSOFormTypesOfOrdersWeekendDrillButtonForm01 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[3]/div[1]/div[1]/div[2]/table/tbody/tr/td[1]/label");

        #endregion
        #region Dropdowns
        public By MMSOWorkflowDropDownBox = By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_DropDownListWorkflows");
        #endregion
        #region HTML Hyperlinks
        public By MMSOFormsAddDiagnosisLinkButton = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonShowDiagnosisPanel2");
        public By MMSOFormsAddDiagnosisSelect = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[2]/div/div[2]/div[4]/div/div/div[1]/div/table/tbody/tr[10]/td/select/option");
        public By MMSOFormsAddDiagnosisSelectForm01 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[2]/div/div[3]/div[4]/div/div/div[1]/div/table/tbody/tr[10]/td/select/option");
        public By MMSOFormsAddDiagnosisLinkButtonForm01 = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonShowDiagnosisPanel1");
        public By MMSOFormsAddProcedureLinkButtonForm06 = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonShowProcedurePanel6");
        public By MMSOFormsSurgeryAddProcedureSearchButtonForm06 = By.Id("MEDCHARTContent_EmmpsContent_hcpcsCptCodeSearch_LinkButtonSearchProcedures");
        public By MMSOFormsSurgeryAddSelectedProcedureButtonForm06 = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonAddProcedure6");
        public By MMSOFormsSurgeryAddProcedureSelectForm06 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[2]/div/div[4]/div[4]/div/div/div[1]/div[3]/select/option");
        public By MMSOFormsAddDiagnosisLinkButtonForm06 = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonShowDiagnosisPanel3");
        public By MMSOFormsAddDiagnosisSelectForm06 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div[2]/div/div[3]/div[4]/div/div/div[1]/div/table/tbody/tr[10]/td/select/option");

        #endregion
        #region HTML Check Boxes
        public By MMSOFormsEligibilityDocumentLODFormCheckBox = By.Id("MEDCHARTContent_EmmpsContent_EligibilityDocumentCheckboxList2_0");
        public By MMSOFormsEligibilityDocumentOrdersAttendanceRosterCheckBox = By.Id("MEDCHARTContent_EmmpsContent_EligibilityDocumentCheckboxList2_1");
        public By EligibleLODsAssociateMMSOCheckBox = By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods_CheckBoxSelectedLod_0");
        public By MMSOFormsAddDiagnosisExactMatchCheckBox = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown2_ExactSearchCheckBox");
        public By MMSOFormsAddDiagnosisExactMatchCheckBoxForm01 = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown1_ExactSearchCheckBox");
        public By MMSOFormsAddDiagnosisExactMatchCheckBoxForm06 = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown3_ExactSearchCheckBox");
        public By MMSOFormsEligibilityDocumentLODFormCheckBoxForm01 = By.Id("MEDCHARTContent_EmmpsContent_EligibilityDocumentCheckboxList1_0");
        public By MMSOEligibleWorksheetCheckbox = By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleWorksheets_CheckBoxSelectedWorksheet_0");
        #endregion
        #region Buttons
        public By MMSOFormsAddDiagnosisSearchButton = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown2_SearchButton");
        public By MMSOFormsAddDiagnosisButtonForm02 = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonAddDiagnosis2");
        public By MMSOFormsAddDiagnosisButtonForm06 = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonAddDiagnosis3");
        public By MMSOFormsAddDiagnosisSearchButtonForm01 = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown1_SearchButton");
        public By MMSOFormsAddDiagnosisButtonForm01 = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonAddDiagnosis1");
        public By MMSOFormsAddDiagnosisSearchButtonForm06 = By.Id("MEDCHARTContent_EmmpsContent_icd10DropDown3_SearchButton");
        public By MMSOSearchMyFilterButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterMyPreAuthorizations");
        #endregion Buttons


        #endregion

    }
}
