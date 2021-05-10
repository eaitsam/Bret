using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class PreAuthAssociatePage
    {
        #region My Pre-Auth Associate Tab Objects

        #region HTML Div
        public By MMSOAssociateMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOAssociateMenuDiv");
        public By MMSOAssociateMenuLinkButtonLinkText => By.LinkText("Associate");
        public By MMSOAssociateFirstCase = By.Id("MEDCHARTContent_EmmpsContent_GridViewEligibleLods_LinkButtonAssociateMmsoToLod_0");
        public By MMSOAssociateSelectContinueButton = By.XPath("/html/body/div[4]/div[3]/div/button[1]");
        #endregion

        #endregion

    }
}
