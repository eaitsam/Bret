using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Xunit;
using MedchartSeleniumAutomationCore.Core_Framework;

namespace FrameworkAutomation.PageObjectModel
{
    public class AuditLog
    {
        #region Page Objects

        #region By Elements
        public By ActionDropDownList => By.Id("MEDCHARTContent_MedchartPagesContent_ActionDropDownList");
        public By PaginationCombobox => By.Id("MEDCHARTContent_MedchartPagesContent_ucRowCount_ddlPageRows");
        public By SelectFirstAuditLogEntry => By.XPath("//a[contains(@href, 'Select$0')]");
        public By FirstActionAuditLogEntry => By.XPath("//table[@id='MEDCHARTContent_MedchartPagesContent_AuditLogListGridView']/tbody/tr[3]/td[1]");
        public By FirstDateAuditLogEntry => By.XPath("//table[@id='MEDCHARTContent_MedchartPagesContent_AuditLogListGridView']/tbody/tr[3]/td[3]");
        public By ActionHeaderSort => By.XPath("//a[contains(@href, 'Sort$ActionName')]");
        public By DateHeaderSort => By.XPath("//a[contains(@href, 'Sort$EntryTime')]");
        public By UserHeaderSort => By.XPath("//a[contains(@href, 'Sort$UserName')]");
        public By EDIPINHeaderSort => By.XPath("//a[contains(@href, 'Sort$UserEdi')]");
        public By TotalResultsCount => By.Id("MEDCHARTContent_MedchartPagesContent_TotalCountLabel");
        public By PageHeader => By.XPath("//table[@id='MEDCHARTContent_MedchartPagesContent_AuditLogListGridView']//tr[contains(@class, 'Pager')]");
        public readonly List<string> moduleList = new List<string>() { "AVS", "DenClass", "eCase", "eMMPS", "HRR", "MATS", "MRR", "OccHealth", "OHR" };

        public By FirstNameTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserFirstName");
        public By LastNameTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_UserLastName");
        public By EDIPITextBox => By.Id("MEDCHARTContent_MedchartPagesContent_EdiTextbox");
        public By SSNTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_SoldierSSNTextBox");
        public By OrganizationCombobox => By.Id("MEDCHARTContent_MedchartPagesContent_OrganizationDropDownList");
        public By ModuleCombobox => By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDropDownList");
        public By RegionCombobox => By.Id("MEDCHARTContent_MedchartPagesContent_RegionDropDownList");
        public By AuditLogActionCombobox => By.Id("MEDCHARTContent_MedchartPagesContent_ActionDropDownList");
        public By ViewSysAdminEventsCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_IncludeSysAdminEventsCheckBox");

        public By RangeToTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_RangeToTextbox");
        public By RangeFromTextBox => By.Id("MEDCHARTContent_MedchartPagesContent_RangeFromTextbox");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_SearchButton");
        public By ResetButton => By.Id("MEDCHARTContent_MedchartPagesContent_ResetButton");
        public By AuditLogGridView => By.Id("MEDCHARTContent_MedchartPagesContent_AuditLogListGridView");

        public By ResultsTable => By.Id("MEDCHARTContent_MedchartPagesContent_AuditLogListGridView");
        public By ResultsTableFirstRow => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[3]/div/div[2]/div/table/tbody/tr[3]");
        public By FirstSelectLink => By.LinkText("Select");
        public By AuditLogText => By.Id("jqDetailsLabel");
        public By DateText => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[3]/div/div[2]/div/table/tbody/tr[2]/td[3]");

