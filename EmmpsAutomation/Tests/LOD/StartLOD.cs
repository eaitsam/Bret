using EmmpsAutomation.PageObjectModel.LOD;
using EmmpsAutomation.PageObjectModel.Usermanagement;
using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using Xunit;

namespace EmmpsAutomation.LOD
{

    public class StartLOD
    {

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        StartNewLODPage _startnewlod;
        SearchFilterObjects _searchFilter;
        StartNewLODPage _startNewLOD;
        MiscPageOjects _myAccount;
        EmmpsPermissions _emmpsPermission;
        MyLODSearch lodsearch;

        public StartLOD()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _startnewlod = new StartNewLODPage();
            _searchFilter = new SearchFilterObjects();
            _startNewLOD = new StartNewLODPage();
            _myAccount = new MiscPageOjects();
            _emmpsPermission = new EmmpsPermissions();
            lodsearch = new MyLODSearch();
        }

        [Fact]
        public void StartLODSearchPageValidation()
        {
            try
            {
                //login
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");
                // new lod
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

            }
            finally
            {
                _driverInit.TearDown();
            }

            //stub for test to test the following:
            //test input validations
            //test enter text
            //test that objects appear
        }

        [Fact]
        public void StartLODPageValidations()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarID, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //need test to test input validations for search boxes
                UIActions.GetElement(_startNewLOD.SsnBox).SendKeys("367009658");
                UIActions.GetElement(_startNewLOD.SearchButton).Text.Should().Be("Search");
                UIActions.GetElement(_startNewLOD.SearchButton).Click();

                UIActions.GetElement(_startNewLOD.ReqEndOfAuthorizedDutyStatusDateMessage).Displayed.Should().BeTrue();

                UIActions.TypeInTextBoxAndEnter(_startNewLOD.EndOfAuthorizedDutyDateBox, "20180105");

                _startNewLOD.ValidateSelectExceptionToPolicySection("Other", "This is a test", -180);

