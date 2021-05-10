using EmmpsAutomation.PageObjectModel.LOD;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.LOD
{
    public class MyLODSearch
    {

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        StartNewLODPage _startnewlod;
        SearchFilterObjects _searchFilter;
        MiscPageOjects _miscPageOjects;

        public MyLODSearch()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _startnewlod = new StartNewLODPage();
            _searchFilter = new SearchFilterObjects();
            _miscPageOjects = new MiscPageOjects();
        }

        [Fact]
        public void MyLODSearchPageValidations()
        {
            try
            {

            }
            finally
            {
                _driverInit.TearDown();
            }
            //			@TestCase 42162
            //Scenario Outline: LOD All Inbox and Search Page Update MyLODs -Validations
            //	Given I am Logged in as < Role > using EDIPIN<PIN>
            //	  And I have navigated to "My LODs" tab in "eMMPS"
            //	Then I verify the fields on My LOOs page
            //	And I verify the status dropdown list<StatusDropdownList>
            //	And I verify the Workflow dropdown list<WorkflowDropdownList>
            //	And I verify the Region dropdownlist

            //	Scenarios: 
            //	| Role | PIN | StatusDropdownList | WorkflowDropdownList |
            //	| State Admin | 8880070113 | --All--,LOD Appeal Draft(NG),LOD Draft(NG),State Admin LOD Review(NG) | --All--,NG Death(Formal),NG Death(Informal),NG Legacy Unrestricted(Formal),NG M-Day(Formal),NG M-Day(Informal),NG OCONUS(Formal),NG OCONUS(Informal),NG Pre-Approved(Informal),NG Title 10(Formal),NG Title 10(Informal),NG Title 32(Formal),NG Title 32(Informal),NG Unrestricted Assault(Informal) |


        }
	}
}
