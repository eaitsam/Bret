using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.PageObjectModel
{
    public class AllUsersManagementPage
    {
        #region PageObjects
        public By ModuleDropdown => By.Id("MEDCHARTContent_MedchartPagesContent_ModuleDropDownList");
        public By RegionDropdown => By.Id("MEDCHARTContent_MedchartPagesContent_RegionDropDownList");
        public By AllowedButton => By.XPath("//*[@id='MEDCHARTContent_MedchartPagesContent_RoleStatusCheckBoxList']/span[1]/label");
        public By PendingButton => By.XPath("//*[@id='MEDCHARTContent_MedchartPagesContent_RoleStatusCheckBoxList']/span[2]/label");
        public By DisAllowedButton => By.XPath("//*[@id='MEDCHARTContent_MedchartPagesContent_RoleStatusCheckBoxList']/span[3]/label");
        public By ExpiredButton => By.XPath("//*[@id='MEDCHARTContent_MedchartPagesContent_RoleStatusCheckBoxList']/span[4]/label");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_StartSearch");
        public By SelectLink => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[4]/div[2]/div/table/tbody/tr[3]/td[9]/a");
        public List<string> ModuleList => new List<string> { "AVS", "DenClass", "eCase", "eMMPS", "HRR", "MATS", "MATS-ACRC", "MRR", "OccHealth" };
        public List<string> StateList => new List<string> { "- All States -", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Title 10 (eCase ONLY)", "Utah", "Vermont", "Virgin Islands", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
        public string Role = "eCase ARNG ManagerThis role is for the eCase system owner for ARNG. Its primary purpose is to approve the ARNG users and to perform management functions.Administrative SupportThe Admin Support (Admin SPT) role is most suited for Contracted Medical Administrative Assistants, Patient Administration Officers, Military Medical Administration Clerks, and Military Personnel Administrative Clerks.AuditorThe Auditor role is a read-only role.DSSThis role is reserved for the designated Deputy State Surgeon of your state. This role can only be approved by an eCase ARNG Manager.Lead MCMThe Lead Medical Case Manager (Lead CM) role is most suited to Military Nurse Case Managers, Military Social Workers, Contracted Civilian Nurse Case Managers, and Contracted Civilian Social Workers, that are in a management or leadership role for case management activities.Medical Case ManagerThe Case Manager (CM) role is most suited to Military Nurse Case Managers, Military Social Workers, Contracted Civilian Nurse Case Managers, and Contracted Civilian Social Workers.Medical Readiness NCOThe MRNCO role is most suited for BN/ BDE Medical Readiness NCOs, MED DET Commanders, MED DET ADOS/AGR Support, and Unit Readiness/Training NCOs.NGB BHOThis role is exclusively reserved for the designated NGB Behavioral Health Officer(s) and/or alternate(s). Users can only be elevated to this role by the eCase ARNG Manager, MEDCHART System Administrator or the MEDCHART ARNG Manager.ProviderThe Provider role is most suited for State Surgeons, Military Medical Providers (MD/DO), Contracted Civilian Medical Providers (MD/DO), Physician Assistants, and Nurse Practitioners.State BHO ReportingThis role is reserved for State Behavioral Health Officers exclusively for the entry of BH survey report data. There is no Case Management capabilities provided with this role.Unit AdministratorThe UANCO role is most suited for Military Medical Administrative Clerks, MED-DET ADOS/AGR Support, and Unit Readiness/Training NCOs.";
        public By OpenPermissionButton => By.Id("btnPerm");
        
        #endregion
    }
}
