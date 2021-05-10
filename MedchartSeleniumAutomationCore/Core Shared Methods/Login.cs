using AutoIt;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MedchartSeleniumAutomationCore.Core_Shared_Methods
{
    public class Login : IDisposable
    {


        // ------------------------
        // This is for CAC Logins
        //---------------------------
        private By CacTextBox = By.Name("txtEDIPIN");
        private By CACEdipinLoginButton = By.Id("btnGo");
        private By CACTermsButton = By.Id("CACPress");
        // ------------------------
        // This is for NON CAC Logins
        //---------------------------
        private By EdiTextbox = By.Id("EDIPINEntry");
        private By EdipinLoginButton = By.Id("lnkDevLogin");
        private By UserAgreementAcceptButton = By.ClassName("acceptButton");
        private By UserAgreement = By.PartialLinkText("User Agreement");

        public void LoginMethod(string edipin)
        {
            DebuggingHelpers.Log.Info("Logging In.");
            if (ObjectRepository.Driver.FindElements(CACTermsButton).Count == 1)
            {

                UIActions.GetElement(CACTermsButton).SendKeys(Keys.Enter);
                //DebuggingHelpers.Log.Info("Calling CancelSecurity DiaLogue");
                //CancelSecurityDiaLogue();
                //ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                ////DO OUT: Investigate the error that appears when you delete the thread.sleep
                //Thread.Sleep(50);
                //ObjectRepository.Driver.SwitchTo().DefaultContent();
                //UIActions.TypeInTextBox(CacTextBox, edipin);
                //UIActions.ClickElement(CACEdipinLoginButton);
                UIActions.GetElement(CacTextBox).Click();
                UIActions.GetElement(CacTextBox).SendKeys(edipin);
                UIActions.GetElement(CACEdipinLoginButton).SendKeys(Keys.Enter);
            }
            else
            {
                UIActions.GetElement(EdiTextbox).SendKeys(edipin);
                UIActions.GetElement(EdipinLoginButton).Click();
            }
            DebuggingHelpers.Log.Info("Logged in");
        }


        /// <summary>
        /// Uses AutoITX to cancel Windows Security Login Window that appears with CAC Logins
        /// </summary>
        private static void CancelSecurityDiaLogue()
        {
            DebuggingHelpers.Log.Info("If Exists: " + AutoItX.WinExists("Windows Security"));
            AutoItX.WinWait("Windows Security");
            if (AutoItX.WinExists("Windows Security") == 1)
            {
                AutoItX.WinActivate("Windows Security");
                AutoItX.WinWaitActive("Windows Security");
                AutoItX.Send("{TAB}");
                AutoItX.Send("{TAB}");
                AutoItX.Send("{TAB}");
                AutoItX.Send("{ENTER}");
            }
            DebuggingHelpers.Log.Info("After If Exists in CancelSecurityDiaLogue");
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}
