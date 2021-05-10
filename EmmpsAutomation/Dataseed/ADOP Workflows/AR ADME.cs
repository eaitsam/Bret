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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.Dataseed.ADOP_Workflows
{
    public class AR_ADME
    {
        readonly string fileName = "AR ADME.xlsx";

        readonly BaseDriverInit driverInit;
        readonly Login login;
        readonly NavMenuObjects navMenu;
        readonly StartNewAdopPage startNewADOP;
        readonly MiscPageOjects misc;
        readonly AdopNav adopNav;
        public By CaseStatusLabel = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_CaseStatusLabel");

        public AR_ADME()
        {
            driverInit = new BaseDriverInit();
            login = new Login();
            navMenu = new NavMenuObjects();
            misc = new MiscPageOjects();
            startNewADOP = new StartNewAdopPage();
            adopNav = new AdopNav();
        }

        //[Fact]
        //public void AR_ADMEStartADOP()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartADOP(ExcelUtil.ReadData(i, "UnitAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //    }
        //}

        //[Fact]
        //public void AR_ADMEDIVRAdmin()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartADOP(ExcelUtil.ReadData(i, "UnitAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //        DIVRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //    }
        //}

        //[Fact]
        //public void AR_ADMEUSARCMedicalReviewer()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartADOP(ExcelUtil.ReadData(i, "UnitAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //        DIVRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //        USARCMedicalReviewer(ExcelUtil.ReadData(i, "USARCMedicalReviewerPin"), ExcelUtil.ReadData(i, "Id"));

        //    }
        //}

        //[Fact]
        //public void AR_ADMEOTSGApproval()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartADOP(ExcelUtil.ReadData(i, "UnitAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //        DIVRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //        USARCMedicalReviewer(ExcelUtil.ReadData(i, "USARCMedicalReviewerPin"), ExcelUtil.ReadData(i, "Id"));
        //        OTSGApproval(ExcelUtil.ReadData(i, "OTSGApprovalPin"), ExcelUtil.ReadData(i, "Id"));

        //    }
        //}


        //[Fact]
        //public void AR_ADMENGBReviewer()
        //{
        //    ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\ADOP\" + fileName)));

        //    for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
        //    {
        //        StartADOP(ExcelUtil.ReadData(i, "UnitAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //        DIVRAdmin(ExcelUtil.ReadData(i, "DivRAdminPin"), ExcelUtil.ReadData(i, "Id"));
        //        USARCMedicalReviewer(ExcelUtil.ReadData(i, "USARCMedicalReviewerPin"), ExcelUtil.ReadData(i, "Id"));
        //        OTSGApproval(ExcelUtil.ReadData(i, "OTSGApprovalPin"), ExcelUtil.ReadData(i, "Id"));
        //        NGBReviewer(ExcelUtil.ReadData(i, "NGBReviewerPin"), ExcelUtil.ReadData(i, "Id"));

        //    }
        //}

        //public void StartADOP(string edipin, string id)
        //{
        //    try
        //    {
        //        driverInit.InitWebdriver();
        //        login.LoginMethod(edipin);
        //        List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.ADOPMenuLink, navMenu.MyADOPMenuLink, navMenu.StartNewADOPMenuLink };
        //        MasterMenuNavigation.StartTabSelectionMethod(tabs);

        //        WaitMethods.Wait(startNewADOP.SsnBox, 60);
        //        startNewADOP.SoldierSSNSearch(id);

        //        UIActions.SelectElementByText(startNewADOP.WorkflowDropDownBox, "AR ADME");
        //        WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);



        //        UIActions.JSClickElement(adopNav.ADOPForm4LinkButton);
        //    }
        //    finally
        //    {
        //        driverInit.TearDown();
        //    }

        //}

        public void DIVRAdmin(string edipin, string id)
        {
            try
            {

            }
            finally
            {
                driverInit.TearDown();
            }

        }

        public void USARCMedicalReviewer(string edipin, string id)
        {
            try
            {

            }
            finally
            {
                driverInit.TearDown();
            }

        }

        public void OTSGApproval(string edipin, string id)
        {
            try
            {

            }
            finally
            {
                driverInit.TearDown();
            }

        }

        public void NGBReviewer(string edipin, string id)
        {
            try
            {

            }
            finally
            {
                driverInit.TearDown();
            }

        }

    }
}
