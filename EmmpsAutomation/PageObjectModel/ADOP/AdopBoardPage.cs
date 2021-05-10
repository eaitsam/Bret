using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopBoardPage
    {
        #region My ADOPS Board Tab Objects

        #region HTML Div
        public By ADOPBoardMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPBoardMenuDiv");

        #endregion

        #endregion
        public By ADOPSSNTextBox = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPBoardMenuDiv");
        public By NameTextBox = By.Id("MEDCHARTContent_EmmpsContent_TextBoxNameSearch");
        public By CaseIdTextBox = By.Id("MEDCHARTContent_EmmpsContent_TextBoxCaseIdSearch");
        public By EDIPITextBox = By.Id("MEDCHARTContent_EmmpsContent_txtEDIPI");
        public By RegionDropdownBox = By.Id("MEDCHARTContent_EmmpsContent_RegionDropDownList_RegionDropDownList");
        public By StatusDropdownBox = By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By WorkflowDropdownBox = By.Id("MEDCHARTContent_EmmpsContent_DropDownListWorkflow");
        public By ExportExcelButton = By.Id("MEDCHARTContent_EmmpsContent_ButtonExportMyAdops");
        public By FilterButton = By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterSearchResults");
        public By TestCase5 = By.Id("MEDCHARTContent_EmmpsContent_SearchResultsAdopDisplayGrid_GridViewAdopCaseFilterResults_LinkButtonCaseId_5");
        public By TestCase3 = By.Id("MEDCHARTContent_EmmpsContent_SearchResultsAdopDisplayGrid_GridViewAdopCaseFilterResults_LinkButtonCaseId_3");
        public By TestCase1 = By.Id("MEDCHARTContent_EmmpsContent_SearchResultsAdopDisplayGrid_GridViewAdopCaseFilterResults_LinkButtonCaseId_1");
        public By RowsPerPage = By.Id("MEDCHARTContent_EmmpsContent_MyAdopsDisplayGrid_ddrcRowCount_ddlPageRows");

    }
}
