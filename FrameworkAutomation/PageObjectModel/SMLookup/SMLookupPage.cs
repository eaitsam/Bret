using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using Xunit;

namespace FrameworkAutomation.PageObjectModel
{
    public class SMLookupPage
    {
        #region Page Objects

        #region By Elements

        public By ContactInformationTitle => By.XPath("//*[.='Contact Information']");
        public By EditSoldierDemographicsPanel => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMDemographicsFormPanel");
        public By LookupSMResultTable => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierSearch_SearchSoldierGridView");
        public By LookupSMResultTableHeader => By.XPath("//table[@id='MEDCHARTContent_MedchartPagesContent_ucSoldierSearch_SearchSoldierGridView']//tr[@class='MedchartGrid-ColHeader']");
        public By MedchartTable => By.XPath("//table[contains(@id, 'GridView')]");
        public By NoResultsFound => By.XPath("//*[contains(text(), 'No Record(s) Found')]");
        public By PermissionAmendmentsDiv => By.XPath("//div[contains(@id, 'PermissionAmendmentsTabContainer_body')]");
        public By FirstUserSelectLink => By.XPath("//a[contains(@href, 'Select$0')]");
        public By SoldierDemographicEditableFields => By.XPath("//div[contains(@class, 'SoldierDemographics')]//*[local-name()='input' or local-name()='select']");
        public By SoldierDemographicInfoPanel => By.XPath("//div[@id='MEDCHARTContent_MedchartPagesContent_SMSearchUpdatePanel']/following-sibling::div//div[contains(@id, 'ui-id')][1]");
        public By SoldierDemographicTitle => By.XPath("//div[@id='MEDCHARTContent_MedchartPagesContent_SMSearchUpdatePanel']/following-sibling::div//h3[contains(@id, 'ui-id')][1]");
        public By UserDetailsPageTitle => By.XPath("//div[contains(text(), 'User Details')]");
        public By SoldierDemographicExtendedInfo => By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_ExtendedDetails");
        public By SoldierDemoContactInfoCloseButton => (By.XPath("/html/body/div[4]/div[1]/button"));
        public By SoldierDemoContactInfoOKButton => (By.XPath("/html/body/div[4]/div[3]/div/button"));
        public By SoldiersExtendedContactInfoLink => (By.Id("MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_ExtendedDetails"));

        //Extended Soldier Contact Info Modal
        public By ExtInfoContactInfoHeading => By.XPath("//*[@id=\"MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMExtendedDetailsPanels\"]/div[2]/h4");
        public By ExtInfoTAPDBHeading => By.XPath("/*[@id=\"MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMExtendedDetailsPanels\"]/div[1]/h4");
        public By ExtInfoMailAddress1Heading => By.XPath("//*[@id=\"MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMExtendedDetailsPanels\"]/div[2]/table[2]/tbody/tr[1]/td[1]");
        public By ExtInfoMailAddress2Heading => By.XPath("//*[@id=\"MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMExtendedDetailsPanels\"]/div[2]/table[2]/tbody/tr[1]/td[2]");

        public By EditableFieldsDisclaimerText => By.XPath("//*[@id=\"MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMExtendedDetailsPanels\"]/div[2]/div");
        public By ItalicSoldierDataTAPDBText => By.XPath("//*[@id=\"MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMExtendedDetailsPanels\"]/div[1]/table/tbody/tr[1]/td");

        #endregion By Elements

        #region String/List Elements

        public string SoldierDemoExtContactInfoSMDisclaimer = "This information has been provided by other MEDCHART users. If the SM does not have an existing record within MEDCHART, or you do not have the Edit Soldier Demographic Data permission, these fields will not be editable.";
        public string SoldierDemoExtTAPDBDisclaimer = "You cannot modify the following Soldier information.If the values are incorrect, please contact your military service administrator.";


