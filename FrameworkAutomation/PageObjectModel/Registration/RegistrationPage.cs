using System.Collections.Generic;
using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;

namespace FrameworkAutomation.PageObjectModel
{
    public class RegistrationPage
    {
        Dictionary<string, By> AVSRoles = new Dictionary<string, By>();
        Dictionary<string, By> DenClassRoles = new Dictionary<string, By>();
        Dictionary<string, By> eCaseRoles = new Dictionary<string, By>();
        Dictionary<string, By> EmmpsRoles = new Dictionary<string, By>();
        Dictionary<string, By> HRRRoles = new Dictionary<string, By>();
        Dictionary<string, By> MATSRoles = new Dictionary<string, By>();
        Dictionary<string, By> MRRRoles = new Dictionary<string, By>();
        Dictionary<string, By> OHRoles = new Dictionary<string, By>();

        public RegistrationPage()
        {
            //Add All Roles to the Module's Dictionarys
            AVSAddRoles();
            DenClassAddRoles();
            eCaseAddRoles();
            EmmpsAddRoles();
            MATSAddRoles();
            MRRAddRoles();
            OHAddRoles();
        }

        #region Base Page Elements
        #region Page Objects
                #region Textboxes
                    public By FirstNameTextbox = By.Id("MEDCHARTContentCACOnly_FirstNameTextBox");
                    public By MiddleNameTextbox = By.Id("MEDCHARTContentCACOnly_MiddleNameTextBox");
                    public By LastNameTextbox = By.Id("MEDCHARTContentCACOnly_LastNameTextBox");
                    public By PrimaryPhoneTextbox = By.Id("MEDCHARTContentCACOnly_PrimaryPhoneTextBox");
                    public By PrimaryPhoneExtensionTextbox = By.Id("MEDCHARTContentCACOnly_PrimaryPhoneExt");
                    public By EmailTextbox = By.Id("MEDCHARTContentCACOnly_EmailTextBox");
                    public By DSNTextbox = By.Id("MEDCHARTContentCACOnly_DSNTextBox");
                    public By SecondaryPhoneTextbox = By.Id("MEDCHARTContentCACOnly_SecondaryPhoneTextBox");
                    public By SecondaryPhoneExtensionTextbox = By.Id("MEDCHARTContentCACOnly_SecondaryPhoneExt");
                #endregion
                #region ComboBoxs
                    public By RankCombobox = By.Id("MEDCHARTContentCACOnly_RankDropDownList");
                #endregion
                #region Buttons
                    public By CancelButton = By.Id("MEDCHARTContentCACOnly_CancelButton");
                    public By NextButton = By.Id("MEDCHARTContentCACOnly_NextButton");
                    public By SubmitButton = By.Id("UserDetailsModalSubmitButton");
                    public By ChooseFileButton = By.Id("MEDCHARTContentCACOnly_ucFileUpload_file");
                #endregion
                #region Divs
                    public By MedchartPageTitle = By.Id("MedchartPageTitle");
                    public By FeedbackSuccess = By.Id("feedback");
                #endregion
                #region Spans
                    public By AVSModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8");
                    public By DenClassModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3");
                    public By eCaseModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1");
                    public By eMMPSModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7");
                    public By HRRModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6");
                    public By MATSModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5");
                    public By MRRModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4");
                    public By OHModuleTab = By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2");
                #endregion
                #region Links
                    public By UploadExistingCertificateLink = By.LinkText("Upload Existing Certificate");
                    public By HIPAATrainingAndExamLink = By.Id("MEDCHARTContent_MedchartPagesContent_RCCBTLink");
        #endregion
        #region Validators
        public By RankValidator = By.Id("MEDCHARTContentCACOnly_RankDropDownListCompareValidator");
                    public By FirstNameValidator = By.Id("MEDCHARTContentCACOnly_FirstNameValidatorCalloutExtender_popupTable");
                    public By EmailValidator = By.Id("MEDCHARTContentCACOnly_EmailRequiredValidatorCalloutExtender_popupTable");
                    public By LastNameValidator = By.Id("MEDCHARTContentCACOnly_LastNameCalloutExtender_popupTable");
                    public By PhoneValidator = By.Id("MEDCHARTContentCACOnly_PrimaryPhoneRequiredCalloutExtender_popupTable");
                    public By RoleSelectedValidator = By.Id("MEDCHARTContentCACOnly_RoleSelectionRequiredMessageLabel");
                #endregion
        #endregion
        #region Page Methods
            private void SelectCheckbox(By roleCheckbox)
            {
                if ((UIActions.GetElement(roleCheckbox).GetAttribute("checked") == null))
                    UIActions.JSClickElement(roleCheckbox);
            }
        #endregion
        #endregion

