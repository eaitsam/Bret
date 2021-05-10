using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMPAutomation.PageObjectModel
{
    public class UserInfoPage
    {
        private By UserInfo => By.Id("Edipin");
        


        public void EnterEdiAndSubmit(string edipin)
        {
            UIActions.TypeInTextBoxAndEnter(EdipinTextBox, edipin);
        }
    }
}
