using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmmpsAutomation.PageObjectModel.LOD;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class MMSOAuthorizations
    {
        //Pre Authorizations
        //--> Filter Results
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
        public By MemberDataRankDropDown => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_RankDropDownList");
        //MMSO Pre-Authorizations Options
        public By MemberUIUC => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_TextBoxMemberUic");
        public By MemberUIUCVerify => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_LinkButtonVerifyUic");
        public By ChainOfCommand => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_trChainOfCommand");
        public By Region => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_trRegion");
        public By Workflow => By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_DropDownListWorkflows");
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








    }
}