        #region AVS
            #region Page Objects
                #region Comboboxes
                    public By AVSOrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_OrganizationDropDownList");
                    public By AVSRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_RegionDropDownList");
                #endregion
                #region Checkboxes
                    // AVS
                    public By AVSRoleARNGApprovalAuthorityCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By AVSRoleARNGUnitAdministratorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By AVSRoleARNGPDHRACoordinatorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");

                    public By AVSRoleUSARApprovalAuthorityCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By AVSRoleUSARUnitAdministratorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By AVSRoleUSARDHAPCoordinatorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");

                    public By AVSRoleDHAPServiceProviderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By AVSRoleRHRPServiceProviderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By AVSRoleRHRPCallCenterCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_avsModuleTab_8_avsModuleTabUserControl_8_avsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                #endregion
            #endregion
            #region Page Methods
                public void AVSChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = AVSRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void AVSAddRoles()
                {
                    //Create Roles Dictionary For AVS
                    AVSRoles.Add("ARNG Approval Authority", AVSRoleARNGApprovalAuthorityCheckbox);
                    AVSRoles.Add("ARNG Unit Administrator", AVSRoleARNGUnitAdministratorCheckbox);
                    AVSRoles.Add("ARNG PDHRA Coordinator", AVSRoleARNGPDHRACoordinatorCheckbox);
                    AVSRoles.Add("USAR Approval Authority", AVSRoleUSARApprovalAuthorityCheckbox);
                    AVSRoles.Add("USAR Unit Administrator", AVSRoleUSARUnitAdministratorCheckbox);
                    AVSRoles.Add("USAR DHAP Coordinator", AVSRoleUSARDHAPCoordinatorCheckbox);
                    AVSRoles.Add("DHAP Service Provider", AVSRoleDHAPServiceProviderCheckbox);
                    AVSRoles.Add("RHRP Service Provider", AVSRoleRHRPServiceProviderCheckbox);
                    AVSRoles.Add("RHRP Call Center", AVSRoleRHRPCallCenterCheckbox);
                }
            #endregion
        #endregion

        #region DenClass
            #region Page Objects
                #region Comboboxes
                    public By DenClassOrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_OrganizationDropDownList");
                    public By DenClassRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_RegionDropDownList");
                #endregion
                #region Checkboxes
                    // DenClass
                    public By DenClassRoleContractDentalTechCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By DenClassRoleContractDentistCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By DenClassRoleDeputyStateSurgeonCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By DenClassRoleHealthCareSpecialistCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By DenClassRoleStateDentalOfficerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By DenClassRoleStateDentalTechCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By DenClassRoleStateDentistCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");

                    public By DenClassRoleUSARDentalTechCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By DenClassRoleUSARDentistCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");

