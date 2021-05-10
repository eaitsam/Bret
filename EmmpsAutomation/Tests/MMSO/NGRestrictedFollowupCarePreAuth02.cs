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
    //59584 
    //eMMPS>MMSO>Start MMSO-NG Restricted Followup Care Pre-Auth[Form 02]
    public class NGRestrictedFollowupCarePreAuth02
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

        public NGRestrictedFollowupCarePreAuth02()
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
        public void NGRestrictedFollowupCarePreAuth02Validations()
        {
            // Step 1-> Login to Medchart 
            // Step 2-> Enter EDIPIN of NG SARC (8880070009) in the text box of test user field, click on Login button
            _driverInit.InitWebdriver();
            _login.LoginMethod("8880070009");
            // Step 3-> Hover the mouse on MMSO in the eMMPS tab
            // Step 4-> Select the Start New Pre-Authorization sub tab 
            List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.MMSOMenuBarLink, _navMenu.StartNewPreAuthLink };
            MasterMenuNavigation.StartTabSelectionMethod(tabs);
            // Step 5-> Enter a valid SSN in the text box of SSN field and click on Search button
            UIActions.JSClickElement(_MMSOPOM.SoldierSSN);
            UIActions.TypeInTextBoxAndEnter(_MMSOPOM.SoldierSSN, "919009325");
            UIActions.JSClickElement(_MMSOPOM.SoldierSearchButton);
            // Step 6-> Verify the Member Data Section in eMMPS/Start New Pre-Authorization  Page
            UIActions.GetElement(_MMSOPOM.FullNameFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.FullNameExpectedValue);
            UIActions.GetElement(_MMSOPOM.MemberDataRankDropDown).Text.Should().BeEquivalentTo("Major (MAJ)");
            UIActions.GetElement(_MMSOPOM.SSNFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.SSNExpectedValue);
            UIActions.GetElement(_MMSOPOM.EDIPINFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.EDIPINExpectedValue);
            UIActions.GetElement(_MMSOPOM.ComponentFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.ComponentExpectedValue);
            UIActions.GetElement(_MMSOPOM.DataDOBFieldLabel).Text.Should().BeEquivalentTo(_MMSOPOM.DOBExpectedValue);
            // Step 7-> Click on the Rank drop-down menu
            UIActions.JSClickElement(_MMSOPOM.MemberDataRankDropDown);
            // Step 8-> Click on the Rank drop-down menu in Member Data section and select -- Select -- Option
            UIActions.SelectElementByText(_MMSOPOM.MemberDataRankDropDown, "--Select--");
            // Step 9-> Click on the drop down menu of Workflow
            UIActions.JSClickElement(_MMSOPOM.WorkflowDropDown);

            // Step 10-> Select NG Restricted Followup Care Pre-Auth [Form 02] from the drop-down menu
            UIActions.SelectElementByText(_MMSOPOM.WorkflowDropDown, "NG Restricted Followup Care Pre-Auth [Form 02]");
            // Step 11-> Verify Existing Worksheets result grid
            UIActions.GetElement(_MMSOPOM.CaseID1ExistingWorksheet).Displayed.Should().BeTrue(); //?
            UIActions.GetElement(_MMSOPOM.CaseID2ExistingWorksheet).Displayed.Should().BeTrue(); //?
            UIActions.GetElement(_MMSOPOM.CaseID3ExistingWorksheet).Displayed.Should().BeTrue(); //?

            UIActions.GetElement(_MMSOPOM.Workflow11ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Workflow1ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Workflow2ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Workflow2ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Workflow3ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Workflow3ExpectedValue);

            UIActions.GetElement(_MMSOPOM.Name1ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Name1ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Name2ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Name2ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Name3ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Name3ExpectedValue);

            UIActions.GetElement(_MMSOPOM.UIC1ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.UIUC1ExpectedValue);
            UIActions.GetElement(_MMSOPOM.UIC2ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.UIUC2ExpectedValue);
            UIActions.GetElement(_MMSOPOM.UIC3ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.UIUC3ExpectedValue);

            UIActions.GetElement(_MMSOPOM.Region1ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Region1ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Region2ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Region2ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Region3ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Region3ExpectedValue);

            UIActions.GetElement(_MMSOPOM.Status1ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Status1ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Status2ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Status2ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Status3ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Status3ExpectedValue);

            UIActions.GetElement(_MMSOPOM.Diagnosis1ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Diagnosis1ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Diagnosis2ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Diagnosis2ExpectedValue);
            UIActions.GetElement(_MMSOPOM.Diagnosis3ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.Diagnosis3ExpectedValue);

            UIActions.GetElement(_MMSOPOM.DateReceived1ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.DataReceived1ExpectedValue);
            UIActions.GetElement(_MMSOPOM.DateReceived2ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.DataReceived2ExpectedValue);
            UIActions.GetElement(_MMSOPOM.DateReceived3ExistingWorksheet).Text.Should().BeEquivalentTo(_MMSOPOM.DataReceived3ExpectedValue);


            // Step 12-> Verify Eligible LODs section
            UIActions.GetElement(_MMSOPOM.AssociateMMSOCheckboxLOD).Displayed.Should().BeTrue(); //?
            UIActions.GetElement(_MMSOPOM.CaseIDEligibleLOD2).Displayed.Should().BeTrue(); //?

            UIActions.GetElement(_MMSOPOM.WorkflowEligibleLOD2).Text.Should().BeEquivalentTo(_MMSOPOM.WorkflowEligibleExpectedValue);
            UIActions.GetElement(_MMSOPOM.NameEligibleLOD2).Text.Should().BeEquivalentTo(_MMSOPOM.NameEligibleExpectedValue);
            UIActions.GetElement(_MMSOPOM.UICEligibleLOD2).Text.Should().BeEquivalentTo(_MMSOPOM.UIUCEligibleExpectedValue);
            UIActions.GetElement(_MMSOPOM.RegionEligibleLOD2).Text.Should().BeEquivalentTo(_MMSOPOM.RegionEligibleExpectedValue);
            UIActions.GetElement(_MMSOPOM.StatusEligibleLOD2).Text.Should().BeEquivalentTo(_MMSOPOM.StatusEligibleExpectedValue);
            UIActions.GetElement(_MMSOPOM.DiagnosisEligibleLOD2).Text.Should().BeEquivalentTo(_MMSOPOM.DiagnosisEligibleExpectedValue);
            UIActions.GetElement(_MMSOPOM.DateReceivedEligibleLOD2).Text.Should().BeEquivalentTo(_MMSOPOM.DataReceivedEligibleExpectedValue);

            // Step 13-> In Eligible LODs Section, click on a check box of Associate MMSO column of one result
            UIActions.JSClickElement(_MMSOPOM.AssociateMMSOCheckboxLOD);
            // Step 14-> In Eligible Worksheets Section, click on a check box of Associate MMSO column of one result
            UIActions.JSClickElement(_MMSOPOM.EligibleWorksheetAssociateMMSOCheckBox);
            
            // Step 15-> Verify Eligible Worksheets workflow Column ????

            // Step 16-> Click on Create MMSO button
           // UIActions.JSClickElement(_MMSOPOM.ActionCreateMMSO);


            // Step 17-> Select a Rank from the drop- down menu and click on Create MMSO button
            UIActions.JSClickElement(_MMSOPOM.RankOrGradeMDS1);
            UIActions.SelectElementByText(_MMSOPOM.MemberDataRankDropDown, "Major General (MG)");
            // STep 18-> Verify the Status of the case 
            UIActions.GetElement(_MMSOPOM.RestrictedMMSODraft).Text.Should().BeEquivalentTo(_MMSOPOM.RestrictedMMSODraftValidationExpectedValue);
            // Step 19-> Verify the Forms Tab 
            UIActions.GetElement(_MMSOPOM.MMSOFormsTab).Displayed.Should().BeTrue();
            // Step 20-> Verify the Branch of Service  field
            UIActions.GetElement(_MMSOPOM.BranchOfService).Text.Should().BeEquivalentTo(_MMSOPOM.BranchOfServiceExpectedValue);
            UIActions.GetElement(_MMSOPOM.BranchOfServiceDropDown).Text.Should().BeEquivalentTo("ARNG");
            // Step 21-> Verify the  Rank field
            UIActions.GetElement(_MMSOPOM.MemberDataRankDropDown).Text.Should().BeEquivalentTo("Major General (MG)");
            // Step 22-> Logged Out Page 
            // Click on Logout link on the top right corner 
            UIActions.JSClickElement(_MMSOPOM.LogoutLink);
            // Click on the Click here link in the Logged out page 
            UIActions.JSClickElement(_MMSOPOM.ClickHere);





        }




    }


}
