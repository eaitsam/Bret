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
    public class AccessLog
    {

        private BaseDriverInit _webDriver;
        private Login _login;
        private NavMenuObjects _nav;
        private AccessLogPage _accessLog;
        private SearchFilterObjects _searchFilter;

        public AccessLog()
        {
            _webDriver = new BaseDriverInit();
            _login = new Login();
            _nav = new NavMenuObjects();
            _searchFilter = new SearchFilterObjects();
            _accessLog = new AccessLogPage();
        }

        [Fact]
        public void ViewAccessLogGenTest()
        {
            try
            {
                // Test Script 24916
                _webDriver.InitWebdriver();
                _login.LoginMethod("9990001100");
                List<By> tabs = new List<By> { _nav.AdminMenuBarXpath, _nav.ViewAccessLogMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.GetElement(_searchFilter.SearchButton).Click();

                //Check page description
                UIActions.GetElement(_accessLog.PageDecriptionLabel).Text.Should().Be(_accessLog.PageDescription);

                //Check that the page filters and button exist
                UIActions.GetElement(_accessLog.OrganizationDropdown).Displayed.Should().BeTrue();
                UIActions.GetElement(_accessLog.LastNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_accessLog.FirstNameTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_accessLog.DateFromTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_accessLog.DateToTextBox).Displayed.Should().BeTrue();
                UIActions.GetElement(_accessLog.SearchButton).Displayed.Should().BeTrue();
                UIActions.GetElement(_accessLog.ResetButton).Displayed.Should().BeTrue();

                //Check the Grid for appropriate columns and pagination values
                _accessLog.GetColumnByName("Date & Time").Displayed.Should().BeTrue();
                _accessLog.GetColumnByName("Name of User").Displayed.Should().BeTrue();
                _accessLog.GetColumnByName("EDIPI").Displayed.Should().BeTrue();
                _accessLog.GetColumnByName("Browser").Displayed.Should().BeTrue();
                _accessLog.GetColumnByName("Server").Displayed.Should().BeTrue();

                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_accessLog.PaginationDropdown)
                    .Options, _accessLog.PageDropdownExpectedValues).Should().BeTrue();

                //Check that the data is sortable
                _accessLog.GetColumnByName("Date & Time").Click();
                WaitMethods.Wait(_accessLog.AccessLogGridView, 60);

                //Check that the grid can be paged
                _accessLog.GetPaginationByNumber(2).Click();
                WaitMethods.Wait(_accessLog.AccessLogGridView, 60);

                //Check that the number of rows per page can be changed
                UIActions.GetSelectElement(_accessLog.PaginationDropdown).SelectByText("25");
                WaitMethods.Wait(_accessLog.AccessLogGridView, 60);

                //Check that another organization can be searched on
                UIActions.HTMLComboBoxOptionValidator(UIActions.GetSelectElement(_accessLog.OrganizationDropdown)
                         .Options, _accessLog.OrganizationDropdownExpectedValues).Should().BeTrue();

                UIActions.GetSelectElement(_accessLog.OrganizationDropdown).SelectByText("National Guard");

                UIActions.GetElement(_accessLog.SearchButton).Click();
                WaitMethods.Wait(_accessLog.AccessLogGridView, 60);
                UIActions.GetElement(_accessLog.AccessLogGridView).Displayed.Should().BeTrue(); 
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

    }
}

