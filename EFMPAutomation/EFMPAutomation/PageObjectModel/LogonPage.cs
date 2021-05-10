using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMPAutomation.PageObjectModel
{
    public class LogonPage
    {
        private By EdipinTextBox => By.Id("Edipin");
        private By LogInButton => By.Name("button");


        public void EnterEdiAndSubmit(string edipin)
        {
            UIActions.TypeInTextBoxAndEnter(EdipinTextBox, edipin);
        }
    }
}
