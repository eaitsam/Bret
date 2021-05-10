using System.Collections.Generic;
using OpenQA.Selenium;
using System.Threading;
using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium.Support.UI;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;
using System;
using System.Data;

namespace EmmpsAutomation.PageObjectModel.Usermanagement
{
    public class EmmpsPermissions
    {
        #region Page Objects
        //EmmpsPermissionsTable was commented out because it could not be found for the permissions page
        //public IWebElement EmmpsPermissionsTable = Helpers.ObjectRepository.Driver.FindElement(By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList"));
        #region Permissions Buttons
        public By EmmpsPermissionsSelectAll => By.Id("MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_70_SelectAllPermissionsButton_UserControlLinkButton");
        public By PermissionSaveManageUsersButton => By.Id("btnUpdate");
        public By ManageUsersPermSubmitButton => By.XPath("/html/body/div[2]/div[3]/div/button[2]");
        public By ManageUsersPermSubmitandGoBackButton => By.XPath("/html/body/div[2]/div[3]/div/button[1]");

        #endregion
        #region LOD Permission Amendments
        public By EmmpsPermBaseID => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_");
        //these will be deleted once the method to iterate through the base id is completed, see SelectRolePermissions method for example
        public By DeleteLODCasesCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_0");
        public By DeleteRestrictedAssaultLODCasesCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_1");
        public By DeleteUnRestrictedAssaultLODCasesCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_2");
        public By LODAORCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_3");
        public By LODAppealOverrideCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_4");
        public By NGBApprovalLODAppealReviewCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_5");
        public By NGBJAGLODAppealReviewCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_6");
        public By NGBLODAppealReviewCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_7");
        public By NGBSurgeonApprovalLODAppealReviewCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_8");
        public By NGBSurgeonLODAppealReviewCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_9");
        public By OverrideDEMOBWTUFinalLODStatusCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_10");
        //public By OverrideFinalLODStatusCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_11");


        public By OverrideFinalLODStatusCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_71_eMMPS_PermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_5");

        public By OverrideLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_12");
        public By OverrideRestrictedLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_13");
        public By OverrideUnrestrictedLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_14");
        public By RestoreDeletedRestrictedAssaultLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_15");
        public By RestoreDeletedUnRestrictedAssaultLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_16");
        public By RestoreLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_17");
        public By SearchViewDeathLODsCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_18");
        public By SearchViewLODsCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_19");
        public By SearchViewRestrictedLODsCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_20");
        public By SearchViewUnRestrictedLODsCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_21");
        public By ViewDeletedLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_22");
        public By ViewDeletedRestrictedAssaultLODCasesCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_23");
        public By ViewDeletedUnRestrictedAssaultLODCasesCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_24");
        public By WriteTrackingCommentLODCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_25");

        #endregion
        #region Permissions Spans
        public By EMMPSAdministrationtab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_70");
        public By EmmpsLODtab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_71");
        public By EmmpsINCAPtab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_72");
        public By EmmpsPDHRAtab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_73");
        public By EmmpsMMSOtab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_74");
        public By EmmpsADOPtab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_75");
        public By EmmpsReportstab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_76");
        public By EmmpsMedChartAdmin => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_1");
        #endregion

        #region Permissions Tables
        public By EmmpsAdmin_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_70_eMMPS_PermissionGroup_70_PermissionCheckBoxesDataList");

        public By Lod_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_71_eMMPS_PermissionGroup_71_PermissionCheckBoxesDataList");
        public By InCap_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_72_eMMPS_PermissionGroup_72_PermissionCheckBoxesDataList");
        public By Pdhra_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_73_eMMPS_PermissionGroup_73_PermissionCheckBoxesDataList");
        public By MMSO_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_74_eMMPS_PermissionGroup_74_PermissionCheckBoxesDataList");
        public By ADOP_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_75_eMMPS_PermissionGroup_75_PermissionCheckBoxesDataList");
        public By Reports_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_76_eMMPS_PermissionGroup_76_PermissionCheckBoxesDataList");
        public By MedChartAdmin_TabTable => By.Id("MEDCHARTContent_MedchartPagesContent_eMMPS_PermissionAmendmentsTabContainer_eMMPS_PermissionGroupTab_1_eMMPS_PermissionGroup_1_PermissionCheckBoxesDataList");