                    public By DenClassRoleRHRPDentalOfficerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By DenClassRoleRHRPDentalTechCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By DenClassRoleRHRPDentistCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_denclassModuleTab_3_denclassModuleTabUserControl_3_denclassRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                #endregion
            #endregion
            #region Page Methods
                public void DenClassChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = DenClassRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void DenClassAddRoles()
                {
                    //Create Roles Dictionary For DenClass
                    DenClassRoles.Add("Contract Dental Tech", DenClassRoleContractDentalTechCheckbox);
                    DenClassRoles.Add("Contract Dentist", DenClassRoleContractDentistCheckbox);
                    DenClassRoles.Add("Deputy State Surgeon", DenClassRoleDeputyStateSurgeonCheckbox);
                    DenClassRoles.Add("Health Care Specialist", DenClassRoleHealthCareSpecialistCheckbox);
                    DenClassRoles.Add("State Dental Officer", DenClassRoleStateDentalOfficerCheckbox);
                    DenClassRoles.Add("State Dental Tech", DenClassRoleStateDentalTechCheckbox);
                    DenClassRoles.Add("State Dentist", DenClassRoleStateDentistCheckbox);
                    DenClassRoles.Add("USAR Dental Tech", DenClassRoleUSARDentalTechCheckbox);
                    DenClassRoles.Add("USAR Dentist", DenClassRoleUSARDentistCheckbox);
                    DenClassRoles.Add("RHRP Dental Officer", DenClassRoleRHRPDentalOfficerCheckbox);
                    DenClassRoles.Add("RHRP Dental Tech", DenClassRoleRHRPDentalTechCheckbox);
                    DenClassRoles.Add("RHRP Dentist", DenClassRoleRHRPDentistCheckbox);
                }
            #endregion
        #endregion

        #region eCase
            #region Page Objects
                #region Textboxes
                    public By eCaseIssuingClinicTextbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseIssuingClinicCredentials_IssuingClinicTextBox");
                #endregion
                #region Comboboxes
                    public By eCaseOrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_OrganizationDropDownList");
                    public By eCaseRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_RegionDropDownList");
                    public By eCaseCredentialsCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseIssuingClinicCredentials_CredentialsDropDownList");
                #endregion
                #region Checkboxes
                    // eCase
                    public By eCaseRoleNGAdministrativeSupportCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By eCaseRoleNGAuditorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By eCaseRoleDSSCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By eCaseRoleLeadMCMCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By eCaseRoleMedicalCaseManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By eCaseRoleMedicalReadinessNCOCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By eCaseRoleNGProviderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                    public By eCaseRoleStateBHOReportingCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_7");
                    public By eCaseRoleUnitAdministratorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_8");

                    public By eCaseRoleARAdministrativeSupportCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By eCaseRoleARAuditorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By eCaseRoleLeadNurseCaseManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By eCaseRoleMedicalReviewerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By eCaseRoleNurseCaseManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By eCaseRoleARProviderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By eCaseRoleSupervisorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                #endregion
            #endregion
            #region Page Methods
                public void eCaseChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = eCaseRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void eCaseAddRoles()
                {
                    //Create Roles Dictionary For eCase
                    eCaseRoles.Add("NG Administrative Support", eCaseRoleNGAdministrativeSupportCheckbox);
                    eCaseRoles.Add("NG Auditor", eCaseRoleNGAuditorCheckbox);
                    eCaseRoles.Add("DSS", eCaseRoleDSSCheckbox);
                    eCaseRoles.Add("Lead MCM", eCaseRoleLeadMCMCheckbox);
                    eCaseRoles.Add("Medical Case Manager", eCaseRoleMedicalCaseManagerCheckbox);
                    eCaseRoles.Add("Medical Readiness NCO", eCaseRoleMedicalReadinessNCOCheckbox);
                    eCaseRoles.Add("NG Provider", eCaseRoleNGProviderCheckbox);
                    eCaseRoles.Add("State BHO Reporting", eCaseRoleStateBHOReportingCheckbox);
                    eCaseRoles.Add("Unit Administrator", eCaseRoleUnitAdministratorCheckbox);
                    eCaseRoles.Add("AR Administrative Support", eCaseRoleARAdministrativeSupportCheckbox);
                    eCaseRoles.Add("AR Auditor", eCaseRoleARAuditorCheckbox);
                    eCaseRoles.Add("Lead Nurse Case Manager", eCaseRoleLeadNurseCaseManagerCheckbox);
                    eCaseRoles.Add("Medical Reviewer", eCaseRoleMedicalReviewerCheckbox);
                    eCaseRoles.Add("Nurse Case Manager", eCaseRoleNurseCaseManagerCheckbox);
                    eCaseRoles.Add("AR Provider", eCaseRoleARProviderCheckbox);
                    eCaseRoles.Add("Supervisor", eCaseRoleSupervisorCheckbox);
                }
            #endregion
        #endregion

