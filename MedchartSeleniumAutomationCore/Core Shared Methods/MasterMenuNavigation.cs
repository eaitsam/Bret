using MedchartSeleniumAutomationCore.Core_Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedchartSeleniumAutomationCore.Core_Shared_Methods
{
    public class MasterMenuNavigation
    {
        public static void StartTabSelectionMethod(List<By> tabs)
        {
            Console.WriteLine("In StartTabSelectionMethod");
            foreach (var tab in tabs)
            {
                WaitMethods.Wait(tab, 60);
                Console.WriteLine($"After Wait for Element: {tab}");
                //UIActions.JSMoveTo(tab);
                UIActions.MoveTo(tab);
            }
            UIActions.JSClickElement(tabs.Last());
        }

    }
}
