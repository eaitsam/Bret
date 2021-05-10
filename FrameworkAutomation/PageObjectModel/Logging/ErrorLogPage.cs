using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using MedchartSeleniumAutomationCore.Core_Framework;
using FluentAssertions;
using OpenQA.Selenium.Support.UI;
using MedchartSeleniumAutomationCore.Core_Settings;
using System;

namespace FrameworkAutomation.PageObjectModel
{
    public class ErrorLogPage
    {
        #region Page Objects

        #region By Elements
        public By PageDecriptionLabel => By.Id("PageDescription");
        public By ModuleDropdown => By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDropDownList");
        public By UserFirstNameTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserFirstName");
        public By UserLastNameTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserLastName");
        public By DateFromTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_DateFromTextBox");
        public By DateToTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_DateToTextBox");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_SearchButton");
        public By ResetButton => By.Id("MEDCHARTContent_MedchartPagesContent_ResetButton");
        public By ErrorGrid => By.Id("MEDCHARTContent_MedchartPagesContent_ErrorLogListGridView");
        public By PaginationDropdown => By.Id("MEDCHARTContent_MedchartPagesContent_ucRowCount_ddlPageRows");
        public By ErrorDialog => By.Id("ErrorDialog");
        public By FromDateDatePicker => By.CssSelector("div[id='FromDatePicker'][style*='display: block']");
        public By ToDateDatePicker => By.CssSelector("div[class*='xdsoft_datetimepicker'][style*='display: block']");
        #endregion
        #region String/List Elements

        public string PageDescription => "Below are all of the Error Events that have occurred within the system. Please use the filters to isolate a range of Events.";
        public List<object> ModuleDropdownExpectedValues => new List<object> { "- All modules -", "Framework", "eCase", "OccHealth", "DenClass", "MRR", "MATS", "MATS-ACRC", "HRR", "eMMPS", "AVS", "OHR" };
        public List<object> PageDropdownExpectedValues => new List<object> { "25", "50", "100" };
        public List<object> ErrorDialogExpectedValues => new List<object> { "Error ID:", "Error Time:", "User:", "Page Name:", "Browser:", "Message:", "Stack Trace:", "Caller:" };
        #endregion

        #endregion

        #region Page Methods

        public IWebElement GetColumnByName(string columnName)
        {
            var gridView = UIActions.GetElement(ErrorGrid);
            CustomWait(UIActions.GetElement(By.CssSelector("th[scope='col']")), By.TagName("a"));

            var columnList = gridView.FindElements(By.CssSelector("th[scope='col']"));

            return columnList.FirstOrDefault(e => e.FindElement(By.TagName("a")).Text == columnName).FindElement(By.TagName("a"));
        }

        public IWebElement GetPaginationByNumber(int pageNumber)
        {
            var gridView = UIActions.GetElement(ErrorGrid);
            var pageNumberElement = gridView.FindElement(By.CssSelector("a[href*='Page$" + pageNumber.ToString() + "']"));

            return pageNumberElement;
        }

        public void ClickSelectLinkByRowId(int rowNumber)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(15))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50),
            };

            wait.Until(driver =>
            {
                try
                {
                    var gridView = UIActions.GetElement(ErrorGrid);
                    var rowList = gridView.FindElements(By.TagName("tr"));

                    //Because there is a header row, the row number has a starting index of 1
                    var row = rowList[rowNumber];

                    row.FindElement(By.TagName("a")).Click();
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }

        public List<object> GetShownErrorDialogColumnValues()
        {
            var ListToReturn = new List<object>();
            var errorDialog = UIActions.GetElement(ErrorDialog);
            var rowList = errorDialog.FindElements(By.TagName("tr"));

            foreach (IWebElement webElement in rowList)
            {
                ListToReturn.Add(webElement.FindElements(By.TagName("td"))[0].Text);
            }

            return ListToReturn;
        }

        public void CloseErrorDialog()
        {
            var errorDialog = UIActions.GetElement(ErrorDialog).FindElement(By.XPath("./.."));
            errorDialog.FindElement(By.TagName("button")).Click();
        }

        public void CustomWait(IWebElement element, By locator)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50),
            };
            
            wait.Until(driver =>
            {
                try
                {
                    var elementToBeDisplayed = element.FindElement(locator);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }

        public void CustomWaitSelectByText(By locator, string text)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(15))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50),
            };

            wait.Until(driver =>
            {
                try
                {
                    var selectElement = new SelectElement(UIActions.GetElement(locator));
                    selectElement.SelectByText(text);
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }

        public void CustomWaitClick(By locator)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(15))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50),
            };

            wait.Until(driver =>
            {
                try
                {
                    var selectElement = UIActions.GetElement(locator);
                    selectElement.Click();
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }
        #endregion
    }
}
