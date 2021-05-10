using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class INCAPExtensionsPage
    {
        public By IncapExtensionsNameTextBox => By.Id("MEDCHARTContent_EmmpsContent_TextBoxNameSearch");
        public By IncapExtensionsFilterButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterMyIncaps");
        public By IncapExtensionsCaseLink => By.Id("MEDCHARTContent_EmmpsContent_MyIncapsDisplayGrid_GridViewIncapCaseFilterResults_LinkButtonCaseId_0");
        public By IncapExtensionsStatusDropDown => By.Id("MEDCHARTContent_EmmpsContent_DropDownListStatus");
        public By IncapExtensionsDateCreated => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div/div/div[2]/div/div[3]/table/tbody/tr[1]/th[9]/a");

    }
}
