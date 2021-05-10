using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{

    //@Case46203
    //Scenario: EMMPS My Account Permissions - NG State Approval
    //	Given I am Logged in as "State Approval" using EDIPIN 8880070114
    //	When I select the My Account Page Link in the MEDCHART tile
    //	Then my Module Access Details should be correct for my "State Approval" role
    //	| Tabs                                                         |
    //	| eMMPS Administration, LOD, INCAP, PDHRA, MMSO, ADOP, Reports |

    class NGStateApproval
    {
        //	And the Permissions for "LOD" are correct for State Approval in NG
        //	| Permission                         | Description                                                                                                                    | Access Modifier |
        //	| Override LOD                       | Permits the user to change the status of a LOD within the scope of the user.                                                   | E               |
        //	| Search/View Death LODs             | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs                   | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs      | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| State Admin LOD Review             | Permits the user to own a specific National Guard 'State' Administrative LOD status.                                           | E               |
        //	| State Approval LOD & Appeal Review | Permits the user to own two National Guard 'State' LOD statuses. The status permits the user to approve 'State' LODs.          | D               |
        //	| State JAG LOD & Appeal Review      | Permits the user to own two National Guard 'State' LOD statuses. The status permits the user to provide Legal Opinions         | E               |
        //	| State Surgeon LOD & Appeal Review  | Permits the user to own two National Guard 'State' LOD statuses. The status permits the user to provide Medical Opinions       | E               |
        //	| Write Tracking Comment - LOD       | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |
        public DataTable LODPerms()
        {
            DataTable table = new DataTable("LOD");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Override LOD";
            newRow["Description"] = "Permits the user to change the status of a LOD within the scope of the user.";
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
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "State Approval LOD & Appeal Review";
            newRow["Description"] = "Permits the user to own two National Guard 'State' LOD statuses. The status permits the user to approve 'State' LODs.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " State JAG LOD & Appeal Review";
            newRow["Description"] = "Permits the user to own two National Guard 'State' LOD statuses. The status permits the user to provide Legal Opinions";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " State Surgeon LOD & Appeal Review";
            newRow["Description"] = "Permits the user to own two National Guard 'State' LOD statuses. The status permits the user to provide Medical Opinions";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Write Tracking Comment - LOD";
            newRow["Description"] = "Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);


            return table;
        }

        //	And the Permissions for "MMSO" are correct for State Approval in NG
        //	| Permission | Description | Access Modifier |
        //	| Search/View MMSO Pre-Authorizations | Permits the user to search and view MMSO Pre-Authorization cases.                                                               | D               |
        //	| Write Tracking Comment - MMSO       | Permits users with the ability to input a comment on the MMSO tracking tab when the case is outside users statuses of ownership | E               |


        public DataTable MMSOPerms()
        {
            DataTable table = new DataTable("LOD");
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

        //	And the Permissions for "INCAP" are correct for State Approval in NG
        //	| Permission                           | Description                                                                                                                      | Access Modifier |
        //	| In Progress (NG)                     | Permits the user to own the initial INCAP status.                                                                                | E               |
        //	| INCAP Appeal Draft (NG)              | Permits the user to own the initial INCAP Appeal status.                                                                         | E               |
        //	| INCAP Draft (NG)                     | Permits the user to own the initial INCAP Extension status.                                                                      | E               |
        //	| Search/View an INCAP                 | Permits the user to search and view INCAP.                                                                                       | D               |
        //	| State Approval INCAP & Appeal Review | Permits the user to own two INCAP statuses and finalize an INCAP.                                                                | D               |
        //	| Write Tracking Comment - INCAP       | Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership | E               |


        public DataTable INCAPPerms()
        {
            DataTable table = new DataTable("LOD");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "In Progress(NG)";
            newRow["Description"] = "Permits the user to own the initial INCAP status.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "INCAP Appeal Draft (NG)";
            newRow["Description"] = "Permits the user to own the initial INCAP Appeal status.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "INCAP Draft (NG)";
            newRow["Description"] = "Permits the user to own the initial INCAP Extension status.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View an INCAP";
            newRow["Description"] = "Permits the user to search and view INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "State Approval INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to own two INCAP statuses and finalize an INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "PDHRA" are correct for State Approval in NG
        //	| Permission                     | Description                                                                                                                                              | Access Modifier |
        //	| Search/View PDHRA Referrals    | Permits the user to search and view an PDHRA Referrals                                                                                                   | E               |
        //	| State PDHRA Manager Review     | Permits the user to own a specific status in the PDHRA workflow.The user will be able to assign an Alternative State and the UIC assigned to the PDHRA. | E               |
        //	| Write Tracking Comment - PDHRA | Permits users with the ability to input a comment on the PDHRA tracking tab when the case is outside users statuses of ownership                         | E               |


        public DataTable PDHRAPerms()
        {
            DataTable table = new DataTable("LOD");
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
            newRow["Permission"] = " State PDHRA Manager Review";
            newRow["Description"] = "Permits the user to own a specific status in the PDHRA workflow.The user will be able to assign an Alternative State and the UIC assigned to the PDHRA.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Write Tracking Comment - PDHRA";
            newRow["Description"] = "Permits users with the ability to input a comment on the PDHRA tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);


            return table;
        }

        //	And the Permissions for "ADOP" are correct for State Approval in NG
        //	| Permission                    | Description                                                                                                                                                                                                | Access Modifier |
        //	| ADOP Draft (NG)               | Permits the user to own a specific ADOP status that falls in one or more workflows. The user will be able to initiate an ADOP case have read/write access to the Soldier, Documents and Next Action pages. | E               |
        //	| Search/View ADOP Cases        | Permits the user to search for and view ADOP cases                                                                                                                                                         | D               |
        //	| State Admin ADOP Statuses     | Permits full-access to the National Guard State Admin ADOP statuses                                                                                                                                        | E               |
        //	| State Approval ADOP Statuses  | Permits full-access to the National Guard State Surgeon statuses                                                                                                                                           | D               |
        //	| State Surgeon ADOP Statuses   | Permits the user to own multiple ADOP statuses that fall in one or more workflows. The user will be have read/write access to the Documents and Next Action page.                                          | E               |
        //	| Write Tracking Comment - ADOP | Permits users with the ability to input a comment on the ADOP tracking tab when the case is outside users statuses of ownership                                                                            | E               |


        public DataTable ADOPPerms()
        {
            DataTable table = new DataTable("LOD");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Search/View an INCAP";
            newRow["Description"] = " Permits the user to search and view INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Search/View an INCAP";
            newRow["Description"] = " Permits the user to search and view INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);



            return table;
        }


        //	And the Permissions for "Reports" are correct for State Approval in NG
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
            DataTable table = new DataTable("LOD");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Search/View an INCAP";
            newRow["Description"] = " Permits the user to search and view INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);


            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);



            return table;
        }

        //	And the Permissions for "eMMPS Administration" are correct for State Approval in NG
        //	| Permission | Description | Access Modifier |
        //	| Approve eMMPS Users            | Permits the ability to approve new eMMPS user accounts                                                   | D               |
        //	| Manage eMMPS Permissions       | Permits the ability to modify permissions for an eMMPS user                                              | D               |
        //	| Manage eMMPS Users             | Permits the ability to modify access for an eMMPS user                                                   | D               |
        //	| Manage Letterheads             | Permits the user to Manage Letterheads on Memos                                                          | E               |
        //	| Manage System Messages(eMMPS) | Permits the ability to Manage System Messages(eMMPS)                                                    | E               |
        //	| Manage UIC Page                | Allows the user to manage and approve UICs within a user's request on the Manage UIC Page.               | D               |
        //	| Management Tools               | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Region Scope                   | Permits the user to have Region Level Access in eMMPS                                                    | D               |

        public DataTable eMMPSAdministrationPerms()
        {
            DataTable table = new DataTable("LOD");
            DataColumn perm = new DataColumn("Permission", typeof(string));
            DataColumn descriptColumn = new DataColumn("Description", typeof(string));
            DataColumn accessMod = new DataColumn("AccessMod", typeof(string));

            table.Columns.Add(perm);
            table.Columns.Add(descriptColumn);
            table.Columns.Add(accessMod);

            DataRow newRow = table.NewRow();
            newRow["Permission"] = "Search/View an INCAP";
            newRow["Description"] = " Permits the user to search and view INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);
            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "State JAG INCAP & Appeal Review";
            newRow["Description"] = "Permits the user to review INCAPs and provide a legal opinion.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow["Permission"] = "Write Tracking Comment - INCAP";
            newRow["Description"] = "Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);





            return table;
        }


    }
}


