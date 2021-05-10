using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
    public class PreAuthTrackingPage
    {
        #region My Pre-Auth Tracking Tab Objects

        #region HTML Div

        [FindsBy(How = How.Id, Using = "MEDCHARTContent_EmmpsContent_CaseHeader1_MMSOTrackingMenuDiv")]
        private IWebElement MMSOTrackingMenuDiv { get; set; }

        #endregion
        #region HTML Text Boxes
        public By MMSOTrackingCommentsTextbox = By.Id("MEDCHARTContent_EmmpsContent_TrackingCommentUserControl_TextBoxComments");

        #endregion
        #region HTML Hyperlinks
        public By MMSOTrackingShowUsersWorkingThisCaseLinkButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowUsersWorkingThisCaseLinkButton");
        public By MMSOTrackingExportTrackingResultsButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ExportTrackingResultsLinkButton");


        #endregion
        #region HTML Radio Buttons
        public By MMSOTrackingExpandNoButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList_0");
        public By MMSOTrackingExpandYesButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList_1");


        #endregion

        #endregion

    }
}
