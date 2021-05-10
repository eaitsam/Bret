﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{
    public class DivRAdminDataTables
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
            newRow["Permission"] = "Admin Override";
            newRow["Description"] = "Permits the user to make administrative updates to cases";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Approve eMMPS Users";
            newRow["Description"] = "Permits the ability to approve new eMMPS user accounts";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Lookup MSC Progeny Tree";
            newRow["Description"] = "Allows the user to lookup the MSC regions progeny UIC Tree. ";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage eMMPS Permissions";
            newRow["Description"] = "Permits the ability to modify permissions for an eMMPS user";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage eMMPS Users";
            newRow["Description"] = "Permits the ability to modify access for an eMMPS user";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage Letterheads";
            newRow["Description"] = "Permits the user to Manage Letterheads on Memos";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage System Messages (eMMPS)";
            newRow["Description"] = "Permits the ability to Manage System Messages(eMMPS)";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage UIC Page";
            newRow["Description"] = "Allows the user to manage and approve UICs within a user's request on the Manage UIC Page.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Management Tools";
            newRow["Description"] = "Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. ";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Region Scope";
            newRow["Description"] = "Permits the user to have Region Level Access in eMMPS";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "View Invalid LOD Log";
            newRow["Description"] = "Permits users to review an audit trail of invalid LOD creation attempts";
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
            newRow["Permission"] = "Delete LOD Cases";
            newRow["Description"] = "Permits the user to delete LODs";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "DIV(R) Approval LOD Review";
            newRow["Description"] = "Permits the user to own a specific LOD status in Army Reserve Workflows.The status permits the user to approve LODs.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "DIV(R) LOD Review";
            newRow["Description"] = "Permits the user to own a specific DIV(R) Administrative status in Army Reserve LOD workflow";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Draft (AR)";
            newRow["Description"] = "Permits the user to own an initial Army Reserves LOD status";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Override Final LOD Status";
            newRow["Description"] = "Permits the user to override closed (approved/denied) LODs within the Compo or Compo-Region scope of the user.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Override LOD";
            newRow["Description"] = "Permits the user to change the status of a LOD within the scope of the user.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Override Unrestricted LOD";
            newRow["Description"] = "Permits the user to change the status of Unrestricted LOD within the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Restore LOD (Restore Deleted LOD)";
            newRow["Description"] = "Permits the user to restore deleted LODs within the scope of the user.";
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
            newRow["Permission"] = "View Deleted Unrestricted Assault LOD cases";
            newRow["Description"] = "Permits the user to view deleted Unrestricted Assault LOD cases.";
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
            newRow["Permission"] = "Create an INCAP";
            newRow["Description"] = "Permits the user to create an INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Create an INCAP Appeal";
            newRow["Description"] = "Permits the user to create an INCAP Appeal.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Create an INCAP Extension";
            newRow["Description"] = "Permits the user to create an INCAP Appeal.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "DIV(R) Approval INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to own two INCAP statuses and finalize an INCAP.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "DIV(R) INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to own two INCAP statuses and review INCAPs, Extensions & Appeals.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "In Progress (AR)";
            newRow["Description"] = "Permits the user to own the initial INCAP status.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "INCAP Appeal Draft (AR)";
            newRow["Description"] = "Permits the user to own the initial INCAP Appeal status.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "INCAP Draft (AR)";
            newRow["Description"] = "Permits the user to own the initial INCAP Extension status.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Override INCAP";
            newRow["Description"] = "Permits the user to override, delete and restore INCAPs.";
            newRow["AccessMod"] = "E";
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
            newRow["Permission"] = "Create PDHRA";
            newRow["Description"] = "Permits the user to initiate the creation of an PDHRA Referrals";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Delete and Restore PDHRA";
            newRow["Description"] = "Permits the user to delete and restore deleted PDHRAs within the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "DIV(R) PDHRA Manager Review";
            newRow["Description"] = "Permits the user to own a specific status in the PDHRA workflow.The user will be able to approve the PDHRA Referrals and will be able to assign an Alternative DIV(R) and the UIC assigned to the PDHRA.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Override PDHRA";
            newRow["Description"] = "Permits the user to move/change a PDHRA from one status to another status within the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "PDHRA Final Status Override";
            newRow["Description"] = "Permits the user to override closed(approved/denied) PDHRA Referrals status within the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View PDHRA Referrals";
            newRow["Description"] = "Permits the user to search and view an PDHRA Referrals";
            newRow["AccessMod"] = "D";
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
            newRow["Permission"] = "MMSO Draft (AR)";
            newRow["Description"] = "Permits the user to own an initial MMSO status.This status permits the user to access the Forms and Documents tab.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "MMSO Pre-Auth Override";
            newRow["Description"] = "Permits the user to change the status of MMSO Pre-Authorization within the scope of the user.";
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
            newRow["Permission"] = "Access ADOP Board Tab";
            newRow["Description"] = "Permits the user to access the ADOP Board tab for the ADME/MRP-2 Workflows";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "ADOP Clinical Review";
            newRow["Description"] = "Permits full-access to the Army Reserve ADOP Clinical Review status ";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "ADOP Draft (AR) & Disapproved Case";
            newRow["Description"] = "Permits full-access to the Army Reserve ADOP Draft & Disapproved Case statuses";
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
            newRow["Permission"] = "ADOP USAR Draft (AR)";
            newRow["Description"] = "Permits users to own an initial ADOP status in the AR SRU workflow.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Create ADOP";
            newRow["Description"] = "Permits the user to initiate the creation of an ADOP in association with the status owned.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Delete & Restore Deleted ADOP";
            newRow["Description"] = "PPermits the user to delete and restore deleted ADOPs within the scope of the user.";
            newRow["AccessMod"] = "E";
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

            newRow = table.NewRow();
            newRow["Permission"] = "WT Specialist Statuses";
            newRow["Description"] = "Permits full-access to the Army Reserve WT Specialist statuses";
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
            newRow["Permission"] = "ADOP Reports > Behavioral Health";
            newRow["Description"] = "Permits the user to run ADOP Reports for Behavior Health ADOP cases";
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
