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
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.Tests.ADOP
{
    public class OrdersTab
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
        public OrdersTab()
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
        }


        [Fact]
        public void ADOPOrdersTabValidations()
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

            //clicks Order Tab
            UIActions.JSClickElement(_adopNav.ADOPOrdersMenuLinkButton);

            UIActions.GetElement(_adopOrdersPage.ADOPOrderNumberValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopOrdersPage.ADOPOrderNumberValidationMess).Text.Should().BeEquivalentTo("Required");

            UIActions.GetElement(_adopOrdersPage.ADOPSRULocationValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopOrdersPage.ADOPSRULocationValidationMess).Text.Should().BeEquivalentTo("Required");

            UIActions.GetElement(_adopOrdersPage.ADOPStartDateValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopOrdersPage.ADOPStartDateValidationMess).Text.Should().BeEquivalentTo("Required");

            UIActions.GetElement(_adopOrdersPage.ADOPEndDateValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopOrdersPage.ADOPEndDateValidationMess).Text.Should().BeEquivalentTo("Required");

            UIActions.GetElement(_adopOrdersPage.ADOPStartOfRefradValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopOrdersPage.ADOPStartOfRefradValidationMess).Text.Should().BeEquivalentTo("Required");

            UIActions.GetElement(_adopOrdersPage.ADOPSoldierReleasedValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopOrdersPage.ADOPSoldierReleasedValidationMess).Text.Should().BeEquivalentTo("Required");

            UIActions.GetElement(_adopOrdersPage.ADOPSoldierDepartValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(_adopOrdersPage.ADOPSoldierDepartValidationMess).Text.Should().BeEquivalentTo("Required");

            //101 characters--only 100 go inside field
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPOrderNumberTextBox, "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901");
            ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPOrderNumberValidationMess).Count.Should().Be(0);

            //SRU Location Dropdown
            Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPSRULocationTextBox, new List<string> { "Select", "Joint Base Lewis-McChord", "Tripler", "Bethesda", "Ft. Belvoir", "Ft. Benning", "Ft. Bragg", "Ft. Campbell", "Ft. Drum", "Ft. Stewart", "Ft. Bliss", "Ft. Carson", "Ft. Hood", "Ft. Riley", "Joint Base San Antonio" }));
            UIActions.SelectElementByText(_adopOrdersPage.ADOPSRULocationTextBox, "Ft. Belvoir");
            ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPSRULocationValidationMess).Count.Should().Be(0);

            //ADOP Start Date Box
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPStartDateBox, (UIActions.SelectDate(Convert.ToInt32(-180)) + " 0000"));
            ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPStartDateValidationMess).Count.Should().Be(0);
            UIActions.ClearTextBox(_adopOrdersPage.ADOPStartDateBox);
            //date box cannot have letters
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPStartDateBox, "this will mot be there");
            UIActions.GetElement(_adopOrdersPage.ADOPStartDateValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPStartDateBox, "123456789");
            // date box cannot go above 9 digits
            Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPStartDateBox, "12345678"));


            //ADOP End Date Box
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPEndDateBox, (UIActions.SelectDate(Convert.ToInt32(-181)) + " 0000"));
            ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPEndDateValidationMess).Count.Should().Be(0);
            UIActions.ClearTextBox(_adopOrdersPage.ADOPEndDateBox);
            //date box cannot have letters
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPEndDateBox, "this will not be there");
            UIActions.GetElement(_adopOrdersPage.ADOPEndDateValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPEndDateBox, "123456789");
            // date box cannot go above 9 digits
            Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPEndDateBox, "12345678"));


            // started soldiers release from Active Duty
            UIActions.JSClickElement(_adopOrdersPage.ADOPYesRefrad);
            ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPStartOfRefradValidationMess).Count.Should().Be(0);

            //is solider released from Active Duty
            UIActions.JSClickElement(_adopOrdersPage.ADOPYesReleasedAd);
            ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPSoldierReleasedValidationMess).Count.Should().Be(0);


            //Soldier Depart Date Box
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPDepatureDateBox, (UIActions.SelectDate(Convert.ToInt32(-179)) + "0000"));
            //clicks away to remove validation message
            UIActions.JSClickElement(_adopOrdersPage.ADOPImageDateEnd);
            ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPSoldierDepartValidationMess).Count.Should().Be(0);
            UIActions.ClearTextBox(_adopOrdersPage.ADOPDepatureDateBox);
            //date box cannot have letters
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPDepatureDateBox, "this will not be there");
            UIActions.GetElement(_adopOrdersPage.ADOPSoldierDepartValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPDepatureDateBox, "123456789");
            // date box cannot go above 9 digits
            Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPDepatureDateBox, "12345678"));

            //clicks Associate Tab
            //UIActions.JSClickElement(_adopNav.ADOPAssociateMenuLinkButton);

            //clicks Order Tab
            //UIActions.JSClickElement(_adopNav.ADOPOrdersMenuLinkButton);

            }
            [Fact]
            public void ADOPOrdersTabVEalidations()
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
                UIActions.SelectElementByText(_adopBoardPage.WorkflowDropdownBox, "(NG) NG MRP-E");
                UIActions.SelectElementByText(_adopBoardPage.StatusDropdownBox, "ADOP MRP-E Draft (NG)");
                UIActions.JSClickElement(_adopBoardPage.FilterButton);
                UIActions.JSClickElement(_adopBoardPage.TestCase1);

                //clicks Order Tab
                UIActions.JSClickElement(_adopNav.ADOPOrdersMenuLinkButton);

                UIActions.GetElement(_adopOrdersPage.ADOPOrderNumberValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_adopOrdersPage.ADOPOrderNumberValidationMess).Text.Should().BeEquivalentTo("Required");

                UIActions.GetElement(_adopOrdersPage.ADOPSRULocationValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_adopOrdersPage.ADOPSRULocationValidationMess).Text.Should().BeEquivalentTo("Required");

                UIActions.GetElement(_adopOrdersPage.ADOPStartDateValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_adopOrdersPage.ADOPStartDateValidationMess).Text.Should().BeEquivalentTo("Required");

                UIActions.GetElement(_adopOrdersPage.ADOPEndDateValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_adopOrdersPage.ADOPEndDateValidationMess).Text.Should().BeEquivalentTo("Required");

                UIActions.GetElement(_adopOrdersPage.ADOPStartOfRefradValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_adopOrdersPage.ADOPStartOfRefradValidationMess).Text.Should().BeEquivalentTo("Required");

                UIActions.GetElement(_adopOrdersPage.ADOPSoldierReleasedValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_adopOrdersPage.ADOPSoldierReleasedValidationMess).Text.Should().BeEquivalentTo("Required");

                UIActions.GetElement(_adopOrdersPage.ADOPSoldierDepartValidationMess).Displayed.Should().BeTrue();
                UIActions.GetElement(_adopOrdersPage.ADOPSoldierDepartValidationMess).Text.Should().BeEquivalentTo("Required");

                //101 characters--only 100 go inside field
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPOrderNumberTextBox, "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901");
                ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPOrderNumberValidationMess).Count.Should().Be(0);

                //SRU Location Dropdown
                Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPSRULocationTextBox, new List<string> { "Select", "Joint Base Lewis-McChord", "Tripler", "Bethesda", "Ft. Belvoir", "Ft. Benning", "Ft. Bragg", "Ft. Campbell", "Ft. Drum", "Ft. Stewart", "Ft. Bliss", "Ft. Carson", "Ft. Hood", "Ft. Riley", "Joint Base San Antonio" }));
                UIActions.SelectElementByText(_adopOrdersPage.ADOPSRULocationTextBox, "Tripler");
                ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPSRULocationValidationMess).Count.Should().Be(0);

                //ADOP Start Date Box
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPStartDateBox, (UIActions.SelectDate(Convert.ToInt32(-180)) + " 0000"));
                ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPStartDateValidationMess).Count.Should().Be(0);
                UIActions.ClearTextBox(_adopOrdersPage.ADOPStartDateBox);
                //date box cannot have letters
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPStartDateBox, "this will mot be there");
                UIActions.GetElement(_adopOrdersPage.ADOPStartDateValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPStartDateBox, "123456789");
                // date box cannot go above 9 digits
                Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPStartDateBox, "12345678"));


                //ADOP End Date Box
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPEndDateBox, (UIActions.SelectDate(Convert.ToInt32(-181)) + " 0000"));
                ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPEndDateValidationMess).Count.Should().Be(0);
                UIActions.ClearTextBox(_adopOrdersPage.ADOPEndDateBox);
                //date box cannot have letters
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPEndDateBox, "this will not be there");
                UIActions.GetElement(_adopOrdersPage.ADOPEndDateValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPEndDateBox, "123456789");
                // date box cannot go above 9 digits
                Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPEndDateBox, "12345678"));


                // started soldiers release from Active Duty
                UIActions.JSClickElement(_adopOrdersPage.ADOPYesRefrad);
                ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPStartOfRefradValidationMess).Count.Should().Be(0);

                //is solider released from Active Duty
                UIActions.JSClickElement(_adopOrdersPage.ADOPYesReleasedAd);
                ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPSoldierReleasedValidationMess).Count.Should().Be(0);


                //Soldier Depart Date Box
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPDepatureDateBox, (UIActions.SelectDate(Convert.ToInt32(-179)) + "0000"));
                //clicks away to remove validation message
                UIActions.JSClickElement(_adopOrdersPage.ADOPImageDateEnd);
                ObjectRepository.Driver.FindElements(_adopOrdersPage.ADOPSoldierDepartValidationMess).Count.Should().Be(0);
                UIActions.ClearTextBox(_adopOrdersPage.ADOPDepatureDateBox);
                //date box cannot have letters
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPDepatureDateBox, "this will not be there");
                UIActions.GetElement(_adopOrdersPage.ADOPSoldierDepartValidationMess).Text.Should().BeEquivalentTo("Required");
                UIActions.TypeInTextBoxAndEnter(_adopOrdersPage.ADOPDepatureDateBox, "123456789");
                // date box cannot go above 9 digits
                Assert.True(UIActions.ComboboxInnerTextValidator(_adopOrdersPage.ADOPDepatureDateBox, "12345678"));

                //clicks Associate Tab
                //UIActions.JSClickElement(_adopNav.ADOPAssociateMenuLinkButton);

                //clicks Order Tab
                //UIActions.JSClickElement(_adopNav.ADOPOrdersMenuLinkButton);







            }
        }
}
