using EmmpsAutomation.PageObjectModel.LOD;
using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Xunit;



namespace EmmpsAutomation.LOD
{


    public class soldierTab
    {

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        StartNewLODPage _startnewlod;
        SearchFilterObjects _searchFilter;
        LODSoldierTab _soldierTab;

        public soldierTab()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _startnewlod = new StartNewLODPage();
            _searchFilter = new SearchFilterObjects();
            _soldierTab = new LODSoldierTab();
        }

        [Fact]
        public void soldierTabPageValidations()
        {
            try
            {


                // Test 37389 LOD Soldier Tab - Validations 


                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.TypeInTextBox(_startnewlod.SsnBox, "914008363"); //ssn
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(Convert.ToInt32(-181)));  //endofauthorized
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Behavioral Health"); //exceptiontopolicy

                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.ExceptionToPolicyCommentBox, "Start New LOD"); //comments
                UIActions.SelectElementByValue(_startnewlod.RowsPerPage, "50"); //rowsperpage

                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "NG M-Day (Informal)"); //workflow

                UIActions.JSClickElement(_startnewlod.CreateLODButton);

                //-------> 4) When all the fields in the Soldier Tab are displayed to be updated <ContactStreet> and<ContactCity> and <ContactState> and<ContactZip> and <ContactAKOEmail> and<ContactHmPhone>

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactStreetValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactStreetValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoStreetAddressTextBox, "55 Test St");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactStreetValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoCityTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactCityValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactCityValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCityTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoCityTextBox, "FairFax");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCityTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactCityValidationMess).Count.Should().Be(0);

                UIActions.SelectElementByText(_soldierTab.LODSoldierContactInfoStateDropDown, "--Select--");
                UIActions.GetElement(_soldierTab.LODSolierContactStateValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactStateValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.SelectElementByText(_soldierTab.LODSoldierContactInfoStateDropDown, "Virginia");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStateDropDown);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactStateValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoZipTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactZipValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactZipValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoZipTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoZipTextBox, "22031");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoZipTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactZipValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoEmailTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactAKOEmailValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactAKOEmailValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoEmailTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoEmailTextBox, "test@mail.mil");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoEmailTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactAKOEmailValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactHmPhoneValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactHmPhoneValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoHomePhoneTextBox, "703-111-1111");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactHmPhoneValidationMess).Count.Should().Be(0);


                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoCellPhoneTextBox, "703-111-1111");

                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox, "703-111-1111");
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactCityValidationMess).Count.Should().Be(0);
            }

            finally
            {
                _driverInit.TearDown();
            }

        } 


        //Test 37389 LOD Soldier Tab - Input Validations

        [Fact]
        public void soldierTabPageInputValidations()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");
                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, " 367009658"); //ssn
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(Convert.ToInt32(-181)));  //endofauthorized
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other"); //exceptiontopolicy

                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.ExceptionToPolicyCommentBox, "Start New LOD"); //comments
                UIActions.SelectElementByValue(_startnewlod.RowsPerPage, "50"); //rowsperpage

                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "NG M-Day (Formal)"); //workflow

                UIActions.JSClickElement(_startnewlod.CreateLODButton);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactStreetValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactStreetValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoStreetAddressTextBox, "55 Test St");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactStreetValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoCityTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactCityValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactCityValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCityTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoCityTextBox, "FairFax");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCityTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactCityValidationMess).Count.Should().Be(0);

                UIActions.SelectElementByText(_soldierTab.LODSoldierContactInfoStateDropDown, "--Select--");
                UIActions.GetElement(_soldierTab.LODSolierContactStateValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactStateValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.SelectElementByText(_soldierTab.LODSoldierContactInfoStateDropDown, "Virginia");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStateDropDown);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactStateValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoZipTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactZipValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactZipValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoZipTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoZipTextBox, "22031");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoZipTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactZipValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoEmailTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactAKOEmailValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactAKOEmailValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoEmailTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoEmailTextBox, "test@mail.mil");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoEmailTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactAKOEmailValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactHmPhoneValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactHmPhoneValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoHomePhoneTextBox, "703-111-1111");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactHmPhoneValidationMess).Count.Should().Be(0);


                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoCellPhoneTextBox, "703-111-1111");

                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox, "703-111-1111");
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactCityValidationMess).Count.Should().Be(0);

                //	Then the options for the drop downs in the Soldier Tab are correct
                Assert.True(UIActions.ComboboxInnerTextValidator(_soldierTab.LODSoldierThruAddressRegionDropDown, _soldierTab.RegionStatesList));
                Assert.True(UIActions.ComboboxInnerTextValidator(_soldierTab.LODSoldierToAddressRegionDropDown, _soldierTab.RegionStatesList));
                Assert.True(UIActions.ComboboxInnerTextValidator(_soldierTab.LODSoldierFromAddressRegionDropDown, _soldierTab.RegionStatesList));
                Assert.True(UIActions.ComboboxInnerTextValidator(_soldierTab.LODSoldierContactInfoStateDropDown, _soldierTab.RegionStatesList));
                Assert.True(UIActions.ComboboxInnerTextValidator(_soldierTab.LODSoldierRankDropDown, new List<string> { "--Select--", "Private (PV1)", "Private (PV2)", "Private First Class (PFC)", "Specialist (SPC)", "Corporal (CPL)", "Sergeant (SGT)", "Staff Sergeant (SSG)", "Sergeant First Class (SFC)", "Master Sergeant (MSG)", "First Sergeant (1SG)", "Sergeant Major (SGM)", "Command Sergeant Major (CSM)", "Sergeant Major of the Army (SMA)", "Warrant Officer 1 (WO1)", "Chief Warrant Officer 2 (CW2)", "Chief Warrant Officer 3 (CW3)", "Chief Warrant Officer 4 (CW4)", "Chief Warrant Officer 5 (CW5)", "Second Lieutenant (2LT)", "First Lieutenant (1LT)", "Captain (CPT)", "Major (MAJ)", "Lieutenant Colonel (LTC)", "Colonel (COL)", "Brigadier General (BG)", "Major General (MG)", "Lieutenant General (LTG)", "General (GEN)" }));

                //	And all the Soldier Tab numeric fileds have been validated

                string textBoxValue = string.Empty;
                string holdTextBoxValue = string.Empty; //used to account for data that may already be in the numeric field

                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierFromAddressZipTextBox);
                UIActions.TypeInTextBox(_soldierTab.LODSoldierFromAddressZipTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierFromAddressZipTextBox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address From Zip should not except alphanumeric data");

                textBoxValue = string.Empty;
                holdTextBoxValue = string.Empty;
                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierToAddressZipTextBox);
                UIActions.TypeInTextBox(_soldierTab.LODSoldierToAddressZipTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierToAddressZipTextBox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address To Zip should not except alphanumeric data");

                textBoxValue = string.Empty;
                holdTextBoxValue = string.Empty;
                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierThruAddressZipTextBox);
                UIActions.TypeInTextBox(_soldierTab.LODSoldierThruAddressZipTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierThruAddressZipTextBox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Thru Zip should not except alphanumeric data");

                textBoxValue = string.Empty;
                holdTextBoxValue = string.Empty;
                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoZipTextBox);
                UIActions.TypeInTextBox(_soldierTab.LODSoldierContactInfoZipTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoZipTextBox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Zip should not except alphanumeric data");

                textBoxValue = string.Empty;
                holdTextBoxValue = string.Empty;
                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                UIActions.TypeInTextBox(_soldierTab.LODSoldierContactInfoHomePhoneTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Home Phone should not except alphanumeric data");

                textBoxValue = string.Empty;
                holdTextBoxValue = string.Empty;
                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                UIActions.TypeInTextBox(_soldierTab.LODSoldierContactInfoCellPhoneTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Cell Phone should not except alphanumeric data");

                textBoxValue = string.Empty;
                holdTextBoxValue = string.Empty;
                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                UIActions.TypeInTextBox(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Work Phone should not except alphanumeric data");

                textBoxValue = string.Empty;
                holdTextBoxValue = string.Empty;
                holdTextBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSolierContactDobDateTextbox);
                UIActions.TypeInTextBox(_soldierTab.LODSolierContactDobDateTextbox, "alpha");
                textBoxValue = UIActions.GetTextBoxTextValue(_soldierTab.LODSolierContactDobDateTextbox);
                Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info DOB should not except alphanumeric data");

            }
            finally
            {
                _driverInit.TearDown();
            }


        }


        //Scenario Outline: Test 37389 LOD Soldier Tab - Field Validations

        [Fact]
        public void soldierTabPageFieldValidations()

        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070115");

                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink, _navMenu.StartNewLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.TypeInTextBox(_startnewlod.SsnBox, " 367009658"); //ssn
                UIActions.JSClickElement(_startnewlod.SearchButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.EndOfAuthorizedDutyDateBox, UIActions.SelectDate(Convert.ToInt32(-181)));  //endofauthorized
                UIActions.SelectElementByText(_startnewlod.ExceptionToPolicy, "Other"); //exceptiontopolicy

                UIActions.JSClickElement(_startnewlod.NextButton);

                UIActions.TypeInTextBoxAndEnter(_startnewlod.ExceptionToPolicyCommentBox, "Start New LOD"); //comments
                UIActions.SelectElementByValue(_startnewlod.RowsPerPage, "50"); //rowsperpage

                UIActions.JSClickElement(_startnewlod.NextButton);
                UIActions.SelectElementByText(_startnewlod.WorkflowDropDownBox, "NG M-Day (Formal)"); //workflow

                UIActions.JSClickElement(_startnewlod.CreateLODButton);

                //Verify fields exist
                WaitMethods.Wait(_soldierTab.LODSoldierThruAddressUnitTextBox, 30);
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierThruAddressUnitTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierThruAddressStreetTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierThruAddressCityTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierThruAddressRegionDropDown));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierThruAddressZipTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierThruAddressMakeDefaultChkBox));

                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierToAddressUnitTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierToAddressStreetTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierToAddressCityTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierToAddressRegionDropDown));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierToAddressZipTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierToAddressMakeDefaultChkBox));

                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierFromAddressUnitTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierFromAddressStreetTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierFromAddressCityTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierFromAddressRegionDropDown));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierFromAddressZipTextBox));
                Assert.True(UIActions.IsElementPresent(_soldierTab.LODSoldierFromAddressMakeDefaultChkBox));



                //       UIActions.GetElement(_soldierTab.LODSoldierThruAddressUnitTextBox).Displayed.Should().BeTrue();
                //      UIActions.GetElement(_soldierTab.LODSoldierThruAddressStreetTextBox).Displayed.Should().BeTrue();
                //     UIActions.GetElement(_soldierTab.LODSoldierThruAddressCityTextBox).Displayed.Should().BeTrue();
                //    UIActions.GetElement(_soldierTab.LODSoldierThruAddressRegionDropDown).Displayed.Should().BeTrue();
                //   UIActions.GetElement(_soldierTab.LODSoldierThruAddressZipTextBox).Displayed.Should().BeTrue();
                //      UIActions.GetElement(_soldierTab.LODSoldierThruAddressMakeDefaultChkBox).Displayed.Should().BeTrue();

                //     UIActions.GetElement(_soldierTab.LODSoldierToAddressUnitTextBox).Displayed.Should().BeTrue();
                //    UIActions.GetElement(_soldierTab.LODSoldierToAddressStreetTextBox).Displayed.Should().BeTrue();
                //   UIActions.GetElement(_soldierTab.LODSoldierToAddressCityTextBox).Displayed.Should().BeTrue();
                //   UIActions.GetElement(_soldierTab.LODSoldierToAddressRegionDropDown).Displayed.Should().BeTrue();
                //   UIActions.GetElement(_soldierTab.LODSoldierToAddressZipTextBox).Displayed.Should().BeTrue();
                //     UIActions.GetElement(_soldierTab.LODSoldierToAddressMakeDefaultChkBox).Displayed.Should().BeTrue();

                //UIActions.GetElement(_soldierTab.LODSoldierFromAddressUnitTextBox).Displayed.Should().BeTrue();
                //UIActions.GetElement(_soldierTab.LODSoldierFromAddressStreetTextBox).Displayed.Should().BeTrue();
                //UIActions.GetElement(_soldierTab.LODSoldierFromAddressCityTextBox).Displayed.Should().BeTrue();
                //UIActions.GetElement(_soldierTab.LODSoldierFromAddressRegionDropDown).Displayed.Should().BeTrue();
                //UIActions.GetElement(_soldierTab.LODSoldierFromAddressZipTextBox).Displayed.Should().BeTrue();
                //      UIActions.GetElement(_soldierTab.LODSoldierFromAddressMakeDefaultChkBox).Displayed.Should().BeTrue();

                //The required fields
                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactStreetValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactStreetValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoStreetAddressTextBox, "55 Test St");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStreetAddressTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactStreetValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoCityTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactCityValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactCityValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCityTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoCityTextBox, "FairFax");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCityTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactCityValidationMess).Count.Should().Be(0);

                UIActions.SelectElementByText(_soldierTab.LODSoldierContactInfoStateDropDown, "--Select--");
                UIActions.GetElement(_soldierTab.LODSolierContactStateValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactStateValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.SelectElementByText(_soldierTab.LODSoldierContactInfoStateDropDown, "Virginia");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoStateDropDown);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactStateValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoZipTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactZipValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactZipValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoZipTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoZipTextBox, "22031");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoZipTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactZipValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoEmailTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactAKOEmailValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactAKOEmailValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoEmailTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoEmailTextBox, "test@mail.mil");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoEmailTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactAKOEmailValidationMess).Count.Should().Be(0);

                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                UIActions.GetElement(_soldierTab.LODSolierContactHmPhoneValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSolierContactHmPhoneValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoHomePhoneTextBox, "703-111-1111");
                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoHomePhoneTextBox);
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactHmPhoneValidationMess).Count.Should().Be(0);


                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoCellPhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoCellPhoneTextBox, "703-111-1111");

                UIActions.JSClickElement(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                UIActions.ClearTextBox(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox);
                UIActions.TypeInTextBoxAndEnter(_soldierTab.LODSoldierContactInfoWorkPhoneTextBox, "703-111-1111");
                ObjectRepository.Driver.FindElements(_soldierTab.LODSolierContactCityValidationMess).Count.Should().Be(0);


                //	#And the defaults are set on the Soldier Tab 
                UIActions.GetElement(_soldierTab.LODSoldierThruAddressMakeDefaultChkBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSoldierToAddressMakeDefaultChkBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSoldierFromAddressMakeDefaultChkBox).Displayed.Should().BeTrue();

                //To Do The Yes/No buttons are HtmlLabels and not working with isSelected or isChecked attributes

                //Assert.True(Convert.ToBoolean(Convert.ToInt32(ObjectRepository.Driver.FindElement(_soldierTab.LODSoldierAttachedUnitNo).GetAttribute("checked"))));
                //Assert.True(Convert.ToBoolean(Convert.ToInt32(ObjectRepository.Driver.FindElement(_soldierTab.LODSoldierAttachedUnitYes).GetAttribute("checked"))));
                //Assert.True(UIActions.IsElementChecked(_soldierTab.LODSoldierAttachedUnitNo));
                //Assert.True(UIActions.IsElementChecked(_soldierTab.LODSoldierAttachedUnitYes));

                //Assert.True(UIActions.IsElementSelected(_soldierTab.LODSoldierAttachedUnitNo));
                //Assert.True(UIActions.IsElementSelected(_soldierTab.LODSoldierABCMRCaseNo));
                //Assert.True(UIActions.IsElementSelected(_soldierTab.LODSoldierAGRCaseNo));
                //Assert.True(UIActions.IsElementSelected(_soldierTab.LODSoldierBehavioralCaseNo));
                //Assert.True(UIActions.IsElementSelected(_soldierTab.LODSoldierIDESCaseNo));

                UIActions.GetElement(_soldierTab.LODSoldierAttachedUnitNo).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSoldierABCMRCaseNo).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSoldierAGRCaseNo).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSoldierBehavioralCaseNo).Displayed.Should().BeTrue();
                UIActions.GetElement(_soldierTab.LODSoldierIDESCaseNo).Displayed.Should().BeTrue();




                //no, yes, labelname?

            }
            finally
            {

                _driverInit.TearDown();

            }


        }


    }

}

