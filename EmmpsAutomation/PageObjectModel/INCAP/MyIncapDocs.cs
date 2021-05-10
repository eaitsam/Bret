using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.INCAP
{
    public class MyIncapDocs
    {
        #region My INCAP Documents Tab Objects
        //---------------------------------------------------------------------------------------------//
        //Objects are organized by HTML Tag type in their own #region tags
        //Please Keep all objects organized this way for ease of use and maintenance in the Object Model
        //---------------------------------------------------------------------------------------------//

        #region HTML Div

        public By INCAPDocumentsMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_INCAPDocumentsMenuDiv");

        #endregion
        #region Document Categories
        public By LODForms => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[1]");
        public By LODCorrespondence => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[3]");
        public By LODDocumentation => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[5]");
        public By HardCopyDAForm2167 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        public By MedicalDocsCivMil => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[9]");
        public By AuthOrdersDutyStatus => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[1]");
        public By DAForm1379 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[13]");
        public By DAForm1380 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[15]");
        public By DD214 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[17]");
        public By INCAPCorrespondence => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[19]");

        public By DAForm7574 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[21]");
        public By DAForm7574PhysicianStatement => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[23]");
        public By DAForm7574SoldierAcknowledge => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[25]");
        public By ExtMemo => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[27]");
        public By INCAPSupportDocs => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[29]");
        public By IRBMeetingMinutes => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[31]");
        public By DAForm3349 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[33]");
        public By SurgeonReview => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[35]");
        public By JAGReview => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[37]");
        public By FinanceDocs => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[39]");
        public By AdditionalDocs => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[41]");
        public By AppealofDetermination => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[43]");

        //public By INCAPDocumentsCategory1label = By.XPath("//div[contains(@title, 'Line of Duty Forms')]");
        //public By INCAPDocumentsCategory2label = By.XPath("//div[contains(@title, 'LOD Correspondence')]");
        //public By INCAPDocumentsCategory3label = By.XPath("//div[contains(@title, 'LOD Documentation')]");
        //public By INCAPDocumentsCategory4label = By.XPath("//div[contains(@title, 'Hard Copy of Active DA Form 2173 and/or DD Form 261')]");
        //public By INCAPDocumentsCategory5label = By.XPath("//div[contains(@title, 'Medical Documents (Civ/Mil)')]");
        //public By INCAPDocumentsCategory6label = By.XPath("//div[contains(@title, 'Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214')]");
        //public By INCAPDocumentsCategory7label = By.XPath("//div[contains(@title, 'DA Form 1379  Record of Training')]");
        //public By INCAPDocumentsCategory8label = By.XPath("//div[contains(@title, 'DA Form 1380/Commander Signed Unit Sign-in Roster')]");
        //public By INCAPDocumentsCategory9label = By.XPath("//div[contains(@title, 'DD 214 & DD 215/NGB-22')]");
        //public By INCAPDocumentsCategory10label = By.XPath("//div[contains(@title, 'INCAP Correspondence')]");
        //public By INCAPDocumentsCategory11label = By.XPath("//div[contains(@title, 'DA Form 7574 - Incapacitation Pay Monthly Claim Form')]");
        //public By INCAPDocumentsCategory12label = By.XPath("//div[contains(@title, 'DA Form 7574-1 - Physicians Statement of Soldiers Incapacitation/Fitness for Duty')]");
        //public By INCAPDocumentsCategory13label = By.XPath("//div[contains(@title, 'DA Form 7574-2 - Soldiers Acknowledgement of Incapacitation Pay Counseling')]");
        //public By INCAPDocumentsCategory14label = By.XPath("//div[contains(@title, 'Extension Memo')]");
        //public By INCAPDocumentsCategory15label = By.XPath("//div[contains(@title, 'Incap Other Supporting Documents')]");
        //public By INCAPDocumentsCategory16label = By.XPath("//div[contains(@title, 'IRB Meeting Minutes')]");
        //public By INCAPDocumentsCategory17label = By.XPath("//div[contains(@title, 'DA Form 3349 - Medical Profile')]");
        //public By INCAPDocumentsCategory18label = By.XPath("//div[contains(@title, 'Surgeon Review/Opinion')]");
        //public By INCAPDocumentsCategory19label = By.XPath("//div[contains(@title, 'JAG Review/Opinion')]");
        //public By INCAPDocumentsCategory20label = By.XPath("//div[contains(@title, 'Financial Documents (W2, Tax Returns, Pay Stubs, etc)')]");
        //public By INCAPDocumentsCategory21label = By.XPath("//div[contains(@title, 'Additional Documentation')]");
        //public By INCAPDocumentsCategory22label = By.XPath("//div[contains(@title, 'Appeal Determination Documentation')]");



        #endregion
        #region Upload Document

        public By INCAPDocumentsBrowseButton = By.XPath("//input[contains(@id, 'MEDCHARTContent_NoDivContent_ucFileUpload_file')]");
        public By INCAPDocumentsUploadButton = By.XPath("//button[contains(@id, 'FileUploadUploadButton')]");

        public By INCAPDocumentsDescriptionTextBox = By.XPath("//input[contains(@id, 'MEDCHARTContent_NoDivContent_ucFileUpload_description')]");
        public By INCAPDocumentsUploadDateBox = By.XPath("//input[contains(@id, 'MEDCHARTContent_NoDivContent_ucFileUpload_date')]");

        #endregion
        #region Buttons

        public By INCAPDocumentsCategory1AddButton = new ByChained(By.XPath("//div[contains(@title, 'Line of Duty Forms')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory2AddButton = new ByChained(By.XPath("//div[contains(@title, 'LOD Correspondence')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory3AddButton = new ByChained(By.XPath("//div[contains(@title, 'LOD Documentation')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory4AddButton = new ByChained(By.XPath("//div[contains(@title, 'Hard Copy of Active DA Form 2173 and/or DD Form 261')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory5AddButton = new ByChained(By.XPath("//div[contains(@title, 'Medical Documents (Civ/Mil)')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory6AddButton = new ByChained(By.XPath("//div[contains(@title, 'Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory7AddButton = new ByChained(By.XPath("//div[contains(@title, 'DA Form 1379  Record of Training')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory8AddButton = new ByChained(By.XPath("//div[contains(@title, 'DA Form 1380/Commander Signed Unit Sign-in Roster')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory9AddButton = new ByChained(By.XPath("//div[contains(@title, 'DD 214 & DD 215/NGB-22')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory10AddButton = new ByChained(By.XPath("//div[contains(@title, 'INCAP Correspondence')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory11AddButton = new ByChained(By.XPath("//div[contains(@title, 'DA Form 7574 - Incapacitation Pay Monthly Claim Form')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory12AddButton = new ByChained(By.XPath("//div[contains(@title, 'DA Form 7574-1 - Physicians Statement of Soldiers Incapacitation/Fitness for Duty')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory13AddButton = new ByChained(By.XPath("//div[contains(@title, 'DA Form 7574-2 - Soldiers Acknowledgement of Incapacitation Pay Counseling')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory14AddButton = new ByChained(By.XPath("//div[contains(@title, 'Extension Memo')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory15AddButton = new ByChained(By.XPath("//div[contains(@title, 'Incap Other Supporting Documents')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory16AddButton = new ByChained(By.XPath("//div[contains(@title, 'IRB Meeting Minutes')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory17AddButton = new ByChained(By.XPath("//div[contains(@title, 'DA Form 3349 - Medical Profile')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory18AddButton = new ByChained(By.XPath("//div[contains(@title, 'Surgeon Review/Opinion')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory19AddButton = new ByChained(By.XPath("//div[contains(@title, 'JAG Review/Opinion')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory20AddButton = new ByChained(By.XPath("//div[contains(@title, 'Financial Documents (W2, Tax Returns, Pay Stubs, etc)')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory21AddButton = new ByChained(By.XPath("//div[contains(@title, 'Additional Documentation')]"), By.Id("UploadButton"));
        public By INCAPDocumentsCategory22AddButton = new ByChained(By.XPath("//div[contains(@title, 'Appeal Determination Documentation')]"), By.Id("UploadButton"));

        #endregion

        #endregion

    }
}
