using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Xunit;

namespace FrameworkAutomation.PageObjectModel
{
    public class UICLookupPage
    {
        #region Page Objects

        #region By Elements
        public By SearchBox => By.Id("MEDCHARTContent_MedchartPagesContent_ucUicLookup_SearchTextbox");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_ucUicLookup_SearchButton");
        public By DetailsPanel => By.Id("MEDCHARTContent_MedchartPagesContent_ucUicLookup_UicDetailsPanel");
        public By OrgInfoPanel => By.XPath("//div[@class='uic-info-fieldset']");
        public By OrgChartParent => By.Id("parent-container");
        public By OrgChartBlocks => By.XPath("//div[contains(@class, 'oc-node uics')]");
        public By OrgChartChildren => By.Id("child-container");
        public By OrgChartChildBlocks => By.XPath("//div[@id='child-container']/div[@class='oc-node']");
        #endregion
        #region String/List Elements
        public string NoOrgChartXPath => "//div[contains(text(),'Could not find a(n) Org Chart for *uic*')]";
        #endregion

        #endregion

        #region Page Methods

        public void EnterUIC(string uic)
        {
            // Enter UIC into search box
            WaitMethods.Wait(SearchBox, 60);
            UIActions.JSEnterText(SearchBox, uic);
            // Click on search button
            WaitMethods.Wait(SearchButton, 60);
            UIActions.JSClickElement(SearchButton);
        }

        public void HoverUIC(string uic)
        {
            // Hover over block with the given UIC
            WaitMethods.Wait(OrgChartParent, 60);
            UIActions.MoveTo(By.Id(uic));
        }

        public void ClickUIC(string uic)
        {
            // Click on the org chart block with the given uic
            WaitMethods.Wait(OrgChartParent, 60);
            UIActions.JSClickElement(By.Id(uic));
        }

        #endregion

        #region Page Validations

        public void VerifySystemDisplay(string uic)
        {
            // Make sure that the details panel displays the correct information
            WaitMethods.Wait(DetailsPanel, 60);
            string details = UIActions.GetElement(DetailsPanel).Text;
            Assert.Contains(uic, details);
        }

        public void VerifyOrgChartPanelInfo(string uic, string type, string parent_or_child, string[] data)
        {
            Assert.Equal(3, data.Length);
            string panelText = UIActions.GetElement(OrgInfoPanel).Text;
            Assert.Contains(uic, panelText);
            Assert.Contains("Name:" + data[0], panelText);
            Assert.Contains("Rollup Strength:" + data[1], panelText);
            Assert.Contains("Unit Strength:" + data[2], panelText);

            if (type != null)
            {
                switch (type)
                {
                    case "Ancestor":
                        Assert.Contains("Ancestor of " + parent_or_child, panelText);
                        break;
                    case "Child":
                        Assert.Contains("Child of " + parent_or_child, panelText);
                        break;
                    default:
                        throw new Exception("Unknown type: " + type);
                }
            }

        }

        public void VerifyOrgChartHeirarchy(string uic, string[] heirarchy)
        {
            // Verify that the the org chart is present
            UIActions.GetElement(OrgChartParent).Displayed.Should().BeTrue();
            // Verify that the heirarchy within the org chart is correct
            IReadOnlyCollection<IWebElement> blocks = UIActions.GetAllElements(OrgChartBlocks);
            Assert.True(blocks.Count == heirarchy.Length);

            int i = 0;
            foreach (IWebElement block in blocks)
            {
                Assert.Equal(heirarchy[i], block.Text);
                i++;
            }
        }

        public void VerifyOrgChartColoring()
        {
            // Verify that the coloring for the chart is correct
            IReadOnlyCollection<IWebElement> blocks = UIActions.GetAllElements(OrgChartBlocks);

            int i = 0;
            foreach (IWebElement block in blocks)
            {
                if (i == blocks.Count-1)
                {
                    Assert.Equal("double", block.GetCssValue("border-bottom-style"));
                    Assert.Equal("double", block.GetCssValue("border-top-style"));
                    Assert.Equal("double", block.GetCssValue("border-left-style"));
                    Assert.Equal("double", block.GetCssValue("border-right-style"));
                }
                Assert.Equal("rgba(255, 0, 0, 1)", block.GetCssValue("background-color"));
                Assert.Equal("rgba(255, 255, 255, 1)", block.GetCssValue("color"));

                i++;
            }
        }

