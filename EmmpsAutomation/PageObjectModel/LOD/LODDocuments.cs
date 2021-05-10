using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODDocuments
    {
        MiscPageOjects misc = new MiscPageOjects();

        //Importnat Strings for Document Manipulation and Upload
        public readonly string LISTOFFILESKEY = "ListOfFiles";
        public readonly string DELETEDFILEKEY = "DeletedFile";
        public readonly string UPLOADEDFILE = "UploadedFile";
        public readonly string TESTFILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"Project Items\TestFile.pdf"));

        //public readonly string TESTFILE = @"C:\Temp\TestFile.pdf";

        //Validations
        public By LODDocumentMedicalDocumentValidMessage => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_RequiredLabel_4");
        public By LODDocumentAuthorizationValidMessage => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_RequiredLabel_6");

        //Document Upload
        public By AddDocumentsButton => By.Id("UploadButton");
        public By UploadFileDiaLogue => By.Id("MEDCHARTContent_NoDivContent_ucFileUpload_file");
        public By UploadFileDescription => By.Id("MEDCHARTContent_NoDivContent_ucFileUpload_description");
        public By FileUploadButton => By.Id("FileUploadUploadButton");
        public By LODExportExcelButton => By.Id("MEDCHARTContent_EmmpsContent_ButtonExportMyLods");

        public By DynamSoftAnimation => By.ClassName("dynamsoft-backdrop");

        //Document Memo Creation
        public By LODCorrespondenceMemoConfirmButton => By.XPath("//*[@id=\"AddDocDiv4\"]/div[3]");
        public By MemoTypeDropDown => By.Id("MEDCHARTContent_EmmpsContent_MemoTypeDropdownList");
        public By ApprovalSignatureDropdown => By.Id("MEDCHARTContent_EmmpsContent_MemoApprovalSignatureDropDownList");
        public By MemoTextBox => By.Id("MemoForTextbox");
        public By OfficeSymbolTextbox => By.Id("MEDCHARTContent_EmmpsContent_MemoOfficeSymbolTextbox");


        public By MemoSignatureTextBox => By.Id("MEDCHARTContent_EmmpsContent_MemoSignatureBlockTextbox");
        public By MemoAddressTextBox => By.Id("MEDCHARTContent_EmmpsContent_MemoAddressTextbox");
        public By SuspenseDateBox => By.Id("MEDCHARTContent_EmmpsContent_MemoSuspenseDateTextbox");
        public By MemoDateBox => By.Id("MEDCHARTContent_EmmpsContent_MemoDateTextbox");
        public By SaveSubmitMemoButton => By.Id("SaveMemoButton");
        public By CancelMemoButton => By.Id("CancelMemoButton");


        

        //Used to determine when the Documents tab is loaded - primarly for debugging purposes
        public By MedDocsRequiredLabel => By.Id("MEDCHARTContent_EmmpsContent_CategoryRepeater_RequiredLabel_4");
        public By LoadedDocumentsPageXpath => By.XPath("/html/body/form/div[5]/div[1]/div/div[1]/div[1]/div[6]/div/div[1]/div[1]");


        //LOD Document Header Categories//
        public By LODForms => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[1]");
        public By LODDocumentation => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[3]");
        public By HardCopyofActiveDA => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[5]");
        public By LODCorrespondence => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[7]");
        public By MedicalDocsCivMil => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[9]");
        public By DeathCert => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[11]");
        public By AuthOrdersDutyStatus => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[13]");
        public By DAForm1379 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[15]");
        public By DAForm1380 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[17]");
        public By DD214 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[19]");
        public By JAGReview => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[21]");
        public By SurgeonReview => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[23]");
        public By InvestigateOfficer => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[25]");
        public By SoldiersRightsWarningsStatement => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[27]");
        public By DisabilityCounselingBrief => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[29]");
        public By Last2MedicalCerts => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[31]");
        public By WitnessSoldierStatements => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[33]");
        public By SF88DD2808 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[35]");
        public By AdverseNotifLetter => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[37]");
        public By PoliceReport => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[39]");
        public By PhotoMapsSketch => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[41]");
        public By PreviousSupportingDocs => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[43]");
        public By PreviousCivInjuryRecords => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[45]");
        public By FollowupMedDocs => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[47]");
        public By MedicalElligibilityVerify => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[49]");
        public By MedicalBills => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[51]");
        public By MedicalReleaseForm => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[53]");
        public By AdditionDocs => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[55]");
        public By AppealofDetermineDocs => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[57]");
        public By DAForm3349 => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[59]");
        public By PreDeployMedAssess => By.XPath("//*[@id=\"MEDCHARTContent_EmmpsContent_editUpdatePanel\"]/div[2]/div[61]");

        //Surgeon Revieww Upload Options
        public By LODDocSurgeonReviewConfirm => By.XPath("//*[@id=\"AddDocDiv28\"]/div[3]");
        public By LODSurgeonReviewUpload => By.XPath("//*[@id=\"AddDocTypeRadioButtonList28\"]/label[2]");
        public By LODDocSurgeonReviewSaveMemo => By.Id("SaveMemoButton");
        public By LODDocSurgeonReviewSavePdf => By.Id("form1");


        public IWebElement CreateDeleteFileLink(string rowNumber)
        {
            var linkLocator = CreateDeleteFileLocator(rowNumber);
            return UIActions.GetElement(linkLocator);
        }

        public By CreateDeleteFileLocator(string rowNumber)
        {
            return By.Id($"MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_{rowNumber}_DocDeleteLinkButton_0");
        }
        public By CreateChainedDeleteFileLocator(string rowNumber)
        {
            return new ByChained(By.Id($"MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_{rowNumber}_DocDeleteLinkButton_0"), By.ClassName("jqbutton-delete"));
        }
        public By CreateEditFileLocator(string rowNumber)
        {

            return By.Id($"MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_{ rowNumber}_EditMemoLinkButton_0");
        }
        public By CreateLODRenameFileLocator(string rowNumber)
        {
            return By.Id($"MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_{rowNumber}_StartRenameLinkButton_0");
        }
        public By CreateLODRenameTextBoxLocator(string rowNumber)
        {
            return By.Id($"MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_{rowNumber}_RenameTextbox_0");
        }
        public By CreateLODRenameSaveLinkLocator(string rowNumber)
        {
            return By.Id($"MEDCHARTContent_EmmpsContent_CategoryRepeater_DocumentRepeater_{rowNumber}_SaveRenameLinkButton_0");
        }



        public void UploadFile(string fileDescription, string fileName)
        {

            //UIActions.GetElement(UploadFileDiaLogue);
            DocumentUpload.UploadFile(UploadFileDiaLogue, fileName);
            Thread.Sleep(500);
            UIActions.TypeInTextBox(UploadFileDescription, fileDescription);
            UIActions.ClickElement(FileUploadButton);
            UIActions.ClickElement(FileUploadButton);
        }

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

        public By CreateDivLocatorByTitle(string title)
        {
            WaitMethods.Wait(LoadedDocumentsPageXpath, 500);
            title = title.StripQuotes();
            DebuggingHelpers.Log.Debug("In SearchUsingParentsTitleAndTargetsId");
            DebuggingHelpers.Log.Debug($"Looking for: //div[@title='{title}']");
            return By.XPath($"//div[@title='{title}']");
        }

        public By FindNextSiblingOfDivLocatorByTitle(string title)
        {
            title = title.StripQuotes();
            DebuggingHelpers.Log.Debug("In SearchUsingParentsTitleAndTargetsId");
            DebuggingHelpers.Log.Debug($"Looking for: //div[@title='{title}']/following-sibling::div");
            return By.XPath($"//div[@title='{title}']/following-sibling::div*");
        }

        public ReadOnlyCollection<IWebElement> GetSensitivityElements()
        {
            var formElement = UIActions.GetElement(By.Id("form1"));
            var elements = formElement.FindElements(By.XPath("//input[@name='sensitivity_radiobtn']"));
            return elements;
        }

        public void VerifyValidations()
        {
            UIActions.GetElement(LODDocumentMedicalDocumentValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODDocumentMedicalDocumentValidMessage).Text.Should().BeEquivalentTo("Required");
            ClickUploadDcoumentLink(MedicalDocsCivMil, "UploadButton");
            UploadFile("Medical Documents", TESTFILE);
            Thread.Sleep(500);
            ObjectRepository.Driver.FindElements(LODDocumentMedicalDocumentValidMessage).Count.Should().Be(1);

            UIActions.GetElement(LODDocumentAuthorizationValidMessage).Displayed.Should().BeTrue();
            UIActions.GetElement(LODDocumentAuthorizationValidMessage).Text.Should().BeEquivalentTo("Required");
            ClickUploadDcoumentLink(AuthOrdersDutyStatus, "UploadButton");
            UploadFile("Authorization Orders", TESTFILE);
            Thread.Sleep(500);
            ObjectRepository.Driver.FindElements(LODDocumentAuthorizationValidMessage).Count.Should().Be(1);
        }
    }
}