        public string ButtonXPath = "//a[contains(text(), '{0}')] | //button[contains(text(), '{0}')]";
        public string EditSoldierDemographicHeadingXPath = "//div[@id='MEDCHARTContent_MedchartPagesContent_ucSoldierInfo_SMDemographicsFormPanel']//*[contains(text(), '{0}')]";
        public string LookupSMDropdownXPath = "//select[contains(@name, '${0}')]";
        public string LookupSMResultTableHeaderXPath = "//tr[@class='MedchartGrid-ColHeader']";
        public string LookupSMResultTableResultColXPath = "//tr[contains(@class, 'Row')]/td[{0}]";
        public string LookupSMTextboxXPath = "(//input[@type='text'][contains(@name, '${0}')])[1]";
        public string ModuleTabXPath = "//div[@id='MEDCHARTContent_MedchartPagesContent_ModulesTabContainer_header']/span[.='{0}']";
        public string PermissionsCheckboxXPath = "//div[normalize-space(.)='{0}']/preceding-sibling::div//input";
        public string PermissionsTabXPath = "//div[contains(@id, 'PermissionAmendmentsTabContainer_header')]//span[contains(text(), '{0}')]";
        public string RoleAndResponsibilitiesRegionXPath = "//table[contains(@id, '{0}RoleCheckBoxDataList')]";
        public string WarningMessageXPath = "//td[contains(text(), '{0}')]";



        #endregion String/List Elements

        #endregion Page Objects

        #region Page Methods

        public void CheckPermissionsRoleCheckbox(string role, string module)
        {
            IWebElement amendmentRegion = UIActions.GetElement(PermissionAmendmentsDiv);
            IWebElement checkbox = UIActions.GetElement(By.XPath(String.Format(RoleAndResponsibilitiesRegionXPath, module.ToLower()) + String.Format(PermissionsCheckboxXPath, role)));
            if (!checkbox.Selected)
            {
                UIActions.JSClickElement(By.XPath(String.Format(PermissionsCheckboxXPath, role)));
                //WaitMethods.WaitForElementToBeStale(amendmentRegion);
            }
        }

        //public void ClickElement(string button)
        //{
        //    IWebElement myButton = WaitMethods.WaitForElement(By.XPath(string.Format(ButtonXPath, button)));
        //    myButton.Click();

        //    WaitMethods.WaitForPageToLoad(60);
        //}

        public void ClickLink(string link)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            UIActions.JSClickElement(By.XPath(String.Format("//a[contains(text(),\"{0}\")]", link)));
        }

        //public void ClickTitleBar()
        //{
        //    IWebElement titlebar = WaitMethods.WaitForElement(SoldierDemographicTitle);
        //    titlebar.Click();
        //    WaitMethods.WaitForPageToLoad();
        //}






