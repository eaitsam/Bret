using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{

    //Scenario: EMMPS My Account Permissions - CrossCom Lead MMSO Reviewer
    //	Given I am Logged in as "Lead MMSO Reviewer" using EDIPIN 8880070047
    //	When I select the My Account Page Link in the MEDCHART tile
    //	Then my Module Access Details should be correct for my "Lead MMSO Reviewer" role
    //	| Tabs                                                  |
    //	| eMMPS Administration, LOD, MMSO, PDHRA, ADOP, Reports |

    class CrossComLeadMMSOReviewer
    {

        //	And the Permissions for "LOD" are correct for Lead MMSO Reviewer in CrossCom
        //	| Permission                                  | Description                                                                                                                    | Access Modifier |
        //	| Search/View Death LODs                      | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs                            | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Restricted LODs                 | Permits the user to search for and view Restricted LODs                                                                        | E               |
        //	| Search/View Unrestricted LODs               | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| View Deleted LOD                            | Permits the user to view LODs that have been deleted.                                                                          | E               |
        //	| View Deleted Restricted Assault LOD cases   | Permits the user to view deleted Restricted Assault LOD cases.                                                                 | E               |
        //	| View Deleted Unrestricted Assault LOD cases | Permits the user to view deleted Unrestricted Assault LOD cases.                                                               | E               |
        //	| Write Tracking Comment - LOD                | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |



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

        //	And the Permissions for "MMSO" are correct for Lead MMSO Reviewer in CrossCom
        //	| Permission                                     | Description                                                                                                                                                   | Access Modifier |
        //	| Delete and Restore MMSO                        | Permits the user to delete and restore deleted MMSO cases within the scope of the user.                                                                       | E               |
        //	| Delete and Restore Restricted MMSO             | Permits the user to delete and restore deleted restricted MMSO cases within the scope of the user.                                                            | E               |
        //	| MMSO Pre-Auth Final Status Override            | Permits the user to override closed (approved/denied) MMSO cases within the scope of the user.                                                                | E               |
        //	| MMSO Pre-Auth Override                         | Permits the user to change the status of MMSO Pre-Authorization within the scope of the user.                                                                 | E               |
        //	| MMSO SPOC (AR)                                 | Permits the user to own a specific status in the MMSO Pre-Authorization workflow. This status permits the user to review and approve MMSO Pre-Authorizations. | D               |
        //	| MMSO SPOC (NG)                                 | Permits the user to own a specific status in the MMSO Pre-Authorization workflow. This status permits the user to review and approve MMSO Pre-Authorizations. | D               |
        //	| Restricted MMSO Pre-Auth Final Status Override | Permits the user to override closed (approved/denied) restricted MMSO cases within the scope of the user                                                      | E               |
        //	| Restricted MMSO Pre-Auth Override              | Permits the user to change the status of Restricted MMSO Pre-Authorization within the scope of the user.                                                      | E               |
        //	| Search/View MMSO Pre-Authorizations            | Permits the user to search and view MMSO Pre-Authorization cases.                                                                                             | D               |
        //	| Search/View Restricted MMSO Pre-Authorizations | Permits the user to search and view MMSO Restricted Pre-Authorization cases.                                                                                  | D               |
        //	| Write Tracking Comment - MMSO                  | Permits users with the ability to input a comment on the MMSO tracking tab when the case is outside users statuses of ownership                               | E               |


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


        //	And the Permissions for "PDHRA" are correct for Lead MMSO Reviewer in CrossCom
        //	| Permission                     | Description                                                                                                                      | Access Modifier |
        //	| Search/View PDHRA Referrals    | Permits the user to search and view an PDHRA Referrals                                                                           | D               |
        //	| Write Tracking Comment - PDHRA | Permits users with the ability to input a comment on the PDHRA tracking tab when the case is outside users statuses of ownership | E               |


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

        //	And the Permissions for "ADOP" are correct for Lead MMSO Reviewer in CrossCom
        //	| Permission                    | Description                                                                                                                     | Access Modifier |
        //	| Access ADOP Board Tab         | Permits the user to access the ADOP Board tab for the ADME/MRP-2 Workflows                                                      | E               |
        //	| Search/View ADOP Cases        | Permits the user to search for and view ADOP cases                                                                              | D               |
        //	| Write Tracking Comment - ADOP | Permits users with the ability to input a comment on the ADOP tracking tab when the case is outside users statuses of ownership | E               |


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


            return table;
        }


        //	And the Permissions for "Reports" are correct for Lead MMSO Reviewer in CrossCom
        //	| Permission    | Description                                                                                                                       | Access Modifier |
        //	| MMSO Report   | Permits the user to run the MMSO Report. The report displays all MMSO Pre-Authorizations and their corresponding LOD information. | D               |
        //	| Module Search | Permits the user to search for all Sub-Module items in the eMMPS application related a Service Member.                            | E               |


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


            return table;
        }

        //	And the Permissions for "eMMPS Administration" are correct for Lead MMSO Reviewer in CrossCom
        //	| Permission               | Description                                                                                              | Access Modifier |
        //	| Approve eMMPS Users      | Permits the ability to approve new eMMPS user accounts                                                   | D               |
        //	| Global Scope             | Permits the user to have Global Level Access in eMMPS                                                    | D               |
        //	| Lookup MSC Progeny Tree  | Allows the user to lookup the MSC regions progeny UIC Tree.                                              | D               |
        //	| Manage eMMPS Permissions | Permits the ability to modify permissions for an eMMPS user                                              | D               |
        //	| Manage eMMPS Users       | Permits the ability to modify access for an eMMPS user                                                   | D               |
        //	| Management Tools         | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |



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


            return table;
        }

    }
}
