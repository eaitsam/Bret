using FluentAssertions;
using FrameworkAutomation.PageObjectModel;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.User_Management
{
    public class UICLookup
    {

        BaseDriverInit _webDriver;
        private readonly Login _login;
        private readonly Homepage _homepage;
        private readonly SearchFilterObjects _searchFilter;
        private readonly UICLookupPage _lookupPage;
        private const string BACKGROUND_COLOR = "background-color";
        private const ColorName HOVER_COLOR = ColorName.BlueViolet;
        private const ColorName INCORRECT_HOVER_COLOR = ColorName.BlueViolet;
        private const ColorName PARENT = ColorName.Red;
        private const ColorName CHILD = ColorName.CadetBlue;

        public UICLookup()
        {
            _webDriver = new BaseDriverInit();
            _login = new Login();
            _homepage = new Homepage();
            _searchFilter = new SearchFilterObjects();
            _lookupPage = new UICLookupPage();
        }
        //Scenario: UIC Lookup ARNG - Org Chart Heirarchy (Parents)
        //	Given I am Logged in as "Sys Admin" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter "W77743" in the UIC search field
        //	Then the heirarchy for "W77743" contains the correct heirarchy of "W00QAA,W8BJAA,W777AA,W77743"
        [Fact]
        public void UICLookupARNG()
        {
            try
            {
                string[] childUics = new string[] { "W00QAA", "W8BJAA", "W777AA", "W77743" };
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys("W77743");
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                foreach (var uic in childUics)
                {
                    var ele = UIActions.GetElement(By.Id(uic));
                }

            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        //Scenario: UIC Lookup ARNG - Org Chart Coloring(Parents)
        //	Given I am Logged in as "Sys Admin" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter "W77743" in the UIC search field
        //	Then the coloring for the org chart is correct
        [Fact]
        public void UICLookupARNG_ReturnsCorrectColor()
        {
            try
            {
                string[] childUics = new string[] { "W00QAA", "W8BJAA", "W777AA", "W77743" };
                string parent = "W77743";
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parent);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                foreach (var uic in childUics)
                {
                    var ele = UIActions.GetElement(By.Id(uic));
                    _ = ele.GetCssValue(BACKGROUND_COLOR).Should().Be(RGBColor.GetByName(ColorName.Red).ToRGB());
                }
            }
            finally
            {
                _webDriver.TearDown();
            }
        }


        //Scenario: UIC Lookup ARNG - Org Chart Alphabetical Order
        //	Given I am Logged in as "eCase ARNG Manager" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter "W77743" in the UIC search field
        //	And I click on the "W00QAA" UIC
        //	Then the children UICs are ordered from left to right in alphabetical order
        [Fact]
        public void UICLookupARNG_ClickingOnUICResultsInChildrenInAlphabeticalOrder()
        {
            try
            {
                string parent = "W77743";
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parent);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.GetElement(By.Id("W00QAA")).Click();
                var childUics = UIActions.GetAllElements(_lookupPage.OrgChartChildBlocks);
                UICLookupPage.ElementsAreAlphabeticallyAscending(childUics).Should().BeTrue();
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        //Scenario: UIC Lookup ARNG - Org Chart Heirarchy(Parents and Children)
        //	Given I am Logged in as "eCase ARNG Manager" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter "W77743" in the UIC search field
        //	And I click on the "W00QAA" UIC
        //	And I hover over the "W8A1AA" UIC
        //	Then the "W8A1AA" of "Child" is displayed with "W00QAA" and "KSARNG ELEMENT, JF HQ;5092;83"

        [Fact]
        public void UICLookupARNG_HoveringOverElementDisplaysCorrectInformation()
        {
            try
            {
                string parent = "W77743";
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parent);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.GetElement(By.Id("W00QAA")).Click();
                UIActions.GetElement(By.Id("W8A1AA")).Should().NotBeNull();
                UIActions.MoveTo(By.Id("W8A1AA"));
                UIActions.GetElement(By.TagName("legend")).Text.Should().Be("W8A1AA (Child of W00QAA)");
                var uicInfo = UIActions.GetAllElements(By.ClassName("uic-info-data")).Select(x => x.Text);
                uicInfo.Should().Contain("KSARNG ELEMENT, JF HQ");
                uicInfo.Should().Contain("5092");
                uicInfo.Should().Contain("83");
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        //Scenario Outline: UIC Lookup ARNG - Org Chart Heirarchy(Children)
        //	Given I am Logged in as "eCase ARNG Manager" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter "W77743" in the UIC search field
        //	And I hover over the<UIC> UIC
        //	Then the<UIC> of<Type> is displayed with <Parent/Child> and<Name/Rollup Strength/Unit Strength>

        //	| UIC    | Type     | Parent/Child | Name/Rollup Strength/Unit Strength |
        [Theory]
        [InlineData("W00QAA", "Ancestor", "W77743", new string[] { "NATIONAL GUARD BUREAU", "349292", "0" })]
        [InlineData("W8BJAA", "Ancestor", "W77743", new string[] { "VAARNG ELEMENT, JF HQ", "7470", "175" })]
        [InlineData("W777AA", "Ancestor", "W77743", new string[] { "VIRGINIA REC & RET", "129", "111" })]
        public void UICLookupARNG_Rollup(string targetUic, string relation, string parentUic, string[] info)
        {
            try
            {
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parentUic);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.MoveTo(By.Id(targetUic));
                UIActions.GetElement(By.TagName("legend")).Text.Should().Be($"{targetUic} ({relation} of {parentUic})");
                var uicInfo = UIActions.GetAllElements(By.ClassName("uic-info-data")).Select(x => x.Text);
                uicInfo.Should().Contain(info[0]);
                uicInfo.Should().Contain(info[1]);
                uicInfo.Should().Contain(info[2]);
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        [Theory]
        [InlineData("W77743", "W77743", new string[] { "RI ARNG REC RET CMD", "0", "0" })]
        public void UICLookupARNG_Rollup_TargetUICDisplaysCorrectInfo(string targetUic, string parentUic, string[] info)
        {
            try
            {
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parentUic);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.MoveTo(By.Id(targetUic));
                UIActions.GetElement(By.TagName("legend")).Text.Should().Be($"{targetUic}");
                var uicInfo = UIActions.GetAllElements(By.ClassName("uic-info-data")).Select(x => x.Text);
                uicInfo.Should().Contain(info[0]);
                uicInfo.Should().Contain(info[1]);
                uicInfo.Should().Contain(info[2]);

            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        [Fact]
        public void UICLookupARNG_HittingEnterReturnsCorrectInformation()
        {
            try
            {
                string[] childUics = new string[] { "W00QAA", "W8BJAA", "W777AA", "W77743" };
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys("W77743");
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(Keys.Enter);
                foreach (var uic in childUics)
                {
                    var ele = UIActions.GetElement(By.Id(uic));
                }

            }
            finally
            {
                _webDriver.TearDown();
            }

        }

        //		Scenario Outline: UIC Lookup - ARNG
        //	Given I am Logged in as "Sys Admin" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter<UIC> in the UIC search field
        //	Then the system should display the information for <UIC>
        //	And the result should be correct for the UIC Type of <UIC Type> with the UIC of <UIC>

        //	Scenarios: 
        //	| UIC Type     | UIC    |
        //	| No Org Chart | W77749 |
        //	| Org Chart    | W77743 |
        [Theory]
        [InlineData("W77749", false)]
        [InlineData("W77743", true)]
        public void UICLookupARNG_Rollup_TargetUICDisplaysOrgChartOrPageMessageCorrectly(string targetUic, bool hasOrgChart)
        {
            try
            {
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(targetUic);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                if (hasOrgChart)
                {
                    UIActions.GetElement(_lookupPage.OrgChartParent).Text.Should().NotBeEmpty();
                }
                else
                {
                    UIActions.GetElement(By.Id("page-message")).Text.Should().Be($"Could not find a(n) Org Chart for {targetUic}.");
                }

            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        //Scenario Outline: UIC Lookup ARNG - Org Chart Coloring(Children)
        //	Given I am Logged in as "eCase ARNG Manager" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter "W77743" in the UIC search field
        //	And I click on the<UIC Click Sequence> UIC
        //	Then the coloring for the children and parent blocks are correct with<UIC> of<Type>

        //	Scenarios:
        //	| UIC Click Sequence          | UIC    | Type   |




        [Theory]
        [InlineData("W77743", new string[] { "W00QAA" }, new string[] { "W00QAA", "W7P4AA" }, new ColorName[] { PARENT, CHILD })]
        [InlineData("W77743", new string[] { "W00QAA", "W8BJAA", "W777AA" }, new string[] { "W777AA", "W777AB" }, new ColorName[]{PARENT, CHILD })]
        [InlineData("W77743", new string[] { "W00QAA", "W8BJAA", "W777AA", "W77743" }, new string[] { "W77743", "W777AA" }, new ColorName[]{  PARENT , PARENT } )]
        public void UICLookupARNG_Rollup_TargetUICDisplaysOrgChartColorsCorrectly(string targetUic, string[] uics, string[] resultUics, ColorName[] colors)
        {
            try
            {
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(targetUic);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                foreach(var x in uics)
                {
                    UIActions.GetElement(By.Id(x)).Click();
                }
                for(int i = 0; i < resultUics.Length; i++)
                {
                    var ele = UIActions.GetElement(By.Id(resultUics[i]));
                    ele.GetCssValue(BACKGROUND_COLOR).Should().Be(RGBColor.GetByName(colors[i]).ToRGB());
                }
               
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        //Scenario: UIC Lookup ARNG - Search Field
        //	Given I am Logged in as "eCase ARNG Manager" using EDIPIN 8880010823
        //	When I select the "Lookup UIC" link in the MEDCHART tile
        //	And I enter "W77743" in the UIC search field
        //	And I click on the "W00QAA" UIC
        //	Then the search field contains "W00QAA"
        [Fact]
        public void UICLookupARNG_ClickingOnUICResultsSearchFieldBeingPopulated()
        {
            try
            {
                string parent = "W77743";
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parent);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.GetElement(By.Id("W00QAA")).Click();
                UIActions.GetElement(_lookupPage.SearchBox).Text.Should().Be("W00QAA");
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        [Fact]
        public void UICLookupARNG_ClickingOnUICResultsRegionBeingPopulated()
        {
            try
            {
                string parent = "W77743";
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parent);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.GetElement(By.Id("W00QAA")).Click();
               var ele = UIActions.GetElement(By.Id("MEDCHARTContent_MedchartPagesContent_ucUicLookup_UicDetailsList"));
                var uicInfoElements = ele.FindElements(By.TagName("dd")).Select(x => x.Text);
                uicInfoElements.Should().Contain("Kentucky (KY)");
                uicInfoElements.Should().Contain("Open");
                uicInfoElements.Should().Contain("Populated");
            }
            finally
            {
                _webDriver.TearDown();
            }
        }

        [Fact]
        public void UICLookupARNG_HoveringShowsCorrectBackgroundColor()
        {
            try
            {
                string parent = "W77743";
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parent);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.MoveTo(By.Id("W00QAA"));
                var ele = UIActions.GetElement(By.Id("W00QAA"));
                ele.GetCssValue(BACKGROUND_COLOR).Should().Be(RGBColor.GetByName(HOVER_COLOR).ToRGB());
            }
            finally
            {
                _webDriver.TearDown();
            }
        }
        [Fact]
        public void UICLookupARNG_NegativeTestHoveringShowsCorrectBackgroundColor()
        {
            try
            {
                string parent = "W77743";
                //login
                _webDriver.InitWebdriver();
                _login.LoginMethod("8880010823");
                UIActions.GetElement(_homepage.LookupUICLink).Click();
                UIActions.GetElement(_lookupPage.SearchBox).SendKeys(parent);
                UIActions.GetElement(_lookupPage.SearchButton).Click();
                UIActions.MoveTo(By.Id("W00QAA"));
                var ele = UIActions.GetElement(By.Id("W00QAA"));
                ele.GetCssValue(BACKGROUND_COLOR).Should().Be(RGBColor.GetByName(INCORRECT_HOVER_COLOR).ToRGB());
            }
            finally
            {
                _webDriver.TearDown();
            }
        }
    }
}
