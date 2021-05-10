using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.Medchart_Logging
{
    public class AuditLog
    {


//# General Audit Log Functions
//# Test Script 24917
//		@AuditLog
//		Scenario Outline: View Audit Log - Search Audit Log
//			Given I am Logged in as "Sys Admin" using EDIPIN 9990001100
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search by<Search Value> in the<Field> in the Audit Log
//	Then all the Logs with that<Search Value> in <Field> should appear in the Audit Log results

//	Scenarios: 
//	| Search Value | Field            |
//	| john         | First Name Field |
//	| peach        | Last Name Field  |
//	| 123456789    | SSN Field        |
//	| Virginia     | Region Field     |
//	| 8880061222   | EDIPIN Field     |


//Scenario: View Audit Log - Date Range To-From Search
//	Given I am Logged in as "Sys Admin" using EDIPIN 9990001100
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I input dates of "2019-01-02 00:00" and "2019-01-02 23:00" in the Range From field and Range To field in the Audit Log
//	Then the Logs in the range of "2019-01-02 00:00" and "2019-01-02 23:00" should appear in the Audit Log results

//Scenario Outline: View Audit Log - Search Input Validation
//	Given I am Logged in as "Sys Admin" using EDIPIN 9990001100
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I input a<Invalid Data Type> of<Data> with the<Data Error>
//	Then a validation message will display regarding the<Data Error> of <Data>

//	Scenarios: 
//	| Invalid Data Type  | Data   | Data Field       | Data Error                     |
//	| Invalid Date Range | Date   | Range From Field | Future Date                    |
//	| Invalid Date Range | Date   | Range To Field   | Past Date                      |
//	| Invalid SSN        | SSN    | SSN Field        | Incorrect SSN Character Count  |
//	| Invalid SSN        | SSN    | SSN Field        | Alphanumeric SSN               |
//	| Recordless Region  | Region | Region Field     | No Records for Region          |
//	| Invalid EDIPIN     | EDIPIN | EDIPIN Field     | Invalid EDIPIN Character Count |
//	| Invalid EDIPIN     | EDIPIN | EDIPIN Field     | Alphanumeric EDIPIN            |

//Scenario: View Audit Log - Search Reset Button
//	Given I am Logged in as "Sys Admin" using EDIPIN 9990001100
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search by "Peach" in the "Last Name Field" in the Audit Log
//	And I click the Reset Button
//	Then the Audit Log Results will be cleared

//Scenario: View Audit Log - View Sys Admin Events
//	Given I am Logged in as "Sys Admin" using EDIPIN 9990001100
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I click the "View Sys Admin Events" checkbox
//	Then Sys Admin Events are displayed

//Scenario Outline: View Audit Log - Column Sorting
//	Given I am Logged in as "Sys Admin" using EDIPIN 9990001100
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search by "- All actions -" in the "Log Type Field" in the Audit Log
//	And I sort the results by<Sort Link>
//	Then the results should be displayed by<Sort Link>
//	Scenarios: 
//	| Sort Link |
//	| Action    |
//	| Date      |
//	| User      |
//	| EDIPIN    |

//Scenario Outline: View Audit Log - Pagination
//	Given I am Logged in as "Sys Admin" using EDIPIN 9990001100
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search by "- All actions -" in the "Log Type Field" in the Audit Log
//	And I click the<Pagination Link> Pagination option
//   Then the results should be displayed with<Pagination Link> rows
//   And the paging hyperlinks work


//   Scenarios: 
//	| Pagination Link |
//	| 25              |
//	| 50              |
//	| 100             |


//# AVS
//# Test Case 32729 http://s150rctfs15-01:8080/tfs/RCTFS_Medchart/MED-CHART/_workitems?id=32729&_a=edit
//Scenario Outline: View Audit Log - AVS - Filter Validations

//   Given I am Logged in as "AVS Sys Admin" using EDIPIN 1110000011
//	When I navigate to "View Audit Log" tab in "Admin"
//	Then the filter options should be correct for the<Organization> Audit Log in <Module>

//	Scenarios:
//	| Module | Organization   |
//	| AVS    | National Guard |
//	| AVS    | Army Reserve   |
//	| AVS    | Contractors    |

//Scenario Outline: View Audit Log - AVS - Log Type Validation - Sys Admin
//	Given I am Logged in as "AVS ARNG Manager" using EDIPIN 1110000161
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search for a<Log Type> Log
//	Then the<Log Type> Log entry should be correct for the Audit Log

//	Scenarios: 
//	| Log Type                         |
//	| Soldier - Demographics Updated   |
//	| Budget – Funds Requested         |
//	| User – Manage Command/UIC Access |


//# eMMPS
//# Test Case 36715
//Scenario Outline: View Audit Log - eMMPS - Filter Validations
//	Given I am Logged in as "eMMPS Sys Admin" using EDIPIN 8880070070
//	When I navigate to "View Audit Log" tab in "Admin"
//	Then the filter options should be correct for the<Organization> Audit Log in <Module>

//	Scenarios:
//	| Module | Organization              |
//	| eMMPS  | National Guard            |
//	| eMMPS  | Army Reserve              |
//	| eMMPS  | Cross-Component           |
//	| eMMPS  | DEMOB/WTU Cross-Component |
	
//Scenario Outline: View Audit Log - eMMPS - Log Type
//	Given I am Logged in as "eMMPS Sys Admin" using EDIPIN 8880070070
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search for a<Log Type> Log
//	Then the<Log Type> Log entry should be correct for the Audit Log

//	Scenarios: 
//	| Log Type           |
//	| Added/Removed UICs |
//	| Requested UICs     |


//# Denclass
//# Test Case 35902
//Scenario Outline: View Audit Log - DenClass - Filter Validations
//	Given I am Logged in as "DenClass Sys Admin" using EDIPIN 8880040000
//	When I navigate to "View Audit Log" tab in "Admin"
//	Then the filter options should be correct for the<Organization> Audit Log in <Module>

//	Scenarios:
//	| Module   | Organization   |
//	| DenClass | National Guard |
//	| DenClass | Army Reserve   |
//	| DenClass | Contractors    |

//Scenario Outline: View Audit Log - DenClass - Log Type Validation - Sys Admin
//	Given I am Logged in as "Denclass Sys Admin" using EDIPIN 8880040000
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search for a<Log Type> Log
//	Then the<Log Type> Log entry should be correct for the Audit Log

//	Scenarios: 
//	| Log Type              |
//	| User - Registered     |
//	| Estimated Cost Report |


//# ECASE
//# Test Script 36976
//# Test Steps 142-145 are removed from 36976 because it is not clear what is being tested and the steps needed to test it
//Scenario Outline: View Audit Log - eCase - Filter Validations
//	Given I am Logged in as "eCase Sys Admin" using EDIPIN 8880010167
//	When I navigate to "View Audit Log" tab in "Admin"
//	Then the filter options should be correct for the<Organization> Audit Log in <Module>

//	Scenarios:
//	| Module | Organization   |
//	| eCase  | National Guard |
//	| eCase  | Army Reserve   |

//Scenario Outline: View Audit Log - ECase - Log Type Validation - SysAdmin
//	Given I am Logged in as "Sys Admin" using EDIPIN 8880010167
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search for a<Log Type> Log
//	Then the<Log Type> Log entry should be correct for the Audit Log

//	Scenarios: 
//	| Log Type                            |
//	| User - Registered                   |
//	| User - Account Modified             |
//	| User - Disallowed from module       |
//	| User - Re-Allowed                   |
//	| Case - Created new(Manual)         |
//	| Case - Created new(Auto)           |
//	| Case - Viewed                       |
//	| Case - Updated                      |
//	| Case - Reassigned                   |
//	| Soldier - Demographics Updated      |
//	| Case Task - Created                 |
//	| Case Task - Updated                 |
//	| Case Task - Finished                |
//	| Case Diagnosis - LOD Status Changed |
//	| HIPAA Certificate - Approved        |
//	| HIPAA Certificate - Disapproved     |
//	| HIPAA Certificate - Uploaded        |
//	| User - Assigned Regions Modified    |
//	| User Request Access                 |
//	| User Request Access Approved        |
//	| User Request Access Disapproved     |


//	#Steps 59, 60 of Script 36976, Need verification of what is being tested as the script is out of date
//	#Scenario: View Audit Log - ECase - "User –Extended Permissions Changed" - SysAdmin
//	#Given I am Logged in as "Sys Admin" using EDIPIN ""
//	#And I navigate to the "View Audit Log" from the "Admin" menu
//	#When I search for a "User –Extended Permissions Changed" ECase Log
//	#Then the "User –Extended Permissions Changed" Log entry should be correct for an ECase Audit Log as a "Sys Admin"


//#OCCHEALTH
//#Test Script 24892
//Scenario Outline: View Audit Log - OH - Filter Validations
//	Given I am Logged in as "OccHealth Sys Admin" using EDIPIN 8880030000
//	When I navigate to "View Audit Log" tab in "Admin"
//	Then the filter options should be correct for the<Organization> Audit Log in <Module>

//	Scenarios:
//	| Module | Organization   |
//	| OH     | National Guard |

//Scenario Outline: View Audit Log - OH - Log Type Validation - Sys Admin
//	Given I am Logged in as "OccHealth Sys Admin" using EDIPIN 8880030000
//	And I have navigated to "View Audit Log" tab in "Admin"
//	When I search for a<Log Type> Log
//	Then the<Log Type> Log entry should be correct for the Audit Log

//	Scenarios: 
//	| Log Type                            |
//	| Budget                              |
//	| Create New Exam Request             |
//	| Edit Health and Wellness            |
//	| Edit Hearing                        |
//	| Edit Hearing Dosimetry              |
//	| Edit Musculoskeletal/Ergonomics     |
//	| Edit OWCP/Job Restrictions          |
//	| Edit Physical                       |
//	| Edit Radiation                      |
//	| Edit Respiratory/Spirometry         |
//	| Edit Vision                         |
//	| Employee Demographics Updated       |
//	| Employee Hazard Profile Updated     |
//	| Employee Record Status Changed      |
//	| Exam Requests Approved              |
//	| Exam Requests Canceled              |
//	| Exam Requests Disapproved           |
//	| Exam Requests Edited                |
//	| HIPAA Certificate - Approved        |
//	| HIPAA Certificate - Disapproved     |
//	| HIPAA Certificate - Uploaded        |
//	| ICDFavorite - Added By User         |
//	| ICDFavorite - Removed By User       |
//	| ICDFavorite - Removed Over Max      |
//	| New Employee Created (Manual)       |
//	| Non-FOH Exam Results                |
//	| Soldier - Demographics Updated      |
//	| Transfer Funds                      |
//	| User - Account Modified             |
//	| User - Assigned Regions Modified    |
//	| User - Disallowed from module       |
//	| User - Extended Permissions Changed |
//	| User - Re-Allowed                   |
//	| User - Registered                   |
//	| User - Registration Approved        |
//	| User - Role Modified                |
//	| User – User Details Updated         |
//	| User Request Access                 |
//	| User Request Access Approved        |
//	| User Request Access Disapproved     |
//	| View Health and Wellness            |
//	| View Hearing                        |
//	| View Musculoskeletal/Ergonomics     |
//	| View OWCP/Job Restrictions          |
//	| View Physical                       |
//	| View Radiation                      |
//	| View Respiratory/Spirometry         |
//	| View Vision                         |


	}
}