        #region Emmps
            #region Page Objects
                #region Comboboxes
                    public By eMMPSOrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_OrganizationDropDownList");
                    public By eMMPSRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_RegionDropDownList");
                #endregion
                #region Checkboxes
                    // eMMPS
                    public By eMMPSRoleNGBReviewerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By eMMPSRoleNGBSurgeonCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By eMMPSRoleNGBJAGCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By eMMPSRoleNGBOversightCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By eMMPSRoleStateApprovalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By eMMPSRoleStateAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By eMMPSRoleStateSurgeonCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                    public By eMMPSRoleStateJAGCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_7");
                    public By eMMPSRoleStateOversightCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_8");
                    public By eMMPSRoleNGSARCCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_9");
                    public By eMMPSRoleAppointingAuthorityCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_10");
                    public By eMMPSRoleIntermediateCommandReviewerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_11");
                    public By eMMPSRoleNGInvestigatorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_12");
                    public By eMMPSRoleUnitCommanderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_13");
                    public By eMMPSRoleUnitAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_14");

                    public By eMMPSRoleUSARCG1AdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By eMMPSRoleUSARCSARCManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By eMMPSRoleUSARCMedicalReviewCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By eMMPSRoleUSARCLegalReviewCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By eMMPSRoleUSARCG1OversightCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By eMMPSRoleArmyG1PDHRAManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By eMMPSRoleDIVPDHRAManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                    public By eMMPSRoleDIVApprovalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_7");
                    public By eMMPSRoleDIVAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_8");
                    public By eMMPSRoleDIVMedicalReviewCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_9");
                    public By eMMPSRoleDIVLegalReviewCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_10");
                    public By eMMPSRoleDIVOversightCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_11");
                    public By eMMPSRoleMSCApprovalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_12");
                    public By eMMPSRoleMSCAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_13");
                    public By eMMPSRoleMSCMedicalReviewCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_14");
                    public By eMMPSRoleMSCLegalReviewCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_15");
                    public By eMMPSRoleARInvestigatorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_16");
                    public By eMMPSRoleARUnitCommanderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_17");
                    public By eMMPSRoleARUnitAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_18");
                    public By eMMPSRoleARSARCCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_19");

                    public By eMMPSRoleLODOversightCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By eMMPSRoleLeadHRCReviewerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By eMMPSRoleHRCReviewerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By eMMPSRoleDAG1ApprovalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By eMMPSRoleDAG1AdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By eMMPSRoleLeadMMSOReviewerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By eMMPSRoleMMSOReviewerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                    public By eMMPSRolePDHRACallCenterCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_7");
                    public By eMMPSRoleOTSGViewOnlyCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_8");
                    public By eMMPSRoleOTSGApprovalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_9");

                    public By eMMPSRoleDEMOBApprovalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By eMMPSRoleDEMOBUnitCommanderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By eMMPSRoleDEMOBAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By eMMPSRoleDEMOBManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By eMMPSRoleWTUManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By eMMPSRoleWTUUnitCommanderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By eMMPSRoleWTUAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                    public By eMMPSRoleWTUApprovalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_emmpsModuleTab_7_emmpsModuleTabUserControl_7_emmpsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_7");
                #endregion
            #endregion
            #region Page Methods
                public void eMMPSChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = EmmpsRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void EmmpsAddRoles()
                {
                    //Create Roles Dictionary For Emmps
                    EmmpsRoles.Add("NGB Reviewer", eMMPSRoleNGBReviewerCheckbox);
                    EmmpsRoles.Add("NGB Surgeon", eMMPSRoleNGBSurgeonCheckbox);
                    EmmpsRoles.Add("NGB JAG", eMMPSRoleNGBJAGCheckbox);
                    EmmpsRoles.Add("NGB Oversight", eMMPSRoleNGBOversightCheckbox);
                    EmmpsRoles.Add("State Approval", eMMPSRoleStateApprovalCheckbox);
                    EmmpsRoles.Add("State Admin", eMMPSRoleStateAdminCheckbox);
                    EmmpsRoles.Add("State Surgeon", eMMPSRoleStateSurgeonCheckbox);
                    EmmpsRoles.Add("State JAG", eMMPSRoleStateJAGCheckbox);
                    EmmpsRoles.Add("State Oversight", eMMPSRoleStateOversightCheckbox);
                    EmmpsRoles.Add("NG SARC", eMMPSRoleNGSARCCheckbox);
                    EmmpsRoles.Add("Appointing Authority", eMMPSRoleAppointingAuthorityCheckbox);
                    EmmpsRoles.Add("Intermediate Command Reviewer", eMMPSRoleIntermediateCommandReviewerCheckbox);
                    EmmpsRoles.Add("NG Investigator", eMMPSRoleNGInvestigatorCheckbox);
                    EmmpsRoles.Add("Unit Commander", eMMPSRoleUnitCommanderCheckbox);
                    EmmpsRoles.Add("Unit Admin", eMMPSRoleUnitAdminCheckbox);
                    EmmpsRoles.Add("USARC G-1 Admin", eMMPSRoleUSARCG1AdminCheckbox);
                    EmmpsRoles.Add("USARC SARC Manager", eMMPSRoleUSARCSARCManagerCheckbox);
                    EmmpsRoles.Add("USARC Medical Review", eMMPSRoleUSARCMedicalReviewCheckbox);
                    EmmpsRoles.Add("USARC Legal Review", eMMPSRoleUSARCLegalReviewCheckbox);
                    EmmpsRoles.Add("USARC G-1 Oversight", eMMPSRoleUSARCG1OversightCheckbox);
                    EmmpsRoles.Add("Army G-1 PDHRA Manager", eMMPSRoleArmyG1PDHRAManagerCheckbox);
                    EmmpsRoles.Add("DIV(R) PDHRA Manager", eMMPSRoleDIVPDHRAManagerCheckbox);
                    EmmpsRoles.Add("DIV(R) Approval", eMMPSRoleDIVApprovalCheckbox);
                    EmmpsRoles.Add("DIV(R) Admin", eMMPSRoleDIVAdminCheckbox);
                    EmmpsRoles.Add("DIV(R) Medical Review", eMMPSRoleDIVMedicalReviewCheckbox);
                    EmmpsRoles.Add("DIV(R) Legal Review", eMMPSRoleDIVLegalReviewCheckbox);
                    EmmpsRoles.Add("DIV(R) Oversight", eMMPSRoleDIVOversightCheckbox);
                    EmmpsRoles.Add("MSC Approval", eMMPSRoleMSCApprovalCheckbox);
                    EmmpsRoles.Add("MSC Admin", eMMPSRoleMSCAdminCheckbox);
                    EmmpsRoles.Add("MSC Medical Review", eMMPSRoleMSCMedicalReviewCheckbox);
                    EmmpsRoles.Add("MSC Legal Review", eMMPSRoleMSCLegalReviewCheckbox);
                    EmmpsRoles.Add("AR Investigator", eMMPSRoleARInvestigatorCheckbox);
                    EmmpsRoles.Add("AR Unit Commander", eMMPSRoleARUnitCommanderCheckbox);
                    EmmpsRoles.Add("AR Unit Admin", eMMPSRoleARUnitAdminCheckbox);
                    EmmpsRoles.Add("AR SARC", eMMPSRoleARSARCCheckbox);
                    EmmpsRoles.Add("LOD Oversight", eMMPSRoleLODOversightCheckbox);
                    EmmpsRoles.Add("Lead HRC Reviewer", eMMPSRoleLeadHRCReviewerCheckbox);
                    EmmpsRoles.Add("HRC Reviewer", eMMPSRoleHRCReviewerCheckbox);
                    EmmpsRoles.Add("DA G-1 Approval", eMMPSRoleDAG1ApprovalCheckbox);
                    EmmpsRoles.Add("DA G-1 Admin", eMMPSRoleDAG1AdminCheckbox);
                    EmmpsRoles.Add("Lead MMSO Reviewer", eMMPSRoleLeadMMSOReviewerCheckbox);
                    EmmpsRoles.Add("MMSO Reviewer", eMMPSRoleMMSOReviewerCheckbox);
                    EmmpsRoles.Add("PDHRA Call Center", eMMPSRolePDHRACallCenterCheckbox);
                    EmmpsRoles.Add("OTSG View Only", eMMPSRoleOTSGViewOnlyCheckbox);
                    EmmpsRoles.Add("OTSG Approval", eMMPSRoleOTSGApprovalCheckbox);
                    EmmpsRoles.Add("DEMOB Approval", eMMPSRoleDEMOBApprovalCheckbox);
                    EmmpsRoles.Add("DEMOB Unit Commander", eMMPSRoleDEMOBUnitCommanderCheckbox);
                    EmmpsRoles.Add("DEMOB Admin", eMMPSRoleDEMOBAdminCheckbox);
                    EmmpsRoles.Add("DEMOB Manager", eMMPSRoleDEMOBManagerCheckbox);
                    EmmpsRoles.Add("WTU Manager", eMMPSRoleWTUManagerCheckbox);
                    EmmpsRoles.Add("WTU Unit Commander", eMMPSRoleWTUUnitCommanderCheckbox);
                    EmmpsRoles.Add("WTU Admin", eMMPSRoleWTUAdminCheckbox);
                    EmmpsRoles.Add("WTU Approval", eMMPSRoleWTUApprovalCheckbox);
                }
            #endregion
        #endregion