        public By StandardErrorMessage => By.Id("errorFeedback");
        public By SSNErrorMessage => By.Id("MEDCHARTContent_MedchartPagesContent_FullSSNRequiredLabel");
        public By NoRecordErrorMessage => By.Id("MEDCHARTContent_MedchartPagesContent_AuditLogListGridView_noRecordFoundLabel");
        public By EDIPIErrorMessage => By.Id("MEDCHARTContent_MedchartPagesContent_FullSoldierEDIPIRequiredLabel");
        #endregion
        #region String/List Elements
        public string PaginationLinkPath => "//table[@id='MEDCHARTContent_MedchartPagesContent_AuditLogListGridView']//tr[1]//table//td";
        public By FrameworkActionCheckbox => By.Id("MEDCHARTContent_MedchartPagesContent_IncludeFrameworkActions");
        public List<string> IncludeAuditLogActionsAVSExpectedValues => new List<string> {"-All Actions -","Budget-Funds Requested"," HIPAA Certificate - Approved","HIPAA Certificate - Disapproved","HIPAA Certificate - Uploaded",
        "Soldier - Demographics Updated","User - Account Modified","User - Assigned Regions Modified",
          "User - Disallowed from module","User - Extended Permissions Changed", " User - Manage Command/UIC Access","User - Manage My Access","User - Organization Modified","User - Re-Allowed","User-Registered","User - Registration Approved","User - Role Modified","User - User Details Updated",
           "User Request Access","User Request Access Approved","User Request Access Disapproved" };
        public List<string> ExcludeAVSAuditLogActionsExpectedValues => new List<string> { "Budget – Funds Requested", "Service-Modified", "User- Manage My Access", "User – Manage Command/UIC Access" };
        public List<string> IncludeAuditLogActionsHRRExpectedValues => new List<string> {"Added  Soldiers to VA claims Request", " Annotate  Document", "Approve  Document","Approved  HAIMS Auto Generate STR",
         "Archive  Soldier",
         "BH  Audit Report - Export",
         "BHS  Class Change Report - Export",
         "BTG  for BHS Document Access",
         "Change  State",
         "Change  Status to Pending",
         "Copy  Document",
         "Create  BatchID",
         "Delete  Batch",
         "Delete  BatchID",
         "Delete  Document",
         "Delete  Document - Reindex page",
         "Delete  Page - Reindex page",
         "Disapproved  HAIMS Auto Generate STR",
         "Document  List - Export",
         "Download  composite from Retrieval",
         "Export  MEBPEB Outstanding Docs",
         "Exported  Auto STRs not validated",
         "Exported  Failed STRs due to batches",
         "Exported  HAIMS Auto Generate STR",
         "Exported  Patient Not Found Report",
         "Exported  Web API Report",
         "Full  STR downloaded",
         "Full  STR Requested",
         "Generate  Group PDF",
         "HAIMS  STR Requested",
         "HIPAA  Certificate - Approved",
         "HIPAA  Certificate - Disapproved",
         "HIPAA  Certificate - Uploaded",
         "ICDFavorite  - Added By User",
         "ICDFavorite  - Removed By User",
         "ICDFavorite  - Removed Over Max",
         "Index  Document - Reindex page",
         "Index  Document - ReOrg page",
         "Mark  Document Behavioral Health",
         "Mark  Document Sensitive",
         "MHA  Audit Log exported",
         "Modified  VA claims status",
         "Organize  Batches - Export",
         "Organize  Batches - Search",
         "Preview  Document MA",
         "Print  Document - ReIndex page",
         "Print  Document - ReOrg page",
         "Print  Page - ReIndex page",
         "Recycle  Document",
         "Selected  type STR Requested",
         "Separating  Soliders Report exported",
         "Soldier  - Demographics Updated",
         "STR  Validation Completed",

         "Unarchive  Soldier",
         "Unindex  Document",
         "Unmark  Document Behavioral Health",
         "Unmark  Document Sensitive",
         "Update  BatchID",
         "Update  Status",         "Upload  Document",
         "USAR  Generate Sep Soldier STR",
         "USAR  Process Sep Soldiers File",
         "USAR  Separating Soldiers Export",
         "USAR  Viewed Separating Soldiers",
         "User  - Account Modified",
         "User  - Assigned Regions Modified",
         "User  - Disallowed from module",
         "User  - Extended Permissions Changed",
         "User  - Organization Modified",
         "User  - Re-Allowed",
         "User  - Registered",
         "User  - Registration Approved",
         "User  - Role Modified",
         "User  - User Details Updated",
         "User  Request Access",
         "User  Report Access Approved",
         "User  Report Access Disapproved",
         "VA  claims status Report-Export",
         "Validate  Pending Document - Export",
         "Validate  Pending Document - Search",       "View  composite Retrieval Page",         "View  Document",        "View  Document BHS",         "View  Document PHI",       "View  Record Review",      "View  Soldier Info",    "View  STR History",
         "Viewed  MHA Audit Log",
         "Viewed  ARNG HRR HAIMS STR Report",
         "Viewed  Auto STRs not validated",
        "Viewed  Failed STRs due to batches",
         "Viewed  HAIMS Auto Generate STRs",
         "Viewed  Patient Not Found Report",
         "Viewed  Scanning and Usage Report",
         "Viewed  Separating Soliders Report",
         "Viewed  USAR HRR HAIMS STR Report",
         "Viewed  VA claims status Report",
         "Viewed  Web API Report",
        " VLR/SPO  STR Requested"};
        public List<string> AuditLogActionsMRRExpectedValues => new List<string> {"HIPAA Certificate - Approved",
         "HIPAA Certificate - Disapproved",
         "HIPAA Certificate - Uploaded",
         "ICDFavorite  - Added By User",
         "ICDFavorite  - Removed By User",
         "ICDFavorite  - Removed Over Max",
          "Soldier  - Demographics Updated",
         "User  - Account Modified",
         "User  - Assigned Regions Modified",
         "User  - Disallowed from module",
         "User  - Extended Permissions Changed",
         "User  - Organization Modified",
         "User  - Re-Allowed",
         "User  - Registered",
         "User  - Registration Approved",
         "User  - Role Modified",
         "User  - User Details Updated",
         "User Request Access",
         "User Report Access Approved",
         "User Report Access Disapproved", };
        public List<string> IncludeFrameworkAuditLogActionsMATSExpectedValues => new List<string> {"HIPAA Certificate - Approved",
         "HIPAA Certificate - Disapproved",
         "HIPAA Certificate - Uploaded",
         "ICDFavorite  - Added By User",
         "ICDFavorite  - Removed By User",
         "ICDFavorite  - Removed Over Max",
         "Soldier  - Demographics Updated",
         "MATS  – Appeal Action",
         "MATS  – Approve Action",
         "MATS  – Close Action",
         "MATS  – Create Action",
         "MATS  – Disapprove Action",
         "MATS  – Expert Consult",
         "MATS  – Generate Results Memo",
         "MATS  – Initial Review",
         "MATS  – Opened Action",
         "MATS  – Pending More Information",
         "MATS  – Return Action",
         "MATS  – Review Action",
         "MATS  – Reviewed and Approved",
         "MATS  – Save Action",
         "MATS  – Submit Action",
         "MATS  – Transfer Action",
         "MATS  – Transfer All Current",
         "MATS  – Transfer Future",
         "MATS  – View Composite",
         "User  - Account Modified",
         "User  - Assigned Regions Modified",
         "User  - Disallowed from module",
         "User  - Extended Permissions Changed",
         "User  - Organization Modified",
         "User  - Re-Allowed",
         "User  - Registered",
         "User  - Registration Approved",
         "User  - Role Modified",
         "User  - User Details Updated",
         "User Report Exported",
         "User Request Access",
         "User Report Access Approved",
         "User Report Access Disapproved" };
        public List<string> AuditLogActionsExpValues => new List<string> { "Budget-Funds Requested", "User-Manage Command/UIC Access", "User-Manage My Access", "User Request Access" };
        public List<string> AuditLogActionsOHRExpValues => new List<string> {"Approve Document",
         "BH Audit Report – Export",
         "BHS Class Change Report – Export",
         "BTG  for BHS Document Access",
         "Composite download",
         "Composite Request",
         "Create BatchID(scan)",
         "Delete Batch",
         "Delete Document",
         "Delete Document – Reindex page",
         "Delete Page – Reindex page",
         "Document List – Export",
         "Download composite from Retreval",
         "Index Document – Reindex page",
         "Index Document – ReOrg page",
         "Mark Document Behavioral Health",
         "Mark Document Sensitive",
         "Organize Batches – Export",
         "Organize Batches – Search",
         "Print Document – ReIndex page",
         "Print Document – ReOrg page",
         "Print Page – ReOrg page",
         "Recycle Document",
         "Transfer OHR record to another State",
         "Unmark Document Behavioral Health",
         "Unmark Document Sensitive",
         "Update Batch",
         "Upload Document",
         "Validate Pending Document – Export",
         "Validate Pending Document – Search",
         "View Composite History",
         "View composite Retrieval Page",
         "View Document",
         "View Document BHS",
         "View E, mployee Info",
         "View Record Review",
         "View/Search Employee Record",
         "Viewed Scanning and Usage Report" };
        public List<string> ExcludeAuditLogActionsOHRExpValues => new List<string> {" Budget",
         "Create New Exam Request",
         "Edit Health and Wellness",
         "Edit Hearing",
         "Edit Hearing Dosimetry",
         "Edit Musculoskeletal/Ergonomics",
         "Edit OWCP/Job Restrictions",
         "Edit Physical",
         "Edit Radiation",
         "Edit Respiratory/Spirometry",
         "Edit Vision",
         "Employee Demographics Updated",
         "Employee Hazard Profile Updated",
         "Employee Record Status Changed",
         "Exam Requests Approved",
         "Exam Requests Canceled",
         "Exam Requests Disapproved",
         "Exam Requests Edited",
         "New Employee Created(Manual)",
         "Non-FOH Exam Results",
         "Soldier  - Demographics Updated",
         "Transfer Funds",
         "View Health and Wellness",
         "View Hearing",
         "View Musculoskeletal/Ergonomics",
         "View OWCP/Job Restrictions",
         "View Physical",
         "View Radiation",
          "View Respiratory/Spirometry",
         "View Vision" };
        public List<string> ExcludeAuditLogActionsOccHealthExpValues => new List<string> {" Approve Document",
         "BH Audit Report – Export",
         "BHS Class Change Report – Export",
         "BTG  for BHS Document Access",
         "Composite download",
         "Composite Request",
         "Create BatchID(scan)",
         "Delete Batch",
         "Delete Document",
         "Delete Document – Reindex page",
         "Delete Page – Reindex page",
         "Document List – Export",
         "Download composite from Retreval",
         "Index Document – Reindex page",
         "Index Document – ReOrg page",
         "Mark Document Behavioral Health",
         "Mark Document Sensitive",
         "Organize Batches – Export",
         "Organize Batches – Search",
         "Print Document – ReIndex page",
         "Print Document – ReOrg page",
         "Print Page – ReOrg page",
         "Recycle Document",
         "Transfer OHR record to another State",
         "Unmark Document Behavioral Health",
         "Unmark Document Sensitive",
         "Update Batch",
         "Upload Document",
         "Validate Pending Document – Export",
         "Validate Pending Document – Search",
         "View Composite History",
         "View composite Retrieval Page",
         "View Document",
         "View Document BHS",
         "View Employee Info",
         "View Record Review",
         "View/Search Employee Record",
         "Viewed Scanning and Usage Report", };
        public List<string> ExcludeAuditLogActionsDNSExpValues => new List<string> {
        "2813  Uploaded from Xray Page",
         "Added SM to the Event",
         "AdminTask-Alter SoldierInfo",
         "AdminTask-CDS Audit",
         "AdminTask-CDS Error Log",
         "AdminTask-ConfigManagement",
         "AdminTask-Create AVSVoucher",
         "AdminTask-Alter Get EmailAddress",
         "AdminTask-ProcessAllSoldier",
         "AdminTask-SendEmail to Users",
         "AdminTask-SF603 Error Log",
         "AdminTask-Table Change Log",
         "Bitewings Viewed",
         "DD2813 Viewed",
         "Delete Images less than 24hr",
         "Delete Images more than 24hr",
         "Deleted SM from the Event",
         "Dental Workload Summary Exported",
         "Estimated Cost Report",
         "Event Summary Report",
         "Event Summary Report Exported",
         "Event Created",
         "Event-Group Created",
         "Event-Group Deleted",
         "Event-Group Modified",
         "Event Modified",
         "Event-Personnel Added",
         "Event-Personnel Modified",
         "Exported-Dental Readiness Report",
         "Exported-Estimated Cost Report",
         "Exported-Radiograph Report",
         "HQ(5570) Created",
         "HQ(5570) Uploaded",
         "HQ(5570) Viewed",
         "HQ Uploaded(5570) for Records",
         "PA Viewed",
         "Pano Viewed",
         "RHRP DRC3C Report Exported",
         "SenderProfileData",
         "SF-603  Report",
         "SF-603  Uploaded",
         "SF-603  Viewed",
         "SF603 Report Detail Viewed",
         "SF603 Report Exported",
         "SoldierDoc Page Viewed",
         "TP Approved After Modified",
         "TP Disapproved",
         "TP DRC Updated",
         "TP Modified After Approval",
        "TP Updated DRC Approved",
         "TP Viewed",
         "Treated Plan Approved",
         "Treated Plan Created",
         "Treated Plan Modified",
         "Updated eProfile Data",
         "Upload BW with Upload Radiograph",
         "Upload BW with Xray Upload Page",
         "Upload PA with Xray Upload Page",
         "Upload Pana with Upload Radiograph",
         "Upload Pana with Xray Upload Page",
         "Uploaded DD 2813 for DRC",
         "User Report Exported",
         "View-Upload X-ray Page Viewed",
         "Viewed-ADA Code Report",
         "Viewed-Audit Report",
         "Viewed-Class3 Details Report",
         "Viewed-Dental Demo Report",
         "Viewed-Dental Readiness Report",
         "Viewed-Dental Workload Summary",
         "Viewed-TP Report",
         "Viewed-Radiograph Report",
         "Viewed-Soldiers By Class By Month",
         "Viewed-Soldiers By Month",
          "Viewed-User Report" };
        public List<string> ExcludeAuditLogActionseCaseExpValues => new List<string>{"Case  - Created new(Auto)",
         "Case  - Created new(Manual)",
         "Case  - Reassigned",
         "Case  - Updated",
         "Case  - Viewed",
         "Case Diagnosis - LOD Status Changed",
         "Case Task - Created",
         "Case Task - Finished",
         "Case Task – Updated", };
        public List<string> ExcludeFrameworkAuditLogActionsMATSExpValues => new List<string>
        {"MATS  – Appeal Action",
         "MATS  – Approve Action",
         "MATS  – Close Action",
         "MATS  – Create Action",
         "MATS  – Disapprove Action",
         "MATS  – Expert Consult",
         "MATS  – Generate Results Memo",
         "MATS  – Initial Review",
         "MATS  – Opened Action",
         "MATS  – Pending More Information",
         "MATS  – Return Action",
         "MATS  – Review Action",
         "MATS  – Reviewed and Approved",
         "MATS  – Save Action",
         "MATS  – Submit Action",
         "MATS  – Transfer Action",
         "MATS  – Transfer All Current",
         "MATS  – Transfer Future",
         "MATS  – View Composite" };
        public List<string> ExcludeAuditLogActionseMMPSxpValues => new List<string>{" Added/Removed UICs",
         "Case Initiated",
         "Case Signed",
         "Case Updated",
         "Case Viewed",
         "Requested UICs" };
        public List<string> ExcludeAuditLogActionseHRRexpValues => new List<string>{"Added Soldiers to VA claims Request",
         "Annotate Document",
         "Approve Document",
         "Approved HAIMS Auto Generate STR",
         "Archive Soldier",
         "BH Audit Report - Export",
         "BHS Class Change Report - Export",
         "BTG  for BHS Document Access",
         "Change State",
         "Change Status to Pending",
         "Copy Document",
         "Create BatchID",
         "Delete Batch",
         "Delete BatchID",
         "Delete Document",
         "Delete Document - Reindex page",
         "Delete Page - Reindex page",
         "Disapproved HAIMS Auto Generate STR",
         "Document List - Export",
         "Download composite from Retrieval",
         "Export MEBPEB Outstanding Docs",
         "Exported Auto STRs not validated",
         "Exported Failed STRs due to batches",
         "Exported HAIMS Auto Generate STR",
         "Exported Patient Not Found Report",
         "Exported Web API Report",
         "Full STR downloaded",
         "Full STR Requested",
         "Generate Group PDF",
         "HAIMS STR Requested",
         "Index Document - Reindex page",
         "Index Document - ReOrg page",
         "Mark Document Behavioral Health",
         "Mark Document Sensitive",
         "MHA Audit Log exported",
         "Modified VA claims status",
         "Organize Batches - Export",
         "Organize Batches - Search",
         "Preview Document MA",
         "Print Document - ReIndex page",
         "Print Document - ReOrg page",
        "Print Page - ReIndex page",
         "Recycle Document",
         "Reset Failed HAIMS attempts",
         "Selected type STR Requested",
         "Separating Soliders Report exported",
         "STR Validation Completed",
         "Thumbnail",
         "Unarchive Soldier",
         "Unindex Document",
         "Unmark Document Behavioral Health",
         "Unmark Document Sensitive",
         "Update BatchID",
         "Update Status",
         "Upload Document",
         "USAR Generate Sep Soldier STR",
         "USAR Process Sep Soldiers File",
         "USAR Separating Soldiers Export",
         "USAR Viewed Separating Soldiers",
         "VA claims status Report-Export",
         "Validate Pending Document - Export",
         "Validate Pending Document - Search",
         "View composite Retrieval Page",
         "View Document",
         "View Document BHS",
         "View Document PHI",
         "View Record Review",
         "View Soldier Info",
        "View STR History",
         "Viewed MHA Audit Log",
         "Viewed ARNG HRR HAIMS STR Report",
         "Viewed Auto STRs not validated",
         "Viewed Failed STRs due to batches",
         "Viewed HAIMS Auto Generate STRs",
         "Viewed Patient Not Found Report",
         "Viewed Scanning and Usage Report",
         "Viewed Separating Soliders Report",
         "Viewed USAR HRR HAIMS STR Report",
         "Viewed VA claims status Report",
         "Viewed Web API Report", };
        public List<string> ExcludeLogActionComboboxMRRExpectedValues => new List<string> { "- All actions -" };
        public List<string> AVSOrganizationComboboxExpectedValues => new List<string> { "National Guard", "Army Reserve", "Contractors" };
        public List<string> AVSLogActionComboboxExpectedValues => new List<string> { "- All actions -", "Budget – Funds Requested", "HIPAA Certificate - Approved", "HIPAA Certificate - Disapproved", "HIPAA Certificate - Uploaded", "ICDFavorite - Added By User", "ICDFavorite - Removed By User", "ICDFavorite - Removed Over Max", "Soldier - Demographics Updated", "User - Account Modified", "User - Assigned Regions Modified", "User - Disallowed from module", "User - Extended Permissions Changed", "User - Re-Allowed", "User - Registered", "User - Registration Approved", "User - Role Modified", "User – Manage Command/UIC Access", "User – Manage My Access", "User – User Details Updated", "User Request Access", "User Request Access Approved", "User Request Access Disapproved" };
        public List<string> AVSNationalGuardRegionComboboxExpectedValues => new List<string> { "- All States -", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        public List<string> AVSArmyReserveRegionComboboxExpectedValues => new List<string> { "- All Commands -", "108th Tng Cmd (IET)", "1st MSC", "200th MP Cmd", "311th Theater Sig Cmd", "335th Theater Sig Cmd", "377th TSC", "3rd Med DSC", "412th TEC", "416th TEC", "63rd DIV(R)", "75th Tng Div", "76th Opns Rspn Cmd", "79th SSC", "7th Civil Spt Cmd", "807th Med DSC", "80th Tng Cmd (TASS)", "81st DIV(R)", "84th Tng Cmd (UR)", "85th USAR Spt Cmd (West)", "88th DIV(R)", "99th DIV(R)", "9th MSC", "AHRC", "AR Aviation Cmd", "AR Careers Div", "ARMEDCOM", "First Army Spt Cmd", "MIRC", "USACAPOC", "USAR Lgl Cmd", "USARC" };
        public List<string> AVSContractorsRegionComboboxExpectedValues => new List<string> { "- All Regions -", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };

        public List<string> eMMPSOrganizationComboboxExpectedValues => new List<string> { "National Guard", "Army Reserve", "Cross-Component", "DEMOB/WTU Cross-Component" };
        public List<string> eMMPSLogActionComboboxExpectedValues => new List<string> { "- All actions -", "Added/Removed UICs", "Case Initiated", "Case Signed", "Case Updated", "Case Viewed", "HIPAA Certificate - Approved", "HIPAA Certificate - Disapproved", "HIPAA Certificate - Uploaded", "ICDFavorite - Added By User", "ICDFavorite - Removed By User", "ICDFavorite - Removed Over Max", "Requested UICs", "Soldier - Demographics Updated", "User - Account Modified", "User - Assigned Regions Modified", "User - Disallowed from module", "User - Extended Permissions Changed", "User - Re-Allowed", "User - Registered", "User - Registration Approved", "User - Role Modified", "User – User Details Updated", "User Request Access", "User Request Access Approved", "User Request Access Disapproved" };
        public List<string> eMMPSNationalGuardRegionComboboxExpectedValues => new List<string> { "- All States -", "ARNG-HQ (eMMPS)", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        public List<string> eMMPSArmyReserveRegionComboboxExpectedValues => new List<string> { "- All Commands -", "USARC-HQ (eMMPS)", "108th Tng Cmd (IET)", "1st MSC", "200th MP Cmd", "311th Theater Sig Cmd", "335th Theater Sig Cmd", "377th TSC", "3rd Med DSC", "412th TEC", "416th TEC", "63rd DIV(R)", "75th Tng Div", "76th Opns Rspn Cmd", "79th SSC", "7th Civil Spt Cmd", "807th Med DSC", "80th Tng Cmd (TASS)", "81st DIV(R)", "84th Tng Cmd (UR)", "85th USAR Spt Cmd (West)", "88th DIV(R)", "99th DIV(R)", "9th MSC", "AHRC", "AR Aviation Cmd", "AR Careers Div", "ARMEDCOM", "First Army Spt Cmd", "MIRC", "USACAPOC", "USAR Lgl Cmd", "USARC" };
        public List<string> eMMPSCrossComponentRegionComboboxExpectedValues => new List<string> { "- All Commands -", "N/A (Not Applicable)" };
        public List<string> eMMPSDEMOBWTURegionComboboxExpectedValues => new List<string> { "- All Regions -", "Camp Atterbury, Indiana", "Camp Shelby, Mississippi", "Fort Belvoir, Virginia", "Fort Benning, Georgia", "Fort Bliss, Texas", "Fort Carson, Colorado", "Fort Dix, New Jersey", "Fort Gordon, Georgia", "Fort Hood, Texas", "Fort Irwin, California", "Fort Jackson, South Carolina", "Fort Knox, Kentucky", "Fort Lewis, Washington", "Fort Polk, Louisiana", "Fort Riley, Kansas", "Fort Sam Houston (32nd MED BDE)", "Fort Sam Houston (BAMC WTB)", "Fort Sam Houston (Provisional BDE)", "Walter Reed, Maryland", "Puerto Rico CCU", "TRADOC - Fort Benning, Georgia", "TRADOC - Fort Jackson, South Carolina", "TRADOC - Fort Leonard Wood, Missouri", "TRADOC - Fort Sill, Oklahoma", "TRADOC - Fort Lee, Virginia", "TRADOC - Fort Eustis, Virginia", "TRADOC - Fort Gordon, Georgia", "TRADOC - Fort Huachuca, Arizona", "TRADOC - Fort Rucker, Alabama", "TRADOC - DFLIC, California", "TRADOC - Fort Sam Houston, Texas", "TRADOC - Camp Robinson, Arkansas" };

        public List<string> DenClassOrganizationComboboxExpectedValues => new List<string> { "National Guard", "Army Reserve", "Contractors" };
        public List<string> DenClassLogActionComboboxExpectedValues => new List<string> { "- All actions -", "2813 Uploaded from Xray Page", "Added SM to the Event", "AdminTask-Alter SoldierInfo", "AdminTask-CDA Audit", "AdminTask-CDA Error Log", "AdminTask-ConfigManagement", "AdminTask-Create AVSVoucher", "AdminTask-Get EmailAddress", "AdminTask-MedPros UpdateLog", "AdminTask-ProcessAllSoldier", "AdminTask-SendEmail to Users", "AdminTask-SF603 Error Log", "AdminTask-Table Change Log", "Bitewings Viewed", "DD2813 Viewed", "Delete Images less than 24hr", "Delete Images more than 24hr", "Deleted SM from the Event", "Dental Workload Summary Exported", "Estimated Cost Report", "Event Summary Report", "Event Summary Report Exported", "Event-Created", "Event-Group Created", "Event-Group Deleted", "Event-Group Modfied", "Event-Modified", "Event-Personnel Added", "Event-Personnel Modified", "Exported-Dental Readiness Report", "Exported-Estimated Cost Report", "Exported-Radiograph Report", "Exported-Readiness by Task Force", "HIPAA Certificate - Approved", "HIPAA Certificate - Disapproved", "HIPAA Certificate - Uploaded", "HQ (5570) Created", "HQ (5570) Uploaded", "HQ (5570) Viewed", "HQ Uploaded(5570) for Records", "ICDFavorite - Added By User", "ICDFavorite - Removed By User", "ICDFavorite - Removed Over Max", "PA Viewed", "Pano Viewed", "RHRP DRC3C Report Exported", "SendeProfileData", "SF-603 Report", "SF-603 Uploaded", "SF-603 Viewed", "SF603 Report Detail Viewed", "SF603 Report Exported", "Soldier - Demographics Updated", "SoldierDoc Page Viewed", "TP Approved After Modified", "TP Disapproved", "TP DRC Updated", "TP Modified After Approval", "TP Updated DRC Approved", "TP Viewed", "Treatment Plan Approved", "Treatment Plan Created", "Treatment Plan Modified", "UpdateeProfileData", "Upload BW with Upload Radiograph", "Upload BW with Xray Upload Page", "Upload PA with Xray Upload Page", "Upload Pano with Upload Radiograph", "Upload Pano with Xray Upload Page", "Uploaded DD 2813 for DRC", "User - Account Modified", "User - Assigned Regions Modified", "User - Disallowed from module", "User - Extended Permissions Changed", "User - Re-Allowed", "User - Registered", "User - Registration Approved", "User - Role Modified", "User – User Details Updated", "User Report Exported", "User Request Access", "User Request Access Approved", "User Request Access Disapproved", "View-Upload X-ray Page Viewed", "Viewed-ADA Code Report", "Viewed-Audit Report", "Viewed-Class3 Details Report", "Viewed-Dental Demo Report", "Viewed-Dental Readiness Report", "Viewed-Dental Workload Summary", "Viewed-Pending TP Report", "Viewed-Radiograph Report", "Viewed-Readiness By Task Force", "Viewed-Soldiers By Class By Month", "Viewed-Soldiers By Month", "Viewed-User Report" };
        public List<string> DenClassNationalGuardRegionComboboxExpectedValues => new List<string> { "- All States -", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        public List<string> DenClassArmyReserveRegionComboboxExpectedValues => new List<string> { "- All Commands -", "USARC" };
        public List<string> DenClassContractorsRegionComboboxExpectedValues => new List<string> { "- All Regions -", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming", };

        public List<string> eCaseOrganizationComboboxExpectedValues => new List<string> { "National Guard", "Army Reserve" };
        public List<string> eCaseLogActionComboboxExpectedValues => new List<string> { "- All actions -", "Case - Created new (Auto)", "Case - Created new (Manual)", "Case - Reassigned", "Case - Updated", "Case - Viewed", "Case Diagnosis - LOD Status Changed", "Case Task - Created", "Case Task - Finished", "Case Task - Updated", "HIPAA Certificate - Approved", "HIPAA Certificate - Disapproved", "HIPAA Certificate - Uploaded", "ICDFavorite - Added By User", "ICDFavorite - Removed By User", "ICDFavorite - Removed Over Max", "Soldier - Demographics Updated", "User - Account Modified", "User - Assigned Regions Modified", "User - Disallowed from module", "User - Extended Permissions Changed", "User - Re-Allowed", "User - Registered", "User - Registration Approved", "User - Role Modified", "User – User Details Updated", "User Request Access", "User Request Access Approved", "User Request Access Disapproved" };
        public List<string> eCaseNationalGuardRegionComboboxExpectedValues => new List<string> { "- All States -", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Title 10 (eCase ONLY)", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        public List<string> eCaseArmyReserveRegionComboboxExpectedValues => new List<string> { "- All Commands -", "63 HSB", "81 HSB", "88 HSB", "99 HSB", "Admin", "AGR Team", "Auditors", "BHP", "Intake", "MAR2", "MEB", "OFTS", "Other", "PEB", "RCC", "T-Profile", "Team 1 (Retired)", "Team 2 (Retired)", "Team 3 (Retired)", "Team 4 (Retired)", "Team 5 (Retired)", "USARC A", "USARC HSB", "USARC P" };

        public List<string> OHOrganizationComboboxExpectedValues => new List<string> { "National Guard" };
        public List<string> OHLogActionComboboxExpectedValues => new List<string> { "- All actions -", "Budget", "Create New Exam Request", "Edit Health and Wellness", "Edit Hearing", "Edit Hearing Dosimetry", "Edit Musculoskeletal/Ergonomics", "Edit OWCP/Job Restrictions", "Edit Physical", "Edit Radiation", "Edit Respiratory/Spirometry", "Edit Vision", "Employee Demographics Updated", "Employee Hazard Profile Updated", "Employee Record Status Changed", "Exam Requests Approved", "Exam Requests Canceled", "Exam Requests Disapproved", "Exam Requests Edited", "HIPAA Certificate - Approved", "HIPAA Certificate - Disapproved", "HIPAA Certificate - Uploaded", "ICDFavorite - Added By User", "ICDFavorite - Removed By User", "ICDFavorite - Removed Over Max", "New Employee Created (Manual)", "Non-FOH Exam Results", "Soldier - Demographics Updated", "Transfer Funds", "User - Account Modified", "User - Assigned Regions Modified", "User - Disallowed from module", "User - Extended Permissions Changed", "User - Re-Allowed", "User - Registered", "User - Registration Approved", "User - Role Modified", "User – User Details Updated", "User Request Access", "User Request Access Approved", "User Request Access Disapproved", "View Health and Wellness", "View Hearing", "View Musculoskeletal/Ergonomics", "View OWCP/Job Restrictions", "View Physical", "View Radiation", "View Respiratory/Spirometry", "View Vision" };
        public List<string> OHNationalGuardRegionComboboxExpectedValues => new List<string> { "- All States -", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        #endregion

        #endregion

        #region Page Methods
        public void SearchByAUser(string searchvalue, string field)
        {
            switch (field)
            {
                case "Log Type Field":
                    {
                        UIActions.SelectElementByText(AuditLogActionCombobox, searchvalue);
                        break;
                    }
                case "First Name Field":
                    {
                        UIActions.JSEnterText(FirstNameTextBox, searchvalue);
                        break;
                    }
                case "Last Name Field":
                    {
                        UIActions.JSEnterText(LastNameTextBox, searchvalue);
                        break;
                    }
                case "SSN Field":
                    {
                        UIActions.JSEnterText(SSNTextBox, searchvalue);
                        break;
                    }
                case "EDIPIN Field":
                    {
                        UIActions.JSEnterText(EDIPITextBox, searchvalue);
                        break;
                    }
                case "Region Field":
                    {
                        UIActions.SelectElementByText(RegionCombobox, searchvalue);
                        break;
                    }
                default:
                    throw new Exception("Unknown field name: " + field);
            }
        }

        public void InvalidSearchMethod(string invalidvaluetype, string invalidvalue, string error)
        {
            switch (invalidvaluetype)
            {
                case "Invalid Date Range":
                    {
                        switch (error)
                        {
                            case "Future Date":
                                {
                                    DateTime today = DateTime.Now;
                                    today = today.AddDays(5);
                                    UIActions.JSEnterText(RangeFromTextBox, today.ToString("yyyy-MM-dd hh:mm"));
                                    break;
                                }
                            case "Past Date":
                                {
                                    UIActions.JSEnterText(RangeFromTextBox, "2019-01-02 00:00");
                                    UIActions.JSEnterText(RangeToTextBox, "2019-01-01 00:00");
                                    break;
                                }
                            default:
                                throw new Exception("Unknown error name: " + error);
                        }
                        break;
                    }
                case "Invalid SSN":
                    {
                        switch (error)
                        {
                            case "Incorrect SSN Character Count":
                                {
                                    UIActions.JSEnterText(SSNTextBox, "123");
                                    break;
                                }
                            case "Alphanumeric SSN":
                                {
                                    UIActions.JSEnterText(SSNTextBox, "abc");
                                    break;
                                }
                            default:
                                throw new Exception("Unknown error name: " + error);
                        }
                        break;
                    }
                case "Recordless Region":
                    {
                        UIActions.JSEnterText(RangeFromTextBox, DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
                        UIActions.SelectElementByText(RegionCombobox, "Rhode Island");
                        break;
                    }
                case "Invalid EDIPIN":
                    {
                        switch (error)
                        {
                            case "Invalid EDIPIN Character Count":
                                {
                                    UIActions.JSEnterText(EDIPITextBox, "123");
                                    break;
                                }
                            case "Alphanumeric EDIPIN":
                                {
                                    UIActions.JSEnterText(EDIPITextBox, "abc");
                                    break;
                                }
                            default:
                                throw new Exception("Unknown error name: " + error);
                        }
                        break;
                    }

                default:
                    throw new Exception("Unknown value type name: " + invalidvaluetype);
            }
        }

        public void SortResults(string sorttype)
        {
            switch (sorttype)
            {
                case "Action":
                    {
                        UIActions.ClickElement(ActionHeaderSort);
                        break;
                    }
                case "User":
                    {
                        UIActions.ClickElement(UserHeaderSort);
                        break;
                    }
                case "EDIPIN":
                    {
                        UIActions.ClickElement(EDIPINHeaderSort);
                        break;
                    }
                case "Date":
                    {
                        UIActions.ClickElement(DateHeaderSort);
                        break;
                    }
                default:
                    throw new Exception("Unknown sort type: " + sorttype);
            }
        }

        #endregion

        #region Page Validations

        public void CheckDisplayedResults(string sortLink)
        {
            int row = 3;
            int col = 0;

            switch (sortLink)
            {
                case "Action":
                    col = 1;
                    break;
                case "Date":
                    col = 3;
                    break;
                case "User":
                    col = 4;
                    break;
                case "EDIPIN":
                    col = 5;
                    break;
                default:
                    throw new Exception("Unknown sort link: " + sortLink);
            }

            string columnLocator = "//table[@id='MEDCHARTContent_MedchartPagesContent_AuditLogListGridView']/tbody/tr[" + row + "]/td[" + col + "]";
            string firstTest = UIActions.GetElement(By.XPath(columnLocator)).Text;

            DateTime firstTestDate = new DateTime();
            DateTime secondTestDate = new DateTime();

            int numRows = UIActions.GetNumberOfElements(By.XPath("//table[@id='MEDCHARTContent_MedchartPagesContent_AuditLogListGridView']/tbody/tr"));

            while (++row < numRows)
            {
                columnLocator = "//table[@id='MEDCHARTContent_MedchartPagesContent_AuditLogListGridView']/tbody/tr[" + row + "]/td[" + col + "]";
                string secondTest = UIActions.GetElement(By.XPath(columnLocator)).Text;
                if (sortLink == "Date")
                {
                    firstTestDate = Convert.ToDateTime(firstTest);
                    secondTestDate = Convert.ToDateTime(secondTest);
                    Assert.True(firstTestDate <= secondTestDate);
                }
                else
                {
                    Assert.True(firstTest.CompareTo(secondTest) <= 0);
                }
                firstTest = secondTest;
            }
        }

        public void AVSFilterValidation(string orgname)
        {
            UIActions.SelectElementByText(OrganizationCombobox, orgname);

            Assert.True(UIActions.ComboboxInnerTextValidator(OrganizationCombobox, AVSOrganizationComboboxExpectedValues));
            Assert.True(UIActions.ComboboxContainsValue(ModuleCombobox, "AVS"));
            Assert.True(UIActions.ComboboxInnerTextValidator(AuditLogActionCombobox, AVSLogActionComboboxExpectedValues));

            List<string> regionCombobox = new List<string>();

            switch (orgname)
            {
                case "National Guard":
                    regionCombobox = AVSNationalGuardRegionComboboxExpectedValues;
                    break;
                case "Army Reserve":
                    regionCombobox = AVSArmyReserveRegionComboboxExpectedValues;
                    break;
                case "Contractors":
                    regionCombobox = AVSContractorsRegionComboboxExpectedValues;
                    break;
                default:
                    throw new Exception("Unknown organization name: " + orgname);
            }
            Assert.True(UIActions.ComboboxInnerTextValidator(RegionCombobox, regionCombobox));
        }

        public void DenClassFilterValidation(string orgname)
        {
            UIActions.SelectElementByText(OrganizationCombobox, orgname);

            Assert.True(UIActions.ComboboxInnerTextValidator(OrganizationCombobox, DenClassOrganizationComboboxExpectedValues));
            Assert.True(UIActions.ComboboxContainsValue(ModuleCombobox, "DenClass"));
            Assert.True(UIActions.ComboboxInnerTextValidator(AuditLogActionCombobox, DenClassLogActionComboboxExpectedValues));

            List<string> regionCombobox = new List<string>();

            switch (orgname)
            {
                case "National Guard":
                    regionCombobox = DenClassNationalGuardRegionComboboxExpectedValues;
                    break;
                case "Army Reserve":
                    regionCombobox = DenClassArmyReserveRegionComboboxExpectedValues;
                    break;
                case "Contractors":
                    regionCombobox = DenClassContractorsRegionComboboxExpectedValues;
                    break;
                default:
                    throw new Exception("Unknown organization name: " + orgname);
            }
            Assert.True(UIActions.ComboboxInnerTextValidator(RegionCombobox, regionCombobox));
        }

        public void eCaseFilterValidation(string orgname)
        {
            UIActions.SelectElementByText(OrganizationCombobox, orgname);

            Assert.True(UIActions.ComboboxInnerTextValidator(OrganizationCombobox, eCaseOrganizationComboboxExpectedValues));
            Assert.True(UIActions.ComboboxContainsValue(ModuleCombobox, "eCase"));
            Assert.True(UIActions.ComboboxInnerTextValidator(AuditLogActionCombobox, eCaseLogActionComboboxExpectedValues));

            List<string> regionCombobox = new List<string>();

            switch (orgname)
            {
                case "National Guard":
                    regionCombobox = eCaseNationalGuardRegionComboboxExpectedValues;
                    break;
                case "Army Reserve":
                    regionCombobox = eCaseArmyReserveRegionComboboxExpectedValues;
                    break;
                default:
                    throw new Exception("Unknown organization name: " + orgname);
            }
            Assert.True(UIActions.ComboboxInnerTextValidator(RegionCombobox, regionCombobox));
        }

        public void eMMPSFilterValidation(string orgname)
        {
            UIActions.SelectElementByText(OrganizationCombobox, orgname);

            Assert.True(UIActions.ComboboxInnerTextValidator(OrganizationCombobox, eMMPSOrganizationComboboxExpectedValues));
            Assert.True(UIActions.ComboboxContainsValue(ModuleCombobox, "eMMPS"));
            Assert.True(UIActions.ComboboxInnerTextValidator(AuditLogActionCombobox, eMMPSLogActionComboboxExpectedValues));

            List<string> regionCombobox = new List<string>();

            switch (orgname)
            {
                case "National Guard":
                    regionCombobox = eMMPSNationalGuardRegionComboboxExpectedValues;
                    break;
                case "Army Reserve":
                    regionCombobox = eMMPSArmyReserveRegionComboboxExpectedValues;
                    break;
                case "Cross-Component":
                    regionCombobox = eMMPSCrossComponentRegionComboboxExpectedValues;
                    break;
                case "DEMOB/WTU Cross-Component":
                    regionCombobox = eMMPSDEMOBWTURegionComboboxExpectedValues;
                    break;
                default:
                    throw new Exception("Unknown organization name: " + orgname);
            }
            Assert.True(UIActions.ComboboxInnerTextValidator(RegionCombobox, regionCombobox));
        }

        public void OHFilterValidation(string orgname)
        {
            UIActions.SelectElementByText(OrganizationCombobox, orgname);

            Assert.True(UIActions.ComboboxInnerTextValidator(OrganizationCombobox, OHOrganizationComboboxExpectedValues));
            Assert.True(UIActions.ComboboxContainsValue(ModuleCombobox, "OccHealth"));
            Assert.True(UIActions.ComboboxInnerTextValidator(AuditLogActionCombobox, OHLogActionComboboxExpectedValues));

            List<string> regionCombobox = new List<string>();

            switch (orgname)
            {
                case "National Guard":
                    regionCombobox = OHNationalGuardRegionComboboxExpectedValues;
                    break;
                default:
                    throw new Exception("Unknown organization name: " + orgname);
            }
            Assert.True(UIActions.ComboboxInnerTextValidator(RegionCombobox, regionCombobox));
        }


        public void IncludeframeworkActionCheckboxvalidation(string moduleName)
        {
            UIActions.SelectElementByText(ModuleCombobox, moduleName);
            List<string> Framewokaction = new List<string>();

            switch (moduleName)
            {
                case "AVS":
                    Framewokaction = IncludeAuditLogActionsAVSExpectedValues;
                    break;
                case "DenClass":
                    Framewokaction = DenClassLogActionComboboxExpectedValues;
                    break;
                case "eCase":
                    Framewokaction = eCaseLogActionComboboxExpectedValues;
                    break;
                case "eMMPS":
                    Framewokaction = eMMPSLogActionComboboxExpectedValues;
                    break;
                case "HRR":
                    Framewokaction = IncludeAuditLogActionsHRRExpectedValues;
                    break;
                case "MATS":
                    Framewokaction = IncludeFrameworkAuditLogActionsMATSExpectedValues;
                    break;
                case "MRR":
                    Framewokaction = AuditLogActionsMRRExpectedValues;
                    break;
                case "OccHealth":
                    Framewokaction = OHLogActionComboboxExpectedValues;
                    break;
                case "OHR":
                    Framewokaction = AuditLogActionsOHRExpValues;
                    break;


            }
           
            UIActions.ComboboxInnerTextValidator(AuditLogActionCombobox, Framewokaction);
        }
        public void IncludeframeworkActionUnCheckboxvalidation(string moduleName)
        {
            UIActions.SelectElementByText(ModuleCombobox, moduleName);
            List<string> Framewokaction = new List<string>();

            switch (moduleName)
            {
                case "AVS":
                    Framewokaction = ExcludeAVSAuditLogActionsExpectedValues;
                    break;
                case "DenClass":
                    Framewokaction = ExcludeAuditLogActionsDNSExpValues;
                    break;
                case "eCase":
                    Framewokaction = ExcludeAuditLogActionseCaseExpValues;
                    break;
                case "eMMPS":
                    Framewokaction = ExcludeAuditLogActionseMMPSxpValues;
                    break;
                case "HRR":
                    Framewokaction = ExcludeAuditLogActionseHRRexpValues;
                    break;
                case "MATS":
                    Framewokaction = ExcludeFrameworkAuditLogActionsMATSExpValues;
                    break;
                case "MRR":
                    Framewokaction = ExcludeLogActionComboboxMRRExpectedValues;
                    break;
                case "OccHealth":
                    Framewokaction = ExcludeAuditLogActionsOccHealthExpValues;
                    break;
                case "OHR":
                    Framewokaction = ExcludeAuditLogActionsOHRExpValues;
                    break;


            }
            UIActions.ComboboxInnerTextValidator(AuditLogActionCombobox, Framewokaction);

        }
    }
}
#endregion

