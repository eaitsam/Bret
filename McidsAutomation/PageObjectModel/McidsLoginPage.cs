using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace McidsAutomation.PageObjectModel
{
    public static class McidsLoginPage
    {
        #region Page Objects

        #region By Elements

        private static By EdipinTextBox => By.Id("Edipin");
        private static By LogInButton => By.Name("button");

        #endregion By Elements

        #endregion Page Objects

        #region Page Methods

        public static void EnterEdiAndSubmit(string edipin)
        {
            UIActions.TypeInTextBoxAndEnter(EdipinTextBox, edipin);
        }

        #endregion Page Methods
    }
}