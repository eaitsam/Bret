using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODFormFindingsTab
    {
        //--------------------------------//
        //My LOD Form Findings Tab Objects
        //--------------------------------//
        public By LODFormFindingsMenuDiv => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODForm");
        public By LODFormFindingsAppointingUICTextBox => By.Id("MEDCHARTContent_EmmpsContent_formFindingsControl_AppointingUicTextBox");
        public By LODFormFindingsAppointingAuthorityReasonAndSubstitutedFindings => By.Id("MEDCHARTContent_EmmpsContent_formFindingsControl_AppointingTextBox");
        public By LODFormFindingsReviewingAuthorityReasonAndSubstitutedFindings => By.Id("MEDCHARTContent_EmmpsContent_formFindingsControl_ReviewingTextBox");
        public By LODFormFindingsFinalApprovalFindings => By.Id("MEDCHARTContent_EmmpsContent_formFindingsControl_ApprovalFindingsTextBox");
        public By LODFormFindingsFinalApprovalReasonAndSubstitutedFindings => By.Id("MEDCHARTContent_EmmpsContent_formFindingsControl_ApprovalAuthorityTextBox");

        //Radio Button
        public By LODFormFindingsAppointingAuthorityApproved => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_formFindingsControl_AppointingRadioButtonList\"]/tbody/tr/td[1]/label");
        public By LODFormFindingsAppointingAuthorityDisapproved => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_formFindingsControl_AppointingRadioButtonList\"]/tbody/tr/td[2]/label");
        public By LODFormFindingsReviewingAuthorityApproved => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div[2]/div[2]/div/div/table/tbody/tr[3]/td[2]/table/tbody/tr/td[1]/label");
        public By LODFormFindingsReviewingAuthorityDisapproved => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div[2]/div[2]/div/div/table/tbody/tr[3]/td[2]/table/tbody/tr/td[2]/label");


        public void UpdateFormFindingsAppointingAuthorityFindings(string decision)
        {
            if (decision == "Approved")
            {
                UIActions.JSClickElement(LODFormFindingsAppointingAuthorityApproved);
            }

            else if (decision == "Disapproved")
            {
                UIActions.JSClickElement(LODFormFindingsAppointingAuthorityDisapproved);
            }

        }


        public void UpdateFormFindingsAppointingAuthorityReasons(string reasons)
        {
            UIActions.TypeInTextBox(LODFormFindingsAppointingAuthorityReasonAndSubstitutedFindings, reasons);

        }

        public void UpdateFormFindingsReviewingAuthorityFindings(string decision, string reasons)
        {
            if (decision == "Approved")
            {
                UIActions.JSClickElement(LODFormFindingsReviewingAuthorityApproved);
            }

            else if (decision == "Disapproved")
            {
                UIActions.JSClickElement(LODFormFindingsReviewingAuthorityDisapproved);
            }
            UIActions.JSEnterText(LODFormFindingsReviewingAuthorityReasonAndSubstitutedFindings, reasons);

        }



        public void UpdateFormFindingsFinalApprovalFindings(string findings, string reasons)
        {
            UIActions.JSEnterText(LODFormFindingsFinalApprovalFindings, findings);
            UIActions.JSEnterText(LODFormFindingsFinalApprovalReasonAndSubstitutedFindings, reasons);
        }



    }
}
