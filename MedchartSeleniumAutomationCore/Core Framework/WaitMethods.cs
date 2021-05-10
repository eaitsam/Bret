using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MedchartSeleniumAutomationCore.Core_Framework
{
    public static class WaitMethods
    {
        /// <summary>
        /// Waits for an object to be displayed. This is an explicit wait.
        /// </summary>
        /// <param  name="locator"></param>
        public static void Wait(By locator, int maxSecondstoWait)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(maxSecondstoWait))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50),
            };
            wait.Until(driver =>
            {
                try
                {
                    var elementToBeDisplayed = ObjectRepository.Driver.FindElement(locator);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }

        //public static WebDriverWait GetWebdriverWait(TimeSpan timeout)
        //{
        //    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        //    WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout)
        //    {
        //        PollingInterval = TimeSpan.FromMilliseconds(500),
        //    };
        //    wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
        //    return wait;
        //}


        public static void WaitForAnimationtoComplete(By locator, int maxtime)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(maxtime))
            {
                PollingInterval = TimeSpan.FromMilliseconds(10),
            };
            wait.Until(driver => {
                try
                {
                    driver = ObjectRepository.Driver;
                    var element = driver.FindElement(locator);
                    return !element.Displayed;
                }
                //catch (NoSuchElementException)
                //{
                //    // Returns true because the element is not present in DOM. The
                //    // try block checks if the element is present but is invisible.
                //    return true;
                //}
                catch (StaleElementReferenceException)
                {
                    // Returns true because stale element reference implies that element
                    // is no longer visible.
                    return false;   
                }
            });
            
        }
        public static void WaitForPageToLoad(int maxSecondsToWait)
        {
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, new TimeSpan(maxSecondsToWait))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50)
                
            };
            //wait.Until(d => (bool)(d as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
