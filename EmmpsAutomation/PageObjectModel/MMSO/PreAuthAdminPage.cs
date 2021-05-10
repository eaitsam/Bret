using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class PreAuthAdminPage
    {
        #region My Pre-Auth Admin Tab Objects

        #region HTML Div
        public By MMSOAdminMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOAdminMenuDiv");

        #endregion
        #region HTML Text Boxes

        public By MMSOAdminDeleteTrackingTextbox = By.Id("MEDCHARTContent_EmmpsContent_DeleteMmsoTrackingTextBox");

        #endregion
        #region HTML Hyperlinks
        public By MMSOAdminDeleteButton = By.Id("MEDCHARTContent_EmmpsContent_DeleteMmsoButton");
        #endregion

        #endregion

    }
}
