//using EmmpsAutomation.PageObjectModel.LOD;
//using EmmpsAutomation.PageObjectModel.MMSO;
//using MedchartSeleniumAutomationCore.Core_Framework;
//using MedchartSeleniumAutomationCore.Core_PageObjects;
//using MedchartSeleniumAutomationCore.Core_Settings;
//using MedchartSeleniumAutomationCore.Core_Shared_Methods;
//using MedchartSeleniumAutomationCore.Core_Tools;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using Xunit;

//namespace EMMPSDataseed.Workflows.MMSO
//{
//    public class ARFollowupCarePreAuth
//    {
//        //Test Script 55392

//        string fileName = "ARFollowupCarePreAuth.xlsx";
//        private string currentId = string.Empty;

//        readonly BaseDriverInit driverInit;
//        readonly Login login;
//        readonly StartNewLODPage startNewLOD;
//        readonly NavMenuObjects navMenu;
//        readonly MyLODMenuNav myLOD;
//        readonly MiscPageOjects misc;
//        readonly MMSOPage startNewMMSO;
//        readonly LODNextActionTab nextActionTab;

//        public ARFollowupCarePreAuth()
//        {
//            driverInit = new BaseDriverInit();
//            login = new Login();
//            startNewLOD = new StartNewLODPage();
//            navMenu = new NavMenuObjects();
//            misc = new MiscPageOjects();
//            myLOD = new MyLODMenuNav();
//            startNewMMSO = new MMSOPage();
//            nextActionTab = new LODNextActionTab();
//        }


//        [Fact]
//        public void ARFollowupCarePreAuthStartMMSO()
//        {
//            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

//            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\MMSO\" + fileName)));
//            int b = ExcelUtil.GetTotalRowCount();

//            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
//            {
//                currentId = ExcelUtil.ReadData(i, "Id");
//                StartMMSO(ExcelUtil.ReadData(i, "StartMMSOPin"), ExcelUtil.ReadData(i, "Id"));
//            }


//        }

//        [Fact]
//        public void ARFollowupCarePreAuthMMSOReviewer()
//        {
//            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

//            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\MMSO\" + fileName)));
//            int b = ExcelUtil.GetTotalRowCount();

//            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
//            {
//                currentId = ExcelUtil.ReadData(i, "Id");
//                StartMMSO(ExcelUtil.ReadData(i, "StartMMSOPin"), ExcelUtil.ReadData(i, "Id"));
//                MMSOReviewer(ExcelUtil.ReadData(i, "MMSOReviewerPin"));
//            }


//        }




//        public void StartMMSO(string edipin, string id)
//        {
//            try
//            {
//                driverInit.InitWebdriver();
//                login.LoginMethod(edipin);
//                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.MMSOMenuBarLink, navMenu.MyPreauthMMSOLink, navMenu.StartNewPreAuthLink };
//                MasterMenuNavigation.StartTabSelectionMethod(tabs);

//                startNewMMSO.MMSOSoldierSSNSearch(id);
//                UIActions.SelectElementByText(startNewMMSO.MMSOWorkflowDropDownBox, "AR Followup Care Pre-Auth [Form 02]");
//                //Wait for worksheet to show
//                UIActions.JSClickElement(startNewMMSO.EligibleLODsAssociateMMSOCheckBox);
//                UIActions.JSClickElement(startNewMMSO.CreateMMSOButton);

//                //Update MMSO form
//                // Section 1 Memeber Data
//                //(string memberEmail, string memberPhone, string triCareRegion)
//                startNewMMSO.UpdateMMSOFormMemberData("testemail@med-chart.mil", "7031111111", "North");

//                //section II Pre-Authorization Request
//                //(string fromDutyDate, string ToDutydate, string injurycode, string neededFollowup, string specialtyRequested, string medicalInBoardProcess(Yes orNo), formType = 02)
//                startNewMMSO.UpdateMMSOFollowUpFormPreAuthRequest("-365", "25", "M00062", "Automation Test", "Automation Test", "No", "02");

//                //Section III
//                //(string miles, string milesFromPlaceType, string unitPoc, string PocPhone, string PocEmail, string formType (form01=PreAuth, form02=FollowupCarePreAuth), Type of Orders = N/A for thing )
//                startNewMMSO.UpdateMMSOFormCurrentUnitCertificationOfEligibilityFollowUpForm02("10", "Duty", "Dr. Automation", "7031111111", "test@test.mil");

//                //Next Action
//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MMSO Contact Rep");
//                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

//                if (UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
//                {
//                    throw new NoSuchElementException("Next Action Button disabled.");
//                }
//                else
//                {
//                    UIActions.JSClickElement(startNewMMSO.MMSONextActionSignButton);
//                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
//                }




//            }

//            finally
//            {
//                driverInit.TearDown();
//            }


//        }

//        public void MMSOReviewer(string edipin)
//        {
//            try
//            {
//                driverInit.InitWebdriver();
//                login.LoginMethod(edipin);
//                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.MMSOMenuBarLink, navMenu.MyPreauthMMSOLink };
//                MasterMenuNavigation.StartTabSelectionMethod(tabs);

//                UIActions.JSClickElement(startNewMMSO.MyMMSOPageLink);
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxStatus, "MMSO Contact Representative (AR)");
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "AR Followup Care Pre-Auth [Form 02]");
//                UIActions.JSClickElement(startNewMMSO.MMSOSearchMyFilterButton);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                startNewMMSO.ClickOnTheFirstCaseId();
//                UIActions.JSClickElement(myLOD.MMSOFollowupCareMenuLinkButtonLinkText);

//                startNewMMSO.UpdateMMSOFollowupCareTab("Routine Priority", "  Comeback in 2 weeks", "Test", "Test");

//                //next action tab
//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Complete Pre-Auth Case");
//                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

//                if (UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
//                {
//                    throw new NoSuchElementException("Next Action Button disabled.");
//                }
//                else
//                {
//                    UIActions.JSClickElement(startNewMMSO.MMSONextActionSignButton);
//                    WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
//                }


//            }

//            finally
//            {
//                driverInit.TearDown();
//            }
//        }

//    }
//}
