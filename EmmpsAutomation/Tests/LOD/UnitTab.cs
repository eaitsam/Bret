using EmmpsAutomation.PageObjectModel.LOD;
using FluentAssertions;
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
    public class UnitTab
    {

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        StartNewLODPage _startnewlod;
        SearchFilterObjects _searchFilter;
        MiscPageOjects _miscPageOjects;
        LODSearchPage _myLodSearchPage;
        MyLODMenuNav _mylodMenuNav;
        LODUnitTabPage _unitTab;

        public UnitTab()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _startnewlod = new StartNewLODPage();
            _searchFilter = new SearchFilterObjects();
            _miscPageOjects = new MiscPageOjects();
            _myLodSearchPage = new LODSearchPage();
            _mylodMenuNav = new MyLODMenuNav();
            _unitTab = new LODUnitTabPage();
        }

        [Fact]
        public void LODUnitTabPageValidations()
        {
          try 
          { 

                //Login
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070122");

                //Navigate to StartNewLOD 
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "368009687");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-180));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");

                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");
                UIActions.SelectElementByValue(_startnewlod.RowsPerPage, "50");

                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "AR Informal");
                UIActions.JSClickElement(_startnewlod.CreateLODButton);

                //////

                //click Medical Tab
                UIActions.ClickElement(_mylodMenuNav.LODUnitMenuLinkButton);

                //////

                          
                UIActions.GetElement(_unitTab.LODUnitIncidenetDateHourValidMessage).Displayed.Should().BeTrue();
                UIActions.GetElement(_unitTab.LODUnitIncidenetDateHourValidMessage).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_unitTab.LODUnitIncidentDateTextBox, (UIActions.SelectDate(Convert.ToInt32(-190)) + " 0000"));
                ObjectRepository.Driver.FindElements(_unitTab.LODUnitIncidenetDateHourValidMessage).Count.Should().Be(0);

                UIActions.GetElement(_unitTab.LODUnitIncidenetCityMessage).Displayed.Should().BeTrue();
                UIActions.GetElement(_unitTab.LODUnitIncidenetCityMessage).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_unitTab.LODUnitIncidentCityTextBox, "SomeWhere");
                ObjectRepository.Driver.FindElements(_unitTab.LODUnitIncidenetCityMessage).Count.Should().Be(0);

                UIActions.GetElement(_unitTab.LODUnitIncidenetRegionValidMessage).Displayed.Should().BeTrue();
                UIActions.GetElement(_unitTab.LODUnitIncidenetRegionValidMessage).Text.Should().BeEquivalentTo("Required");
                UIActions.SelectElementByText(_unitTab.LODUnitIncidentRegion, "Ohio");
                ObjectRepository.Driver.FindElements(_unitTab.LODUnitIncidenetRegionValidMessage).Count.Should().Be(0);

                UIActions.GetElement(_unitTab.LODUnitDutyStatusValidMessage).Displayed.Should().BeTrue();
                UIActions.GetElement(_unitTab.LODUnitDutyStatusValidMessage).Text.Should().BeEquivalentTo("Required");
                UIActions.SelectElementByText(_unitTab.LODUnitDutyStatus, "Present For Duty");
                ObjectRepository.Driver.FindElements(_unitTab.LODUnitDutyStatusValidMessage).Count.Should().Be(0);

                UIActions.GetElement(_unitTab.LODUnitPOCValidMessage).Displayed.Should().BeTrue();
                UIActions.GetElement(_unitTab.LODUnitPOCValidMessage).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBox(_unitTab.LODUnitPOCInfoTextBox, "Self");
                ObjectRepository.Driver.FindElements(_unitTab.LODUnitPOCValidMessage).Count.Should().Be(0);

                UIActions.GetElement(_unitTab.LODUnitIndivWasOnValidMessage).Displayed.Should().BeTrue();
                UIActions.GetElement(_unitTab.LODUnitIndivWasOnValidMessage).Text.Should().BeEquivalentTo("Required");
                UIActions.SelectElementByText(_unitTab.LODUnitIndivWasOn, "Active Duty");
                ObjectRepository.Driver.FindElements(_unitTab.LODUnitIndivWasOnValidMessage).Count.Should().Be(0);

                UIActions.TypeInTextBox(_unitTab.LODUnitDistanceInvolved, "25");

                UIActions.GetElement(_unitTab.LODUnitDetailsOfAccidentValidMessage).Displayed.Should().BeTrue();
                UIActions.GetElement(_unitTab.LODUnitDetailsOfAccidentValidMessage).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBox(_unitTab.LODUnitDetailsOfAccident, "Automation Test");
                ObjectRepository.Driver.FindElements(_unitTab.LODUnitDetailsOfAccidentValidMessage).Count.Should().Be(0);

           }




          finally
           {
              _driverInit.TearDown();
           }

        }
        [Fact]
        public void LODUnitTabPageValidations2()
        {
          try 
          { 
                //Login
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070122");

                //Navigate to StartNewLOD 
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, "368009687");
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(-180));
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other");

                UIActions.GetElement(_startnewlod.NextButton).Click();
                UIActions.GetElement(_startnewlod.ExceptionToPolicyCommentBox).SendKeys("Start New LOD");
                UIActions.SelectElementByValue(_startnewlod.RowsPerPage, "50");

                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "AR Informal");
                UIActions.JSClickElement(_startnewlod.CreateLODButton);


                //click Medical Tab
                UIActions.ClickElement(_mylodMenuNav.LODUnitMenuLinkButton);


                //verify required fields for Unit Tab
                WaitMethods.Wait(_unitTab.LODUnitIncidentDateTextBox, 60);
                Assert.True(UIActions.IsElementPresent(_unitTab.LODUnitIncidenetDateHourValidMessage));
                Assert.True(UIActions.IsElementPresent(_unitTab.LODUnitIncidenetCityMessage));
                Assert.True(UIActions.IsElementPresent(_unitTab.LODUnitIncidenetRegionValidMessage));
                Assert.True(UIActions.IsElementPresent(_unitTab.LODUnitPOCValidMessage));
                Assert.True(UIActions.IsElementPresent(_unitTab.LODUnitDetailsOfAccidentValidMessage));
                Assert.True(UIActions.IsElementPresent(_unitTab.LODUnitDutyStatusValidMessage));
                Assert.True(UIActions.IsElementPresent(_unitTab.LODUnitIndivWasOnValidMessage));
                //verify remianing counters
                UIActions.CharactersRemainingValidator(_unitTab.LODUnitPOCInfoTextBox, _unitTab.LODUnitTChactersRemainingPOC);
                UIActions.CharactersRemainingValidator(_unitTab.LODUnitDetailsOfAccident, _unitTab.LODUnitTChactersRemainingDetailOfAccident);


                //Verify dropdownlist
                Assert.True(UIActions.ComboboxInnerTextValidator(_unitTab.LODUnitIncidentRegion, _myLodSearchPage.RegionStatesList));
                Assert.True(UIActions.ComboboxInnerTextValidator(_unitTab.LODUnitDutyStatus, new List<string> { "-- Select --", "Present For Duty", "Absent Without Authority", "Absent With Authority", "On Pass", "On Leave" }));
                Assert.True(UIActions.ComboboxInnerTextValidator(_unitTab.LODUnitIndivWasOn, new List<string> { "-- Select --", "Active Duty", "Active Duty For Training", "Inactive Duty Training" }));
                Assert.True(UIActions.ComboboxInnerTextValidator(_unitTab.LODUnitModeTransporation, new List<string> { "-- Select --", "Commercial Plane", "Commercial Vehicle", "Government Vehicle", "Government Plane", "Privately Owned Vehicle", "Privately Owned Motorcycle", "Ticket Bus", "Ticket Plane" }));

            
                //verify required numeric values for Unit Tab
                string textBoxValue = string.Empty;

                UIActions.TypeInTextBox(_unitTab.LODUnitIncidentDateTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_unitTab.LODUnitIncidentDateTextBox);
                Assert.False(textBoxValue.Length > 0, "Incident Date should not except alphanumeric data");
                textBoxValue = string.Empty;

                textBoxValue = string.Empty;
                UIActions.TypeInTextBox(_unitTab.LODUnitDateofAbsenceAreaA, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_unitTab.LODUnitDateofAbsenceAreaA);
                Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Absence To: Area A should not except alphanumeric data");


                textBoxValue = string.Empty;
                UIActions.TypeInTextBox(_unitTab.LODUnitDateofAbsenceAreaB, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_unitTab.LODUnitDateofAbsenceAreaB);
                Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Absence To: Area B should not except alphanumeric data");

                textBoxValue = string.Empty;
                UIActions.TypeInTextBox(_unitTab.LODUnitDateofTrainingAreaA, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_unitTab.LODUnitDateofTrainingAreaA);
                Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Training To: Area A should not except alphanumeric data");

                textBoxValue = string.Empty;
                UIActions.TypeInTextBox(_unitTab.LODUnitDateofTrainingAreaB, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_unitTab.LODUnitDateofTrainingAreaB);
                Assert.False(textBoxValue.Length > 0, "LOD Unit Date of Training To: Area B should not except alphanumeric data");

                textBoxValue = string.Empty;
           }




           finally
          {
              _driverInit.TearDown();
          }

        }


        //  Scenario Outline: Test 37390 LOD Unit Tab - Validations
        //	Given I am Logged in as <Role> using EDIPIN<PIN>
        //	And I have navigated to "Start New LOD" tab in "eMMPS"
        //	And I have created a New LOD in <Workflow> and<Status> and<SSN> and<EndOfAuthorizedDutyStatusDate> and <ExceptionToPolicy> and<Comments> and <RowsPerPage>
        //	When I click the "Unit" Tab in "LOD"
        //	Then all the fields in the Unit Tab should be displayed to update <IncidentDate> and<IncidentCity> and <IncidentRegion> and<IncidentPOC> and <DutyStatus> and<DateAbsenseFrom> and <HourAbsenseFrom> and<DateAbsenseTo> and <HourAbsenseTo> and<AwolInterferedWithDuty> and <IndivWasOn>  and<dateTrainingBegan> and <HourTraingBegan> and<DateTrainingEnded> and <HourTrainingEnded> and<Transportation> and <Details> and<InjuryLOD>
        //	And all the Unit Tab required fields are updated

        //	Scenarios: 
        //	| Role       | PIN        | SSN       | Workflow    | Status    | EndOfAuthorizedDutyStatusDate | ExceptionToPolicy | Comments      | RowsPerPage | IncidentDate | IncidentCity | IncidentRegion | IncidentPOC | DutyStatus       | DateAbsenseFrom | HourAbsenseFrom | DateAbsenseTo | HourAbsenseTo | AwolInterferedWithDuty | IndivWasOn  | dateTrainingBegan | HourTraingBegan | DateTrainingEnded | HourTrainingEnded | Transportation | Details         | InjuryLOD |
        //	| Unit Admin | 8880070122 | 368009687 | AR Informal | -- All -- | -182                          | Other             | Start New LOD | 50          | -190         | SomeWhere    | Ohio           | Self        | Present For Duty |                 |                 |               |               |                        | Active Duty |                   |                 |                   |                   |                | Automation Test |           |

        //  Scenario Outline: Test 37390 LOD Unit Tab - Input Validations
        //	Given I am Logged in as <Role> using EDIPIN <PIN>
        //	And I have navigated to "Start New LOD" tab in "eMMPS"
        //	And I have created a New LOD in <Workflow> and<Status> and<SSN> and<EndOfAuthorizedDutyStatusDate> and <ExceptionToPolicy> and<Comments> and <RowsPerPage>
        //	When I click the "Unit" Tab in "LOD"
        //	Then all the Unit Tab required fields are displayed
        //	And the options for the drop downs in the Unit Tab are correct
        //	And all the Unit Tab numeric fileds have been validated

        //	Scenarios: 
        //	| Role       | PIN        | SSN       | Workflow               | Status    | EndOfAuthorizedDutyStatusDate | ExceptionToPolicy | Comments      | RowsPerPage |
        //	| Unit Admin | 8880070122 | 368009687 | AR Informal            | -- All -- | -182                          | Other             | Start New LOD | 50          |

    }
}
