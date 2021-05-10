using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class StartIncapPage
    {

        public By IncapSearchCases = By.Id("MEDCHARTContent_EmmpsContent_TextBoxSearchCriteria");
        public By IncapSearchButton = By.Id("MEDCHARTContent_EmmpsContent_LinkButtonSearch");
        public By IncapStartLink = By.Id("MEDCHARTContent_EmmpsContent_LodDisplayGridCaseHistory_GridViewMyLodsFilterResults_LinkButtonSelect_0");


    }
}
