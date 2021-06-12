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
            
             driver.Url = "https://www.ebay.com/";
            IWebElement Electronics = driver.FindElement(By.LinkText("Electronics"));

            //driver.Manage().Timeouts().ImplicitWait();



             IWebElement Iphone = driver.FindElement(By.LinkText("iPhones"));
              // IWebElement Iphone = driver.FindElement(By.XPath("//a[@href="https://www.ebay.com/b/Apple-iPhone/9355/bn_319682"]));

            Actions action = new Actions(driver);
            
            action.MoveToElement(Electronics).Build().Perform();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            //action.MoveToElement(Iphone).Click();

            action.Click(Iphone);




            



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
