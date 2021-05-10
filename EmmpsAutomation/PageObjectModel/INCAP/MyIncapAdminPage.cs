using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyIncapAdminPage
    {
        #region My INCAP Admin Tab Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//

        #region HTML Div
        public By INCAPAdminMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_INCAPAdminMenuDiv");

        #endregion
        #region HTML Combo Boxes
        public By INCAPAdminStatusComboBox = By.XPath("//select[contains(@id, 'MEDCHARTContent_EmmpsContent_IncapStatusDropDownList')]");

        #endregion
        #region HTML Text Boxes
        public By INCAPAdminStatusTrackingTextbox = By.XPath("//select[contains(@id, 'MEDCHARTContent_EmmpsContent_IncapStatusTrackingTextBox')]");
        public By INCAPAdminResetPeriodTrackingTextbox = By.XPath("//select[contains(@id, 'MEDCHARTContent_EmmpsContent_ResetPeriodTrackingTextBox')]");
        public By INCAPAdminContingencyTrackingTextbox = By.XPath("//select[contains(@id, 'MEDCHARTContent_EmmpsContent_ContingencyTrackingTextBox')]");
        public By INCAPAdminDeleteTrackingTextbox = By.XPath("//select[contains(@id, 'MEDCHARTContent_EmmpsContent_DeleteIncapTrackingTextBox')]");
        #endregion
        #region HTML Hyperlinks
        public By INCAPAdminStatusGoButton = By.XPath("//input[contains(@id, 'MEDCHARTContent_EmmpsContent_IncapStatusGoButton')]");
        public By INCAPAdminContingencyGoButton = By.XPath("//input[contains(@id, 'MEDCHARTContent_EmmpsContent_ContingencyGoButton')]");
        public By INCAPAdminDeleteButton = By.XPath("//input[contains(@id, 'MEDCHARTContent_EmmpsContent_DeleteIncapButton')]");
        #endregion
        #region HTML Radio Buttons
        public By INCAPAdminContingencyBaseButton = By.XPath("//label[contains(@id, 'MEDCHARTContent_EmmpsContent_IncapTypeRadioButtonList_0')]");
        public By INCAPAdminContingencyIraqButton = By.XPath("//label[contains(@id, 'MEDCHARTContent_EmmpsContent_IncapTypeRadioButtonList_1')]");
        public By INCAPAdminContingencyAfghanistanButton = By.XPath("//label[contains(@id, 'MEDCHARTContent_EmmpsContent_IncapTypeRadioButtonList_2')]");
        public By INCAPAdminContingencyOtherTitle10Button = By.XPath("//label[contains(@id, 'MEDCHARTContent_EmmpsContent_IncapTypeRadioButtonList_3')]");
        #endregion

        #endregion

    }
}
