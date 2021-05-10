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
//    public class NGMMSOPreAuth
//    {
//        //Test Script 55206

//        string fileName = "NGMMSOPreAuth.xlsx";
//        private string currentId = string.Empty;

//        readonly BaseDriverInit driverInit;
//        readonly Login login;
//        readonly StartNewLODPage startNewLOD;
//        readonly NavMenuObjects navMenu;
//        readonly MyLODMenuNav myLOD;
//        readonly MiscPageOjects misc;
//        readonly MMSOPage startNewMMSO;
//        readonly LODNextActionTab nextActionTab;

//        public NGMMSOPreAuth()
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
//        public void NGMMSOPreAuthStartMMSO()
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
//        public void NGMMSOPreAuthStateAdmin()
//        {
//            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

//            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\MMSO\" + fileName)));
//            int b = ExcelUtil.GetTotalRowCount();

//            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
//            {
//                currentId = ExcelUtil.ReadData(i, "Id");
//                StartMMSO(ExcelUtil.ReadData(i, "StartMMSOPin"), ExcelUtil.ReadData(i, "Id"));
//                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
//            }


//        }

//        [Fact]
//        public void NGMMSOPreAuthMMSOReviewer()
//        {
//            //test = extent.CreateTest("NGPreApprovedFormalStartLOD", "StartLOD");

//            ExcelUtil.PopulateInCollection(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Dataseed\Parameter Files\MMSO\" + fileName)));
//            int b = ExcelUtil.GetTotalRowCount();

//            for (int i = 1; i <= ExcelUtil.GetTotalRowCount(); i++)
//            {
//                currentId = ExcelUtil.ReadData(i, "Id");
//                StartMMSO(ExcelUtil.ReadData(i, "StartMMSOPin"), ExcelUtil.ReadData(i, "Id"));
//                StateAdmin(ExcelUtil.ReadData(i, "StateAdminPin"));
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
//                WaitMethods.WaitForPageToLoad(60);
//                startNewMMSO.MMSOSoldierSSNSearch(id);
//                UIActions.SelectElementByText(startNewMMSO.MMSOWorkflowDropDownBox, "NG Pre-Auth [Form 01]");
//                Thread.Sleep(1000);
//                UIActions.JSClickElement(startNewMMSO.CreateMMSOButton);
//                Thread.Sleep(5000);
//                //Update MMSO form
//                // Section 1 Memeber Data
//                startNewMMSO.UpdateMMSOFormMemberDataForm01("testemail@med-chart.mil", "7031111111");

//                //section II Illness/Injury Information
//                startNewMMSO.UpdateMMSOFormPreAuthIllnessInjury("-50", "-50", "-365", "25", "M00062");

//                //Section III Current Unit Certification of Eligibility
//                startNewMMSO.UpdateMMSOFormCurrentUnitCertificationOfEligibilityPreAuthForm01("10", "Duty", "Dr. Automation", "7031111111", "test@test.mil", "other");

//                //Associate tab
//                UIActions.JSClickElement(startNewMMSO.MMSOAssociateMenuLinkButtonLinkText);
//                Thread.Sleep(8000);

//                UIActions.JSClickElement(startNewMMSO.MMSOAssociateFirstCase);
//                Thread.Sleep(1000);
//                UIActions.JSClickElement(startNewMMSO.MMSOAssociateSelectContinueButton);
//                Thread.Sleep(1000);

//                //Next Action
//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                Thread.Sleep(5000);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To State Admin MMSO Review");
//                Thread.Sleep(1000);
                                
//                if(UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
//                {
//                    throw new NoSuchElementException("Next Action Button disabled.");
//                }
//                else
//                {                     
//                    UIActions.JSClickElement(startNewMMSO.MMSONextActionSignButton);
//                    Thread.Sleep(2000);
//                }
//            }
//            finally
//            {
//                driverInit.TearDown();
//            }


//        }

//        public void StateAdmin(string edipin)
//        {
//            try
//            {
//                driverInit.InitWebdriver();
//                login.LoginMethod(edipin);
//                List<By> tabs = new List<By> { navMenu.EMMPSMenuBarID, navMenu.MMSOMenuBarLink, navMenu.MyPreauthMMSOLink };
//                MasterMenuNavigation.StartTabSelectionMethod(tabs);
//                Thread.Sleep(8000);
//                UIActions.JSClickElement(startNewMMSO.MyMMSOPageLink);
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxStatus, "State Admin MMSO Review (NG)");
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "NG Pre-Auth [Form 01]");
//                UIActions.JSClickElement(startNewMMSO.MMSOSearchMyFilterButton);
//                Thread.Sleep(3000);
//                //WaitMethods.Wait(LODCaseMenuNav.FilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                //WaitMethods.Wait(LODCaseMenuNav.FilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                startNewMMSO.ClickOnTheFirstCaseId();
//                Thread.Sleep(7000);
//                UIActions.JSClickElement(myLOD.MMSOFollowupCareMenuLinkButtonLinkText);
//                Thread.Sleep(3000);
                                
//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                Thread.Sleep(3000);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MMSO Contact Rep");
//                Thread.Sleep(2000);
                
//                if(UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
//                {
//                    throw new NoSuchElementException("Next Action Button disabled.");
//                }
//                else
//                {
//                    UIActions.JSClickElement(startNewMMSO.MMSONextActionSignButton);
//                    Thread.Sleep(2000);
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
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxStatus, "MMSO Contact Representative (NG)");
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "NG Pre-Auth [Form 01]");
//                UIActions.JSClickElement(startNewMMSO.MMSOSearchMyFilterButton);
//                Thread.Sleep(3000);
//                //WaitMethods.Wait(LODCaseMenuNav.FilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                //WaitMethods.Wait(LODCaseMenuNav.FilterByDateCreated);
//                UIActions.JSClickElement(startNewMMSO.MMSOFilterByDateCreated);
//                Thread.Sleep(3000);
//                startNewMMSO.ClickOnTheFirstCaseId();
//                Thread.Sleep(7000);
//                UIActions.JSClickElement(myLOD.MMSOFollowupCareMenuLinkButtonLinkText);
//                Thread.Sleep(3000);

//                startNewMMSO.UpdateMMSOFollowupCareTab("Routine Priority", "  Comeback in 2 weeks", "Test", "Test");

//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                Thread.Sleep(3000);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Complete Pre-Auth Case");
//                Thread.Sleep(2000);

//                if(UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
//                {
//                    throw new NoSuchElementException("Next Action Button disabled.");
//                }
//                else
//                {
//                    UIActions.JSClickElement(startNewMMSO.MMSONextActionSignButton);
//                    Thread.Sleep(2000);
//                }


//            }
//            finally
//            {
//                driverInit.TearDown();
//            }
//        }
//    }
//}
