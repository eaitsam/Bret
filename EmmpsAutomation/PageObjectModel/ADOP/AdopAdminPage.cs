using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopAdminPage
    {
        #region My ADOPs Admin Tab Objects
        #region HTML Div
        public By ADOPAdminMenuDiv => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPAdminMenuDiv");

        //Edit ADOP details--UIC/Region 
        public By ADOPUicTextBox => By.Id("MEDCHARTContent_EmmpsContent_UicTextBox");
        public By ADOPUicTRegionDropDownList => By.Id("MEDCHARTContent_EmmpsContent_UicRegionDropDownList");
        public By ADOPUicTrackingTextBox => By.Id("MEDCHARTContent_EmmpsContent_UICTrackingTextBox");
        public By ADOPUicSelectButton => By.Id("MEDCHARTContent_EmmpsContent_UicRegionButton");



        #endregion
        #region HTML Combo Boxes
        public By ADOPAdminStatusComboBox => By.Id("MEDCHARTContent_EmmpsContent_StatusDropDownList");


        #endregion
        #region HTML Text Boxes
        public By ADOPAdminStatusTrackingTextbox => By.Id("MEDCHARTContent_EmmpsContent_StatusTrackingTextBox");
        public By ADOPAdminCloseTrackingTextbox => By.Id("MEDCHARTContent_EmmpsContent_AdminCloseTrackingTextBox");
        public By ADOPAdminDeleteADOPTrackingTextbox => By.Id("MEDCHARTContent_EmmpsContent_DeleteAdopTrackingTextBox");

        #endregion
        #region HTML Buttons
        public By MMSOAdminStatusGoButton => By.Id("MEDCHARTContent_EmmpsContent_StatusGoButton");
        public By MMSOAdminCloseButton => By.Id("MEDCHARTContent_EmmpsContent_AdminCloseButton");
        public By MMSOAdminDeleteADOPButton => By.Id("MEDCHARTContent_EmmpsContent_DeleteAdopButton");
        #endregion

        #endregion

    }
}
