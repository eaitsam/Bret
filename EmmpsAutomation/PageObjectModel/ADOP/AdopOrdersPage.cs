using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopOrdersPage
    {
        #region My ADOPs Orders Tab Objects
        #region HTML Div
        public By ADOPOrdersMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPOrdersMenuDiv");
        #endregion

        public By ADOPOrderNumberTextBox => By.Id("MEDCHARTContent_EmmpsContent_CcuOrdersNumberTb");
        public By ADOPSRULocationTextBox => By.Id("MEDCHARTContent_EmmpsContent_CcuSruLocationDdl");
        public By ADOPStartDateBox => By.Id("MEDCHARTContent_EmmpsContent_CcuOrdersStartDateTb");
        public By ADOPEndDateBox => By.Id("MEDCHARTContent_EmmpsContent_CcuOrdersEndDateTb");

        public By ADOPImageDateEnd => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/table/tbody/tr[6]/td[3]/img");

        public By ADOPYesRefrad => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/table/tbody/tr[7]/td[3]/span/label[1]");
        //*[@id="MEDCHARTContent_EmmpsContent_CcuStartedRefradRbl"]/label[1]

        public By ADOPNoRefrad => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/table/tbody/tr[7]/td[3]/span/label[2]");
        //*[@id="MEDCHARTContent_EmmpsContent_CcuStartedRefradRbl"]/label[2]

        public By ADOPYesReleasedAd => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/table/tbody/tr[8]/td[3]/span/label[1]");
        //*[@id="MEDCHARTContent_EmmpsContent_CcuIsReleasedFromAdRbl"]/label[1]

        public By ADOPNoReleasedAd => By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/table/tbody/tr[8]/td[3]/span/label[2]");
        //*[@id="MEDCHARTContent_EmmpsContent_CcuIsReleasedFromAdRbl"]/label[2]

        public By ADOPDepatureDateBox => By.Id("MEDCHARTContent_EmmpsContent_CcuMobDepartureDateTb");

        #endregion

        //validations
        public By ADOPOrderNumberValidationMess => By.Id("validationMessage0");
        public By ADOPSRULocationValidationMess => By.Id("validationMessage1");
        public By ADOPStartDateValidationMess => By.Id("validationMessage2");
        public By ADOPEndDateValidationMess => By.Id("validationMessage3");
        public By ADOPStartOfRefradValidationMess => By.Id("validationMessage4");
        public By ADOPSoldierReleasedValidationMess => By.Id("validationMessage5");
        public By ADOPSoldierDepartValidationMess => By.Id("validationMessage6");


    }
}
