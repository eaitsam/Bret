using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.EmmpsContent_Shared_Objects
{
    public class EMMPSCaseMenuNav
    {
        #region LOD Menu Links
        public By LODSoldierMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Soldier']");
        public By LODSoldierMenuLinkText => By.LinkText("Soldier");
        public By LODMedicalMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Medical']");
        public By LODMedicalMenuLinkButtonLinkText => By.LinkText("Medical");
        public By LODUnitMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Unit']");
        public By LODUnitMenuLinkButtonLinkText => By.LinkText("Unit");
        public By LODInvestigationMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Investigation']");
        public By LODInvestigationMenuLinkButtonLinkText => By.LinkText("Investigation");
        public By LODApptMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Appointment']");
        public By LODAptMenuLinkButtonLinkText => By.LinkText("Appointment");
        public By LODFormfindingsMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Form Findings']");
        public By LODFormfindingsMenuLinkButtonLinkText => By.LinkText("Form Findings");
        public By LODDocumentsMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Documents']");
        public By LODDocumentsMenuLinkButtonLinkText => By.LinkText("Documents");
        public By LODNextActionMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Next Action']");
        public By LODNextActionMenuLinkButtonLinkText => By.LinkText("Next Action");
        public By LODTrackingMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Tracking']");
        public By LODAdminMenuLinkButton => By.XPath("//a[contains(@class, 'ChLink') and text()='Admin']");
        public By LODAdminMenuLinkButtonLinkText => By.LinkText("Admin");
        public By LODAdminMenuLinkButtonFromDocs => By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODAdminMenuLinkButton");
        public By LODsEligibleForAppeals => By.Name("LODs Eligible For Appeals");
        public By MyLODsHeader => By.Name("My LODs");

        #endregion

        #region ADOP Menu Links
        public By ADOPSelectCaseLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPSelect CaseMenuLinkButton");
        public By ADOPSoldierLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPSoldierMenuLinkButton");
        public By ADOPForm4LinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPForm");
        public By ADOPBoardMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPBoardMenuLinkButton");
        public By ADOPOrdersMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPOrdersMenuLinkButton");
        public By ADOPAssociateMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPAssociateMenuLinkButton");
        public By ADOPDocumentsMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPDocumentsMenuLinkButton");
        public By ADOPNextActionMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPNext ActionMenuLinkButton");
        public By ADOPTrackingMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPTrackingMenuLinkButton");
        public By ADOPAdminMenuLinkButton = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPAdminMenuLinkButton");

        #endregion

        #region INCAP Menu Links
        public By INCAPSoldierMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Soldier']");
        public By INCAPSoldierMenuLinktext => By.LinkText("Soldier");

        public By INCAPFinancesMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Finances']");
        public By INCAPFinancesMenuLinktext => By.LinkText("Finances");

        public By INCAPCalcMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Calculator']");
        public By INCAPCalcMenuLinktext => By.LinkText("Calculator");

        public By INCAPExtMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Extentions']");
        public By INCAPExtMenuLinktext => By.LinkText("Extentions");

        public By INCAPDetailsMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Details']");
        public By INCAPDetailsMenuLinktext => By.LinkText("Details");

        public By INCAPDocsMenuLink => By.XPath("//a[contains(@class, 'ChLink') and text() = 'Documents']");
        public By INCAPDocsMenulinktext => By.LinkText("Documents");

        public By INCAPNextActionMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Next Action']");
        public By INCAPNextActionMenuLinktext => By.LinkText("Next Action");

        public By INCAPTrackingMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Tracking']");
        public By INCAPTrackingMenuLinktext => By.LinkText("Tracking");

        public By INCAPAdminMenuLink = By.XPath("//a[contains(@class, 'ChLink') and text() = 'Admin']");
        public By INCAPAdminMenuLinktext => By.LinkText("Admin");
        public By INCAPFinancesMenuLinkText => By.LinkText("Finances");
        public By INCAPCalculatorMenuLinkText => By.LinkText("Calculator");

        public By MyINCAPPageLink = By.Id("ReviewAndActOnMyINCAPsHyperLink");

        #endregion 
    }
}