        public void SelectFromDropdown(string selection, string dropdown)
        {
            SelectElement myDropdown = new SelectElement(UIActions.GetElement(By.XPath(String.Format(LookupSMDropdownXPath, dropdown))));
            myDropdown.SelectByText(selection);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        public void SelectPermissionsTab(string tab)
        {
            if (UIActions.IsElementPresent(By.XPath(String.Format(PermissionsTabXPath, tab))))
                UIActions.JSClickElement(By.XPath(String.Format(PermissionsTabXPath, tab)));
        }

        #endregion Page Methods

        #region Page Validations

        public void VerifyColumnValues(string[] values)
        {
            string headerText = UIActions.GetElement(LookupSMResultTableHeader).Text;
            Assert.NotNull(headerText);
            foreach (string value in values)
                Assert.Contains(value, headerText);
        }

        public void VerifyEditDemographicsRegionDisplay(string appearance)
        {
            switch (appearance.ToLower())
            {
                case "closed":
                    Assert.False(UIActions.GetElement(EditSoldierDemographicsPanel).Displayed);
                    break;

                case "open":
                    Assert.True(UIActions.GetElement(EditSoldierDemographicsPanel).Displayed);
                    break;

                default:
                    throw new Exception("Unknown value: " + appearance);
            }
        }

        public void VerifyElementColor(string elementType, string value, string color)
        {
            //WaitMethods.WaitForElement(ContactInformationTitle).Click();

            By myElement;

            switch (elementType.ToLower())
            {
                case "textbox":
                    myElement = By.XPath(String.Format(LookupSMTextboxXPath, value));
                    break;

                case "dropdown":
                    myElement = By.XPath(String.Format(LookupSMDropdownXPath, value));
                    break;

                default:
                    throw new Exception("Unknown element: " + elementType);
            }

            Assert.NotNull(myElement);

            switch (color.ToLower())
            {
                case "red":
                    Assert.Equal("rgba(253, 223, 223, 1)", UIActions.GetElement(myElement).GetCssValue("background-color"));
                    break;

                case "white":
                    Assert.Equal("rgba(255, 255, 255, 1)", UIActions.GetElement(myElement).GetCssValue("background-color"));
                    break;

                default:
                    throw new Exception("Unknown color: " + color);
            }
        }

        //public void VerifyElementText(string elementType, string value, string text)
        //{
        //    IWebElement myElement;

        //    switch (elementType.ToLower())
        //    {
        //        case "textbox":
        //            myElement = WaitMethods.WaitForElement(By.XPath(String.Format(LookupSMTextboxXPath, value)));
        //            Assert.Equal(text, myElement.GetAttribute("value"));
        //            break;

        //        case "dropdown":
        //            SelectElement dropdown = new SelectElement(WaitMethods.WaitForElement(By.XPath(String.Format(LookupSMDropdownXPath, value))));
        //            Assert.Equal(text, dropdown.SelectedOption.Text);
        //            break;

        //        default:
        //            throw new Exception("Unknown element: " + elementType);
        //    }
        //}

        public void VerifyEmptyTextbox(string textbox)
        {
            Assert.Equal(String.Empty, UIActions.GetElement(By.XPath(String.Format(LookupSMTextboxXPath, textbox))).GetAttribute("value"));
        }

        //public void VerifyHeadingExists(string heading)
        //{
        //    IWebElement myHeading = WaitMethods.WaitForElement(By.XPath(String.Format(EditSoldierDemographicHeadingXPath, heading)));
        //    Assert.True(myHeading.Displayed);
        //}

        public void VerifyPageContainsEditableFields(Boolean doesContain)
        {
            IReadOnlyCollection<IWebElement> fields = UIActions.GetAllElements(SoldierDemographicEditableFields);

            foreach (IWebElement field in fields)
                Assert.Equal(doesContain, field.Displayed);
        }

        public void VerifyPermissionExists(string permission, Boolean exists)
        {
            if (exists)
                Assert.True(UIActions.IsElementPresent(By.XPath(String.Format(PermissionsCheckboxXPath, permission))));
            else
                Assert.False(UIActions.IsElementPresent(By.XPath(String.Format(PermissionsCheckboxXPath, permission))));
        }

        public void VerifyResultInColumn(string result, string column)
        {
            WaitMethods.Wait(LookupSMResultTable, 60);

            if (result.Equals("none"))
                UIActions.GetElement(NoResultsFound).Displayed.Should().BeTrue();
            else
            {
                //var emptyChars = new char[] { ' ' };
                IReadOnlyCollection<IWebElement> columns = UIActions.GetAllElements(By.XPath(LookupSMResultTableHeaderXPath + "/th"));
                int colNum = -1;
                int i = 1;
                foreach (IWebElement col in columns)
                {
                    if (col.Text.Trim().Equals(column))
                    {
                        colNum = i;
                        break;
                    }
                    else
                        i++;
                }
                Assert.NotEqual(colNum, -1);

                IReadOnlyCollection<IWebElement> results = UIActions.GetAllElements(By.XPath(String.Format(LookupSMResultTableResultColXPath, colNum)));
                foreach (IWebElement col in results)
                    Assert.True(col.Text.ToLower().Contains(result.ToLower()));
            }
        }

        public void VerifySoldierDemographics(string datum, string location)
        {
            string data;
            switch (location)
            {
                case "Title":
                    data = UIActions.GetElement(SoldierDemographicTitle).Text;
                    Assert.True(data.Contains(datum));
                    break;

                case "Panel":
                    data = UIActions.GetElement(SoldierDemographicInfoPanel).Text;
                    Assert.True(data.Contains(datum));
                    break;

                default:
                    throw new Exception("Unknown location: " + location);
            }
        }

        public void VerifySoldierPanelAction(string action)
        {
            WaitMethods.Wait(SoldierDemographicInfoPanel, 60);
            IWebElement panel = UIActions.GetElement(SoldierDemographicInfoPanel);
            switch (action)
            {
                case "collapses":
                    Assert.False(UIActions.IsDisplayed(panel));
                    break;

                case "expands":
                    Assert.True(UIActions.IsDisplayed(panel));
                    break;

                default:
                    throw new Exception("Unknown action : " + action);
            }
        }

        //public void VerifyWarningMessage(Boolean exists, string warning)
        //{
        //    Assert.Equal(exists, UIValidations.IsElementPresent(By.XPath(String.Format(WarningMessageXPath, warning))));
        //}

        #endregion Page Validations
    }
}