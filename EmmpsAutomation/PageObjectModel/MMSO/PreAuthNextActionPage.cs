using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class PreAuthNextActionPage
    {
        #region My Pre-Auth Next Action Tab Objects

        #region HTML Div
        public By MMSONextActionMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSONext ActionMenuDiv");


        #endregion
        #region HTML Text Boxes

        public By MMSONextActionCommentsTextbox = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_CommentsTextBox");

        #endregion
        #region Combo Boxes
        public By MMSONextActionActionComboBox = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_ActionDropDownList");

        #endregion
        #region HTML Hyperlinks

        public By MMSONextActionSignButton = By.Id("SignButton");

        #endregion

        #endregion

    }
}
