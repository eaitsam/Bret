using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
//using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODAdminTab
    {
        //------------------------//
        //My LOD Admin Tab Objects
        //------------------------//

        public By LODAdminTabStatusDropdown = By.Id("MEDCHARTContent_EmmpsContent_StatusDropDownList");
        // SECTION: Edit Details //

        public By OkButton => By.XPath("/html/body/div[1]/div[3]/div/button");

        //Labels
        public By LODCaseStatusLabel => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_CaseStatusLabel");

        // Status
        public By LODStatusContainer = By.Id("MEDCHARTContent_EmmpsContent_StatusTilePanel");
        public By LODStatusDropdown = By.Id("MEDCHARTContent_EmmpsContent_StatusDropDownList");
        public By LODStatusTrackingComment = By.Id("MEDCHARTContent_EmmpsContent_StatusTrackingTextBox");
        public By LODStatusSelectButton = By.Id("MEDCHARTContent_EmmpsContent_StatusGoButton");
        public By LODAdminStatusTrackingCommentCounter = By.Id("MEDCHARTContent_EmmpsContent_StatusTileCommentsTextBoxCounter");
        public By LODAdminStatusValidationSummary = By.Id("MEDCHARTContent_EmmpsContent_StatusTileValidationSummary");

        // Attached UIC/Region
        public By LODAttachedUICRegionContainer = By.Id("MEDCHARTContent_EmmpsContent_AttachedUICTilePanel");
        public By LODAttachedUICYesRadioButton = By.Id("MEDCHARTContent_EmmpsContent_AttachedUnitRadioButtonList_0");
        public By LODAttachedUICNoRadioButton = By.Id("MEDCHARTContent_EmmpsContent_AttachedUnitRadioButtonList_1");
        public By LODAttachedUICTextBox = By.Id("MEDCHARTContent_EmmpsContent_AttachedUicTextBox");
        public By LODAttachedUICRegionDropdown = By.Id("MEDCHARTContent_EmmpsContent_AttachedUicDropDownList");
        public By LODAttachedUICTrackingComment = By.Id("MEDCHARTContent_EmmpsContent_AttachedUICTrackingTextBox");
        public By LODAttachedUICSelectButton = By.Id("MEDCHARTContent_EmmpsContent_AttachedUicButton");
        public By LODAdminAttachedUICRegionTrackingCommentCounter = By.Id("MEDCHARTContent_EmmpsContent_AttachedUICTileCommentsTextBoxCounter");
        public By LODAdminAttachedUICRegionValidationSummary = By.Id("MEDCHARTContent_EmmpsContent_AttachedUICTileValidationSummary");

        // Delete LOD
        public By LODDeleteContainer = By.Id("MEDCHARTContent_EmmpsContent_DeleteLodTilePanel");
        public By LODDeleteTrackingComment = By.Id("MEDCHARTContent_EmmpsContent_DeleteLodTrackingTextBox");
        public By LODDeleteButton = By.Id("MEDCHARTContent_EmmpsContent_DeleteLodButton");
        public By LODAdminDeleteLODTrackingCommentCounter = By.Id("MEDCHARTContent_EmmpsContent_DeleteLodTileCommentsTextBoxCounter");
        public By LODAdminDeleteLODValidationSummary = By.Id("MEDCHARTContent_EmmpsContent_DeleteTileValidationSummary");

        // UIC/Region
        public By LODUICRegionContainer = By.Id("MEDCHARTContent_EmmpsContent_UICTilePanel");
        public By LODUICRegionTextBox = By.Id("MEDCHARTContent_EmmpsContent_UicTextBox");
        public By LODUICRegionDropdown = By.Id("MEDCHARTContent_EmmpsContent_UicRegionDropDownList");
        public By LODUICRegionTrackingComment = By.Id("MEDCHARTContent_EmmpsContent_UICTrackingTextBox");
        public By LODUICRegionSelectButton = By.Id("MEDCHARTContent_EmmpsContent_UicRegionButton");
        public By LODAdminUICRegionTrackingCommentCounter = By.Id("MEDCHARTContent_EmmpsContent_UICTileCommentsTextBoxCounter");
        public By LODAdminUICRegionValidationSummary = By.Id("MEDCHARTContent_EmmpsContent_UICTileValidationSummary");

        // Admin Close
        public By LODAdminCloseContainer = By.Id("MEDCHARTContent_EmmpsContent_AdminCloseTilePanel");
        public By LODAdminCloseTrackingComment = By.Id("MEDCHARTContent_EmmpsContent_AdminCloseTrackingTextBox");
        public By LODAdminCloseButton = By.Id("MEDCHARTContent_EmmpsContent_AdminCloseButton");
        public By LODAdminAdminCloseTrackingCommentCounter = By.Id("MEDCHARTContent_EmmpsContent_AdminCloseTileCommentsTextBoxCounter");
        public By LODAdminCloseValidationSummary = By.Id("MEDCHARTContent_EmmpsContent_AdminCloseTileValidationSummary");

        //misc
        public By UserDetailsButton => By.Id("MEDCHARTContent_MedchartPagesContent_GetUserDetailsButton");
        public By PermissionOpenButton => By.Id("btnPerm");

        #region Expected Values
        public List<object> AdminUSARManagerWorkflowExpectedValues => new List<object>{ "-- Select --, Appointing Authority Review (AR), DIV(R) Approval LOD Review (AR), DIV(R) LOD Legal Review (AR), DIV(R) LOD Medical Review (AR), DIV(R) LOD Review (AR), HRC Admin LOD Appeal Review (AR), HRC Approval LOD Appeal Review (AR), HRC LOD Compliance Review (AR), I/O - Investigation (AR), LOD Appeal Draft (AR), LOD Draft (AR), MSC Approval LOD Review (AR), MSC LOD Legal Review (AR), MSC LOD Medical Review (AR), MSC LOD Review (AR), MTF Entry (AR), Unit Commander LOD Review (AR), USARC Admin LOD Appeal Review (AR), USARC Admin LOD Review (AR), USARC Approval LOD Appeal Review (AR), USARC Approval LOD Review (AR), USARC LOD Appeal Legal Review (AR), USARC LOD Appeal Medical Review (AR), USARC LOD Legal Review (AR), USARC LOD Medical Review (AR)"};
        public List<object> AdminUSARCG1StatusExpValues => new List<object>{ "-- Select --, Appointing Authority Review (AR), DIV(R) Approval LOD Review (AR), DIV(R) LOD Legal Review (AR), DIV(R) LOD Medical Review (AR), DIV(R) LOD Review (AR), HRC Admin LOD Appeal Review (AR), HRC Approval LOD Appeal Review (AR), HRC LOD Compliance Review (AR), I/O - Investigation (AR), LOD Appeal Draft (AR), LOD Draft (AR), MSC Approval LOD Review (AR), MSC LOD Legal Review (AR), MSC LOD Medical Review (AR), MSC LOD Review (AR), MTF Entry (AR), Unit Commander LOD Review (AR), USARC Admin LOD Appeal Review (AR), USARC Admin LOD Review (AR), USARC Approval LOD Appeal Review (AR), USARC Approval LOD Review (AR), USARC LOD Appeal Legal Review (AR), USARC LOD Appeal Medical Review (AR), USARC LOD Legal Review (AR), USARC LOD Medical Review (AR) "};
        public List<object> AdminSARCManagerStatusExpValues => new List<object> { "-- Select --, Appointing Authority Review(AR), DIV(R) Approval LOD Review(AR), DIV(R) LOD Legal Review(AR), DIV(R) LOD Medical Review(AR), DIV(R) LOD Review(AR), HRC Admin LOD Appeal Review(AR), HRC Approval LOD Appeal Review(AR), HRC LOD Compliance Review(AR), I/O - Investigation(AR), LOD Appeal Draft(AR), LOD Draft(AR), MSC Approval LOD Review(AR), MSC LOD Legal Review(AR), MSC LOD Medical Review(AR), MSC LOD Review(AR), MTF Entry(AR), Unit Commander LOD Review(AR), USARC Admin LOD Appeal Review(AR), USARC Admin LOD Review(AR), USARC Approval LOD Appeal Review(AR), USARC Approval LOD Review(AR), USARC LOD Appeal Legal Review(AR), USARC LOD Appeal Medical Review(AR), USARC LOD Legal Review(AR), USARC LOD Medical Review(AR)"};

        public List<object> DivRAdminTabStatusExpValues => new List<object> { "-- Select --, Appointing Authority Review (AR), DIV(R) Approval LOD Review (AR), DIV(R) LOD Legal Review (AR), DIV(R) LOD Medical Review (AR), DIV(R) LOD Review (AR), HRC Admin LOD Appeal Review (AR), HRC Approval LOD Appeal Review (AR), HRC LOD Compliance Review (AR), I/O - Investigation (AR), LOD Appeal Draft (AR), LOD Draft (AR), MSC Approval LOD Review (AR), MSC LOD Legal Review (AR), MSC LOD Medical Review (AR), MSC LOD Review (AR), MTF Entry (AR), Unit Commander LOD Review (AR), USARC Admin LOD Appeal Review (AR), USARC Admin LOD Review (AR), USARC Approval LOD Appeal Review (AR), USARC Approval LOD Review (AR), USARC LOD Appeal Legal Review (AR), USARC LOD Appeal Medical Review (AR), USARC LOD Legal Review (AR), USARC LOD Medical Review (AR)" };

        public List<object> NGBAdminTabStatusExpValues => new List<object> { "-- Select --, Appointing Authority Review (NG), HRC Admin LOD Appeal Review (NG), HRC Approval LOD Appeal Review (NG), I/O - Investigation (NG), Intermediate Command Review (NG), Investigation Review (NG), LOD Appeal Draft (NG), LOD Draft (NG), MTF Entry (NG), NGB Approval LOD Appeal Review (NG), NGB Approval LOD Review (NG), NGB JAG LOD Appeal Review (NG), NGB JAG LOD Review (NG), NGB LOD Appeal Review (NG), NGB LOD Review (NG), NGB Surgeon Approval LOD Appeal Review (NG), NGB Surgeon Approval LOD Review (NG), NGB Surgeon LOD Appeal Review (NG), NGB Surgeon LOD Review (NG), State Admin LOD Review (NG), State Approval LOD Appeal Review (NG), State Approval LOD Review (NG), State JAG LOD Appeal Review (NG), State JAG LOD Review (NG), State Surgeon LOD Appeal Review (NG), State Surgeon LOD Review (NG), Unit Commander LOD Review (NG)" };


        #endregion

        public void VerifyAdminTabStatus(string workflow, string dropdownlist)
        {
            List<string> resultList = dropdownlist.Split(',').ToList();

            Assert.True(UIActions.ComboboxInnerTextValidator(LODAdminTabStatusDropdown, resultList));

        }

        public void VerifyAdminTab(bool hasTab, string tabName)
        {
            if (tabName == "Admin")
            {
                //if (hasTab)
                //{
                //    Assert.True(UIActions.IsElementPresent(LODAdminMenuLinkButton));
                //}
                //else
                //{
                //    Assert.False(UIActions.IsElementPresent(LODAdminMenuLinkButton));
                //}

            }

        }
        public bool IsStatusLabelCorrect(By locator, string expectedValue)
        {

            IWebElement elem = ObjectRepository.Driver.FindElement(locator);

            string statusLabel = elem.Text;
            //string x = elem.FindElement(By.XPath("//*[containts(@id,'MEDCHARTContent_EmmpsContent_CaseHeader1_CaseStatusLabel')]")).ToString();
            if (statusLabel == expectedValue)
                return true;
            else return false;
        }

        //public void CheckAdminEditDetails()
        //{
        //    //------------------------//
        //    //Check LOD Admin Tab Containers & Objects
        //    //------------------------//

        //    //Status
        //    Assert.True(UIActions.IsElementPresent(LODStatusContainer));
        //    Assert.True(UIActions.IsElementPresent(LODStatusDropdown));
        //    Assert.True(UIActions.IsElementPresent(LODStatusTrackingComment));
        //    Assert.True(UIActions.IsElementPresent(LODStatusSelectButton));
        //    //Attached UIC Region
        //    HtmlComboBox attachedUICDropdown = new HtmlComboBox();
        //    attachedUICDropdown.SearchProperties[HtmlDiv.PropertyNames.Id] = "MEDCHARTContent_EmmpsContent_AttachedUicDropDownList";
        //    if (attachedUICDropdown.Exists)
        //    // Thread.Sleep(5000);
        //    {
        //        Assert.True(UIActions.IsElementPresent(LODAttachedUICRegionContainer));
        //        Assert.True(UIActions.IsElementPresent(LODAttachedUICYesRadioButton));
        //        Assert.True(UIActions.IsElementPresent(LODAttachedUICNoRadioButton));
        //        Assert.True(UIActions.IsElementPresent(LODAttachedUICTextBox));
        //        Assert.True(UIActions.IsElementPresent(LODAttachedUICRegionDropdown));
        //        Assert.True(UIActions.IsElementPresent(LODAttachedUICTrackingComment));
        //        Assert.True(UIActions.IsElementPresent(LODAttachedUICSelectButton));
        //    }

        //    //UIC Region
        //    Assert.True(UIActions.IsElementPresent(LODUICRegionContainer));
        //    Assert.True(UIActions.IsElementPresent(LODUICRegionTextBox));
        //    Assert.True(UIActions.IsElementPresent(LODUICRegionDropdown));
        //    Assert.True(UIActions.IsElementPresent(LODUICRegionTrackingComment));
        //    Assert.True(UIActions.IsElementPresent(LODUICRegionSelectButton));
        //    //Admin Close
        //    Assert.True(UIActions.IsElementPresent(LODAdminCloseContainer));
        //    Assert.True(UIActions.IsElementPresent(LODAdminCloseTrackingComment));
        //    Assert.True(UIActions.IsElementPresent(LODAdminCloseButton));
        //    //Delete LOD
        //    Assert.True(UIActions.IsElementPresent(LODDeleteContainer));
        //    Assert.True(UIActions.IsElementPresent(LODDeleteTrackingComment));
        //    Assert.True(UIActions.IsElementPresent(LODDeleteButton));

        //}
        public void VerifyDropDownListAdminTab()
        {
            //Status
            UIActions.ComboboxInnerTextValidator(LODStatusDropdown, new List<string> { "-- Select --", "DIV(R) Approval LOD Review (AR)", "DIV(R) LOD Legal Review (AR)", "DIV(R) LOD Medical Review (AR)", "DIV(R) LOD Review (AR)", "Unit Commander LOD Review (AR)" });
            //Attached UIC Region
            // UIActions.ComboboxInnerTextValidator(LODAttachedUICRegionDropdown, new List<string> { "-- Select --", "63rd DIV(R)", "7th Civil Spt Cmd", "81st DIV(R)", "88th DIV(R)", "99th DIV(R)", "9th MSC" });
            //UIC Region
            UIActions.ComboboxInnerTextValidator(LODUICRegionDropdown, new List<string> { "-- Select --", "63rd DIV(R)", "7th Civil Spt Cmd", "81st DIV(R)", "88th DIV(R)", "99th DIV(R)", "9th MSC" });
        }
        public void VerifyCharactersRemainingAdminTab()
        {
            //Status
            UIActions.CharactersRemainingValidator(LODStatusTrackingComment, LODAdminStatusTrackingCommentCounter);
            //Attached UIC Region
            // UIActions.CharactersRemainingValidator(LODAttachedUICTrackingComment, LODAdminAttachedUICRegionTrackingCommentCounter);
            //Delete LOD
            UIActions.CharactersRemainingValidator(LODDeleteTrackingComment, LODAdminAdminCloseTrackingCommentCounter);
            //UIC Region
            UIActions.CharactersRemainingValidator(LODUICRegionTrackingComment, LODAdminUICRegionTrackingCommentCounter);
            //Admin Close
            UIActions.CharactersRemainingValidator(LODAdminCloseTrackingComment, LODAdminAdminCloseTrackingCommentCounter);
        }


        //TO DO: remove the HTMLDiv functionality and transition away from Microsoft lib
        public void VerifyValidationErrorMessages()
        {
            //Status
            UIActions.JSClickElement(LODStatusSelectButton);
            CheckErrorMessagesAdminTab(LODAdminStatusValidationSummary, new List<string> { "Status is required.", "A Tracking Comment Is Required." });
            UIActions.JSClickElement(OkButton);
            //Attached UIC Region
            //HtmlComboBox attachedUICDropdown = new HtmlComboBox();
            //attachedUICDropdown.SearchProperties[HtmlDiv.PropertyNames.Id] = "MEDCHARTContent_EmmpsContent_AttachedUicDropDownList";
            //if (attachedUICDropdown.Exists)
            // Thread.Sleep(5000);
            {
                UIActions.ClearTextBox(LODAttachedUICTextBox);
                UIActions.SelectElementByText(LODAttachedUICRegionDropdown, "-- Select --");
                UIActions.JSClickElement(LODAttachedUICSelectButton);
                CheckErrorMessagesAdminTab(LODAdminAttachedUICRegionValidationSummary, new List<string> { "Invalid UIC.", "Region is required.", "Tracking Comment is required." });
                UIActions.JSClickElement(OkButton);
            }
            //Delete LOD
            UIActions.JSClickElement(LODDeleteButton);
            CheckErrorMessagesAdminTab(LODAdminDeleteLODValidationSummary, new List<string> { "A Tracking Comment Is Required." });
            UIActions.JSClickElement(OkButton);
            //UIC Region
            UIActions.ClearTextBox(LODUICRegionTextBox);
            UIActions.SelectElementByText(LODUICRegionDropdown, "-- Select --");
            UIActions.JSClickElement(LODUICRegionSelectButton);
            CheckErrorMessagesAdminTab(LODAdminUICRegionValidationSummary, new List<string> { "Invalid UIC.", "Region is required.", "A Tracking Comment Is Required." });
            UIActions.JSClickElement(OkButton);
            //Admin Close
            UIActions.JSClickElement(LODAdminCloseButton);
            CheckErrorMessagesAdminTab(LODAdminCloseValidationSummary, new List<string> { "A Tracking Comment Is Required." });
            UIActions.JSClickElement(OkButton);
        }

        public void SelectAdminStatusWorflow(string status)
        {
            //WaitMethods.Wait(LODStatusDropdown);
            UIActions.SelectElementByText(LODStatusDropdown, status);
            UIActions.TypeInTextBox(LODStatusTrackingComment, "Automation Team");
            UIActions.JSClickElement(LODStatusSelectButton);
            //WaitMethods.Wait(LODCaseStatusLabel, 60);
            //UIValidations.IsStatusLabelCorrect(LODCaseStatusLabel, status);
        }

        //Method
        public static bool CheckErrorMessagesAdminTab(By locator, List<string> expectedValues)
        {
            IWebElement elem = ObjectRepository.Driver.FindElement(locator);
            IList<IWebElement> options = elem.FindElements(By.TagName("li"));

            foreach (IWebElement option in options)
            {
                if (expectedValues.Contains(option.Text.ToString()))
                    continue;
                else
                    return false;
            }
            return true;
        }



    }
}
