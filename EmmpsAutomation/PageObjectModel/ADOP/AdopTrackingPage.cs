using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.ADOP
{
    public class AdopTrackingPage
    {
        #region My ADOPs Tracking Tab Objects
        #region HTML Div
        public By ADOPTrackingMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_ADOPTrackingMenuDiv");

        #endregion
        #region HTML Text Boxes
        public By ADOPTrackingCommentsTextbox = By.Id("MEDCHARTContent_EmmpsContent_TrackingCommentUserControl_TextBoxComments");

        #endregion
        #region HTML Hyperlinks
        public By ADOPTrackingAddCommentButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingCommentUserControl_LinkButtonAddTrackingComment");
        public By ADOPTrackingShowUsersWorkingThisCaseLinkButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowUsersWorkingThisCaseLinkButton");
        public By ADOPTrackingExportTrackingResultsButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ExportTrackingResultsLinkButton");

        #endregion
        #region HTML Radio Buttons
        public By ADOPTrackingExpandNoButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList_0");
        public By ADOPTrackingExpandYesButton = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList_1");

        #endregion

        #endregion
        public By ADOPTrackingCommentBox = By.Id("MEDCHARTContent_EmmpsContent_TrackingCommentUserControl_TextBoxComments");
        public By ADOPTrackingAddComment = By.Id("MEDCHARTContent_EmmpsContent_TrackingCommentUserControl_LinkButtonAddTrackingComment");

        public By ADOPExpandNo = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList"]/label[1]
        public By ADOPExpandYes = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList");
        //*[@id="MEDCHARTContent_EmmpsContent_TrackingUC1_ShowExpandedDataRadioButtonList"]/label[2]

        public By ADOPWhoIsWorkingCase = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ShowUsersWorkingThisCaseLinkButton");
        public By ADOPEportToExcel = By.Id("MEDCHARTContent_EmmpsContent_TrackingUC1_ExportTrackingResultsLinkButton");

    }
}
