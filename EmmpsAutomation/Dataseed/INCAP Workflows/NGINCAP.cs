using EmmpsAutomation.PageObjectModel.EmmpsContent_Shared_Objects;
using EmmpsAutomation.PageObjectModel.INCAP;
using EmmpsAutomation.PageObjectModel.LOD;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using MedchartSeleniumAutomationCore.Core_Tools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Xunit;

namespace EMMPSDataseed.Workflows.INCAP
{
    public class NGINCAP
    {
        //Test Script 55069

        string fileName = "NGINCAP.xlsx";
        private string currentId = string.Empty;

        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly StartNewLODPage startNewLOD;
        readonly NavMenuObjects navMenu;
        readonly EMMPSCaseMenuNav INCAPnav;
        readonly LODDocuments docs;
        readonly MyIncapDocs incapDocs;
        readonly MiscPageOjects misc;
        readonly MyINCAPPage _myINCAP;
        readonly EmmpsSearchObjects _search;
        readonly StartIncapPage _startNewINCAP;
        readonly MyIncapSoldierPage _soldier;
        readonly MyIncapFinances _finance;
        readonly MyIncapNextActionPage _next;


        public NGINCAP()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            INCAPnav = new EMMPSCaseMenuNav();
            startNewLOD = new StartNewLODPage();
            _search = new EmmpsSearchObjects();
            incapDocs = new MyIncapDocs();
            docs = new LODDocuments();
            _myINCAP = new MyINCAPPage();
            _startNewINCAP = new StartIncapPage();
            _soldier = new MyIncapSoldierPage();
            _finance = new MyIncapFinances();
            _next = new MyIncapNextActionPage();
        }




        [Fact]
        public void NGINCAPStartINCAP()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\INCAP\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartINCAP(ExcelUtil.ReadData(i, "StartINCAPPin"));
            }


        }


        [Fact]
        public void NGINCAPStateApproval()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\INCAP\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartINCAP(ExcelUtil.ReadData(i, "StartINCAPPin"));
                StateApproval(ExcelUtil.ReadData(i, "StateApprovalPin"));
            }


        }


        public void StartINCAP(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.INCAPMenuLink, navMenu.MyINCAPMenuLink, navMenu.StartINCAPMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                Thread.Sleep(200);
                UIActions.JSEnterText(_startNewINCAP.IncapSearchCases, "VA");
                UIActions.JSClickElement(_startNewINCAP.IncapSearchButton);
                //sort to get the a recent case
                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);
                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                //Soldier Tab
                UIActions.JSClickElement(INCAPnav.LODSoldierMenuLinkText);

                string pebd = UIActions.GetTextBoxTextValue(_soldier.INCAPSoldierPEBDTextbox);

                if (String.IsNullOrEmpty(pebd))
                {
                    UIActions.TypeInTextBox(_soldier.INCAPSoldierPEBDTextbox, "20050101");
                }

                //Finances Tab
                UIActions.JSClickElement(INCAPnav.INCAPFinancesMenuLinkText);

                UIActions.JSEnterText(_finance.INCAPFinancesNewPeriodStartDateTextbox, DateTime.Now.ToString("yyyyMMdd"));
                UIActions.JSEnterText(_finance.INCAPFinancesNewPeriodEndDateTextbox, DateTime.Now.AddDays(60).ToString("yyyyMMdd"));
                UIActions.JSClickElement(_finance.INCAPFinancesAddNewPeriodButton);

                //Calculator link button.  Pops up after add Period
                UIActions.JSClickElement(INCAPnav.INCAPCalcMenuLink);

                //Documents Tab 
                UIActions.JSClickElement(INCAPnav.LODDocumentsMenuLinkButtonLinkText);
                Thread.Sleep(1000);

                var locator = docs.CreateDivLocatorByTitle("DA Form 7574 - Incapacitation Pay Monthly Claim Form");
                docs.ClickUploadDcoumentLink(locator, "UploadButton");
                docs.UploadFile("DA Form 7574", docs.TESTFILE);

                var locator1 = docs.CreateDivLocatorByTitle("DA Form 7574-1 - Physicians Statement of Soldiers Incapacitation/Fitness for Duty");
                docs.ClickUploadDcoumentLink(locator1, "UploadButton");
                docs.UploadFile("DA Form 7574-1", docs.TESTFILE);

                var locator2 = docs.CreateDivLocatorByTitle("DA Form 7574-2 - Soldiers Acknowledgement of Incapacitation Pay Counseling");
                docs.ClickUploadDcoumentLink(locator2, "UploadButton");
                docs.UploadFile("DA Form 7574-2", docs.TESTFILE);

                var locator3 = docs.CreateDivLocatorByTitle("IRB Meeting Minutes");
                docs.ClickUploadDcoumentLink(locator3, "UploadButton");
                docs.UploadFile("IRB Meeting Minutes", docs.TESTFILE);

                var locator4 = docs.CreateDivLocatorByTitle("DA Form 3349 - Medical Profile");
                docs.ClickUploadDcoumentLink(locator4, "UploadButton");
                docs.UploadFile("DA Form 3349", docs.TESTFILE);

                //NextAction Tab
                UIActions.JSClickElement(INCAPnav.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(_next.INCAPNextActionComboBox, "Forward To State Approval INCAP Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                if (UIActions.IsNextActionButtonDisabled(_next.INCAPNextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(_next.INCAPNextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

                }

            }

            finally
            {
                driverInit.TearDown();
            }


        }

        public void StateApproval(string edipin)
        {
            try
            {

                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.INCAPMenuLink, navMenu.MyINCAPMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.JSClickElement(INCAPnav.MyINCAPPageLink);
                UIActions.SelectElementByText(_search.DropDownListStatus, "State Approval INCAP Review (NG)");
                UIActions.SelectElementByText(_search.DropDownListWorkflow, "NG INCAP");
                UIActions.JSClickElement(_myINCAP.ButtonFilterMyIncaps);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.MyINCAPFilterResultsRow0CaseIDLink);

                UIActions.JSClickElement(INCAPnav.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(_next.INCAPNextActionComboBox, "Forward To NGB Rebuttal Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                if (UIActions.IsNextActionButtonDisabled(_next.INCAPNextActionSignButton))
                {
                    throw new NoSuchElementException("Next Action Button disabled.");
                }
                else
                {
                    UIActions.JSClickElement(_next.INCAPNextActionSignButton);
                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);
                }

            }

            finally
            {
                driverInit.TearDown();
            }
        }

    }
}
