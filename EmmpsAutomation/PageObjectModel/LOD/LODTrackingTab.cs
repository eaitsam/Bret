using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODTrackingTab
    {

        #region My LOD Tracking Tab Objects
        //---------------------------//
        //My LOD Tracking Tab Objects
        //---------------------------//
        //--HTML Div--//
        public By LODTrackingMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODTrackingMenuDiv");
        public By StartNewLODTrackingComment => By.XPath("//*[text()='Start New LOD Automation Team']");

        #endregion


    }
}
