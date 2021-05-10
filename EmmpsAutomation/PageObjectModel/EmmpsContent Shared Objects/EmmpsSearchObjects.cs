using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.EmmpsContent_Shared_Objects
{
    public class EmmpsSearchObjects
    {
        public By TextBoxSSNSearch = By.Id("MEDCHARTContent_EmmpsContent_TextBoxSsnSearch");
        public By TextBoxNameSearch = By.Id("MEDCHARTContent_EmmpsContent_TextBoxNameSearch");
        public By TextBoxCaseIdSearch = By.Id("MEDCHARTContent_EmmpsContent_TextBoxCaseIdSearch");
        public By TextBoxEDIPISearch = By.Id("MEDCHARTContent_EmmpsContent_txtEDIPI");
        public By DropDownListStatus = By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By DropDownListWorkflow = By.Id("MEDCHARTContent_EmmpsContent_DropDownListWorkflow");
        public By DropDownListRegion = By.Id("MEDCHARTContent_EmmpsContent_RegionDropDownList");


        public By SearchIncapActiveDropDown = By.Id("MEDCHARTContent_EmmpsContent_DropDownListActiveCaseOptions");
        public By SearchIncapFilterButton = By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterSearchResults");
        public By SearchIncapSearchLink = By.Id("MEDCHARTContent_EmmpsContent_SearchResultsIncapDisplayGrid_GridViewIncapCaseFilterResults_LinkButtonCaseId_0");
        public By INCAPFilterResultsRow0CaseIDLink => By.Id("MEDCHARTContent_EmmpsContent_LodDisplayGridCaseHistory_GridViewMyLodsFilterResults_LinkButtonSelect_0");



        public By FilterByDateCreated => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_LodDisplayGridCaseHistory_GridViewMyLodsFilterResults\"]/tbody/tr[1]/th[10]/a");

        #region INCAP
        public By ButtonExportMyIncaps = By.Id("MEDCHARTContent_EmmpsContent_ButtonExportMyIncaps");
        public By ButtonFilterMyIncaps = By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterMyIncaps");
        public By MyIncapStartLink = By.Id("MEDCHARTContent_EmmpsContent_MyIncapsDisplayGrid_GridViewIncapCaseFilterResults_LinkButtonCaseId_0");
        public By INCAPFilterCasebyDate = By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_MyIncapsDisplayGrid_GridViewIncapCaseFilterResults\"]/tbody/tr[1]/th[9]/a");
        
        public By MyINCAPFilterResultsRow0CaseIDLink => By.Id("MEDCHARTContent_EmmpsContent_MyIncapsDisplayGrid_GridViewIncapCaseFilterResults_LinkButtonCaseId_0");

        public By INCAPSelectFirstCase => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_MyIncapsDisplayGrid_GridViewIncapCaseFilterResults_LinkButtonCaseId_0\"]");
        #endregion

    }
}