        public void VerifyOrgChartInfo(string uictype, string uic)
        {
            switch (uictype)
            {
                case "No Org Chart":
                    // Make sure that a message indicating that there is no org chart is displayed
                    //Assert.True(UIValidations.IsElementPresent(By.XPath(NoOrgChartXPath.Replace("*uic*", uic))));
                    break;
                case "Org Chart":
                    // Verify that the org chart info panel exists
                    UIActions.GetElement(OrgInfoPanel).Displayed.Should().BeTrue();
                    // Verify that the details within the info panel are correct
                    string[] data = { "RI ARNG REC RET CMD", "0", "0" };
                    VerifyOrgChartPanelInfo(uic, null, null, data);
                    break;
                default:
                    throw new Exception("Unknown UIC type:" + uictype);
            }
        }

        public void VerifyOrgChartChildrenAlphabetical()
        {
            WaitMethods.Wait(OrgChartChildren, 30);

            if (UIActions.GetNumberOfElements(OrgChartChildBlocks) >= 2)
            {
                IReadOnlyCollection<IWebElement> blocks = UIActions.GetAllElements(OrgChartChildBlocks);

                IWebElement blockA = null;
                foreach (IWebElement blockB in blocks)
                {
                    if (blockA != null)
                        Assert.True(blockA.Text.CompareTo(blockB.Text) < 0);
                    blockA = blockB;
                }
            }
        }

        public void VerifyOrgChartColoringChildren(string uic, string type)
        {
            switch (type.ToLower())
            {
                case "parent":
                    {
                        string parentColor = UIActions.GetElement(By.Id(uic)).GetCssValue("background-color");
                        IReadOnlyCollection<IWebElement> blocks = UIActions.GetAllElements(OrgChartChildBlocks);

                        foreach (IWebElement block in blocks)
                        {
                            Assert.Equal("rgba(255, 255, 255, 1)", block.GetCssValue("color"));
                            string childcolor = block.GetCssValue("background-color");
                            Assert.Equal("rgba(95, 158, 160, 1)", childcolor);
                            Assert.NotEqual(parentColor, childcolor);
                        }
                    }
                    break;
                case "child":
                    {
                        IWebElement block = UIActions.GetElement(By.Id(uic));

                        Assert.Equal("rgba(255, 0, 0, 1)", block.GetCssValue("background-color"));
                        Assert.Equal("double", block.GetCssValue("border-bottom-style"));
                        Assert.Equal("double", block.GetCssValue("border-top-style"));
                        Assert.Equal("double", block.GetCssValue("border-left-style"));
                        Assert.Equal("double", block.GetCssValue("border-right-style"));
                    }
                    break;
                default:
                    throw new Exception("Unknown UIC type: " + type);
            }
        }

        public void VerifySearchField(string uic)
        {
            Assert.Equal(uic, UIActions.GetTextBoxTextValue(SearchBox));
        }
        //Assumes Elements are ordered, alphabetically ascending, left to right, top to bottom
        public static bool ElementsAreAlphabeticallyAscending(IReadOnlyCollection<IWebElement> elements)
        {
            if (elements.Count < 2)
                return false;
            IWebElement prev = SetElement(elements, 0);
            for (int i = 1; i < elements.Count; i++)
            {
                IWebElement current = SetElement(elements, i);
                if (IsInSameRow(prev.Location, current.Location))
                {
                    if (!IsToTheRight(prev.Location, current.Location))
                        return false;
                    //0: the strings are equal
                    //1: prev is alphetically greater than current.
                    if (string.Compare(prev.Text, current.Text, true) >= 0)
                        return false;
                }
                else
                {
                    prev = current;
                }
            }
            return true;
        }

        private static IWebElement SetElement(IReadOnlyCollection<IWebElement> elements, int index)
        {
            return elements.ElementAt(index);
        }

        public static bool IsInSameRow(Point v1, Point v2)
        {
            return v1.Y == v2.Y;
        }

        public static bool IsToTheRight(Point v1, Point v2)
        {

            return v2.X > v1.X;
        }
        #endregion
    }
}
