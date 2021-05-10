using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMPAutomation.PageObjectModel
{
    public class SplashPage
    {



        private By PageBodyElement => By.TagName("body");





        public void ClickCacButton()
        {
            UIActions.ClickElement(CacLoginButton);
        }

        public By CacLoginButton => By.Id("btnLogin");
            
    public string GetBodyText() => UIActions.GetElement(PageBodyElement).Text;
        public string BodyTextActual => "EFMP Splash Page";

        


    }
     }
