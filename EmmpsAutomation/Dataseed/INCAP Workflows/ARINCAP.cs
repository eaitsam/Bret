using EmmpsAutomation.PageObjectModel.EmmpsContent_Shared_Objects;
using EmmpsAutomation.PageObjectModel.INCAP;
using EmmpsAutomation.PageObjectModel.LOD;
using EmmpsAutomation.Tests.INCAP;
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
    public class ARINCAP
    {

        //Test Script 55069

        #region Page Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//



        #endregion

        string fileName = "ARINCAP.xlsx";
        private string currentId = string.Empty;

        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly StartNewLODPage startNewLOD;
        readonly NavMenuObjects navMenu;
        readonly EMMPSCaseMenuNav INCAPnav;
        readonly LODDocuments docs;
        readonly MyIncapDocs incapDocs;
        readonly MiscPageOjects misc;
        //readonly MyINCAPPage _myINCAP;
        readonly EmmpsSearchObjects _search;
        readonly StartIncapPage _startNewINCAP;
        readonly MyIncapSoldierPage _soldier;
        readonly MyIncapFinances _finance;
        readonly MyIncapNextActionPage _next;


        public ARINCAP()
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
           // _myINCAP = new MyINCAPPage();
            _startNewINCAP = new StartIncapPage();
            _soldier = new MyIncapSoldierPage();
            _finance = new MyIncapFinances();
            _next = new MyIncapNextActionPage();
        }


        [Fact]
        public void ARINCAPStartINCAP()
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
        public void ARINCAPUnitCommander()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\INCAP\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartINCAP(ExcelUtil.ReadData(i, "StartINCAPPin"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
            }


        }

        [Fact]
        public void ARINCAPDivRAdmin()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\INCAP\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartINCAP(ExcelUtil.ReadData(i, "StartINCAPPin"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
                DivRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"));
            }


        }

        [Fact]
        public void ARINCAPDivRApproval()
        {
            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\INCAP\" + fileName)));
            int b = ExcelUtil.GetTotalRowCount();

            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
            {
                currentId = ExcelUtil.ReadData(i, "Id");
                StartINCAP(ExcelUtil.ReadData(i, "StartINCAPPin"));
                UnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
                DivRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"));
                DivRApproval(ExcelUtil.ReadData(i, "DivRApprovalPin"));
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
                UIActions.JSEnterText(_startNewINCAP.IncapSearchCases, "059");
                UIActions.JSClickElement(_startNewINCAP.IncapSearchButton);
                //sort to get the a recent case
                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);  
                UIActions.JSClickElement(_search.INCAPFilterResultsRow0CaseIDLink);

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
                //UIActions.JSClickElement(_myINCAP.INCAPCalculatorTabButton);
                UIActions.JSClickElement(INCAPnav.INCAPCalcMenuLinktext);

                //Documents Tab 
                UIActions.JSClickElement(INCAPnav.LODDocumentsMenuLinkButtonLinkText);


                docs.ClickUploadDcoumentLink(incapDocs.DAForm7574, "UploadButton");
                Thread.Sleep(500);
                docs.UploadFile("DAForm7574", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(incapDocs.DAForm7574PhysicianStatement, "UploadButton");
                Thread.Sleep(500);
                docs.UploadFile("Physicians Statement", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(incapDocs.DAForm7574SoldierAcknowledge, "UploadButton");
                Thread.Sleep(500);
                docs.UploadFile("Soldier Acknowledgement", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(incapDocs.IRBMeetingMinutes, "UploadButton");
                Thread.Sleep(500);
                docs.UploadFile("Meeting Minutes", docs.TESTFILE);
                Thread.Sleep(500);

                docs.ClickUploadDcoumentLink(incapDocs.DAForm3349, "UploadButton");
                Thread.Sleep(500);
                docs.UploadFile("DA Form 3349", docs.TESTFILE);
                Thread.Sleep(500);


                //NextAction Tab
                UIActions.JSClickElement(INCAPnav.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(_next.INCAPNextActionComboBox, "Forward To Unit Commander INCAP Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

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

        public void UnitCommander(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.INCAPMenuLink, navMenu.MyINCAPMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                //UIActions.JSClickElement(INCAPnav.MyINCAPPageLink);
                UIActions.SelectElementByText(_search.DropDownListStatus, "Unit Commander INCAP Review (AR)");
                UIActions.SelectElementByText(_search.DropDownListWorkflow, "AR INCAP");
                UIActions.JSClickElement(_search.ButtonFilterMyIncaps);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.INCAPSelectFirstCase);


                UIActions.JSClickElement(INCAPnav.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(_next.INCAPNextActionComboBox, "Forward To DIV(R) INCAP Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);


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

        public void DivRAdmin(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.INCAPMenuLink, navMenu.MyINCAPMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(_search.DropDownListStatus, "DIV(R) INCAP Review (AR)");
                UIActions.SelectElementByText(_search.DropDownListWorkflow, "AR INCAP");
                UIActions.JSClickElement(_search.ButtonFilterMyIncaps);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.MyINCAPFilterResultsRow0CaseIDLink);


                UIActions.JSClickElement(INCAPnav.LODNextActionMenuLinkButtonLinkText);
                UIActions.SelectElementByText(_next.INCAPNextActionComboBox, "Forward To DIV(R) Approval INCAP Review");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);


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

        public void DivRApproval(string edipin)
        {
            try
            {
                driverInit.InitWebdriver();
                login.LoginMethod(edipin);
                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.INCAPMenuLink, navMenu.MyINCAPMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(_search.DropDownListStatus, "DIV(R) Approval INCAP Review (AR)");
                UIActions.SelectElementByText(_search.DropDownListWorkflow, "AR INCAP");
                UIActions.JSClickElement(_search.ButtonFilterMyIncaps);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.INCAPFilterCasebyDate);
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 30);

                UIActions.JSClickElement(_search.MyINCAPFilterResultsRow0CaseIDLink);

                UIActions.JSClickElement(INCAPnav.LODNextActionMenuLinkButtonLinkText);
                UIActions.JSClickElement(_next.INCAPApproveButton);
                UIActions.SelectElementByText(_next.INCAPNextActionComboBox, "Approve INCAP Period");
                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

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
