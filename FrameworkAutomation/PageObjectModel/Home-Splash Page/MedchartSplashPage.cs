
using AutoIt;
using OpenQA.Selenium;
using System;
using System.Threading;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;

namespace FrameworkAutomation.PageObjectModel
{
    public class MedchartSplashPage
    {
        #region Page Objects

        //Note: The objects for logging into Medchart have been removed from this page and added to the MedchartSeleniumAutomationCore project
        //      because they are too integral to the medchart testing project to not be under the Automation framework's purview. 
        
        
        public By ContactUsLink => By.Id("ContactUs");
        public By UserAgreementAcceptButton => By.ClassName("acceptButton");
        public By UserAgreement => By.PartialLinkText("User Agreement");
        public By AboutHyperlink => By.Id("AboutHyperLink");
        public By MebPrepLink => By.LinkText("MEB Prep");
        public By CBTLink => By.LinkText("CBT");
        public By UserAgreementDiv => By.Id("agreement");
        public By MedchartLogo => By.Id("medchartLogoLarge");
        #endregion





    }
}
