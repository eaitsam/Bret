using OpenQA.Selenium;
namespace MedchartSeleniumAutomationCore.Core_Settings
{
   public  interface IConfig
    {
        BrowserType? GetBrowser();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();
    }
}
