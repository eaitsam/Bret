using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using Xunit;

namespace FrameworkAutomation.PageObjectModel
{
    public class ContactUsPage
    {
        #region Page Objects

        //--General--//
        public By MedchartHelpEmailLink => By.Id("MedchartEmailLink");
        public By ReturntoMedchartButton => By.Id("MEDCHARTContentPublic_ReturnToMedchart");

        //This is located on a different site, so an ID wasn't added
        public By HelpManualHeader => By.XPath("/html/body/div/div/section/section/div/h1");
        

        //--AVS--//
        public By ContactUsAVSHeader => By.Id("MEDCHARTContentPublic_ContactUsAVSHeader");
        public By ContactUsAVSContainer => By.Id("MEDCHARTContentPublic_ContactUsAVSContainer");
        public By AVSHelpEmailLink => By.Id("AVSEmailLink");
        public By RHRPCallCenterHelpEmailLink => By.Id("RHRPEmailLink");
        public By AVSARNGHelpManual => By.Id("ARNG_AVS_HelpLink");
        public By AVSUSARHelpManual => By.Id("USAR_AVS_HelpLink");
        public string AVSContactUsExpectedText => "For problems or issues related to the AVS module, please take a moment to review the AVS Help Manuals:\r\nFor the Army National Guard, click here.\r\nFor the US Army Reserve, click here.\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at 703.681.4976 or toll free at 888.849.4341, or send an email to:\r\nAVS@asmr.com\r\nPlease provide as much of the following information as is available:\r\nThe Soldier's first and last name.\r\nThe last 4 digits of the Soldier's SSN (do not send their full SSN).\r\nIf it relates to a specific Voucher or Event, please include the Voucher ID or Event ID.\r\nAny other specific information that will help with investigation and resolution of the issue (for example: steps that can be taken to recreate the issue, screenshots).\r\nPlease do not include PII and PHI information.\r\nGeneral feedback on AVS may also be sent to the email address provided above.\r\n\r\nReserve Health Readiness Program (RHRP)\r\n\r\nRHRP Call Center\r\nContact for appointment scheduling and voucher related information.\r\n1-800-666-2833 ext.3555\r\nMonday -Friday, 0700-2200 CST\r\nSaturday, 0700-1500 CST\r\nemail rhrp@tma.osd.mil\r\nPDHRA Call Center:\r\nContact for Deployment Health Assessment Program (DHAP) event information.\r\n1-888-734-7299\r\n24 hours, 7 days a week\r\nPolicy Assistance\r\nFor assistance with policy questions, contact your AVS Manager.";


        //--Denclass--//
        public By ContactUsDenclassHeader => By.Id("ContactUsDenclassHeader");
        public By ContactUsDenclassContainer => By.Id("ContactUsDenclassContainer");
        public By DenclassHelpEmailLink => By.Id("DenClassEmailLink");
        public By DenclassUSARHelpManual => By.Id("USAR_DenClass_HelpLink");
        public By DenclassARNGHelpManual => By.Id("ARNG_DenClass_HelpLink");
        public string DenclassContactUsExpectedText => "For problems or issues related to the DenClass module, please take a moment to review the DenClass Help Manual. Click here for ARNG. Click here for USAR\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at 703.681.4976 or toll free at 888.849.4341, or send an email to:\r\nDenClass@asmr.com\r\nPlease provide as much of the following information as is available:\r\nThe Soldier's first and last name.\r\nThe last 4 digits of the Soldier's SSN (do not send their full SSN).\r\nA concise description of the issue.\r\nAny other specific information that will help with investigation and resolution of the issue (for example: steps that can be taken to recreate the issue, screenshots).\r\nPlease do not include PII and PHI information.\r\nGeneral feedback on DenClass may also be sent to the email address provided above.";


