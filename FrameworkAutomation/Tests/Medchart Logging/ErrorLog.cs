using FluentAssertions;
using FrameworkAutomation.PageObjectModel;
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
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.Medchart_Logging
{
    public class ErrorLog
    {
        

        private BaseDriverInit _webDriver;
        private Login _login;
        private NavMenuObjects _nav;
        private ErrorLogPage _errorLog;
        private SearchFilterObjects _searchFilter;

        public ErrorLog()
        {
            _webDriver = new BaseDriverInit();
            _login = new Login();
            _nav = new NavMenuObjects();
            _errorLog = new ErrorLogPage();
        }

        [Fact]
        public void MedchartSysAdminViewErrorLogTest()
        {
            try
            {
                //# Medchart Sys Admin - View Error Log Permissions
                //# Test Case 68012
                _webDriver.InitWebdriver();
                _login.LoginMethod("9990001100");
                List<By> tabs = new List<By> { _nav.AdminMenuBarXpath, _nav.ViewErrorLogMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //Check Page Description
                UIActions.GetElement(_errorLog.PageDecriptionLabel).Text.Should().Be(_errorLog.PageDescription);

                //Check Module Dropdown
                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_errorLog.ModuleDropdown)
                         .Options, _errorLog.ModuleDropdownExpectedValues, true).Should().BeTrue();

                //Check Filter Objects
                UIActions.GetElement(_errorLog.UserFirstNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.UserLastNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.DateFromTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.DateToTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.SearchButton).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.ResetButton).Displayed.Should().BeTrue();

                //Click Search Button
                UIActions.GetElement(_errorLog.SearchButton).Click();

                //Check the Grid for appropriate columns and pagination values
                _errorLog.GetColumnByName("Date").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("User").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("EDIPI").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("Server").Displayed.Should().BeTrue();

                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_errorLog.PaginationDropdown)
                    .Options, _errorLog.PageDropdownExpectedValues).Should().BeTrue();

                //Check that the data is sortable
                _errorLog.GetColumnByName("ID").Click();
                WaitMethods.Wait(_errorLog.PaginationDropdown, 10);

                //Check that the grid can be paged
                _errorLog.GetPaginationByNumber(2).Click();
                WaitMethods.Wait(_errorLog.PaginationDropdown, 10);

                //Check that the number of rows per page can be changed
                _errorLog.CustomWaitSelectByText(_errorLog.PaginationDropdown, "25");
                WaitMethods.Wait(_errorLog.ModuleDropdown, 10);

                //Check Filters
                //- First Name
                UIActions.TypeInTextBox(_errorLog.UserFirstNameTextBox, "MEDCHART");
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- Last Name
                UIActions.TypeInTextBox(_errorLog.UserLastNameTextBox, "Sys Admin");
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- From Date
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.FromDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- To Date
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //Check Reset Button
                _errorLog.CustomWaitClick(_errorLog.ResetButton);

                //Check Date Time Boxes
                // - From Date
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.FromDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);

                //- To Date
                UIActions.ClickElement(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.GetTextBoxTextValue(_errorLog.DateToTextBox).Should().Be("");

                UIActions.ClickElement(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.GetTextBoxTextValue(_errorLog.DateToTextBox).Should().Be("");
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        [Fact]
        public void EcaseSysAdminViewErrorLogTest()
        {
            try
            {
                //# eCase Sys Admin - View Error Log Permissions
                //# Test Case 68009
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010167");
                List<By> tabs = new List<By> { _nav.AdminMenuBarXpath, _nav.ViewErrorLogMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //Check Page Description
                UIActions.GetElement(_errorLog.PageDecriptionLabel).Text.Should().Be(_errorLog.PageDescription);

                //Check Module Dropdown
                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_errorLog.ModuleDropdown)
                         .Options, _errorLog.ModuleDropdownExpectedValues.Where(s => s.ToString() == "- All modules -" || s.ToString() == "eCase").ToList(), true).Should().BeTrue();
                
                //Check Filter Objects
                UIActions.GetElement(_errorLog.UserFirstNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.UserLastNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.DateFromTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.DateToTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.SearchButton).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.ResetButton).Displayed.Should().BeTrue();

                //Click Search Button
                UIActions.GetElement(_errorLog.SearchButton).Click();

                //Check the Grid for appropriate columns and pagination values
                _errorLog.GetColumnByName("Date").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("User").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("EDIPI").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("Server").Displayed.Should().BeTrue();

                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_errorLog.PaginationDropdown)
                    .Options, _errorLog.PageDropdownExpectedValues).Should().BeTrue();

                //Check that the data is sortable
                _errorLog.GetColumnByName("ID").Click();
                WaitMethods.Wait(_errorLog.PaginationDropdown, 10);

                //Check that the grid can be paged
                _errorLog.GetPaginationByNumber(2).Click();
                WaitMethods.Wait(_errorLog.PaginationDropdown, 10);

                //Check that the number of rows per page can be changed
                _errorLog.CustomWaitSelectByText(_errorLog.PaginationDropdown, "25");
                WaitMethods.Wait(_errorLog.ModuleDropdown, 10);

                //Check that eCase Module can be searched on
                _errorLog.CustomWaitSelectByText(_errorLog.ModuleDropdown, "eCase");

                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);

                //Check that Select Element Shows Error
                _errorLog.ClickSelectLinkByRowId(2);
                _errorLog.GetShownErrorDialogColumnValues().Should().Contain(_errorLog.ErrorDialogExpectedValues);
                _errorLog.CloseErrorDialog();

                //Check Filters
                //- First Name
                UIActions.TypeInTextBox(_errorLog.UserFirstNameTextBox, "MEDCHART");
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- Last Name
                UIActions.TypeInTextBox(_errorLog.UserLastNameTextBox, "Sys Admin");
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- From Date
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.FromDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- To Date
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //Check Reset Button
                _errorLog.CustomWaitClick(_errorLog.ResetButton);

                //Check Date Time Boxes
                // - From Date
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.FromDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);

                //- To Date
                UIActions.ClickElement(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.GetTextBoxTextValue(_errorLog.DateToTextBox).Should().Be("");

                UIActions.ClickElement(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.GetTextBoxTextValue(_errorLog.DateToTextBox).Should().Be("");
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        [Fact]
        public void OcchealthSysAdminViewErrorLogTest()
        {
            try
            {
                //# OccHealth Sys Admin - View Error Log Permissions
                //# Test Case 68011
                _webDriver.InitWebdriver();
                _login.LoginMethod("4111636236");
                List<By> tabs = new List<By> { _nav.AdminMenuBarXpath, _nav.ViewErrorLogMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //Check Page Description
                UIActions.GetElement(_errorLog.PageDecriptionLabel).Text.Should().Be(_errorLog.PageDescription);

                //Check Module Dropdown
                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_errorLog.ModuleDropdown)
                         .Options, _errorLog.ModuleDropdownExpectedValues.Where(s => s.ToString() == "- All modules -" || s.ToString() == "OccHealth").ToList(), true).Should().BeTrue();

                //Check Filter Objects
                UIActions.GetElement(_errorLog.UserFirstNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.UserLastNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.DateFromTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.DateToTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.SearchButton).Displayed.Should().BeTrue();
                UIActions.GetElement(_errorLog.ResetButton).Displayed.Should().BeTrue();

                //Check that OccHealth Module can be searched on
                _errorLog.CustomWaitSelectByText(_errorLog.ModuleDropdown, "OccHealth");
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);

                //Check the Grid for appropriate columns and pagination values
                _errorLog.GetColumnByName("Date").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("User").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("EDIPI").Displayed.Should().BeTrue();
                _errorLog.GetColumnByName("Server").Displayed.Should().BeTrue();

                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_errorLog.PaginationDropdown)
                    .Options, _errorLog.PageDropdownExpectedValues).Should().BeTrue();

                //Check that the data is sortable
                _errorLog.GetColumnByName("ID").Click();
                WaitMethods.Wait(_errorLog.PaginationDropdown, 10);

                //Check that the number of rows per page can be changed
                _errorLog.CustomWaitSelectByText(_errorLog.PaginationDropdown, "25");
                WaitMethods.Wait(_errorLog.ModuleDropdown, 10);

                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);

                //Check Filters
                //- First Name
                UIActions.TypeInTextBox(_errorLog.UserFirstNameTextBox, "MEDCHART");
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);

                //- Last Name
                UIActions.TypeInTextBox(_errorLog.UserLastNameTextBox, "Sys Admin");
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- From Date
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.FromDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //- To Date
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                _errorLog.CustomWaitClick(_errorLog.SearchButton);
                WaitMethods.Wait(_errorLog.ErrorGrid, 10);
                UIActions.GetElement(_errorLog.ErrorGrid).Displayed.Should().BeTrue();

                //Check Reset Button
                _errorLog.CustomWaitClick(_errorLog.ResetButton);

                //Check Date Time Boxes
                // - From Date
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.FromDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                _errorLog.CustomWaitClick(_errorLog.DateFromTextBox);

                //- To Date
                UIActions.ClickElement(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.GetTextBoxTextValue(_errorLog.DateToTextBox).Should().Be("");

                UIActions.ClickElement(_errorLog.DateToTextBox);
                UIActions.SetDateForDateTimePicker(_errorLog.ToDateDatePicker, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1);
                _errorLog.CustomWaitClick(_errorLog.DateToTextBox);
                UIActions.GetTextBoxTextValue(_errorLog.DateToTextBox).Should().Be("");
            }
            finally
            {
                _webDriver.TearDown();
            }
        }
    }
}
