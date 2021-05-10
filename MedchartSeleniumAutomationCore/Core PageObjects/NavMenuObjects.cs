using OpenQA.Selenium;

namespace MedchartSeleniumAutomationCore.Core_PageObjects
{
    public class NavMenuObjects
    {

        public By HomeMasterMenuBarCss = By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun0>table>tbody>tr>td>a");
        public By HomeMasterMenuBarID = By.Id("MasterMenun0");

        #region EMMPS   
        //-------------//
        //----EMMPS----//
        //-------------//
        public By eMMPSMasterMenuBarLink = By.XPath("//*[@id=|\"MasterMenun4\"]/table/tbody/tr/td[1]/a");
        public By EMMPSMenuBarXPath = By.XPath("//a[@class='MasterMenu_1 ModuleMenuParentItems MasterMenu_3'][contains(text(),'eMMPS')]");
        public By EMMPSMenuBarCss = By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun4>table>tbody>tr>td>a");
        public By EMMPSMenuBarClass = By.ClassName("MasterMenu_1 ModuleMenuParentItems MasterMenu_3");
        public By EMMPSMenuBarID = By.Id("MasterMenun4");

        //LOD
        public By LODMenuBarLink => By.XPath("/html/body/form/div[3]/div[2]/div/div/div[1]/table/tbody/tr[1]/td/table/tbody/tr/td[1]/a");                                      
        public By MyLODLink => By.XPath("//a[contains(text(),'My LODs')]");
        public By SearchLODLink => By.XPath("//a[contains(text(),'Search LODs')]");
        public By StartNewLODLink => By.XPath("//a[contains(text(),'Start New LOD')]");

        //MMSO
        public By MMSOMenuBarLink => By.LinkText("MMSO");
        public By MyPreauthMMSOLink => By.XPath("//a[contains(text(),'My Pre-Authorizations')]");
        public By SearchPreAuthLink => By.XPath("//a[contains(text(),'Search Pre-Authorizations')]");
        public By StartNewPreAuthLink => By.XPath("//a[contains(text(),'Start New Pre-Authorization')]");

        //INCAP
        public By INCAPMenuLink => By.LinkText("INCAP");
        public By MyINCAPMenuLink => By.XPath("//a[contains(text(),'My INCAPs')]");
        public By SearchINCAPMenuLink => By.XPath("//a[contains(text(),'Search INCAPs')]");
        public By StartINCAPMenuLink => By.XPath("//a[contains(text(),'Start INCAP')]");
        public By MyINCAPExtMenuLink => By.XPath("//a[contains(text(),'My INCAP Extensions')]");

        //PDHRA
        public By PDHRAMenuLink => By.XPath("//a[contains(text(),'PDHRA')]");
        public By SearchPDHRAReferralsMenuLink => By.XPath("//a[contains(text(),'Search PDHRA Referrals')]");

        //ADOP
        public By ADOPMenuLink => By.XPath("//a[contains(text(),'ADOP')]");
        public By MyADOPMenuLink => By.XPath("//a[contains(text(),'My ADOPs')]");
        public By SearchADOPMenuLink => By.XPath("//a[contains(text(),'Search ADOPs')]");
        public By StartNewADOPMenuLink => By.XPath("//a[contains(text(),'Start New ADOP')]");

        //Reports
        public By EMMPSReportsMenuLink => By.XPath("//a[contains(text(), 'Reports')]");
        public By LODReportsLink => By.XPath("//a[contains(text(), 'LOD')]");
        public By INCAPReportsLink => By.XPath("//a[contains(text(), 'INCAP')]");
        public By MMSOReportsLink => By.XPath("//a[contains(text(), 'MMSO')]");
        public By ADOPReportsLink => By.XPath("//a[contains(text(), 'ADOP')]");
        public By DashboardReportsLink => By.XPath("//a[contains(text(), 'eMMPS Dashboard')]");
        public By LODAdHocLink => By.XPath("//a[contains(text(), 'LOD Ad-Hoc')]");
        public By LODActivityLink => By.XPath("//a[contains(text(), 'LOD Activity')]");
        public By LODMatchReportLink => By.XPath("//a[contains(text(), 'LOD Match Report')]");
        public By INCAPFinancesAdHocLink => By.XPath("//a[contains(text(), 'INCAP Finances Ad-Hoc')]");
        public By INCAPExtAdHocMenuLink => By.XPath("//a[contains(text(), 'INCAP Extensions Ad-Hoc')]");
        public By MMSOReportMenuLink => By.XPath("//a[contains(text(), 'MMSO Report')]");
        public By ADOPAdHocMenuLink => By.XPath("//a[contains(text(), 'ADOP Ad-Hoc')]");
        public By EmmpsARDashboardReportLink => By.XPath("//a[contains(text(), 'eMMPS AR Dashboard')]");

