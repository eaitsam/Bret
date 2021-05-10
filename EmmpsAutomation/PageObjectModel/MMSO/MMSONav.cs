using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using MedchartSeleniumAutomationCore.Core_Framework;
using EmmpsAutomation.PageObjectModel.LOD;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class MMSONav
    {
        #region Page Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//
        #region My Pre-Auth Main Menu Objects

        #region HyperLinks
        public By MMSOSelectCaseMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOSelect");
        public By MMSOFormsMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOMMSO FormsMenuLinkButton");
        public By MMSODocumentsMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSODocumentsMenuLinkButton");
        public By MMSOAssociateMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOAssociateMenuLinkButton");
        public By MMSOFollowUpCareMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOFollow");
        public By MMSONextActionMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSONext ActionMenuLinkButton ActionMenuDiv");
        public By MMSOTrackingMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOTrackingMenuLinkButton");
        public By MMSOAdminMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOAdminMenuLinkButton");
        public By MyMMSOPageLink = By.Id("ReviewAndActOnMyPreAuthorizationsHyperLink");
        public By MMSOFilterResultsRow0CaseIDLink => By.Id("MEDCHARTContent_EmmpsContent_MyPreAuthorizationsDisplayGrid_GridViewMmsoCaseFilterResults_LinkButtonCaseId_0");
        public By MMSOSearchFilterResultsRow0CaseIDLink => By.Id("MEDCHARTContent_EmmpsContent_SearchResultsMmsoDisplayGrid_GridViewMmsoCaseFilterResults_LinkButtonCaseId_0");


        #endregion
        #region Labels
        public By MMSOServiceMemberLabel = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ServiceMemberLabel");
        public By MMSOExistingWorkSheetsLabel = By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_divExistingWorksheetsSection");

        #endregion

        #endregion








        #endregion

        #region Page Methods

    //    StartNewLODPage startNewLOD = new StartNewLODPage();

    //    public void MMSOSoldierSSNSearch(string SSN)
    //    {
    //        UIActions.TypeInTextBox(SsnBox, SSN);
    //        UIActions.JSClickElement(SearchButton);
    //    }

    //    private void SelectResult()
    //    {
    //        Thread.Sleep(750);
    //        if (UIActions.IsElementPresent(MMSOFilterResultsRow0CaseIDLink))
    //        {
    //            //WaitMethods.Wait(MMSOFilterResultsRow0CaseIDLink, 60);
    //            UIActions.JSClickElement(MMSOFilterResultsRow0CaseIDLink);
    //        }
    //        else
    //        {
    //            //WaitMethods.Wait(MMSOSearchFilterResultsRow0CaseIDLink, 60);
    //            UIActions.JSClickElement(MMSOSearchFilterResultsRow0CaseIDLink);
    //        }
    //    }

    //    public void ClickOnTheFirstCaseId()
    //    {
    //        //Select first case if found

    //        SelectResult();
    //    }

    //    #region AR Followup Care Pre-Auth MMSO form
    //    public void UpdateMMSOFormMemberData(string memberEmail, string memberPhone, string triCareRegion)
    //    {           
    //        string emailValue = UIActions.GetTextBoxTextValue(MMSOFormsPatientEmailTextbox);

    //        if (String.IsNullOrEmpty(emailValue))
    //        {
    //            UIActions.TypeInTextBox(MMSOFormsPatientEmailTextbox, memberEmail);
    //        }

    //        string phoneValue = UIActions.GetTextBoxTextValue(MMSOFormsPatientPhoneTextbox);

    //        if (String.IsNullOrEmpty(phoneValue))
    //        {
    //            UIActions.TypeInTextBox(MMSOFormsPatientPhoneTextbox, memberPhone);

    //        }


    //        if (!string.IsNullOrEmpty(triCareRegion))
    //        {
    //            switch (triCareRegion)
    //            {
    //                case "North":
    //                    {
    //                        UIActions.JSClickElement(MMSOFormsTricareRegionNorthButton);
    //                        break;
    //                    }
    //                case "South":
    //                    {
    //                        UIActions.JSClickElement(MMSOFormsTricareRegionSouthButton);
    //                        Thread.Sleep(5000);
    //                        break;
    //                    }
    //                case "West":
    //                    {
    //                        UIActions.JSClickElement(MMSOFormsTricareRegionWestButton);
    //                        break;
    //                    }
    //                default:
    //                    {
    //                        break;
    //                    }
    //            }
    //        }
    //    }

    //    public void UpdateMMSOFollowUpFormPreAuthRequest(string fromDutyDate, string ToDutyDate, string injurycode, string neededFollowup, string specialtyRequested, string medicalInBoardProcess, string formType)
    //    {            
    //        string injuryDateValue = UIActions.GetTextBoxTextValue(MMSOFormsDateOfInjuryTextbox);

    //        if (String.IsNullOrEmpty(injuryDateValue))
    //        {
    //            injuryDateValue = DateTime.Now.ToString("yyyyMMdd");
    //            UIActions.JSEnterText(MMSOFormsDateOfInjuryTextbox, injuryDateValue);
    //        }

    //        DateTime injuryDate = DateTime.ParseExact(injuryDateValue, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);     
           
    //        UIActions.JSEnterText(MMSOFormsDutyDateFromTextbox, (SelectDate(injuryDate, Convert.ToInt32(fromDutyDate))));
    //        UIActions.JSEnterText(MMSOFormsDutyDateToTextbox, (SelectDate(injuryDate, Convert.ToInt32(ToDutyDate))));

    //        //add Diagnosis
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisLinkButton);
    //        Thread.Sleep(2000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisExactMatchCheckBox);
    //        Thread.Sleep(2000);
    //        UIActions.TypeInTextBox(MMSOFormsAddDiagnosisExactMatchTextBox, injurycode);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisSearchButton);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisSelect);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisButtonForm02);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsEligibilityDocumentLODFormCheckBox);
    //        UIActions.TypeInTextBox(MMSOFormsFollowUpCareTextbox, neededFollowup);
    //        UIActions.TypeInTextBox(MMSOFormsSpecialtyRequestedTextbox, specialtyRequested);

    //        if (medicalInBoardProcess == "Yes")
    //        {
    //            UIActions.JSClickElement(MMSOFormsMedicalBoardInProcessYesButton);
    //            UIActions.JSEnterText(MMSOFormsMedicalBoardStartDateAndMTFNameTextbox, "Automation Test");
    //        }
    //        else if (medicalInBoardProcess == "No")
    //        {
    //            UIActions.JSClickElement(MMSOFormsMedicalBoardInProcessNoButton);
    //        }
    //    }


    //    public static string SelectDate(DateTime injurydate, int numberOfDays)
    //    {

    //        return injurydate.AddDays(numberOfDays).ToString("yyyMMdd");
    //    }
    //    /// <summary>
    //    /// Used to update Current Unit Certification of Eligibilty
    //    /// </summary>
    //    /// <param name="miles"></param>
    //    /// <param name="milesFromPlaceType"></param>
    //    /// <param name="unitPoc"></param>
    //    /// <param name="PocPhone"></param>
    //    /// <param name="PocEmail"></param>
    //    public void UpdateMMSOFormCurrentUnitCertificationOfEligibilityFollowUpForm02(string miles, string milesFromPlaceType, string unitPoc, string PocPhone, string PocEmail)
    //    {
    //        UIActions.TypeInTextBox(MMSOFormsDistanceToMTFTextbox, miles);
    //        UIActions.TypeInTextBox(MMSOFormsCurrentUnitPOCTextbox, unitPoc);
    //        UIActions.TypeInTextBox(MMSOFormsCurrentUnitPOCPhoneTextbox, PocPhone);
    //        UIActions.TypeInTextBox(MMSOFormsCurrentUnitPOCEmailTextbox, PocEmail);
    //        //UIActions.TypeInTextBox(MMSOFormsUnitPhoneTextbox, "7031111111");
    //        //UIActions.TypeInTextBox(MMSOFormsUnitAddressTextbox, "200 Test Street Fairfax, VA 11111");
    //        //UIActions.TypeInTextBox(MMSOFormsUnitAssignmentNameTextbox, "Test");
    //        //UIActions.TypeInTextBox(MMSOFormsMilitaryTreatmentFacilityTextbox, "Test");
            
    //        Thread.Sleep(2000);

    //        if (milesFromPlaceType == "Duty")
    //        {
    //            UIActions.JSClickElement(MMSOFormsMTFLocationFromDutyButtonForm02);                
    //        }
    //       else if (milesFromPlaceType == "Residence")
    //        {
    //            UIActions.JSClickElement(MMSOFormsMTFLocationFromResidenceButtonForm02);
    //        }

            
    //    }

    //    public void UpdateMMSOFollowupCareTab(string priority, string followupCare, string preAuth, string preAuthCorresponding)
    //    {
    //        UIActions.SelectElementByText(MMSOFllowupCarePriortyComboBox, "Routine Priority");
    //        UIActions.TypeInTextBox(MMSOFormsFollowUpCareTabFollowupTextbox, followupCare);
    //        UIActions.TypeInTextBox(MMSOFormsFollowUpCareTabPreAuthTextbox, preAuth);
    //        UIActions.TypeInTextBox(MMSOFormsFollowUpCareTabPreAuthCorrespondingTextbox, preAuthCorresponding);
            
    //}

    //    #endregion AR Followup Care Pre-Auth

    //    #region AR Pre-Auth[Form 01]
    //    /// <summary>
    //    /// Section I - Member Data
    //    /// </summary>
    //    /// <param name="memberEmail"></param>
    //    /// <param name="memberPhone"></param>
    //    public void UpdateMMSOFormMemberDataForm01(string memberEmail, string memberPhone)
    //    {
    //        string email = UIActions.GetTextBoxTextValue(MMSOFormsPatientEmailTextboxForm01);
    //        string phone = UIActions.GetTextBoxTextValue(MMSOFormsPatientPhoneTextboxForm01);

    //        if (String.IsNullOrEmpty(email))
    //           {
    //            UIActions.TypeInTextBox(MMSOFormsPatientEmailTextboxForm01, memberEmail);
    //        }

    //        if (String.IsNullOrEmpty(phone))
    //        {
    //            UIActions.TypeInTextBox(MMSOFormsPatientPhoneTextboxForm01, memberPhone);
    //        }
                        
    //    }

    //    /// <summary>
    //    /// Update Section II Illness/Injury Information
    //    /// </summary>
    //    /// <param name="dateInjury"></param>
    //    /// <param name="treatmentDate"></param>
    //    /// <param name="fromDutyDate"></param>
    //    /// <param name="ToDutyDate"></param>
    //    /// <param name="injurycode"></param>
    //    public void UpdateMMSOFormPreAuthIllnessInjury(string dateInjury, string treatmentDate, string fromDutyDate, string ToDutyDate,  string injurycode)
    //    {
    //        string injuryIllnessDate = UIActions.SelectDate(Convert.ToInt32(dateInjury));
                
    //        UIActions.JSEnterText(MMSOFormsIllnessDateTextboxForm01, (UIActions.SelectDate(Convert.ToInt32(dateInjury))));
    //        UIActions.JSEnterText(MMSOFormsTreatmentDateToTextboxForm01, (UIActions.SelectDate(Convert.ToInt32(treatmentDate))));

    //        DateTime injuryDate = DateTime.ParseExact(injuryIllnessDate, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
    //        UIActions.JSEnterText(MMSOFormsDutyDateFromTextboxForm01, (SelectDate(injuryDate, Convert.ToInt32(fromDutyDate))));
    //        UIActions.JSEnterText(MMSOFormsDutyDateToTextboxForm01, (SelectDate(injuryDate, Convert.ToInt32(ToDutyDate))));

    //        //add Diagnosis
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisLinkButtonForm01);
    //        Thread.Sleep(2000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisExactMatchCheckBoxForm01);
    //        Thread.Sleep(2000);
    //        UIActions.TypeInTextBox(MMSOFormsAddDiagnosisExactMatchTextBoxForm01, injurycode);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisSearchButtonForm01);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisSelectForm01);     //check to see if same path
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisButtonForm01);
    //        Thread.Sleep(3000);
                        
    //    }
    //    /// <summary>
    //    /// MMSO Form NG Pre-Auth [Form 01]
    //    /// </summary>
    //    /// <param name="miles"></param>
    //    /// <param name="milesFromPlaceType"></param>
    //    /// <param name="unitPoc"></param>
    //    /// <param name="PocPhone"></param>
    //    /// <param name="PocEmail"></param>
    //    /// <param name="typeOfOrders"></param>
    //    public void UpdateMMSOFormCurrentUnitCertificationOfEligibilityPreAuthForm01(string miles, string milesFromPlaceType, string unitPoc, string PocPhone, string PocEmail, string typeOfOrders)
    //    {
    //        UIActions.TypeInTextBox(MMSOFormsDistanceToMTFTextboxForm01, miles);
    //        UIActions.JSEnterText(MMSOFormsCurrentUnitPOCTextboxForm01, unitPoc);
    //        Thread.Sleep(200);
    //        UIActions.TypeInTextBox(MMSOFormsCurrentUnitPOCPhoneTextboxForm01, PocPhone);
    //        UIActions.TypeInTextBox(MMSOFormsCurrentUnitPOCEmailTextboxForm01, PocEmail);
    //        UIActions.TypeInTextBox(MMSOFormsUnitPhoneTextboxForm01, "7031111111");
    //        UIActions.TypeInTextBox(MMSOFormsUnitAddressTextboxForm01, "200 Test Street Fairfax, VA 11111");
    //        UIActions.TypeInTextBox(MMSOFormsUnitAssignmentNameTextboxForm01, "Test");
    //        UIActions.TypeInTextBox(MMSOFormsMilitaryTreatmentFacilityTextboxForm01, "Test");

    //        Thread.Sleep(2000);

    //        if (milesFromPlaceType == "Duty")
    //        {
    //            UIActions.JSClickElement(MMSOFormsMTFLocationFromDutyButtonForm01);
    //        }
    //        else if (milesFromPlaceType == "Residence")
    //        {
    //            UIActions.JSClickElement(MMSOFormsMTFLocationFromResidenceButtonForm01);
    //        }
           

    //        if (typeOfOrders == "weekendDrill")
    //        {
    //            UIActions.JSClickElement(MMSOFormTypesOfOrdersWeekendDrillButtonForm01);
    //        }
    //        else if (typeOfOrders == "annualTraining")
    //        {
    //            UIActions.JSClickElement(MMSOFormTypesOfOrdersAnnualTrainingButtonForm01);
    //        }
    //        else if (typeOfOrders == "other")
    //        {
    //            UIActions.JSClickElement(MMSOFormTypesOfOrdersOtherButtonForm01);
    //        }

    //    }

    //    #endregion AR Pre-Auth

    //    #region AR Surgery and Durable Medical Equipment (DME) Information
    //    /// <summary>
    //    /// Used to update AR Surgery and Durable Medical Equipment (DME) Information on the AR Surgical Pre Auth workfow
    //    /// </summary>
    //    /// <param name="dateOfRequest"></param>
    //    /// <param name="dateOfSurgery"></param>
    //    /// <param name="surgicalProcedureInfo"></param>
    //    /// <param name="diagnosisCode"></param>
    //    /// <param name="procedureCode"></param>
    //    public void UpdateSurgeryInformationForm06(string dateOfRequest, string dateOfSurgery, string surgicalProcedureInfo, string diagnosisCode, string procedureCode)
    //    {
    //        UIActions.JSEnterText(MMSOFormsSurgeryDateRequestTextboxForm06, (UIActions.SelectDate(Convert.ToInt32(dateOfRequest))));
    //        UIActions.JSEnterText(MMSOFormsSurgeryDateOfSurgeryTextboxForm06, (UIActions.SelectDate(Convert.ToInt32(dateOfSurgery))));
    //        UIActions.JSEnterText(MMSOFormsSurgicalProcedureInformationTextboxForm06, surgicalProcedureInfo);

    //        //add Diagnosis
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisLinkButtonForm06);
    //        Thread.Sleep(2000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisExactMatchCheckBoxForm06);
    //        Thread.Sleep(2000);
    //        UIActions.TypeInTextBox(MMSOFormsAddDiagnosisExactMatchTextBoxForm06, diagnosisCode);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisSearchButtonForm06);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisSelectForm06);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsAddDiagnosisButtonForm06);
    //        Thread.Sleep(3000);

    //        //add Procedure
    //        UIActions.JSClickElement(MMSOFormsAddProcedureLinkButtonForm06);
    //        UIActions.JSEnterText(MMSOFormsSurgeryAddProcedureSearchTextboxForm06, procedureCode);
    //        UIActions.JSClickElement(MMSOFormsSurgeryAddProcedureSearchButtonForm06);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsSurgeryAddProcedureSelectForm06);
    //        Thread.Sleep(3000);
    //        UIActions.JSClickElement(MMSOFormsSurgeryAddSelectedProcedureButtonForm06);
    //        Thread.Sleep(3000);
    //    }

    //    /// <summary>
    //    /// Used to update AR Current Unit Point of Contact Information for the AR Surgical Pre Auth workfow
    //    /// </summary>
    //    /// <param name="unitPoc"></param>
    //    /// <param name="rankAndTitle"></param>
    //    /// <param name="pocPhone"></param>
    //    /// <param name="pocFax"></param>
    //    public void UpdateCurrentUnitPointOfContactInformationForm06(string unitPoc, string rankAndTitle, string pocPhone, string pocFax)
    //    {
    //        UIActions.JSEnterText(MMSOFormsSurgeryUnitPOCTextboxForm06, unitPoc);
    //        UIActions.JSEnterText(MMSOFormsSurgeryUnitPOCRankTitleTextboxForm06, rankAndTitle);
    //        UIActions.JSEnterText(MMSOFormsSurgeryPOCPhoneTextboxForm06, pocPhone);
    //        UIActions.JSEnterText(MMSOFormsSurgeryPOCFaxTextboxForm06, pocFax);
            
    //    }

    //    #endregion AR Surgery and Durable Medical Equipment (DME) Information

        #endregion
    }
}
