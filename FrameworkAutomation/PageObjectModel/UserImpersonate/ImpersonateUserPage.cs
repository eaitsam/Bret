using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.PageObjectModel
{
    public class ImpersonateUserPage
    {
        public By StopImpersonating => By.Id("MEDCHARTContent_MedchartPagesContent_StopImpersonating");
        public By TileUserControl => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_3_updPopup");//("MEDCHARTContent_MedchartPagesContent_TileUserControl_3_updPopup");
        public By SelectAllTab => By.Id("MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_4_SelectAllPermissionsButton_UserControlLinkButton");
        public By Submitbutton => By.Id("MEDCHARTContent_MedchartPagesContent_SubmitButton");
        private By ImpersonateUserPageHeading => By.Id("impersonateUserPageHeading");
        public string GetImpersonateUserPageHeading() => UIActions.GetElement(ImpersonateUserPageHeading).Text;
        public string ImpersonateUserAccessDeniedMessageActual => "Access Denied.";
        public By ECaseSensitiveDataCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_2_ecasePermissionGroup_2_PermissionCheckBoxesDataList_PermissionCheckBox_0");
        public By logoutlink => By.Id("FixedLogout");
        public By SensitiveDataTab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_2");
        public By ManageCasesTab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_3");
        public By ReportsTab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_4");
        public By ImpHyperLink => By.Id("MEDCHARTContent_MedchartPagesContent_TileUserControl_2_ImpersonateRoleHyperLink");
        public By LeadMCMecasePermGrpTab => By.Id("__tab_MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_5");
        
       
        public By PermissionAmendmentsTab => By.Id("MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_4_ecasePermissionGroup_4_PermissionCheckBoxesDataList_PermissionCheckBox_0");
        // public By AdministatrivesupportSensitiveDataExpectedValues => By.Name("Break-the-glass");
        public By ECaseSensitiveData_Table => By.Id("MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_2_ecasePermissionGroup_2_PermissionCheckBoxesDataList");
        public By EcaseManageCases_Table => By.Id ("MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_3_ecasePermissionGroup_3_PermissionCheckBoxesDataList");
                                                    
        public By EcaseReports_Table => By.Id ( "MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_4_ecasePermissionGroup_4_PermissionCheckBoxesDataList");
                                                                                            
        
        
        public By eCaseAdmin_Table => By.Id ("MEDCHARTContent_MedchartPagesContent_PermissionAmendmentsTabContainer_ecasePermissionGroupTab_5_ecasePermissionGroup_5_PermissionCheckBoxesDataList" );
        

       
        
       
        
        

        

        
        private SearchFilterObjects _searchFilter;
        public ImpersonateUserPage()
        {
            _searchFilter = new SearchFilterObjects();
        }

       
    }
}
    
