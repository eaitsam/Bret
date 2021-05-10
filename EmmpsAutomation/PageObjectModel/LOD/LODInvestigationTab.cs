using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODInvestigationTab
    {
        //---------------------------------//
        // My LOD Investigation Tab Objects
        //---------------------------------//

        //--HTMLEdit--//
        public By LODInvestigationReportDate => By.Id("MEDCHARTContent_EmmpsContent_investigationControl_ReportDateTextBox");
        public By LODInvestigationCircumstancesDate => By.Id("MEDCHARTContent_EmmpsContent_investigationControl_DateOfCircumstancesTextBox");
        public By LODInvestigationPlace => By.Id("MEDCHARTContent_EmmpsContent_investigationControl_PlaceTextBox");
        public By LODInvestigationSustained => By.Id("MEDCHARTContent_EmmpsContent_investigationControl_SustainedTextBox");
        public By LODInvestigationMedicalDiagnosis => By.Id("MEDCHARTContent_EmmpsContent_investigationControl_MedicalTextBox");
        public By LODInvestigationRemark => By.Id("MEDCHARTContent_EmmpsContent_investigationControl_RemarksTextBox");
        public By LODInvestigationOrganization => By.Id("MEDCHARTContent_EmmpsContent_investigationControl_OrganizationTextBox");
        public By LODInvestigationInactiveDutyTrainingStartDate => By.Id("StartDateTextBox");
        public By LODInvestigationInactiveDutyTrainingFinishDate => By.Id("EndDateTextBox");

        //Radio Button

        //investigation report
        public By LODInvestigationOfInjury => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[1]/div/table/tbody/tr[2]/td[2]/table/tbody/tr/td[1]/label");
        public By LODInvestigationOfDisease => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[1]/div/table/tbody/tr[2]/td[2]/table/tbody/tr/td[2]/label");
        public By LODInvestigationOfIllness => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[1]/div/table/tbody/tr[2]/td[2]/table/tbody/tr/td[3]/label");
        //Status
        public By LODInvestigationYesRegularOrEad => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[1]/tbody/tr[2]/td[3]/table/tbody/tr/td[1]/label");
        public By LODInvestigationNoRegularOrEad => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[1]/tbody/tr[2]/td[3]/table/tbody/tr/td[2]/label");

        //Basis for Findings
        public By LODInvestigationYesCalledOrOrderedToAd => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[2]/tbody/tr/td[3]/table/tbody/tr/td[1]/label");
        public By LODInvestigationNoCalledOrOrderedToAd => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[2]/tbody/tr/td[3]/table/tbody/tr/td[2]/label");
        public By LODInvestigationNoCalledOrOrderedToAd30DaysMore => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[2]/tbody/tr/td[5]/table/tbody/tr/td[1]/label");
        public By LODInvestigationNoCalledOrOrderedToAd30DaysLess => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[2]/tbody/tr/td[5]/table/tbody/tr/td[2]/label");
        public By LODInvestigationYesInactiveDutyTraining => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[3]/tbody/tr/td[3]/table/tbody/tr/td[1]/label");
        public By LODInvestigationNoInactiveDutyTraining => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[3]/tbody/tr/td[3]/table/tbody/tr/td[2]/label");
        public By LODInvestigationYesShortTourOfAdForTraining => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[4]/tbody/tr/td[3]/table/tbody/tr/td[1]/label");
        public By LODInvestigationNoShortTourOfAdForTraining => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[2]/div/table[4]/tbody/tr/td[3]/table/tbody/tr/td[2]/label");
        public By LODInvestigationYesPresentForDuty => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[7]/td[2]/table/tbody/tr/td[1]/label");
        //public By LODInvestigationYesPresentForDuty => By.Id("PresentForDutyRadioButtonList_0");
        //public By LODInvestigationNoPresentForDuty => By.Id("PresentForDutyRadioButtonList_1");


        public By LODInvestigationNoPresentForDuty => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[7]/td[2]/table/tbody/tr/td[2]/label");
        public By LODInvestigationYesIntentionalMisconductOrNeglect => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[9]/td[2]/table/tbody/tr/td[1]/label");


        //By.Id("MEDCHARTContent_EmmpsContent_investigationControl_MisconductRadioButtonList_0");

        public By LODInvestigationNoIntentionalMisconductOrNeglect => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[9]/td[2]/table/tbody/tr/td[2]/label");
        public By LODInvestigationYesMentallySound => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[10]/td[2]/table/tbody/tr/td[1]/label");
        public By LODInvestigationNoMentallySound => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[10]/td[2]/table/tbody/tr/td[2]/label");
        public By LODInvestigationFindingInLineOfDuty => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[5]/div/table/tbody/tr/td[2]/table/tbody/tr/td[1]/label");
        public By LODInvestigationFindingMisconduct => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[5]/div/table/tbody/tr/td[2]/table/tbody/tr/td[2]/label");
        public By LODInvestigationFindingNoMisconduct => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[5]/div/table/tbody/tr/td[2]/table/tbody/tr/td[3]/label");
        public By LODInvestigationAbsentWithAuthority => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[8]/td[2]/table/tbody/tr/td[1]/label");
        public By LODInvestigationAbsentWithoutAuthority => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div[4]/div/div/table/tbody/tr[8]/td[2]/table/tbody/tr/td[2]/label");



        public void UpdateRequiredFieldsInvestigationTab(string reportDate, string investigationOf, string circumstanceDate, string place, string sustained, string medDiagnosis, string presentForDuty, string misconductOrNeglect, string mentallySound, string remarks, string findings, string organizationAndStation, string ifAbsentFromDuty)
        {

            UIActions.TypeInTextBox(LODInvestigationReportDate, (UIActions.SelectDate(Convert.ToInt32(reportDate))));
            UIActions.JSClickElement(LODInvestigationReportDate);

            switch (investigationOf)
            {
                case "Injury":
                    {
                        UIActions.JSClickElement(LODInvestigationOfInjury);
                        break;
                    }
                case "Disease":
                    {
                        UIActions.JSClickElement(LODInvestigationOfDisease);
                        break;
                    }
                case "Illness":
                    {
                        UIActions.JSClickElement(LODInvestigationOfIllness);
                        break;
                    }
            }


            UIActions.TypeInTextBox(LODInvestigationCircumstancesDate, (UIActions.SelectDate(Convert.ToInt32(circumstanceDate)) + " 0000"));
            UIActions.JSClickElement(LODInvestigationCircumstancesDate);
            UIActions.TypeInTextBox(LODInvestigationPlace, place);
            UIActions.TypeInTextBox(LODInvestigationSustained, sustained);
            UIActions.TypeInTextBox(LODInvestigationMedicalDiagnosis, medDiagnosis);
            UIActions.TypeInTextBox(LODInvestigationRemark, remarks);
            UIActions.TypeInTextBox(LODInvestigationOrganization, organizationAndStation);

            if (presentForDuty == "Yes")
            {
                UIActions.JSClickElement(LODInvestigationYesPresentForDuty);
            }
            else if (presentForDuty == "No")
            {
                UIActions.JSClickElement(LODInvestigationNoPresentForDuty);
            }

            if (misconductOrNeglect == "Yes")
            {
                UIActions.JSClickElement(LODInvestigationYesIntentionalMisconductOrNeglect);
            }

            else if (misconductOrNeglect == "No")
            {
                UIActions.JSClickElement(LODInvestigationNoIntentionalMisconductOrNeglect);
            }

            if (mentallySound == "Yes")
            {
                UIActions.JSClickElement(LODInvestigationYesMentallySound);
            }

            else if (mentallySound == "No")
            {
                UIActions.JSClickElement(LODInvestigationYesMentallySound);
            }

            switch (findings)
            {
                case "In Line Of Duty":
                    {
                        UIActions.JSClickElement(LODInvestigationFindingInLineOfDuty);
                        break;
                    }
                case "Misconduct":
                    {
                        UIActions.JSClickElement(LODInvestigationFindingMisconduct);
                        break;
                    }
                case "No Misconduct":
                    {
                        UIActions.JSClickElement(LODInvestigationFindingNoMisconduct);
                        break;
                    }
            }


            if (!String.IsNullOrEmpty(ifAbsentFromDuty))
            {
                if (ifAbsentFromDuty == "With Authority")
                {
                    UIActions.JSClickElement(LODInvestigationAbsentWithAuthority);
                }

                else if (ifAbsentFromDuty == "Without Authority")
                {
                    UIActions.JSClickElement(LODInvestigationAbsentWithoutAuthority);
                }

            }

        }

        public void UpdateInvestigationRegularOrEadOption(string regularOrEad)
        {
            if (regularOrEad == "Yes")
            {
                UIActions.JSClickElement(LODInvestigationYesRegularOrEad);
            }

            else if (regularOrEad == "No")
            {
                UIActions.JSClickElement(LODInvestigationNoRegularOrEad);
            }


        }
        public void UpdateInvestigationLODShortTourOfAdForTraining(string shortTourOfAdForTraining, string startDate, string endDate)
        {
            if (shortTourOfAdForTraining == "Yes")
            {
                UIActions.JSClickElement(LODInvestigationYesShortTourOfAdForTraining);
            }

            else if (shortTourOfAdForTraining == "No")
            {
                UIActions.JSClickElement(LODInvestigationNoShortTourOfAdForTraining);
            }

            UIActions.TypeInTextBox(LODInvestigationInactiveDutyTrainingStartDate, (UIActions.SelectDate(Convert.ToInt32(startDate)) + " 0000"));
            UIActions.TypeInTextBox(LODInvestigationInactiveDutyTrainingFinishDate, (UIActions.SelectDate(Convert.ToInt32(endDate)) + " 0000"));
        }
        public void UpdateInvestigationCalledOrOrderedToAD(string calledOrOrderedToAD, string days)
        {
            if (calledOrOrderedToAD == "Yes")
            {
                UIActions.JSClickElement(LODInvestigationYesCalledOrOrderedToAd);
            }

            else if (calledOrOrderedToAD == "No")
            {
                UIActions.JSClickElement(LODInvestigationNoCalledOrOrderedToAd);
            }

            if (days == "30 Days or More")
            {
                UIActions.JSClickElement(LODInvestigationNoCalledOrOrderedToAd30DaysMore);
            }
            else if (days == "30 Days or Less")
            {
                UIActions.JSClickElement(LODInvestigationNoCalledOrOrderedToAd30DaysLess);
            }

        }

        public void UpdateInvestigationInactiveDutyTraining(string inactiveDutyTraining, string startDate, string endDate)
        {
            if (inactiveDutyTraining == "Yes")
            {
                UIActions.JSClickElement(LODInvestigationYesInactiveDutyTraining);
            }

            else if (inactiveDutyTraining == "No")
            {
                UIActions.JSClickElement(LODInvestigationYesInactiveDutyTraining);
            }

            UIActions.TypeInTextBox(LODInvestigationInactiveDutyTrainingStartDate, (UIActions.SelectDate(Convert.ToInt32(startDate)) + " 0000"));
            UIActions.TypeInTextBox(LODInvestigationInactiveDutyTrainingFinishDate, (UIActions.SelectDate(Convert.ToInt32(endDate)) + " 0000"));
        }


    }
}
