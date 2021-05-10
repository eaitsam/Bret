using FrameworkAutomation.User_Management.SharedContextData;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;
using FrameworkAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using OpenQA.Selenium;
using System;
using FluentAssertions;

namespace FrameworkAutomation.User_Management
{
    public class SMLookUp
    {
        BaseDriverInit _webDriver;
        private Login _login;
        private Homepage _homepage;
        private SearchFilterObjects _searchFilter;
        private SMLookupPage _lookupPage;

        public SMLookUp()
        {
            _webDriver = new BaseDriverInit();
            _login = new Login();
            _homepage = new Homepage();
            _searchFilter = new SearchFilterObjects();
            _lookupPage = new SMLookupPage();
        }

        //worth noting that some of the search objects are not the same as the search objects in Core Shared Objects, they have a "uc" in the ID,
        //but for the most part are identical. Prob should ask Framework what the difference is

        [Theory]
        [MemberData(nameof(SMLookupTestData.EditDemographicPermissionData), MemberType = typeof(SMLookupTestData))]
        public void SMLookUpManageUsersDemographicPermission(string edipin, string moduleName, string organization, string userRole2, bool exists)
        {
            try
            {
                string permission = "Edit Soldier Demographic Data";

                _webDriver.InitWebdriver();
                _login.LoginMethod(edipin);
                UIActions.ClickElement(_homepage.ManageUsersLink);

                UIActions.SelectElementByText(_searchFilter.OrgCombobox, organization);
                UIActions.SelectElementByText(_searchFilter.MedchartModuleComboBox, moduleName);
                UIActions.SelectElementByText(_searchFilter.RoleComboBox, userRole2);

                UIActions.ClickElement(_searchFilter.ucSearchButton);
                UIActions.ClickElement(_lookupPage.FirstUserSelectLink);

                UIActions.ClickElement(By.XPath(String.Format(_lookupPage.ModuleTabXPath, moduleName)));
                UIActions.ClickElement(By.Id("btnPerm"));


                //This test does not meet the acceptance criteria because it does not verify that the permission is greyed out (meaning its a default perm)
                // Or that the text for the permission is correct
                // Or that the description for the permission is correct
                //All it does is validate that the checkbox exists
                if (exists)
                    Assert.True(UIActions.IsElementPresent(By.XPath(String.Format(_lookupPage.PermissionsCheckboxXPath, permission))));
                else
                    Assert.False(UIActions.IsElementPresent(By.XPath(String.Format(_lookupPage.PermissionsCheckboxXPath, permission))));

                //implment dispose here

            }
            finally 
            {

                _webDriver.TearDown();
            }
        }


