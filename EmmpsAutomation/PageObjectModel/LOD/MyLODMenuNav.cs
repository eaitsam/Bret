using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using Microsoft.VisualStudio.TestTools.UITesting;
using Xunit;
//using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using MedchartSeleniumAutomationCore.Core_PageObjects;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class MyLODMenuNav
    {

        //--HyperLinks--//
        public By LODSoldierMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Soldier']");
        public By LODSoldierMenuLinkText => By.LinkText("Soldier");
        public By LODMedicalMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Medical']");
        public By LODMedicalMenuLinkButtonLinkText => By.LinkText("Medical");
        public By LODUnitMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Unit']");
        public By LODUnitMenuLinkButtonLinkText => By.LinkText("Unit");
        public By LODInvestigationMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Investigation']");
        public By LODInvestigationMenuLinkButtonLinkText => By.LinkText("Investigation");
        public By LODApptMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Appointment']");
        public By LODAptMenuLinkButtonLinkText => By.LinkText("Appointment");
        public By LODFormfindingsMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Form Findings']");
        public By LODFormfindingsMenuLinkButtonLinkText => By.LinkText("Form Findings");
        public By LODDocumentsMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Documents']");
        public By LODDocumentsMenuLinkButtonLinkText => By.LinkText("Documents");
        public By LODNextActionMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Next Action']");
        public By LODNextActionMenuLinkButtonLinkText => By.LinkText("Next Action");
        public By LODTrackingMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Tracking']");
        public By LODAdminMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Admin']");
        public By LODAdminMenuLinkButtonLinkText => By.LinkText("Admin");
        public By LODAdminMenuLinkButtonFromDocs => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODAdminMenuLinkButton");
        public By LODsEligibleForAppeals => By.Name("LODs Eligible For Appeals");
        public By MyLODsHeader => By.Name("My LODs");


        public By MMSOFollowupCareMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Follow-Up Care']");
        public By MMSOFollowupCareMenuLinkButtonLinkText => By.LinkText("Follow-Up Care");

        //--Labels--//
        public By LODServiceMemberLabel => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ServiceMemberLabel");
        public By LODCaseStatusLabel => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_CaseStatusLabel");

    }
}