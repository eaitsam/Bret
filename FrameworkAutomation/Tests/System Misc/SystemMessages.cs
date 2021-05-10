using FrameworkAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.Tests.System_Misc
{
    public class SystemMessages
    {
        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        ManageMessagesPage _manageMessagesPage;
        public SystemMessages()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _manageMessagesPage = new ManageMessagesPage();
        }

        [Fact]
        public void USARMRRSysMessagePriorMRTransformDate()
        {
            //try
            //{
                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");


            //navigate
            //List<By> tabs = new List<By> { _navMenu.EcaseMenuBarCss, _navMenu.EcaseReportsMenuLink, _navMenu.InsightsReportLink };
            //MasterMenuNavigation.StartTabSelectionMethod(tabs);







            //}
            //finally
            //{
            //    _driverInit.TearDown();
            //}
        }
        //# Test Scripts Covered:
        //#39782 http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=39782&_a=edit

        //		@MRR
        //		Scenario: System Message - MRR - Prior to MR Transformation Date - USAR
        //			Given I am Logged in as MRR USAR Manager using EDIPIN {edipin
        //}
        //And I have navigated to "Reports" tab in "By State Report"
        //	When I select a Load Date prior to "April 11, 2016" 
        //	Then a "USAR" MRR System Message should appear regarding "Medical Readiness Transformation"

        //@MRR
        //Scenario: System Message - MRR - Prior FY - USAR
        //	Given I am Logged in as MRR USAR Manager using EDIPIN {edipin}
        //	And I have navigated to "Trending Tool" tab in "Tools"
        //	When I select a Prior FY of "FY-2015"
        //	Then a "USAR" MRR System Message should appear regarding "Medical Readiness Transformation"

        //@MRR
        //Scenario: System Message - MRR - Prior to MR Transformation Date - ARNG
        //	Given I am Logged in as MRR USAR Manager using EDIPIN {edipin}
        //	And I have navigated to "MRO Dashboard" tab in "Dashboards"
        //	When I select a Load Date prior to "April 11, 2016" 
        //	Then a "ARNG" MRR System Message should appear regarding "Medical Readiness Transformation"


        //#Test Scripts Covered:
        //#39509

        //@Framework
        //Scenario: System Message - Framework - Check Messages
        //	Given I am Logged in as "Sys Admin" using EDIPIN 9990002200
        //	When There are at least 6 messages added to the Message Board
        //	Given I have navigated to "N/A" tab in "Home"
        //	Then The messages display correctly
    }
}
