using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System;

namespace facebook1
{
    public class FacebookAutomation
    {
        [Fact]
        public void Test1() 
        {
            IWebDriver driver = new ChromeDriver(); //Chrome thing is fixed

          //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.ebay.com/";

            driver.Manage().Window.Maximize();

            IWebElement Electronics = driver.FindElement(By.LinkText("Electronics"));

          


            




           
            IWebElement Iphone = driver.FindElement(By.LinkText("iPhone"));
            


           


            Actions action = new Actions(driver);
            action.Click(Electronics);

            action.MoveToElement(Electronics).Build().Perform();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            action.MoveToElement(Iphone).Click();

            action.Click(Iphone);


            //AppleAddress.Click();









            /*IWebElement EmailAdd = driver.FindElement(By.Id("email"));
            IWebElement PasswordAdd = driver.FindElement(By.Id("pass"));

            //driver.Manage().Timeouts().ImplicitWait(40, TimeUnits.seconds);


            

            System.Threading.Thread.Sleep(3000);
           


      
            EmailAdd.SendKeys("Brett123");
            

            EmailAdd.SendKeys("HENDRICKSON");

            PasswordAdd.SendKeys("Eaitsam");

            //How do we Hover?


            // IWebElement LoginButton1 = driver.FindElement(By.Id("u_0_h"));
            //IWebElement LoginButton1 = driver.FindElement(By.XPath("//button[@id='u_0_h']"));
            //LoginButton1.Click();   */











        }
    }
}
