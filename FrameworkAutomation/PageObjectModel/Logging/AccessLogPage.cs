using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using MedchartSeleniumAutomationCore.Core_Framework;

namespace FrameworkAutomation.PageObjectModel
{
    public class AccessLogPage
    {
        #region Page Objects

        #region By Elements
        public By PageDecriptionLabel => By.Id("PageDescription");
        public By OrganizationDropdown => By.Id("MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList");
        public By DateFromTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_DateFromTextBox");
        public By DateToTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_DateToTextBox");
        public By FirstNameTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserFirstName");
        public By LastNameTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserLastName");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_SearchButton");
        public By ResetButton => By.Id("MEDCHARTContent_MedchartPagesContent_ResetButton");
        public By PaginationDropdown => By.Id("MEDCHARTContent_MedchartPagesContent_ucRowCount_ddlPageRows");
        public By AccessLogGridView => By.Id("MEDCHARTContent_MedchartPagesContent_LoginsLogListGridView");

        #endregion
        #region String/List Elements//*[@id="PageDescription"]

        public string PageDescription => "This page displays the history of user access to the MEDCHART system. It includes the date and time the system was accessed by the user, the name of the user, the user's EDIPI, the user's internet browser version, and the server IP. Please use the filters to reduce the results of your inquiry as needed. Click Reset to enter new search conditions.";
        public string AuditLogPageDescription => "The audit log below shows detailed information pertaining to certain actions that have occurred in the MEDCHART application. Column headers can be used to sort the list, and filter values can be used to narrow your search (both functionalities can be used simultaneously). Please click on an item to view the associated details.";
        public List<object> OrganizationDropdownExpectedValues => new List<object> { "National Guard", "Army Reserve", "Contractors", "Cross-Component", "DEMOB/WTU Cross-Component" };
        public List<object> PageDropdownExpectedValues => new List<object> { "25", "50", "100" };

        #endregion

        #endregion

        #region Page Methods

        public IWebElement GetColumnByName(string columnName)
        {
            var gridView = UIActions.GetElement(AccessLogGridView);
            var columnList = gridView.FindElements(By.CssSelector("th[scope='col']"));

            return columnList.FirstOrDefault(e => e.FindElement(By.TagName("a")).Text == columnName).FindElement(By.TagName("a"));
        }

        public IWebElement GetPaginationByNumber(int pageNumber)
        {
            var gridView = UIActions.GetElement(AccessLogGridView);
            var pageNumberElement = gridView.FindElement(By.CssSelector("a[href*='Page$" + pageNumber.ToString() + "']"));

            return pageNumberElement;
        }

        public bool CheckAllPageDropdownValues(IList<IWebElement> options, List<object> expected)
        {
            var dropdownHasAllValues = true;

            foreach (IWebElement element in options)
            {
                if (!PageDropdownExpectedValues.Contains(element.Text))
                {
                    dropdownHasAllValues = false;
                }
            }

            foreach (string text in expected)
            {
                if (!options.Any(o => o.Text == text))
                {
                    dropdownHasAllValues = false;
                }
            }

            return dropdownHasAllValues;
        }

        public bool CheckAllOrganizationDropdownValues(IList<IWebElement> options)
        {
            var dropdownHasAllValues = true;

            foreach (IWebElement element in options)
            {
                if (!OrganizationDropdownExpectedValues.Contains(element.Text))
                {
                    dropdownHasAllValues = false;
                }
            }

            foreach (string text in OrganizationDropdownExpectedValues)
            {
                if (!options.Any(o => o.Text == text))
                {
                    dropdownHasAllValues = false;
                }
            }

            return dropdownHasAllValues;
        }

        #endregion
    }
}
