using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{
    class CrossComHRCReviewerDataTable
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
            newRow["Permission"] = "Global Scope";
            newRow["Description"] = "Permits the user to have Global Level Access in eMMPS";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Lookup MSC Progeny Tree";
            newRow["Description"] = "Allows the user to lookup the MSC regions progeny UIC Tree.";
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
            newRow = table.NewRow();
            newRow["Permission"] = "ARNG NLD Email Notification";
            newRow["Description"] = "This permission enables users to receive an automated email notification when ARNG LODs that have been adjudicated as NLD.";
            newRow["AccessMod"] = "E";

            newRow = table.NewRow();
            newRow["Permission"] = "HRC Admin LOD Review (NG)";
            newRow["Description"] = "Permits the user to own a specific HRC status in the Army Reserve LOD Appeal workflow.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "HRC Admin LOD Appeal Review(AR)";
            newRow["Description"] = "Permits the user to own a specific HRC status in the Army Reserve LOD Appeal workflow. The status permits the user to approve LOD Appeals.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "HRC Admin LOD Appeal Review (NG)";
            newRow["Description"] = "Permits the user to own a specific HRC status in the National Guard LOD Appeal workflow. The status permits the user to review LOD Appeals.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "HRC Admin LOD Review (AR)";
            newRow["Description"] = "Permits the user to own a specific HRC status in the Army Reserve LOD workflow.The status permits the user to review Death LODs";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "HRC Admin LOD Review (NG)";
            newRow["Description"] = "Permits the user to own a specific HRC status in the National Guard LOD workflow.The status permits the user to review Death LODs";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);


            newRow = table.NewRow();
            newRow["Permission"] = "HRC LOD Compliance Review (AR)";
            newRow["Description"] = "Permits the user access to review USARC NLD determinations.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View Death LODs";
            newRow["Description"] = "Permits the user to search for and view Death LODs";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View LODs";
            newRow["Description"] = "Permits the user to search for and view LODs and LOD Appeals";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - LOD";
            newRow["Description"] = "Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership";
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
            newRow["Permission"] = "AR Overdue LOD Report Dashboard";
            newRow["Description"] = "Permits the user to run the Overdue LOD Completion Report and the Overdue LOD Report for the Army Reserve.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Ad-Hoc Report";
            newRow["Description"] = "Permits the user to run the LOD Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user.";
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
            newRow["Permission"] = "Static - LODs Processed by All DIV(R) Roles";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed by All DIV(R) Roles";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Static - LODs Processed by All NGB Roles";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed By All NGB Roles";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Static - LODs Processed By DIV(R) Admin";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed by DIV(R) Admin";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Static - LODs Processed By NGB Reviewer";
            newRow["Description"] = "Permits the user to run Static LOD Reports for LODs Processed By NGB Reviewer (formally NGB Admin/Analyst)";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "View ARNG LOD Activity(Grid within User Scope)";
            newRow["Description"] = "Permits the user to view all active ARNG Informal, Formal and Overdue LODs within the scope of their user role.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "View USAR LOD Activity(Grid within User Scope)";
            newRow["Description"] = "Permits the user to view all active USAR Informal, Formal and Overdue LODs within the scope of their user role.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            return table;
        }


    }
}
