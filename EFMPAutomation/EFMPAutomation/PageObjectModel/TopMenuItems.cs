using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMPAutomation.PageObjectModel
{
    public class TopMenuItems
    {
        private By PageBodyElement => By.TagName("body");

        private By UserInfo1 => By.Id("lnkUserInfo");


        public string GetBodyText() => UIActions.GetElement(PageBodyElement).Text;
        public string BodyTextActual => "EFMP Splash Page";


        public void ClickUserInfo()
        {
            UIActions.ClickElement(UserInfo1);
        }


    }


    

}