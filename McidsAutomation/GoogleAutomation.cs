using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using Xunit;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Framework;
using McidsAutomation;
using McidsAutomation.PageObjectModel;
using FluentAssertions;

namespace Google_Automation

{ 
public class GoogleAutomationTest
{
    private readonly Configurations _config;
    private readonly BaseDriverInit _webDriver;
    private readonly GooglePageTest _googlePage;
    private readonly string _googleUrl;
    private readonly string _IWebElement;
    private const string moduleNameFirstSignOn = "Google";


    public GoogleAutomationTest()
    {
        _config = new Configurations();
        _googleUrl = _config.GetConfigValue("GoogleURL");
        _webDriver = new BaseDriverInit();
        _googlePage = new GooglePageTest();
    }

    [Fact]
    public void Google_OpenBrowser()
    { 
            
            
            
            
            DebuggingHelpers.Logger().Info(" *** Start MCIDS Single Sign-on test case ");
       
        _webDriver.InitWebdriver(_config.GetConfigValue("Browser"), _googleUrl);
           
        _webDriver.BrowserMaximize();
            DebuggingHelpers.Logger().Info("Maximize Window");
           // _googlePage.VerifyGooglePageOpened();
           // _googlePage.FacebookEmail();
            _googlePage.FacebookPassword();
           
            
            
            
            

            
            //DebuggingHelpers.Logger().Info("Verify Google Homepage");
            //_googlePage.WriteInSearchBox();
            //DebuggingHelpers.Logger().Info("Write in Search Box");

            //    _googlePage.ClickMedChart();
            //    DebuggingHelpers.Logger().Info("Click on Medchart");

            //    _googlePage.VerifyMedChart();
            //    DebuggingHelpers.Logger().Info("Verify Medchart");

            //    _googlePage.AVSLink1();

            //    _webDriver.Dispose();

            //_webDriver.TearDown();

        }


        

}
}