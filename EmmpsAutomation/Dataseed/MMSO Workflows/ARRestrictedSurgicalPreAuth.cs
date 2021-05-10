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
//    public class ARRestrictedSurgicalPreAuth
//    {
//        //Test Script 55395

//        string fileName = "ARRestrictedSurgicalPreAuth.xlsx";
//        private string currentId = string.Empty;

//        readonly BaseDriverInit driverInit;
//        readonly Login login;
//        readonly StartNewLODPage startNewLOD;
//        readonly NavMenuObjects navMenu;
//        readonly MyLODMenuNav myLOD;
//        readonly MiscPageOjects misc;
//        readonly MMSOPage startNewMMSO;
//        readonly LODNextActionTab nextActionTab;

//        public ARRestrictedSurgicalPreAuth()
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
//        public void ARRestrictedSurgicalPreAuthStartMMSO()
//        {
            
//            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\MMSO\" + fileName)));
//            int b = ExcelUtil.GetTotalRowCount();

//            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
//            {
//                currentId = ExcelUtil.ReadData(i, "Id");
//                StartMMSO(ExcelUtil.ReadData(i, "StartMMSOPin"), ExcelUtil.ReadData(i, "Id"));
//            }


//        }

//        [Fact]
//        public void ARRestrictedSurgicalPreAuthMMSOReviewer()
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


//        [Fact]
//        public void ARRestrictedSurgicalPreAuthMMSONurse()
//        {
           
//            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\MMSO\" + fileName)));
//            int b = ExcelUtil.GetTotalRowCount();

//            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
//            {
//                currentId = ExcelUtil.ReadData(i, "Id");
//                StartMMSO(ExcelUtil.ReadData(i, "StartMMSOPin"), ExcelUtil.ReadData(i, "Id"));
//                MMSOReviewer(ExcelUtil.ReadData(i, "MMSOReviewerPin"));
//                MMSONurse(ExcelUtil.ReadData(i, "MMSONursePin"));
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
//                WaitMethods.WaitForPageToLoad(60);
//                startNewMMSO.MMSOSoldierSSNSearch(id);
//                UIActions.SelectElementByText(startNewMMSO.MMSOWorkflowDropDownBox, "AR Restricted Surgical Pre-Auth [Form 06]");
//                //Wait for worksheet to show
//                WaitMethods.Wait(startNewMMSO.MMSOExistingWorkSheetsLabel, 50);
//                UIActions.JSClickElement(startNewMMSO.EligibleLODsAssociateMMSOCheckBox);
//                UIActions.JSClickElement(startNewMMSO.CreateMMSOButton);

//                //section II Surgery and Durable Medical Equipment (DME) Information
//                startNewMMSO.UpdateSurgeryInformationForm06("-65", "25", "Automation Test", "C162", "43501");

//                //Section III Current Unit Point of Contact Information
//                startNewMMSO.UpdateCurrentUnitPointOfContactInformationForm06("Mr.Smith", "Automation", "7031111111", "7031112222");

//                //next action tab
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
//                Thread.Sleep(8000);
//                UIActions.JSClickElement(startNewMMSO.MyMMSOPageLink);
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxStatus, "MMSO Contact Representative (AR)");
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "AR Surgical Pre-Auth [Form 06]");
//                UIActions.JSClickElement(startNewMMSO.MMSOSearchMyFilterButton);
//                Thread.Sleep(3000);
//                //WaitMethods.Wait(LODCaseMenuNav.FilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                //WaitMethods.Wait(LODCaseMenuNav.FilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                startNewMMSO.ClickOnTheFirstCaseId();

//                //followup care
//                UIActions.JSClickElement(myLOD.MMSOFollowupCareMenuLinkButtonLinkText);
//                startNewMMSO.UpdateMMSOFollowupCareTab("Routine Priority", "  Comeback in 2 weeks", "Test", "Test");

//                //next action tab
//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MMSO Nurse");
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

//        public void MMSONurse(string edipin)
//        {
//            try
//            {
//                driverInit.InitWebdriver();
//                login.LoginMethod(edipin);
//                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.MMSOMenuBarLink, navMenu.MyPreauthMMSOLink };
//                MasterMenuNavigation.StartTabSelectionMethod(tabs);

//                UIActions.JSClickElement(startNewMMSO.MyMMSOPageLink);
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxStatus, "MMSO Nurse (AR)");
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "AR Surgical Pre-Auth [Form 06]");
//                UIActions.JSClickElement(startNewMMSO.MMSOSearchMyFilterButton);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                startNewMMSO.ClickOnTheFirstCaseId();

//                UIActions.JSClickElement(myLOD.MMSOFollowupCareMenuLinkButtonLinkText);

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
