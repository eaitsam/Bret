using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyIncapCalcPage
    {
        #region MYy INCAP Calculator Tab Objects

        #region HTML Text Boxes

        #region Patient Information (PI)

        public By INCAPCalculatorPIZipCodeBoxWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxZipcode')]");
        public By INCAPCalculatorPIZipCodeBoxRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxZipcode')]");

        #endregion
        #region Income Compensation (IC)

        public By INCAPCalculatorICOtherCivCompBoxWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxOtherCivilianCompensation')]");
        public By INCAPCalculatorICOtherCivCompBoxRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxOtherCivilianCompensation')]");

        #endregion
        #region Civilian Loss of Income (CLI)

        public By INCAPCalculatorCLIHourlyRateBaseWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxCivilianBaseHourlyRate')]");
        public By INCAPCalculatorCLIHourlyRateBaseRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxCivilianBaseHourlyRate')]");
        public By INCAPCalculatorCLIHourlyRateDiffWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxCivilianDifferential')]");
        public By INCAPCalculatorCLIHourlyRateDiffRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxCivilianDifferential')]");
        public By INCAPCalculatorCLITotalWithFICAWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxCivilianTotalWithFica')]");
        public By INCAPCalculatorCLITotalWithFICARead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxCivilianTotalWithFica')]");

        #endregion
        #region Totals

        public By INCAPCalculatorTotalsOtherBoxWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxOtherCost')]");
        public By INCAPCalculatorTotalsOtherBoxRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxOtherCost')]");
        public By INCAPCalculatorTotalsActualCostBoxWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxActualCost')]");
        public By INCAPCalculatorTotalsActualCostBoxRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxActualCost')]");

        #endregion
        #region Comments

        public By INCAPCalculatorCommentsBoxWrite = By.XPath("//textarea[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxComment')]");
        public By INCAPCalculatorCommentsBoxRead = By.XPath("//textarea[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxComment')]");

        #endregion
        #region USPFO Codes

        public By INCAPCalculatorUSPFORefNumWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxReferenceNumber')]");
        public By INCAPCalculatorUSPFORefNumRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxReferenceNumber')]");
        public By INCAPCalculatorUSPFOTransNumWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxTransNumber')]");
        public By INCAPCalculatorUSPFOTransNumRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxTransNumber')]");
        public By INCAPCalculatorUSPFOOrderNumWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxOrderNumber')]");
        public By INCAPCalculatorUSPFOOrderNumRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxOrderNumber')]");
        public By INCAPCalculatorUSPFOAPCCodeWrite = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$TextBoxApcCode')]");
        public By INCAPCalculatorUSPFOAPCCodeRead = By.XPath("//input[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$TextBoxApcCode')]");

        #endregion

        #endregion
        #region HTML Combo Boxes

        public By INCAPCalculatorSelectPeriodBoxWrite = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$DropDownListSelectedPeriod')]");
        public By INCAPCalculatorSelectPeriodBoxRead = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$DropDownListSelectedPeriod')]");

        #region Patient Information (PI)

        public By INCAPCalculatorPIPayGradeBoxWrite = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$DropDownListPayGrade')]");
        public By INCAPCalculatorPIPayGradeBoxRead = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$DropDownListPayGrade')]");

        #endregion
        #region Income Compensation (IC)

        public By INCAPCalculatorICEmploymentBoxWrite = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$DropDownListEmploymentStatus')]");
        public By INCAPCalculatorICEmploymentBoxRead = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$DropDownListEmploymentStatus')]");

        #endregion
        #region Civilian Loss of Income (CLI)

        public By INCAPCalculatorCLIHourMissedPerDayBoxWrite = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$DropDownListCivilianHoursMissedPerDay')]");
        public By INCAPCalculatorCLIHourMissedPerDayBoxRead = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$DropDownListCivilianHoursMissedPerDay')]");
        public By INCAPCalculatorCLIDaysMissedThisMonthBoxWrite = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadWrite$DropDownListCivilianDaysMissedThisMonth')]");
        public By INCAPCalculatorCLIDaysMissedThisMonthBoxRead = By.XPath("//select[contains(@name, 'ctl00$ctl00$MEDCHARTContent$EmmpsContent$FormViewReadOnly$DropDownListCivilianDaysMissedThisMonth')]");

        #endregion

        #endregion
        #region HTML Buttons

        public By INCAPCalculatorPrintMonthButton = By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_linkButtonPrintFinacePeriod')]");
        public By INCAPCalculatorPrintAllMonthsButton = By.XPath("//a[contains(@id, 'MEDCHARTContent_EmmpsContent_linkButtonPrintAllFinancePeriods')]");
        public By INCAPCalculatorTabButton = By.Id("MEDCHARTContent_EmmpsContent_linkButtonContinueToCalculatorTab");

        #region Patient Information (PI)

        public By INCAPCalculatorPITeir = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadOnly_RadioButtonListIncapFinancesTier')]");
        public By INCAPCalculatorPITeir1 = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListIncapFinancesTier_0')]");
        public By INCAPCalculatorPITeir2 = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListIncapFinancesTier_1')]");
        public By INCAPCalculatorPIContingency = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadOnly_RadioButtonListIncapType')]");
        public By INCAPCalculatorPIContingencyBase = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListIncapType_0')]");
        public By INCAPCalculatorPIContingencyIraq = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListIncapType_1')]");
        public By INCAPCalculatorPIContingencyAfghanistan = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListIncapType_2')]");
        public By INCAPCalculatorPIContingencyOther = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListIncapType_3')]");
        public By INCAPCalculatorPIDependents = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadOnly_radioButtonListDependents')]");
        public By INCAPCalculatorPIDependentsYes = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_radioButtonListDependents_0')]");
        public By INCAPCalculatorPIDependentsNo = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_radioButtonListDependents_1')]");

        #endregion
        #region Civilian Loss of Income (CLI)

        public By INCAPCalculatorCLICalculateTotal = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadOnly_RadioButtonListEnterOrCalculateTotalWithFica')]");
        public By INCAPCalculatorCLICalculateTotalWithFICA = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListEnterOrCalculateTotalWithFica_0')]");
        public By INCAPCalculatorCLIEnterTotalWithFICA = By.XPath("//label[contains(@for, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_RadioButtonListEnterOrCalculateTotalWithFica_1')]");

        #endregion

        #endregion
        #region HTML Text(Readonly)

        public By INCAPCalculatorFinancePeriodLabel = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div[1]/table/tbody/tr/td/div[1]/span[2]/span");

        #region Patient Information (PI)

        public By INCAPCalculatorPILocation = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelLocation')]");

        #endregion
        #region Income Compensation (IC)

        public By INCAPCalculatorICTotal = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelTotalIncomeCompensationICSection')]");

        #endregion
        #region Military Pay and Allowances (MPA)

        public By INCAPCalculatorMPADaysLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelDaysInMonth')]");
        public By INCAPCalculatorMPABasePayLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelMilitaryBasePay')]");
        public By INCAPCalculatorMPATotalIncomCompensationLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelTotalIncomeCompensationMPandASection')]");
        public By INCAPCalculatorMPAAdjustedBasePayLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelMilitaryAdjustedBasePay')]");
        public By INCAPCalculatorMPABAHLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelBasicAllowanceHousing')]");
        public By INCAPCalculatorMPABASLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelBasicAllowanceSubsistence')]");
        public By INCAPCalculatorMPATotalAllowanceLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelMilitaryTotalAllowance')]");
        public By INCAPCalculatorMPAFICALabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelMilitaryFica')]");
        public By INCAPCalculatorMPATotalWithFICALabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelMilitaryTotalWithFica')]");

        #endregion
        #region Civilian Loss of Income (CLI)

        public By INCAPCalculatorCLIHourlyRateLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelCivilianHourlyRate')]");
        public By INCAPCalculatorCLIHoursMissedPerDayLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelHoursMissedAmount')]");
        public By INCAPCalculatorCLIDaysMissedThisMonthLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelDaysMissedAmount')]");
        public By INCAPCalculatorCLILessIncomeCompensationLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelLessIncomeCompensation')]");
        public By INCAPCalculatorCLITotalAllowanceLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelCivilianTotalAllowance')]");
        public By INCAPCalculatorCLIFICALabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelCivilianFica')]");
        public By INCAPCalculatorCLITotalWithFICALable = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelCivilianTotalWithFica')]");

        #endregion
        #region Totals

        public By INCAPCalculatorTotalsTotalPayLabel = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelTotalPay')]");
        public By INCAPCalculatorTotalsEstimatedCostToGovernment = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_LabelEstimatedCostToGovernment')]");
        //can't find + with generic xpath because same class and same text
        public By INCAPCalculatorTotalsPlusSign1 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div[1]/table/tbody/tr/td/div[3]/div[1]/div[3]/div/div[2]/div[1]");
        public By INCAPCalculatorTotalsPlusSign2 = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/div[1]/table/tbody/tr/td/div[3]/div[1]/div[3]/div/div[2]/div[2]");

        public By INCAPCalculatorTotalsTotalPayTitle = By.XPath("//div[contains(@class, 'FontBold') and text()='Total Pay']");
        public By INCAPCalculatorTotalsOtherTitle = By.XPath("//div[contains(@class, 'FontBold') and text()='Other']");
        #endregion
        #region Comments

        public By INCAPCalculatorCommentsCharactersRemaining = By.XPath("//span[contains(@id, 'MEDCHARTContent_EmmpsContent_FormViewReadWrite_TextBoxComment_output')]");

        #endregion

        #endregion

        #endregion

    }
}