        #endregion

        #region Manage Users
        public By ManageUsersTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_EdipnTextBox");
        public By ManageUsersSearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_StartSearch");
        public By ManageUsersOrgdropdown => By.Id("MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList");

        public By LODPermAmmendTab => By.Id("__tab_PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71");


        public By MUOverrideFinalLODStatus => By.Id("PermissionAmendmentsTabContainer_emmpsPermissionGroupTab_71_emmpsPermissionGroup_71_PermissionCheckBoxesDataList_PermissionCheckBox_5");

        #endregion
        #endregion

        public abstract class EmmpsPermObject
        {
            public abstract By GetRolesDataListContainer();
            public abstract By GetModuleSelectButton();
            public abstract List<By> GetListOfRolesCheckBox();
        }

        public class DefaultModuleObject : EmmpsPermObject
        {
            public override By GetRolesDataListContainer()
            {
                return null;
            }

            public override By GetModuleSelectButton()
            {
                return null;
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return null;
            }
        }

        public class AVSModuleObject : EmmpsPermObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_0");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_0");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_0_MessageRoleCheckBox_0"), // ModuleARNGManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_0_MessageRoleCheckBox_1"), // ModuleARNGApprovalAuthRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_0_MessageRoleCheckBox_2"), // ModuleARNGUnitAdminRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_0_MessageRoleCheckBox_3"), // ModuleARNGPDHRAManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_0_MessageRoleCheckBox_4")  // ModuleARNGPDHRACoordRoleCheckBox
                };
            }
        }

        public class DenClassModuleObject : EmmpsPermObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_1");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_0"), // DenClassModuleARNGManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_1"), // DenClassModuleDeputyStateSurgRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_2"), // DenClassModuleStateDentalTechRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_3"), // DenClassModuleContractDentalTechRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_4"), // DenClassModuleHealthCareSpecRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_5"), // DenClassModuleStateDentistRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_6"), // DenClassModuleContractDentistRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_1_MessageRoleCheckBox_7")  // DenClassModuleStateDentalOfficerRoleCheckBox
                };
            }
        }



        //public void SearchManageUsers(string organization)
        //{
        //Homepage homepage = new Homepage();
        //GlobalShared global = new GlobalShared();

        //    UIActions.ClickElement(homepage.ManageUsersLink);
        //    switch (organization)
        //    {
        //        case "NG":
        //            {
        //                UIActions.SelectElementByValue(global.OrgCombobox, "National Guard");
        //                UIActions.JSClickElement(global.SearchButton);
        //                UIActions.JSClickElement(global.muFirstUserLink);
        //                break;
        //            }
        //        case "AR":
        //            {
        //                UIActions.SelectElementByValue(global.OrgCombobox, "Army Reserve");
        //                UIActions.JSClickElement(global.SearchButton);
        //                UIActions.JSClickElement(global.muFirstUserLink);

        //                break;
        //            }
        //        case "Cross-Com":
        //            {

        //                UIActions.SelectElementByValue(global.OrgCombobox, "Cross - Component");
        //                UIActions.JSClickElement(global.SearchButton);
        //                UIActions.JSClickElement(global.muFirstUserLink);

        //                break;
        //            }
        //        case "DEMOB":
        //            {
        //                UIActions.SelectElementByValue(global.OrgCombobox, "DEMOB / WTU Cross - Component");
        //                UIActions.JSClickElement(global.SearchButton);
        //                UIActions.JSClickElement(global.muFirstUserLink);
        //                break;
        //            }
        //        default:
        //            break;
        //    }

        //}



        //public void ClickPermisionTab(string tab, bool manageUser)
        //{
        //    if (manageUser)
        //    {
        //        WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(40))
        //        {
        //            PollingInterval = TimeSpan.FromMilliseconds(100)
        //        };
        //        wait.Until(condition => ObjectRepository.Driver.WindowHandles.Count > 1);

        //        string mainWindow = ObjectRepository.Driver.CurrentWindowHandle;
        //        foreach (string handle in ObjectRepository.Driver.WindowHandles)
        //        {
        //            if (handle != mainWindow)
        //            {
        //                ObjectRepository.Driver.SwitchTo().Window(handle);
        //                break;
        //            }
        //        }
        //    }

        //    if (manageUser)
        //    {
        //        switch (tab)
        //        {
        //            case "LOD":
        //                {
        //                    UIActions.JSClickElement(PermissionAdminLodTab);
        //                    break;
        //                }
        //            case "INCAP":
        //                {
        //                    UIActions.JSClickElement(PermissionAdminIncapTab);
        //                    break;
        //                }
        //            case "PDHRA":
        //                {
        //                    UIActions.JSClickElement(PermissionAdminPdhraTab);
        //                    break;
        //                }
        //            case "MMSO":
        //                {
        //                    UIActions.JSClickElement(PermissionAdminMmsoTab);
        //                    break;
        //                }
        //            case "ADOP":
        //                {
        //                    UIActions.JSClickElement(PermissionAdminAdopTab);
        //                    break;
        //                }
        //            case "Reports":
        //                {
        //                    UIActions.JSClickElement(PermissionAdminReportsTab);
        //                    break;
        //                }
        //            case "EMMPS":
        //                {
        //                    UIActions.JSClickElement(PermissionAdminEmmpsTab);
        //                    break;
        //                }

        //        }

        //        //ObjectRepository.Driver.Close();
        //        //ObjectRepository.Driver.SwitchTo().Window(mainWindow);
        //    }
        //    else
        //    {
        //        switch (tab)
        //        {
        //            case "LOD":
        //                {
        //                    UIActions.JSClickElement(PermissionLodTab);
        //                    break;
        //                }
        //            case "INCAP":
        //                {
        //                    UIActions.JSClickElement(PermissionIncapTab);
        //                    break;
        //                }
        //            case "PDHRA":
        //                {
        //                    UIActions.JSClickElement(PermissionPdhraTab);
        //                    break;
        //                }
        //            case "MMSO":
        //                {
        //                    UIActions.JSClickElement(PermissionMmsoTab);
        //                    break;
        //                }
        //            case "ADOP":
        //                {
        //                    UIActions.JSClickElement(PermissionAdopTab);
        //                    break;
        //                }
        //            case "Reports":
        //                {
        //                    UIActions.JSClickElement(PermissionReportsTab);
        //                    break;
        //                }
        //            case "EMMPS":
        //                {
        //                    UIActions.JSClickElement(PermissionEmmpsTab);
        //                    break;
        //                }

        //        }
        //    }

        //}


        ///// <summary>
        ///// Used by Admin Users to set permissions for Users DIV(R) user
        ///// </summary>
        ///// <param name="permission"></param>
        ///// <param name="hasPermission"></param>
        //public void VerifyUserPermissionByAdmin(string permission, bool hasPermission, string updateUserType)
        //{
        //    bool currentlyHasPermission = false;
        //    var permissionCheckbox = PermissionAdminOverrideFinalLODStatus;
        //    switch (updateUserType)
        //    {
        //        case "DIV(R) Admin":
        //            {
        //                currentlyHasPermission = UIValidations.IsElementSelected(PermissionAdminOverrideFinalLODStatus);
        //                permissionCheckbox = PermissionAdminOverrideFinalLODStatus;
        //                break;
        //            }

        //        case "eMMPS ARNG Manager":
        //            {
        //                currentlyHasPermission = UIValidations.IsElementSelected(PermissionAdminOverrideFinalLODStatusForEmmpsManager);
        //                permissionCheckbox = PermissionAdminOverrideFinalLODStatusForEmmpsManager;
        //                break;
        //            }
        //        case "NGB Reviewer":
        //            {
        //                currentlyHasPermission = UIValidations.IsElementSelected(PermissionAdminOverrideFinalLODStatusForNGBReviewer);
        //                permissionCheckbox = PermissionAdminOverrideFinalLODStatusForNGBReviewer;
        //                break;
        //            }
        //    }

        //    if (permission == "Override Final LOD Status" && !hasPermission)
        //    {
        //        if (currentlyHasPermission)
        //        {
        //            //deselect permmission
        //            UIActions.JSClickElement(permissionCheckbox);
        //            UIActions.JSClickElement(PermissionSaveManageUsersButton);
        //            Thread.Sleep(3000);
        //            UIActions.JSClickElement(PermissionSubmitButton);
        //            Thread.Sleep(3000);
        //        }

        //    }
        //    else if (permission == "Override Final LOD Status" && hasPermission)
        //    {
        //        if (!currentlyHasPermission)
        //        {
        //            //select permmission
        //            UIActions.JSClickElement(permissionCheckbox);
        //            UIActions.JSClickElement(PermissionSaveManageUsersButton);
        //            Thread.Sleep(3000);
        //            UIActions.JSClickElement(PermissionSubmitButton);
        //            Thread.Sleep(3000);
        //        }

        //    }
        //}




        //public void VerifyUserPermission(bool hasPermission, string permission, string userType)
        //{

        //    if (permission == "Override Final LOD Status" && userType == "DIV(R) Admin")
        //    {
        //        if (hasPermission)
        //        {
        //            Assert.True(UIValidations.IsElementSelected(PermissionOverrideFinalLODStatus));
        //        }
        //        else
        //        {
        //            Assert.False(UIValidations.IsElementSelected(PermissionOverrideFinalLODStatus));
        //        }

        //    }
        //    else if (permission == "Override Final LOD Status" && userType == "eMMPS ARNG Manager")
        //    {
        //        if (hasPermission)
        //        {
        //            Assert.True(UIValidations.IsElementSelected(PermissionOverrideFinalLODStatusForEmmpsManager));
        //        }
        //        else
        //        {
        //            Assert.False(UIValidations.IsElementSelected(PermissionOverrideFinalLODStatusForEmmpsManager));
        //        }

        //    }
        //    else if (permission == "Override Final LOD Status" && userType == " NGB Reviewer")
        //    {
        //        if (hasPermission)
        //        {
        //            Assert.True(UIValidations.IsElementSelected(PermissionOverrideFinalLODStatusForNGBReviewer));
        //        }
        //        else
        //        {
        //            Assert.False(UIValidations.IsElementSelected(PermissionOverrideFinalLODStatusForNGBReviewer));
        //        }

        //    }

        //}

        public void MyAccountPermsTabValidation(List<string> perm)
        {
            string[] permOutput = perm.ToString().Split('|');
            string permString = permOutput[3];
            permOutput = permString.Split(',');

            foreach (var tabName in permOutput)
            {
                string trimString = tabName.Trim();
                switch (trimString) //First & Last case do not work because tabs have uneeded stuff
                {
                    case "eMMPS Administration":
                        //Clicks on tab and asserts it exists
                        Assert.True(UIActions.IsElementPresent(EMMPSAdministrationtab));
                        break;
                    case "LOD":
                        Assert.True(UIActions.IsElementPresent(EmmpsLODtab));
                        break;
                    case "INCAP":
                        Assert.True(UIActions.IsElementPresent(EmmpsINCAPtab));
                        break;
                    case "PDHRA":
                        Assert.True(UIActions.IsElementPresent(EmmpsPDHRAtab));
                        break;
                    case "MMSO":
                        Assert.True(UIActions.IsElementPresent(EmmpsMMSOtab));
                        break;
                    case "ADOP":
                        Assert.True(UIActions.IsElementPresent(EmmpsADOPtab));
                        break;
                    case "Reports":
                        Assert.True(UIActions.IsElementPresent(EmmpsReportstab));
                        break;
                    case "MEDCHART Administration":
                        Assert.True(UIActions.IsElementPresent(EmmpsMedChartAdmin));
                        break;
                    default:
                        
                        break;
                }

            }

        }


        public void EmmpsMyAccountPermissionsValidation(string modulename, DataTable perm)
        {
            //EmmpsPermissions PermPage = new EmmpsPermissions();
            IWebElement webElmTable = null;

            //figuring out which tab we are checking and taking the data from it
            switch (modulename)
            {
                case "eMMPS Administration":
                    UIActions.ClickElement(EMMPSAdministrationtab);
                    webElmTable = UIActions.GetElement(EmmpsAdmin_TabTable);
                    break;
                case "LOD":
                    UIActions.ClickElement(EmmpsLODtab);
                    webElmTable = UIActions.GetElement(Lod_TabTable);
                    break;
                case "INCAP":
                    UIActions.ClickElement(EmmpsINCAPtab);
                    webElmTable = UIActions.GetElement(InCap_TabTable);
                    break;
                case "PDHRA":
                    UIActions.ClickElement(EmmpsPDHRAtab);
                    webElmTable = UIActions.GetElement(Pdhra_TabTable);
                    break;
                case "MMSO":
                    UIActions.ClickElement(EmmpsMMSOtab);
                    webElmTable = UIActions.GetElement(MMSO_TabTable);
                    break;
                case "ADOP":
                    UIActions.ClickElement(EmmpsADOPtab);
                    webElmTable = UIActions.GetElement(ADOP_TabTable);
                    break;
                case "Reports":
                    UIActions.ClickElement(EmmpsReportstab);
                    webElmTable = UIActions.GetElement(Reports_TabTable);
                    break;
                case "MEDCHART Administration":
                    UIActions.ClickElement(EmmpsMedChartAdmin);
                    webElmTable = UIActions.GetElement(MedChartAdmin_TabTable);
                    break;
            }
            Thread.Sleep(3000);
            webElmTable = webElmTable.FindElement(By.TagName("tbody"));//gets the body of the table
            IReadOnlyList<IWebElement> pageData = webElmTable.FindElements(By.XPath(".//*"));

            //there are 19 data points in pageData for each row
            //          11 if there is only one permission in the row
            //each row has up to two permissions
            int numPerm = 0;
            if (pageData.Count % 19 != 0)
            { //if odd number of permissions on the page
                int x = pageData.Count - 11;
                numPerm = ((x / 19) * 2) + 1;
            }
            else
            {
                numPerm = (pageData.Count / 19) * 2;
            }

            Assert.Equal(perm.Rows.Count, numPerm);

            //looping through to pull out all the relevant data
            List<IWebElement> permPairs = new List<IWebElement>();
            int g = 5;
            int s = 0;
            for (int l = 0; l < numPerm * 2; l++)
            {
                permPairs.Insert(l, pageData[g + 1]);
                l++;
                permPairs.Insert(l, pageData[g]);
                if (s == 0)
                {
                    s = 1;
                    g += 9;
                }
                else
                {
                    s = 0;
                    g += 10;
                }
            }

            IWebElement checkbox = null;
            bool exists = false;
            for (int i = 0; i < numPerm; i++)
            {

                for (int j = 0; j < numPerm * 2; j += 2)
                {
                    exists = false;
                    if (perm.Rows[i][0].Equals(permPairs[j].Text))
                    {
                        exists = true;
                        checkbox = permPairs[j + 1];
                        break;
                    }
                }
                Assert.True(exists);

                //Checking that the box is disabled
                Assert.NotNull(checkbox.GetAttribute("disabled"));

                //has cell, is checkbox valid
                if (perm.Rows[i][2].Equals("D"))
                {
                    //need checked box that is disabled
                    Assert.NotNull(checkbox.GetAttribute("checked"));
                }
                else
                {
                    //need unchecked box that is disabled
                    Assert.Null(checkbox.GetAttribute("checked"));
                }
            }
        }



    }
}