using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MedchartSeleniumAutomationCore.Core_Framework
{
    public static class UIActions
    {
        //------------------------------------------------------------------------------------------------------------
        //                                                IMPORTANT!
        //------------------------------------------------------------------------------------------------------------
        //This Class is only for UI Actions and simple UI Validatuons such as entering text or clicking a control or 
        //making sure it appears on screen. Everything must be abstracted and not specific to any one object in Medchart
        //------------------------------------------------------------------------------------------------------------

        private static IWebElement element;
        private static SelectElement select;

        #region Select Elements
        /// <summary>
        /// Selects the index of a combobox or multivalue HTML object
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="index"></param>
        public static bool SelectElementByIndex(By locator, int index)
        {

            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 30);
                    select = new SelectElement(GetElement(locator));
                    select.SelectByIndex(index);
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;

        }

        /// <summary>
        /// Selects a specific value in the combo box or multivalue HTML object
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="value"></param>
        public static bool SelectElementByValue(By locator, string value)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 30);
                    select = new SelectElement(GetElement(locator));
                    select.SelectByValue(value);
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;
        }

        /// <summary>
        /// Selects the text elements of a Combobox or multivalue HTML object
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="visibletext"></param>
        public static bool SelectElementByText(By locator, string visibletext)
        {

            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 30);
                    select = new SelectElement(GetElement(locator));
                    select.SelectByText(visibletext);
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;

        }

        /// <summary>
        /// Gets the innerHTML for the characters remaining
        /// </summary>
        /// <param name="CharacterCounter"></param>
        public static string GetCharactersRemainingValue(By CharacterCounter)
        {
            element = GetElement(CharacterCounter);
            return element.GetAttribute("innerHTML");
        }

        public static string GetDropdownSelectedValue(By locator)
        {

            IWebElement comboBox = GetElement(locator);
            SelectElement selectedValue = new SelectElement(comboBox);
            return selectedValue.SelectedOption.Text;            

        }

        #endregion
        
        #region Get Methods

        /// <summary>
        /// IWebElement object version of GetElement
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static IWebElement GetElement(By locator)
        {
            WaitMethods.Wait(locator, 30);
            if (ObjectRepository.Driver.FindElement(locator).Displayed)
                return ObjectRepository.Driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

        public static IWebElement GetElements(By locator)
        {
            //WaitMethods.Wait(locator, 30);
            if (ObjectRepository.Driver.FindElements(locator).Count == 1)
                return ObjectRepository.Driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

        //public static string GetTextBoxTextValue(object lODSoldierContactInfoStreetAddressTextBox)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Gets a SelectElement object in Selenium.Support.UI, then feeds in a By locator, allowing method chaining on
        /// SelectElements
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static SelectElement GetSelectElement(By locator)
        {
            WaitMethods.Wait(locator, 30);
            if (ObjectRepository.Driver.FindElement(locator).Displayed)
                return new SelectElement(ObjectRepository.Driver.FindElement(locator));
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

        //public static string GetTextBoxTextValue(object lODSoldierContactInfoStateDropDown)
        //{
        //    throw new NotImplementedException();
        //}

        public static int GetNumberOfElements(By locator)
        {
            return ObjectRepository.Driver.FindElements(locator).Count;
        }


        public static IReadOnlyCollection<IWebElement> GetAllElements(By locator)
        {
            if (DoesAnyNumberOfElementExist(locator))
                return ObjectRepository.Driver.FindElements(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }


        /// <summary>
        /// Gets the text of a button and returns the value
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static string GetButtonText(By locator)
        {
            element = GetElement(locator);
            if (element.GetAttribute("value") == null)
                return String.Empty;
            return element.GetAttribute("value");
        }

        /// <summary>
        /// Gets the InnerText of a combobox and returns the value
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static string GetComboboxInnerText(By locator)
        {
            element = GetElement(locator);
            if (element.GetAttribute("value") == null)
                return String.Empty;
            return element.GetAttribute("value");
        }
        public static IWebElement GetParent(IWebElement e)
        {
            return e.FindElement(By.XPath(".."));
        }

        public static void MoveByOffset(IWebElement scrollbar, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public static bool IsElementPresent(By by)
        {
            try
            {
                ObjectRepository.Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        /// <summary>
        /// Gets all text within a object and returns it in a list
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }


        #endregion

        #region Scrolling and MoveTo Methods
        public static void ScrollTo(int xPosition = 0, int yPosition = 0)
        {
            var js = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
            executor.ExecuteScript(js);
        }

        public static IWebElement ScrollToView(By selector)
        {
            var element = UIActions.GetElement(selector);
            ScrollToView(element);
            return element;
        }

        public static void ScrollToView(IWebElement element)
        {
            if (element.Location.Y > 200)
            {
                ScrollTo(0, element.Location.Y - 100); // Make sure element is in the view but below the top navigation pane
            }

        }

        public static void JSScrollToView(By locator)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
            IWebElement element = GetElement(locator);
            executor.ExecuteScript("arguments[0].scrollIntoView();", element);
        }
        public static void JSMoveTo(By locator)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
            IWebElement element = GetElement(locator);
            executor.ExecuteScript("jQuery(\".optionSelector\").mouseover();");
        }

        /// <summary>
        /// Moves the focus and cursor to a specific element on the screen.
        /// Note: IE11 has some issues with Window Focus. Keep this in mind when debugging
        /// </summary>
        /// <param name="locator"></param>
        public static void MoveTo(By locator)
        {
            Actions action = new Actions(ObjectRepository.Driver);
            action.MoveToElement(GetElement(locator));
            action.Build();
            action.Perform();
        }
        public static void ClickAndDragByOffset(By locator, int offsetX, int offsetY)
        {
            Actions action = new Actions(ObjectRepository.Driver);
            action.MoveToElement(GetElement(locator));
            action.ClickAndHold();
            action.MoveByOffset(offsetX, offsetY);
            action.Release();
            action.Build();
            action.Perform();
        }

        public static void ClickAndDragByOffset(IWebElement element, int offsetX, int offsetY)
        {
            Actions action = new Actions(ObjectRepository.Driver);
            action.MoveToElement(element);
            action.ClickAndHold();
            action.MoveByOffset(offsetX, offsetY);
            action.Release();
            action.Build();
            action.Perform();
        }

        #endregion

        #region Click Methods


        ///// <summary>
        ///// Clicks on a web element
        ///// </summary>
        ///// <param name="locator"></param>
        public static bool ClickElement(By locator)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 60);
                    IWebElement element = ObjectRepository.Driver.FindElement(locator);
                    element.Click();
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;

        }
        /// <summary>
        /// Javascript Executor Click Element method. This method exeutes Javascript to mimic clicks on the screen.
        /// This is not a method that uses the Native Elements of Windows.
        /// </summary>
        /// <param name="locator"></param>
        public static bool JSClickElement(By locator)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 60);
                    IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
                    IWebElement element = GetElement(locator);
                    executor.ExecuteScript("arguments[0].click();", element);
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;
        }

        #endregion

        #region Text Box Methods

        /// <summary>
        /// Enters text in a textbox
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public static bool TypeInTextBox(By locator, string text)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 60);
                    IWebElement element = ObjectRepository.Driver.FindElement(locator);
                    element.SendKeys(text);
                    break;
                }
                catch (ElementNotInteractableException e)
                {
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;
        }

        public static void TypeInTextBoxAndEnter(By locator, string text)
        {
            WaitMethods.Wait(locator, 60);
            element = GetElement(locator);
            element.SendKeys(text);
            Thread.Sleep(300);
            element.SendKeys(Keys.Enter);
            //element.SendKeys(text + Keys.Enter);
            DebuggingHelpers.Log.Info($"Text Entered: {text.ToString()}");
        }


        /// <summary>
        /// Clears text in a textbox
        /// </summary>
        /// <param name="locator"></param>
        public static bool ClearTextBox(By locator)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 60);
                    IWebElement element = ObjectRepository.Driver.FindElement(locator);
                    element.Clear();
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                    
                }
                attempts++;
            }
            return result;
        }

        public static bool ClearTextBoxandEnter(By locator)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 60);
                    IWebElement element = ObjectRepository.Driver.FindElement(locator);
                    element.Clear();
                    element.SendKeys(Keys.Enter);
                    break;
                }
                catch (StaleElementReferenceException e)
                {

                }
                attempts++;
            }
            return result;
        }

        public static string GetTextBoxTextValue(By locator)
        {
            WaitMethods.Wait(locator, 60);
            element = GetElement(locator);
            if (element.GetAttribute("value") == null)
                return String.Empty;
            return element.GetAttribute("value");
        }


        /// <summary>
        /// Javascript Executor Click Element method. This method exeutes Javascript to mimic sendtext on the screen.
        /// This is not a method that uses the Native Elements of Windows.
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public static bool JSEnterText(By locator, string text)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    WaitMethods.Wait(locator, 60);
                    IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
                    IWebElement element = GetElement(locator);
                    executor.ExecuteScript("arguments[0].value=arguments[1];", element, text);
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;
        }

        #endregion

        #region Datepicker Methods

        public static string SelectDate(int numberOfDays)
        {
            return DateTime.Today.AddDays(numberOfDays).ToString("yyyMMdd");
        }

        public static void SetDateForDateTimePicker(By locator, int year, int month, int day)
        {
            var time = DateTime.Now;
            IWebElement dateTimePicker = GetElement(locator);

            var dateNextButton = dateTimePicker.FindElement(By.CssSelector("button[class='xdsoft_next']"));
            var datePrevButton = dateTimePicker.FindElement(By.CssSelector("button[class='xdsoft_prev']"));

            var yearButton = dateTimePicker.FindElement(By.CssSelector("div[class*='xdsoft_year']"));
            var monthButton = dateTimePicker.FindElement(By.CssSelector("div[class*='xdsoft_month']"));

            if (year != time.Year)
            {
                yearButton.Click();

                var yearScrollbar = yearButton.FindElement(By.CssSelector("div[class='xdsoft_scroller']"));
                var yearToSelect = yearButton.FindElement(By.CssSelector("div[data-value = '" + year + "']"));

                var differenceInYears = year - time.Year;

                if (differenceInYears != 0)
                {
                    ClickAndDragByOffset(yearScrollbar, 0, Convert.ToInt32(differenceInYears * yearToSelect.Size.Height * 0.0705));
                }

                yearToSelect.Click();
            }

            if (time.Month != month)
            {
                monthButton.Click();

                var monthScrollbar = monthButton.FindElement(By.CssSelector("div[class='xdsoft_scroller']"));
                var monthToSelect = monthButton.FindElement(By.CssSelector("div[data-value = '" + (month - 1).ToString() + "']"));

                if (!monthToSelect.IsDisplayed())
                {
                    if (month > 6)
                    {
                        ClickAndDragByOffset(monthScrollbar, 0, monthToSelect.Size.Height * 5);
                    }
                    else
                    {
                        ClickAndDragByOffset(monthScrollbar, 0, -monthToSelect.Size.Height * 5);
                    }
                }

                monthToSelect.Click();
            }

            var date = dateTimePicker.FindElement(By.CssSelector("td[data-year='" + year + "'][data-month='" + (month - 1).ToString() + "'][data-date='" + day + "']"));
            
            try
            {
                date.Click();
            }
            catch (ElementNotInteractableException)
            {
                throw new ElementNotInteractableException("Date was unable to be clicked on, or was disabled");
            }
        }

        #endregion

        #region ComboBox Methods
        /// <summary>
        /// [[DEPRECATED]]
        /// 
        /// Validates the combobox innertext with a expected value
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="ExpectedValue"></param>
        /// <returns></returns>
        public static bool ComboboxInnerTextValidator(By locator, List<string> expectedValues)
        {
            IWebElement elem = ObjectRepository.Driver.FindElement(locator);

            SelectElement selectList = new SelectElement(elem);
            IList<IWebElement> options = selectList.Options;

            foreach (IWebElement option in options)
            {
                if (expectedValues.Contains(option.Text))
                    continue;
                else
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Validates the options in a HTML Combobox and compares them to a defined list of expected values
        /// </summary>
        /// <param name="options"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        public static bool HTMLComboBoxOptionValidator(IList<IWebElement> options, List<object> expected, bool TrimElementText = false)
        {
            var dropdownHasAllValues = true;

            foreach (IWebElement element in options)
            {
                if (!expected.Contains(element.Text) && (TrimElementText && !expected.Any(s => s.ToString() == element.Text.Trim())))
                {
                    dropdownHasAllValues = false;
                    break;
                }
            }

            foreach (string text in expected)
            {
                if (!options.Any(o => o.Text == text || (TrimElementText && o.Text.Trim() == text)))
                {
                    dropdownHasAllValues = false;
                    break;
                }
            }

            return dropdownHasAllValues;
        }

        /// <summary>
        /// Validates whether or not the combobox contains the given expected value
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="ExpectedValue"></param>
        /// <returns></returns>
        public static bool ComboboxContainsValue(By locator, string expectedValue)
        {
            IWebElement elem = ObjectRepository.Driver.FindElement(locator);

            SelectElement selectList = new SelectElement(elem);
            IList<IWebElement> options = selectList.Options;

            foreach (IWebElement option in options)
            {
                if (expectedValue.Equals(option.Text))
                    return true;
                else
                    continue;
            }
            return false;
        }

        #endregion

        #region Misc Methods
        /// <summary>
        /// Sends command to browser to reestablish browser focus via Javascript
        /// </summary>
        /// <param name="locator"></param>
        public static void JSBrowserFocus(By locator)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)ObjectRepository.Driver;
            IWebElement element = GetElement(locator);
            executor.ExecuteScript("document.getElementById('" + element.GetAttribute("id") + "').focus()");
        }

        /// <summary>
        /// An extension to strip the single and double quotes for a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StripQuotes(this string input)
        {
            return input.Replace("'", "").Replace("\"", "");
        }

        public static string GetCurrentWindowHandle()
        {
            return ObjectRepository.Driver.CurrentWindowHandle;
        }
        public static IReadOnlyCollection<string> GetWindowHandles()
        {
            return ObjectRepository.Driver.WindowHandles;
        }

        /// <summary>
        /// Verifies that there is at least one version of the given element on the page
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static bool DoesAnyNumberOfElementExist(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count >= 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Used in workflow methods to check to see if the Next Action button is disabled
        /// Have to check the css values for the element
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static bool IsNextActionButtonDisabled(By locator)
        {
            Boolean result = false;
            int attempts = 0;
            while (attempts < 2)
            {
                try
                {
                    IWebElement element = ObjectRepository.Driver.FindElement(locator);
                    bool isDisabled = element.GetAttribute("disabled") != null;
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
                attempts++;
            }
            return result;

            //if disabled attribute found, the button is disabled            
        }

        public static bool DoMenuTabsExist(By locator)
        {
            IWebElement element = ObjectRepository.Driver.FindElement(locator);

            //if disabled attribute found, the button is disabled
            bool isDisabled = element.GetAttribute("disabled") != null;

            return isDisabled;

        }

        /// <summary>
        /// Verifies that element is selected i.e. a checkbox is checked etc
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static bool IsElementSelected(By locator)
        {
            element = UIActions.GetElement(locator);
            return element.Selected;
        }

        /// <summary>
        /// Verifies that element is Check i.e. a Radio button etc
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static bool IsElementChecked(By locator)
        {
            element = UIActions.GetElement(locator);
            return Convert.ToBoolean(Convert.ToInt32(element.GetAttribute("checked")));
        }


        /// <summary>
        /// Validates the characters remaining matches the number of charaters entered in the textbox
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="characterCounter"></param>
        /// <returns></returns>
        public static bool CharactersRemainingValidator(By locator, By characterCounter)
        {
            string initialCharacterCount = string.Empty;
            initialCharacterCount = UIActions.GetCharactersRemainingValue(characterCounter);
            UIActions.TypeInTextBox(locator, " Automation Team");
            string textBoxValue = string.Empty;
            textBoxValue = UIActions.GetTextBoxTextValue(locator);
            string counterSpan = string.Empty;
            counterSpan = UIActions.GetCharactersRemainingValue(characterCounter);
            string countText = (Int32.Parse(initialCharacterCount) - textBoxValue.Length).ToString();
            if (countText.Equals(counterSpan))
            {
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// Validates the combobox innertext with a expected value
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="ExpectedValue"></param>
        /// <returns></returns>
        public static bool ComboboxInnerTextValidator(By locator, string ExpectedValue)
        {
            element = UIActions.GetElement(locator);
            if (element.GetAttribute("value") == ExpectedValue)
                return true;
            else return false;

        }

        /// <summary>
        /// Verifies the element appears on the screen. This method accesses webelements using the IWebElement object
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool IsDisplayed(this IWebElement element)
        {
            bool result;
            try
            {
                result = element.Displayed;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public static bool IsStatusLabelCorrect(By locator, string expectedValue)
        {

            IWebElement elem = ObjectRepository.Driver.FindElement(locator);

            string statusLabel = elem.Text;
            //string x = elem.FindElement(By.XPath("//*[containts(@id,'MEDCHARTContent_EmmpsContent_CaseHeader1_CaseStatusLabel')]")).ToString();
            if (statusLabel == expectedValue)
                return true;
            else return false;
        }
        #endregion

    }

}
