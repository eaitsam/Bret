using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopSoldierPage
    {
        #region My ADOPs Soldier Tab Objects
        #region HTML Div
        public By ADOPSoldierMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPSoldierMenuDiv");

        #endregion

        //Soldier Data
        public By ADOPRankDropDownList = By.Id("MEDCHARTContent_EmmpsContent_RankDropDownList");

        public By ADOPYesAttachUnit = By.Id("MEDCHARTContent_EmmpsContent_AttachedUnitRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_AttachedUnitRadioButtonList"]/label[1]

        public By ADOPAttachedUICTextBox = By.Id("MEDCHARTContent_EmmpsContent_AttachedUICTextBox");
        //validation
        public By ADOPAttachedUICValidationMess = By.Id("validationMessage1");

        public By ADOPAttachedRegionDropdown = By.Id("MEDCHARTContent_EmmpsContent_AttachedRegionDropDownList");
        //validation
        public By ADOPAttachedRegionValidationMess = By.Id("validationMessage2");

        public By ADOPNoAttachUnit = By.Id("MEDCHARTContent_EmmpsContent_AttachedUnitRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_AttachedUnitRadioButtonList"]/label[2]

        public By ADOPPEBDDateBox = By.Id("MEDCHARTContent_EmmpsContent_PebdTextbox");
        public By ADOPGetPEBDinfo = By.Id("getSoldierPebdButton");
        
        //Soldier Contact Information
        public By ADOPStreetTextBox = By.Id("MEDCHARTContent_EmmpsContent_StreetTextbox");
        public By ADOPStreetTextBoxValidationMess = By.Id("validationMessage2");

        public By ADOPCityTextBox = By.Id("MEDCHARTContent_EmmpsContent_CityTextBox");
        public By ADOPCityTextBoxValidationMess = By.Id("validationMessage3");


        public By ADOPStateDropDownList = By.Id("MEDCHARTContent_EmmpsContent_SciStateDropDownList");
        public By ADOPStateDropDownListValidationMess = By.Id("validationMessage4");

        public By ADOPZipTextBox = By.Id("MEDCHARTContent_EmmpsContent_ZipTextBox");
        public By ADOPZipTextBoxValidationMess = By.Id("validationMessage5");


        public By ADOPAkoEmailTextBox = By.Id("MEDCHARTContent_EmmpsContent_AkoEmailTextBox");
        public By ADOPAkoEmailTextBoxValidationMess = By.Id("validationMessage6");
        public By ADOPAkoEmailGovMilValidationMess = By.Id("validationMessage7");


        public By ADOPHomePhoneTextBox = By.Id("MEDCHARTContent_EmmpsContent_HomePhoneTextBox");
        public By ADOPHomePhoneTextBoxValidationMess = By.Id("validationMessage8");
        public By ADOPHomePhoneTenDigitsValidationMess = By.Id("validationMessage9");


        public By ADOPCellPhoneTextBox = By.Id("MEDCHARTContent_EmmpsContent_CellPhoneTextBox");
        public By ADOPWorkPhoneTextBox = By.Id("MEDCHARTContent_EmmpsContent_WorkPhoneTextBox");

        //Unit Information
        public By ADOPUnitStreetTextBox = By.Id("MEDCHARTContent_EmmpsContent_UnitStreetTextBox");
        public By ADOPUnitCityTextBox = By.Id("MEDCHARTContent_EmmpsContent_UnitCityTextBox");
        public By ADOPUnitStateDropdownList = By.Id("MEDCHARTContent_EmmpsContent_UnitStateDropDownList");
        public By ADOPUnitZipTextBox = By.Id("MEDCHARTContent_EmmpsContent_UnitZipTextBox");
        public By ADOPUnitPOCEmailTextBox = By.Id("MEDCHARTContent_EmmpsContent_PocEmailTextBox");
        public By ADOPUnitPOCPhoneTextBox = By.Id("MEDCHARTContent_EmmpsContent_PocPhoneTextBox");

        //Home of Record Information
        public By ADOPHomeStreetTextBox = By.Id("MEDCHARTContent_EmmpsContent_HomeOfRecordStreetTextBox");
        public By ADOPHomeCityTextBox = By.Id("MEDCHARTContent_EmmpsContent_HomeOfRecordCityTextBox");
        public By ADOPHomeStateDropdownList = By.Id("MEDCHARTContent_EmmpsContent_HomeOfRecordStateDropDownList");
        public By ADOPHomeZipTextBox = By.Id("MEDCHARTContent_EmmpsContent_HomeOfRecordZipTextBox");
        public By ADOPHomePOCEmailTextBox = By.Id("MEDCHARTContent_EmmpsContent_HomeOfRecordEmailTextBox");
        public By ADOPHomePOCPhoneTextBox = By.Id("MEDCHARTContent_EmmpsContent_HomeOfRecordPhoneTextBox");

        //LOD Information
        public By ADOPYesLODInitiated = By.Id("MEDCHARTContent_EmmpsContent_LodInitiatedRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_LodInitiatedRadioButtonList"]/label[1]
        public By ADOPNoLODInitiated = By.Id("MEDCHARTContent_EmmpsContent_LodInitiatedRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_LodInitiatedRadioButtonList"]/label[2]
        public By ADOPYesLODexists = By.Id("MEDCHARTContent_EmmpsContent_LodExistRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_LodExistRadioButtonList"]/label[1]
        public By ADOPNoLODexists = By.Id("MEDCHARTContent_EmmpsContent_LodExistRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_LodExistRadioButtonList"]/label[2]
        #endregion

    }
}
