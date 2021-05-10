using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyIncapSoldierPage
    {
        #region My INCAP Soldier Tab Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//

        #region HTML Div
        public By INCAPSoldierMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_INCAPSoldierMenuDiv");
        #endregion
        #region HTML Text Boxes
        public By INCAPFilterByDateCreated => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div/div/div[2]/div/div/div/div/div[3]/table/tbody/tr[1]/th[10]/a");
        public By MyINCAPFilterByDateCreated => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[2]/div/div[3]/table/tbody/tr[1]/th[9]/a");
        public By INCAPSoldierHomeAddressStreetTextbox = By.Id("MEDCHARTContent_EmmpsContent_homeAddressWrite_StreetTextBox");
        public By IncapHCIStreetBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$homeAddressWrite$StreetTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[3]/td[2]");

        public By INCAPSoldierHomeAddressCityTextbox = By.Id("MEDCHARTContent_EmmpsContent_homeAddressWrite_CityTextBox");
        public By IncapHCICityBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$homeAddressWrite$CityTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[4]/td[2]");

        public By INCAPSoldierHomeAddressZipTextbox = By.Id("MEDCHARTContent_EmmpsContent_homeAddressWrite_ZipTextBox");
        public By IncapHCIZipBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$homeAddressWrite$ZipTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[6]/td[2]");

        public By INCAPSoldierEmailTextbox = By.Id("MEDCHARTContent_EmmpsContent_EmailTextBox");
        public By IncapHCIeMailBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$EmailTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[2]/td[2]");

        public By INCAPSoldierHomePhoneTextbox = By.Id("MEDCHARTContent_EmmpsContent_HomePhoneTextBox");
        public By IncapHCIHomePhoneBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$HomePhoneTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[3]/td[2]");

        public By INCAPSoldierCellPhoneTextbox = By.Id("MEDCHARTContent_EmmpsContent_CellPhoneTextBox");
        public By IncapHCICellPhoneBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$CellPhoneTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[4]/td[2]");

        public By INCAPSoldierWorkPhoneTextbox = By.Id("MEDCHARTContent_EmmpsContent_WorkPhoneTextBox");
        public By IncapHCIWorkPhoneBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$WorkPhoneTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[5]/td[2]");

        public By INCAPSoldierUnitAddressStreetTextbox = By.Id("MEDCHARTContent_EmmpsContent_unitAddressWrite_StreetTextBox");
        public By IncapUCIStreetBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$unitAddressWrite$StreetTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[3]/td[2]");

        public By INCAPSoldierUnitAddressCityTextbox = By.Id("MEDCHARTContent_EmmpsContent_unitAddressWrite_CityTextBox");
        public By IncapUCICityBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$unitAddressWrite$CityTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[4]/td[2]");

        public By INCAPSoldierUnitAddressZipTextbox = By.Id("MEDCHARTContent_EmmpsContent_unitAddressWrite_ZipTextBox");
        public By IncapUCIZipBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$unitAddressWrite$ZipTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[6]/td[2]");

        public By INCAPSoldierUnitEmailTextbox = By.Id("MEDCHARTContent_EmmpsContent_UnitEmailTextBox");
        public By IncapUCIeMailBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$UnitEmailTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[2]/td[2]");

        public By INCAPSoldierUnitPhoneTextbox = By.Id("MEDCHARTContent_EmmpsContent_UnitPhoneTextBox");
        public By IncapUCIPhoneBox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$UnitPhoneTextBox')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[3]/td[2]");

        public By INCAPSoldierPEBDTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$PebdTextbox')]");//By.Id("MEDCHARTContent_EmmpsContent_PebdTextbox");
        public By INCAPSoldierETSDateTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$EtsDateTextbox')]");//By.Id("MEDCHARTContent_EmmpsContent_EtsDateTextbox");
        public By INCAPSoldierFitnessTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FitnessTextBox')]");//By.Id("MEDCHARTContent_EmmpsContent_FitnessTextBox");
        public By INCAPSoldierMEBStatusTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$MebStatusTextBox')]");//By.Id("MEDCHARTContent_EmmpsContent_MebStatusTextBox");
        public By INCAPSoldierPEBStatusTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$PebStatusTextBox')]");//By.Id("MEDCHARTContent_EmmpsContent_PebStatusTextBox");
        public By INCAPSoldierPDAStatusTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$PdaTextBox')]");//By.Id("MEDCHARTContent_EmmpsContent_PdaTextBox");
        public By INCAPSoldierMEBIncidentTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$MebIncidentTextBox')]");//By.Id("MEDCHARTContent_EmmpsContent_MebIncidentTextBox");
        public By INCAPSoldierPEBIncidentTextbox = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$PebIncidentTextBox')]");//By.Id("MEDCHARTContent_EmmpsContent_PebIncidentTextBox");
        #endregion
        #region HTML Combo Boxes
        public By INCAPSoldierHomeAddressRegionComboBox = By.Id("MEDCHARTContent_EmmpsContent_homeAddressWrite_RegionDropDownList");
        public By IncapHCIStateBox = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$homeAddressWrite$RegionDropDownList')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[5]/td[2]");

        public By INCAPSoldierUnitAddressRegionComboBox = By.Id("MEDCHARTContent_EmmpsContent_unitAddressWrite_RegionDropDownList");
        public By IncapUCIStateBox = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$unitAddressWrite$RegionDropDownList')]");//"/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[5]/td[2]");

        public By INCAPSoldierEmploymentComboBox = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$EmploymentDropDownList')]");
        public By INCAPSoldierDutyStatusComboBox = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$DutyStatusDropDownList')]");

        #endregion
        #region HTML Radio Buttons
        public By INCAPSoldierFitnessYesButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FitnessRadioButtonList_0')]");//By.Id("MEDCHARTContent_EmmpsContent_FitnessRadioButtonList_0");
        public By INCAPSoldierFitnessNoButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FitnessRadioButtonList_1')]");//By.Id("MEDCHARTContent_EmmpsContent_FitnessRadioButtonList_1");
        public By INCAPSoldierMEBStatusYesButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_MebStatusRadioButtonList_0')]");//By.Id("MEDCHARTContent_EmmpsContent_MebStatusRadioButtonList_0");
        public By INCAPSoldierMEBStatusNoButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_MebStatusRadioButtonList_1')]");//By.Id("MEDCHARTContent_EmmpsContent_MebStatusRadioButtonList_1");
        public By INCAPSoldierPEBStatusYesButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_PebStatusRadioButtonList_0')]");//By.Id("MEDCHARTContent_EmmpsContent_PebStatusRadioButtonList_0");
        public By INCAPSoldierPEBStatusNoButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_PebStatusRadioButtonList_1')]");//By.Id("MEDCHARTContent_EmmpsContent_PebStatusRadioButtonList_1");
        public By INCAPSoldierPDAYesButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_PdaRadioButtonList_0')]");//By.Id("MEDCHARTContent_EmmpsContent_PdaRadioButtonList_0");
        public By INCAPSoldierPDANoButton = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_PdaRadioButtonList_1')]");//By.Id("MEDCHARTContent_EmmpsContent_PdaRadioButtonList_1");
        #endregion
        #region HTML Text(Readonly)
        #region Section Headers
        public By IncapSoliderID = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[1]/td[1]");
        public By IncapSoliderStatus = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[1]/td[2]");
        public By IncapSoliderIncident = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[3]/td[1]");
        public By IncapSoliderHome = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[3]/td[2]");
        public By IncapSoliderUnit = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[5]/td[1]");
        #endregion
        #region Solider Identification (ID)
        public By IncapIDTable = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody");

        public By IncapIDRank = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[1]/td[1]");
        public By IncapIDTAPRank = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[2]/td[1]");
        public By IncapIDMOSARC = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[3]/td[1]");
        public By IncapIDOrgStation = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[4]/td[1]");
        public By IncapIDCompo = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[5]/td[1]");
        public By IncapIDUIC = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[6]/td[1]");
        public By IncapIDRegion = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[7]/td[1]");
        public By IncapIDDOB = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[8]/td[1]");
        public By IncapIDPEBD = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[9]/td[1]");
        public By IncapIDETS = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[10]/td[1]");

        public By IncapIDRankData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[1]/td[2]");
        public By IncapIDTAPRankData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[2]/td[2]");
        public By IncapIDMOSARCData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[3]/td[2]");
        public By IncapIDOrgStationData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[4]/td[2]");
        public By IncapIDCompoData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[5]/td[2]");
        public By IncapIDUICData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[6]/td[2]");
        public By IncapIDRegionData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[7]/td[2]");
        public By IncapIDDOBData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[1]/table/tbody/tr[8]/td[2]");
        #endregion
        #region Soldier Home Contact Information (HCI)
        public By IncapHCITable = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody");

        public By IncapHCIStreet = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[3]/td[1]");
        public By IncapHCICity = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[4]/td[1]");
        public By IncapHCIState = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[5]/td[1]");
        public By IncapHCIZip = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[6]/td[1]");
        public By IncapHCIeMail = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[2]/td[1]");
        public By IncapHCIHomePhone = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[3]/td[1]");
        public By IncapHCICellPhone = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[4]/td[1]");
        public By IncapHCIWorkPhone = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[2]/td[2]/table/tbody/tr[5]/td[1]");

        public By IncapHCIStreetLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_homeAddressRead_StreetLabel')]");
        public By IncapHCICityLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_homeAddressRead_CityLabel')]");
        public By IncapHCIStateLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_homeAddressRead_StateLabel')]");
        public By IncapHCIZipLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_homeAddressRead_ZipLabel')]");
        public By IncapHCIeMailLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_EmailLabel')]");
        public By IncapHCIHomePhoneLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_HomePhoneLabel')]");
        public By IncapHCICellPhoneLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_CellPhoneLabel')]");
        public By IncapHCIWorkPhoneLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_WorkPhoneLabel')]");
        #endregion
        #region Solider's Status (SS)
        public By IncapSSTable = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[1]/table/tbody");

        public By IncapEmploymentText = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[1]/table/tbody/tr[1]/td[1]");
        public By IncapDutyStatusText = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[1]/table/tbody/tr[2]/td[1]");
        public By IncapFitnessText = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[1]/table/tbody/tr[3]/td[1]");
        public By IncapMEBText = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[1]/table/tbody/tr[4]/td[1]");
        public By IncapPEBText = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[1]/table/tbody/tr[5]/td[1]");
        public By IncapPDAText = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[1]/table/tbody/tr[6]/td[1]");

        public By INCAPSoldierEmploymentLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_EmploymentLabel')]");
        public By INCAPSoldierDutyStatusLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_DutyLabel')]");
        public By INCAPSoldierFitnessDateLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FitnessDateLabel')]");
        public By INCAPSoldierFitnessBoolLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FitnessBooleanLabel')]");
        public By INCAPSoldierMEBStatusDateLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_MebStatusDateLabel')]");
        public By INCAPSoldierMEBStatusBoolLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_MebStatusBooleanLabel')]");
        public By INCAPSoldierPEBStatusDateLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_PebStatusDateLabel')]");
        public By INCAPSoldierPEBStatusBoolLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_PebStatusBooleanLabel')]");
        public By INCAPSoldierPDAStatusDateLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_PdaDateLabel')]");
        public By INCAPSoldierPDAStatusBoolLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_PdaBooleanLabel')]");
        #endregion
        #region Soldier Unit Contact Information (UCI)
        public By IncapUCITable = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody");

        public By IncapUCIStreet = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[3]/td[1]");
        public By IncapUCICity = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[4]/td[1]");
        public By IncapUCIState = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[5]/td[1]");
        public By IncapUCIZip = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr[6]/td[1]");
        public By IncapUCIeMail = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[2]/td[1]");
        public By IncapUCIPhone = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[4]/td[2]/table/tbody/tr[3]/td[1]");

        public By IncapUCIStreetLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_unitAddressRead_StreetLabel')]");
        public By IncapUCICityLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_unitAddressRead_CityLabel')]");
        public By IncapUCIStateLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_unitAddressRead_StateLabel')]");
        public By IncapUCIZipLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_unitAddressRead_ZipLabel')]");
        public By IncapUCIeMailLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_UnitEmailLabel')]");
        public By IncapUCIPhoneLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_UnitPhoneLabel')]");
        #endregion
        #region Incident Information (II)
        public By IncapIITable = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody");

        public By IncapIIIncidentDate = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[1]/td[1]");
        public By IncapIITime = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[2]/td[1]");
        public By IncapIICity = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[3]/td[1]");
        public By IncapIIState = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[4]/td[1]");
        public By IncapIINatureOfIncident = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[5]/td[1]");
        public By IncapIIMEB = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[6]/td[1]");
        public By IncapIIPRB = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[7]/td[1]");

        public By IncapIIIncidentDateData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[1]/td[2]");
        public By IncapIITimeData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[2]/td[2]");
        public By IncapIICityData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[3]/td[2]");
        public By IncapIIStateData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[4]/td[2]");
        public By IncapIINatureOfIncidentData = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div/table/tbody/tr[6]/td[1]/table/tbody/tr[5]/td[2]");
        #endregion
        #region HTML Links
        // these get 100 years in the past for each calendar & the current year
        public By IncapSoliderPEBDYearsLink = By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapSoliderPEBDCurrYearsLink = By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        public By IncapSoliderETSYearsLink = By.XPath("/html/body/div[5]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapSoliderETSCurrYearsLink = By.XPath("/html/body/div[5]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        public By IncapStatusFitnessYearsLink = By.XPath("/html/body/div[6]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapStatusFitnessCurrYearsLink = By.XPath("/html/body/div[6]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        public By IncapStatusMEBYearsLink = By.XPath("/html/body/div[7]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapStatusMEBCurrYearsLink = By.XPath("/html/body/div[7]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        public By IncapStatusPEBYearsLink = By.XPath("/html/body/div[8]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapStatusPEBCurrYearsLink = By.XPath("/html/body/div[8]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        public By IncapStatusPDAYearsLink = By.XPath("/html/body/div[9]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapStatusPDACurrYearsLink = By.XPath("/html/body/div[9]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        public By IncapInciMEBYearsLink = By.XPath("/html/body/div[10]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapInciMEBCurrYearsLink = By.XPath("/html/body/div[10]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        public By IncapInciPEBYearsLink = By.XPath("/html/body/div[11]/div[1]/div[1]/div[2]/div/div[1]/div[1]");
        public By IncapInciPEBCurrYearsLink = By.XPath("/html/body/div[11]/div[1]/div[1]/div[2]/div/div[1]/div[101]");

        #endregion
        #endregion

        #endregion

    }
}
