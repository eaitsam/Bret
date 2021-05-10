using OpenQA.Selenium;

namespace MedchartSeleniumAutomationCore.Core_Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
