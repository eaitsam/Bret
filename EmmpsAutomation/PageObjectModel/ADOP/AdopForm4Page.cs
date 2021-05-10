using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopForm4Page
    {
        #region My ADOPs Form 4 Tab Objects
        #region HTML Div
        public By ADOPForm4MenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPForm 4MenuDiv");

        public By AdminExceptiontoPolicyYesButton => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_IsAdminExceptionRadioButtonList\"]/label[1]");
        public By AdminExceptiontoPolicyNoButton => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_IsAdminExceptionRadioButtonList\"]/label[2]");

        public By BehaveHealthRelatedYes => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_IsLodHealthRelatedRadioButtonList\"]/label[1]");
        public By BehaveHealthRelatedNo => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_IsLodHealthRelatedRadioButtonList\"]/label[2]");

        public By Form4ChecklistADMEBox => By.Id("MEDCHARTContent_EmmpsContent_ProgramsCheckBoxList_0");
        public By Form4ChecklistINCAPBox => By.Id("MEDCHARTContent_EmmpsContent_ProgramsCheckBoxList_1");
        public By Form4ChecklisMRPBox => By.Id("MEDCHARTContent_EmmpsContent_ProgramsCheckBoxList_2");
        public By Form4ChecklistMRP2Box => By.Id("MEDCHARTContent_EmmpsContent_ProgramsCheckBoxList_3");
        public By Form4ChecklistRCMCBox => By.Id("MEDCHARTContent_EmmpsContent_ProgramsCheckBoxList_4");
        public By Form4ChecklistNoneBox => By.Id("MEDCHARTContent_EmmpsContent_ProgramsCheckBoxList_5");


        public By AddtoADOPDiagnosisButton => By.Id("MEDCHARTContent_EmmpsContent_LODADOPDiagnosis_LinkButtonAddToAdopDiagnosis");
        public By ADOPAddDiagnosisPanelButton => By.Id("MEDCHARTContent_EmmpsContent_LODADOPDiagnosis_ShowDiagnosisPanelButton");
        public By ExactMatchCheckbox => By.Id("MEDCHARTContent_EmmpsContent_LODADOPDiagnosis_icd10DropDown_ExactSearchCheckBox");

        public By ExactMatchDiagnosisCodeTextBox => By.Id("MEDCHARTContent_EmmpsContent_LODADOPDiagnosis_icd10DropDown_ExactSearchTextBox");
        public By FirstEntryDiagnosis => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_LODADOPDiagnosis_icd10DropDown_ICD10ResultsListBox\"]/option");
        
        public By DiagnosisSearchButton => By.Id("MEDCHARTContent_EmmpsContent_LODADOPDiagnosis_icd10DropDown_SearchButton");

        public By PreviousAppealYes => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_HasPreviouslyAppealedRadioButtonList\"]/label[1]");
        public By PreviousAppealNo => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_HasPreviouslyAppealedRadioButtonList\"]/label[2]");
        public By ReceiveINCAPYes => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_IsReceivingIncapacitationPayRadioButtonList\"]/label[1]");
        public By ReceiveINCAPNo => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_IsReceivingIncapacitationPayRadioButtonList\"]/label[2]");

        public By SoldierStatusCombobox => By.Id("MEDCHARTContent_EmmpsContent_OrdersTypeDropDownList2");
        #endregion

        #endregion

    }
}