        #region HRR
            #region Page Objects
                #region Comboboxes
                    public By HRROrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_OrganizationDropDownList");
                    public By HRRRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_RegionDropDownList");
                #endregion
                #region Checkboxes
                    // HRR
                    public By HRRRoleHRRARNGUserCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By HRRRoleDSSCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By HRRRoleARNGContractorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By HRRRolePADOfficerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By HRRRolePADSpecialistCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By HRRRoleMEBPEBCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By HRRRoleARNGMOBStationCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                    public By HRRRoleARNGProviderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_7");
                    public By HRRRoleBehavioralHealthOfficerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_8");
                    public By HRRRoleARNGDPHCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_9");
                    public By HRRRoleARNGARPCCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_10");
                    public By HRRRoleCaseManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_11");

                    public By HRRRoleUSARAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By HRRRoleUSARCommanderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By HRRRoleUSARSurgeonCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By HRRRoleUSARMEBPEBCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By HRRRoleUSARMOBStationCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By HRRRoleUSARHRRUserCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By HRRRoleUSARContractorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");
                    public By HRRRoleUSARDPHCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_7");
                    public By HRRRoleUSARARPCCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_hrrModuleTab_6_hrrModuleTabUserControl_6_hrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_8");
                #endregion
            #endregion
            #region Page Methods
                public void HRRChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = HRRRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void HRRAddRoles()
                {
                    //Create Roles Dictionary For HRR
                    HRRRoles.Add("HRR ARNG User", HRRRoleHRRARNGUserCheckbox);
                    HRRRoles.Add("DSS", HRRRoleDSSCheckbox);
                    HRRRoles.Add("ARNG Contractor", HRRRoleARNGContractorCheckbox);
                    HRRRoles.Add("PAD Officer", HRRRolePADOfficerCheckbox);
                    HRRRoles.Add("PAD Specialist", HRRRolePADSpecialistCheckbox);
                    HRRRoles.Add("MEB/PEB", HRRRoleMEBPEBCheckbox);
                    HRRRoles.Add("ARNG MOB Station", HRRRoleARNGMOBStationCheckbox);
                    HRRRoles.Add("ARNG Provider", HRRRoleARNGProviderCheckbox);
                    HRRRoles.Add("Behavioral Health Officer", HRRRoleBehavioralHealthOfficerCheckbox);
                    HRRRoles.Add("ARNG DPH", HRRRoleARNGDPHCheckbox);
                    HRRRoles.Add("ARNG ARPC", HRRRoleARNGARPCCheckbox);
                    HRRRoles.Add("Case Manager", HRRRoleCaseManagerCheckbox);
                    HRRRoles.Add("USAR Admin", HRRRoleUSARAdminCheckbox);
                    HRRRoles.Add("USAR Commander", HRRRoleUSARCommanderCheckbox);
                    HRRRoles.Add("USAR Surgeon", HRRRoleUSARSurgeonCheckbox);
                    HRRRoles.Add("USAR MEB/PEB", HRRRoleUSARMEBPEBCheckbox);
                    HRRRoles.Add("USAR MOB Station", HRRRoleUSARMOBStationCheckbox);
                    HRRRoles.Add("USAR HRR User", HRRRoleUSARHRRUserCheckbox);
                    HRRRoles.Add("USAR Contractor", HRRRoleUSARContractorCheckbox);
                    HRRRoles.Add("USAR DPH", HRRRoleUSARDPHCheckbox);
                    HRRRoles.Add("USAR ARPC", HRRRoleUSARARPCCheckbox);
                }
            #endregion
        #endregion