        //Management Tools (Note sure if this is EMMPS Exclusive)
        public By ManagementToolsMenuLink => By.XPath("//a[contains(text(), 'Management Tools')]");
        public By ManagementToolsDocumentationMenuLink => By.XPath("//a[contains(text(), 'Documentation')]");
        public By RequestUICMenuLink => By.XPath("//a[contains(text(), 'Request UIC')]");
        public By ProgenyTreeLookupMenuLink => By.XPath("//a[contains(text(), 'Lookup MSC Progeny Tree')]");

        public By AdminToolsSubMenu => By.XPath("//a[contains(text(), 'Request UIC')]");
        //*[@id="MasterMenun16"]/td/table/tbody/tr/td/a

        #endregion

        #region AVS
        //DO OUT: Organize by menu tab

        public By AVSMenuBarID => By.Id("MasterMenun1");
        public By AVSMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun1>table>tbody>tr>td>a");
        public By IndividualVoucherMenuLink => By.XPath("//a[contains(text(), 'Individual Voucher')]");
        public By CreateIndividVoucherMenuLink => By.XPath("//a[contains(text(), 'Create')]");
        public By MassEventMenuLink => By.XPath("//a[contains(text(), 'Mass Event')]");
        public By CreateMassEventMenuLink => By.XPath("//a[contains(text(), 'Create')]");
        public By LookupAVSPOCMenuLink => By.XPath("//a[contains(text(), 'Lookup AVS POCs')]");
        public By ManageMyAVSPOCsUICMenuLink => By.XPath("//a[contains(text(), 'Manage My POCs UICs')]");
        public By AVSSearchMenuLink => By.XPath("//a[contains(text(), 'Search')]");
        public By AVSARNGHelpManualMenuLink => By.XPath("//a[contains(text(), 'ARNG Help Manual')]");

        #endregion

        #region HRR

        //DO OUT: Organize by menu tab
        public By HRRMasterMenuLink => By.Id("MasterMenun5");
        public By HRRMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun>table>tbody>tr>td>a");
        public By DocumentManagementMenuLink => By.XPath("//a[contains(text(),'Document Management')]");
        public By CompositeRetrievalMenuLink => By.XPath("//a[contains(text(),'Composite Retrieval')]");
        public By SoldierDocumentMenuLink => By.XPath("//a[contains(text(),'Soldier Documents')]");
        public By UploadDocumentBatchMenuLink => By.XPath("//a[contains(text(),'Upload/Scan Document or Batch')]");
        public By ValidatePendingDocsMenuLink => By.XPath("//a[contains(text(),'Validate Pending Documents')]");
        public By BatchManagementMenuLink => By.XPath("//a[contains(text(),'Batch Management')]");
        public By OrganizeBatchesMenuLink => By.XPath("//a[contains(text(),'Organize Batches')]");
        public By HRRReportsMenuMenuLink => By.XPath("//a[contains(text(), 'Reports')]");
        public By BTGAuditMenuLink => By.XPath("//a[contains(text(), 'BTG Audit Report')]");
        public By DocumentIndexReportlink => By.XPath("//a[contains(text(), 'Document Index Report')]");
        public By HAIMSSTRReportLink => By.XPath("//a[contains(text(), 'HRR HAIMS STR Report')]");
        public By SBHClassReportLink => By.XPath("//a[contains(text(), 'SBH Classification Change Report')]");
        public By ScanUsageReportLink => By.XPath("//a[contains(text(), 'Scan and Usage Report')]");
        public By AdministrativeTaskMenuLink => By.XPath("//a[contains(text(), 'Administrative Task')]");
        public By ManageSTRMenuLink => By.XPath("//a[contains(text(), 'Manage STR')]");
        public By HRRHelpMenuLink => By.XPath("//a[contains(text(), 'Help')]");
        public By AR4066MenuLink => By.XPath("//a[contains(text(), 'AR 40-66')]");
        public By TwainDriversMenuLink => By.XPath("//a[contains(text(), 'TWAIN Drivers')]");
        public By HRRUSARHelpManualMenuLink => By.XPath("//a[contains(text(), 'USAR Help Manual')]");

