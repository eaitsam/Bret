using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using Xunit;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Framework;
using McidsAutomation;
using McidsAutomation.PageObjectModel;


namespace McidsAutomation.PageObjectModel
{
    class GooglePageTest
    {
        private By GoogleSearhButton => By.XPath("(//input[@value='Google Search'])[2]");
        // private By GoogleSearchButton => By.Name("btnK");
        private By SearchMedChart => By.XPath("//input[@title='Search']");
        //private By SearchMedChart => By.Name("q");


        //private By MedChartLink => By.XPath("//a[@href='https://medchart.ngb.army.mil/']");

        private By MedChartLink => By.LinkText("MEDCHART Help Desk");

        private By MedChartValid => By.XPath("//div[@id='medchartLogoLarge']");

        //private By MedChartLink => By.XPath("//*[contains(text(),'medchart: Medical Record Request and Release Platform')]");

        //private By AVSLink => By.LinkText("AVS");
        //private By FacebookEmail1 => By.Id("email");
        private By FacebookPassword1 => By.Id("pass");

        private By AVSLink => By.XPath("(//a[@href='#'])[1]");

        public void VerifyGooglePageOpened()
        {
            Assert.True(UIActions.GetElement(GoogleSearhButton).Displayed);
        }


        public void WriteInSearchBox()
        {
            UIActions.TypeInTextBoxAndEnter(SearchMedChart, "MedChart");

        }

        public void ClickMedChart()
        {
            UIActions.ClickElement(MedChartLink);

        }

        public void VerifyMedChart()
        {
            Assert.True(UIActions.GetElement(MedChartValid).Displayed);

        }

        public void AVSLink1()
        {
            UIActions.ClickElement(AVSLink);
        }

        //public void FacebookEmail()
        //{
        //    UIActions.ClickElement(FacebookEmail1);
        //}

        public void FacebookPassword()
        {
            UIActions.ClickElement(FacebookPassword1);
        }

    }

} 

