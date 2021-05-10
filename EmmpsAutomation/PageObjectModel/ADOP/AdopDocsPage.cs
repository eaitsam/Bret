using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopDocsPage
    {
        #region My ADOPs Documents Tab Objects
        #region HTML Div
        public By ADOPDocumentsMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPDocumentsMenuDiv");
        public By ADOPDocumentsTab = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPDocumentsMenuLinkButton");
        public By ADOPDocUploader => By.Id("UploadButton");
        public By ADOPManageUpload => By.Id("ManageButton");
        
        public By ADOPRenameMedDoc => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_4_StartRenameLinkButton_0");
        public By ADOPDeleteMedDoc => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_4_DocDeleteLinkButton_0");
        public By ADOPEditMedDoc => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_4_EditMemoLinkButton_0");

        public By ADOPRenameAuthorizationDutyStatus => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_5_StartRenameLinkButton_0");
        public By ADOPDeleteAuthorizationDutyStatus => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_5_DocDeleteLinkButton_0");
        public By ADOPEditAuthorizationDutyStatus => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_5_EditMemoLinkButton_0");

        public By ADOPRenameDamps => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_9_StartRenameLinkButton_0");
        public By ADOPDeleteDamps => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_9_DocDeleteLinkButton_0");
        public By ADOPEditDamps => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_9_EditMemoLinkButton_0");


        #endregion
        #endregion
        public By ADOPMedDocValidationMessage4 => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_RequiredLabel_4");
        public By ADOPDutyStatusValidationMessage5 => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_RequiredLabel_5");
        public By ADOPUploadButton => By.Id("UploadButton");
        public By ADOPLODDocumentation => By.XPath("/*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[5]");
        public By HardCopy => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        //public By MedDocuments => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        //public By AuthorizationOrders => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        //public By DD/NGB => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        //public By DAFormMedProfile => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        //public By OtherDocuments => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        //public By DAMPSOrders => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        //Importnat Strings for Document Manipulation and Upload
        
        public readonly string LISTOFFILESKEY = "ListOfFiles";
        public readonly string DELETEDFILEKEY = "DeletedFile";
        public readonly string UPLOADEDFILE = "UploadedFile";
        public readonly string TESTFILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Project Items\TestFile.pdf"));


        public void ClickUploadDcoumentLink(By locator, string childId)
        {

            var addLinkLocator = By.Id(childId);
            var chainedAddLinkLocator = new ByChained(locator, addLinkLocator);
            DebuggingHelpers.Log.Debug($"IS '{By.XPath($"{locator}")}' present: {UIActions.IsElementPresent(By.XPath($"//div[@title='{locator}']"))}");
            WaitMethods.Wait(chainedAddLinkLocator, 60);
            UIActions.JSScrollToView(chainedAddLinkLocator);
            Thread.Sleep(500);
            //if (UIActions.GetElement(misc.uiwidget).Displayed == true)
            //{
            //    WaitMethods.WaitForAnimationtoComplete(misc.uiwidget, 10);
            //}
            //UIActions.GetElement(chainedAddLinkLocator).Click();
            UIActions.JSClickElement(chainedAddLinkLocator);
        }






    }
}        

