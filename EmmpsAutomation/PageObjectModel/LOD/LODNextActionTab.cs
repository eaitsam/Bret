using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.LOD
{
    public class LODNextActionTab
    {
        //------------------------------//
        //My LOD Next Action Tab Objects
        //------------------------------//
        //--Validations--//
        public By FirstValidMess = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/div/div[1]/div/div/ul/li[1]");
        public By NoValidMess = By.XPath("/html/body/form/div[5]/div/div[1]/div[1]/div[6]/div/div/div/div[1]/div/div/div");

        //--HTML Div--//
        public By LODNextActionMenuDiv = By.Id("MEDCHARTContent_EmmpsContent_CaseHeader1_LODNext");

        //--Hyperlinks and Buttons--//
        public By NextActionSignButton = By.Id($"SignButton");

        //--HTMLSpan--//
        public By InitiateMMSOButtonNo = By.XPath("");
        public By InitiateMMSOButtonYes = By.XPath("");

        //--HTML ComboBoxes--//
        public By NextActionControlDropDownList = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_ActionDropDownList");

        //--HTMLEdit and Text Area--//
        public By NextActionCommentTextBox = By.Id("MEDCHARTContent_EmmpsContent_nextActionControl_CommentsTextBox");


    }
}
