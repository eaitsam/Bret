﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{
    public class NGUnitAdminDataTables
    {
        //	| Tabs                                                         |
        //	| eMMPS Administration, LOD, INCAP, PDHRA, MMSO, ADOP, Reports |

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
            newRow["Permission"] = "Management Tools";
            newRow["Description"] = "Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. ";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Unit Scope";
            newRow["Description"] = "Permits the user Unit Level Access in eMMPS; UICs must be input into account for access";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Region Scope";
            newRow["Description"] = "Permits the user to have Region Level Access in eMMPS";
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
            newRow["Permission"] = "Create ARNG and USAR LOD";
            newRow["Description"] = "Permits the user to create a LODs";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Draft (NG)";
            newRow["Description"] = "Permits the user to own an initial Army Reserves LOD status";
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
            newRow["Permission"] = "View Deleted LOD";
            newRow["Description"] = "Permits the user to view LODs that have been deleted.";
            newRow["AccessMod"] = "D";
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
            newRow["Permission"] = "Create MMSO Pre-Auth";
            newRow["Description"] = "Permits the user to create MMSO Pre-Authroization cases.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Delete and Restore MMSO";
            newRow["Description"] = "Permits the user to delete and restore deleted MMSO cases within the scope of the user.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "MMSO Draft (NG)";
            newRow["Description"] = "Permits the user to own an initial MMSO status. This status permits the user to access the Forms and Documents tab.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
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
            newRow["Permission"] = "ADOP Draft (NG)";
            newRow["Description"] = "Permits the user to own a specific ADOP status that falls in one or more workflows. The user will be able to initiate an ADOP case have read/write access to the Soldier, Documents and Next Action pages.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Create ADOP";
            newRow["Description"] = "Permits the user to initiate the creation of an ADOP in association with the status owned.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View ADOP Cases";
            newRow["Description"] = "Permits the user to search for and view ADOP cases";
            newRow["AccessMod"] = "D";
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
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "DEMOB/WTU Station Report";
            newRow["Description"] = "Permits users to run a report for DEMOB and/or WTU LODs.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Ad-Hoc Report";
            newRow["Description"] = "Permits the user to run the LOD Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Match Report";
            newRow["Description"] = "Permits the user to query for LODs based solely on account access.";
            newRow["AccessMod"] = "D";
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
            newRow["Permission"] = "RCMC Finances Report";
            newRow["Description"] = "Permits users with the ability to review and compare RCMC case estimates and cost";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            return table;

        }

    }
}