        //--Ecase--//
        public By ContactUsEcaseHeader => By.Id("ContactUsEcaseHeader");
        public By ContactUsEcaseContainer => By.Id("ContactUsEcaseContainer");
        public By EcaseHelpEmailLink => By.Id("EcaseEmailLink");
        public By EcaseUSARHelpManual => By.Id("USAR_Ecase_HelpLink");
        public By EcaseARNGHelpManual => By.Id("ARNG_Ecase_HelpLink");
        public string EcaseContactUsExpectedText => "For problems or issues related to the eCase module (eCase case management), please take a moment to review the appropriate eCase Help Manual:\r\nFor the Army National Guard, click here.\r\nFor the US Army Reserve, click here.\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at 703.681.4976 or toll free at 888.849.4341, or send an email to:\r\neCase@asmr.com\r\nPlease provide as much of the following information as is available:\r\nThe Soldier's last name.\r\nThe last 4 digits of the Soldier's SSN (do not send their full SSN).\r\nIf it relates to a specific eCase, please include the Case ID.\r\nAny other specific information that will help with investigation and resolution of the issue (for example: steps that can be taken to recreate the issue).\r\nPlease do not include PII and PHI information.\r\nGeneral feedback on eCase may also be sent to the email address provided above.";


        //--Emmps--//
        public By ContactUsEmmpsHeader => By.Id("ContactUsEmmpsHeader");
        public By ContactUsEmmpsContainer => By.Id("ContactUsEmmpsContainer");
        public By EmmpsLODHelpEmailLink => By.Id("LODEmailLink");
        public By EmmpsUSARHelpManual => By.Id("USAR_EMMPS_HelpLink");
        public By EmmpsARNGHelpManual => By.Id("ARNG_EMMPS_HelpLink");
        public string EmmpsContactUsExpectedText => "For problems or issues related to the eMMPS module, please take a moment to review the appropriate eMMPS Help Manual:\r\nFor the Army National Guard, click here.\r\nFor the US Army Reserve, click here.\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at 703.681.4976, DSN at 761.4976 or toll free at 888.849.4341, or send an e-mail to:\r\nLOD@ASMR.COM\r\nPlease have the following information readily available:\r\nThe Soldier’s Last Name.\r\nThe Last (4) digits of the Soldier’s SSN (do not send their full SSN).\r\nThe Case ID and Sub-Module Name if the issue relates to a specific eMMPS case.\r\nDetailed description of task that was being attempted and not accomplished.\r\nSteps that can be taken to recreate the issue.\r\nAny other specific information that will help with the investigation and resolution of the issue (Example: Screenshots of issue).\r\nPlease do not include PII and PHI information.\r\nGeneral feedback on eMMPS may also be sent to the e-mail address provided above.";


        //--HRR--//
        public By ContactUsHRRHeader => By.Id("MEDCHARTContentPublic_ContactUsHrrHeader");
        public By ContactUsHRRContainer => By.Id("MEDCHARTContentPublic_ContactUsHrrContainer");
        public By HRRHelpEmailLink => By.Id("HRREmailLink");
        public By HRRUSARHelpManual => By.Id("USAR_HRR_HelpLink");
        public By HRRARNGHelpManual => By.Id("ARNG_HRR_HelpLink");
        public string HRRContactUsExpectedText => "For problems or issues related to the HRR module, please take a moment to review the appropriate HRR Help Manual:\r\nFor the Army National Guard, click here.\r\nFor the US Army Reserve, click here.\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at 703.681.4976 or toll free at 888.849.4341, or send an email to:\r\nHRR@asmr.com\r\nPlease provide as much of the following information as is available:\r\nThe Report, Map, or Dashboard you were accessing, or attempting to access.\r\nThe general nature of the issue: a system error, trying to print, trying to export, etc.\r\nThe date and time the issue occurred.\r\nAny other specific information that will help with investigation and resolution of the issue (for example: steps that can be taken to recreate the issue).\r\nIf possible, include a screenshot of the error message, or the page where the issue is occurring.\r\nPlease do not include PII and PHI information.\r\nGeneral feedback on HRR may also be sent to the email address provided above.";


