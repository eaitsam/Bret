﻿//using System;
//using OpenQA.Selenium;
//using System.Collections.Generic;
//using System.Threading;
//using System.IO;
//using Xunit;
//using MedchartSeleniumAutomationCore.Core_Tools;
//using MedchartSeleniumAutomationCore.Core_Settings;
//using MedchartSeleniumAutomationCore.Core_Framework;
//using MedchartSeleniumAutomationCore.Core_Shared_Methods;
//using MedchartSeleniumAutomationCore.Core_PageObjects;
//using EmmpsAutomation.PageObjectModel.LOD;
//using EmmpsAutomation.PageObjectModel.MMSO;

//namespace EMMPSDataseed.Workflows.MMSO
//{
//    public class NGSurgicalPreAuth
//    {
//        //Test Script 55344

//        #region Page Objects
//        //---------------------------------------------------------------------------------------------//
//        //Objects are organized by HTML Tag type in their own #region tags
//        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
//        //---------------------------------------------------------------------------------------------//



//        #endregion

//        string fileName = "NGSurgicalPreAuth.xlsx";
//        private string currentId = string.Empty;


//        readonly BaseDriverInit driverInit;
//        readonly Login login;
//        readonly StartNewLODPage startNewLOD;
//        readonly NavMenuObjects navMenu;
//        readonly MyLODMenuNav myLOD;
//        readonly MiscPageOjects misc;
//        readonly MMSOPage startNewMMSO;
//        readonly LODNextActionTab nextActionTab;

//        public NGSurgicalPreAuth()
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
//        public void NGSurgicalPreAuthStartMMSO()
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
//        public void NGSurgicalPreAuthStateAdmin()
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
//        public void NGSurgicalPreAuthMMSOReviewer()
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
//                WaitMethods.Wait(startNewMMSO.SsnBox, 60);
//                startNewMMSO.MMSOSoldierSSNSearch(id);
//                UIActions.SelectElementByText(startNewMMSO.MMSOWorkflowDropDownBox, "NG Surgical Pre-Auth [Form 06]");
//                //Wait for worksheet to show
//                WaitMethods.Wait(startNewMMSO.MMSOExistingWorkSheetsLabel, 60);
//                UIActions.JSClickElement(startNewMMSO.EligibleLODsAssociateMMSOCheckBox);
//                WaitMethods.Wait(startNewMMSO.CreateMMSOButton, 60);
//                Thread.Sleep(500);
//                UIActions.JSClickElement(startNewMMSO.CreateMMSOButton);
//                Thread.Sleep(8000);

//                //section II Surgery and Durable Medical Equipment (DME) Information
//                startNewMMSO.UpdateSurgeryInformationForm06("-65", "25", "Automation Test", "C162", "43501");

//                //Section III Current Unit Point of Contact Information
//                startNewMMSO.UpdateCurrentUnitPointOfContactInformationForm06("Mr.Smith", "Automation", "7031111111", "7031112222");

//                UIActions.JSClickElement(myLOD.LODNextActionMenuLinkButtonLinkText);
//                Thread.Sleep(1000);
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To State Admin MMSO Review");
//                Thread.Sleep(2000);

//                if (UIActions.IsNextActionButtonDisabled(startNewMMSO.MMSONextActionSignButton))
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
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "NG Surgical Pre-Auth [Form 06]");
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
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, "NG Surgical Pre-Auth [Form 06]");
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
//                UIActions.SelectElementByText(nextActionTab.NextActionControlDropDownList, "Forward To MMSO Nurse");
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
//            catch (Exception ex)
//            {
//                //DebuggingHelpers.LogWorkflowError(ex, "NGSurgicalPreAuth MMSOReviewer", edipin, currentId);
//                throw;
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
//                Thread.Sleep(8000);
//                UIActions.JSClickElement(startNewMMSO.MyMMSOPageLink);
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxStatus, "MMSO Nurse (NG)");
//                UIActions.SelectElementByText(startNewMMSO.MMSOComboBoxWorkflow, " NG Surgical Pre-Auth [Form 06]");
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
//            catch (Exception ex)
//            {
//                //DebuggingHelpers.LogWorkflowError(ex, "NGSurgicalPreAuth MMSONurse", edipin, currentId);
//                throw;
//            }
//            finally
//            {
//                driverInit.TearDown();
//            }
//        }
//    }
//}
