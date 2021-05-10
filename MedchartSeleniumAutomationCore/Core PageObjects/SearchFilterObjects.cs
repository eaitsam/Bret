using OpenQA.Selenium;

namespace MedchartSeleniumAutomationCore.Core_PageObjects
{
    public class SearchFilterObjects
    {
        public By OrgCombobox => By.Id("MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList");
        public By MedchartModuleComboBox => By.Id("MEDCHARTContent_MedchartPagesContent_ModuleList"); 
        public By RoleComboBox => By.Id("MEDCHARTContent_MedchartPagesContent_RoleDropDownList");
        public By RegionDropDown => By.Id("MEDCHARTContent_MedchartPagesContent_RegionDropDownList");
        public By FirstNameTxtBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserFirstName");
        public By MiddleNameTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_MiddleNameTextBox");
        public By LastNameTxtBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserLastName");
        public By EDIPINTxtBox => By.Id("MEDCHARTContent_MedchartPagesContent_EdiTextbox");
        public By SSNTxtBox => By.Id("MEDCHARTContent_MedchartPagesContent_SoldierSSNTextBox");

        public By PrimaryPhoneTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_PrimaryPhoneTextBox");
        public By PrimaryPhoneExtTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_PrimaryPhoneExt");
        public By EmailTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_EmailTextBox");
        public By DSNTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_EmailTextBox");
        public By SecondaryPhoneTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_SecondaryPhoneTextBox");
        public By SecondaryPhoneExtTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_SecondaryPhoneExt");

        /// <remarks>Find out what the difference between this and SSNTextBox is</remarks>
        public By SoldierEDIPINTxtBox => By.Id("MEDCHARTContent_MedchartPagesContent_SoldierEDIPITextBox");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_SearchButton");
        public By ResetButton => By.Id("MEDCHARTContent_MedchartPagesContent_ResetButton");
        public By RangeFromTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_RangeFromTextbox");
        public By RangeToTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_RangeToTextbox");


        //The following are the MEDCHART Pages Content objects that have a prefix of "uc"

        public By ucSSNTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierSearch_SSNText");
        public By ucEDIPINBox => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierSearch_EDIPIText");
        public By ucFirstNameBox => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierSearch_FirstNameText");
        public By ucLastNameBox => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierSearch_LastNameText");
        public By ucSearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierSearch_SearchButton");

        
    }
}