        //--MATS--//
        public By ContactUsMATSHeader => By.Id("ContactUsMATSHeader");
        public By ContactUsMATSContainer => By.Id("ContactUsMATSContainer");
        public By MATSHelpEmailLink => By.Id("MATSEmailLink");
        public By NGBPOCHelpEmailLink => By.Id("NGBPOCEmailLink");
        public By MATSHelpManual => By.Id("ARNG_MATS_HelpLink");
        public By LNORequiredTrainingLink => By.Id("MATSTrainingLink");
        public By MerbRotcProceduresandRegLink => By.Id("DODProceduresLink");
        public By MerbUpdateMemo => By.Id("DODMerbUpdateLink");
        public By GenOfficerPhysicalAnnounceLink => By.Id("GOAnnouncmentLink");
        public By GenOfficerPhysicalReqLink => By.Id("GORequirmentLink");
        public By AccessionOptionsCriteriaLink => By.Id("AccessionOptionsLink");
        public By PriorServicePhysicalExamLink => By.Id("PriorServiceLink");
        public By ActiveandReserveComponenetEnlistLink => By.Id("AREnlistmentLink");
        public By ActiveGuardConvalescantLeaveLink => By.Id("AGLeaveGuidanceLink");
        public By ConvalescantLeaveMemoLink => By.Id("LeaveMemoLink");
        public By EnlistmentAccessionChecklistLink => By.Id("AWEEnlistmentLink");
        public By CommissioningAccessionChecklistLink => By.Id("AWCCommissioningLink");
        public By DoDMerbChecklistLink => By.Id("AWCDoDMerbLink");
        public By MEPSPhysicalApprovalChecklistLink => By.Id("AFMPMEPSLink");
        public By MTFPhysicalChecklistLink => By.Id("AWCMTFPhysicalLink");
        public By GeneralOfficerPhysicalChecklistLink => By.Id("GOPLink");
        public By ConvalescentLeaveChecklistLink => By.Id("CONLLeaveLink");
        public string MATSContactUsExpectedText => "NGB POC\r\nFor policy issues related to all MATS actions please contact MAJ Steven F. Nelson at steven.f.nelson.mil@mail.mil.\r\nFor problems or issues related to the Medical Action Tracking System (MATS) module, please take a moment to review the MATS User Manual by clicking here.\r\nHELP DESK\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at 703.681.4976 or toll free at 888.849.4341, or send an email to:\r\nMATS@asmr.com\r\nPlease provide as much of the following information as available:\r\nThe Soldier or Applicant last name.\r\nThe last 4 digits of the Soldier or Applicant SSN (do not send their full SSN).\r\nAny other specific information that will help with investigation and resolution of the issue (Example: List of steps that can be taken to recreate the issue).\r\nDo not include PII and PHI information.\r\nLinks and Documents\r\nThe below links provide best practice guidance for processing actions in MATS.\r\nLNO ROLES MUST TAKE THE REQUIRED TRAINING HERE BEFORE YOU CAN USE MATS\r\n\r\nDoD MERB/ROTC Procedures and Regulations\r\nDoD MERB/ROTC Procedures and Regulations\r\nDoD MERB Update Memo\r\nGeneral Officer Physical Guidance Regulations\r\nGeneral Officer Physical Announcement\r\nGeneral Officer Physical Requirements\r\nEnlistment and Prior Service Physical Guidance Regulations\r\nAccession Options Criteria\r\nPrior Service Physical Examination Processing Policy Memorandum 11-049\r\nActive and Reserve Component Enlistment Program 601-210\r\nConvalescent Leave IP Guidance\r\nGuidance for Active Guard Convalescent Leave Process\r\nConvalescent Leave Memo\r\nRequired Documents Checklists\r\nAWE Checklist - Enlistment Accession\r\nAWC and AWWO Checklist - Commissioning Accession\r\nAWC-DMP and AWE-DMP Checklist - DoDMERB\r\nAFMP Checklist - Approval for MEPS Physical\r\nAWC and AWWO Checklist - MTF Physical\r\nGOP Checklist - General Officer Physical\r\nCONL Checklist - Convalescent Leave\r\nGeneral feedback on MATS may also be sent to the email address provided above.";


        //--MATS ACRC--//
        public By ContactUsMATSACRCHeader => By.Id("MEDCHARTContentPublic_ContactUsAcrcHeader");
        public By ContactUsMATSACRCContainer => By.Id("MEDCHARTContentPublic_ContactUsAcrcContainer");
        public By MATSACRCHelpEmailLink => By.Id("MATS_ACRCEmailLink");
        public By MATSACRCHelpManual => By.Id("MATS_ACRCManualLink");
        public By DoDI1205DocLink => By.Id("MemberTransferLink");
        public By StandardsofMedFitnessLink => By.Id("FitnessStandardsLink");
        public By ArmyRetentionProgramLink => By.Id("ArmyRetentionLink");