        #region MATS
            #region Page Objects
                #region Comboboxes
                    public By MATSOrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_OrganizationDropDownList");
                    public By MATSRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_RegionDropDownList");
                    public By MATSUsersOfficeCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_matsUserAttributes_MATSOfficeDropDownList");
                    public By MATSRequestingOfficeCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_matsUserAttributes_MATSRequestingOfficeDropDownList");
                #endregion
                #region Checkboxes
                // MATS
                    public By MATSRoleAOContractorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_matsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By MATSRoleNGBSupportAdminCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_matsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By MATSRoleLNOWaiversCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_matsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By MATSRoleLNOGeneralOfficerPhysicalCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_matsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By MATSRoleLNOConvalescentLeaveCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_matsModuleTab_5_matsModuleTabUserControl_5_matsRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                #endregion
            #endregion
            #region Page Methods
                public void MATSChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = MATSRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void MATSAddRoles()
                {
                    //Create Roles Dictionary For MATS
                    MATSRoles.Add("AO Contractor", MATSRoleAOContractorCheckbox);
                    MATSRoles.Add("NGB Support Admin", MATSRoleNGBSupportAdminCheckbox);
                    MATSRoles.Add("LNO - Waivers", MATSRoleLNOWaiversCheckbox);
                    MATSRoles.Add("LNO - General Officer Physical", MATSRoleLNOGeneralOfficerPhysicalCheckbox);
                    MATSRoles.Add("LNO - Convalescent Leave", MATSRoleLNOConvalescentLeaveCheckbox);
                }
            #endregion
        #endregion

        #region MRR
            #region Page Objects
                #region Comboboxes
                    public By MRROrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_OrganizationDropDownList");
                    public By MRRRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_RegionDropDownList");
                #endregion
                #region Checkboxes
                    // MRR
                    public By MRRRoleAlternateDSSCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By MRRRoleBudgetOfficerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By MRRRoleDSSCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By MRRRoleCredentialingSpecialistCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By MRRRoleNGBAuthorizedUserCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                    public By MRRRoleNGBUserCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_5");
                    public By MRRRoleStateUserCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_6");

