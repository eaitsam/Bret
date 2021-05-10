using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.IO;
using System.Threading;
using static MedchartSeleniumAutomationCore.Core_Framework.DebuggingHelpers;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace MedchartSeleniumAutomationCore.Core_Settings
{
    public class BaseDriverInit : IDisposable
    {

        
        public FirefoxOptions GetFirefoxptions()
        {
            FirefoxProfileManager manager = new FirefoxProfileManager();

            FirefoxOptions options = new FirefoxOptions()
            {
                Profile = manager.GetProfile("default"),
                AcceptInsecureCertificates = true,
                UnhandledPromptBehavior = UnhandledPromptBehavior.Accept,
                PageLoadStrategy = PageLoadStrategy.Eager,
            };
            return options;
        }
        public ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            option.AcceptInsecureCertificates = true;
            option.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
            option.AddArguments("--disable-extensions");
            //option.AddArgument("--headless");
            Log.Info(" Using Chrome Options ");
            return option;
        }

        public InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions
            {
                //IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnsureCleanSession = false,
                ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom,
                EnableNativeEvents = true,
                UnhandledPromptBehavior = UnhandledPromptBehavior.Accept,
                RequireWindowFocus = true,
                FileUploadDialogTimeout = TimeSpan.FromSeconds(60),
                //EnablePersistentHover = true,
            };

            Log.Info(" Using Internet Explorer Options ");
            return options;
        }

        public EdgeOptions GetEdgeOptions()
        {
            EdgeOptions options = new EdgeOptions();
            options.AcceptInsecureCertificates = true;
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            options.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
           //options.StartPage = ObjectRepository.Driver.Url = new AppConfigReader().GetWebsite();
            return options;
        }


        public FirefoxDriver GetFirefoxDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            FirefoxDriver driver = new FirefoxDriver(GetFirefoxptions()); 
            return driver; 
        }

        public ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        public EdgeDriver GetEdgeDriver()
        {
            //EdgeOptions options = new EdgeOptions();
            EdgeDriver driver = new EdgeDriver(GetEdgeOptions());
            return driver;
        }

        public InternetExplorerDriver GetIEDriver()
        {
            InternetExplorerDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        public void InitWebdriver()
        {
            ObjectRepository.Config = new AppConfigReader(); 

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    DebuggingHelpers.Log.Info(" Using Firefox Driver  ");
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    DebuggingHelpers.Log.Info(" Using Chrome Driver  ");
                    break;
                case BrowserType.Edge:
                    ObjectRepository.Driver = GetEdgeDriver();
                    DebuggingHelpers.Log.Info(" Using Edge Driver  ");
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    DebuggingHelpers.Log.Info(" Using Internet Explorer Driver  ");
                    break;
                default:
                    throw new NoSutiableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
            }
            //ObjectRepository.Driver.Manage()
           //    .Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            BrowserMaximize();
            ObjectRepository.Driver.Url = new AppConfigReader().GetWebsite();

        }

        public void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                //ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
                //RemoveDriverServerProcesses();
                MurderDriver(ObjectRepository.Driver);
            }
            Log.Info(" Stopping the Driver  ");
        }


        /// <summary>
        /// Sometimes the IEDriverServer.exe process does not close after running a test. Multiple instances
        /// of the process can seriously degrade the speed at which the tests run.
        /// This removes any processes the temporary browser needs to be able to run.
        /// </summary>
        private readonly List<string> _processesToCheck =
            new List<string>
            {
            "opera",
            "chrome",
            "firefox",
            "ie",
            "gecko",
            "phantomjs",
            "edge",
            "microsoftwebdriver",
            "webdriver"
            };

        public DateTime? TestRunStartTime { get; set; }

        private void MurderDriver(IWebDriver driver)
        {
            driver?.Dispose();
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    Debug.WriteLine(process.ProcessName);
                    if (process.StartTime > TestRunStartTime)
                    {
                        var shouldKill = false;
                        foreach (var processName in _processesToCheck)
                        {
                            if (process.ProcessName.ToLower().Contains(processName))
                            {
                                shouldKill = true;
                                break;
                            }
                        }

                        if (shouldKill)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }

        public void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
            DebuggingHelpers.Log.Info(" Browser Maximize ");
        }

        //looking into implementing Idisposable interface on all files in solution, this is not yet implemented fully
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~BaseDriverInit()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        #region .Net Core

        /// <summary>
        /// The .net Core project will use this method for init web driver
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="url"></param>
        public void InitWebdriver(string browser, string url)
        {
            BrowserType type = (BrowserType)Enum.Parse(typeof(BrowserType), browser);

            switch (type)
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriverForDotNetCore();
                    DebuggingHelpers.Log.Info(" Using Firefox Driver  ");

                    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    DebuggingHelpers.Log.Info(" Using Chrome Driver  ");
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    DebuggingHelpers.Log.Info(" Using Internet Explorer Driver  ");
                    break;
                default:
                    throw new NoSutiableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
            }
            BrowserMaximize();
            ObjectRepository.Driver.Url = url;

        }

        public FirefoxDriver GetFirefoxDriverForDotNetCore()
        {
            CodePagesEncodingProvider.Instance.GetEncoding(437);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            FirefoxOptions options = new FirefoxOptions();
            FirefoxDriver driver = new FirefoxDriver(GetFirefoxptions());
            return driver;
        }

        #endregion

    }
}