        //--MRR--//
        public By ContactUsMRRHeader => By.Id("ContactUsMrrHeader");
        public By ContactUsMRRContainer => By.Id("ContactUsMrrContainer");
        public By MRRHelpEmailLink => By.Id("MRREmailLink");
        public By MRRARNGHelpManual => By.Id("ARNG_MRR_HelpLink");
        public By MRRUSARHelpManual => By.Id("USAR_MRR_HelpLink");
        public string MRRContactUsExpectedText => "For problems or issues related to the MRR module, please take a moment to review the appropriate MRR Help Manual:\r\nFor the Army National Guard, click here.\r\nFor the US Army Reserve, click here.\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at 703.681.4976 or toll free at 888.849.4341, or send an email to:\r\nMRR@asmr.com\r\nPlease provide as much of the following information as is available:\r\nThe Report, Map, or Dashboard you were accessing, or attempting to access.\r\nThe general nature of the issue: a system error, trying to print, trying to export, etc.\r\nThe date and time the issue occurred.\r\nAny other specific information that will help with investigation and resolution of the issue (for example: steps that can be taken to recreate the issue).\r\nIf possible, include a screenshot of the error message, or the page where the issue is occurring.\r\nPlease do not include PII and PHI information.\r\nGeneral feedback on MRR may also be sent to the email address provided above.";


        //--OccHealth--//
        public By ContactUsOccHealthHeader => By.Id("ContactUsOcchealthHeader");
        public By ContactUsOccHealthContainer => By.Id("ContactUsOccHealthContainer");
        public By OccHealthHelpEmailLink => By.Id("OccHealthEmailLink");
        public By OccHealthHelpManual => By.Id("ARNG_OccHealth_HelpLink");
        public string OccHealthContactUsExpectedText => "For problems or issues related to the OccHealth module, please take a moment to review the OccHealth Help Manual by clicking here.\r\nIf this does not solve the issue, please contact the MEDCHART Help Desk at (703) 681-4976 or (888) 849-4341 or email:\r\nOccHlth@asmr.com\r\nPlease provide as much of the following information as is available:\r\nThe Soldier's last name.\r\nThe last 4 digits of the Soldier's SSN (do not send their full SSN).\r\nIf it relates to a specific exam, please include the exam ID.\r\nAny other specific information that will help with investigation and resolution of the issue (for example: steps that can be taken to recreate the issue).\r\nPlease do not include PII and PHI information.\r\nGeneral feedback on OccHealth may also be sent to the email address provided above.";

        #endregion

        #region Page Methods

        public void ClickModuleTab(string module)
        {
            switch (module)
            {
                case "AVS":
                    UIActions.JSClickElement(ContactUsAVSHeader);
                    WaitMethods.Wait(ContactUsAVSContainer, 60);
                    break;
                case "DenClass":
                    UIActions.JSClickElement(ContactUsDenclassHeader);
                    WaitMethods.Wait(ContactUsDenclassContainer, 60);
                    break;
                case "eCase":
                    UIActions.JSClickElement(ContactUsEcaseHeader);
                    WaitMethods.Wait(ContactUsEcaseContainer, 60);
                    break;
                case "eMMPS":
                    UIActions.JSClickElement(ContactUsEmmpsHeader);
                    WaitMethods.Wait(ContactUsEmmpsContainer, 60);
                    break;
                case "HRR":
                    UIActions.JSClickElement(ContactUsHRRHeader);
                    WaitMethods.Wait(ContactUsHRRContainer, 60);
                    break;
                case "MATS":
                    UIActions.JSClickElement(ContactUsMATSHeader);
                    WaitMethods.Wait(ContactUsMATSContainer, 60);
                    break;
                case "MRR":
                    UIActions.JSClickElement(ContactUsMRRHeader);
                    WaitMethods.Wait(ContactUsMRRContainer, 60);
                    break;
                case "OccHealth":
                    UIActions.JSClickElement(ContactUsOccHealthHeader);
                    WaitMethods.Wait(ContactUsOccHealthContainer, 60);
                    break;
                default:
                    throw new Exception("Unknown module name: " + module);
            }
        }

