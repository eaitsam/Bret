using EmmpsAutomation.PageObjectModel.LOD;
using EmmpsAutomation.PageObjectModel.Usermanagement;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.LOD
{
    public class AdminOverride
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

        public AdminOverride()
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


        [Fact]
        public void Test40691()
        {
            try
            {

            }
            finally
            {
                _driverInit.TearDown();
            }
            AdminOverridePageValidations();
            AdminOverrideAssaultWorkflowRestrictions();
        }

        [Fact]
        public void Test40609()
        {
            try
            {

            }
            finally
            {
                _driverInit.TearDown();
            }

            //AdminOverrideDEMOBWTUStationsWorkflowStatusChanges();
            //WTUManagerTradocRegionPageValidation();
            //WTUManagerTradocRegionDropDownHidden();
            //WTUManagerTradocRegionDropDownDisplayedValidation();
            //AdminTabNotDisplayedinMTFEntryStatus();
            //TradocRegionDisableAdminTabValidation();
        }

        [Fact]
        public void AdminOverridePageValidations()//		@TestCase40691
        {

            try
            {

            }
            finally
            {
                _driverInit.TearDown();
            }
            //# LOD Admin Override Assault Workflow 
            //		@TestCase40691
            //Scenario: LOD Admin Override Page Validations
            //	Given I am Logged in as RSC Admin using EDIPIN 8880070133
            //	And I have navigated to "My LODs" tab in "eMMPS"
            //	And I search for a LOD in the workflow "AR Informal" in the "LOD Draft (AR)" status and select the first Case-ID
            //	When I click the "Admin" Tab in "LOD"
            //	Then all the fields in the Admin Tab should be displayed
            //	And all the options for the drop downs in the admin tab are correct
            //	And all the validation error messages are correct
            //	And all the admin tab numeric fields have been validated

        }

        [Fact]
        public void AdminOverrideAssaultWorkflowRestrictions()
        {
            try
            {

            }
            finally
            {
                _driverInit.TearDown();
            }
            //see above, does not complete the test script
        }


        [Theory]
        [MemberData(nameof(DEMOBWTUWorkflow))]
        public void AdminOverrideDEMOBWTUStationsWorkflowStatusChanges(string edipin, string workflow, string active, string station, string caseid, string status)
        {
            try
            {
                //@TestCase40609

                _driverInit.InitWebdriver();
                _login.LoginMethod(edipin);
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(lodsearch.LODComboBoxWorkflow, workflow);
                UIActions.SelectElementByText(lodsearch.LODComboBoxActive, active);
                UIActions.SelectElementByText(lodsearch.LODComboBoxStation, station);

                int numRows = UIActions.GetNumberOfElements(By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_')]"));
                int row;
                string id = "MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_";

                for (row = 0; row < numRows; row++)
                {
                    if (UIActions.GetElement(By.Id(id + row)).Text == caseid)
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                    if (UIActions.GetElement(By.Id(id + row)).Text.Equals(caseid))
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }

                }

                UIActions.GetElement(_lodsearch.FilterResultsRow0CaseIDLink).Click();
                //UIActions.GetElement(_lodsearch.SearchFilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();

                UIActions.SelectElementByText(_admin.LODStatusDropdown, status);
                UIActions.TypeInTextBox(_admin.LODStatusTrackingComment, "Automation Team");
                UIActions.JSClickElement(_admin.LODStatusSelectButton);
                _admin.IsStatusLabelCorrect(_admin.LODCaseStatusLabel, status);
            }
            finally
            {
                _driverInit.TearDown();
            }

        }
        public static IEnumerable<object[]> DEMOBWTUWorkflow =>
        new List<object[]>
        {
                new object[] { "8880070411", "(DEMOB XC) DEMOB Informal", "Final (Adjudicated)", "Camp Atterbury, Indiana", "DEM-18-00231", "DEMOB Unit Commander Review (xC)" },
                new object[] { "8880070418", "(DEMOB XC) WTU Informal", "Final (Adjudicated)", "Camp Atterbury, Indiana", "WTU-18-00155", "WTU LOD Review (xC)" },
                new object[] { "8880070042", "(DEMOB XC) DEMOB Informal", "Final (Adjudicated)", "Camp Atterbury, Indiana", "DEM-16-00020", "MTF Entry DEMOB" },
        };


        [Fact]
        public void WTUManagerTradocRegionPageValidation()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070613");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(lodsearch.LODComboBoxStatus, "-- All --");
                UIActions.SelectElementByText(lodsearch.LODComboBoxStation, "TRADOC - Fort Lee, Virginia");
                int numRows = UIActions.GetNumberOfElements(By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_')]"));
                int row;
                string id = "MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_";

                for (row = 0; row < numRows; row++)
                {
                    if (UIActions.GetElement(By.Id(id + row)).Text == "WTU - 18 - 00056")
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                    if (UIActions.GetElement(By.Id(id + row)).Text.Equals("WTU - 18 - 00056"))
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }

                }

                UIActions.GetElement(_lodsearch.FilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodsearch.SearchFilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();

                Assert.True(UIActions.IsElementPresent(_admin.LODStatusSelectButton)); //status
                Assert.True(UIActions.IsElementPresent(_admin.LODAdminAttachedUICRegionValidationSummary)); //uic region
                Assert.True(UIActions.IsElementPresent(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList')]"))); //demob wtu
                Assert.True(UIActions.IsElementPresent(_admin.LODAdminCloseButton)); //admin close
                Assert.True(UIActions.IsElementPresent(_admin.LODDeleteButton)); //delete lod
                UIActions.GetElement(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_StartSearch')]")).Click(); //verify content title

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void WTUManagerTradocRegionDropDownHidden()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070418");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(lodsearch.LODComboBoxStatus, "-- All --");
                UIActions.SelectElementByText(lodsearch.LODComboBoxStation, "Camp Atterbury");
                int numRows = UIActions.GetNumberOfElements(By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_')]"));
                int row;
                string id = "MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_";

                for (row = 0; row < numRows; row++)
                {
                    if (UIActions.GetElement(By.Id(id + row)).Text == "WTU - 18 - 00056")
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                    if (UIActions.GetElement(By.Id(id + row)).Text.Equals("WTU - 18 - 00056"))
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }

                }

                UIActions.GetElement(_lodsearch.FilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodsearch.SearchFilterResultsRow0CaseIDLink).Click();
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();
                UIActions.IsElementPresent(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList')]"));
                UIActions.GetElement(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList')]")).Click();
                Assert.True(UIActions.ComboboxInnerTextValidator(_admin.LODAdminTabStatusDropdown, new List<string> { "--All--", "23rd QM BDE", "59th OD BDE" }));
                UIActions.SelectElementByText(_admin.LODAdminTabStatusDropdown, "");

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void WTUManagerTradocRegionDropDownDisplayedValidation()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070613");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(lodsearch.LODComboBoxStatus, "-- All --");
                UIActions.SelectElementByText(lodsearch.LODComboBoxStation, "TRADOC - Fort Lee, Virginia");
                int numRows = UIActions.GetNumberOfElements(By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_')]"));
                int row;
                string id = "MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_";

                for (row = 0; row < numRows; row++)
                {
                    if (UIActions.GetElement(By.Id(id + row)).Text == "WTU-18-00056")
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                    if (UIActions.GetElement(By.Id(id + row)).Text.Equals("WTU-18-00056"))
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                }
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();
                UIActions.GetElement(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList')]")).Click();
                UIActions.IsElementPresent(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList')]"));
                Assert.True(UIActions.ComboboxInnerTextValidator(_admin.LODUICRegionDropdown, new List<string> { "Select", "Joint Base Lewis-McChord", "Tripler", "Bethesda", "Ft. Belvoir", "Ft. Benning", "Ft. Bragg", "Ft. Campbell", "Ft. Drum", "Ft. Stewart", "Ft. Bliss", "Ft. Carson", "Ft. Hood", "Ft. Riley", "Joint Base San Antonio" }));
                UIActions.SelectElementByText(_admin.LODUICRegionDropdown, "");
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void AdminTabNotDisplayedinMTFEntryStatus() 
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070613");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(lodsearch.LODComboBoxStatus, "MTF Entry(WTU)");
                UIActions.SelectElementByText(lodsearch.LODComboBoxStation, "TRADOC - Fort Lee, Virginia");
                int numRows = UIActions.GetNumberOfElements(By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_')]"));
                int row;
                string id = "MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_";

                for (row = 0; row < numRows; row++)
                {
                    if (UIActions.GetElement(By.Id(id + row)).Text == "WTU-18-00115")
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                    if (UIActions.GetElement(By.Id(id + row)).Text.Equals("WTU-18-00115"))
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                }
            }
            finally
            {
                _driverInit.TearDown();
            }
            //#LOD Admin Override Restrictions DEMOBWTU Stations  - - VALIDATION NOT AVAILABLE
            //@TestCase40609
            //Scenario Outline: LOD Admin Override Not Displayed in MTF Entry Status Validation
           
            //   Then I verify the admin override tab is not available // ***where should this admin override tab be located?


            //	Scenarios: 
            //	| Role                        | Pin        | Status         | Station                     | CaseID       |
            //	| WTU Manager TRADOC Fort Lee | 8880070613 | MTF Entry(WTU) | TRADOC - Fort Lee, Virginia | WTU-18-00115 |

        }

        [Fact]
        public void TradocRegionDisableAdminTabValidation()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070613");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.SearchLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByText(lodsearch.LODComboBoxStatus, "-- All --");
                UIActions.SelectElementByText(lodsearch.LODComboBoxStation, "TRADOC - Fort Lee, Virginia");
                int numRows = UIActions.GetNumberOfElements(By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_')]"));
                int row;
                string id = "MEDCHARTContent_EmmpsContent_SearchResultsLodDisplayGrid_GridViewMyLodsFilterResults_LinkButtonCaseId_";

                for (row = 0; row < numRows; row++)
                {
                    if (UIActions.GetElement(By.Id(id + row)).Text == "WTU-18-00104")
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                    if (UIActions.GetElement(By.Id(id + row)).Text.Equals("WTU-18-00104"))
                    {
                        UIActions.JSClickElement(By.Id(id + row));
                        break;
                    }
                UIActions.GetElement(_lodnav.LODAdminMenuLinkButton).Click();
                            
                UIActions.GetElement(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_ExtendablePermissionDropDownList')]")).Click();
                //  UIActions.IsElementPresent(By.XPath("//a[contains(@id, 'MEDCHARTContent_MedchartPagesContent_ExtendablePermissionDropDownList')]").("DEMOB/WTU Station Report"));
                UIActions.SelectElementByText(_admin.LODUICRegionDropdown, "TRADOC - Fort Lee, Virginia");
                UIActions.TypeInTextBox(_admin.LODStatusTrackingComment, "Automation Team");
                UIActions.JSClickElement(_admin.LODStatusSelectButton);

                //	And I verify the admin tab details dissapears
                }
            }
            finally
            {
                _driverInit.TearDown();
            }
            //#LOD Admin Override Restrictions DEMOBWTU Stations  - - VALIDATION ADMIN TAB DISAPPEARS
            //# EDIPIN for Fort Benning Georgia  8880070511
            //@TestCase40609
            //Scenario Outline: LOD Admin Override WTU Manager Tradoc Region Selection and admin tab disappears Validation
            //Given I am Logged in as < Role > using EDIPIN<PIN>
            //And I have navigated to "Search LODs" tab in "eMMPS"
            //And I search for a LOD in the '<Status>' status and filter the '<Station>' station
            //And I select the < caseID > if available
            //When I click the "Admin" Tab in "LOD"
            //Then I Select the DEMOB WTU "<DEMOB WTU Station>" Station
            //And I select the "<TradocRegion>" from the TRADOC Region dropdown, enter a comment, and press the select button
            //And I verify the admin tab details dissapears


            //	Scenarios: 
            //	| Role                        | Pin        | Scope     | Station                     | CaseID       | DEMOB WTU Station              | TradocRegion |
            //	| WTU Manager TRADOC Fort Lee | 8880070613 | -- All -- | TRADOC - Fort Lee, Virginia | WTU-18-00104 | TRADOC - Fort Benning, Georgia | 198th IN BDE |

        }

    }
}