        #endregion

        #region Ecase
        //DO OUT: Organize by menu tab
        public By EcaseMenuBarID => By.Id("MasterMenun3");
        public By EcaseMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun4>table>tbody>tr>td>a");
        public By NewCaseMenuLink => By.XPath("//a[contains(text(), 'New Case')]");
        public By HAReferralsMenuLink => By.XPath("//a[contains(text(), 'HA Referrals')]");
        public By ReassignCasesMenuLink => By.XPath("//a[contains(text(), 'Reassign Cases')]");
        public By CaseListMenuLink => By.XPath("//a[contains(text(), 'Case List')]");
        public By TaskingSummaryMenuLink => By.XPath("//a[contains(text(), 'Tasking Summary')]");
        public By EcaseReportsMenuLink => By.XPath("//a[contains(text(), 'Reports')]");
        public By InsightsReportLink => By.XPath("//a[contains(text(), 'Insights')]");
        public By StatusReportLink => By.XPath("//a[contains(text(), 'Status')]");
        public By DispositionReportLink => By.XPath("//a[contains(text(), 'Disposition')]");
        public By CaseAgingReportLink => By.XPath("//a[contains(text(), 'Case Aging')]");
        public By DiagnosisReportLink => By.XPath("//a[contains(text(), 'Diagnosis')]");
        public By ExpirationReportLink => By.XPath("//a[contains(text(), 'Expiration')]");
        public By BoardReportLink => By.XPath("//a[contains(text(), 'Board')]");
        public By NonComplyReportLink => By.XPath("//a[contains(text(), 'Non-Compliance')]");
        public By HAReferralActionReportLink => By.XPath("//a[contains(text(), 'HA Referral Action')]");
        public By TaskTimelinessReportLink => By.XPath("//a[contains(text(), 'Task Timeliness')]");
        public By PermenantProfileReportLink => By.XPath("//a[contains(text(), 'Permenant Profile')]");
        public By LifecycleReportLink => By.XPath("//a[contains(text(), 'Lifecycle')]");
        public By BHReportsMenuLink => By.XPath("//a[contains(text(), 'BH Reports')]");
        public By MyBHReportsLink => By.XPath("//a[contains(text(), 'My Reports')]");
        public By UICAutoAssignMenuLink => By.XPath("//a[contains(text(), 'UIC Auto Assign')]");
        public By ECaseHelpManualMenuLink => By.XPath("//a[contains(text(), 'Help Manual')]");

        #endregion

        #region Denclass
        public By DenclassMenuBarID => By.Id("MasterMenun2");
        public By DenclassMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun2>table>tbody>tr>td>a");
        public By EventMenuLink => By.XPath("//a[contains(text(), 'Event')]");
        public By CreateEventMenuLink => By.XPath("//a[contains(text(), 'Create Event')]");
        public By EditEventMenuLink => By.XPath("//a[contains(text(), 'Edit Event')]");
        public By CreateUserGroupMenuLink => By.XPath("//a[contains(text(), 'Create User Group')]");
        public By EditUserGroupMenuLink => By.XPath("//a[contains(text(), 'Edit User Group')]");
        public By TreatmentPlanMenuLink => By.XPath("//a[contains(text(), 'Treatment Plan')]");
        public By CreateTreatmentPlanMenuLink => By.XPath("//a[contains(text(), 'Create Treatment Plan')]");
        public By ManageTreatmentPlanMenuLink => By.XPath("//a[contains(text(), 'Manage Treatment Plan')]");
        public By Upload2813MenuLink => By.XPath("//a[contains(text(), 'Upload 2813')]");
        public By UploadRadiographsMenuLink => By.XPath("//a[contains(text(), 'Upload Radiographs')]");
        public By ViewSoldierDocumentationMenuLink => By.XPath("//a[contains(text(), 'View Soldier Documentation')]");
        public By DenclassReportsMenuLink => By.XPath("//a[contains(text(), 'Reports')]");
        public By DentalReadinessReportLink => By.XPath("//a[contains(text(), 'Dental Readiness Report')]");
        public By DentalWorkloadSummaryReportLink => By.XPath("//a[contains(text(), 'Dental Workload Summary')]");
        public By EstimatedCostReportLink => By.XPath("//a[contains(text(), 'Estimated Cost Report')]");
        public By EventSummaryReportLink => By.XPath("//a[contains(text(), 'Event Summary Report')]");
        public By PendingTreatmentPlanReportLink => By.XPath("//a[contains(text(), 'Pending Treatment Plan')]");
        public By RadiographReportLink => By.XPath("//a[contains(text(), 'Radiograph Report')]");
        public By SF603ReportLink => By.XPath("//a[contains(text(), 'SF-603 Report')]");
        public By UserReportLink => By.XPath("//a[contains(text(), 'User Report')]");
        public By DocumentLibraryMenuLink => By.XPath("//a[contains(text(), 'Document Library')]");
        public By DenclassARNGHelpManualMenuLink => By.XPath("//a[contains(text(), 'ARNG Help Manual')]");