        public void ClickModuleEmailLink(string module)
        {
            By HelpEmailLink = null;

            switch (module)
            {
                case "AVS":
                    HelpEmailLink = AVSHelpEmailLink;
                    break;
                case "DenClass":
                    HelpEmailLink = DenclassHelpEmailLink;
                    break;
                case "eCase":
                    HelpEmailLink = EcaseHelpEmailLink;
                    break;
                case "eMMPS":
                    HelpEmailLink = EmmpsLODHelpEmailLink;
                    break;
                case "HRR":
                    HelpEmailLink = HRRHelpEmailLink;
                    break;
                case "MATS":
                    HelpEmailLink = MATSHelpEmailLink;
                    break;
                case "MRR":
                    HelpEmailLink = MRRHelpEmailLink;
                    break;
                case "OccHealth":
                    HelpEmailLink = OccHealthHelpEmailLink;
                    
                    break;
                default:
                    throw new Exception("Unknown module name: " + module);
            }

            WaitMethods.Wait(HelpEmailLink, 60);
            UIActions.JSClickElement(AVSHelpEmailLink);
        }

        public void ClickModuleHelpManualLink(string module, string org)
        {
            By helpManualLink = By.Id("");
            switch (module)
            {
                case "AVS":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = AVSARNGHelpManual;
                            break;
                        case "USAR":
                            helpManualLink = AVSUSARHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                case "DenClass":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = DenclassARNGHelpManual;
                            break;
                        case "USAR":
                            helpManualLink = DenclassUSARHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                case "eCase":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = EcaseARNGHelpManual;
                            break;
                        case "USAR":
                            helpManualLink = EcaseUSARHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                case "eMMPS":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = EmmpsARNGHelpManual;
                            break;
                        case "USAR":
                            helpManualLink = EmmpsUSARHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                case "HRR":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = HRRARNGHelpManual;
                            break;
                        case "USAR":
                            helpManualLink = HRRUSARHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                case "MATS":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = MATSHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                case "MRR":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = MRRARNGHelpManual;
                            break;
                        case "USAR":
                            helpManualLink = MRRUSARHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                case "OccHealth":
                    switch (org)
                    {
                        case "ARNG":
                            helpManualLink = OccHealthHelpManual;
                            break;
                        default:
                            throw new Exception("Unknown organization: " + org);
                    }
                    break;
                default:
                    throw new Exception("Unknown module name: " + module);
            }

            int numWindows = ObjectRepository.Driver.WindowHandles.Count;
            while (ObjectRepository.Driver.WindowHandles.Count == numWindows)
                UIActions.ClickElement(helpManualLink);
        }

        #endregion

        #region Page Validators

        public void VerifyLoginPage()
        {
            DebuggingHelpers.Log.Info("Verifying that the user has returned to the login page");

            MedchartSplashPage splashPage = new MedchartSplashPage();
            // verifying objects on the login page

            //Assert.True(UIValidations.IsElementPresent(splashPage.ContactUsLink));
            //Assert.True(UIValidations.IsElementPresent(splashPage.AboutHyperlink));
            //Assert.True(UIValidations.IsElementPresent(splashPage.MebPrepLink));
            //Assert.True(UIValidations.IsElementPresent(splashPage.CBTLink));
            //Assert.True(UIValidations.IsElementPresent(splashPage.UserAgreementDiv));
            //Assert.True(UIValidations.IsElementPresent(splashPage.MedchartLogo));
        }

        public void VerifyTabText(string module)
        {
            switch (module)
            {
                case "AVS":
                    Assert.Equal(AVSContactUsExpectedText, UIActions.GetElement(ContactUsAVSContainer).Text);
                    break;
                case "DenClass":
                    Assert.Equal(DenclassContactUsExpectedText, UIActions.GetElement(ContactUsDenclassContainer).Text);
                    break;
                case "eCase":
                    Assert.Equal(EcaseContactUsExpectedText, UIActions.GetElement(ContactUsEcaseContainer).Text);
                    break;
                case "eMMPS":
                    string expected = UIActions.GetElement(ContactUsEmmpsContainer).Text;
                    Assert.Equal(EmmpsContactUsExpectedText, UIActions.GetElement(ContactUsEmmpsContainer).Text);
                    break;
                case "HRR":
                    Assert.Equal(HRRContactUsExpectedText, UIActions.GetElement(ContactUsHRRContainer).Text);
                    break;
                case "MATS":
                    Assert.Equal(MATSContactUsExpectedText, UIActions.GetElement(ContactUsMATSContainer).Text);
                    break;
                case "MRR":
                    Assert.Equal(MRRContactUsExpectedText, UIActions.GetElement(ContactUsMRRContainer).Text);
                    break;
                case "OccHealth":
                    Assert.Equal(OccHealthContactUsExpectedText, UIActions.GetElement(ContactUsOccHealthContainer).Text);
                    break;
                default:
                    break;
            }
        }

