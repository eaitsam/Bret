using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{
    public class NGStateAdminDataTable
    {

        //	And the Permissions for "LOD" are correct for State Admin in NG
        //	| Permission                                  | Description                                                                                                                    | Access Modifier |
        //	| Create ARNG and USAR LOD                    | Permits the user to create a LODs                                                                                              | D               |
        //	| Create ARNG and USAR LOD Appeal             | Permits the user to create LOD Appeals                                                                                         | D               |
        //	| Delete LOD Cases                            | Permits the user to delete LODs                                                                                                | E               |
        //	| LOD Appeal Draft(NG)                       | Permits the user to own an initial National Guard LOD Appeal status                                                            | D               |
        //	| LOD Draft(NG)                              | Permits the user to own an initial National Guard LOD status                                                                   | D               |
        //	| NLD(NG)                                    | Permits the user to access cases with a NLD and initiate an Appeal.                                                            | D               |
        //	| Override LOD                                | Permits the user to change the status of a LOD within the scope of the user.                                                   | E               |
        //	| Restore LOD (Restore Deleted LOD)           | Permits the user to restore deleted LODs within the scope of the user.                                                         | E               |
        //	| Search/View Death LODs                      | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs                            | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs               | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| State Admin LOD Review                      | Permits the user to own a specific National Guard 'State' Administrative LOD status.                                           | D               |
        //	| View Deleted LOD                            | Permits the user to view LODs that have been deleted.                                                                          | E               |
        //	| View Deleted Unrestricted Assault LOD cases | Permits the user to view deleted Unrestricted Assault LOD cases.                                                               | E               |
        //	| Write Tracking Comment - LOD                | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |


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
            newRow["Permission"] = "Create ARNG and USAR LOD Appeal";
            newRow["Description"] = "Permits the user to create a LODs";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Delete LOD Cases";
            newRow["Description"] = "Permits the user to delete LODs";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Appeal Draft(NG)";
            newRow["Description"] = "Permits the user to own an initial National Guard LOD Appeal status";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Draft(NG)";
            newRow["Description"] = "Permits the user to access cases with a NLD and initiate an Appeal.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "NLD(NG)";
            newRow["Description"] = "Permits the user to search for and view Death LODs";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Override LOD";
            newRow["Description"] = "Permits the user to change the status of a LOD within the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Restore LOD (Restore Deleted LOD)";
            newRow["Description"] = "Permits the user to restore deleted LODs within the scope of the user.";
            newRow["AccessMod"] = "E";
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
            newRow["Permission"] = "State Admin LOD Review";
            newRow["Description"] = "Permits the user to own a specific National Guard 'State' Administrative LOD status.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "View Deleted LOD";
            newRow["Description"] = "Permits the user to view LODs that have been deleted.";
            newRow["AccessMod"] = "E";
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


        //	And the Permissions for "MMSO" are correct for State Admin in NG
        //	| Permission                          | Description                                                                                                                                                | Access Modifier |
        //	| Create MMSO Pre-Auth                | Permits the user to create MMSO Pre-Authroization cases.                                                                                                   | D               |
        //	| Delete and Restore MMSO             | Permits the user to delete and restore deleted MMSO cases within the scope of the user.                                                                    | D               |
        //	| MMSO Draft (NG)                     | Permits the user to own an initial MMSO status.This status permits the user to access the Forms and Documents tab.                                        | D               |
        //	| Search/View MMSO Pre-Authorizations | Permits the user to search and view MMSO Pre-Authorization cases.                                                                                          | D               |
        //	| State Admin MMSO Review             | Permits the user to own a specific MMSO status in the MMSO Pre-Authorization workflow. This status permits the user to access the Forms and Documents tab. | D               |
        //	| Write Tracking Comment - MMSO       | Permits users with the ability to input a comment on the MMSO tracking tab when the case is outside users statuses of ownership                            | E               |

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
            newRow["Description"] = "Permits the user to own an initial MMSO status.This status permits the user to access the Forms and Documents tab.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View MMSO Pre-Authorizations";
            newRow["Description"] = "Permits the user to search and view MMSO Pre-Authorization cases.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "State Admin MMSO Review";
            newRow["Description"] = " Permits the user to own a specific MMSO status in the MMSO Pre-Authorization workflow. This status permits the user to access the Forms and Documents tab.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - MMSO";
            newRow["Description"] = "Permits users with the ability to input a comment on the MMSO tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "INCAP" are correct for State Admin in NG
        //	| Permission                     | Description                                                                                                                      | Access Modifier |
        //	| Create an INCAP                | Permits the user to create an INCAP.                                                                                             | D               |
        //	| Create an INCAP Appeal         | Permits the user to create an INCAP Appeal.                                                                                      | D               |
        //	| Create an INCAP Extension      | Permits the user to create an INCAP Extension.                                                                                   | D               |
        //	| In Progress (NG)               | Permits the user to own the initial INCAP status.                                                                                | D               |
        //	| INCAP Appeal Draft (NG)        | Permits the user to own the initial INCAP Appeal status.                                                                         | D               |
        //	| INCAP Draft (NG)               | Permits the user to own the initial INCAP Extension status.                                                                      | D               |
        //	| Override INCAP                 | Permits the user to override, delete and restore INCAPs.                                                                         | D               |
        //	| Search/View an INCAP           | Permits the user to search and view INCAP.                                                                                       | D               |
        //	| Write Tracking Comment - INCAP | Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership | E               |

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
            newRow["Permission"] = " Create an INCAP";
            newRow["Description"] = "Permits the user to create an INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Create an INCAP Appeal";
            newRow["Description"] = "Permits the user to create an INCAP Appeal.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Create an INCAP Extension";
            newRow["Description"] = "Permits the user to create an INCAP Extension.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "In Progress (NG)";
            newRow["Description"] = "Permits the user to own the initial INCAP status.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "INCAP Appeal Draft (NG)";
            newRow["Description"] = "Permits the user to own the initial INCAP Appeal status.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "INCAP Draft (NG)";
            newRow["Description"] = "Permits the user to own the initial INCAP Extension status.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Override INCAP";
            newRow["Description"] = "Permits the user to override, delete and restore INCAPs.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View an INCAP ";
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

        //	And the Permissions for "PDHRA" are correct for State Admin in NG
        //	| Permission                     | Description                                                                                                                      | Access Modifier |
        //	| Search/View PDHRA Referrals    | Permits the user to search and view an PDHRA Referrals                                                                           | E               |
        //	| Write Tracking Comment - PDHRA | Permits users with the ability to input a comment on the PDHRA tracking tab when the case is outside users statuses of ownership | E               |
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

            table.Rows.Add(newRow);
            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - PDHRA";
            newRow["Description"] = "Permits users with the ability to input a comment on the PDHRA tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "ADOP" are correct for State Admin in NG
        //	| Permission                    | Description                                                                                                                                                                                                | Access Modifier |
        //	| ADOP Draft (NG)               | Permits the user to own a specific ADOP status that falls in one or more workflows. The user will be able to initiate an ADOP case have read/write access to the Soldier, Documents and Next Action pages. | D               |
        //	| ADOP Override                 | Permits the user to move/change a ADOP from one status to another status with the scope of the user.                                                                                                       | E               |
        //	| Create ADOP                   | Permits the user to initiate the creation of an ADOP in association with the status owned.                                                                                                                 | D               |
        //	| Delete & Restore Deleted ADOP | Permits the user to delete and restore deleted ADOPs within the scope of the user.                                                                                                                         | E               |
        //	| Search/View ADOP Cases        | Permits the user to search for and view ADOP cases                                                                                                                                                         | D               |
        //	| State Admin ADOP Statuses     | Permits full-access to the National Guard State Admin ADOP statuses                                                                                                                                        | D               |
        //	| Write Tracking Comment - ADOP | Permits users with the ability to input a comment on the ADOP tracking tab when the case is outside users statuses of ownership                                                                            | E               |

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
            newRow["Description"] = " Permits the user to own a specific ADOP status that falls in one or more workflows. The user will be able to initiate an ADOP case have read/write access to the Soldier, Documents and Next Action pages.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "ADOP Override";
            newRow["Description"] = "Permits the user to move/change a ADOP from one status to another status with the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Create ADOP";
            newRow["Description"] = "Permits the user to initiate the creation of an ADOP in association with the status owned.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);


            newRow = table.NewRow();
            newRow["Permission"] = " Delete & Restore Deleted ADOP";
            newRow["Description"] = "Permits the user to delete and restore deleted ADOPs within the scope of the user.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View ADOP Cases";
            newRow["Description"] = "Permits the user to search for and view ADOP cases";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "State Admin ADOP Statuses";
            newRow["Description"] = "Permits full-access to the Army Reserve ADOP Clinical Review status ";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - ADOP";
            newRow["Description"] = "Permits users with the ability to input a comment on the ADOP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "Reports" are correct for State Admin in NG
        //	| Permission                                      | Description                                                                                                                       | Access Modifier |
        //	| ADOP Ad-Hoc Report                              | Permits the user to run the ADOP Ad-Hoc Report. Results vary depending on the scope of the user.                                  | D               |
        //	| ADOP Reports > Behavioral Health                | Permits the user to run ADOP Reports for Behavior Health ADOP cases                                                               | D               |
        //	| DEMOB/WTU Station Report                        | Permits users to run a report for DEMOB and/or WTU LODs.                                                                          | E               |
        //	| INCAP Ad-Hoc Report                             | Permits the user to run the INCAP Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user.   | D               |
        //	| LOD Ad-Hoc Report                               | Permits the user to run the LOD Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user.     | D               |
        //	| LOD Match Report                                | Permits the user to query for LODs based solely on account access.                                                                | D               |
        //	| MMSO Report                                     | Permits the user to run the MMSO Report. The report displays all MMSO Pre-Authorizations and their corresponding LOD information. | D               |
        //	| Module Search                                   | Permits the user to search for all Sub-Module items in the eMMPS application related a Service Member.                            | E               |
        //	| NG Overdue LOD Report Dashboard                 | Permits the user to run the Overdue LOD Completion Report and the Overdue LOD Report for the National Guard                       | D               |
        //	| RCMC Finances Report                            | Permits users with the ability to review and compare RCMC case estimates and cost                                                 | D               |
        //	| View ARNG LOD Activity (Grid within User Scope) | Permits the user to view all active ARNG Informal, Formal and Overdue LODs within the scope of their user role.                   | D               |

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
            newRow["Description"] = "Permits the user to run ADOP Reports for Behavior Health ADOP cases.";
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
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "RCMC Finances Report";
            newRow["Description"] = "Permits users with the ability to review and compare RCMC case estimates and cost";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " View ARNG LOD Activity (Grid within User Scope)";
            newRow["Description"] = "Permits the user to view all active ARNG Informal, Formal and Overdue LODs within the scope of their user role.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "eMMPS Administration" are correct for State Admin in NG
        //	| Permission                     | Description                                                                                              | Access Modifier |
        //	| Approve eMMPS Users            | Permits the ability to approve new eMMPS user accounts                                                   | D               |
        //	| Manage eMMPS Permissions       | Permits the ability to modify permissions for an eMMPS user                                              | D               |
        //	| Manage eMMPS Users             | Permits the ability to modify access for an eMMPS user                                                   | D               |
        //	| Manage Letterheads             | Permits the user to Manage Letterheads on Memos                                                          | E               |
        //	| Manage System Messages(eMMPS) | Permits the ability to Manage System Messages(eMMPS)                                                    | E               |
        //	| Manage UIC Page                | Allows the user to manage and approve UICs within a user's request on the Manage UIC Page.               | D               |
        //	| Management Tools               | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Region Scope                   | Permits the user to have Region Level Access in eMMPS                                                    | D               |
        //	| View Invalid LOD Log           | Permits users to review an audit trail of invalid LOD creation attempts                                  | E               |

        public DataTable eMMPSAdministrationPerms()
        {
            DataTable table = new DataTable("Reports");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Approve eMMPS Users ";
            newRow["Description"] = "Permits the ability to approve new eMMPS user accounts";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage eMMPS Permissions";
            newRow["Description"] = "Permits the ability to modify permissions for an eMMPS user.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Manage eMMPS Users ";
            newRow["Description"] = "Permits the ability to modify access for an eMMPS user";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage Letterheads";
            newRow["Description"] = "Permits the user to Manage Letterheads on Memos";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage System Messages(eMMPS)";
            newRow["Description"] = "Permits the ability to Manage System Messages(eMMPS)";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Manage UIC Page ";
            newRow["Description"] = "Allows the user to manage and approve UICs within a user's request on the Manage UIC Page.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Management Tools";
            newRow["Description"] = "Permits the user to access Management Tools designed for user managed functionality of the eMMPS module.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Region Scope";
            newRow["Description"] = "Permits the user to have Region Level Access in eMMPS";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "View Invalid LOD Log ";
            newRow["Description"] = " Permits users to review an audit trail of invalid LOD creation attempts";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }



    }
}


