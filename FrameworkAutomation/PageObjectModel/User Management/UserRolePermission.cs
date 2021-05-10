using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.PageObjectModel
{
    public class UserRolePermission
    {
        #region PageObjects
        public By PermissionAmendementSection => By.XPath("/html/body/form/div[3]/div/div/div/div/p");
        public string PermissionSection = "This section displays the specific set of permissions within the system that this user is granted. The permissions are based on the user’s designated Role (above). If it is necessary to grant the user additional permissions, please select the appropriate permission(s) below. You may deselect any current additional permissions granted, but you cannot deselect default permissions of the Role.";
        public string UserBandwidthCheckboxstr = "User Bandwidth";
        public string UserBandwidthTextstr = "Allows a SA to view Bandwidth usage for a User";
        public By UserBandwidthCheckbox => By.XPath("//div[contains(text(), 'User Bandwidth']");
        public By UserBandwidthText => By.XPath("//div[contains(text(), 'Allows a SA to view Bandwidth usage for a User']");
        public By MedchartAdminTab => By.Id("upPerms");
        public By PermissionTableEcase => By.Id("PermissionAmendmentsTabContainer_ecasePermissionGroupTab_1_ecasePermissionGroup_1_PermissionCheckBoxesDataList");
        public By PermissionTableFramework => By.Id("PermissionAmendmentsTabContainer_frameworkPermissionGroupTab_1_frameworkPermissionGroup_1_PermissionCheckBoxesDataList");
        public By PermissionCheckbox => By.Id("PermissionAmendmentsTabContainer_hrrPermissionGroupTab_1_hrrPermissionGroup_1_PermissionCheckBoxesDataList_PermissionCheckBox_0");
        public By SaveButton => By.Id("btnUpdate");
        public By SubmitAndGoback => By.CssSelector(".ui-dialog-buttonset > button:nth-child(1)");
        public By CancelButton => By.CssSelector("button.ui-button:nth-child(3)");
        public By SubmitButton => By.CssSelector(".ui-dialog-buttonset > button:nth-child(2)");
        #endregion
    }
}
