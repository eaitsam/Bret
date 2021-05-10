using EmmpsAutomation.PageObjectModel.LOD;
using EmmpsAutomation.PageObjectModel.Usermanagement;
using EmmpsAutomation.Tests.Permissions.Shared_Context;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmmpsAutomation.Permissions
{
    public class MyAccountPermissions
    {
        BaseDriverInit _driverInit;
        Login _login;
        NavMenuObjects _navMenu;
        EmmpsPermissions _perms;
        MiscPageOjects _misc;

        public MyAccountPermissions()
        {
            _driverInit = new BaseDriverInit();
            _login = new Login();
            _navMenu = new NavMenuObjects();
            _perms = new EmmpsPermissions();
            _misc = new MiscPageOjects();
        }

        [Fact]
        public void ARSARC()
        {
            //Case54184
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070121");
                ARSARCDataTables _dataTables = new ARSARCDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.EMMPSLODAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void ARUnitAdmin()
        {
            //@Case46131
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070322");
                ARUnitAdminDataTables _dataTables = new ARUnitAdminDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        [Fact]
        public void ARUnitCommander()
        {
            //@Case46403
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070323");
                ARUnitCommanderDataTables _dataTables = new ARUnitCommanderDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }

        }


        [Fact]
        public void ARInvestigator()
        {
            //@Case54182
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070124");
                ARInvestigatorDataTable _dataTables = new ARInvestigatorDataTable();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }

        }


        [Fact]
        public void MSCLegalReview()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070126");
                MSCLegalReviewDataTables _dataTables = new MSCLegalReviewDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }

        }

        [Fact]
        public void MSCAdmin()
        {
            //@Case46167
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070128");
                MSCAdminDataTables _dataTables = new MSCAdminDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LODPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void MSCMedicalReview()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070127");
                MSCMedicalReviewDataTables _dataTables = new MSCMedicalReviewDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LODPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void MSCApproval()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070129");
                MSCApprovalDataTables _dataTables = new MSCApprovalDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                //_perms.MyAccountPermsTabValidation(_dataTables.permtabs);
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LODPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void DIVRPDHRAManager()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070135");
                DIVRPDHRAManagerDataTables _dataTables = new DIVRPDHRAManagerDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();

                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARDivROversight()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070130");
                USARDivROversightDataTables _dataTables = new USARDivROversightDataTables();

                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LODPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARDivRLegalReview()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070131");
                USARDivRLegalReview _dataTables = new USARDivRLegalReview();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LODPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARDivRMedicalReview()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070132");
                USARDivRMedicalReviewDataTables _dataTables = new USARDivRMedicalReviewDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LODPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARDivRAdmin()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070133");
                DivRAdminDataTables _dataTables = new DivRAdminDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARDIVRApproval()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070134");
                DIVRApprovalDataTables _dataTables = new DIVRApprovalDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void G1PDHRAManager()
        {
            //@Case53867

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070036");
                G1PDHRAManagerDataTables _dataTables = new G1PDHRAManagerDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARCG1Oversight()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070037");
                USARCG1OversightDataTables _dataTables = new USARCG1OversightDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARCLegalReview()
        {
            //	@Case46574

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070038");
                USARCLegalReviewDataTables _dataTables = new USARCLegalReviewDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        [Fact]
        public void USARCMedicalReview()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070039");
                USARCMedicalReview _dataTables = new USARCMedicalReview();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARCSARCManager()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070040");
                USARCSARCManagerDataTables _dataTables = new USARCSARCManagerDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void USARCG1Admin()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070141");
                USARCG1AdminDataTables _dataTables = new USARCG1AdminDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void eMMPSUSARManager()
        {
            //@Case46251

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070042");
                eMMPSUSARManagerDataTables _dataTables = new eMMPSUSARManagerDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        [Fact]
        public void NGUnitAdmin()
        {
            //@Case46086
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070001");
                NGUnitAdminDataTables _dataTables = new NGUnitAdminDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGUnitCommander()
        {
            //@Case46087
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070002");
                NGUnitCommanderDataTables _dataTables = new NGUnitCommanderDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGIntermediateCommandReview()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070103");
                NGIntermedCommandReviewDataTables _dataTables = new NGIntermedCommandReviewDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGAppointingAuthority()
        {
            //@Case46198

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070117");
                NGAppointingAuthorityDataTables _dataTables = new NGAppointingAuthorityDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGSARC()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070109");
                NGSARCDataTables _dataTables = new NGSARCDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGStateOversight()
        {
            //@Case46200
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070110");
                NGStateOversightDataTables _dataTables = new NGStateOversightDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGStateAdmin()
        {
            //@Case46200
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070113");
                NGStateAdminDataTable _dataTables = new NGStateAdminDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                //_perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGStateJAG()
        {
            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070111");
                NGStateJagDataTables _dataTables = new NGStateJagDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                //_perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());
            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGBOversight()
        {
            //@Case46205

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070015");
                NGNGBOversightDataTable _dataTables = new NGNGBOversightDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        [Fact]
        public void NGBReviewer()
        {
            //	@Case46206

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070018");
                NGNGBReviewerDataTable _dataTables = new NGNGBReviewerDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGBSurgeon()
        {
            //@Case46207

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070017");
                NGNGBSurgeonDataTable _dataTables = new NGNGBSurgeonDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void NGBJAG()
        {
            //@Case46208

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070016");
                NGNGBJAGDataTable _dataTables = new NGNGBJAGDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }



        [Fact]
        public void ARNGManager()
        {
            //@Case46208

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070020");
                ARNGManagerDataTables _dataTables = new ARNGManagerDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }



        [Fact]
        public void NGInvestigator()
        {
            //@Case46208

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070106");
                NGInvestigatorDataTables _dataTables = new NGInvestigatorDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void LODOVersight()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070061");
                LODOVersightDataTable _dataTables = new LODOVersightDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void CrossComLeadHRCReviewer()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070067");
                CrossComLeadHRCReviewerDataTable _dataTables = new CrossComLeadHRCReviewerDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
               //_perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        [Fact]
        public void CrossComHRCReviewer()
        {


            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070060");
                CrossComHRCReviewerDataTable _dataTables = new CrossComHRCReviewerDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }



        [Fact]
        public void CrossComDAG1Approval()
        {


            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070049");
                CrossComDAG1ApprovalDataTable _dataTables = new CrossComDAG1ApprovalDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void CrossComDAG1Admin()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070048");
                CrossComDAG1AdminDataTable _dataTables = new CrossComDAG1AdminDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void CrossComLeadMMSOReviewer()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070048");
                CrossComLeadMMSOReviewerDataTable _dataTables = new CrossComLeadMMSOReviewerDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        [Fact]
        public void CrossComOTSGViewOnly()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070044");
                CrossComLeadMMSOReviewerDataTable _dataTables = new CrossComLeadMMSOReviewerDataTable();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        [Fact]
        public void CrossComOTSGApproval()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070043");
                OSTGApprovalDataTables _dataTables = new OSTGApprovalDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                _perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                _perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        [Fact]
        public void PDHRACallCenter()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070045");
                PDHRACallCenterDataTables _dataTables = new PDHRACallCenterDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }


        [Fact]
        public void DEMOBApproval()
        {

            try
            {
                _driverInit.InitWebdriver();
                _login.LoginMethod("8880070414");
                DEMOBApprovalDataTables _dataTables = new DEMOBApprovalDataTables();
                UIActions.GetElement(_misc.MyAccountLink).Click();
                _perms.EmmpsMyAccountPermissionsValidation("eMMPS Administration", _dataTables.EMMPSAdminAccountPerms());
                _perms.EmmpsMyAccountPermissionsValidation("LOD", _dataTables.LodPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("INCAP", _dataTables.INCAPPerms());
                ////_perms.EmmpsMyAccountPermissionsValidation("MMSO", _dataTables.MMSOPerms());
                ////_perms.EmmpsMyAccountPermissionsValidation("PDHRA", _dataTables.PDHRAPerms());
                //_perms.EmmpsMyAccountPermissionsValidation("ADOP", _dataTables.ADOPPerms());
                _perms.EmmpsMyAccountPermissionsValidation("Reports", _dataTables.ReportsPerms());

            }
            finally
            {
                _driverInit.TearDown();
            }
        }

        //#DEMOB Roles - My Account Permissions
        //Scenario: EMMPS My Account Permissions - DEMOB DEMOB Approval
        //	Given I am Logged in as "DEMOB Approval" using EDIPIN 8880070414
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "DEMOB Approval" role
        //	| Tabs                            |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for DEMOB Approval in DEMOB
        //	| Permission                    | Description                                                                                                                    | Access Modifier |
        //	| DEMOB LOD Approval Review     | Permits the user to own a specific LOD status that falls in the DEMOB Workflow.The status permits the user to approve LODs.   | D               |
        //	| Search/View Death LODs        | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs              | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| Write Tracking Comment - LOD  | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |

        //   And the Permissions for "Reports" are correct for DEMOB Unit Commander in DEMOB
        //	| Permission               | Description                                              | Access Modifier |
        //	| DEMOB/WTU Station Report | Permits users to run a report for DEMOB and/or WTU LODs. | E               |

        //   And the Permissions for "eMMPS Administration" are correct for DEMOB Unit Commander in DEMOB
        //	| Permission       | Description                                                                                              | Access Modifier |
        //	| Global Scope     | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Management Tools | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope    | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |


        //@Case46585
        //Scenario: EMMPS My Account Permissions - DEMOB DEMOB Admin
        //   Given I am Logged in as "DEMOB Admin" using EDIPIN 8880070412
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "DEMOB Admin" role
        //	| Tabs                            |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for DEMOB Admin in DEMOB
        //	| Permission                    | Description                                                                                                                    | Access Modifier |
        //	| Create ARNG and USAR LOD      | Permits the user to create a LODs                                                                                              | D               |
        //	| DEMOB LOD Draft               | Permits the user to own an initial LOD status in the DEMOB workflow.                                                           | D               |
        //	| Search/View Death LODs        | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs              | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| Write Tracking Comment - LOD  | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |
        //	And the Permissions for "Reports" are correct for DEMOB Unit Commander in DEMOB
        //	| Permission               | Description                                              | Access Modifier |
        //	| DEMOB/WTU Station Report | Permits users to run a report for DEMOB and/or WTU LODs. | E               |
        //	And the Permissions for "eMMPS Administration" are correct for DEMOB Unit Commander in DEMOB
        //	| Permission       | Description                                                                                              | Access Modifier |
        //	| Global Scope     | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Management Tools | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope    | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |

        //Scenario: EMMPS My Account Permissions - DEMOB DEMOB Manager
        //	Given I am Logged in as "DEMOB Manager" using EDIPIN 8880070411
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "DEMOB Manager" role
        //	| Tabs                               |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for DEMOB Manager in DEMOB
        //	| Permission                        | Description                                                                                                                           | Access Modifier |
        //	| Create ARNG and USAR LOD          | Permits the user to create a LODs                                                                                                     | D               |
        //	| Delete LOD Cases                  | Permits the user to delete LODs                                                                                                       | D               |
        //	| DEMOB LOD Draft                   | Permits the user to own an initial LOD status in the DEMOB workflow.                                                                  | D               |
        //	| DEMOB LOD Review                  | Permits the user to own a specific LOD status that falls in the DEMOB Workflow.The status permits the user to create approval memos. | D               |
        //	| Override LOD                      | Permits the user to change the status of a LOD within the scope of the user.                                                          | D               |
        //	| Override Station Final LOD Status | Permits the user to override closed (approved/denied) DEMOB/WTU LODs within the Compo or Compo-Region scope of the user.              | D               |
        //	| Restore LOD(Restore Deleted LOD) | Permits the user to restore deleted LODs within the scope of the user.                                                                | D               |
        //	| Search/View Death LODs            | Permits the user to search for and view Death LODs                                                                                    | D               |
        //	| Search/View LODs                  | Permits the user to search for and view LODs and LOD Appeals                                                                          | D               |
        //	| Search/View Unrestricted LODs     | Permits the user to search for and view Unrestricted LODs                                                                             | D               |
        //	| View Deleted LOD                  | Permits the user to view LODs that have been deleted.                                                                                 | D               |
        //	| Write Tracking Comment - LOD      | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership        | D               |
        //	And the Permissions for "Reports" are correct for DEMOB Manager in DEMOB
        //	| Permission                           | Description                                                                                                                   | Access Modifier |
        //	| DEMOB/WTU Station Report             | Permits users to run a report for DEMOB and/or WTU LODs.                                                                      | E               |
        //	| LOD Ad-Hoc Report                    | Permits the user to run the LOD Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user. | D               |
        //	| Run Static LOD DEMOB Workload Report | Permits the user to run Static LOD Reports for DEMOB Workload                                                                 | D               |
        //	And the Permissions for "eMMPS Administration" are correct for DEMOB Manager in DEMOB
        //	| Permission               | Description                                                                                              | Access Modifier |
        //	| Approve eMMPS Users      | Permits the ability to approve new eMMPS user accounts                                                   | D               |
        //	| Global Scope             | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Manage eMMPS Permissions | Permits the ability to modify permissions for an eMMPS user                                              | D               |
        //	| Manage eMMPS Users       | Permits the ability to modify access for an eMMPS user                                                   | D               |
        //	| Manage Letterheads       | Permits the user to Manage Letterheads on Memos                                                          | E               |
        //	| Management Tools         | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope            | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |

        //Scenario: EMMPS My Account Permissions - DEMOB DEMOB Unit Commander
        //	Given I am Logged in as "DEMOB Unit Commander" using EDIPIN 8880070413
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "DEMOB Unit Commander" role
        //	| Tabs                            |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for DEMOB Unit Commander in DEMOB
        //	| Permission                    | Description                                                                                                                                                    | Access Modifier |
        //	| DEMOB Unit Commander Review   | Permits the user to own a specific LOD status in the DEMOB workflow.The status permits the user to sign as the Unit Commander on the electronic DA Form 2173. | D               |
        //	| Search/View Death LODs        | Permits the user to search for and view Death LODs                                                                                                             | D               |
        //	| Search/View LODs              | Permits the user to search for and view LODs and LOD Appeals                                                                                                   | D               |
        //	| Search/View Unrestricted LODs | Permits the user to search for and view Unrestricted LODs                                                                                                      | E               |
        //	| Write Tracking Comment - LOD  | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership                                 | E               |
        //	And the Permissions for "Reports" are correct for DEMOB Unit Commander in DEMOB
        //	| Permission               | Description                                              | Access Modifier |
        //	| DEMOB/WTU Station Report | Permits users to run a report for DEMOB and/or WTU LODs. | E               |
        //	And the Permissions for "eMMPS Administration" are correct for DEMOB Unit Commander in DEMOB
        //	| Permission       | Description                                                                                              | Access Modifier |
        //	| Global Scope     | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Management Tools | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope    | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |

        //Scenario: EMMPS My Account Permissions - DEMOB WTU Manager
        //	Given I am Logged in as "WTU Manager" using EDIPIN 8880070418
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "WTU Manager" role
        //	| Tabs                               |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for WTU Manager in DEMOB
        //	| Permission                        | Description                                                                                                                    | Access Modifier |
        //	| Create ARNG and USAR LOD          | Permits the user to create a LODs                                                                                              | D               |
        //	| Delete LOD Cases                  | Permits the user to delete LODs                                                                                                | E               |
        //	| Override LOD                      | Permits the user to change the status of a LOD within the scope of the user.                                                   | E               |
        //	| Override Station Final LOD Status | Permits the user to override closed (approved/denied) DEMOB/WTU LODs within the Compo or Compo-Region scope of the user.       | E               |
        //	| Restore LOD(Restore Deleted LOD) | Permits the user to restore deleted LODs within the scope of the user.                                                         | E               |
        //	| Search/View Death LODs            | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs                  | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs     | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| TRADOC-Brigade Scope              | Permits the user to have the ability to filter inbox by TRADOC Brigades.                                                       | D               |
        //	| View Deleted LOD                  | Permits the user to view LODs that have been deleted.                                                                          | E               |
        //	| Write Tracking Comment - LOD      | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |
        //	| WTU LOD Draft                     | Permits the user to own an initial LOD status in the WTU workflow.                                                             | D               |
        //	| WTU LOD Review                    | Permits the user to own a specific LOD status in the WTU Workflow.The status permits the user to create approval memos.       | D               |
        //	And the Permissions for "Reports" are correct for WTU Manager in DEMOB
        //	| Permission                           | Description                                                                                                                   | Access Modifier |
        //	| DEMOB/WTU Station Report             | Permits users to run a report for DEMOB and/or WTU LODs.                                                                      | E               |
        //	| LOD Ad-Hoc Report                    | Permits the user to run the LOD Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user. | D               |
        //	| Run Static LOD WTU Workload Report | Permits the user to run Static LOD Reports for DEMOB Workload                                                                 | D               |
        //	And the Permissions for "eMMPS Administration" are correct for WTU Manager in DEMOB
        //	| Permission               | Description                                                                                              | Access Modifier |
        //	| Approve eMMPS Users      | Permits the ability to approve new eMMPS user accounts                                                   | D               |
        //	| Global Scope             | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Manage eMMPS Permissions | Permits the ability to modify permissions for an eMMPS user                                              | D               |
        //	| Manage eMMPS Users       | Permits the ability to modify access for an eMMPS user                                                   | D               |
        //	| Manage Letterheads       | Permits the user to Manage Letterheads on Memos                                                          | E               |
        //	| Management Tools         | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope            | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |

        //Scenario: EMMPS My Account Permissions - DEMOB WTU Approval
        //	Given I am Logged in as "WTU Approval" using EDIPIN 8880070415
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "WTU Approval" role
        //	| Tabs                               |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for WTU Approval in DEMOB
        //	| Permission                    | Description                                                                                                                    | Access Modifier |
        //	| Search/View Death LODs        | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs              | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs | Permits the user to search for and view Unrestricted LODs                                                                      | D               |
        //	| TRADOC-Brigade Scope          | Permits the user to have the ability to filter inbox by TRADOC Brigades.                                                       | D               |
        //	| Write Tracking Comment - LOD  | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | D               |
        //	| WTU LOD Approval Review       | Permits the user to own a specific LOD status in the WTU Workflow.The status permits the user to approve LODs.                | D               |

        //   And the Permissions for "Reports" are correct for WTU Approval in DEMOB
        //	| Permission               | Description                                              | Access Modifier |
        //	| DEMOB/WTU Station Report | Permits users to run a report for DEMOB and/or WTU LODs. | D               |

        //   And the Permissions for "eMMPS Administration" are correct for WTU Approval in DEMOB
        //	| Permission               | Description                                                                                              | Access Modifier |
        //	| Global Scope             | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Management Tools         | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope            | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |
        //Scenario: EMMPS My Account Permissions - DEMOB WTU Unit Commander

        //   Given I am Logged in as "WTU Unit Commander" using EDIPIN 8880070417
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "WTU Unit Commander" role
        //	| Tabs                            |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for WTU Unit Commander in DEMOB
        //	| Permission                    | Description                                                                                                                                                  | Access Modifier |
        //	| Search/View Death LODs        | Permits the user to search for and view Death LODs                                                                                                           | D               |
        //	| Search/View LODs              | Permits the user to search for and view LODs and LOD Appeals                                                                                                 | D               |
        //	| Search/View Unrestricted LODs | Permits the user to search for and view Unrestricted LODs                                                                                                    | E               |
        //	| TRADOC-Brigade Scope          | Permits the user to have the ability to filter inbox by TRADOC Brigades.                                                                                     | D               |
        //	| Write Tracking Comment - LOD  | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership                               | E               |
        //	| WTU Unit Commander Review     | Permits the user to own a specific LOD status in the WTU workflow.The status permits the user to sign as the Unit Commander on the electronic DA Form 2173. | D               |
        //	And the Permissions for "Reports" are correct for WTU Unit Commander in DEMOB
        //	| Permission               | Description                                              | Access Modifier |
        //	| DEMOB/WTU Station Report | Permits users to run a report for DEMOB and/or WTU LODs. | E               |
        //	And the Permissions for "eMMPS Administration" are correct for WTU Unit Commander in DEMOB
        //	| Permission       | Description                                                                                              | Access Modifier |
        //	| Global Scope     | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Management Tools | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope    | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |

        //Scenario: EMMPS My Account Permissions - DEMOB WTU Admin
        //	Given I am Logged in as "WTU Admin" using EDIPIN 8880070416
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "WTU Admin" role
        //	| Tabs                               |
        //	| eMMPS Administration, LOD, Reports |
        //	And the Permissions for "LOD" are correct for WTU Admin in DEMOB
        //	| Permission                    | Description                                                                                                                    | Access Modifier |
        //	| Create ARNG and USAR LOD      | Permits the user to create a LODs                                                                                              | D               |
        //	| Search/View Death LODs        | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs              | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| TRADOC-Brigade Scope          | Permits the user to have the ability to filter inbox by TRADOC Brigades.                                                       | D               |
        //	| Write Tracking Comment - LOD  | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |
        //	| WTU LOD Draft                 | Permits the user to own a specific LOD status in the WTU Workflow.The status permits the user to approve LODs.                | D               |

        //   And the Permissions for "Reports" are correct for WTU Admin in DEMOB
        //	| Permission               | Description                                              | Access Modifier |
        //	| DEMOB/WTU Station Report | Permits users to run a report for DEMOB and/or WTU LODs. | E               |

        //   And the Permissions for "eMMPS Administration" are correct for WTU Admin in DEMOB
        //	| Permission               | Description                                                                                              | Access Modifier |
        //	| Global Scope             | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Management Tools         | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Station Scope            | Permits the user to have ARNG/USAR Global Scope for DEMOB/WTU Stations                                   | D               |




        //Scenario: EMMPS My Account Permissions - Sys Admin

        //   Given I am Logged in as "Sys Admin" using EDIPIN 8880070070
        //	When I select the My Account Page Link in the MEDCHART tile
        //	Then my Module Access Details should be correct for my "Sys Admin" role
        //	| Tabs                                          |
        //	| MEDCHART Administration, eMMPS Administration |
        //	And the Permissions for "MEDCHART Administration" are correct for Sys Admin
        //	| Permission                   | Description                                        | Access Modifier |
        //	| Search for User              | Allows a user to search for a specific user        | D               |
        //	| User Bandwidth               | Allows a SA to view Bandwidth usage for a User     | D               |
        //	| View Service Broker Activity | Permits a user to view the Service Broker Activity | D               |
        //	And the Permissions for "eMMPS Administration" are correct for Sys Admin
        //	| Permission                         | Description                                                                                              | Access Modifier |
        //	| Admin Override                     | Permits the user to make administrative updates to cases                                                 | D               |
        //	| Admin Tools                        | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | E               |
        //	| Approve eMMPS Users                | Permits the ability to approve new eMMPS user accounts                                                   | D               |
        //	| E-Mail Opt-In/Out Notification     | Permits the user the option to select whether or not to receive eMMPS E-Mail Notifications.              | D               |
        //	| Global Scope                       | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Impersonate (eMMPS)                | Permits the ability to switch user roles                                                                 | D               |
        //	| Impersonate UIC Profile            | Permits the user to add UICs to account when impersonating users                                         | D               |
        //	| Lookup MSC Progeny Tree            | Allows the user to lookup the MSC regions progeny UIC Tree.                                              | D               |
        //	| Manage eMMPS Permissions           | Permits the ability to modify permissions for an eMMPS user                                              | D               |
        //	| Manage eMMPS Users                 | Permits the ability to modify access for an eMMPS user                                                   | D               |
        //	| Manage Letterheads                 | Permits the user to Manage Letterheads on Memos                                                          | D               |
        //	| Manage System Messages (eMMPS)     | Permits the ability to Manage System Messages (eMMPS)                                                    | D               |
        //	| Manage UIC Page                    | Allows the user to manage and approve UICs within a user's request on the Manage UIC Page.               | D               |
        //	| Management Tools                   | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Organization View of Users (eMMPS) | Permits the ability to manage eMMPS users across all regions                                             | D               |
        //	| View Access Log                    | Allows the user to view the access log for the eMMPS module                                              | D               |
        //	| View Audit Log (eMMPS)             | Allows the user to view the audit log for the eMMPS module                                               | D               |
        //	| View Invalid LOD Log               | Permits users to review an audit trail of invalid LOD creation attempts                                  | E               |
        //	| View MAS Management (Emmps)        | Permits a user to view the MAS Management logs for Emmps                                                 | E               |
        //	| View System Performance (eMMPS)    | Permits the user to view System Health and External Data Exchange Performance.                           | D               |


    }
}
