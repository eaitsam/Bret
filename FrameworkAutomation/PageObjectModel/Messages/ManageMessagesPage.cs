using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace FrameworkAutomation.PageObjectModel
{
    public class ManageMessagesPage
    {
        #region Page Objects

        #region By Elements

        public By PageDecription => By.Id("PageDescription");
        public By CreateSystemMessageTab => By.Id("CreateSystemMessageTab");
        public By MySystemMessagesTab => By.Id("MySystemMessagesTab");
        public By MessageTitleRequiredFieldValidator => By.Id("MEDCHARTContent_MedchartPagesContent_MessageTitleRequiredFieldValidator");
        public By MessageStartDateRequiredFieldValidator => By.Id("MEDCHARTContent_MedchartPagesContent_MessageStartDateRequiredFieldValidator");
        public By MessageEndDateRequiredFieldValidator => By.Id("MEDCHARTContent_MedchartPagesContent_MessageEndDateRequiredFieldValidator");
        public By MessageContentCounter => By.Id("MEDCHARTContent_MedchartPagesContent_MessageContentCounter");
        public By MessageContextTextBoxCounter => By.Id("MEDCHARTContent_MedchartPagesContent_MessageContextTextBoxCounter");
        public By SubmitButton => By.Id("MEDCHARTContent_MedchartPagesContent_CreateMessageSaveLinkButton");
        public By ResetButton => By.Id("MEDCHARTContent_MedchartPagesContent_CreateMessageResetLinkButton");
        public By MessageTextBox => By.Id("MessageTitleProxy");
        public By MessageCounterSpan => By.Id("MEDCHARTContent_MedchartPagesContent_MessageContentCounter");
        public By FromTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_MessageCreaterTextBox");
        public By StartDateDateTime => By.Id("MEDCHARTContent_MedchartPagesContent_MessageStartDateTextBox");
        public By EndDateDateTime => By.Id("MEDCHARTContent_MedchartPagesContent_MessageEndDateTextBox");
        public By ExtendedInformationTextBox => By.Id("MessageContentProxy");
        public By StartDateCalendar => By.Id("startdatepicker");
        public By EndDateCalendar => By.Id("enddatepicker");
        public By RoleCheckboxRequiredFieldValidator => By.Id("MEDCHARTContent_MedchartPagesContent_MessageRolesCheckBoxesDataListCustomValidator");
        public By SystemMessagesGridView => By.Id("MEDCHARTContent_MedchartPagesContent_MyCreatedSystemMessagesGridView");
        public By SystemMessagesGridViewFirstEditButton => By.XPath("//*[@id=\"MEDCHARTContent_MedchartPagesContent_MyCreatedSystemMessagesGridView\"]/tbody/tr[3]/td[6]/a");
        public By SystemMessagesGridViewFirstMessageCell => By.XPath("//*[@id=\"MEDCHARTContent_MedchartPagesContent_MyCreatedSystemMessagesGridView\"]/tbody/tr[3]/td[2]");

        public By SystemMessagesEditMessageTextBox => By.Id("EditMessageTitleProxy");
        public By SystemMessagesSaveButton => By.Id("MEDCHARTContent_MedchartPagesContent_SelectedMySystemMessageDetailsView_SelectedMySystemMessageDetailsViewSaveCommand");

        #region ModuleObjects

        public abstract class ModuleObject
        {
            public abstract By GetRolesDataListContainer();
            public abstract By GetModuleSelectButton();
            public abstract List<By> GetListOfRolesCheckBox();
        }

        public class DefaultModuleObject : ModuleObject
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

        public class AVSModuleObject : ModuleObject
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

        public class DenClassModuleObject : ModuleObject
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

        public class ECaseModuleObject : ModuleObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_2");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_0"), // eCaseModuleARNGManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_1"), // eCaseModuleDSSRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_2"), // eCaseModuleMedRediNCORoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_3"), // eCaseModuleStateBHORepRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_4"), // eCaseModuleAdminSupportRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_5"), // eCaseModuleLeadMCMRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_6"), // eCaseModuleNGBBHORoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_7"), // eCaseModuleUnitAdminRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_8"), // eCaseModuleAuditorRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_9"), // eCaseModuleMedCaseManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_2_MessageRoleCheckBox_10") // eCaseModuleProvidorRoleCheckBox
                };
            }
        }

        public class EMMPSModuleObject : ModuleObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_3");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_0"),  // eMMPSModuleARNGManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_1"),  // eMMPSModuleNGBJAGRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_2"),  // eMMPSModuleStateAdminRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_3"),  // eMMPSModuleStateOversightRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_4"),  // eMMPSModuleIntermedCmdReviewerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_5"),  // eMMPSModuleUnitAdminCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_6"),  // eMMPSModuleNGBReviewerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_7"),  // eMMPSModuleNGBOversightRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_8"),  // eMMPSModuleStateSurgeonRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_9"),  // eMMPSModuleNGSARCRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_10"), // eMMPSModuleNGInvestigatorRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_11"), // eMMPSModuleNGBSurgeonRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_12"), // eMMPSModuleStateApprovalRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_13"), // eMMPSModuleStateJAGRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_14"), // eMMPSModuleAppointingAuthRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_3_MessageRoleCheckBox_15")  // eMMPSModuleUnitCommanderRoleCheckBox
                };
            }
        }

        public class HRRModuleObject : ModuleObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_4");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_0"),  // HRRModuleARNGManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_1"),  // HRRModuleARNGUserRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_2"),  // HRRModuleDSSRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_3"),  // HRRModuleARNGContractorRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_4"),  // HRRModulePADofficerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_5"),  // HRRModulePADSpecialistCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_6"),  // HRRModuleMEBPEBRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_7"),  // HRRModuleARNGMOBStationRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_8"),  // HRRModuleARNGProviderRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_9"),  // HRRModuleBehavHealthAdminRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_10"), // HRRModuleBehavHealthOfficerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_11"), // HRRModuleARNGDPHRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_12"), // HRRModuleARNGARPCRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_4_MessageRoleCheckBox_13")  // HRRModuleCaseManagerRoleCheckBox
                };
            }
        }

        public class MATSModuleObject : ModuleObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_5");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_5");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_5_MessageRoleCheckBox_0"),  // MATSModuleMATSManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_5_MessageRoleCheckBox_1"),  // MATSModuleAOContractorRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_5_MessageRoleCheckBox_2"),  // MATSModuleNGBSuppAdminRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_5_MessageRoleCheckBox_3"),  // MATSModuleLNOWaiverRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_5_MessageRoleCheckBox_4"),  // MATSModuleLNOGenOfficerPhysicalRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_5_MessageRoleCheckBox_5")   // MATSModuleConvalLeaveRoleCheckBox
                };
            }
        }

        public class MATSACRCModuleObject : ModuleObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_6");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_6");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_6_MessageRoleCheckBox_0"),  // MATS_ACRCModuleMATS_ACRCManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_6_MessageRoleCheckBox_1"),  // MATS_ACRCModuleRCCCPersonManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_6_MessageRoleCheckBox_2"),  // MATS_ACRCModuleRCCCManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_6_MessageRoleCheckBox_3")   // MATS_ACRCModuleRCCCSubmitterRoleCheckBox
                };
            }
        }

        public class MRRModuleObject : ModuleObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_7");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_0"),  // MRRModuleARNGManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_1"),  // MRRModuleDSSRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_2"),  // MRRModuleNGBUserRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_3"),  // MRRModuleAltDSSRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_4"),  // MRRModuleCredSpecialistRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_5"),  // MRRModuleStateUserRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_6"),  // MRRModuleBudgetOfficerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_7_MessageRoleCheckBox_7")   // MRRModuleNGBAuthUserRoleCheckBox
                };
            }
        }

        public class OccHealthModuleObject : ModuleObject
        {
            public override By GetRolesDataListContainer()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_8");
            }

            public override By GetModuleSelectButton()
            {
                return By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_ModuleSelectAllLinkButton_8");
            }

            public override List<By> GetListOfRolesCheckBox()
            {
                return new List<By>()
                {
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_8_MessageRoleCheckBox_0"),  // OccHealthModuleARNGManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_8_MessageRoleCheckBox_1"),  // OccHealthModuleLvl2AccessManagerRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_8_MessageRoleCheckBox_2"),  // OccHealthModuleLvl4HROExamReqRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_8_MessageRoleCheckBox_3"),  // OccHealthModuleLvl3StaffRoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_8_MessageRoleCheckBox_4"),  // OccHealthModuleLvl5OHoleCheckBox
                    By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDataList_MessageRolesCheckBoxesDataList_8_MessageRoleCheckBox_5")   // OccHealthModuleLvl6IndHygieneTechRoleCheckBox
                };
            }
        }

        #endregion

        #endregion

        #region String/List Elements

        public readonly string message = "This is a test of the Manage Messages System.";

        public readonly string editedMessage = "This is an edited message.";

        public readonly List<string> moduleList = new List<string>() { "AVS", "DENCLASS", "ECASE", "EMMPS", "HRR", "MATS", "MATS_ACRC", "MRR", "OCCHEALTH" };

        #endregion

        #endregion

        #region Page Methods

        public ManageMessagesPage.ModuleObject GetModuleObject(string module)
        {
            ManageMessagesPage.ModuleObject moduleObject;

            switch (module.ToUpper())
            {
                case "AVS":
                    moduleObject = new ManageMessagesPage.AVSModuleObject();
                    break;
                case "DENCLASS":
                    moduleObject = new ManageMessagesPage.DenClassModuleObject();
                    break;
                case "ECASE":
                    moduleObject = new ManageMessagesPage.ECaseModuleObject();
                    break;
                case "EMMPS":
                    moduleObject = new ManageMessagesPage.EMMPSModuleObject();
                    break;
                case "HRR":
                    moduleObject = new ManageMessagesPage.HRRModuleObject();
                    break;
                case "MATS":
                    moduleObject = new ManageMessagesPage.MATSModuleObject();
                    break;
                case "MATS_ACRC":
                    moduleObject = new ManageMessagesPage.MATSACRCModuleObject();
                    break;
                case "MRR":
                    moduleObject = new ManageMessagesPage.MRRModuleObject();
                    break;
                case "OCCHEALTH":
                    moduleObject = new ManageMessagesPage.OccHealthModuleObject();
                    break;
                default:
                    throw new Exception("Not a valid Module: " + module);
            }

            return moduleObject;
        }

        #endregion
    }
}
