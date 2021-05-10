using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.PageObjectModel.UserManagement
{
    public class UserLookupPage
    {
        public By AdminTab => By.Id("PermissionAmendmentsTabContainer_frameworkPermissionGroupTab_1_frameworkPermissionGroup_1_PermissionCheckBoxesDataList");
       
        public By UserEdipi => By.Id("UserEdipi");
        public By SearchButton => By.Id("MEDCHARTContent_MedchartPagesContent_UserSearch");
    }
}
