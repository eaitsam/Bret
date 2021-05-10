using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{
    class NGNGBSurgeonDataTable
    {
        public DataTable EMMPSAdminAccountPerms()
        {
            DataTable table = new DataTable("Admin");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Component Scope";
            newRow["Description"] = "Permits the user Component Level Access in eMMPS";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "E-Mail Opt-In/Out Notification";
            newRow["Description"] = "Permits the user the option to select whether or not to receive eMMPS E-Mail Notifications.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Management Tools";
            newRow["Description"] = "Permits the user to access Management Tools designed for user managed functionality of the eMMPS module.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            return table;
        }



        public DataTable LodPerms()
        {
            DataTable table = new DataTable("LOD");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "LOD AOR";
            newRow["Description"] = "Permits the user to filter cases on the My LODs and LOD Search Page by Area of Responsibility Region(AOR Region).";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "NGB Surgeon Approval & LOD Appeal Review";
            newRow["Description"] = "Permits the user to own two 'NGB' LOD statuses.The status permits the user to provide & approve Medical Opinions";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "NGB Surgeon LOD & Appeal Review";
            newRow["Description"] = "Permits the user to own two 'NGB' LOD statuses. The status permits the user to provide Medical Opinions";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);


            newRow = table.NewRow();
            newRow["Permission"] = "Search/View Death LODs";
            newRow["Description"] = "Permits the user to search for and view Death LODs";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View LODs";
            newRow["Description"] = "Permits the user to search for and view LODs and LOD Appeals";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View Unrestricted LODs";
            newRow["Description"] = "Permits the user to search for and view Unrestricted LODs";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - LOD";
            newRow["Description"] = "Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        public DataTable INCAPPerms()
        {
            DataTable table = new DataTable("INCAP");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "NGB Surgeon Approval INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a medical opinion as an approval.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "NGB Surgeon INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to own two INCAP statuses and review INCAPs, Extensions & Appeals.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View an INCAP";
            newRow["Description"] = "Permits the user to search and view INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;

        }

        public DataTable PDHRAPerms()
        {
            DataTable table = new DataTable("PDHRA");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Search/View PDHRA Referrals";
            newRow["Description"] = "Permits the user to search and view an PDHRA Referrals";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - PDHRA";
            newRow["Description"] = "Permits users with the ability to input a comment on the PDHRA tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        public DataTable MMSOPerms()
        {
            DataTable table = new DataTable("MMSO");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Search/View MMSO Pre-Authorizations";
            newRow["Description"] = "Permits the user to search and view MMSO Pre-Authorization cases.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - MMSO";
            newRow["Description"] = "Permits users with the ability to input a comment on the MMSO tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        public DataTable ADOPPerms()
        {

            DataTable table = new DataTable("ADOP");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Access ADOP Board Tab";
            newRow["Description"] = "Permits the user to access the ADOP Board tab for the ADME/MRP-2 Workflows";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "ADOP Final Status Override";
            newRow["Description"] = "Permits the user to override a closed (approved/denied) ADOP case to an active status.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "ADOP Override";
            newRow["Description"] = "Permits the user to move/change a ADOP from one status to another status with the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);


            newRow = table.NewRow();
            newRow["Permission"] = "NGB Surgeon ADOP Review & USAR Packet Review";
            newRow["Description"] = "Permits full-access to the National Guard NGB Approval statuses";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);


            newRow = table.NewRow();
            newRow["Permission"] = "Search/View ADOP Cases";
            newRow["Description"] = "Permits the user to search for and view ADOP cases";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - ADOP";
            newRow["Description"] = "Permits users with the ability to input a comment on the ADOP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }
        public DataTable ReportsPerms()
        {
            DataTable table = new DataTable("Reports");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "ADOP Ad-Hoc Report";
            newRow["Description"] = "Permits the user to run the ADOP Ad-Hoc Report. Results vary depending on the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "ADOP Reports > Behavioral Health";
            newRow["Description"] = "Permits the user to run ADOP Reports for Behavior Health ADOP cases";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " DEMOB/WTU Station Report";
            newRow["Description"] = "Permits users to run a report for DEMOB and/or WTU LODs.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Ad-Hoc Report";
            newRow["Description"] = "Permits the user to run the LOD Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Match Report";
            newRow["Description"] = "Permits the user to query for LODs based solely on account access.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "MMSO Report";
            newRow["Description"] = "Permits the user to run the MMSO Report. The report displays all MMSO Pre-Authorizations and their corresponding LOD information.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Module Search";
            newRow["Description"] = "Permits the user to search for all Sub-Module items in the eMMPS application related a Service Member.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "NG Overdue LOD Report Dashboard";
            newRow["Description"] = "Permits the user to run the Overdue LOD Completion Report and the Overdue LOD Report for the National Guard";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "NGB ADOP Workload Report";
            newRow["Description"] = "Permits the user to run the ADOP Workload Report.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "RCMC Finances Report";
            newRow["Description"] = "Permits users with the ability to review and compare RCMC case estimates and cost";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Static - LODs Processed by All NGB Roles";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed By All NGB Roles";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Static - LODs Processed By NGB Reviewer";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed By NGB Reviewer (formally NGB Admin/Analyst)";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }



    }
}
