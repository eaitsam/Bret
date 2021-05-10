using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyIncapExtPage
    {
        #region My INCAP Extensions Tab Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //If an Object has multiple variations depending on Workflows and Status use .Contains instead of .EqualTo for the PropertyExpressionOperator
        //---------------------------------------------------------------------------------------------//

        #region HTML Div
        public By INCAPExtensionsMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeaderExtensionsTab_INCAPExtensionsMenuDiv");

        #endregion
        #region HTML Text Boxes
        public By INCAPExtensionStartDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_TextBoxIncapExtensionStartDate");

        public By INCAPExtensionEndDateTextbox = By.Id("MEDCHARTContent_EmmpsContent_TextBoxIncapExtensionEndDate");

        #endregion
        #region HTML Hyperlinks
        public By INCAPExtensionsStartNewExtensionButton = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonStartNewExtension");

        #endregion

        #endregion

    }
}
