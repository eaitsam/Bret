using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class PreAuthSelectCasePage
    {
        #region My Pre-Auth Select Case Tab Objects

        #region HTML Hyperlinks
        public By MMSOSelectCaseStartNewMMMSOLinkButton = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonStartNewMmso");
        public By SearchButton = By.Id("MEDCHARTContent_EmmpsContent_ucSoldierSearch_SearchButton"); 
        public By CreateMMSOButton = By.Id("MEDCHARTContent_EmmpsContent_FormViewMemberDataOptionsAndCaseHistory_LinkButtonCreateMmso");
        public By MMSOFilterByDateCreated => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[2]/div/div/div/div/div[2]/div/div[3]/table/tbody/tr[1]/th[9]/a");

        #endregion

        #endregion

    }
}
