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
    //52597
    //eMMPS>MMSO>Start MMSO-NG Followup Care Pre-Auth[Form 02]
    public class StartMMSONGFollowupCarePreAuthForm02
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

        public StartMMSONGFollowupCarePreAuthForm02()
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
        public void StartMMSONGFollowupCarePreAuthForm02Validations()
        {
            //Step 1) Login to Medchart 
            //Step 2) Enter EDIPIN 8880070001 in the text box of test user field and click on Login button
            _driverInit.InitWebdriver();
            _login.LoginMethod("8880070001");
            //Step 3) Hover the mouse on the eMMPS tab
            //Step 4) Hover the mouse on MMSO in the eMMPS tab
            //Step 5) Select the Start New Pre-Authorization sub tab 
            List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.MMSOMenuBarLink, _navMenu.StartNewPreAuthLink };
            MasterMenuNavigation.StartTabSelectionMethod(tabs);
            //Step 6) Verify MEDCHART - Lookup SM Control is displayed

            //Step 7) Verify Soldier Search and Select Section
            //Step 8) Soldier Search and Select ***
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

            //Step 9) Enter SSN from the existing Service Member in SSN text box and click on search button (919009325)

            //Step 10) Verify the Member Data Section in eMMPS/Start New Pre-Authorization Page
            //Step 11) Click on the Rank drop-down menu
            //Step 12) Click on the Rank drop-down menu in Member Data section and select -- Select -- Option
            //Step 13) Verify MMSO Pre-Auth Options
            //Step 14) Click on the drop down menu of Workflow
            //Step 15) Select NG Followup care Pre-Auth [Form 02] from the drop-down menu 
            //Step 16) Verify Existing Worksheets result grid
            //Step 17) Verify Eligible LODs section
            //Step 18) In Eligible LODs Section, click on a check box of Associate MMSO column of one result 
            //Step 19) In Eligible Worksheets Section, click on a check box of Associate MMSO column of one result 
            //Step 20) Click on Create MMSO button
            //Step 21) Select a Rank from the drop- down menu and click on Create MMSO button
            //Step 22) Verify the Status of the case
            //Step 23) Verify the Forms Tab
            //Step 24) Verify the Branch of Service  field
            //Step 25) Verify the  Rank field
            //Step 26) Logged Out Page

        }


    }


}