        #endregion

        #region MRR
        public By MRRMenuBarID => By.Id("MasterMenun7");
        public By MRRMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun7>table>tbody>tr>td>a");
        public By MrrMainMenuLink => By.XPath("//a[contains(text(), 'Main')]");
        public By MrrReportsLink => By.XPath("//a[contains(text(), 'Reports')]");
        public By DrillDownByUICReportLink => By.XPath("//a[contains(text(), 'Drill Down by UIC')]");
        public By DashboardsMenuLink => By.XPath("//a[contains(text(), 'Dashboards')]");
        public By ARMedicalReadinessDashMenuLink => By.XPath("//a[contains(text(), 'AR Medical Readiness Dashboard')]");
        public By ToolsMenuLink => By.XPath("//a[contains(text(), 'Tools')]");
        public By ComparisonToolMenulink => By.XPath("//a[contains(text(), 'Comparison Tool')]");
        public By TrendingToolMenuLink => By.XPath("//a[contains(text(), 'Trending Tool')]");
        public By MrrHelpManualMenuLink => By.XPath("//a[contains(text(), 'Help Manual')]");
        public By DataDefinitionsMenuLink => By.XPath("//a[contains(text(), 'Data Definitions')]");

        #endregion

        #region OH
        public By OHMenuBarID => By.Id("MasterMenun8");
        public By OHMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun8>table>tbody>tr>td>a");
        public By EmployeesMenuLink => By.XPath("//a[contains(text(), 'Employees')]");
        public By SearchEmployeesMenuLink => By.XPath("//a[contains(text(), 'Search Employees')]");
        public By ExamsMenuLink => By.XPath("//a[contains(text(), 'Exams')]");
        public By SearchExamsMenuLink => By.XPath("//a[contains(text(), 'Search Exams')]");
        public By OHReportsMenuLink => By.XPath("//a[contains(text(), 'Reports')]");
        public By CustomReportsLink => By.XPath("//a[contains(text(), 'Custom Reports')]");
        public By StandardReportsLink => By.XPath("//a[contains(text(), 'Standard Reports')]");
        public By HazardsProgramReportsLink => By.XPath("//a[contains(text(), 'Hazards Program Reports')]");
        public By FormsMenuLink => By.XPath("//a[contains(text(), 'Forms')]");
        public By EmployeeDemoTemplateMenuLink => By.XPath("//a[contains(text(), 'Employee Demographic Template')]");
        public By NonFOHContractorTemplateLink => By.XPath("//a[contains(text(), 'Contractor Non-FOH Template')]");
        public By SF600MenuLink => By.XPath("//a[contains(text(), 'SF600')]");
        public By SearchSF600MenuLink => By.XPath("//a[contains(text(), 'Search')]");
        public By SF600TemplateMenuLink => By.XPath("//a[contains(text(), 'Template')]");

        #endregion