        public void VerifyDocumentsPage(string documenttitle)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(40))
            {
                PollingInterval = TimeSpan.FromMilliseconds(100)
            };
            wait.Until(condition => ObjectRepository.Driver.WindowHandles.Count > 1);

            string mainWindow = ObjectRepository.Driver.CurrentWindowHandle;
            foreach (string handle in ObjectRepository.Driver.WindowHandles)
            {
                if (handle != mainWindow)
                {
                    ObjectRepository.Driver.SwitchTo().Window(handle);
                    break;
                }
            }

            switch (documenttitle)
            {
                case "DoD MERB/ROTC Procedures and Regulations":
                    {
                        // this document doesn't seem to be working
                        break;
                    }
                case "DoD MERB Update Memo":
                    {
                        Assert.Contains("DoDMERB_Memo", ObjectRepository.Driver.Url);
                        break;
                    }
                case "General Officer Physical Announcement":
                    {
                        Assert.Contains("GO_Physical_Announcement", ObjectRepository.Driver.Url);
                        break;
                    }
                case "General Officer Physical Requirements":
                    {
                        Assert.Contains("GO_Physical_Requirements", ObjectRepository.Driver.Url);
                        break;
                    }
                case "Accession Options Criteria":
                    {
                        Assert.Contains("Accession_Options", ObjectRepository.Driver.Url);
                        break;
                    }
                case "Prior Service Physical Examination Processing Policy Memorandum 11-049":
                    {
                        Assert.Contains("Prior_Service", ObjectRepository.Driver.Url);
                        break;
                    }
                case "Active and Reserve Component Enlistment Program 601-210":
                    {
                        Assert.Contains("AR_601-210", ObjectRepository.Driver.Url);
                        break;
                    }
                case "Guidance for Active Guard Convalescent Leave Process":
                    {
                        Assert.Contains("Active_Guard_Convalescent_Leave", ObjectRepository.Driver.Url);
                        break;
                    }
                case "Convalescent Leave Memo ":
                    {
                        Assert.Contains("Convalescent_Leave_Memo", ObjectRepository.Driver.Url);
                        break;
                    }
                case "AWE Checklist - Enlistment Accession":
                    {
                        Assert.Contains("AWE_Checklist_Enlistment_Accession", ObjectRepository.Driver.Url);
                        break;
                    }
                case "AWC and AWWO Checklist - Commissioning Accession":
                    {
                        Assert.Contains("AWC_and_AWWO_Checklist_Commissioning_Accession", ObjectRepository.Driver.Url);
                        break;
                    }
                case "AWC-DMP and AWE-DMP Checklist - DoDMERB":
                    {
                        Assert.Contains("AWC_DMP_and_AWE_DMP_Checklist_DoDMERB", ObjectRepository.Driver.Url);
                        break;
                    }
                case "AFMP Checklist - Approval for MEPS Physical":
                    {
                        Assert.Contains("AFMP_Checklist_Approval_for_MEPS_Physical", ObjectRepository.Driver.Url);
                        break;
                    }
                case "AWC and AWWO Checklist - MTF Physical":
                    {
                        Assert.Contains("AWC_and_AWWO_Checklist_MTF_Physical", ObjectRepository.Driver.Url);
                        break;
                    }
                case "GOP Checklist - General Officer Physical":
                    {
                        Assert.Contains("GOP_Checklist_General_Officer_Physical", ObjectRepository.Driver.Url);
                        break;
                    }
                case "CONL Checklist - Convalescent Leave":
                    {
                        Assert.Contains("CONL_Checklist_Convalescent_Leave", ObjectRepository.Driver.Url);
                        break;
                    }
                default:
                    break;
            }

            ObjectRepository.Driver.Close();
            ObjectRepository.Driver.SwitchTo().Window(mainWindow);
        }

        #endregion

    }
}
