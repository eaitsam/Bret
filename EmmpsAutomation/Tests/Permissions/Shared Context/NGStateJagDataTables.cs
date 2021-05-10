using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.Permissions.Shared_Context
{
    //@Case46204
    //Scenario: EMMPS My Account Permissions - NG State JAG
    //	Given I am Logged in as "State JAG" using EDIPIN 8880070311
    //	When I select the My Account Page Link in the MEDCHART tile
    //	Then my Module Access Details should be correct for my "State JAG" role
    //	| Tabs                            |
    //	| eMMPS Administration, LOD, INCAP, PDHRA, MMSO, Reports |

    class NGStateJagDataTables
    {

        //	And the Permissions for "LOD" are correct for State JAG in NG
        //	| Permission                    | Description                                                                                                                    | Access Modifier |
        //	| Search/View Death LODs        | Permits the user to search for and view Death LODs                                                                             | D               |
        //	| Search/View LODs              | Permits the user to search for and view LODs and LOD Appeals                                                                   | D               |
        //	| Search/View Unrestricted LODs | Permits the user to search for and view Unrestricted LODs                                                                      | E               |
        //	| State JAG LOD & Appeal Review | Permits the user to own two National Guard 'State' LOD statuses.The status permits the user to provide Legal Opinions         | D               |
        //	| Write Tracking Comment - LOD  | Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership | E               |
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
            newRow["Permission"] = " Search/View Death LODs";
            newRow["Description"] = "Permits the user to search for and view Death LODs";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search/View LODs";
            newRow["Description"] = "Permits the user to search for and view LODs and LOD Appeals";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Search / View Unrestricted LODs";
            newRow["Description"] = "Permits the user to search for and view Unrestricted LODs";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "State JAG LOD & Appeal Review";
            newRow["Description"] = "Permits the user to own two National Guard 'State' LOD statuses.The status permits the user to provide Legal Opinions";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Write Tracking Comment - LOD";
            newRow["Description"] = "Permits users with the ability to input a comment on the LOD tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "MMSO" are correct for State JAG in NG
        //	| Permission                          | Description                                                                                                                     | Access Modifier |
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
            newRow["Permission"] = " Search/View MMSO Pre-Authorizations";
            newRow["Description"] = "Permits the user to search and view MMSO Pre-Authorization cases.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Write Tracking Comment - MMSO";
            newRow["Description"] = " Permits users with the ability to input a comment on the MMSO tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "INCAP" are correct for State JAG in NG
        //	| Permission                      | Description                                                                                                                      | Access Modifier |
        //	| Search/View an INCAP            | Permits the user to search and view INCAP.                                                                                       | D               |
        //	| State JAG INCAP & Appeal Review | Permits the user to review INCAPs and provide a legal opinion.                                                                   | D               |
        //	| Write Tracking Comment - INCAP  | Permits users with the ability to input a comment on the INCAP tracking tab when the case is outside users statuses of ownership | E               |

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
            newRow["Permission"] = "Search/View an INCAP";
            newRow["Description"] = " Permits the user to search and view INCAP.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "State JAG INCAP & Appeal Review";
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


        //	And the Permissions for "PDHRA" are correct for State JAG in NG
        //	| Permission                     | Description                                                                                                                      | Access Modifier |
        //	| Search/View PDHRA Referrals    | Permits the user to search and view an PDHRA Referrals                                                                           | E               |
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
            newRow["Permission"] = "Search/View PDHRA Referrals";
            newRow["Description"] = "Permits the user to search and view an PDHRA Referrals";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = " Write Tracking Comment - PDHRA";
            newRow["Description"] = "Permits users with the ability to input a comment on the PDHRA tracking tab when the case is outside users statuses of ownership";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "Reports" are correct for State JAG in NG
        //	| Permission                                      | Description                                                                                                                   | Access Modifier |
        //	| DEMOB/WTU Station Report                        | Permits users to run a report for DEMOB and/or WTU LODs.                                                                      | E               |
        //	| LOD Ad-Hoc Report                               | Permits the user to run the LOD Ad-Hoc Report. The results of the user's search will vary depending on the scope of the user. | D               |
        //	| LOD Match Report                                | Permits the user to query for LODs based solely on account access.                                                            | D               |
        //	| Module Search                                   | Permits the user to search for all Sub-Module items in the eMMPS application related a Service Member.                        | E               |
        //	| View ARNG LOD Activity (Grid within User Scope) | Permits the user to view all active ARNG Informal, Formal and Overdue LODs within the scope of their user role.               | D               |

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
            newRow["Permission"] = "DEMOB/WTU Station Report";
            newRow["Description"] = "Permits users to run a report for DEMOB and/or WTU LODs.";
            newRow["AccessMod"] = "E";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "LOD Ad-Hoc Report ";
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
            newRow["Permission"] = "View ARNG LOD Activity (Grid within User Scope)";
            newRow["Description"] = "Permits the user to view all active ARNG Informal, Formal and Overdue LODs within the scope of their user role.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            return table;
        }

        //	And the Permissions for "eMMPS Administration" are correct for State JAG in NG
        //	| Permission       | Description                                                                                              | Access Modifier |
        //	| Management Tools | Permits the user to access Management Tools designed for user managed functionality of the eMMPS module. | D               |
        //	| Region Scope     | Permits the user to have Region Level Access in eMMPS                                                    | D               |

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
            newRow["Permission"] = "Management Tools";
            newRow["Description"] = "Permits the user to access Management Tools designed for user managed functionality of the eMMPS module.";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            newRow = table.NewRow();
            newRow["Permission"] = "Region Scope";
            newRow["Description"] = "Permits the user to have Region Level Access in eMMPS";
            newRow["AccessMod"] = "D";
            table.Rows.Add(newRow);

            return table;
        }

    }
}



