using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedchartSeleniumAutomationCore.Core_Shared_Methods
{
    public class SearchandFilterCases
    {

        public By MyLODsFilterButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonFilterMyLods");


        public static void LODCaseFilter(By ssnbox, By statusbox, By worflowbox, string ssn, string status, string workflow)
        {
            UIActions.TypeInTextBox(ssnbox, ssn);
            UIActions.SelectElementByText(statusbox, status);
            UIActions.SelectElementByText(worflowbox, workflow);

        }

        public static void FilterbyRecentCaseandSelect(By filterButton, By dateCreated, By animationDiv, By row0case, By searchcaseidlink)
        {
            
            UIActions.ClickElement(filterButton);
            WaitMethods.WaitForAnimationtoComplete(animationDiv, 60);
            UIActions.ClickElement(dateCreated);
            WaitMethods.WaitForAnimationtoComplete(animationDiv, 60);
            UIActions.ClickElement(dateCreated);
            WaitMethods.WaitForAnimationtoComplete(animationDiv, 60);

            
            if (UIActions.IsElementPresent(row0case))
            {
                WaitMethods.Wait(row0case, 60);
                UIActions.ClickElement(row0case);
            }
            else
            {
                WaitMethods.Wait(searchcaseidlink, 60);
                UIActions.ClickElement(searchcaseidlink);
            }
            WaitMethods.WaitForAnimationtoComplete(animationDiv, 60);

        }
    }
}
