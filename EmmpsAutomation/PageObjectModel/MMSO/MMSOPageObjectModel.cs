using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmmpsAutomation.PageObjectModel.LOD;
using MedchartSeleniumAutomationCore.Core_Framework;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class MMSOPageObjectModel
    {
        //Pre Authorizations
        //--> Filter Results
        public By FilterResultsSSN => By.Id("MEDCHARTContent_EmmpsContent_TextBoxSsnSearch");
        public By FilterResultsName => By.Id("MEDCHARTContent_EmmpsContent_TextBoxNameSearch");
        public By FilterResultsCaseID => By.Id("MEDCHARTContent_EmmpsContent_TextBoxCaseIdSearch");
        public By FilterResultsEDIPIN => By.Id("MEDCHARTContent_EmmpsContent_txtEDIPI");
        public By FilterResultsRegion => By.Id("MEDCHARTContent_EmmpsContent_RegionDropDownList_RegionDropDownList");
        public By FilterResultsStatus => By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By FilterResultsWorkflow => By.Id("MEDCHARTContent_EmmpsContent_DropDownListWorkflow");
        public By FilterResultsPriority => By.Id("MEDCHARTContent_EmmpsContent_DropDownListPriority");
        public By ExportToExcel => By.Id("MEDCHARTContent_EmmpsContent_ButtonExportMyPreAuthorizations");
        public By Filter => By.Id("MEDCHARTContent_EmmpsContent_ButtonExportMyPreAuthorizations");
        public By RowsPerPage => By.Id("MEDCHARTContent_EmmpsContent_MyPreAuthorizationsDisplayGrid_ddrcRowCount_ddlPageRows");

        public By PreAuthCaseID => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[1]/a");
        public By PreAuthLODPDHRA => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[2]/a");
        public By PreAuthWorkflow => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[3]/a");
        public By PreAuthName => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[4]/a");
        public By PreAuthUIC => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[5]/a");
        public By PreAuthRegion => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[6]/a");
        public By PreAuthStatus => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[7]/a");
        public By PreAuthPriority => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[8]/a");
        public By PreAuthDateReceived => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[9]/a");

        //Start New Pre Authorizations
        //--> Soldier Search and Select
        public By SoldierFirstName => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_FirstNameText");
        public By SoldierLastName => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_LastNameText");
        public By SoldierSSN => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SSNText");
        public By SoldierEDIPI => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_EDIPIText");
        public By SoldierSearchButton => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SearchButton");

        //Member Data 
        public By FullNameFieldLabel => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory\"]/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[1]/td[2]");
        public By SSNFieldLabel => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[2]/td[1]");
        public By EDIPINFieldLabel => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[3]/td[1]");
        public By ComponentFieldLabel => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[4]/td[1]");
        public By DataDOBFieldLabel => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[5]/td[1]");

        public By FullNameFieldValue => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[1]/td[2]");

        public By SSNFieldValue => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[2]/td[2]");
        public By EDIPINFieldValue => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[3]/td[2]");
        public By ComponentFieldValue => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[4]/td[2]");
        public By DataDOBFieldValue => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[1]/div/div/div/table/tbody/tr[5]/td[2]");
        public By MemberDataRankDropDown => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_RankDropDownList");

        //Member data validations string
        public string FullNameExpectedValue = "RODGERS BERTHA MAXINE";
        public string SSNExpectedValue = "919009325";
        public string EDIPINExpectedValue = "";
        public string ComponentExpectedValue = "National Guard";
        public string DOBExpectedValue = "19831023";

        
        //MMSO Forms Tab
        public By MMSOFormsTab => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOMMSO FormsMenuLinkButton");
        public By RankOrGradeMDS1 => By.Id("MEDCHARTContent_EmmpsContent_RankDropDownList2");

        public By BranchOfService => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormTwoPanel\"]/div[1]/div[1]/div[1]/div[1]");
        public string BranchOfServiceExpectedValue = "1. Branch of Service";
        public By BranchOfServiceDropDown => By.Id("MEDCHARTContent_EmmpsContent_BranchOfServiceDropdownList2");

        //MMSO Pre-Authorizations Options
        public By MemberUIUC => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_TextBoxMemberUic");
        public By MemberUIUCVerify => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_LinkButtonVerifyUic");
        public By ChainOfCommandDropDown => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_trChainOfCommand");
        public By RegionDropDown => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_trRegion");
        public By WorkflowDropDown => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_DropDownListWorkflows");
        public By ActionCreateMMSO => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_LinkButtonCreateMmso");
        public By ActionStartOver => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_LinkButtonStartOver");

        //Existing Worksheets
        public By ExistingWorkSheetsCaseID => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[1]/a");
        public By ExistingWorkSheetsWorkFlow => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[2]/a");
        public By ExistingWorkSheetsName => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[3]/a");
        public By ExistingWorkSheetsUIC => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[4]/a");
        public By ExistingWorksheetsRegion => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[5]/a");
        public By ExistingWorkSheetsStatus => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[6]/a");
        public By ExistingWorkSheetsDiagnosis => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[7]/a");
        public By ExistingWorkSheetsDateReceived => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[1]/div/div/table/tbody/tr[1]/th[8]/a");


        public By CaseID1ExistingWorksheet => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets_LinkButtonCaseId_0");
        public By CaseID2ExistingWorksheet => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets_LinkButtonCaseId_1");
        public By CaseID3ExistingWorksheet => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets_LinkButtonCaseId_2");


        public By Workflow11ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[2]/td[2]");
        public string Workflow1ExpectedValue = "NG Restricted Followup Care Pre-Auth [Form 02]";

        public By Workflow2ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[3]/td[2]");
        public string Workflow2ExpectedValue = "NG Restricted Followup Care Pre-Auth [Form 02]";

        public By Workflow3ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[4]/td[2]");
        public string Workflow3ExpectedValue = "NG Restricted Pre-Auth [Form 01]";


        public By Name1ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[2]/td[3]/span");
        public string Name1ExpectedValue = "RODGERS BERTHA MAXINE";

        public By Name2ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[3]/td[3]/span");
        public string Name2ExpectedValue = "RODGERS BERTHA";

        public By Name3ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[4]/td[3]/span");
        public string Name3ExpectedValue = "RODGERS BERTHA";


        public By UIC1ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[2]/td[4]");
        public string UIUC1ExpectedValue = "WP1XAD";

        public By UIC2ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[3]/td[4]");
        public string UIUC2ExpectedValue = "WP1XAD";

        public By UIC3ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[4]/td[4]");
        public string UIUC3ExpectedValue = "WP1XAD";


        public By Region1ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[2]/td[5]");
        public string Region1ExpectedValue = "Virginia";

        public By Region2ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[3]/td[5]");
        public string Region2ExpectedValue = "Virginia";

        public By Region3ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[4]/td[5]");
        public string Region3ExpectedValue = "Virginia";


        public By Status1ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[2]/td[6]");
        public string Status1ExpectedValue = "Pre-Authorization Approved (NG)";

        public By Status2ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[3]/td[6]");
        public string Status2ExpectedValue = "Restricted MMSO Draft (NG)";

        public By Status3ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[4]/td[6]");
        public string Status3ExpectedValue = "Pre-Authorization Approved (NG)";


        public By Diagnosis1ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[2]/td[7]");
        public string Diagnosis1ExpectedValue = "J4520 Mild intermittent asthma, uncomplicated -1";

        public By Diagnosis2ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[3]/td[7]");
        public string Diagnosis2ExpectedValue = "A8109 Other Creutzfeldt-Jakob disease;";

        public By Diagnosis3ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[4]/td[7]");
        public string Diagnosis3ExpectedValue = "A0100 Typhoid fever, unspecified	";


        public By DateReceived1ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[2]/td[8]/span");
        public string DataReceived1ExpectedValue = "20180331";

        public By DateReceived2ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[3]/td[8]/span");
        public string DataReceived2ExpectedValue = "20180403";

        public By DateReceived3ExistingWorksheet => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewExistingWorksheets\"]/tbody/tr[4]/td[8]/span");
        public string DataReceived3ExpectedValue = "20180404";

        

        //Eligible LODS

        public By EligibleLODAssociateMMSO => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[1]");
        public By EligibleLODSCaseID => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[2]/a");
        public By EligibleLODWorkflow => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[3]/a");
        public By EligibleLODName => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[4]/a");
        public By EligibleLODUIC => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[5]/a");
        public By EligibleLODRegion => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[6]/a");
        public By EligibleLODStatus => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[7]/a");
        public By EligibleLODDiagnosis => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[8]/a");
        public By EligibleLODDateReceived => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/table/tbody/tr/td/div[3]/div/div/div/div[2]/div/div/table/tbody/tr[1]/th[9]/a");



        public By AssociateMMSOCheckboxLOD => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods_CheckBoxSelectedLod_0");

        public By CaseIDEligibleLOD2 => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods_LinkButtonCaseId_0");

        public By WorkflowEligibleLOD2 => By.Id("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods\"]/tbody/tr[2]/td[3]");
        public string WorkflowEligibleExpectedValue = "NG Restricted Assault (Informal)";

        public By NameEligibleLOD2 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods\"]/tbody/tr[2]/td[4]/span");
        public string NameEligibleExpectedValue = "RODGERS BERTHA";

        public By UICEligibleLOD2 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods\"]/tbody/tr[2]/td[5]");
        public string UIUCEligibleExpectedValue = "WP1XAD";

        public By RegionEligibleLOD2 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods\"]/tbody/tr[2]/td[6]");
        public string RegionEligibleExpectedValue = "Virginia";

        public By StatusEligibleLOD2 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods\"]/tbody/tr[2]/td[7]");
        public string StatusEligibleExpectedValue = "ILD (NG)";

        public By DiagnosisEligibleLOD2 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods\"]/tbody/tr[2]/td[8]");
        public string DiagnosisEligibleExpectedValue = "A8109 Other Creutzfeldt-Jakob disease";

        public By DateReceivedEligibleLOD2 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleLods\"]/tbody/tr[2]/td[9]/span");
        public string DataReceivedEligibleExpectedValue = "20171129";


        //Eligible Worksheets
        public By EligibleWorksheetAssociateMMSOCheckBox => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleWorksheets_CheckBoxSelectedWorksheet_0");
        public By EligibleWorksheetWorkFlow1 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_GridViewEligibleWorksheets\"]/tbody/tr[2]/td[3]");


        //Search Pre Authorizations
        //--> Search Criteria
        public By SearchCriteriaSSN => By.Id("MEDCHARTContent_EmmpsContent_TextBoxSsnSearch");
        public By SearchCriteriaName => By.Id("MEDCHARTContent_EmmpsContent_TextBoxNameSearch");
        public By SearchCriteriaCaseID => By.Id("MEDCHARTContent_EmmpsContent_TextBoxCaseIdSearch");
        public By SearchCriteriaEDIPI => By.Id("MEDCHARTContent_EmmpsContent_txtEDIPI");
        public By SearchCriteriaComponentDD => By.Id("MEDCHARTContent_EmmpsContent_DropDownListOrganization");
        public By SearchCriteriaWorkflowDD => By.Id("MEDCHARTContent_EmmpsContent_DropDownListWorkflow");
        public By SearchCriteriaStatus => By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By SearchCriteriaActive => By.Id("MEDCHARTContent_EmmpsContent_DropDownListActiveCaseOptions");
        public By SearchCriteriaAdminClosed => By.Id("MEDCHARTContent_EmmpsContent_DropDownListAdminClosedCaseOptions");
        public By SearchCriteriaDeleted => By.Id("MEDCHARTContent_EmmpsContent_DropDownListDeletedCaseOptions");
        public By SearchCriteriaPriority => By.Id("MEDCHARTContent_EmmpsContent_DropDownListPriorityOptions");
        public By SearchCriteriaRegion => By.Id("MEDCHARTContent_EmmpsContent_RegionDropDownList_RegionDropDownList");
        public By SearchCriteriaMMSOCaseType => By.Id("MEDCHARTContent_EmmpsContent_DropDownListParentReferenceCaseType");
        public By SearchCriteriaExportToExcelBttn => By.Id("MEDCHARTContent_EmmpsContent_ButtonExportSearchResults");
        public By SearchCriteriaFilterButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterSearchResults");

        //Search preauthorization Documents
        public By SearchPreAuthCaseID => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[1]/a");
        public By SearchPreAuthLODPDHRA => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[2]/a");
        public By SearchPreAuth => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[3]/a");
        public By SearchPreAuthWorkFlow => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[3]/a");
        public By SearchPreAuthName => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[4]/a");
        public By SearchPreAuthUIC => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[5]/a");
        public By SearchPreAuthRegion => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[6]/a");
        public By SearchPreAuthStatus => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[7]/a");
        public By SearchPreAuthPriority => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[8]/a");
        public By SearchPreAuthDateReceived => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[9]/a");
        public By SearchPreAuthDateCreated => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[3]/div/div[3]/table/tbody/tr[1]/th[10]/a");

        //Restricted MMSO Draft (NG) Validation
        public By RestrictedMMSODraft => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_CaseStatusLabel");
        public string RestrictedMMSODraftValidationExpectedValue = "Restricted MMSO Draft (NG) Validation";


        //Logout
        public By LogoutLink => By.Id("FixedLogout");
        public By ClickHere => By.XPath("//*[@id=\"PageContent\"]/div/div/div[2]/p[2]/a");

    }
}
