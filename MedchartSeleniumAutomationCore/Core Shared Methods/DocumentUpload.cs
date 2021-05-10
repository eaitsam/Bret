using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedchartSeleniumAutomationCore.Core_Shared_Methods
{
    public class DocumentUpload
    {
        public static readonly string LISTOFFILESKEY = "ListOfFiles";
        public static readonly string DELETEDFILEKEY = "DeletedFile";
        public static readonly string UPLOADEDFILE = "UploadedFile";
        public static readonly string TESTFILE = @"C:\Temp\TestFile.pdf";

        public static By FileUploadButton => By.Id("FileUploadUploadButton");


        public By AddDocumentsButton => By.Id("UploadButton");
        public By LoadedDocumentsPageXpath => By.XPath("/html/body/form/div[5]/div[1]/div/div[1]/div[1]/div[6]/div/div[1]/div[1]");

        public static void UploadFile(By locator, string filepath)
        {
            var element = UIActions.GetElement(locator);
            element.SendKeys(filepath);
        }
        public By CreateDivLocatorByTitle(string title)
        {
            WaitMethods.Wait(LoadedDocumentsPageXpath, 500);
            title = title.StripQuotes();
            DebuggingHelpers.Log.Debug("In SearchUsingParentsTitleAndTargetsId");
            DebuggingHelpers.Log.Debug($"Looking for: //div[@title='{title}']");
            return By.XPath($"//div[@title='{title}']");
        }
        public void ClickUploadDcoumentLink(By locator, string childId)
        {
            //WaitMethods.Wait(AddDocumentsButton, 60);
            // var form = By.XPath("//div[@title='form1']");
            var addLinkLocator = By.Id(childId);
            var chainedAddLinkLocator = new ByChained(locator, addLinkLocator);

            DebuggingHelpers.Log.Debug($"IS '{By.XPath($"{locator}")}' present: {UIActions.IsElementPresent(By.XPath($"//div[@title='{locator}']"))}");
            UIActions.MoveTo(chainedAddLinkLocator);
            //UIActions.ClickLink(chainedAddLinkLocator);
            UIActions.JSClickElement(chainedAddLinkLocator);
        }

    }
}
