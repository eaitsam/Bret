using EmmpsAutomation.PageObjectModel.ADOP;
using EmmpsAutomation.PageObjectModel.LOD;
using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.Tests.ADOP
{
    public class DocumentTab
    {
        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        AdopNav _adopNav;
        StartNewLODPage _startnewlod;
        SearchFilterObjects _searchFilter;
        MiscPageOjects _miscPageOjects;
        MyLODMenuNav _mylodMenuNav;
        AdopBoardPage _adopBoardPage;
        AdopOrdersPage _adopOrdersPage;
        AdopDocsPage _adopDocsPage;
        public DocumentTab()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _adopNav = new AdopNav();
            _startnewlod = new StartNewLODPage();
            _searchFilter = new SearchFilterObjects();
            _miscPageOjects = new MiscPageOjects();
            _mylodMenuNav = new MyLODMenuNav();
            _adopBoardPage = new AdopBoardPage();
            _adopOrdersPage = new AdopOrdersPage();
            _adopDocsPage = new AdopDocsPage();
        }


        [Fact]
        public void DocumentTabValidations()
        {
            //try
            //{
            //login
            _driverInit.InitWebdriver();
            _login.LoginMethod("8880077013");

            //Navigate to ADOP Menu
            List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.ADOPMenuLink, _navMenu.MyADOPMenuLink, _navMenu.StartNewADOPMenuLink, _navMenu.SearchADOPMenuLink };
            MasterMenuNavigation.StartTabSelectionMethod(tabs);


            //selects test case
            UIActions.SelectElementByText(_adopBoardPage.WorkflowDropdownBox, "(NG) NG CCU");
            UIActions.SelectElementByText(_adopBoardPage.StatusDropdownBox, "ADOP CCU Draft (NG)");
            UIActions.JSClickElement(_adopBoardPage.FilterButton);
            UIActions.JSClickElement(_adopBoardPage.TestCase3);

            UIActions.JSClickElement(_adopNav.ADOPDocumentsMenuLinkButton);

            //verify these are true
            UIActions.GetElement(_adopDocsPage.ADOPMedDocValidationMessage4).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopDocsPage.ADOPDutyStatusValidationMessage5).Displayed.Should().BeTrue();

            //UIActions.GetElements(_adopDocsPage.ADOPLODDocumentation.ADOPUploadButton).Displayed.Should().BeTrue();

            //DocumentUpload button
            //_adopDocsPage.ClickUploadDcoumentLink(_adopDocsPage.MedicalDocsCivMil, "UploadButton");
            Thread.Sleep(500);
           // _adopDocsPage.UploadFile("Medical Documents", _adopDocsPage.TESTFILE);
            Thread.Sleep(500);






        }


    }
}
