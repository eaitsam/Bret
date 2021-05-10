using EmmpsAutomation.PageObjectModel.ADOP;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using MedchartSeleniumAutomationCore.Core_Tools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace EmmpsAutomation.Dataseed.ADOP_Workflows
{
    public class ARSRU
    {
        //Test Script 67535

        readonly string fileName = "ARSRU.xlsx";

        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly NavMenuObjects navMenu;
        readonly StartNewAdopPage startNewADOP;
        readonly MiscPageOjects misc;
        public By CaseStatusLabel = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_CaseStatusLabel");

        public ARSRU()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            startNewADOP = new StartNewAdopPage();
        }

        //[Fact]
        //public void ArSruStartAdopUnitCommander()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartAdopUnitCommander(ExcelUtil.ReadData(i, "UnitCommanderPin"));
        //    }
        //}

        //[Fact]
        //public void ArSruStartAdopUnitAdmin()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartAdopUnitAdmin(ExcelUtil.ReadData(i, "UnitAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //    }
        //}

        //[Fact]
        //public void ArSruStartAdopOtsgApproval()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartAdopOtsgApproval(ExcelUtil.ReadData(i, "OtsgApprovalPin"), ExcelUtil.ReadData(i, "Id"));
        //    }
        //}

        //[Fact]
        //public void ArSruStartAdopUsarManager()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartAdopUsarManager(ExcelUtil.ReadData(i, "UsarManagerPin"), ExcelUtil.ReadData(i, "Id"));
        //    }
        //}

        //[Fact]
        //public void ArSruStartAdopUsarcG1Admin()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartAdopUsarcG1Admin(ExcelUtil.ReadData(i, "UsarcG1AdminPin"), ExcelUtil.ReadData(i, "Id"));
        //    }
        //}

        //public void StartAdopUnitCommander(string edipin)
        //{
        //    try
        //    {
        //        driverInit.InitWebdriver();
        //        login.LoginMethod(edipin);
        //        List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.ADOPMenuLink, navMenu.MyADOPMenuLink, navMenu.StartNewADOPMenuLink };
        //    }

        //    finally
        //    {
        //        driverInit.TearDown();
        //    }

        //}

        //public void StartAdopUnitAdmin(string edipin, string id)
        //{
        //    try
        //    {
        //        driverInit.InitWebdriver();
        //        login.LoginMethod(edipin);
        //        List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.ADOPMenuLink, navMenu.MyADOPMenuLink, navMenu.StartNewADOPMenuLink };
        //        MasterMenuNavigation.StartTabSelectionMethod(tabs);

        //        WaitMethods.Wait(startNewADOP.SsnBox, 60);
        //        startNewADOP.SoldierSSNSearch(id);
        //        UIActions.SelectElementByText(startNewADOP.WorkflowDropDownBox, "AR SRU");
        //        WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
        //        UIActions.SelectElementByText(startNewADOP.SruDutyStatus, "No Orders");
        //        WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
        //        UIActions.JSClickElement(startNewADOP.StartOverDodiADOPButton);

        //        StartAdop(id);
        //        Assert.Contains("ADOP USAR Draft (AR)", UIActions.GetElement(CaseStatusLabel).Text);
        //    }

        //    finally
        //    {
        //        driverInit.TearDown();
        //    }
        //}

        //public void StartAdopOtsgApproval(string edipin, string id)
        //{
        //    try
        //    {
        //        driverInit.InitWebdriver();
        //        login.LoginMethod(edipin);

        //        UIActions.GetElement(misc.MyAccountLink).Click();
        //        startNewADOP.VerifyCreateAdopAndSruDraftPermission();

        //        StartAdop(id);
        //        Assert.Contains("ADOP SRU Draft (AR)", UIActions.GetElement(CaseStatusLabel).Text);
        //    }

        //    finally
        //    {
        //        driverInit.TearDown();
        //    }
        //}

        //public void StartAdopUsarManager(string edipin, string id)
        //{
        //    try
        //    {
        //        driverInit.InitWebdriver();
        //        login.LoginMethod(edipin);

        //        UIActions.GetElement(misc.MyAccountLink).Click();
        //        startNewADOP.VerifyUsarDraftAndSruDraftPermission();

        //        StartAdop(id);
        //        Assert.Contains("ADOP USAR Draft (AR)", UIActions.GetElement(CaseStatusLabel).Text);
        //    }

        //    finally
        //    {
        //        driverInit.TearDown();
        //    }
        //}

        //public void StartAdopUsarcG1Admin(string edipin, string id)
        //{
        //    try
        //    {
        //        driverInit.InitWebdriver();
        //        login.LoginMethod(edipin);

        //        UIActions.GetElement(misc.MyAccountLink).Click();
        //        startNewADOP.VerifySruDraftAndNotUsarDraftPermission();

        //        StartAdop(id);
        //        Assert.Contains("ADOP SRU Draft (AR)", UIActions.GetElement(CaseStatusLabel).Text);
        //    }

        //    finally
        //    {
        //        driverInit.TearDown();
        //    }
        //}

        //public void StartAdop(string id)
        //{
        //    List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.ADOPMenuLink, navMenu.MyADOPMenuLink, navMenu.StartNewADOPMenuLink };
        //    MasterMenuNavigation.StartTabSelectionMethod(tabs);

        //    WaitMethods.Wait(startNewADOP.SsnBox, 60);
        //    startNewADOP.SoldierSSNSearch(id);
        //    UIActions.SelectElementByText(startNewADOP.WorkflowDropDownBox, "AR SRU");
        //    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
        //    UIActions.SelectElementByText(startNewADOP.SruDutyStatus, "ADT");
        //    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
        //    startNewADOP.EnterUIC("1234567");
        //    startNewADOP.EnterUIC("W8B1Z9");
        //    UIActions.SelectElementByText(startNewADOP.Region, "63rd DIV(R)");
        //    UIActions.SelectElementByIndex(startNewADOP.Rank, 0);
        //    UIActions.JSClickElement(startNewADOP.CreateADOPButton);
        //    UIActions.SelectElementByText(startNewADOP.Rank, "Private (PV1)");
        //    UIActions.JSClickElement(startNewADOP.CreateADOPButton);
        //}
    }
}
