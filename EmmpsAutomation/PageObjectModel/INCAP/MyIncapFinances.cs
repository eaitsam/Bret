using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyIncapFinances
    {
        #region My INCAP Finances Tab Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //If an Object has multiple variations depending on Workflows and Status use .Contains instead of .EqualTo for the PropertyExpressionOperator
        //---------------------------------------------------------------------------------------------//

        #region HTML Div
        public By INCAPFinancesMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeaderFinancesTab_INCAPFinancesMenuDiv");

        #endregion
        #region HTML Text Boxes
        public By INCAPFinancesNewPeriodStartDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_TextBoxNewPeriodStartDate");
        public By INCAPFinancesNewPeriodEndDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_TextBoxNewPeriodEndDate");
        public By INCAPFinancesTerminationDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_TextBoxIncapTerminationDate");
        public By INCAPFinancesUpdateStartDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_TextBoxStartDate_0");
        public By INCAPFinancesUpdateEndDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_TextBoxEndDate_0");
        #endregion
        #region HTML Button
        public By INCAPFinancesPrintYesNoButton = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapFinances_radioButtonListPrintSelectedFinancePeriod_0");
        public By INCAPFinancesAddNewPeriodButton = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_LinkButtonAddNewPeriod");
        public By INCAPFinancesPrintSelectedFinancePeriodsButton = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_linkButtonPrintSelectedFinancePeriods");
        public By INCAPFinancesUpdateButton = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_ButtonUpdateIncap");
        #endregion
        #region HTML Combo Boxes
        public By INCAPFinancesTerminationReasonComboBox = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_DropDownListTerminationReason");

        #endregion
        #region HTML Hyperlinks
        public By INCAPFinancesEditLink = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_LinkButtonEditIncapPeriod_0");
        public By INCAPFinancesDeleteLink = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_LinkButtonDeleteIncapPeriod_0");
        public By INCAPFinancesContinueLink = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_ButtonContinue");
        public By INCAPFinancesSectionMonth = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapFinances_LinkButtonSelect_0");
        public By INCAPFinancesUpdateLink = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_LinkButtonUpdateIncapPeriod_0");
        public By INCAPFinancesCancelLink = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_LinkButtonCancelEditIncapPeriod_0");
        public By INCAPFinancesCancelUpdateLink = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_ButtonCancel");
        #region Calendar Regions
        public By INCAPFinancesStartDate = By.XPath("/html/body/div[4]/div[1]/div[2]/table/tbody/tr[4]/td[7]");//switch to new case for xpath to work properly TODO: refactor this so it can work 

        public By INCAPFinancesStartDateCurrYearLink = By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/span");//current year
        public By INCAPFinancesStartDateYearLink = By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div/div[1]/div[1]");//100 years in the past

        public By INCAPFinancesEndDateCurrYearLink = By.XPath("/html/body/div[5]/div[1]/div[1]/div[2]/span");
        public By INCAPFinancesEndDateYearLink = By.XPath("/html/body/div[5]/div[1]/div[1]/div[2]/div/div[1]/div[1]");

        public By INCAPFinancesTermCurrYearLink = By.XPath("/html/body/div[6]/div[1]/div[1]/div[2]/span");
        public By INCAPFinancesTermYearLink = By.XPath("/html/body/div[6]/div[1]/div[1]/div[2]/div/div[1]/div[1]");

        public By INCAPFinancesEndDate = By.XPath("/html/body/div[5]/div[1]/div[2]/table/tbody/tr[5]/td[1]");

        public By INCAPFinancesMonthLink = By.XPath("/html/body/div[5]/div[1]/div[1]/div[1]");
        #endregion

        #endregion
        #region HTML Text (readonly)
        public By INCAPFinancesSectionGridHeader = By.XPath("/html/body/form/div[5]/div[1]/div[1]/div[1]/div[5]/div/table/tbody/tr/td/div[1]/div/div/div/div[1]/table/tbody/tr[1]");
        public By INCAPDatesSectionGridHeader = By.XPath("/html/body/form/div[5]/div[1]/div[1]/div[1]/div[5]/div/table/tbody/tr/td/div[2]/div/div/div/div[4]/div[2]/table/tbody/tr[1]");
        public By INCAPDatesUpdateSectionGridHeader = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[5]/div/table/tbody/tr/td/div[2]/div/div/div/div[5]/div/div[2]/div/table/tbody/tr[1]");
        public By INCAPDatesErrorMsg = By.XPath("/html/body/form/div[5]/div[1]/div[1]/div[1]/div[5]/div/table/tbody/tr/td/div[2]/div/div/div/div[2]/ul/li");
        public By INCAPDatesErrorMsgStartEnd = By.XPath("/html/body/form/div[5]/div[1]/div[1]/div[1]/div[5]/div/table/tbody/tr/td/div[2]/div/div/div/div[2]/ul/li[3]");
        public By INCAPFinancesDatesSubText = By.XPath("/html/body/form/div[5]/div[1]/div[1]/div[1]/div[5]/div/table/tbody/tr/td/div[2]/div/div/div/div[3]/div[2]");
        public By INCAPFinancesDatesStartText = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_TextBoxStartDate_0");
        public By INCAPFinancesDatesEndText = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadWrite_GridViewIncapPeriods_TextBoxEndDate_0");
        public By INCAPFinancesTabText = By.Id("MedchartPageTitle");
        #endregion
        #region Readonly elements
        public By INCAPFinancesPrintSelectedFinancePeriodsButtonReadOnly = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadOnly_linkButtonPrintSelectedFinancePeriodsReadOnly");
        public By INCAPFinancesPrintYesNoButtonReadOnly = By.Id("MEDCHARTContent_EmmpsContent_FormViewReadOnly_GridViewIncapFinancesReadOnly_radioButtonListPrintSelectedFinancePeriod_0");
        public By INCAPDatesSectionGridHeaderReadOnly = By.XPath("/html/body/form/div[5]/div[1]/div[1]/div[1]/div[5]/div/table/tbody/tr/td/div[2]/div/div/div/div/div[2]/table/tbody/tr[1]");
        #endregion
        #endregion

    }
}
