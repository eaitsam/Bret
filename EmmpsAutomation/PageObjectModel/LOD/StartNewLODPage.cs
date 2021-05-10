using MedchartSeleniumAutomationCore.Core_Framework;
using Xunit;
using OpenQA.Selenium;
using System;
using System.Threading;
using FluentAssertions;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class StartNewLODPage
    {
        #region Page Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//
        #region Text Boxes
        public By SsnBox = By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SSNText");
        public By LastName = By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_LastNameText");
        public By EndOfAuthorizedDutyDateBox = By.Id("MEDCHARTContent_EmmpsContent_TextBoxEndOfAuthorizedDutyStatus");
        public By ExceptionToPolicyCommentBox = By.Id("MEDCHARTContent_EmmpsContent_TextBoxExceptionToPolicyComment");
        public By MemberUic = By.Id("MEDCHARTContent_EmmpsContent_MemberUicTextbox");
        #endregion
        #region Buttons 
        public By SearchButton = By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SearchButton");
        public By NextButton = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonNext");
        public By CreateLODButton = By.Id("MEDCHARTContent_EmmpsContent_CreateLodButton");
        public By StartOverLODButton = By.Id("MEDCHARTContent_EmmpsContent_StartOverButton");
        public By StartOverErrorMessageButton = By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_LinkButtonCloseErrorMessage\"]");
        #endregion
        #region DropDowns
        public By ExceptionToPolicy = By.Id("MEDCHARTContent_EmmpsContent_DropDownListExceptionToPolicy");
        public By RowsPerPage = By.Id("MEDCHARTContent_EmmpsContent_LodDisplayGridCaseHistory_ddrcRowCount_ddlPageRows");
        public By WorkflowDropDownBox = By.Id("MEDCHARTContent_EmmpsContent_WorkflowDropDownList");
        public By Region = By.Id("MEDCHARTContent_EmmpsContent_RegionDropDownList");
        public By ChainOfCommand = By.Id("MEDCHARTContent_EmmpsContent_ChainOfCommandDropDownList");
        public By Rank = By.Id("MEDCHARTContent_EmmpsContent_DropDownListRank");

        #endregion
        #region Checkboxes
        public By ABCMRCase = By.Id("MEDCHARTContent_EmmpsContent_CheckBoxABCMRCase");
        public By AGRCase = By.Id("MEDCHARTContent_EmmpsContent_CheckBoxAGRCase");
        public By BehavioralHealthCase = By.Id("MEDCHARTContent_EmmpsContent_CheckBoxBehavioralHealthCase");
        public By IDESCase => By.Id("MEDCHARTContent_EmmpsContent_CheckBoxIDESCase");
        public By IDESCaseByName => By.Name("ctl00$ctl00$MEDCHARTContent$EmmpsContent$CheckBoxIDESCase");

        public By CreateArngAndUsarLodPermissionCheckbox = By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_71_eMMPS_PermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_0");
        #endregion
        #region Html-Pane
        public By CommentChactersRemaining => By.Id("MEDCHARTContent_EmmpsContent_TextBoxExceptionToPolicyComment_output");
        public By LODpermissionTab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_71");
        #endregion
        #region HTML Div
        public By ReqEndOfAuthorizedDutyStatusDateMessage => By.Id("eoadsErrorMessage");
        public By ReqCommentMessage => By.Id("divCommentErrorMessage");
        public By NoExceptionToPolicySelectedMessage => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div[1]/div[2]/div[1]");
        public By StartNewLODTxt => By.Id("LocationPath");
        #endregion
        #region Links
        public By MyAccountLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_MyAccountHyperLink");
        #endregion

        public By ErrorMessageModal => By.Id("MEDCHARTContent_EmmpsContent_ModalPopupExtenderCantCreateLODErrorMessage_foregroundElement");
        public By ErrorModalText => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_PanelCantCreateLODErrorMessage\"]/div[2]/div[1]");
       
        
        #endregion



        #region Page Methods
        public void SoldierSSNSearch(string SSN)
        {
            UIActions.TypeInTextBox(SsnBox, SSN);
            UIActions.JSClickElement(SearchButton);
        }

        public void VerifyRankSelected(string rank)
        {
            WaitMethods.Wait(Rank, 60);
            string checkRank = UIActions.GetDropdownSelectedValue(Rank);

            if (checkRank == "-- Select --")
            {
                UIActions.SelectElementByText(Rank, rank);
            }
        }


        public void VerifyCreateARNGUSARLODAndLODDraftNGPermission()
        {
            UIActions.JSClickElement(LODpermissionTab);
            Thread.Sleep(4000);
            Assert.True(UIActions.IsElementSelected(CreateArngAndUsarLodPermissionCheckbox));
        }

        /// <summary>
        /// Validates that the Exception to Policy reason only shows when the End
        /// of Authorization Date is 180 days or more
        /// </summary>
        /// <param name="exceptionToPolicy"></param>
        public void ValidateSelectExceptionToPolicySection(string exceptionToPolicy, string comments, int date)
        {
            //string date = UIActions.GetTextBoxTextValue(EndOfAuthorizedDutyDateBox);

            //convert to date format
            //date = date.Insert(4, "/");
            //date = date.Insert(7, "/");
            //DateTime endOfAuthDate = DateTime.ParseExact(date, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);

            //string today = DateTime.Now.ToString("yyyy/MM/dd");
            //DateTime todaysDate = Convert.ToDateTime(today);

            //var days = (todaysDate - endOfAuthDate).TotalDays;

            //UIActions.SelectElementByValue(RowsPerPage, "50");//temporarily used to deselct the dated picker field which blocks update to exceptionToPolicy field
            //                                                  //insert wait here???

            UIActions.TypeInTextBoxAndEnter(EndOfAuthorizedDutyDateBox, UIActions.SelectDate(date));

            if (date < -180)
            {
                UIActions.GetElement(ExceptionToPolicy).Enabled.Should().BeTrue();
                UIActions.ComboboxInnerTextValidator(ExceptionToPolicy, "--Select-- Behavioral Health  Death Pre-Approved Other ");

                if (!string.IsNullOrEmpty(exceptionToPolicy))
                {
                    UIActions.SelectElementByText(ExceptionToPolicy, exceptionToPolicy);
                    UIActions.JSClickElement(NextButton);

                    //check for required comment message
                    UIActions.GetElement(ReqCommentMessage).Displayed.Should().BeTrue();
                    if (!string.IsNullOrEmpty(comments))
                    {
                        UIActions.GetElement(ExceptionToPolicyCommentBox).SendKeys(comments);
                        UIActions.CharactersRemainingValidator(ExceptionToPolicyCommentBox, CommentChactersRemaining);
                    }

                    UIActions.JSClickElement(NextButton);
                }
                else if (string.IsNullOrEmpty(exceptionToPolicy))
                {
                    //Verify error message as follows when End Of Authorized Duty Date greater than 180 days but no exception to policy is entered
                    //"No LOD can be created due to the End of Authorized Duty Status date entered. Your attempt to create an LOD has been logged. Please Contact Your eMMPS ARNG/USAR Manager." 
                    UIActions.JSClickElement(NextButton);
                    //check for required comment message
                    UIActions.GetElement(ReqCommentMessage).Displayed.Should().BeTrue();

                    if (!string.IsNullOrEmpty(comments))
                    {
                        UIActions.GetElement(ExceptionToPolicyCommentBox).SendKeys(comments);
                        UIActions.CharactersRemainingValidator(ExceptionToPolicyCommentBox, CommentChactersRemaining);
                    }
                    UIActions.JSClickElement(NextButton);
                    //look for error message 
                    UIActions.GetElement(NoExceptionToPolicySelectedMessage).Displayed.Should().BeTrue();
                    UIActions.GetElements(ErrorModalText).Text.Should().BeEquivalentTo("No LOD can be created due to the End of Authorized Duty Status date entered. Your attempt to create an LOD has been logged. Please Contact Your eMMPS ARNG/USAR Manager.");
                    UIActions.JSClickElement(StartOverErrorMessageButton);

                }              
                                       

            }
            else
            {
                UIActions.GetElement(ExceptionToPolicy).Enabled.Should().BeFalse();

                UIActions.JSClickElement(NextButton);
                //check to make sure required comment message does exist
                // Assert.IsFalse(UIValidations.IsElementPresent(ReqCommentMessage));

                if (!string.IsNullOrEmpty(comments))
                {
                    UIActions.GetElement(ExceptionToPolicyCommentBox).SendKeys(comments);
                    UIActions.CharactersRemainingValidator(ExceptionToPolicyCommentBox, CommentChactersRemaining);
                }

                UIActions.JSClickElement(NextButton);
            }

            
            
            
        }

        public void VaildateLODOptionsSection(string exceptionToPolicy)
        {
            //verify fields exist
            UIActions.GetElement(MemberUic).Displayed.Should().BeTrue();
            UIActions.GetElement(Region).Displayed.Should().BeTrue();
            UIActions.GetElement(WorkflowDropDownBox).Displayed.Should().BeTrue();
            UIActions.GetElement(ChainOfCommand).Displayed.Should().BeTrue();
            UIActions.GetElement(ABCMRCase).Displayed.Should().BeTrue();
            UIActions.GetElement(AGRCase).Displayed.Should().BeTrue();
            UIActions.GetElement(BehavioralHealthCase).Displayed.Should().BeTrue();
            UIActions.GetElement(IDESCase).Displayed.Should().BeTrue();
            UIActions.GetElement(CreateLODButton).Displayed.Should().BeTrue();
            UIActions.GetElement(StartOverLODButton).Displayed.Should().BeTrue();

            //get Chain of Command value in order to check workflow list and region list
            string command = UIActions.GetDropdownSelectedValue(ChainOfCommand);

            ValidateWorkflowList(command, exceptionToPolicy);

            if (command == "National Guard")
            {
                UIActions.ComboboxInnerTextValidator(Region, "--Select-- Alabama Alaska Arizona Arkansas California Colorado Connecticut Delaware District of Columbia Florida Georgia Guam Hawaii HQ NGB Idaho Illinois Indiana Iowa Kansas Kentucky Louisiana Maine Maryland Massachusetts Michigan Minnesota Mississippi Missouri Montana Nebraska Nevada New Hampshire New Jersey New Mexico New York North Carolina North Dakota OCONUS Ohio Oklahoma Oregon Pennsylvania Puerto Rico Rhode Island South Carolina South Dakota Tennessee Texas Utah Vermont Virgin Islands Virginia Washington West Virginia Wisconsin Wyoming ");
            }
            else if (command == "Army Reserve")
            {
                UIActions.ComboboxInnerTextValidator(Region, "-- Select -- 63rd DIV(R) 7th Civil Spt Cmd 81st DIV(R) 88th DIV(R) 99th DIV(R) 9th MSC ");

            }
        }




        public void ValidateWorkflowList(string command, string exceptionToPolicy)
        {
            if (command == "National Guard")
            {
                if (exceptionToPolicy == "Other")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- NG Death (Formal) NG Death (Informal) NG M-Day (Formal) NG OCONUS (Formal) NG OCONUS (Informal) NG Title 10 (Formal) NG Title 10 (Informal) NG Title 32 (Formal) ");
                }
                else if (exceptionToPolicy == "Assault (SARC)")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- NG Restricted Assault (Informal) NG Unrestricted Assault (Informal) ");
                }
                else if (exceptionToPolicy == "Behavioral Health")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- NG Death (Formal) NG Death (Informal) NG M-Day (Formal) NG M-Day (Informal) NG OCONUS (Formal) NG OCONUS (Informal) NG Pre-Approved (Informal) NG Title 10 (Formal) NG Title 10 (Informal) NG Title 32 (Formal) NG Title 32 (Informal) ");
                }
                else if (exceptionToPolicy == "Death")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- NG Death (Formal) NG Death (Informal) ");
                }
                else if (exceptionToPolicy == "Pre-Approved")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- NG Pre-Approved (Informal) ");
                }
                else if (string.IsNullOrEmpty(exceptionToPolicy))
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- NG Death (Formal) NG Death (Informal) NG M-Day (Formal) NG M-Day (Informal) NG OCONUS (Formal) NG OCONUS (Informal) NG Pre-Approved (Informal) NG Restricted Assault (Informal) NG Title 10 (Formal) NG Title 10 (Informal) NG Title 32 (Formal) NG Title 32 (Informal) NG Unrestricted Assault (Informal) ");
                }
            }


            if (command == "Army Reserve")
            {
                if (exceptionToPolicy == "Other")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- AR Death (Formal) AR Death (Informal) AR M-Day (Formal) AR OCONUS (Formal) AR OCONUS (Informal) AR Title 10 (Formal) AR Title 10 (Informal) AR Title 32 (Formal) ");
                }
                else if (exceptionToPolicy == "Assault (SARC)")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- AR Restricted Assault (Informal) AR Unrestricted Assault (Informal) ");
                }
                else if (exceptionToPolicy == "Behavioral Health")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- AR Death (Formal) AR Death (Informal) AR M-Day (Formal) AR M-Day (Informal) AR OCONUS (Formal) AR OCONUS (Informal) AR Pre-Approved (Informal) AR Title 10 (Formal) AR Title 10 (Informal) AR Title 32 (Formal) AR Title 32 (Informal) ");
                }
                else if (exceptionToPolicy == "Death")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- AR Death (Formal) AR Death (Informal) ");
                }
                else if (exceptionToPolicy == "Pre-Approved")
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- AR Pre-Approved (Informal) ");
                }
                else if (string.IsNullOrEmpty(exceptionToPolicy))
                {
                    UIActions.ComboboxInnerTextValidator(WorkflowDropDownBox, "-- Select -- AR Death (Formal) AR Death (Informal) AR Formal AR Informal AR Pre-Approved (Informal) AR Restricted Assault (Informal) AR Unrestricted Assault (Informal) ");
                }
            }

        }



        #endregion
    }
}
