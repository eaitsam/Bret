using FluentAssertions;
using FluentAssertions.Common;
using FrameworkAutomation.PageObjectModel;
using FrameworkAutomation.User_Management.SharedContextData;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.Tests.UserImpersonate
{
    public class UserImpersonate
    {
        private Login _login;
        private Homepage _homePage;
        private RegistrationPage _reg;
        private NavMenuObjects _navMenu;
        private AccessLogPage _accessLog;
        private BaseDriverInit _driverInit;
        private SearchFilterObjects _searchFilter;
        private readonly ImpersonateUserPage _impersonateUserPage;


        public UserImpersonate()
        {
            _login = new Login();
            _homePage = new Homepage();
            _reg = new RegistrationPage();
            _navMenu = new NavMenuObjects();
            _accessLog = new AccessLogPage();
            _driverInit = new BaseDriverInit();
            _searchFilter = new SearchFilterObjects();
            _impersonateUserPage = new ImpersonateUserPage();

        }

        [Fact]
        public void ImpersonateRole()
        {
            try
            {
                List<string> expValue = new List<string>();
                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");//
                List<By> tabs = new List<By> { _navMenu.AdminMenuBarXpath, _navMenu.ImpersonateRoleMenuLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);
                UIActions.SelectElementByIndex(_searchFilter.MedchartModuleComboBox, 2);            


                // eCase ARNG Manager
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 0);

                //Administrative support
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 1);
                GetPermissionTable();

                //Auditor
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 2);
                UIActions.ClickElement(_impersonateUserPage.ReportsTab);
                UIActions.IsElementPresent(_impersonateUserPage.EcaseReports_Table);

                ////BHOAuditor
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 3);
                GetPermissionTable();
                ////DSS
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 4);
                GetPermissionTable();

                ////LeadMCM
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 5);
                GetPermissionTable();
                UIActions.ClickElement(_impersonateUserPage.LeadMCMecasePermGrpTab);
                UIActions.IsElementPresent(_impersonateUserPage.eCaseAdmin_Table);

                ////MedicalCaseManager
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 6);
                GetPermissionTable();

                ////MedicalRedinessNCO
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 7);
                GetPermissionTable();
                ////NGBBHO
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 8);
                ////case "Provider":
                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 9);
                GetPermissionTable();

                UIActions.SelectElementByIndex(_searchFilter.RoleComboBox, 10);
                GetPermissionTable();

                UIActions.ClickElement(_impersonateUserPage.SelectAllTab);
                UIActions.ClickElement(_impersonateUserPage.Submitbutton);

                Assert.True(UIActions.GetElement(_impersonateUserPage.TileUserControl).Displayed);
                UIActions.ClickElement(_impersonateUserPage.ImpHyperLink);
                UIActions.ClickElement(_impersonateUserPage.StopImpersonating);
                Assert.False(UIActions.IsElementPresent(_impersonateUserPage.TileUserControl));

            }
            finally
            {
                _driverInit.TearDown();
            };


        }

        private void GetPermissionTable()
        {
            UIActions.ClickElement(_impersonateUserPage.SensitiveDataTab);
            UIActions.IsElementPresent(_impersonateUserPage.ECaseSensitiveData_Table);
            UIActions.ClickElement(_impersonateUserPage.ManageCasesTab);
            UIActions.IsElementPresent(_impersonateUserPage.EcaseManageCases_Table);
            UIActions.ClickElement(_impersonateUserPage.ReportsTab);
            UIActions.IsElementPresent(_impersonateUserPage.EcaseReports_Table);
        }
    }
}