        [Fact]
        public void SMLookupSearchVerifyColumns()
        {
            try
            {

            }
            finally
            {
                _webDriver.TearDown();
            }
            _webDriver.InitWebdriver();
            _login.LoginMethod("1119999999");
            UIActions.ClickElement(_homepage.LookupSMLink);

            //fix this not use the string format xpath
            UIActions.TypeInTextBox(By.XPath(String.Format(_lookupPage.LookupSMTextboxXPath, "SSN")), "8971");
            UIActions.ClickElement(_searchFilter.ucSearchButton);

            string columnData = "SSN;EDIPI;Soldier;UIC;Region";
            _lookupPage.VerifyColumnValues(columnData.Split(';'));

        }

        
        [Theory]
        [MemberData(nameof(SMLookupTestData.SearchFunctionVerifyResultsData), MemberType = typeof(SMLookupTestData))]
        public void SMLookupSearchFunctionVerifyResults(string filter, string value, string result, string column)
        {
            try
            {
                _webDriver.InitWebdriver();
                _login.LoginMethod("1119999999");
                UIActions.ClickElement(_homepage.LookupSMLink);
                UIActions.TypeInTextBox(By.XPath(String.Format(_lookupPage.LookupSMTextboxXPath, value)), filter);
                UIActions.ClickElement(_searchFilter.ucSearchButton);
                _lookupPage.VerifyResultInColumn(result, column);

            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        [Fact]
        public void SMLookUpSearchEDIPINFieldValidation()
        {
            //Scenario: SM Lookup - Search Function - EDIPI Field (Less Than 10 Characters)
            //Scenario: SM Lookup - Search Function - EDIPI Field(Alpha Characters)
            // ^^^ merged these two tests into one because two seperate tests testing the same object is not needed
            try
            {
                _webDriver.InitWebdriver();
                _login.LoginMethod("1119999999");
                UIActions.ClickElement(_homepage.LookupSMLink);
                UIActions.TypeInTextBox(_searchFilter.ucEDIPINBox, "1000317860");
                UIActions.ClickElement(_searchFilter.ucSearchButton);
                //All of this needs to be refactored to divorce it from Specflow's table inputs and make it more readable and elegant

                //Boolean choice;
                //if (decision.ToLower().Equals("does"))
                //    choice = true;
                //else if (decision.ToLower().Equals("does not"))
                //    choice = false;
                //else
                //    throw new Exception("Unknown value: " + decision);
                //_lookupPage.VerifyWarningMessage(choice, warning);

                UIActions.TypeInTextBox(By.XPath(String.Format(_lookupPage.LookupSMTextboxXPath, "abcde")), "EDIPI");
                UIActions.ClickElement(By.XPath(string.Format(_lookupPage.ButtonXPath, "Search")));
                //_lookupPage.VerifyEmptyTextbox(textbox.Replace(" ", ""));
                //the validation above doesnt need to be abstracted from the test because its only checking to see if the box is empty

            }
            finally
            {
                _webDriver.TearDown();
            }


        }

        [Fact]
        public void SMLookupSoldierDemoInfoPanelValidations()
        {
            try
            {
                _webDriver.InitWebdriver();
                _login.LoginMethod("1119999999");
                UIActions.ClickElement(_homepage.LookupSMLink);
                UIActions.TypeInTextBox(_searchFilter.ucEDIPINBox, "1000317860");
                UIActions.ClickElement(_searchFilter.ucSearchButton);

                //Validates that the Test Data appears and is correct for the particular test user
                //probably can be redone with more elegant assertions
                _lookupPage.VerifySoldierDemographics("SGT LE ABEL", "Title");
                _lookupPage.VerifySoldierDemographics("United States Army | National Guard", "Panel");
                _lookupPage.VerifySoldierDemographics("SSN:  xxxxx7860", "Panel");
                _lookupPage.VerifySoldierDemographics("DOB | Age:  19980429 | 21", "Panel");
                _lookupPage.VerifySoldierDemographics("Gender:  Male", "Panel");
                _lookupPage.VerifySoldierDemographics("MOS/AOC:  09S", "Panel");

            }
            finally
            {
                _webDriver.TearDown();
            }

        }

        [Fact]
        public void SMLookupSoldierDemoTitleBar()
        {
            try
            {
                _webDriver.InitWebdriver();
                _login.LoginMethod("1119999999");
                UIActions.ClickElement(_homepage.LookupSMLink);
                UIActions.TypeInTextBox(_searchFilter.ucEDIPINBox, "1000317860");
                UIActions.ClickElement(_searchFilter.ucSearchButton);

                //could be improved
                UIActions.GetElement(_lookupPage.SoldierDemographicTitle).Click();
                _lookupPage.VerifySoldierPanelAction("collapses");
                UIActions.GetElement(_lookupPage.SoldierDemographicTitle).Click();
                _lookupPage.VerifySoldierPanelAction("expands");
            }
            finally
            {
                _webDriver.TearDown();
            }

        }

        [Fact]
        public void SMLookupSoldierDemographicsOkCancelButtons()
        {
            try
            {
                _webDriver.InitWebdriver();
                _login.LoginMethod("1119999999");
                UIActions.ClickElement(_homepage.LookupSMLink);
                UIActions.TypeInTextBox(_searchFilter.ucSSNTextBox, "672008635");
                UIActions.ClickElement(_searchFilter.ucSearchButton);

                //Tests the OK Button for the popup window
                UIActions.JSClickElement(_lookupPage.SoldiersExtendedContactInfoLink);
                UIActions.GetElement(_lookupPage.EditSoldierDemographicsPanel).Displayed.Should().BeTrue();

                UIActions.GetElement(_lookupPage.SoldierDemoContactInfoOKButton).Click();
                UIActions.GetElement(_lookupPage.EditSoldierDemographicsPanel).Displayed.Should().BeFalse();

                //Tests the Cancel Button on the popup window
                UIActions.JSClickElement(_lookupPage.SoldiersExtendedContactInfoLink);
                UIActions.GetElement(_lookupPage.EditSoldierDemographicsPanel).Displayed.Should().BeTrue();

                UIActions.GetElement(_lookupPage.SoldierDemoContactInfoCloseButton).Click();
                UIActions.GetElement(_lookupPage.EditSoldierDemographicsPanel).Displayed.Should().BeFalse();
            }
            finally
            {
                _webDriver.TearDown();
            }

        }

        [Fact]
        public void SMLookupSoldierDemoExtContactInfoPageValidation()
        {
            try
            {
                _webDriver.InitWebdriver();
                _login.LoginMethod("1119999999");
                UIActions.ClickElement(_homepage.LookupSMLink);
                UIActions.TypeInTextBox(_searchFilter.ucEDIPINBox, "1000317860");
                UIActions.ClickElement(_searchFilter.ucSearchButton);
                UIActions.JSClickElement(_lookupPage.SoldiersExtendedContactInfoLink);

                //Validates that the Headings in each section of the Soldier Contact Information Modal Appear and are Correct
                UIActions.GetElement(_lookupPage.ExtInfoTAPDBHeading).Displayed.Should().BeTrue();
                UIActions.GetElement(_lookupPage.ExtInfoTAPDBHeading).Text.Should().Be("Soldier Data from TAPDB");

                UIActions.GetElement(_lookupPage.ExtInfoContactInfoHeading).Displayed.Should().BeTrue();
                UIActions.GetElement(_lookupPage.ExtInfoContactInfoHeading).Text.Should().Be("Contact Information");

                UIActions.GetElement(_lookupPage.ExtInfoMailAddress1Heading).Displayed.Should().BeTrue();
                UIActions.GetElement(_lookupPage.ExtInfoMailAddress1Heading).Text.Should().Be("Mailing Address 1");

                UIActions.GetElement(_lookupPage.ExtInfoMailAddress2Heading).Displayed.Should().BeTrue();
                UIActions.GetElement(_lookupPage.ExtInfoMailAddress2Heading).Text.Should().Be("Mailing Address 2");

                //Validates that the disclamer text underneath "Contact Information" and Soldier Data from TAPDB appears and is correct
                UIActions.GetElement(_lookupPage.EditableFieldsDisclaimerText).Displayed.Should().BeTrue();
                UIActions.GetElement(_lookupPage.EditableFieldsDisclaimerText).Text.Should().BeSameAs(_lookupPage.SoldierDemoExtContactInfoSMDisclaimer);

                UIActions.GetElement(_lookupPage.ItalicSoldierDataTAPDBText).Displayed.Should().BeTrue();
                UIActions.GetElement(_lookupPage.ItalicSoldierDataTAPDBText).Text.Should().BeSameAs(_lookupPage.SoldierDemoExtTAPDBDisclaimer);
            }
            finally
            {
                _webDriver.TearDown();
            }


        }


        [Fact]
        public void SMLookupSoldierDemoExtContactInfoNoEditPermissions()
        {
            try
            {

            }
            finally
            {
                _webDriver.TearDown();
            }
            //Stub for test to determine if a user can edit the Extended contact info without the correct permissions
            //verify if user has any of the comboboxes and text fields editable if they dont have the correct permissions

            //will likely need a test EDIPIN that doesnt have the permission, makes no sense to go into permissions to take it away from a user

            //will likely need a test script created
        }

        [Fact]
        public void ExtSoldierDemographicsInputValidation()
        {
            try
            {

            }
            finally
            {
                _webDriver.TearDown();
            }
            //Scenario Outline: SM Lookup - Soldier Demographics - Textbox Verification
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "Lookup SM" link in the MEDCHART tile
            //	And I enter "1000317860" in the "EDIPI" textbox
            //	And I click the "Search" button
            //	And I click the "Soldier's Contact Information" link
            //	And I enter<Text> in the<Textbox> textbox
            //	Then the <Textbox> textbox should appear<Color>
            //	And the<Expected Text> appears in the<Textbox> textbox

            //Scenarios:
            //		| Textbox             | Text               | Expected Text      | Color |
            //		| Email Address       | ronald6 @boring.com | ronald6 @boring.com | red   |
            //		| Email Address       | joe7 @cool.gov      | joe7 @cool.gov      | white |
            //		| Civilian Email      | hello              | hello              | red   |
            //		| Civilian Email      | le1f @erikson.no    | le1f @erikson.no  | white |
            //		| Primary Phone       | abc                | abc                | red   |
            //		| Primary Phone       | 9873819248         | 9873819248         | white |
            //		| Primary Phone       | 98738192481        | 9873819248         | white |
            //		| Primary Phone Ext   | abc                | abc                | red   |
            //		| Primary Phone Ext   | 12345              | 12345              | white |
            //		| Primary Phone Ext   | 123456             | 12345              | white |
            //		| Secondary Phone     | abc                | abc                | red   |
            //		| Secondary Phone     | 9873819248         | 9873819248         | white |
            //		| Secondary Phone     | 98738192481        | 9873819248         | white |
            //		| Secondary Phone Ext | abc                | abc                | red   |
            //		| Secondary Phone Ext | 12345              | 12345              | white |
            //		| Secondary Phone Ext | 123456             | 12345              | white |
            //		| Address 1           | my address 1       | my address 1       | white |
            //		| Address 2           | my address 2       | my address 2       | white |
            //		| City                | Duckburg 12        | Duckburg 12        | white |
            //		| Zip Code            | xyz                | xyz                | red   |
            //		| Zip Code            | 12345              | 12345              | white |
            //		| Zip Code            | 123456             | 12345              | white |
            //		| Alternate Address 1 | alt address 1      | alt address 1      | white |
            //		| Address 2           | alt address 2      | alt address 2      | white |
            //		| Alternate City      | Arrakis 17         | Arrakis 17         | white |
            //		| Alternate Zip Code  | zxy                | zxy                | red   |
            //		| Alternate Zip Code  | 12345              | 12345              | white |
            //		| Alternate Zip Code  | 123456             | 12345              | white |

            //Scenario Outline: SM Lookup - Soldier Demographics - Dropdown Verification
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "Lookup SM" link in the MEDCHART tile
            //	And I enter "1000317860" in the "EDIPI" textbox
            //	And I click the "Search" button
            //	And I click the "Soldier's Contact Information" link
            //	And I select<Selection> in the<Dropdown> dropdown
            //	Then the <Dropdown> dropdown should appear<Color>
            //	And the<Selection> appears in the<Dropdown> dropdown

            //Scenarios:
            //		| Dropdown         | Selection     | Color |
            //		| Region           | Virginia      | white |
            //		| Alternate Region | Massachusetts | white |


            //Scenario: SM Lookup - Soldier Demographics - Editable Fields
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "Lookup SM" link in the MEDCHART tile
            //	And I enter "1000317860" in the "EDIPI" textbox
            //	And I click the "Search" button
            //	And I click the "Soldier's Contact Information" link
            //	Then the page "does" include editable fields

            //Scenario: SM Lookup - Soldier Demographics - Noneditable Fields
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "Lookup SM" link in the MEDCHART tile
            //	And I enter "672008635" in the "SSN" textbox
            //	And I click the "Search" button
            //	And I click the "Soldier's Contact Information" link
            //	Then the page "does not" include editable fields

        }

        [Fact]
        public void SMLookupSoldierDemoSubmitButton()
        {
            try
            {

            }
            finally
            {
                _webDriver.TearDown();
            }
            //Scenario: SM Lookup - Soldier Demographics - Submit Button
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "Lookup SM" link in the MEDCHART tile
            //	And I enter "1000317860" in the "EDIPI" textbox
            //	And I click the "Search" button
            //	And I click the "Soldier's Contact Information" link
            //	And I enter "abc" in the "Primary Phone Ext" textbox
            //	And I enter "xyz" in the "Secondary Phone Ext" textbox
            //	And I enter "THIS SHOULD FAIL" in the "Civilian Email" textbox
            //	And I click the "Submit" button
            //	Then the Edit Soldier Demographics panel is "open"
            //	When I enter "123" in the "Primary Phone Ext" textbox
            //	And I enter "456" in the "Secondary Phone Ext" textbox
            //	And I enter "this@should.work" in the "Civilian Email" textbox
            //	And I click the "Submit" button
            //	Then the Edit Soldier Demographics panel is "closed"

        }


        [Fact]
        public void SMLookupEditableFieldsNewECase()
        {
            try
            {

            }
            finally
            {
                _webDriver.TearDown();
            }

            //Scenario: SM Lookup - new eCase - Editable Fields
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "Create a New Case" link in the MEDCHART tile
            //	And I enter "8971" in the "SSN" textbox
            //	And I click the "Search" button
            //	And I select any user
            //	And I click the "Soldier's Contact Information" link
            //	Then the page "does" include editable fields

        }

        [Fact]
        public void SMLookupMyAccountInputValidations()
        {
            try
            {

            }
            finally
            {
                _webDriver.TearDown();
            }
            //Scenario Outline: SM Lookup - My Account - Textbox Verification(Invalid Phone Number)
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "My Account" link in the MEDCHART tile
            //	And I enter<Text> in the<Textbox> textbox
            //	And I click the "Save Changes" button
            //	Then the system "does" display a warning message reading "Please enter a valid phone number"
            //	And the <Expected Text> appears in the<Textbox> textbox

            //Scenarios:
            //		| Textbox         | Text | Expected Text |
            //		| Primary Phone   | abc  | abc           |
            //		| Secondary Phone | abc  | abc           |

            //Scenario Outline: SM Lookup - My Account - Textbox Verification (Valid Phone Number)
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "My Account" link in the MEDCHART tile
            //	And I enter<Text> in the<Textbox> textbox
            //	And I click the "Save Changes" button
            //	Then the system "does not" display a warning message reading "Please enter a valid phone number"
            //	And the <Expected Text> appears in the<Textbox> textbox

            //Scenarios:
            //		| Textbox         | Text        | Expected Text |
            //		| Primary Phone   | 9596569469  | 9596569469    |
            //		| Primary Phone   | 95965694691 | 9596569469    |
            //		| Secondary Phone | 9383381189  | 9383381189    |
            //		| Secondary Phone | 93833811891 | 9383381189    |

            //Scenario Outline: SM Lookup - My Account - Textbox Verification (Invalid Extension)
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "My Account" link in the MEDCHART tile
            //	And I enter<Text> in the<Textbox> textbox
            //	And I click the "Save Changes" button
            //	Then the system "does" display a warning message reading "Please enter a valid extension"
            //	And the <Expected Text> appears in the<Textbox> textbox

            //Scenarios:
            //		| Textbox             | Text | Expected Text |
            //		| Primary Phone Ext   | abc  | abc           |
            //		| Secondary Phone Ext | abc  | abc           |

            //Scenario Outline: SM Lookup - My Account - Textbox Verification (Valid Extension)
            //	Given I am Logged in as "Lead MCM" using EDIPIN 1119999999
            //	When I select the "My Account" link in the MEDCHART tile
            //	And I enter<Text> in the<Textbox> textbox
            //	And I click the "Save Changes" button
            //	Then the system "does not" display a warning message reading "Please enter a valid extension"
            //	And the <Expected Text> appears in the<Textbox> textbox

            //Scenarios:
            //		| Textbox             | Text   | Expected Text |
            //		| Primary Phone Ext   | 72352  | 72352         |
            //		| Primary Phone Ext   | 723521 | 72352         |
            //		| Secondary Phone Ext | 17482  | 17482         |
            //		| Secondary Phone Ext | 174821 | 17482         |

        }

    }
}