                    public By MRRRoleCommanderCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By MRRRoleMSCManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By MRRRoleMSCUserAdministratorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By MRRRoleStandardUserCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_mrrModuleTab_4_mrrModuleTabUserControl_4_mrrRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                #endregion
            #endregion
            #region Page Methods
                public void MRRChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = MRRRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void MRRAddRoles()
                {
                    //Create Roles Dictionary For MRR
                    MRRRoles.Add("Alternate DSS", MRRRoleAlternateDSSCheckbox);
                    MRRRoles.Add("Budget Officer", MRRRoleBudgetOfficerCheckbox);
                    MRRRoles.Add("DSS", MRRRoleDSSCheckbox);
                    MRRRoles.Add("Credentialing Specialist", MRRRoleCredentialingSpecialistCheckbox);
                    MRRRoles.Add("NGB Authorized User", MRRRoleNGBAuthorizedUserCheckbox);
                    MRRRoles.Add("NGB User", MRRRoleNGBUserCheckbox);
                    MRRRoles.Add("State User", MRRRoleStateUserCheckbox);
                    MRRRoles.Add("Commander", MRRRoleCommanderCheckbox);
                    MRRRoles.Add("MSC Manager", MRRRoleMSCManagerCheckbox);
                    MRRRoles.Add("MSC User Administrator", MRRRoleMSCUserAdministratorCheckbox);
                    MRRRoles.Add("Standard User", MRRRoleStandardUserCheckbox);
                }
            #endregion
        #endregion

        #region OccHealth
            #region Page Objects
                #region Textboxes
                    public By OHContactDutyTitleTextbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_ohUserAttributes_OU_DutyTitle");
                    public By OHContactAddressTextbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_ohUserAttributes_OU_WorkAddress");
                    public By OHContactCityTextbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_ohUserAttributes_OU_WorkCity");
                    public By OHContactZipTextbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_ohUserAttributes_OU_WorkZip");
                #endregion
                #region Comboboxes
                    public By OHOrganizationCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_OrganizationDropDownList");
                    public By OHRegionCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_RegionDropDownList");
                    public By OHContactStateCombobox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_ohUserAttributes_OU_WorkRegionDropDownList");
                #endregion
                #region Checkboxes
                    // OccHealth
                    public By OHRoleLvl2AccessManagerCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_occhealthRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_0");
                    public By OHRoleLvl3StaffCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_occhealthRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_1");
                    public By OHRoleLvl4HROExamRequestorCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_occhealthRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_2");
                    public By OHRoleLvl5FOHCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_occhealthRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
                    public By OHRoleLvl6AIndustrialHygieneTechnicianCheckbox = By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_occhealthModuleTab_2_occhealthModuleTabUserControl_2_occhealthRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_4");
                #endregion
            #endregion
            #region Page Methods
                public void OHChooseRoleCheckbox(string role)
                {
                    By roleCheckbox = OHRoles[role];
                    SelectCheckbox(roleCheckbox);
                }
                public void OHAddRoles()
                {
                    //Create Roles Dictionary For OH
                    OHRoles.Add("Level 2 Access Manager (JFHQ-S)", OHRoleLvl2AccessManagerCheckbox);
                    OHRoles.Add("Level 3 Staff", OHRoleLvl3StaffCheckbox);
                    OHRoles.Add("Level 4 HRO Exam Requester", OHRoleLvl4HROExamRequestorCheckbox);
                    OHRoles.Add("Level 5 FOH", OHRoleLvl5FOHCheckbox);
                    OHRoles.Add("Level 6 Industrial Hygiene Technician", OHRoleLvl6AIndustrialHygieneTechnicianCheckbox);
                }
            #endregion
        #endregion
    }
}
