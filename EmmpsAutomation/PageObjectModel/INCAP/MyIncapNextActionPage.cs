using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyIncapNextActionPage
    {
        #region My INCAP Next Action Tab Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //If an Object has multiple variations depending on Workflows and Status use .Contains instead of .EqualTo for the PropertyExpressionOperator
        //---------------------------------------------------------------------------------------------//

        #region HTML Div
        public By INCAPNextActionMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_INCAPNext ActionMenuDiv");

        #endregion
        #region HTML Text Boxes
        public By INCAPNextActionCommentsTextbox = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_CommentsTextBox ActionMenuDiv");

        #endregion
        #region HTML Combo Boxes
        public By INCAPNextActionComboBox = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_ActionDropDownList");


        #endregion
        #region HTML Hyperlinks

        public By INCAPNextActionSignButton = By.Id("SignButton");

        #endregion
        public By INCAPApproveButton => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/div[2]/div/div/table/tbody/tr[2]/td[3]/div/span/label[1]");

        #endregion

    }
}
