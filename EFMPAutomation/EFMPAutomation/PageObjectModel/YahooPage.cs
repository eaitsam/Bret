using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMPAutomation.PageObjectModel
{
    class YahooPage
    {
        private By YahooSearchBar => By.Id("ybar-sbq");

       

        



        public void WriteinYahooSeatchBar ()
    {

           // UIActions.ClickElement(YahooSearchBar);

            UIActions.TypeInTextBox(YahooSearchBar, "Reluctant Fundamentalist");


    }

        

    }

}
