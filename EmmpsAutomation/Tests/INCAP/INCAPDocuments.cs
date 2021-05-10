using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.Tests.INCAP
{
    public class INCAPDocuments
    {
//		@mytag
//Scenario Outline: Document category validation 1/2
//	Given I am Logged in as <Role> using EDIPIN<PIN>
//	And I have created an LOD with SSN<SSN>
//	And I have navigated to<tabName> tab in <moduleName>
//	When I have Started the most recent INCAP case after searching for <searchCriteria>
//	And I have added a period from<startDate> to <endDate> and navigated to the Documents tab
//	Then the correct Document categories appear
//	And categories add files correctly
//	Then categories have the correct old file permissions

//Scenarios:
//| Role           | PIN        | SSN       | tabName     | moduleName | searchCriteria | startDate | endDate  |
//| State Admin MD | 8880070113 | 000342443 | Start INCAP | eMMPS      | 000342443      | 20190701  | 20190831 |


//Scenario Outline: Document category validation 2/2
//	Given I am Logged in as <Role> using EDIPIN <PIN>
//	And I have navigated to "My INCAPs" tab in "eMMPS"
//	When I sort with status<status 1> and select a case
//	And I select the Documents tab
//	Then the Documents tab is correct
//	Given I have navigated to "My INCAPs" tab in "eMMPS"
//	When I sort with status<status 2> and select a case
//	And I select the Documents tab
//	Then the Documents tab is correct
//	Given I have navigated to "My INCAP Enxtensions" tab in "eMMPS"
//	When I sort with status<status 3> and select a case in Extensions
//   And I select the Documents tab
//   Then the Documents tab is correct
//# Given I have navigated to "My INCAP Enxtensions" tab in "eMMPS"
//# When I sort with status <status 4> and select a case in Extensions
//# And I select the Documents tab
//# Then the Documents tab is correct

//Scenarios:
//| Role            | PIN        | status 1                                 | status 2                                 | status 3                            | status 4                                   |
//| State JAG       | 8880070011 | State JAG INCAP Review(NG)              | State JAG INCAP Appeal Review(NG)       | State JAG INCAP Ext Review(NG)     | State JAG INCAP Ext Appeal Review(NG)     |
//| State Surgeon   | 8880070012 | State Surgeon INCAP Review(NG)          | State Surgeon INCAP Appeal Review(NG)   | State Surgeon INCAP Ext Review(NG) | State Surgeon INCAP Ext Appeal Review(NG) |
//| State Approval  | 8880070014 | State Approval INCAP Review(NG)         | State Approval INCAP Appeal Review(NG)  | Ext Review                          | Ext Appeal Review                          |
//| NGB Reviewer    | 8880070019 | NGB Rebuttal Review(NG)                 | NGB INCAP Appeal Review(NG)             | NGB INCAP Ext Review(NG)           | NGB Ext Appeal Review                      |
//| NGB Surgeon     | 8880070517 | NGB Surgeon Rebuttal Review(NG)         | NGB Surgeon INCAP Appeal Review(NG)     | NGB Surgeon Ext Review(NG)         | NGB Surgeon Ext Appeal Review(NG)         |
//| ARNG Manager    | 8880070594 | NGB Approval Rebuttal Review(NG)        | NGB Approval INCAP Appeal Review(NG)    | NGB Approval Ext Review(NG)        | NGB Approval Ext Appeal Review(NG)        |
//| DA G-1 Approval | 8880070549 | DA G-1 Approval INCAP Appeal Review(AR) | DA G-1 Approval INCAP Appeal Review(NG) | DA G-1 Approval Ext Review(NG)     | DA G-1 Ext Appeal Review(NG)              |
    }
}