        #region MATS
        public By MATSMenuBarID => By.Id("MasterMenun6");
        public By MATSMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun6>table>tbody>tr>td>a");
        public By MATSInboxMenuLink => By.XPath("//a[contains(text(), 'Inbox')]");
        public By CreateApplicantMenuLink => By.XPath("//a[contains(text(), 'Create Applicant')]");
        public By ApplicantSearchMenuLink => By.XPath("//a[contains(text(), 'Applicant Search')]");
        public By PolicyResourcesMenuLink => By.XPath("//a[contains(text(), 'Help/Policy Resources')]");
        public By MATSUserManualMenuLink => By.XPath("//a[contains(text(), 'User Manual')]");
        public By MATSReportsMenuLink => By.XPath("//a[contains(text(), 'Reports')]");
        public By AccessionWaiverReportLink => By.XPath("//a[contains(text(), 'Accession Waiver Report')]");
        public By ActionsTrendReportLink => By.XPath("//a[contains(text(), 'Actions Trend')]");
        public By AdHocReportLink => By.XPath("//a[contains(text(), 'Ad Hoc')]");
        public By MATSStatisticsReportLink => By.XPath("//a[contains(text(), 'MATS Statistics')]");
        public By RecentUseageReportLink => By.XPath("//a[contains(text(), 'My Recent Usage')]");
        public By PULHESReportLink => By.XPath("//a[contains(text(), 'PULHES Hearing and Eyes')]");
        public By StateLNOUsersReportLink => By.XPath("//a[contains(text(), 'State LNO Users')]");
        public By UsageReportLink => By.XPath("//a[contains(text(), 'Usage')]");
        public By ManageWorkspacesMenuLink => By.XPath("//a[contains(text(), 'Manage Workspaces')]");
        public By EditWorkspacesMenuLink => By.XPath("//a[contains(text(), 'Edit State Workspaces')]");
        public By ReassignWorkMenuLink => By.XPath("//a[contains(text(), 'Reassign Work')]");
        public By MATsAdministrationMenuLink => By.XPath("//a[contains(text(), 'MATS Administration')]");
        public By RegenRMSF507MenuLink => By.XPath("//a[contains(text(), 'Regenerate RM/SF-507')]");
        public By ManageICD10FavMenuLink => By.XPath("//a[contains(text(), 'Manage ICD-10 Favorites')]");

        #endregion
        #region Admin
        public By AdminMenuBarID => By.Id("MasterMenun12");
        public By AdminMenuBarXpath => By.XPath("//*[@id=\"MasterMenun12\"]/table/tbody/tr/td[1]/a");
        public By ViewAuditLogMenuLink => By.XPath("//*[@id=\"MasterMenun15\"]/td/table/tbody/tr/td/a");
        public By AdminMenuBarCss => By.CssSelector("table#MasterMenu>tbody>tr>td#MasterMenun11>table>tbody>tr>td>a");
        public By UserManagementMenuLink => By.XPath("//a[contains(text(), 'User Management')]");
        public By ManageActiveUserMenuLink => By.XPath("//a[contains(text(), 'Manage Active Users')]");
        public By ManageInactiveUserMenuLink => By.XPath("//a[contains(text(), 'Manage Inactive Users')]");
        public By UserLookupMenuLink => By.XPath("//a[contains(text(), 'User Lookup')]");       
        public By ImpersonateRoleMenuLink => By.XPath("//a[contains(text(), 'Impersonate Role')]");
        public By ViewAccessLogMenuLink => By.XPath("//a[contains(text(), 'View Access Log')]");
        public By ViewErrorLogMenuLink => By.XPath("//a[contains(text(), 'View Error Log')]");
        public By ManageMessagesMenuLink => By.XPath("//a[contains(text(), 'Manage Messages')]");
        public By SystemMenuLink => By.XPath("//a[contains(text(), 'System')]");
        public By ServBrokerActivityMenuLink => By.XPath("//a[contains(text(), 'Service Broker Activity')]");

        #endregion

        #region EMMPS Admin Tools
        public By EMMPSAdminTools => By.XPath("//*[@id=\"MasterMenun13\"]/td/table/tbody/tr/td[1]/a");        
        public By AdminTools => By.XPath("//*[@id=\"MasterMenun13\"]/td/table/tbody/tr/td[1]/a");
        public By ImpersonateUICProfile => By.XPath("//a[contains(text(), 'Impersonate UIC Profile')]"); 
        public By DAMPSInterfaceReports => By.XPath("//a[contains(text(), 'DAMPS Interfaces Reports')]");
        public By SystAdminManagement => By.XPath("//a[contains(text(), 'Sys Admin Management')]");
        public By Composite => By.XPath("//a[contains(text(), 'Composites')]");
        
        #endregion

    }
}
