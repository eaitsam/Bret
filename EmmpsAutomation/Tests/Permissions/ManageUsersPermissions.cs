using EmmpsAutomation.PageObjectModel.LOD;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Permissions
{
    public class ManageUsersPermissions
    {
        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        StartNewLODPage _startNewLOD;


        public ManageUsersPermissions()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _startNewLOD = new StartNewLODPage();
            _navMenu = new NavMenuObjects();
        }

    }
}
