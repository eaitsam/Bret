using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODSearchPage
    {
        #region My LODs Search and Filter Objects
        //---------------------------------
        //My LODs Search and Filter Objects
        //---------------------------------

        public By MyLODsFilterButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterMyLods");

        //--HTMLComboBox--//
        public By LODComboBoxRegion => By.Id("MEDCHARTContent_EmmpsContent_RegionDropDownList_RegionDropDownList");
        public By LODComboBoxStatus => By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By LODComboBoxWorkflow => By.Id("MEDCHARTContent_EmmpsContent_DropDownListWorkflow");
        public By LODComboBoxActive => By.Id("MEDCHARTContent_EmmpsContent_DropDownListActiveCaseOptions");
        public By LODComboBoxStation => By.Id("MEDCHARTContent_EmmpsContent_StationDropDownList_StationDropDownList");
        //--TextBoxes--//
        public By LODTextBoxCaseIDSearch => By.Id("MEDCHARTContent_EmmpsContent_TextBoxCaseIdSearch");
        public By LODTextBoxSSNSearch => By.Id("MEDCHARTContent_EmmpsContent_TextBoxSsnSearch");
        public By LODTextBoxNameSearch => By.Id("MEDCHARTContent_EmmpsContent_TextBoxNameSearch");
        public By LODTextBoxEdipin => By.Id("MEDCHARTContent_EmmpsContent_txtEDIPI");

        public By LODDocType => By.Id("CancelButton");
        public By LODsWith => By.Id("MEDCHARTContent_EmmpsContent_LodsWithDropDownList");

        //--Hyperlinks and Buttons--//
        public By SearchResultsFilterButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterSearchResults");
        //--Filtered Results Table--//
        public By FilterResultsRow0CaseIDLink => By.Id("MEDCHARTContent_EmmpsContent_MyLodsDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_0");

        public By SearchLODRow0CaseIDLink => By.Id("MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_0");

        public By SearchFilterResultsRow0CaseIDLink => By.Id("MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_0");
        public By MyLodFilteredResultsDisplayGrid => By.Id("MEDCHARTContent_EmmpsContent_MyLodsDisplayGrid_UpdatePanelMyLodFilterResults");
        public By TrackingExpandYes => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div[1]/span[1]/span[2]/label[2]");
        public By MyAccountLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_MyAccountHyperLink");

        //--Sorting Links--//
        //public By FilterByDateCreated => By.LinkText("javascript:__doPostBack('ctl00$ctl00$MEDCHARTContent$EmmpsContent$MyLodsDisplayGrid$GridViewMyLodsFilterResults','Sort$CreatedDate')");
        public By FilterByDateCreated => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_MyLodsDisplayGrid_GridViewMyLodsFilterResults\"]/tbody/tr[1]/th[9]/a");
        //*[@id="MEDCHARTContent_EmmpsContent_MyLodsDisplayGrid_GridViewMyLodsFilterResults"]/tbody/tr[1]/th[9]/a
        //public By FilterByDateCreated => By.LinkText("Date Created");


        #endregion

        #region Expected Values
        public List<string> RegionStatesList => new List<string> { "--Select--", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "HQ NGB", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "OCONUS", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        #endregion


        private void SelectResult()
        {
            DebuggingHelpers.Log.Debug("In Select Result");
            if (UIActions.IsElementPresent(FilterResultsRow0CaseIDLink))
            {
                WaitMethods.Wait(FilterResultsRow0CaseIDLink, 60);
                UIActions.JSClickElement(FilterResultsRow0CaseIDLink);
            }
            else
            {
                WaitMethods.Wait(SearchFilterResultsRow0CaseIDLink, 60);
                UIActions.JSClickElement(SearchFilterResultsRow0CaseIDLink);
            }
        }
        //private void SelectCaseID(string caseID)
        //{
        //    DebuggingHelpers.Log.Debug("In Selecting CaseID");
        //    Thread.Sleep(750);
        //    int numRows = UIActions.GetNumberOfElements(By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_')]"));
        //    int row;
        //    string id = "MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_";

        //    for (row = 0; row < numRows; row++)
        //    {
        //        if (UIActions.GetElement(By.Id(id + row)).Text == caseID)
        //        {
        //            //WaitMethods.Wait(SearchFilterResultsRow0CaseIDLink);
        //            UIActions.JSClickElement(By.Id(id + row));
        //            break;
        //        }
        //        if (UIActions.GetElement(By.Id(id + row)).Text.Equals(caseID))
        //        {
        //            //WaitMethods.Wait(SearchFilterResultsRow0CaseIDLink);
        //            UIActions.JSClickElement(By.Id(id + row));
        //            break;
        //        }

        //    }
        //    SelectResult();

        //}

        public void VerifyFieldsOnMyLodsPage()
        {
            Assert.True(UIActions.IsElementPresent(LODTextBoxSSNSearch));
            Assert.True(UIActions.IsElementPresent(LODTextBoxNameSearch));
            Assert.True(UIActions.IsElementPresent(LODTextBoxCaseIDSearch));
            Assert.True(UIActions.IsElementPresent(LODTextBoxEdipin));
            Assert.True(UIActions.IsElementPresent(LODComboBoxStatus));
            Assert.True(UIActions.IsElementPresent(LODComboBoxWorkflow));
            Assert.True(UIActions.IsElementPresent(LODComboBoxRegion));
            //Assert.True(UIActions.IsElementPresent(LODExportExcelButton));
            //Assert.True(UIActions.IsElementPresent(MyLODsFilterButton));

        }

        public void VerifySearchStatusDropdownList(string statusList)
        {
            List<string> resultList = statusList.Split(',').ToList();

            Assert.True(UIActions.ComboboxInnerTextValidator(LODComboBoxStatus, resultList));


        }

        public void VerifySearchWorkflowDropdownList(string workflowList)
        {
            List<string> resultList = workflowList.Split(',').ToList();
            Assert.True(UIActions.ComboboxInnerTextValidator(LODComboBoxWorkflow, resultList));

        }

        public void VerifySearchRegionList()
        {
            string region = "-- All --,Alabama,Alaska,Arizona,Arkansas,California,Colorado,Connecticut,Delaware,District of Columbia,Florida,Georgia,Guam,Hawaii,Idaho,Illinois,Indiana,Iowa,Kansas,Kentucky,Louisiana,Maine,Maryland,Massachusetts,Michigan,Minnesota,Mississippi,Missouri,Montana,Nebraska,Nevada,New Hampshire,New Jersey,New Mexico,New York,North Carolina,North Dakota,Ohio,Oklahoma,Oregon,Pennsylvania,Puerto Rico,Rhode Island,South Carolina,South Dakota,Tennessee,Texas,Utah,Vermont,Virgin Islands,Virginia,Washington,West Virginia,Wisconsin,Wyoming";
            List<string> resultList = region.Split(',').ToList();
            Assert.True(UIActions.ComboboxInnerTextValidator(LODComboBoxRegion, resultList));

        }
        public void CaseIdEntryFilterSelect(string caseID)
        {
            UIActions.TypeInTextBox(LODTextBoxCaseIDSearch, caseID);
            UIActions.JSClickElement(MyLODsFilterButton);
            UIActions.JSClickElement(FilterResultsRow0CaseIDLink);

        }
        public void CaseIdStatusWorkflowEntryFilterSelect(string caseID, string workflow, string status)
        {
            workflow = workflow.StripQuotes();
            status = status.StripQuotes();
            DebuggingHelpers.Log.Info("In CaseIdStatusWorkflowEntryFilterSelect");
            DebuggingHelpers.Log.Info($"Workflow: >>{workflow}<<   Status: >>{status}<<");
            UIActions.SelectElementByText(LODComboBoxStatus, status);
            UIActions.SelectElementByText(LODComboBoxWorkflow, workflow);
            FindFilterButton().Click();
            DebuggingHelpers.Log.Debug("After FindFilterbutton Click");
            SelectResult();

            DebuggingHelpers.Log.Info("After CaseIdStatuswork");

        }


        public void CaseIdActiveWorkflowEntryFilterSelect(string workflow, string active, string caseID)
        {
            DebuggingHelpers.Log.Info("In CaseIdActiveWorkflowEntryFilterSelect");
            DebuggingHelpers.Log.Info($"Workflow: >>{workflow}<<   SActive: >>{active}<<");
            UIActions.SelectElementByText(LODComboBoxActive, active);
            UIActions.SelectElementByText(LODComboBoxWorkflow, workflow);
            FindFilterButton().Click();
            DebuggingHelpers.Log.Debug("After FindFilterbutton Click");
            SelectResult();

            DebuggingHelpers.Log.Info("After CaseIdActiveWork");

        }
        public void WorkflowActiveStationEntryFilter(string workflow, string active, string station)
        {
            DebuggingHelpers.Log.Info("In WorkflowActiveStationEntryFilter");
            DebuggingHelpers.Log.Info($"Workflow: >>{workflow}<<   Active: >>{active}<<   Station: >>{station}<<");
            UIActions.SelectElementByText(LODComboBoxWorkflow, workflow);
            UIActions.SelectElementByText(LODComboBoxActive, active);
            UIActions.SelectElementByText(LODComboBoxStation, station);
            FindFilterButton().Click();
            DebuggingHelpers.Log.Debug("After FindFilterbutton Click");

        }
        private IWebElement FindFilterButton()
        {
            if (UIActions.IsElementPresent(MyLODsFilterButton))
            {
                DebuggingHelpers.Log.Debug("Returning MyLodsFilterbutton");
                return UIActions.GetElement(MyLODsFilterButton);
            }
            else
            {
                DebuggingHelpers.Log.Debug("Returning SearchFilterbutton");
                return UIActions.GetElement(SearchResultsFilterButton);
            }
        }

    }

}
