using EmmpsAutomation.PageObjectModel.MMSO;
using EmmpsAutomation.PageObjectModel.LOD;
using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Xunit;

namespace EmmpsAutomation.Tests.MMSO
{
    public class SurgicalPreAuthForm06
    {
        MMSOPageObjectModel _MMSOPOM;
        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        SearchFilterObjects _searchFilter;
        MMSONav _MMSONav;
        PreAuthAdminPage _PreAuthAdminPage;
        PreAuthAssociatePage _PreAuthAssociatePage;
        PreAuthDocsPage _PreAuthDocsPage;
        PreAuthFollowupCarePage _PreAuthFollowupCarePage;
        PreAuthFormsPage _PreAuthFormsPage;
        PreAuthNextActionPage _PreAuthNextActionPage;
        PreAuthSelectCasePage _PreAuthSelectCasePage;
        PreAuthTrackingPage _PreAuthTrackingPage;

        public SurgicalPreAuthForm06()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _searchFilter = new SearchFilterObjects();
            _MMSONav = new MMSONav();
            _PreAuthAdminPage = new PreAuthAdminPage();
            _PreAuthAssociatePage = new PreAuthAssociatePage();
            _PreAuthDocsPage = new PreAuthDocsPage();
            _PreAuthFollowupCarePage = new PreAuthFollowupCarePage();
            _PreAuthFormsPage = new PreAuthFormsPage();
            _PreAuthNextActionPage = new PreAuthNextActionPage();
            _PreAuthSelectCasePage = new PreAuthSelectCasePage();
            _PreAuthTrackingPage = new PreAuthTrackingPage();
            _MMSOPOM = new MMSOPageObjectModel();

        }

        [Fact]
        //Step 1)  Log in to MEDCHART 
        //Step 2)  Enter EDIPIN 8880070001 in the text box of test user field and click on Login button
        public void SurgicalPreAuthForm06Validations()
        {
            _driverInit.InitWebdriver();
            _login.LoginMethod("8880070001");

            //Step 3) Hover the mouse on the eMMPS tab
            //Step 4) Hover the mouse on MMSO in the eMMPS tab
            //Step 5) Select the Start New Pre-Authorization sub tab 
            List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.MMSOMenuBarLink, _navMenu.StartNewPreAuthLink};
            MasterMenuNavigation.StartTabSelectionMethod(tabs);

            //Step 6) Verify MEDCHART - Lookup SM Control is displayed
           //Step 7) Verify Soldier Search and Select Section??
    //    public By SoldierFirstName => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_FirstNameText");
    //    public By SoldierLastName => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_LastNameText");
    //    public By SoldierSSN => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SSNText");
    //    public By SoldierEDIPI => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_EDIPIText");
     //   public By SoldierSearchButton => By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SearchButton");

            //step 8) Soldier Search and Select
        //Click on the Search button without entering any data  **         
        UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);

            // Enter 25 characters in First Name text box **
            UIActions.JSClickElement(_MMSOPOM.SoldierFirstName);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierFirstName, "NehaMathur-wdhfyudksjdiry");

            // Enter 31 characters in Last Name text box **
            UIActions.JSClickElement(_MMSOPOM.SoldierLastName);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierLastName, "NehaMathur-wdhfyudksjdirydjfurk");

            //Enter 10 digitis in SSN Text box **
            UIActions.JSClickElement(_MMSOPOM.SoldierSSN);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierSSN, "1234567892");

            //Enter Xav in the text box of First name and click on Search button **
            UIActions.JSClickElement(_MMSOPOM.SoldierFirstName);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierFirstName, "Xav");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);


            //Clear the first Name and enter Mee in the text box of Last Name and click on Search button **
            UIActions.JSClickElement(_MMSOPOM.SoldierLastName);
            UIActions.ClearTextBox(_MMSOPOM.SoldierFirstName);
            UIActions.ClearTextBox(_MMSOPOM.SoldierLastName);
            UIActions.JSClickElement(_MMSOPOM.SoldierLastName);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierLastName, "Mee");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);



            //Clear the Last Name and enter 888007000 in the text box of SSN and click on Search button **
            UIActions.JSClickElement(_MMSOPOM.SoldierLastName);
            UIActions.ClearTextBox(_MMSOPOM.SoldierLastName);
            UIActions.JSClickElement(_MMSOPOM.SoldierSSN);
            UIActions.ClearTextBox(_MMSOPOM.SoldierSSN);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierSSN, "888007000");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);


            //Clear SSN Text box and enter David in the First Name Text box and click on Search button **
            UIActions.JSClickElement(_MMSOPOM.SoldierSSN);
            UIActions.ClearTextBox(_MMSOPOM.SoldierSSN);
            UIActions.JSClickElement(_MMSOPOM.SoldierFirstName);
            UIActions.ClearTextBox(_MMSOPOM.SoldierFirstName);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierFirstName, "David");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);

            //Click on the SSN column heading
            //Click on the Soldier column heading
            // Click on the UIC column heading
            //Click on the Region column heading

            //Verify the number of Results per page**
            //Verify the total count of results for the search criteria is displayed as a label att the bottom of the result grid**


            //Enter Smith in the Last Name text box and click on Search button **
            UIActions.JSClickElement(_MMSOPOM.SoldierLastName);
            UIActions.ClearTextBox(_MMSOPOM.SoldierLastName);
            UIActions.JSClickElement(_MMSOPOM.SoldierLastName);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierLastName, "Smith");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);



            //Clear the Last Name text box and enter 5657 in the text box of SSN and click on Search button **
            UIActions.ClearTextBox(_MMSOPOM.SoldierLastName);
            UIActions.JSClickElement(_MMSOPOM.SoldierSSN);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierSSN, "5657");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);


            //Click on the Select link of a result row **
            UIActions.JSClickElement(_MMSOPOM.RowsPerPage);


            //step 9) Enter SSN from the existing Service Member in SSN text box and click on search button (919009325)
            UIActions.ClearTextBox(_MMSOPOM.SoldierSSN);
            UIActions.JSClickElement(_MMSOPOM.SoldierSSN);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierSSN, "919009325");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);

            //step 10) Verify the member data section in eMMPS / Start New Pre-Autherization Page
            UIActions.GetElement(_MMSOPOM.FullNameFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.FullNameExpectedValue);
            UIActions.GetElement(_MMSOPOM.MemberDataRankDropDown).Text.Should().BeEquivalentTo("Major (MAJ)");
            UIActions.GetElement(_MMSOPOM.SSNFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.SSNExpectedValue);
            UIActions.GetElement(_MMSOPOM.EDIPINFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.EDIPINExpectedValue);
            UIActions.GetElement(_MMSOPOM.ComponentFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.ComponentExpectedValue);
            UIActions.GetElement(_MMSOPOM.DataDOBFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.DOBExpectedValue);







        }


    }
}
