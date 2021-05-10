using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.PageObjectModel.UserManagement
{
    public class UserDetailsPage
    {
        public By ClickHereLink => By.CssSelector("#Location > div:nth-child(1) > div:nth-child(2) > b:nth-child(1) > a:nth-child(1)");
        public By CancelButton => By.Id("MEDCHARTContentCACOnly_CancelButton");
        public By FirstName => By.Id("MEDCHARTContentCACOnly_FirstNameTextBox");
        public By MiddleName => By.Id("MEDCHARTContentCACOnly_MiddleNameTextBox");
        public By LastName => By.Id("MEDCHARTContentCACOnly_LastNameTextBox");
        public By PrimaryPhone => By.Id("MEDCHARTContentCACOnly_PrimaryPhoneTextBox");
        public By PrimaryPhoneExt => By.Id("MEDCHARTContentCACOnly_PrimaryPhoneExt");
        public By EmailAddress => By.Id("MEDCHARTContentCACOnly_EmailTextBox");
        public By SecondaryPhone => By.Id("MEDCHARTContentCACOnly_SecondaryPhoneTextBox");
        public By SecondaryPhoneExt => By.Id("MEDCHARTContentCACOnly_SecondaryPhoneExt");
        public By NextButton => By.Id("MEDCHARTContentCACOnly_NextButton");
        public By FirstNameErrorMessage => By.CssSelector("#MEDCHARTContentCACOnly_FirstNameValidatorCalloutExtender_popupTable > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(3)");
        public By RankErrorMessage => By.Id("MEDCHARTContentCACOnly_RankDropDownListCompareValidator");
        public By EmailErrorMessage => By.CssSelector("#MEDCHARTContentCACOnly_EmailRequiredValidatorCalloutExtender_popupTable > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(3)");
        public By WrongEmailMessage => By.CssSelector("#MEDCHARTContentCACOnly_EmailRegExValidatorCalloutExtender_popupTable > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(3)");
        public By LastnameErrorMessage => By.CssSelector("#MEDCHARTContentCACOnly_LastNameCalloutExtender_popupTable > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(3)");
        public By PrimaryPhoneErrorMessage => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr/td[3]");
        public By Rank => By.Id("MEDCHARTContentCACOnly_RankDropDownList");
        public By SecondaryPhoneErrorMessage => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div/div/table/tbody/tr[4]/td[4]/table/tbody/tr/td[3]");
        public By DSN => By.Id("MEDCHARTContentCACOnly_DSNTextBox");
        public By DSNErrorMessage => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div/div/table/tbody/tr[3]/td[4]/table/tbody/tr/td[3]");
        public By EcaseTab => By.Id("__tab_MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1");
        public By IssuingClinic => By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseIssuingClinicCredentials_IssuingClinicTextBox");
        public By Credential => By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseIssuingClinicCredentials_CredentialsDropDownList");
        public By Organization => By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_OrganizationDropDownList");
        public By UserRole => By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_ecaseRoleCheckBoxDataList_RoleCheckBoxesDataList_RoleCheckBox_3");
        public By State => By.Id("MEDCHARTContentCACOnly_ModulesTabContainer_ecaseModuleTab_1_ecaseModuleTabUserControl_1_RegionDropDownList");
        public By SubmitButton => By.CssSelector("div.ui-dialog:nth-child(4) > div:nth-child(3) > div:nth-child(1) > button:nth-child(1)");
        public By ReturnLoginButton => By.Id("MEDCHARTContentCACOnly_CancelButton");
        public By HIPAA => By.CssSelector(".xboxcontent > div:nth-child(2) > div:nth-child(3) > a:nth-child(1)");
        public By FileUpload => By.Id("MEDCHARTContentCACOnly_ucFileUpload_file");
        public By UploadButton => By.Id("FileUploadUploadButton");
        public By BrowseButton => By.Id("MEDCHARTContentCACOnly_ucFileUpload_file");
        public By CACAuthentication => By.Id("ctl00_PageBody_txtAKO");
        public By GoButton => By.Id("ctl00_PageBody_btnSubmit");
        public By ClickBegin => By.CssSelector("body > p:nth-child(12) > a:nth-child(1)");
        public By Continue => By.CssSelector("body > p:nth-child(8) > a:nth-child(1) > b:nth-child(1)");
    }
}
