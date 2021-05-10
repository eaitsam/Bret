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
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.LOD
{
    public class AdminTab
    {

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        StartNewLODPage _startNewLOD;
        LODSearchPage _lodsearch;
        MyLODMenuNav _lodnav;
        LODAdminTab _admin;
        MiscPageOjects _misc;
        SearchFilterObjects _search;
        LODSearchPage lodsearch;
        EmmpsPermissions _perms;

        public AdminTab()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _startNewLOD = new StartNewLODPage();
            _navMenu = new NavMenuObjects();
            _lodsearch = new LODSearchPage();
            _lodnav = new MyLODMenuNav();
            _admin = new LODAdminTab();
            _misc = new MiscPageOjects();
            _search = new SearchFilterObjects();
            _perms = new EmmpsPermissions();
            lodsearch = new LODSearchPage();
        }
        //# Test Under the Admn tab need to run in a certain order so each test was put in alphabetized order by proceeding the test name with a letter.
        //# The "AdminTabStatusDropDown" field is used on some of the test as a temporary solution in order for the tester to see the values that are being validated on the Extent Report produced after each test run.

        //# Admin Tab Validation for all of the follow Admin Test Scripts Scenarios
        //# Test Prefix with numbers to run in a certain order.  Some of the Test update Permmisions for users to test scenarios then reset them to test other scenarios

        [Fact]
        public void Test46496()
        {
            try
            {
                DivRRemoveOverrideFinalLODStatusPerms();
                DivRAdminCheckPermissionsDisabled();
                DivRAddOverrideFinalStatusPermissions();
                DivRStatusValidations();
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void Test46509()
        {
            try
            {
                ARNGManagerRemoveOverrideFinalLODStatusPerm();
                ARNGManagerCheckPermissionsDisabled();
                ARNGManagerAddOverrideFinalLODStatusPerm();
                ARNGManagerStatusValidations();
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void Test46507()
        {
            try
            {
                NGBReviewerRemoveOverrideFinalLODStatusPerm();
                NGBReviewerCheckPermissionsDisabled();
                NGBReviewerAddOverrideFinalLODStatusPerm();
                NGBReviewerStatusValidations();
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void AdminTabUSARCManagerValidation()
        {
            //		Scenario Outline: A Test 46432 Admin Tab eMMPS USARC Manager - Validations
            //#// Test Case 46432

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070042");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarID, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(AR) AR Formal");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();

                UIActions.GetElement(_lodsearch.FilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();

                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.AdminUSARManagerWorkflowExpectedValues);
            }
            finally
            {
                _driverInit.TearDown();
            }
        }



        [Fact]
        public void AdminTabUSARCG1Validation()
        {
            //	#// Test Case 46423:
            //Scenario Outline: B Test 46423 Admin Tab USARC-1 Admin - Validations

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070141");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarID, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(AR) AR Formal");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();

                UIActions.GetElement(_lodsearch.FilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();

                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.AdminUSARCG1StatusExpValues);

            }
            finally
            {
                _driverInit.TearDown();
            }

        }


        [Fact]
        public void AdminTabSARCManager()
        {
            try
            {
                //	#// Test Case 46483
                //Scenario Outline: C Test 46483 Admin Tab USARC SARC Manager - Validations

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070040");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarID, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(AR) AR Formal");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();

                UIActions.GetElement(_lodsearch.FilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();

                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.AdminSARCManagerStatusExpValues);


            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        public void DivRRemoveOverrideFinalLODStatusPerms()
        {
            //#// Test Case 46496: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46496&triage=false&_a=edit

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070141");
                UIActions.GetElement(_misc.ManageUsersLink).Click();
                UIActions.TypeInTextBox(_perms.ManageUsersTextBox, "8880070133");
                UIActions.SelectElementByText(_search.OrgCombobox, "Army Reserve");
                UIActions.GetElement(_perms.ManageUsersSearchButton).Click();
                UIActions.GetElement(_admin.UserDetailsButton).Click();
                UIActions.GetElement(_admin.PermissionOpenButton).Click();

                //var winHandleBefore = ObjectRepository.Driver.WindowHandles();

                //// Perform the click operation that opens new window

                //// Switch to new window opened
                //for (String winHandle in ObjectRepository.Driver.WindowHandles)
                //{
                //    ObjectRepository.Driver.SwitchTo()
                //    driver.switchTo().window(winHandle);
                //}

                //// Perform the actions on new window

                //// Close the new window, if that window no more required
                //driver.close();

                //// Switch back to original browser (first window)
                //driver.switchTo().window(winHandleBefore);
                
                var manageusersperms = ObjectRepository.Driver.WindowHandles.Last();


                ObjectRepository.Driver.SwitchTo().Window(manageusersperms);


                UIActions.GetElement(_perms.LODPermAmmendTab).Click();

                if (UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Selected == true)
                {
                    UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Click();
                    UIActions.GetElement(_perms.PermissionSaveManageUsersButton).Click();
                    UIActions.GetElement(_perms.ManageUsersPermSubmitandGoBackButton).Click();
                }
//                else if (UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Selected == false)
//                {

//                    ObjectRepository.Driver.SwitchTo().ParentFrame();

//                    //var popup = ObjectRepository.Driver.WindowHandles


//                    //UIActions.GetElement(_perms.PermissionSaveManageUsersButton).Click();
//                    //UIActions.GetElement(_perms.ManageUsersPermSubmitandGoBackButton).Click();
//                    //ObjectRepository.Driver.Close();

//                UIActions.GetElement(_misc.LogoutButton).Click();
//                UIActions.GetElement(_misc.ClickHereLogoutLink).Click();

//                _login.LoginMethod("8880070133");


            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        public void DivRAdminCheckPermissionsDisabled()
        {
            try
            {
                //  Test Case 46496: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46496&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070133");
                UIActions.GetElement(_misc.MyAccountLink).Click();

                UIActions.GetElement(_perms.EmmpsLODtab).Click();
                Assert.Null(UIActions.GetElement(_perms.OverrideFinalLODStatusCheckbox).GetAttribute("checked"));

                UIActions.GetElement(_navMenu.HomeMasterMenuBarID).Click();

                Thread.Sleep(500);
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(AR) AR Formal");
                WaitMethods.WaitForAnimationtoComplete(_misc.WaitingAnimationDiv, 30);

                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                //UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();
                UIActions.JSClickElement(_lodsearch.SearchResultsFilterButton);
                WaitMethods.WaitForAnimationtoComplete(_misc.WaitingAnimationDiv, 30);
                UIActions.GetElement(lodsearch.SearchLODRow0CaseIDLink).Click();
                //UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Displayed.Should().BeFalse();
                ObjectRepository.Driver.FindElements(_lodnav.LODAdminMenuLinkButton).Count.Should().Be(0);

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        public void DivRAddOverrideFinalStatusPermissions()
        {
            try
            {
                //#// Test Case 46496: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46496&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070141");
                UIActions.GetElement(_misc.ManageUsersLink).Click();
                UIActions.TypeInTextBox(_perms.ManageUsersTextBox, "8880070133");
                UIActions.SelectElementByText(_search.OrgCombobox, "Army Reserve");
                UIActions.GetElement(_perms.ManageUsersSearchButton).Click();
                UIActions.GetElement(_admin.UserDetailsButton).Click();
                UIActions.GetElement(_admin.PermissionOpenButton).Click();


                var manageusersperms = ObjectRepository.Driver.WindowHandles.Last();


                ObjectRepository.Driver.SwitchTo().Window(manageusersperms);


                UIActions.GetElement(_perms.LODPermAmmendTab).Click();

                if (UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Selected == false)
                {
                    UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Click();
                    UIActions.GetElement(_perms.PermissionSaveManageUsersButton).Click();
                    UIActions.GetElement(_perms.ManageUsersPermSubmitandGoBackButton).Click();
                }

            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        public void DivRStatusValidations()
        {
            try
            {

                //#// Test Case 46496: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46496&triage=false&_a=edit
                //Scenario Outline: G Test 46496 LOD Admin Tab DIV_R Admin4 -  Validations

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070133");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(AR) AR Formal");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                //UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();
                UIActions.JSClickElement(_lodsearch.SearchResultsFilterButton);
                UIActions.GetElement(lodsearch.SearchLODRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();
                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.DivRAdminTabStatusExpValues);

            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        public void ARNGManagerRemoveOverrideFinalLODStatusPerm()
        {
            try
            {
                //#// Test Case 46509: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46509&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070070");
                UIActions.GetElement(_misc.ManageUsersLink).Click();
                UIActions.TypeInTextBox(_perms.ManageUsersTextBox, "8880070020");
                UIActions.SelectElementByText(_search.OrgCombobox, "National Guard");
                UIActions.GetElement(_perms.ManageUsersSearchButton).Click();
                UIActions.GetElement(_admin.UserDetailsButton).Click();
                UIActions.GetElement(_admin.PermissionOpenButton).Click();


                var manageusersperms = ObjectRepository.Driver.WindowHandles.Last();


                ObjectRepository.Driver.SwitchTo().Window(manageusersperms);


                UIActions.GetElement(_perms.LODPermAmmendTab).Click();

                if (UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Selected == true)
                {
                    UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Click();
                    UIActions.GetElement(_perms.PermissionSaveManageUsersButton).Click();
                    UIActions.GetElement(_perms.ManageUsersPermSubmitandGoBackButton).Click();
                }

            }
            finally
            {
                _driverInit.TearDown();

            }
        }


        public void ARNGManagerCheckPermissionsDisabled()
        {
            try
            {
                //		#// Test Case 46509: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46509&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070020");
                UIActions.GetElement(_misc.MyAccountLink).Click();

                UIActions.GetElement(_perms.EmmpsLODtab).Click();
                Assert.Null(UIActions.GetElement(_perms.OverrideFinalLODStatusCheckbox).GetAttribute("checked"));
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(NG) NG M-Day (Formal)");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                //UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();
                UIActions.JSClickElement(_lodsearch.SearchResultsFilterButton);
                UIActions.GetElement(lodsearch.SearchLODRow0CaseIDLink).Click();
                //UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Displayed.Should().BeFalse();
                ObjectRepository.Driver.FindElements(_lodnav.LODAdminMenuLinkButton).Count.Should().Be(0);

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        public void ARNGManagerAddOverrideFinalLODStatusPerm()
        {
            try
            {
                //#// Test Case 46509: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46509&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070070");
                UIActions.GetElement(_misc.ManageUsersLink).Click();
                UIActions.TypeInTextBox(_perms.ManageUsersTextBox, "8880070020");
                UIActions.SelectElementByText(_search.OrgCombobox, "National Guard");
                UIActions.GetElement(_perms.ManageUsersSearchButton).Click();
                UIActions.GetElement(_admin.UserDetailsButton).Click();
                UIActions.GetElement(_admin.PermissionOpenButton).Click();


                var manageusersperms = ObjectRepository.Driver.WindowHandles.Last();


                ObjectRepository.Driver.SwitchTo().Window(manageusersperms);


                UIActions.GetElement(_perms.LODPermAmmendTab).Click();

                if (UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Selected == false)
                {
                    UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Click();
                    UIActions.GetElement(_perms.PermissionSaveManageUsersButton).Click();
                    UIActions.GetElement(_perms.ManageUsersPermSubmitandGoBackButton).Click();
                }

            }
            finally
            {
                _driverInit.TearDown();

            }
        }

        public void ARNGManagerStatusValidations()
        {
            try
            {

                //#// Test Case 46509 http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46509&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070020");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(NG) NG M-Day (Formal)");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                //UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();
                UIActions.JSClickElement(_lodsearch.SearchResultsFilterButton);
                UIActions.GetElement(lodsearch.SearchLODRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();
                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.AdminUSARManagerWorkflowExpectedValues);

                //	Scenarios: 
                //	| Workflow               | Active                         | Role                           | PIN        | AdminTabStatusDropDown                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
                //	| (NG) NG M-Day (Formal) | Closed - Ineligible for LOD    | eMMPS ARNG Manager             | 8880070020 | -- Select --, Appointing Authority Review (NG), HRC Admin LOD Appeal Review (NG), HRC Approval LOD Appeal Review (NG), I/O - Investigation (NG), Intermediate Command Review (NG), Investigation Review (NG), LOD Appeal Draft (NG), LOD Draft (NG), MTF Entry (NG), NGB Approval LOD Appeal Review (NG), NGB Approval LOD Review (NG), NGB JAG LOD Appeal Review (NG), NGB JAG LOD Review (NG), NGB LOD Appeal Review (NG), NGB LOD Review (NG), NGB Surgeon Approval LOD Appeal Review (NG), NGB Surgeon Approval LOD Review (NG), NGB Surgeon LOD Appeal Review (NG), NGB Surgeon LOD Review (NG), State Admin LOD Review (NG), State Approval LOD Appeal Review (NG), State Approval LOD Review (NG), State JAG LOD Appeal Review (NG), State JAG LOD Review (NG), State Surgeon LOD Appeal Review (NG), State Surgeon LOD Review (NG), Unit Commander LOD Review (NG) |

            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        public void NGBReviewerRemoveOverrideFinalLODStatusPerm()
        {
            try
            {
                //	#// Test Case 46507: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46507&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070020");
                UIActions.GetElement(_misc.ManageUsersLink).Click();
                UIActions.TypeInTextBox(_perms.ManageUsersTextBox, "8880070018");
                UIActions.SelectElementByText(_search.OrgCombobox, "National Guard");
                UIActions.GetElement(_perms.ManageUsersSearchButton).Click();
                UIActions.GetElement(_admin.UserDetailsButton).Click();
                UIActions.GetElement(_admin.PermissionOpenButton).Click();


                var manageusersperms = ObjectRepository.Driver.WindowHandles.Last();


                ObjectRepository.Driver.SwitchTo().Window(manageusersperms);


                UIActions.GetElement(_perms.LODPermAmmendTab).Click();

                if (UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Selected == true)
                {
                    UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Click();
                    UIActions.GetElement(_perms.PermissionSaveManageUsersButton).Click();
                    UIActions.GetElement(_perms.ManageUsersPermSubmitandGoBackButton).Click();
                }

            }
            finally
            {
                _driverInit.TearDown();

            }
        }

        public void NGBReviewerCheckPermissionsDisabled()
        {
            try
            {
                //		#// Test Case 46507: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46509&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070018");
                UIActions.GetElement(_misc.MyAccountLink).Click();

                UIActions.GetElement(_perms.EmmpsLODtab).Click();
                Assert.Null(UIActions.GetElement(_perms.OverrideFinalLODStatusCheckbox).GetAttribute("checked"));
                UIActions.GetElement(_navMenu.HomeMasterMenuBarID).Click();
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.SearchLODLink };

                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(NG) NG M-Day (Formal)");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                //UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();
                UIActions.JSClickElement(_lodsearch.SearchResultsFilterButton);
                UIActions.GetElement(lodsearch.SearchLODRow0CaseIDLink).Click();
                //UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Displayed.Should().BeFalse();
                ObjectRepository.Driver.FindElements(_lodnav.LODAdminMenuLinkButton).Count.Should().Be(0);

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGBReviewerAddOverrideFinalLODStatusPerm()
        {
            try
            {
                //#// Test Case 46507: http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46509&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070020");
                UIActions.GetElement(_misc.ManageUsersLink).Click();
                UIActions.TypeInTextBox(_perms.ManageUsersTextBox, "8880070018");
                UIActions.SelectElementByText(_search.OrgCombobox, "National Guard");
                UIActions.GetElement(_perms.ManageUsersSearchButton).Click();
                UIActions.GetElement(_admin.UserDetailsButton).Click();
                UIActions.GetElement(_admin.PermissionOpenButton).Click();


                var manageusersperms = ObjectRepository.Driver.WindowHandles.Last();


                ObjectRepository.Driver.SwitchTo().Window(manageusersperms);


                UIActions.GetElement(_perms.LODPermAmmendTab).Click();

                if (UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Selected == false)
                {
                    UIActions.GetElement(_perms.MUOverrideFinalLODStatus).Click();
                    UIActions.GetElement(_perms.PermissionSaveManageUsersButton).Click();
                    UIActions.GetElement(_perms.ManageUsersPermSubmitandGoBackButton).Click();
                }

            }
            finally
            {
                _driverInit.TearDown();

            }
        }


        [Fact]
        public void NGBReviewerStatusValidations()
        {
            try
            {

                //#// Test Case 46507 http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=46509&triage=false&_a=edit

                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070018");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(_lodsearch.LODComboBoxWorkflow, "(NG) NG M-Day (Formal)");
                UIActions.SelectElementByText(_lodsearch.LODComboBoxActive, "Closed - Ineligible for LOD");
                //UIActions.GetElement(_lodsearch.SearchResultsFilterButton).Click();
                UIActions.JSClickElement(_lodsearch.SearchResultsFilterButton);
                UIActions.GetElement(lodsearch.SearchLODRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();
                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_admin.LODStatusDropdown).Options, _admin.NGBAdminTabStatusExpValues);


            }
            finally
            {
                _driverInit.TearDown();
            }

        }


    }
}
