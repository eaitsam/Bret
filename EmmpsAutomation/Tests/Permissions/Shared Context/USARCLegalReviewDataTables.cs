﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{
    public class USARCLegalReviewDataTables
    {
        //	| Tabs                            |
        //	| eMMPS Administration, LOD, INCAP, Reports |
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
            newRow["Permission"] = "Lookup MSC Progeny Tree";
            newRow["Description"] = "Allows the user to lookup the MSC regions progeny UIC Tree. ";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Management Tools";
            newRow["Description"] = "Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. ";
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

            newRow["Permission"] = "USARC LOD Legal & Appeal Legal Review";
            newRow["Description"] = "Permits the user to own an initial Army Reserves LOD status";
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
            newRow["Permission"] = "USARC INCAP Legal & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
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
            newRow["Permission"] = "AR Overdue LOD Report Dashboard";
            newRow["Description"] = "Permits the user to run the Overdue LOD Completion Report and the Overdue LOD Report for the Army Reserve.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "DEMOB/WTU Station Report";
            newRow["Description"] = "Permits users to run a report for DEMOB and/or WTU LODs.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "INCAP Ad-Hoc Report";
            newRow["Description"] = "Permits the user to run the INCAP Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user.";
            newRow["AccessMod"] = "D";
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
            newRow["Permission"] = "Static - LODs Processed by All DIV(R) Roles";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed by All DIV(R) Roles";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Static - LODs Processed By DIV(R) Admin";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed by DIV(R) Admin";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "View USAR LOD Activity (Grid within User Scope)";
            newRow["Description"] = "Permits the user to view all active USAR Informal, Formal and Overdue LODs within the scope of their user role.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            return table;

        }

    }
}
