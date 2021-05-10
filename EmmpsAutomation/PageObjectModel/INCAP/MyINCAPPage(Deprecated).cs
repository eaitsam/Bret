using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyINCAPPage
    {

        public By INCAPCaseStatusLabel = By.Id("MEDCHARTContent_EmmpsContent_soldierControl_CaseHeader1_CaseStatusLabel");//TODO: Implement checking this in validation

        
        #region HTML Labels
        public By INCAPServiceMemberLabel = By.Id("MEDCHARTContent_EmmpsContent_CaseHeaderFinancesTab_ServiceMemberLabel");

        #endregion

        #region My INCAP
        public By ButtonExportMyIncaps = By.Id("MEDCHARTContent_EmmpsContent_ButtonExportMyIncaps");
        public By ButtonFilterMyIncaps = By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterMyIncaps");
        public By MyIncapStartLink = By.Id("MEDCHARTContent_EmmpsContent_MyIncapsDisplayGrid_GridViewIncapCaseFilterResults_LinkButtonCaseId_0");
        #endregion




        #region Page Methods
        /// <summary>
        /// This method navigates from any tab back to the INCAP solider tab
        /// </summary>

        public bool IsCalendarValid(By pastYear, By currYear)
        {
            IWebElement earliestYear = UIActions.GetElement(pastYear);
            string currentYear = UIActions.GetElement(currYear).GetAttribute("textContent");//.Text would not work for span but getting the attribute "textContent" seems to be more reliable
            int earlyInt = Int32.Parse(earliestYear.GetAttribute("data-value"));
            int currInt = Int32.Parse(currentYear);

            return ((currInt - 100).Equals(earlyInt));//checks if the earliest year is 100 years from the current year 
           
        }
       
        #endregion



    }
}
