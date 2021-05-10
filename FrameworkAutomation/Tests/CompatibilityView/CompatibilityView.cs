using FrameworkAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.Tests.CompatibilityView
{
    public class ViewSetting
    {
        private Login _login;
        private Homepage _homePage;
        private RegistrationPage _reg;
        
        private AccessLogPage _accessLog;
        private BaseDriverInit _driverInit;
       
       

        public ViewSetting()
        {
            _login = new Login();
            _homePage = new Homepage();
            _reg = new RegistrationPage();
           
            _accessLog = new AccessLogPage();
            _driverInit = new BaseDriverInit();
            

        }
        [Fact]
        public void Viewcompatibility()
        {
            try
            {
                //Automation Team: I am not sure these are the exact paths and Keys you need to use, so you will have to do a research into
                //which registry entries implement compatibility mode
                const string path = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\BrowserEmulation\PolicyList";
                const string key = "UserFilter";

                
                //Automation Team: You are going to have to do research into this Registry Entry to determin what the value is that you need to set
                var regValue = Registry.GetValue(path, key, "Return this default if NoSuchName does not exist.");
                Registry.SetValue(path, key, regValue);

                _driverInit.InitWebdriver();
                _login.LoginMethod("9990002200");                
                UIActions.GetElement(_homePage.PageTitle);
                
            }
            finally
            {
                const string path = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\BrowserEmulation\PolicyList";
                const string key = "UserFilter";
                var regValue = Registry.GetValue(path, key, "Return this default if NoSuchName does not exist.");
                Registry.SetValue(path, key, regValue);
                _driverInit.TearDown();

                //Automation Team: Revert the registry entry to its default state for comaptibility mode here
                
            };
        }
        

        //public void SetUp()
        //{
        //    //read the compatibility mode list from registry
        //    const string path = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\BrowserEmulation\ClearableListData";
        //    const string key = "UserFilter";
        //    var regValue = Registry.GetValue(path, key, "Return this default if NoSuchName does not exist.");

        //    //run IE driver with cleaning of cookies and history
        //    var options = new InternetExplorerOptions
        //    {
        //        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
        //        EnsureCleanSession = true
        //    };
        //    _driverInit = new InternetExplorerDriver(IeDriversPath, options);

        //    //cloase IE
        //    _driverInit.TearDown();
        //    _driverInit.Dispose();

        //    //put the compatibility mode list back into registry 
        //    Registry.SetValue(path, key, regValue);

        //    //run IE driver without cleaning of cookies and history
        //    options.EnsureCleanSession = false;
        //    _driverInit = new InternetExplorerDriver(IeDriversPath, options);
        //}


    }
}
