using EmmpsAutomation.PageObjectModel.LOD;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.LOD
{
    public class DocumentsTab
    {

        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        MyLODMenuNav _lodnav;
        LODSearchPage _search;
        LODDocuments _docs;

        public DocumentsTab()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _lodnav = new MyLODMenuNav();
            _search = new LODSearchPage();
            _docs = new LODDocuments();
        }

        [Fact]
        public void Test40070()
        {
            //LODDocumentsRequiredLabelValidation();
        }


        //---------------------------------------------------------------------//

        [Fact]
        public void UploadADocument()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070122");

                List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink };
                MasterMenuNavigation.StartTabSelectionMethod(tabs);

                UIActions.SelectElementByText(_search.LODComboBoxWorkflow, "AR Formal");
                UIActions.SelectElementByText(_search.LODComboBoxStatus, "LOD Draft (AR)");
                UIActions.GetElement(_search.SearchFilterResultsRow0CaseIDLink).Click();

                UIActions.JSClickElement(_lodnav.LODDocumentsMenuLinkButtonLinkText);
                WaitMethods.Wait(_docs.MedicalDocsCivMil, 60);

                _docs.ClickUploadDcoumentLink(_docs.MedicalDocsCivMil, "UploadButton");
                Thread.Sleep(500);
                _docs.UploadFile("Medical Documents", _docs.TESTFILE);
                Thread.Sleep(500);

                _docs.ClickUploadDcoumentLink(_docs.AuthOrdersDutyStatus, "UploadButton");
                Thread.Sleep(500);
                _docs.UploadFile("Authorization Orders", _docs.TESTFILE);
                Thread.Sleep(500);

            }
            finally
            {
                _driverInit.TearDown();
            }
        }




        [Fact]
        public void LODDocumentsRequiredLabelValidation()
        {
            //_driverInit.InitWebdriver();
            //_login.LoginMethod("8880070122");

            //List<By> tabs = new List<By> { _navMenu.EMMPSMenuBarCss, _navMenu.LODMenuBarLink, _navMenu.MyLODLink };
            //MasterMenuNavigation.StartTabSelectionMethod(tabs);

            //UIActions.SelectElementByText(_search.LODComboBoxWorkflow, "AR Formal");
            //UIActions.SelectElementByText(_search.LODComboBoxStatus, "LOD Draft (AR)");
            //UIActions.GetElement(_search.SearchFilterResultsRow0CaseIDLink).Click();

            //UIActions.JSClickElement(myLOD.LODDocumentsMenuLinkButtonLinkText);
            //WaitMethods.Wait(docs.MedicalDocsCivMil, 60);

            //string docDivId = "AddDocDiv" + id;
            ////docNames are comma separated
            //var neededDocs = docNames.Split(',');
            //var formEntries = MyLODPage.Map.CheckForForms(docDivId, neededDocs);
            //Assert.IsTrue(formEntries.HasAllForms);


            ////###	test case 40070 : http://s150rctfs15-01:8080/tfs/rctfs_medchart/med-chart/_workitems?_a=edit&id=40070

            ////Scenario Outline: LOD Documents tab
            ////	Given I am Logged in as <Role> using EDIPIN<PIN>
            ////	And I have navigated to My LODs tab in "eMMPS"
            ////	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
            ////	When I click the "Documents" Tab in "LOD"
            ////	Then the list of<RequiredDocNames> for section<docDivId> should be in the correct order

            ////	Scenarios:
            ////	| Role          | PIN        | Workflow  | Case ID      | Status    | RequiredDocNames   | TabName   | docDivId |
            ////	| AR Unit Admin | 8880070122 | AR Formal | 055-16-00049 | -- All -- | Form 261, Form 2173 | Documents | 1        |

        }

        //Scenario Outline: lod documents hover tooltips
        //	Given I am Logged in as <Role> using EDIPIN <PIN>
        //	And I have navigated to "My LODs" tab in "eMMPS"
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	#And I hover over the '<Section Title>'
        //	Then a tooltip<Section Title> should appear

        //   Scenarios:
        //	| Role          | PIN        | Section Title                                                    | Case ID      | TabName   | FileInnerText            |
        //	#| AR Unit Admin | 8880070122 | Line of Duty Forms                                               | 055-16-00049 | Documents | Form                     |
        //	#| AR Unit Admin | 8880070122 | LOD Documentation (For Pre-Approved LOD)                         | 055-16-00049 | Documents | LOD Documentation        |
        //	#| AR Unit Admin | 8880070122 | Hard Copy of Active DA Form 2173 and/or DD Form 261              | 055-16-00049 | Documents | Hard Copy                |
        //	#| AR Unit Admin | 8880070122 | LOD Correspondence                                               | 055-16-00049 | Documents | LOD Correspondence       |
        //	#| AR Unit Admin | 8880070122 | Medical Documents (Civ/Mil)                                      | 055-16-00049 | Documents | Medical                  |
        //	#| AR Unit Admin | 8880070122 | Death Certificate or Autopsy Report (req                         | 055-16-00049 | Documents | Death Certificate        |
        //	#| AR Unit Admin | 8880070122 | Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214       | 055-16-00049 | Documents | Authorization            |
        //	#| AR Unit Admin | 8880070122 | DA Form 1379 Record of Training                                  | 055-16-00049 | Documents | DA Form 1379             |
        //	#| AR Unit Admin | 8880070122 | DA Form 1380/Commander Signed Unit Sign-in Roster                | 055-16-00049 | Documents | DA Form 1380             |
        //	#| AR Unit Admin | 8880070122 | DD 214 & DD 215/NGB-22                                           | 055-16-00049 | Documents | DD 214                   |
        //	#| AR Unit Admin | 8880070122 | JAG Review/Opinion                                               | 055-16-00049 | Documents | JAG Review               |
        //	#| AR Unit Admin | 8880070122 | Surgeon Review/Opinion                                           | 055-16-00049 | Documents | Surgeon Review           |
        //	#| AR Unit Admin | 8880070122 | Investigating Officer Appointment Memorandum                     | 055-16-00049 | Documents | Investigating            |
        //	| AR Unit Admin | 8880070122 | Soldier                                                          | 055-16-00049 | Documents | Soldier                  |
        //	| AR Unit Admin | 8880070122 | Disability Counseling Statement/Soldier Briefing                 | 055-16-00049 | Documents | Disability               |
        //	#| AR Unit Admin | 8880070122 | Last Two Annual Medical Certificates                             | 055-16-00049 | Documents | Last Two                 |
        //	#| AR Unit Admin | 8880070122 | Witness & Soldier Statements (DA Form 2823)                      | 055-16-00049 | Documents | Witness                  |
        //	#| AR Unit Admin | 8880070122 | SF 88 & SF 93 or DD 2808 & 2807-1 (last 2 periodic exams)        | 055-16-00049 | Documents | SF 88                    |
        //	#| AR Unit Admin | 8880070122 | Adverse Notification Letter with signed Certified Return Receipt | 055-16-00049 | Documents | Adverse Notification     |
        //	#| AR Unit Admin | 8880070122 | Police Report                                                    | 055-16-00049 | Documents | Police Report            |
        //	#| AR Unit Admin | 8880070122 | Photographs, Maps, or Sketches                                   | 055-16-00049 | Documents | Photographs              |
        //	#| AR Unit Admin | 8880070122 | Previous LODs and Supporting Documents                           | 055-16-00049 | Documents | Supporting               |
        //	#| AR Unit Admin | 8880070122 | Previous LODs Civilian Injury Medical Records                    | 055-16-00049 | Documents | Civilian                 |
        //	#| AR Unit Admin | 8880070122 | Follow-up Medical Documentation                                  | 055-16-00049 | Documents | Follow-up                |
        //	#| AR Unit Admin | 8880070122 | Medical Eligibility Verification (MMSO Form-01 and MMSO Form-02) | 055-16-00049 | Documents | Eligibility              |
        //	#| AR Unit Admin | 8880070122 | Medical Bills                                                    | 055-16-00049 | Documents | Medical Bills            |
        //	#| AR Unit Admin | 8880070122 | Medical Release Forms                                            | 055-16-00049 | Documents | Medical Release          |
        //	#| AR Unit Admin | 8880070122 | Additional Documentation                                         | 055-16-00049 | Documents | Additional Documentation |
        //	#| AR Unit Admin | 8880070122 | Appeal Determination Documentation                               | 055-16-00049 | Documents | Appeal                   |
        //	#| AR Unit Admin | 8880070122 | DA Form 3349 - Medical Profile                                   | 055-16-00049 | Documents | DA Form 3349             |
        //	#| AR Unit Admin | 8880070122 | Pre-Deployment Health Assessment                                 | 055-16-00049 | Documents | Pre-Deployment           |

        //Scenario Outline: LOD Documents Adding new docs
        //	Given I am Logged in as <Role> using EDIPIN <PIN>
        //	And I have navigated to "My LODs" tab in "eMMPS"
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of<Section Title>
        //	And fill out the fields and upload a document<FileInnerText>
        //	Then a new doccument '<Section Title>' will appear '<RowNumber>'

        //	Scenarios:
        //	| Role          | PIN        | Section Title                                                    | Case ID      | docdivId | TabName   | FileInnerText            | RowNumber |
        //	#| AR Unit Admin | 8880070122 | LOD Documentation (For Pre-Approved LOD)                         | 055-16-00049 | 329      | Documents | LOD Documentation        |
        //	#| AR Unit Admin | 8880070122 | Hard Copy of Active DA Form 2173 and/or DD Form 261              | 055-16-00049 | 88       | Documents | Hard Copy                |
        //	#| AR Unit Admin | 8880070122 | LOD Correspondence                                               | 055-16-00049 | 4        | Documents | LOD Correspondence       |
        //	#| AR Unit Admin | 8880070122 | Medical Documents (Civ/Mil)                                      | 055-16-00049 | 12       | Documents | Medical                  |
        //	#| AR Unit Admin | 8880070122 | Death Certificate or Autopsy Report (req                         | 055-16-00049 | 29       | Documents | Death Certificate        |
        //	#| AR Unit Admin | 8880070122 | Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214       | 055-16-00049 | 22       | Documents | Authorization            |
        //	#| AR Unit Admin | 8880070122 | DA Form 1379 Record of Training                                  | 055-16-00049 | 3        | Documents | DA Form 1379             |
        //	| AR Unit Admin | 8880070122 | DA Form 1380/Commander Signed Unit Sign-in Roster                | 055-16-00049 | 321      | Documents | DA Form 1380             | 8 |
        //	| AR Unit Admin | 8880070122 | DD 214 & DD 215/NGB-22                                           | 055-16-00049 | 369      | Documents | DD 214                   | 9 |
        //	#| AR Unit Admin | 8880070122 | JAG Review/Opinion                                               | 055-16-00049 | 23       | Documents | JAG Review               |
        //	#| AR Unit Admin | 8880070122 | Surgeon Review/Opinion                                           | 055-16-00049 | 28       | Documents | Surgeon Review           |
        //	#| AR Unit Admin | 8880070122 | Investigating Officer Appointment Memorandum                     | 055-16-00049 | 13       | Documents | Investigating            |
        //	| AR Unit Admin | 8880070122 | Soldier                                                          | 055-16-00049 | 10       | Documents | Soldier                  | 12|
        //	#| AR Unit Admin | 8880070122 | Disability Counseling Statement/Soldier Briefing                 | 055-16-00049 | 30       | Documents | Disability               |
        //	#| AR Unit Admin | 8880070122 | Last Two Annual Medical Certificates                             | 055-16-00049 | 15       | Documents | Last Two                 |
        //	#| AR Unit Admin | 8880070122 | Witness & Soldier Statements (DA Form 2823)                      | 055-16-00049 | 5        | Documents | Witness                  |
        //	#| AR Unit Admin | 8880070122 | SF 88 & SF 93 or DD 2808 & 2807-1 (last 2 periodic exams)        | 055-16-00049 | 87       | Documents | SF 88                    |
        //	#| AR Unit Admin | 8880070122 | Adverse Notification Letter with signed Certified Return Receipt | 055-16-00049 | 19       | Documents | Adverse Notification     |
        //	#| AR Unit Admin | 8880070122 | Police Report                                                    | 055-16-00049 | 24       | Documents | Police Report            |
        //	#| AR Unit Admin | 8880070122 | Photographs, Maps, or Sketches                                   | 055-16-00049 | 18       | Documents | Photographs              |
        //	#| AR Unit Admin | 8880070122 | Previous LODs and Supporting Documents                           | 055-16-00049 | 20       | Documents | Supporting               |
        //	#| AR Unit Admin | 8880070122 | Previous LODs Civilian Injury Medical Records                    | 055-16-00049 | 21       | Documents | Civilian                 |
        //	#| AR Unit Admin | 8880070122 | Follow-up Medical Documentation                                  | 055-16-00049 | 181      | Documents | Follow-up                |
        //	#| AR Unit Admin | 8880070122 | Medical Eligibility Verification (MMSO Form-01 and MMSO Form-02) | 055-16-00049 | 254      | Documents | Eligibility              |
        //	#| AR Unit Admin | 8880070122 | Medical Bills                                                    | 055-16-00049 | 297      | Documents | Medical Bills            |
        //	#| AR Unit Admin | 8880070122 | Medical Release Forms                                            | 055-16-00049 | 379      | Documents | Medical Release          |
        //	#| AR Unit Admin | 8880070122 | Additional Documentation                                         | 055-16-00049 | 292      | Documents | Additional Documentation |
        //	#| AR Unit Admin | 8880070122 | Appeal Determination Documentation                               | 055-16-00049 | 230      | Documents | Appeal                   |
        //	#| AR Unit Admin | 8880070122 | DA Form 3349 - Medical Profile                                   | 055-16-00049 | 182      | Documents | DA Form 3349             |
        //	#| AR Unit Admin | 8880070122 | Pre-Deployment Health Assessment                                 | 055-16-00049 | 65       | Documents | Pre-Deployment           |

        //Scenario Outline: LOD Documents Renaming Uploaded Documents
        //	Given I am Logged in as <Role> using EDIPIN <PIN>
        //	And I have navigated to "My LODs" tab in "eMMPS"
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of<Section Title>
        //	And fill out the fields and upload a document
        //	And I select the Rename<RowNumber> Link of a uploaded Document
        //	And enter the new name of<RenamedFile> and Save for <RowNumber>
        //	Then the Name of the document should be changed<RenamedFile> <docdivId>


        //	Scenarios:
        //	| Role           | PIN        | Section Title                                                    | Case ID      | docdivId | TabName   | RenamedFile     | RowNumber |
        //	#| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)                         | 055-16-00049 | 329      | Documents | BeenRenamed.txt | 1         |
        //	#| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261              | 055-16-00049 | 88       | Documents | BeenRenamed.txt | 2         |
        //	#| 88th RSC Admin | 8880070133 | LOD Correspondence                                               | 055-16-00049 | 4        | Documents | BeenRenamed.txt | 3         |
        //	#| 88th RSC Admin | 8880070133 | Medical Documents (Civ/Mil)                                      | 055-16-00049 | 12       | Documents | BeenRenamed.txt | 4         |
        //	#| 88th RSC Admin | 8880070133 | Death Certificate or Autopsy Report (req                         | 055-16-00049 | 29       | Documents | BeenRenamed.txt | 5         |
        //	#| 88th RSC Admin | 8880070133 | Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214       | 055-16-00049 | 22       | Documents | BeenRenamed.txt | 6         |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1379 Record of Training                                  | 055-16-00049 | 3        | Documents | BeenRenamed.txt | 7         |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1380/Commander Signed Unit Sign-in Roster                | 055-16-00049 | 321      | Documents | BeenRenamed.txt | 8         |
        //	#| 88th RSC Admin | 8880070133 | DD 214 & DD 215/NGB-22                                           | 055-16-00049 | 369      | Documents | BeenRenamed.txt | 9         |
        //	#| 88th RSC Admin | 8880070133 | JAG Review/Opinion                                               | 055-16-00049 | 23       | Documents | BeenRenamed.txt | 10        |
        //	#| 88th RSC Admin | 8880070133 | Surgeon Review/Opinion                                           | 055-16-00049 | 28       | Documents | BeenRenamed.txt | 11        |
        //	#| 88th RSC Admin | 8880070133 | Investigating Officer Appointment Memorandum                     | 055-16-00049 | 13       | Documents | BeenRenamed.txt | 12        |
        //	#| 88th RSC Admin | 8880070133 | Soldier                                                          | 055-16-00049 | 10       | Documents | BeenRenamed.txt | 13        |
        //	#| 88th RSC Admin | 8880070133 | Disability Counseling Statement/Soldier Briefing                 | 055-16-00049 | 30       | Documents | BeenRenamed.txt | 14        |
        //	#| 88th RSC Admin | 8880070133 | Last Two Annual Medical Certificates                             | 055-16-00049 | 15       | Documents | BeenRenamed.txt | 15        |
        //	#| 88th RSC Admin | 8880070133 | Witness & Soldier Statements (DA Form 2823)                      | 055-16-00049 | 5        | Documents | BeenRenamed.txt | 16        |
        //	#| 88th RSC Admin | 8880070133 | SF 88 & SF 93 or DD 2808 & 2807-1 (last 2 periodic exams)        | 055-16-00049 | 87       | Documents | BeenRenamed.txt | 17        |
        //	#| 88th RSC Admin | 8880070133 | Adverse Notification Letter with signed Certified Return Receipt | 055-16-00049 | 19       | Documents | BeenRenamed.txt | 18        |
        //	#| 88th RSC Admin | 8880070133 | Photographs, Maps, or Sketches                                   | 055-16-00049 | 18       | Documents | BeenRenamed.txt | 20        |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs and Supporting Documents                           | 055-16-00049 | 20       | Documents | BeenRenamed.txt | 21        |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs Civilian Injury Medical Records                    | 055-16-00049 | 21       | Documents | BeenRenamed.txt | 22        |
        //	#| 88th RSC Admin | 8880070133 | Follow-up Medical Documentation                                  | 055-16-00049 | 181      | Documents | BeenRenamed.txt | 23        |
        //	| 88th RSC Admin | 8880070133 | Medical Eligibility Verification (MMSO Form-01 and MMSO Form-02) | 055-16-00049 | 254      | Documents | BeenRenamed.txt | 24        |
        //	#| 88th RSC Admin | 8880070133 | Medical Bills                                                    | 055-16-00049 | 297      | Documents | BeenRenamed.txt | 25        |
        //	| 88th RSC Admin | 8880070133 | Medical Release Forms                                            | 055-16-00049 | 379      | Documents | BeenRenamed.txt | 26        |
        //	#| 88th RSC Admin | 8880070133 | Additional Documentation                                         | 055-16-00049 | 292      | Documents | BeenRenamed.txt | 27        |
        //	#| 88th RSC Admin | 8880070133 | Appeal Determination Documentation                               | 055-16-00049 | 230      | Documents | BeenRenamed.txt | 28        |
        //	#| 88th RSC Admin | 8880070133 | DA Form 3349 - Medical Profile                                   | 055-16-00049 | 182      | Documents | BeenRenamed.txt | 29        |
        //	#| 88th RSC Admin | 8880070133 | Pre-Deployment Health Assessment                                 | 055-16-00049 | 65       | Documents | BeenRenamed.txt | 30        |

        //Scenario Outline: LOD Documents: Cancel Deleting Document
        //	Given I am Logged in as <Role> using EDIPIN <PIN>
        //	And I have navigated to "My LODs" tab in "eMMPS"
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I select the Delete Link <RowNumber>
        //	And I click on the Cancel Button
        //	Then '<FileDescription>' in section '<Section Title>' should not be deleted

        //	Scenarios:
        //	| Role           | PIN        | Section Title                                       | Case ID      | docdivId | TabName   | FileDescription | RowNumber |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | DeletedDesc     | 1         |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | DeletedDesc     | 2         |
        //	#| 88th RSC Admin | 8880070133 | LOD Correspondence                                               | 055-16-00049 | 4        | Documents | DeletedDesc | 3         |
        //	#| 88th RSC Admin | 8880070133 | Medical Documents (Civ/Mil)                                      | 055-16-00049 | 12       | Documents | DeletedDesc | 4         |
        //	#| 88th RSC Admin | 8880070133 | Death Certificate or Autopsy Report (req                         | 055-16-00049 | 29       | Documents | DeletedDesc | 5         |
        //	#| 88th RSC Admin | 8880070133 | Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214       | 055-16-00049 | 22       | Documents | DeletedDesc | 6         |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1379 Record of Training                                  | 055-16-00049 | 3        | Documents | DeletedDesc | 7         |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1380/Commander Signed Unit Sign-in Roster                | 055-16-00049 | 321      | Documents | DeletedDesc | 8         |
        //	#| 88th RSC Admin | 8880070133 | DD 214 & DD 215/NGB-22                                           | 055-16-00049 | 369      | Documents | DeletedDesc | 9         |
        //	#| 88th RSC Admin | 8880070133 | JAG Review/Opinion                                               | 055-16-00049 | 23       | Documents | DeletedDesc | 10        |
        //	#| 88th RSC Admin | 8880070133 | Surgeon Review/Opinion                                           | 055-16-00049 | 28       | Documents | DeletedDesc | 11        |
        //	#| 88th RSC Admin | 8880070133 | Investigating Officer Appointment Memorandum                     | 055-16-00049 | 13       | Documents | DeletedDesc | 12        |
        //	#| 88th RSC Admin | 8880070133 | Soldier                                                          | 055-16-00049 | 10       | Documents | DeletedDesc | 13        |
        //	#| 88th RSC Admin | 8880070133 | Disability Counseling Statement/Soldier Briefing                 | 055-16-00049 | 30       | Documents | DeletedDesc | 14        |
        //	#| 88th RSC Admin | 8880070133 | Last Two Annual Medical Certificates                             | 055-16-00049 | 15       | Documents | DeletedDesc | 15        |
        //	#| 88th RSC Admin | 8880070133 | Witness & Soldier Statements (DA Form 2823)                      | 055-16-00049 | 5        | Documents | DeletedDesc | 16        |
        //	#| 88th RSC Admin | 8880070133 | SF 88 & SF 93 or DD 2808 & 2807-1 (last 2 periodic exams)        | 055-16-00049 | 87       | Documents | DeletedDesc | 17        |
        //	#| 88th RSC Admin | 8880070133 | Adverse Notification Letter with signed Certified Return Receipt | 055-16-00049 | 19       | Documents | DeletedDesc | 18        |
        //	#| 88th RSC Admin | 8880070133 | Police Report                                                    | 055-16-00049 | 24       | Documents | DeletedDesc | 19        |
        //	#| 88th RSC Admin | 8880070133 | Photographs, Maps, or Sketches                                   | 055-16-00049 | 18       | Documents | DeletedDesc | 20        |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs and Supporting Documents                           | 055-16-00049 | 20       | Documents | DeletedDesc | 21        |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs Civilian Injury Medical Records                    | 055-16-00049 | 21       | Documents | DeletedDesc | 22        |
        //	#| 88th RSC Admin | 8880070133 | Follow-up Medical Documentation                                  | 055-16-00049 | 181      | Documents | DeletedDesc | 23        |
        //	#| 88th RSC Admin | 8880070133 | Medical Eligibility Verification (MMSO Form-01 and MMSO Form-02) | 055-16-00049 | 254      | Documents | DeletedDesc | 24        |
        //	#| 88th RSC Admin | 8880070133 | Medical Bills                                                    | 055-16-00049 | 297      | Documents | DeletedDesc | 25        |
        //	#| 88th RSC Admin | 8880070133 | Medical Release Forms                                            | 055-16-00049 | 379      | Documents | DeletedDesc | 26        |
        //	#| 88th RSC Admin | 8880070133 | Additional Documentation                                         | 055-16-00049 | 292      | Documents | DeletedDesc | 27        |
        //	#| 88th RSC Admin | 8880070133 | Appeal Determination Documentation                               | 055-16-00049 | 230      | Documents | DeletedDesc | 28        |
        //	#| 88th RSC Admin | 8880070133 | DA Form 3349 - Medical Profile                                   | 055-16-00049 | 182      | Documents | DeletedDesc | 29        |
        //	#| 88th RSC Admin | 8880070133 | Pre-Deployment Health Assessment                                 | 055-16-00049 | 65       | Documents | DeletedDesc | 30        |


        //Scenario Outline: LOD Documents: Delete Document
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to "My LODs" tab in "eMMPS"
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of<Section Title>
        //	And fill out the fields and upload a document<FileDescription>
        //	And I select the Delete Link  <RowNumber>
        //	And Select the OK button<docdivId>
        //	Then the Document should be deleted '<Section Title>' 

        //	Scenarios:
        //	| Role           | PIN        | Section Title                                                    | Case ID      | docdivId | TabName   | RenamedFile     | RowNumber | FileDescription |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)                         | 055-16-00594 | 329      | Documents | BeenRenamed.txt | 1         | GonnaBeDeleted  |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261              | 055-16-00594 | 88       | Documents | BeenRenamed.txt | 2         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | LOD Correspondence                                               | 055-16-00594 | 4        | Documents | BeenRenamed.txt | 3         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Medical Documents (Civ/Mil)                                      | 055-16-00594 | 12       | Documents | BeenRenamed.txt | 4         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Death Certificate or Autopsy Report (req                         | 055-16-00594 | 29       | Documents | BeenRenamed.txt | 5         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214       | 055-16-00594 | 22       | Documents | BeenRenamed.txt | 6         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1379 Record of Training                                  | 055-16-00594 | 3        | Documents | BeenRenamed.txt | 7         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1380/Commander Signed Unit Sign-in Roster                | 055-16-00594 | 321      | Documents | BeenRenamed.txt | 8         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | DD 214 & DD 215/NGB-22                                           | 055-16-00594 | 369      | Documents | BeenRenamed.txt | 9         | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | JAG Review/Opinion                                               | 055-16-00594 | 23       | Documents | BeenRenamed.txt | 10        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Surgeon Review/Opinion                                           | 055-16-00594 | 28       | Documents | BeenRenamed.txt | 11        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Investigating Officer Appointment Memorandum                     | 055-16-00594 | 13       | Documents | BeenRenamed.txt | 12        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Soldier                                                          | 055-16-00594 | 10       | Documents | BeenRenamed.txt | 13        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Disability Counseling Statement/Soldier Briefing                 | 055-16-00594 | 30       | Documents | BeenRenamed.txt | 14        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Last Two Annual Medical Certificates                             | 055-16-00594 | 15       | Documents | BeenRenamed.txt | 15        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Witness & Soldier Statements (DA Form 2823)                      | 055-16-00594 | 5        | Documents | BeenRenamed.txt | 16        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | SF 88 & SF 93 or DD 2808 & 2807-1 (last 2 periodic exams)        | 055-16-00594 | 87       | Documents | BeenRenamed.txt | 17        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Adverse Notification Letter with signed Certified Return Receipt | 055-16-00594 | 19       | Documents | BeenRenamed.txt | 18        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Police Report                                                    | 055-16-00594 | 24       | Documents | BeenRenamed.txt | 19        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Photographs, Maps, or Sketches                                   | 055-16-00594 | 18       | Documents | BeenRenamed.txt | 20        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs and Supporting Documents                           | 055-16-00594 | 20       | Documents | BeenRenamed.txt | 21        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs Civilian Injury Medical Records                    | 055-16-00594 | 21       | Documents | BeenRenamed.txt | 22        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Follow-up Medical Documentation                                  | 055-16-00594 | 181      | Documents | BeenRenamed.txt | 23        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Medical Eligibility Verification (MMSO Form-01 and MMSO Form-02) | 055-16-00594 | 254      | Documents | BeenRenamed.txt | 24        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Medical Bills                                                    | 055-16-00594 | 297      | Documents | BeenRenamed.txt | 25        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Medical Release Forms                                            | 055-16-00594 | 379      | Documents | BeenRenamed.txt | 26        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Additional Documentation                                         | 055-16-00594 | 292      | Documents | BeenRenamed.txt | 27        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Appeal Determination Documentation                               | 055-16-00594 | 230      | Documents | BeenRenamed.txt | 28        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | DA Form 3349 - Medical Profile                                   | 055-16-00594 | 182      | Documents | BeenRenamed.txt | 29        | GonnaBeDeleted  |
        //	#| 88th RSC Admin | 8880070133 | Pre-Deployment Health Assessment                                 | 055-16-00594 | 65       | Documents | BeenRenamed.txt | 30        | GonnaBeDeleted  |


        //Scenario Outline:  LOD Documents Editing Document
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'My LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Origin Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //	And I change the Document Document Type to '<Destination Section Title>'
        //	Then changed MEDCHARTContent_NoDivContent_ucFileIndex_message_label should have message saying success <Destination DivId>
        //	#AFter save, row should display lock icon. Rename or Edit should not appear. 

        //	Scenarios:
        //	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RenamedFile     | RowNumber | FileDescription | Destination Section Title     | Destination DivId |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | BeenRenamed.txt | 1         | GonnaBeDeleted  | Police Report - Police Report | 19                |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | BeenRenamed.txt | 2         | GonnaBeDeleted  | Police Report - Police Report | 19                |
        //	#| 88th RSC Admin | 8880070133 | LOD Correspondence                                               | 055-16-00049 | 4        | Documents | BeenRenamed.txt | 3         | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Medical Documents (Civ/Mil)                                      | 055-16-00049 | 12       | Documents | BeenRenamed.txt | 4         | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Death Certificate or Autopsy Report (req                         | 055-16-00049 | 29       | Documents | BeenRenamed.txt | 5         | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Authorization Orders/DA Form 1379/DA Form 1380/DD Form 214       | 055-16-00049 | 22       | Documents | BeenRenamed.txt | 6         | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1379 Record of Training                                  | 055-16-00049 | 3        | Documents | BeenRenamed.txt | 7         | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | DA Form 1380/Commander Signed Unit Sign-in Roster                | 055-16-00049 | 321      | Documents | BeenRenamed.txt | 8         | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | DD 214 & DD 215/NGB-22                                           | 055-16-00049 | 369      | Documents | BeenRenamed.txt | 9         | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | JAG Review/Opinion                                               | 055-16-00049 | 23       | Documents | BeenRenamed.txt | 10        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Surgeon Review/Opinion                                           | 055-16-00049 | 28       | Documents | BeenRenamed.txt | 11        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Investigating Officer Appointment Memorandum                     | 055-16-00049 | 13       | Documents | BeenRenamed.txt | 12        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Soldier                                                          | 055-16-00049 | 10       | Documents | BeenRenamed.txt | 13        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Disability Counseling Statement/Soldier Briefing                 | 055-16-00049 | 30       | Documents | BeenRenamed.txt | 14        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Last Two Annual Medical Certificates                             | 055-16-00049 | 15       | Documents | BeenRenamed.txt | 15        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Witness & Soldier Statements (DA Form 2823)                      | 055-16-00049 | 5        | Documents | BeenRenamed.txt | 16        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | SF 88 & SF 93 or DD 2808 & 2807-1 (last 2 periodic exams)        | 055-16-00049 | 87       | Documents | BeenRenamed.txt | 17        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Adverse Notification Letter with signed Certified Return Receipt | 055-16-00049 | 19       | Documents | BeenRenamed.txt | 18        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Police Report                                                    | 055-16-00049 | 24       | Documents | BeenRenamed.txt | 19        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Photographs, Maps, or Sketches                                   | 055-16-00049 | 18       | Documents | BeenRenamed.txt | 20        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs and Supporting Documents                           | 055-16-00049 | 20       | Documents | BeenRenamed.txt | 21        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Previous LODs Civilian Injury Medical Records                    | 055-16-00049 | 21       | Documents | BeenRenamed.txt | 22        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Follow-up Medical Documentation                                  | 055-16-00049 | 181      | Documents | BeenRenamed.txt | 23        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Medical Eligibility Verification (MMSO Form-01 and MMSO Form-02) | 055-16-00049 | 254      | Documents | BeenRenamed.txt | 24        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Medical Bills                                                    | 055-16-00049 | 297      | Documents | BeenRenamed.txt | 25        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Medical Release Forms                                            | 055-16-00049 | 379      | Documents | BeenRenamed.txt | 26        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Additional Documentation                                         | 055-16-00049 | 292      | Documents | BeenRenamed.txt | 27        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Appeal Determination Documentation                               | 055-16-00049 | 230      | Documents | BeenRenamed.txt | 28        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | DA Form 3349 - Medical Profile                                   | 055-16-00049 | 182      | Documents | BeenRenamed.txt | 29        | GonnaBeDeleted  | Police Report - Police Report |
        //	#| 88th RSC Admin | 8880070133 | Pre-Deployment Health Assessment                                 | 055-16-00049 | 65       | Documents | BeenRenamed.txt | 30        | GonnaBeDeleted  | Police Report - Police Report |


        //Scenario Outline:  LOD Documents Fail Editing Document that aren't MY LODS
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'Search LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "-- All --" in the "LOD Draft (AR)" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	Then there should be no Add links '<Origin Section Title>'

        //	Scenarios:
        //	| Role                 | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   |  RowNumber | FileDescription | Destination Section Title     |
        //	| AR Unit Investigator | 8880070125 | LOD Documentation(For Pre-Approved LOD)            | 055-16-00340 | 329      | Documents |  1         | GonnaBeDeleted  | Police Report - Police Report |
        //	| AR Unit Commander    | 8880070123 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00340 | 88       | Documents |  2         | GonnaBeDeleted  | Police Report - Police Report |
        //	| AR SARC              | 8880070121 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00340 | 88       | Documents |  2         | GonnaBeDeleted  | Police Report - Police Report |

        //Scenario Outline:  LOD Documents Set Sensitivity to Not Sensitive
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'My LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Origin Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //	And I change the Sensitivity to '<Sensitivity>'
        //	And I click save
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	Then Sensitivity should have a value of '<Sensitivity Value>'
        //	#AFter save, row should display lock icon. Rename or Edit should not appear. 

        //	Scenarios:
        //	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Sensitivity | Sensitivity Value |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | Sensitive.txt   | Sensitive   | 2                 |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | Sensitive.txt   | Sensitive   | 2                 |

        //Scenario Outline:  LOD Documents Set Sensitivity to Not Sensitive Should Fail
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'My LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Origin Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //	And I change the Sensitivity to '<Sensitivity>'
        //	And I click save
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	Then Sensitivity should not have a value of '<Sensitivity Value>'
        //	#AFter save, row should display lock icon. Rename or Edit should not appear. 

        //	Scenarios:
        //	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Sensitivity   | Sensitivity Value |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | Sensitive.txt   | Not Sensitive | 1                 |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | Sensitive.txt   | Not Sensitive | 2                 |


        //Scenario Outline:  LOD Documents Set Sensitivity to Sensitive
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'My LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Origin Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //	And I change the Sensitivity to '<Sensitivity>'
        //	And I click save
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	Then Sensitivity should have a value of '<Sensitivity Value>'
        //	#AFter save, row should display lock icon. Rename or Edit should not appear. 

        //	Scenarios:
        //	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Sensitivity   | Sensitivity Value |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | Sensitive.txt   | Not Sensitive | 0                 |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | Sensitive.txt   | Not Sensitive | 0                 |


        //Scenario Outline:  LOD Documents Set Sensitivity to Sensitive Should Fail
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'My LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Origin Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //	And I change the Sensitivity to '<Sensitivity>'
        //	And I click save
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	Then Sensitivity should not have a value of '<Sensitivity Value>'
        //	#AFter save, row should display lock icon. Rename or Edit should not appear. 

        //	Scenarios:
        //	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Sensitivity | Sensitivity Value |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | Sensitive.txt   | Sensitive   | 1                 |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | Sensitive.txt   | Sensitive   | 0                 |

        //Scenario Outline:  LOD Documents Set Sensitivity to Behavioral Health
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'My LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Origin Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //	And I change the Sensitivity to '<Sensitivity>'
        //	And I click save
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	Then Sensitivity should have a value of '<Sensitivity Value>'
        //	#AFter save, row should display lock icon. Rename or Edit should not appear. 

        //	Scenarios:
        //	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Sensitivity       | Sensitivity Value |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | Sensitive.txt   | Behavioral Health | 1                 |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | Sensitive.txt   | Behavioral Health | 1                 |

        //Scenario Outline:  LOD Documents Set Sensitivity to Behavioral Health Should Fail
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I have navigated to 'My LODs' tab in 'eMMPS'
        //	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID<Case ID>
        //	When I click the "Documents" Tab in "LOD"
        //	And click on the Add link of '<Origin Section Title>'
        //	And fill out the fields and upload a document<FileDescription>
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //	And I change the Sensitivity to '<Sensitivity>'
        //	And I click save
        //	And I click on the Edit Link of a document '<RowNumber>'
        //	Then Sensitivity should not have a value of '<Sensitivity Value>'
        //	#AFter save, row should display lock icon. Rename or Edit should not appear. 

        //	Scenarios:
        //	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Sensitivity       | Sensitivity Value |
        //	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | Sensitive.txt   | Behavioral Health | 0                 |
        //	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | Sensitive.txt   | Behavioral Health | 2                 |


        //#Scenario Outline:  LOD Documents Set Status to Approve this document
        //#	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //#	And I have navigated to 'My LODs' tab in 'eMMPS'
        //#	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID <Case ID>
        //#	When I click the "Documents" Tab in "LOD"
        //#	And click on the Add link of '<Origin Section Title>'
        //#	And fill out the fields and upload a document <FileDescription>
        //#	And I click on the Edit Link of a document '<RowNumber>'
        //#	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //#	And I change the Status  to '<Status>'
        //#	And I click save
        //#	And I click on the Edit Link of a document '<RowNumber>'
        //#	Then the Approved checkbox should have a value of '<Status>'
        //#
        //#	Scenarios:
        //#	| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Status       |
        //#	| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | GonnaBeApproved | Approved     |
        //#	| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | NotApproved     | Not Approved |



        //#Scenario Outline:  LOD Documents Activate No Date Unknown
        //#	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //#	And I have navigated to 'My LODs' tab in 'eMMPS'
        //#	And I search for a LOD in the workflow "AR Formal" in the "-- All --" status and select the Case-ID <Case ID>
        //#	When I click the "Documents" Tab in "LOD"
        //#	And click on the Add link of '<Origin Section Title>'
        //#	And fill out the fields and upload a document <FileDescription>
        //#	And I click on the Edit Link of a document '<RowNumber>'
        //#	#insert validation Logic in this ^^^^ step for the fields being displayed and formatted correctly #24-26
        //#	And I change the No Date Unknown checkbox to '<Status>'
        //#	And I click save
        //#	And I click on the Edit Link of a document '<RowNumber>'
        //#	Then the No Date Unknown checkbox checkbox should have a value of '<Status>'
        //#	And I clean up <docdivId>
        //#
        //#Scenarios:
        //#| Role           | PIN        | Origin Section Title                                | Case ID      | docdivId | TabName   | RowNumber | FileDescription | Status      |
        //#| 88th RSC Admin | 8880070133 | LOD Documentation (For Pre-Approved LOD)            | 055-16-00049 | 329      | Documents | 1         | GonnaBeApproved | Checked     |
        //#| 88th RSC Admin | 8880070133 | Hard Copy of Active DA Form 2173 and/or DD Form 261 | 055-16-00049 | 88       | Documents | 2         | NotApproved     | Not Checked |



        //Scenario Outline:  eMMPs Tab Shows Proper Sub Tabs
        //	Given I am Logged in as Role '<Role>' using EDIPIN <PIN>
        //	And I hover over the eMMPs tab
        //	Then the eMMPs '<Sub Tabs>' are displayed

        //	Scenarios:
        //	| Role       | PIN        | Sub Tabs                                                       |
        //	| Unit Admin | 8880070001 | LOD,INCAP,PDHRA,MMSO,ADOP,Reports,Management Tools, Help Manual |

    }
}
