using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopNextActionPage
    {
        #region My ADOPs Next Action Tab Objects
        #region HTML Div

        public By ADOPNextActionMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPNext ActionMenuDiv");

        #endregion
        #region HTML Text Boxes
        public By ADOPNextActionCommentsTextbox = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_CommentsTextBox");


        #endregion
        #region HTML Combo Boxes
        public By ADOPNextActionActionComboBox = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_ActionDropDownList");
        #endregion
        #region HTML Hyperlinks
        public By ADOPNextActionSignButton = By.Id("SignButton");
        #endregion

        #endregion

    }
}
