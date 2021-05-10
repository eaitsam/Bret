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
//using System.Threading;
//using Xunit;

//namespace EMMPSDataseed.Workflows.MMSO
//{
//    public class ARMMSOPreAuth
//    {
//        //Test Script 55384

//        #region Page Objects
//        //---------------------------------------------------------------------------------------------//
//        //Objects are organized by HTML Tag type in their own #region tags
//        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
//        //---------------------------------------------------------------------------------------------//



//        #endregion

//        string fileName = "ARMMSOPreAuth.xlsx";
//        private string currentId = string.Empty;

//        readonly BaseDriverInit driverInit;
//        readonly Login login;
//        readonly StartNewLODPage startNewLOD;
//        readonly NavMenuObjects navMenu;
//        readonly MyLODMenuNav myLOD;
//        readonly MiscPageOjects misc;
//        readonly MMSOPage startNewMMSO;
//        readonly LODNextActionTab nextActionTab;


//        public ARMMSOPreAuth()
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
//        public void ARMMSOPreAuthStartMMSO()
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
//        public void ARMMSOPreAuthMMSOReviewer()
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
//                UIActions.SelectElementByText(startNewMMSO.MMSOWorkflowDropDownBox, "AR Pre-Auth [Form 01]");
//                UIActions.JSClickElement(startNewMMSO.CreateMMSOButton);

//                //Update MMSO form
//                // Section 1 Memeber Data
//                //(string memberEmail, string memberPhone, string triCareRegion)
//                startNewMMSO.UpdateMMSOFormMemberDataForm01("testemail@med-chart.mil", "7031111111");

//                //section II Illness/Injury Information
//                //(string dateInjury, string treatmentDate, string fromDutyDate, string ToDutyDate,  string injurycode)
//                startNewMMSO.UpdateMMSOFormPreAuthIllnessInjury("-50", "-50", "-365", "25", "M00062");

//                //Section IIIstring formType (form01=PreAuth, form02=FollowupCarePreAuth, Type of Orders))
//                startNewMMSO.UpdateMMSOFormCurrentUnitCertificationOfEligibilityPreAuthForm01("10", "Duty", "Dr. Automation", "7031111111", "test@test.mil", "other");

//                //Next Action
//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MMSO Contact Rep");
//                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

//                if(UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
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

//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxStatus, "MMSO Contact Representative (AR)");
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "AR Pre-Auth [Form 01]");
//                UIActions.JSClickElement(startNewMMSO.MMSOSearchMyFilterButton);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                //WaitMethods.Wait(LODCaseMenuNav.FilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                startNewMMSO.ClickOnTheFirstCaseId();
//                Thread.Sleep(7000);

//                //Followup Care tab
//                UIActions.JSClickElement(myLOD.MMSOFollowupCareMenuLinkButtonLinkText);
//                startNewMMSO.UpdateMMSOFollowupCareTab("Routine Priority", "  Comeback in 2 weeks", "Test", "Test");

//                //next action tab
//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Complete Pre-Auth Case");
//                WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);

//                if(UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
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
