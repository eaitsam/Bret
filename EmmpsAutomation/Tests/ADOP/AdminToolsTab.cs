using EmmpsAutomation.PageObjectModel.ADOP;
using EmmpsAutomation.PageObjectModel.LOD;
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

namespace EmmpsAutomation.Tests.ADOP
{
   public class AdminToolsTab
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
        AdopAdminPage _adopAdminPage;
        AdminTools _adopAdminTools;
        public AdminToolsTab()
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
            _adopAdminPage = new AdopAdminPage();
            _adopAdminTools = new AdminTools();
        }

        [Fact]
        public void ADOPAdminToolsValidations()
        {
            //try
            //{
            //login
            _driverInit.InitWebdriver();
            _login.LoginMethod("8880070058");

            //Navigate to Admin Tools Menu
            List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.EMMPSAdminTools, _navMenu.AdminTools };
            MasterMenuNavigation.StartTabSelectionMethod(tabs);

            //selects test case
            UIActions.SelectElementByText(_adopBoardPage.WorkflowDropdownBox, "(NG) NG CCU");
            UIActions.SelectElementByText(_adopBoardPage.StatusDropdownBox, "ADOP CCU Draft (NG)");
            UIActions.JSClickElement(_adopBoardPage.FilterButton);
            UIActions.JSClickElement(_adopBoardPage.TestCase3);

            //clicks Order Tab
            UIActions.JSClickElement(_adopNav.ADOPOrdersMenuLinkButton);

            //Adop Override
            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopOverrideTextBox, "ADOP-TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopOverrideGoLinkButton);
            UIActions.SelectElementByText(_adopAdminTools.AdopOverrideDropDownList, "NGB ADOP Admin Review (NG)");
            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopOverrideTrackingTextBox, "It's a Trap");
            UIActions.JSClickElement(_adopAdminTools.AdopOverrideLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopAdminCloseLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopDeleteLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopRestoreDeletedLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopAdminCloseLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopDeleteLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopRestoreAdminLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopRestoreDeletedLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);
            UIActions.JSClickElement(_adopAdminTools.AdopTerminateLinkButton);

            UIActions.TypeInTextBoxAndEnter(_adopAdminTools.AdopAdminTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopAdminTools.AdopAdminGoLinkButton);

            //logout
            UIActions.JSClickElement(_miscPageOjects.LogoutButton);


            _driverInit.InitWebdriver();
            _login.LoginMethod("8880077013");

            //Navigate to Admin Tools Menu
            List<By> tab = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.ADOPMenuLink, _navMenu.MyADOPMenuLink, _navMenu.SearchADOPMenuLink };
            MasterMenuNavigation.StartTabSelectionMethod(tab);

            UIActions.TypeInTextBoxAndEnter(_adopBoardPage.CaseIdTextBox, "ADOP -TX-20-00010");
            UIActions.JSClickElement(_adopBoardPage.FilterButton);

           

        }




















    }


    
}
