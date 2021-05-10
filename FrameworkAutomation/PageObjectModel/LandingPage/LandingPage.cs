using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.PageObjectModel.LandingPage
{
   public  class Landing_Page
    {

        public By HippaWarning => By.XPath("/html/body/form/div[7]/div/h4[4]");
        public By DDWebSiteLink => By.XPath("/html/body/form/div[7]/div/p[5]/a");
        public By DDWebSiteLinkPage => By.XPath("dnn_ctr13712_HtmlModule_lblContent");
        public string HippaWarningDescription => " Protected Health Information in this system is subject to Public Law 104-191, the Health Insurance Portability and Accountability Act of 1996 and the Final Privacy Rule and Final Security Rule codified in 45 C.F.R. § 160 and 164, DoD 6025.18-R, DoD Health Information Privacy Regulation and DoD 8580.02-R, DoD Health Information Security Regulation. Information in this system may only be used and/or disclosed in strict conformance with these authorities.The US Army Medical Command is required to, and will apply, appropriate sanctions against individuals who fail to comply with its privacy policies and procedures.";

    }
}