                _startNewLOD.VaildateLODOptionsSection("Other");


            }
            finally
            {
                _driverInit.TearDown();
            }


        }

        [Fact]
        public void StartNewLOD180DaysCommentScenario1() //46088
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "367009658");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                //UIActions.GetElement(_startnewlod.NextButton).Click();

                _startNewLOD.ValidateSelectExceptionToPolicySection("", "This is a test", -190);


                //ObjectRepository.Driver.SwitchTo().Alert();

                //ObjectRepository.Driver.FindElements(_startNewLOD.ErrorMessageModal).Count.Should().Be(1);
                //UIActions.GetElement(_startNewLOD.ErrorMessageModal).Displayed.Should().BeTrue();
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void StartNewLOD180DaysCommentScenario2() //46090
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "367009658");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                //UIActions.GetElement(_startnewlod.NextButton).Click();

                //UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");

                //UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-190));

                _startNewLOD.ValidateSelectExceptionToPolicySection("Behavioral Health", "This is a test", -190);

                //UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Behavioral Health ");

                //UIActions.JSClickElement(_startnewlod.NextButton);
                //UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "NG M-Day Formal");
                //UIActions.JSClickElement(_startnewlod.CreateLODButton);
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void StartNewLOD180DaysCommentScenario3() //46093
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "367009658");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                _startNewLOD.ValidateSelectExceptionToPolicySection("Other", "This is a test", -180);


                //UIActions.GetElement(_startnewlod.NextButton).Click();

                //UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");

                //UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-180));
                //UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other ");

                //UIActions.JSClickElement(_startnewlod.NextButton);
                //UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "NG M-Day Formal");
                //UIActions.JSClickElement(_startnewlod.CreateLODButton);
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NewLODOptionsEADSDPastDate() //46161 
        {
            try
            {
                //	#// Test Case 46161: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46161&triage=false&_a=edit
                //Scenario Outline: Test 46161 Start New LOD Options EADSD< 180 - Validations
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070122");

                UIActions.JSClickElement(_myAccount.MyAccountLink);
                UIActions.JSClickElement(_emmpsPermission.EmmpsLODtab);

                //	And have verified user has Create ARNG/USAR LOD and LOD Draft(NG) Permissions
                // WaitMethods.Wait(_emmpsPermission.EmmpsLODtab, 60);
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.EmmpsLODtab));
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.));

                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "368009687");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.GetElement(_startnewlod.NextButton).Click();

                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");
                UIActions.SelectElementByValue(_startnewlod.RowsPerPage, "50");

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-80));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other ");

                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "AR Formal");
                UIActions.JSClickElement(_startnewlod.CreateLODButton);

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NewLODOptionsEADSDFutureDateScen1()  //46163
        {
            try
            {
                //	#// Test Case 46163: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46163&triage=false&_a=edit
                //Scenario Outline: Test 46163 Start New LOD Options EADSD is Future Date - Validations
                //	Given I am Logged in as <Role> using EDIPIN <PIN>
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070122");

                //	And have verified user has Create ARNG/USAR LOD and LOD Draft(NG) Permissions
                // WaitMethods.Wait(_emmpsPermission.EmmpsLODtab, 60);
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.EmmpsLODtab));
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.));
                //UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.ARUnitAdmin);//?

                //   And I have navigated to "Start New LOD" tab in "eMMPS"
                UIActions.JSClickElement(_startnewlod.SearchButton);
                UIActions.GetElement(_startnewlod.NextButton).Click();

                //	When I enter Parms to Start New LOD and click search<SSN> and<FirstName> and<LastName> and <StartLODEDIPI> 
                //	Then the Start New LOD page is displayed to update End Of Authorized Duty Status Date<EndOfAuthorizedDutyStatusDate> and <DaysFromCurrentDate>
                //	And Start New LOD Exception to Policy Section is validated<ExceptionToPolicy> and <Comments>

                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "368009687");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(75));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");

                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");

                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "AR Informal");
                UIActions.JSClickElement(_startnewlod.CreateLODButton);

            }
            finally
            {
                _driverInit.TearDown();
            }




            //	Scenarios: 
            //	| Role          | PIN        | SSN       | Workflow          | Status    | EndOfAuthorizedDutyStatusDate | DaysFromCurrentDate | ExceptionToPolicy | Comments      | FirstName | LastName | StartLODEDIPI |
            //	| AR Unit Admin | 8880070122 | 368009687 | AR Informal       | -- All -- |                               | 75                  |Other              | Start New LOD |           |          |               |

        }


        [Fact]
        public void NewLODOptionsEADSDFutureDateScen2() //46164
        {
            try
            {
                //	#// Test Case 46164: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46164&triage=false&_a=edit
                //Scenario Outline: Test 46164 Start New LOD Options EADSD is Future Date Scenario 2 - Validations
                //	Given I am Logged in as <Role> using EDIPIN <PIN>
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070122");

                //	And have verified user has Create ARNG/USAR LOD and LOD Draft(NG) Permissions
                // WaitMethods.Wait(_emmpsPermission.EmmpsLODtab, 60);
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.EmmpsLODtab));
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.));
                //UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.ARUnitAdmin);//?


                //   And I have navigated to "Start New LOD" tab in "eMMPS"
                //	When I enter Parms to Start New LOD and click search<SSN> and<FirstName> and<LastName> and <StartLODEDIPI> 
                //	Then the Start New LOD page is displayed to update End Of Authorized Duty Status Date<EndOfAuthorizedDutyStatusDate> and <DaysFromCurrentDate>
                //	And Start New LOD Exception to Policy Section is validated<ExceptionToPolicy> and <Comments>
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "368009687");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(181));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");

                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");

                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "AR Informal");
                UIActions.JSClickElement(_startnewlod.CreateLODButton);

            }
            finally
            {
                _driverInit.TearDown();
            }

            //	Scenarios: 
            //	| Role          | PIN        | SSN       | Workflow          | Status    | EndOfAuthorizedDutyStatusDate | DaysFromCurrentDate | ExceptionToPolicy | Comments      | FirstName | LastName | StartLODEDIPI |
            //	| AR Unit Admin | 8880070122 | 368009687 | AR Informal       | -- All -- |                               | 181                 |Other              | Start New LOD |           |          |               |

        }


        [Fact]
        public void NewLODOptionsEADSDEqual180Days() //46159
        {
            try
            {
                //	#// Test Case 46159: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46159&triage=false&_a=edit
                //Scenario Outline: Test 46159 Start New LOD Options EADSD Equal 180 days - Validations
                //	Given I am Logged in as <Role> using EDIPIN <PIN>
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070122");

                ////	And I navigated to My Account and selected the LOD tab
                //UIActions.JSClickElement(_myAccount.MyAccountLink);
                //UIActions.JSClickElement(_emmpsPermission.EmmpsLODtab);

                //	And have verified user has Create ARNG/USAR LOD and LOD Draft(NG) Permissions
                // WaitMethods.Wait(_emmpsPermission.EmmpsLODtab, 60);
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.EmmpsLODtab));
                //Assert.True(UIActions.IsElementPresent(_emmpsPermission.));
                //UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.ARUnitAdmin);//?

                //   And I have navigated to "Start New LOD" tab in "eMMPS"
                //	When I enter Parms to Start New LOD and click search<SSN> and<FirstName> and<LastName> and <StartLODEDIPI> 
                //	Then the Start New LOD page is displayed to update End Of Authorized Duty Status Date<EndOfAuthorizedDutyStatusDate> and <DaysFromCurrentDate>
                //	And Start New LOD Exception to Policy Section is validated<ExceptionToPolicy> and <Comments>

                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "368009687");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-180));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");

                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");

                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "AR Informal");
                UIActions.JSClickElement(_startnewlod.CreateLODButton);
            }
            finally
            {
                _driverInit.TearDown();
            }



            //	Scenarios: 
            //	| Role          | PIN        | SSN       | Workflow          | Status    | EndOfAuthorizedDutyStatusDate | DaysFromCurrentDate | ExceptionToPolicy | Comments      | FirstName | LastName | StartLODEDIPI |
            //	| AR Unit Admin | 8880070122 | 368009687 | AR Informal       | -- All -- |                               | -180                |Other              | Start New LOD |           |          |               |

        }

      
        [Theory] // Test Case 46255
        [InlineData("8880070109", "367009658", -195)]
        [InlineData("8880070021", "304008788", -180)]
        public void NewLODOptionsWFAssaultOption(string edipin, string ssn, int days)
        {
            try
            {

                _driverInit.InitWebdriver();
                _login.LoginMethod(edipin);

                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, ssn);
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(days));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Assault (SARC)");

                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");

                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.ComboboxInnerTextValidator(_startnewlod.WorkflowDropDownBox, new List<string> { "-- Select --", "NG Restricted Assault (Informal)", "NG Unrestricted Assault (Informal)" });


            }
            finally
            {
                _driverInit.TearDown();
            }
        }
     
        [Theory] // Test Case 46254
        [InlineData("8880070115", "367009658")]
        [InlineData("8880070122", "368009687")]
        public void NewLODOptionWFOptionBHETP(string edipin, string ssn)
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod(edipin);
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.TypeInTextBox(_startnewlod.SsnBox, ssn);
                UIActions.JSClickElement(_startnewlod.SearchButton);
                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-181));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Behavioral Health");
                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");
                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.JSClickElement(_startnewlod.CreateLODButton);
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Theory] // Test Case 46256
        [InlineData("8880070115", "367009658")]
        [InlineData("8880070122", "368009687")]
        public void NewLODOptionsWFOptionPreapproveETP(string edipin, string ssn)
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod(edipin);
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.TypeInTextBox(_startnewlod.SsnBox, ssn);
                UIActions.JSClickElement(_startnewlod.SearchButton);
                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-181));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Pre-Approved");
                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");
                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.JSClickElement(_startnewlod.CreateLODButton);
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Theory]  // Test Case 46257
        [InlineData("8880070115", "367009658")]
        [InlineData("8880070122", "368009687")]
        public void NewLODOptionsWFOptionSelectedETP(string edipin, string ssn)
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod(edipin);
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.TypeInTextBox(_startnewlod.SsnBox, ssn);
                UIActions.JSClickElement(_startnewlod.SearchButton);
                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-100));
                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("");
                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.ComboboxInnerTextValidator(_startnewlod.WorkflowDropDownBox, new List<string> { "-- Select --", "NG Death (Formal)", "NG Death (Informal)", "NG M-Day (Formal)", "NG M-Day (Informal)", 
                                                     "NG OCONUS(Formal)", "NG OCONUS (Informal)", "NG Pre-Approved (Informal)", "NG Title 10 (Formal)", "NG Title 10 (Informal)", "NG Title 32 (Formal)" ,"NG Title 32 (Informal)" });

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Theory] // Test Case 46252
        [InlineData("8880070115", "367009658", "NG Title 10 (Informal)")]
        [InlineData("8880070122", "368009687", "AR Formal")]
        public void NewLODOptionsWFOptionOtherETP(string edipin, string ssn, string workflow)
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod(edipin);
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.TypeInTextBox(_startnewlod.SsnBox, ssn);
                UIActions.JSClickElement(_startnewlod.SearchButton);
                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-190));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");
                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");
                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, workflow);
                UIActions.JSClickElement(_startnewlod.CreateLODButton);
            }
            finally
            {
                _driverInit.TearDown();
            }
        }
    }
}