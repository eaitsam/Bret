using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODSoldierTab
    {
        MiscPageOjects misc = new MiscPageOjects();
        //---------------------------//
        // My LOD Soldier Tab Objects
        //---------------------------//

        //--HTML Div--//
        public By LODSoldierMenuDiv => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODSoldierMenuDiv");
        public By LODSolierAttachedUicValidationMess => By.Id("validationMessage2");
        public By LODSolierAttachedRegionValidationMess => By.Id("validationMessage3");
        public By LODSolierContactStreetValidationMess => By.Id("validationMessage3");
        public By LODSolierContactCityValidationMess => By.Id("validationMessage4");
        public By LODSolierContactStateValidationMess => By.Id("validationMessage5");
        public By LODSolierContactZipValidationMess => By.Id("validationMessage6");
        public By LODSolierContactZipValidationMessInvalid => By.Id("validationMessage7");
        public By LODSolierContactAKOEmailValidationMess => By.Id("validationMessage11");
        public By LODSolierContactAKOEmailValidationMessInvalid => By.Id("validationMessage10");
        public By LODSolierContactHmPhoneValidationMess => By.Id("validationMessage9");
        public By LODSolierContactHmPhoneValidationMessInvalid => By.Id("validationMessage8");

        //--HTMLEdit and TextArea--//
        public By LODSolierContactDobDateTextbox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_DOBTextBox");

        //------------------//
        //Thru Address Boxes//
        //------------------//
        public By LODSoldierThruAddressUnitTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_thruAddress_UnitTextBox");
        public By LODSoldierThruAddressStreetTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_thruAddress_StreetTextBox");
        public By LODSoldierThruAddressCityTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_thruAddress_CityTextBox");
        public By LODSoldierThruAddressZipTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_thruAddress_ZipTextBox");
        public By MEDCHARTContent_EmmpsContent_thruAddress_UnitTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_thruAddress_UnitTextBox");


        //----------------//
        //To Address Boxes//
        //----------------//
        public By LODSoldierToAddressUnitTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_toAddress_UnitTextBox");
        public By LODSoldierToAddressStreetTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_toAddress_StreetTextBox");
        public By LODSoldierToAddressCityTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_toAddress_CityTextBox");
        public By LODSoldierToAddressZipTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_toAddress_ZipTextBox");

        //------------------//
        //From Address Boxes//
        //------------------//
        public By LODSoldierFromAddressUnitTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_fromAddress_UnitTextBox");
        public By LODSoldierFromAddressStreetTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_fromAddress_StreetTextBox");
        public By LODSoldierFromAddressCityTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_fromAddress_CityTextBox");
        public By LODSoldierFromAddressZipTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_fromAddress_ZipTextBox");

        //-------------------------------//
        //Soldier Data Text Boxes//
        //-------------------------------//
        /// <summary>
        /// each section gets the title & then the solider's personal data
        /// </summary>
        public By LODSoliderDataRank => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[1]");
        public By LODSoliderDataRankInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[2]/span");

        public By LODSoliderDataOrg => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[2]/td[1]");
        public By LODSoliderDataOrgInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[2]/td[2]/span");

        public By LODSoliderDataCompo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[3]/td[1]");
        public By LODSoliderDataCompoInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[3]/td[2]/span");

        public By LODSoliderDataUic => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[4]/td[1]");
        public By LODSoliderDataUicInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[4]/td[2]/span");

        public By LODSoliderDataRegion => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[1]/td[1]");
        public By LODSoliderDataRegionInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[1]/td[2]/span");

        public By LODSoliderDataDob => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[2]/td[1]");
        public By LODSoliderDataDobInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[2]/td[2]/span[2]");

        public By LODSoliderDatatUnitInfo => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AttachedUnitLabel");

        public By LODSoliderDataAttachedRegionInfo => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AttachedRegionLabel");

        /// <summary>
        /// Read/write information
        /// </summary>

        // public By LODSoliderDataAttachedUnit => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table[5]/tbody/tr[3]/td[2]/table/tbody/tr/td[1]/label");
        public By LODSoliderDataAttachedUnit => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AttachedUnitHeaderLabel");

        public By LODSoliderDataAttachedUICTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AttachedUICTextBox");
        public By LODSoliderDataAttachedUICVerifyButton => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_UicVerifyButton");
        public By LODSoliderDataAttachedRegionDropdown => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AttachedRegionDropDownList");




        //-------------------------------//
        //Soldier Contact Info Text Boxes//
        //-------------------------------//
        public By LODSoldierContactInfoStreetAddressTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_soldierContactInformationAddress_StreetTextBox");
        public By LODSoldierContactInfoCityTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_soldierContactInformationAddress_CityTextBox");
        public By LODSoldierContactInfoZipTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_soldierContactInformationAddress_ZipTextBox");
        public By LODSoldierContactInfoEmailTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AKOEmailTextBox");
        public By LODSoldierContactInfoHomePhoneTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_HomePhoneTextBox");
        public By LODSoldierContactInfoCellPhoneTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_CellPhoneTextBox");
        public By LODSoldierContactInfoWorkPhoneTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_WorkPhoneTextBox");
        /// <summary>
        /// each section gets the title & then the solider's personal contact info
        /// </summary>
        public By LODSoliderContactStreet => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[2]/td[1]");
        public By LODSoliderContactStreetInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[2]/td[2]/span");

        public By LODSoliderContactCity => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[3]/td[1]");
        public By LODSoliderContactCityInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[3]/td[2]/span");

        public By LODSoliderContactState => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[4]/td[1]");
        public By LODSoliderContactStateInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[4]/td[2]/span");

        public By LODSoliderContactZip => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[5]/td[1]");
        public By LODSoliderContactZipInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[3]/table/tbody/tr[5]/td[2]/span");

        public By LODSoliderContactAKO => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[1]/td[3]");
        public By LODSoliderContactAKOInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[1]/td[4]/span");

        public By LODSoliderContactHomePh => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[2]/td[3]");
        public By LODSoliderContactHomePhInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[2]/td[4]/span");

        public By LODSoliderContactCellPh => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[3]/td[3]");
        public By LODSoliderContactCellPhInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[3]/td[4]/span");

        public By LODSoliderContactWorkPh => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[4]/td[3]");
        public By LODSoliderContactWorkPhInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[4]/td[4]/span");


        //-------------------------------//
        //         Unit Information      //
        //-------------------------------//
        /// <summary>
        /// each section gets the title & then the solider's personal contact info
        /// </summary>
        public By LODUnitInformationStreet => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[2]/td[1]");
        public By LODUnitInformationStreetInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[2]/td[2]/span");

        public By LODUnitInformationCity => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[3]/td[1]");
        public By LODUnitInformationCityInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[3]/td[2]/span");

        public By LODUnitInformationState => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[4]/td[1]");
        public By LODUnitInformationStateInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[4]/td[2]/span");

        public By LODUnitInformationZip => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[5]/td[1]");
        public By LODUnitInformationZipInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[4]/tbody/tr[1]/td[4]/table/tbody/tr[5]/td[2]/span");

        public By LODUnitInformationPocEmail => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[1]/td[5]/span");
        public By LODUnitInformationPocEmailInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[1]/td[6]/span");

        public By LODUnitInformationPocPhone => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[2]/td[5]/span");
        public By LODUnitInformationPocPhoneInfo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[2]/td[6]/span");

        public By LODUnitInformationStreetTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_unitInfoAddress_StreetTextBox");
        public By LODUnitInformationCityTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_unitInfoAddress_CityTextBox");
        public By LODUnitInformationStateDropDown => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_unitInfoAddress_RegionDropDownList");
        public By LODUnitInformationZipTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_unitInfoAddress_ZipTextBox");
        public By LODUnitInformationPocEmailTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_POCEmailTextBox");
        public By LODUnitInformationPocPhoneTextBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_POCPhoneTextBox");
        //-------------------------------//
        //--Soldier Tab ComboBox-//
        //-------------------------------//

        public By LODSoldierThruAddressRegionDropDown => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_thruAddress_RegionDropDownList");
        public By LODSoldierToAddressRegionDropDown => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_toAddress_RegionDropDownList");
        public By LODSoldierFromAddressRegionDropDown => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_fromAddress_RegionDropDownList");
        public By LODSoldierRankDropDown => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RankDropDownList");
        //LOOK UP ID OF LODSOLDIERCONTACTINFOSTATEDROPDOWN
        public By LODSoldierContactInfoStateDropDown => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_soldierContactInformationAddress_RegionDropDownList");


        //--Checkboxes--//
        public By LODSoldierThruAddressMakeDefaultChkBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_thruAddress_cbMakeDefault");
        public By LODSoldierToAddressMakeDefaultChkBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_toAddress_cbMakeDefault");
        public By LODSoldierFromAddressMakeDefaultChkBox => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_fromAddress_cbMakeDefault");

        //--Radial Buttons--//

        //public By LODSoldierAttachedUnitYes => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[3]/td[2]/table/tbody/tr/td[1]/label");
        public By LODSoldierAttachedUnitYes => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AttachedUnitRadioButtonList_0");
        // public By LODSoldierAttachedUnitNo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[5]/tbody/tr[3]/td[2]/table/tbody/tr/td[2]/label");
        public By LODSoldierAttachedUnitNo => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_AttachedUnitRadioButtonList_1");

        //These as well.
        // public By LODSoldierABCMRCaseYes => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[1]/span/label[1]");
        public By LODSoldierABCMRCaseYes => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListABCMRCase_0");
        //  public By LODSoldierABCMRCaseNo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[1]/span/label[2]");
        public By LODSoldierABCMRCaseNo => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListABCMRCase_1");
        //  public By LODSoldierAGRCaseYes => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[2]/span/label[1]");
        public By LODSoldierAGRCaseYes => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListAGRCase_0");
        //  public By LODSoldierAGRCaseNo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[2]/span/label[2]");
        public By LODSoldierAGRCaseNo => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListAGRCase_1");
        //  public By LODSoldierBehavioralCaseYes => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[3]/span/label[1]");
        public By LODSoldierBehavioralCaseYes => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListBehavioralHealthCase_0");
        //     public By LODSoldierBehavioralCaseNo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[3]/span/label[2]");
        public By LODSoldierBehavioralCaseNo => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListBehavioralHealthCase_1");
        //    public By LODSoldierIDESCaseYes => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[4]/span/label[1]");
        public By LODSoldierIDESCaseYes => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListIDESCase_0");
        //     public By LODSoldierIDESCaseNo => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/div/table[7]/tbody/tr/td[4]/div[4]/span/label[2]");
        public By LODSoldierIDESCaseNo => By.Id("MEDCHARTContent_EmmpsContent_soldierControl_RadioButtonListIDESCase_1");


        public List<string> RegionStatesList => new List<string> { "--Select--", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "HQ NGB", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "OCONUS", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        public void VerifyAllReqFieldsSoldierTab()
        {
            //Clear fields in case data there to show the required fields 
            //ClearAllReqFieldsSoldierTab();

            //verify messages for all required fields show            
            //Assert.True(UIValidations.IsElementPresent(LODSolierContactStreetValidationMess));
            //Assert.True(UIValidations.IsElementPresent(LODSolierContactCityValidationMess));
            //Assert.True(UIValidations.IsElementPresent(LODSolierContactStateValidationMess));
            //Assert.True(UIValidations.IsElementPresent(LODSolierContactZipValidationMess));
            //Assert.True(UIValidations.IsElementPresent(LODSolierContactAKOEmailValidationMess));
            //Assert.True(UIValidations.IsElementPresent(LODSolierContactHmPhoneValidationMess));
        }

        public void VerifyAllReqFieldsUpdatedSoldierTab()
        {
            //Veirfy messages for all required fields is no longer showing            
            //Assert.False(UIValidations.IsElementPresent(LODSolierContactStreetValidationMess));
            //Assert.False(UIValidations.IsElementPresent(LODSolierContactCityValidationMess));
            //Assert.False(UIValidations.IsElementPresent(LODSolierContactStateValidationMess));
            //Assert.False(UIValidations.IsElementPresent(LODSolierContactZipValidationMess));
            //Assert.False(UIValidations.IsElementPresent(LODSolierContactAKOEmailValidationMess));
            //Assert.False(UIValidations.IsElementPresent(LODSolierContactHmPhoneValidationMess));
            Assert.False(ObjectRepository.Driver.FindElements(LODSolierContactStreetValidationMess).Count == 1);
        }

        public void ClearAllReqFieldsSoldierTab()
        {
            UIActions.ClearTextBox(LODSoldierContactInfoStreetAddressTextBox);
            UIActions.ClearTextBox(LODSoldierContactInfoCityTextBox);
            UIActions.SelectElementByText(LODSoldierContactInfoStateDropDown, "--Select--");
            UIActions.ClearTextBox(LODSoldierContactInfoZipTextBox);
            UIActions.ClearTextBox(LODSoldierContactInfoEmailTextBox);
            UIActions.ClearTextBox(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.ClearTextBox(LODSoldierContactInfoCellPhoneTextBox);


        }

        public void UpdateRequiredFieldsSoldierTab(string contactStreet, string contactCity, string contactState, string contactZip, string contactAKOEmail, string contactHmPhone)
        {
            WaitMethods.Wait(LODSoldierContactInfoStreetAddressTextBox, 60);
            string streetAddress = UIActions.GetTextBoxTextValue(LODSoldierContactInfoStreetAddressTextBox);

            if (streetAddress.Length == 0)
            {
                UIActions.TypeInTextBox(LODSoldierContactInfoStreetAddressTextBox, contactStreet);
            }

            string city = UIActions.GetTextBoxTextValue(LODSoldierContactInfoCityTextBox);

            if (city.Length == 0)
            {
                UIActions.TypeInTextBox(LODSoldierContactInfoCityTextBox, contactCity);
            }

            string state = UIActions.GetTextBoxTextValue(LODSoldierContactInfoStateDropDown);

            if (state.Length == 0 || state == "--Select--" || state == "-1")//when "--Select--" is selected the state text returns "-1" as the value so this will allow the region to be updated correctly
            {
                UIActions.SelectElementByText(LODSoldierContactInfoStateDropDown, contactState);
            }

            string zip = UIActions.GetTextBoxTextValue(LODSoldierContactInfoZipTextBox);

            if (zip.Length == 0)
            {
                UIActions.TypeInTextBox(LODSoldierContactInfoZipTextBox, contactZip);
            }

            string email = UIActions.GetTextBoxTextValue(LODSoldierContactInfoEmailTextBox);

            if (email.Length == 0)
            {
                UIActions.TypeInTextBox(LODSoldierContactInfoEmailTextBox, contactAKOEmail);
            }

            string hmPhone = UIActions.GetTextBoxTextValue(LODSoldierContactInfoHomePhoneTextBox);

            if (hmPhone.Length == 0)
            {
                UIActions.TypeInTextBox(LODSoldierContactInfoHomePhoneTextBox, contactHmPhone);
            }

            string cellPhone = UIActions.GetTextBoxTextValue(LODSoldierContactInfoHomePhoneTextBox);

            if (cellPhone.Length == 0)
            {
                UIActions.TypeInTextBox(LODSoldierContactInfoCellPhoneTextBox, contactHmPhone);
            }


        }

        public void NewLODSoldierTabBasicRequiredFieldsEntry(string state, string zipcode)
        {
            UIActions.TypeInTextBox(LODSoldierContactInfoStreetAddressTextBox, "1111 Imagination Lane");
            UIActions.TypeInTextBox(LODSoldierContactInfoCityTextBox, "Red Herring");
            UIActions.SelectElementByValue(LODSoldierContactInfoStateDropDown, state);
            UIActions.TypeInTextBox(LODSoldierContactInfoZipTextBox, zipcode);
            UIActions.TypeInTextBox(LODSoldierContactInfoEmailTextBox, "returntosender@something.mil");
            UIActions.TypeInTextBox(LODSoldierContactInfoHomePhoneTextBox, "7038675309");
            UIActions.TypeInTextBox(LODSoldierContactInfoHomePhoneTextBox, "5718675309");
        }

        public void VerifyDropDownListSoliderTab()
        {

            //Verify dropdownlist
            //Assert.True(UIActions.ComboboxInnerTextValidator(LODSoldierThruAddressRegionDropDown, RegionStatesList));
            //Assert.True(UIActions.ComboboxInnerTextValidator(LODSoldierToAddressRegionDropDown, RegionStatesList));
            //Assert.True(UIActions.ComboboxInnerTextValidator(LODSoldierFromAddressRegionDropDown, RegionStatesList));
            //Assert.True(UIActions.ComboboxInnerTextValidator(LODSoldierContactInfoStateDropDown, RegionStatesList));
            Assert.True(UIActions.ComboboxInnerTextValidator(LODSoldierRankDropDown, new List<string> { "--Select--", "Private (PV1)", "Private (PV2)", "Private First Class (PFC)", "Specialist (SPC)", "Corporal (CPL)", "Sergeant (SGT)", "Staff Sergeant (SSG)", "Sergeant First Class (SFC)", "Master Sergeant (MSG)", "First Sergeant (1SG)", "Sergeant Major (SGM)", "Command Sergeant Major (CSM)", "Sergeant Major of the Army (SMA)", "Warrant Officer 1 (WO1)", "Chief Warrant Officer 2 (CW2)", "Chief Warrant Officer 3 (CW3)", "Chief Warrant Officer 4 (CW4)", "Chief Warrant Officer 5 (CW5)", "Second Lieutenant (2LT)", "First Lieutenant (1LT)", "Captain (CPT)", "Major (MAJ)", "Lieutenant Colonel (LTC)", "Colonel (COL)", "Brigadier General (BG)", "Major General (MG)", "Lieutenant General (LTG)", "General (GEN)" }));

        }

        public void VerifyNumericOnlyFieldsSoldierTab()
        {

            string textBoxValue = string.Empty;
            string holdTextBoxValue = string.Empty; //used to account for data that may already be in the numeric field

            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSoldierFromAddressZipTextBox);
            UIActions.TypeInTextBox(LODSoldierFromAddressZipTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSoldierFromAddressZipTextBox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address From Zip should not except alphanumeric data");

            textBoxValue = string.Empty;
            holdTextBoxValue = string.Empty;
            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSoldierToAddressZipTextBox);
            UIActions.TypeInTextBox(LODSoldierToAddressZipTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSoldierToAddressZipTextBox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address To Zip should not except alphanumeric data");

            textBoxValue = string.Empty;
            holdTextBoxValue = string.Empty;
            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSoldierThruAddressZipTextBox);
            UIActions.TypeInTextBox(LODSoldierThruAddressZipTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSoldierThruAddressZipTextBox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Thru Zip should not except alphanumeric data");

            textBoxValue = string.Empty;
            holdTextBoxValue = string.Empty;
            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoZipTextBox);
            UIActions.TypeInTextBox(LODSoldierContactInfoZipTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoZipTextBox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Zip should not except alphanumeric data");

            textBoxValue = string.Empty;
            holdTextBoxValue = string.Empty;
            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.TypeInTextBox(LODSoldierContactInfoHomePhoneTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoHomePhoneTextBox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Home Phone should not except alphanumeric data");

            textBoxValue = string.Empty;
            holdTextBoxValue = string.Empty;
            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoCellPhoneTextBox);
            UIActions.TypeInTextBox(LODSoldierContactInfoCellPhoneTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoCellPhoneTextBox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Cell Phone should not except alphanumeric data");

            textBoxValue = string.Empty;
            holdTextBoxValue = string.Empty;
            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoWorkPhoneTextBox);
            UIActions.TypeInTextBox(LODSoldierContactInfoWorkPhoneTextBox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSoldierContactInfoWorkPhoneTextBox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info Work Phone should not except alphanumeric data");

            textBoxValue = string.Empty;
            holdTextBoxValue = string.Empty;
            holdTextBoxValue = UIActions.GetTextBoxTextValue(LODSolierContactDobDateTextbox);
            UIActions.TypeInTextBox(LODSolierContactDobDateTextbox, "alpha");
            textBoxValue = UIActions.GetTextBoxTextValue(LODSolierContactDobDateTextbox);
            Assert.False(textBoxValue.Length > holdTextBoxValue.Length, "Address Contact Info DOB should not except alphanumeric data");

        }

        public void VerifyFieldsOnSoldierTab()
        {
            //Verify fields exist         
            //Assert.True(UIValidations.IsElementPresent(LODSoldierThruAddressUnitTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierThruAddressStreetTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierThruAddressCityTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierThruAddressRegionDropDown));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierThruAddressZipTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierThruAddressMakeDefaultChkBox));

            //Assert.True(UIValidations.IsElementPresent(LODSoldierToAddressUnitTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierToAddressStreetTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierToAddressCityTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierToAddressRegionDropDown));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierToAddressZipTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierToAddressMakeDefaultChkBox));

            //Assert.True(UIValidations.IsElementPresent(LODSoldierFromAddressUnitTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierFromAddressStreetTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierFromAddressCityTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierFromAddressRegionDropDown));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierFromAddressZipTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierFromAddressMakeDefaultChkBox));

            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoStreetAddressTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoCityTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoStateDropDown));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoZipTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoEmailTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoHomePhoneTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoCellPhoneTextBox));
            //Assert.True(UIValidations.IsElementPresent(LODSoldierContactInfoWorkPhoneTextBox));



        }

        /// <summary>
        /// Verify default fields selected on the Soldier Tab
        /// </summary>
        public void VerifyDefaultFieldsSelectedOnSoldierTab()
        {

            //To Do The Yes/No buttons are HtmlLabels and not working with isSelected or isChecked attributes

            //Assert.True(Convert.ToBoolean(Convert.ToInt32(ObjectRepository.Driver.FindElement(LODSoldierAttachedUnitNo).GetAttribute("checked"))));
            //Assert.True(Convert.ToBoolean(Convert.ToInt32(ObjectRepository.Driver.FindElement(LODSoldierAttachedUnitYes).GetAttribute("checked"))));
            //Assert.True(UIValidations.IsElementChecked(LODSoldierAttachedUnitNo));
            //Assert.True(UIValidations.IsElementChecked(LODSoldierAttachedUnitYes));

            //Assert.True(UIValidations.IsElementSelected(LODSoldierAttachedUnitNo));
            //Assert.True(UIValidations.IsElementSelected(LODSoldierABCMRCaseNo));
            //Assert.True(UIValidations.IsElementSelected(LODSoldierAGRCaseNo));
            //Assert.True(UIValidations.IsElementSelected(LODSoldierBehavioralCaseNo));
            //Assert.True(UIValidations.IsElementSelected(LODSoldierIDESCaseNo));

        }

        public void VerifyLODSoldierPageTabs()
        {
            Thread.Sleep(3000);
            //verify fields exist
            //Assert.True(UIValidations.IsElementPresent(LODMedicalMenuLinkButton));
            //Assert.True(UIValidations.IsElementPresent(LODUnitMenuLinkButton));
            //Assert.True(UIValidations.IsElementPresent(LODDocumentsMenuLinkButton));
            //Assert.True(UIValidations.IsElementPresent(LODNextActionMenuLinkButton));
            //Assert.True(UIValidations.IsElementPresent(LODTrackingMenuLinkButton));

        }

        public void VerifyValidations()
        {
            UIActions.ClearTextBox(LODSoldierContactInfoStreetAddressTextBox);
            UIActions.GetElement(LODSolierContactStreetValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactStreetValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoStreetAddressTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoStreetAddressTextBox, "55 Test St");
            UIActions.JSClickElement(LODSoldierContactInfoStreetAddressTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactStreetValidationMess).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoCityTextBox);
            UIActions.GetElement(LODSolierContactCityValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactCityValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoCityTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoCityTextBox, "FairFax");
            UIActions.JSClickElement(LODSoldierContactInfoCityTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactCityValidationMess).Count.Should().Be(0);

            UIActions.SelectElementByText(LODSoldierContactInfoStateDropDown, "--Select--");
            UIActions.GetElement(LODSolierContactStateValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactStateValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODSoldierContactInfoStateDropDown, "Virginia");
            UIActions.JSClickElement(LODSoldierContactInfoStateDropDown);
            ObjectRepository.Driver.FindElements(LODSolierContactStateValidationMess).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoZipTextBox);
            UIActions.GetElement(LODSolierContactZipValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactZipValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoZipTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoZipTextBox, "2");
            UIActions.JSClickElement(LODSoldierContactInfoZipTextBox);
            UIActions.GetElement(LODSolierContactZipValidationMessInvalid).Text.Should().BeEquivalentTo("Invalid Zip Code.");
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoZipTextBox, "22031");
            UIActions.JSClickElement(LODSoldierContactInfoZipTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactZipValidationMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODSolierContactZipValidationMessInvalid).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoEmailTextBox);
            UIActions.GetElement(LODSolierContactAKOEmailValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactAKOEmailValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.GetElement(LODSolierContactAKOEmailValidationMessInvalid).Text.Should().BeEquivalentTo("Invalid Email Address; must be .gov or .mil");
            UIActions.JSClickElement(LODSoldierContactInfoEmailTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoEmailTextBox, "test@mail.mil");
            UIActions.JSClickElement(LODSoldierContactInfoEmailTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactAKOEmailValidationMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODSolierContactAKOEmailValidationMessInvalid).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.GetElement(LODSolierContactHmPhoneValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactHmPhoneValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.GetElement(LODSolierContactHmPhoneValidationMessInvalid).Text.Should().BeEquivalentTo("Invalid Phone Number");
            UIActions.JSClickElement(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoHomePhoneTextBox, "703-111-1111");
            UIActions.JSClickElement(LODSoldierContactInfoHomePhoneTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactHmPhoneValidationMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODSolierContactHmPhoneValidationMessInvalid).Count.Should().Be(0);
        }

        public void VerifyFormalValidations()
        {
            UIActions.ClearTextBox(LODSoldierContactInfoStreetAddressTextBox);
            UIActions.GetElement(LODSolierContactStreetValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactStreetValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoStreetAddressTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoStreetAddressTextBox, "55 Test St");
            UIActions.JSClickElement(LODSoldierContactInfoStreetAddressTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactStreetValidationMess).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoCityTextBox);
            UIActions.GetElement(LODSolierContactCityValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactCityValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoCityTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoCityTextBox, "FairFax");
            UIActions.JSClickElement(LODSoldierContactInfoCityTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactCityValidationMess).Count.Should().Be(0);

            UIActions.SelectElementByText(LODSoldierContactInfoStateDropDown, "--Select--");
            UIActions.GetElement(LODSolierContactStateValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactStateValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.SelectElementByText(LODSoldierContactInfoStateDropDown, "Virginia");
            UIActions.JSClickElement(LODSoldierContactInfoStateDropDown);
            ObjectRepository.Driver.FindElements(LODSolierContactStateValidationMess).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoZipTextBox);
            UIActions.GetElement(LODSolierContactZipValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactZipValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoZipTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoZipTextBox, "2");
            UIActions.JSClickElement(LODSoldierContactInfoZipTextBox);
            UIActions.GetElement(LODSolierContactZipValidationMessInvalid).Text.Should().BeEquivalentTo("Invalid Zip Code.");
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoZipTextBox, "22031");
            UIActions.JSClickElement(LODSoldierContactInfoZipTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactZipValidationMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODSolierContactZipValidationMessInvalid).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoEmailTextBox);
            UIActions.GetElement(LODSolierContactAKOEmailValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactAKOEmailValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoEmailTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoEmailTextBox, "test@mail.com");
            UIActions.JSClickElement(LODSoldierContactInfoEmailTextBox);
            UIActions.GetElement(LODSolierContactAKOEmailValidationMessInvalid).Text.Should().BeEquivalentTo("Invalid Email Address; must be .gov or .mil");
            UIActions.ClearTextBox(LODSoldierContactInfoEmailTextBox);
            UIActions.JSClickElement(LODSoldierContactInfoEmailTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoEmailTextBox, "test@mail.mil");
            UIActions.JSClickElement(LODSoldierContactInfoEmailTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactAKOEmailValidationMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODSolierContactAKOEmailValidationMessInvalid).Count.Should().Be(0);

            UIActions.ClearTextBox(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.GetElement(LODSolierContactHmPhoneValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierContactHmPhoneValidationMess).Text.Should().BeEquivalentTo("Required");
            UIActions.JSClickElement(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoHomePhoneTextBox, "703-111-111");
            UIActions.JSClickElement(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.GetElement(LODSolierContactHmPhoneValidationMessInvalid).Text.Should().BeEquivalentTo("Invalid Phone Number");
            UIActions.ClearTextBox(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.JSClickElement(LODSoldierContactInfoHomePhoneTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoldierContactInfoHomePhoneTextBox, "703-111-1111");
            UIActions.JSClickElement(LODSoldierContactInfoHomePhoneTextBox);
            ObjectRepository.Driver.FindElements(LODSolierContactHmPhoneValidationMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODSolierContactHmPhoneValidationMessInvalid).Count.Should().Be(0);
            UIActions.JSClickElement(LODSoldierAttachedUnitYes);
        }

        public void VerifyAttachedUnitValidations()
        {
            UIActions.GetElement(LODSolierAttachedUicValidationMess).Displayed.Should().BeTrue();
            UIActions.GetElement(LODSolierAttachedRegionValidationMess).Displayed.Should().BeTrue();
            UIActions.TypeInTextBoxAndEnter(LODSoliderDataAttachedUICTextBox, "abcdef");
            UIActions.JSClickElement(LODSoliderDataAttachedUICVerifyButton);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
            UIActions.JSClickElement(LODSoliderDataAttachedUICTextBox);
            UIActions.ClearTextBox(LODSoliderDataAttachedUICTextBox);
            UIActions.TypeInTextBoxAndEnter(LODSoliderDataAttachedUICTextBox, "W8YL01");
            UIActions.JSClickElement(LODSoliderDataAttachedUICVerifyButton);
            WaitMethods.WaitForAnimationtoComplete(misc.WaitingAnimationDiv, 60);
            ObjectRepository.Driver.FindElements(LODSolierAttachedUicValidationMess).Count.Should().Be(0);
            ObjectRepository.Driver.FindElements(LODSolierAttachedRegionValidationMess).Count.Should().Be(0);
        }
    }
}
