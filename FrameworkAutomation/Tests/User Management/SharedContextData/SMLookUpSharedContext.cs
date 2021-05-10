using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FrameworkAutomation.User_Management.SharedContextData
{
    public class SMLookupTestData
    {
        public static IEnumerable<object[]> EditDemographicPermissionData =>
            new List<object[]>
            {
            new object[] { "9990001100", "Framework", "National Guard", "MEDCHART Sys Admin", true },
            new object[] { "9990001100", "Framework", "National Guard", "MEDCHART ARNG Manager", true },
            new object[] { "9990001100", "Framework", "National Guard", "MEDCHART USAR Manager", true },
            new object[] { "1110000011", "AVS", "National Guard", "AVS Sys Admin", false },
            new object[] { "1110000011" , "AVS", "National Guard", "AVS ARNG Manager", true },
            new object[] { "1110000011", "AVS", "National Guard", "ARNG Approval Authority", true },
            new object[] { "1110000011", "AVS", "National Guard", "ARNG Unit Administrator", true },
            new object[] { "1110000011", "AVS", "National Guard", "ARNG PDHRA Management", false },
            new object[] { "1110000011", "AVS", "National Guard", "ARNG PDHRA Coordinator", false },
            new object[] { "1110000011", "AVS", "Army Reserve", "AVS USAR Manager", true },
            new object[] { "1110000011", "AVS", "Army Reserve", "USAR Approval Authority", true },
            new object[] { "1110000011", "AVS", "Army Reserve", "USAR Unit Administrator", true },
            new object[] { "1110000011", "AVS", "Army Reserve", "USAR DHAP Manager", false },
            new object[] { "1110000011", "AVS", "Army Reserve", "USAR DHAP Coordinator", false },
            new object[] { "1110000011", "AVS", "Contractors", "DHAP Service Provider", false },
            new object[] { "1110000011", "AVS", "Contractors", "RHRP Service Provider", true },
            new object[] { "1110000011", "AVS", "Contractors", "RHRP Call Center", true },
            new object[] { "1110000011", "AVS", "Contractors", "AVS Contractors Manager", false },
            new object[] { "8880010167", "eCase", "National Guard", "eCase Sys Admin", false },
            new object[] { "8880010167", "eCase", "National Guard" , "eCase ARNG Manager", true },
            new object[] { "8880010167", "eCase", "National Guard" , "Administrative Support", true },
            new object[] { "8880010167", "eCase", "National Guard" , "Auditor", false },
            new object[] { "8880010167", "eCase", "National Guard" , "DSS", true },
            new object[] { "8880010167", "eCase", "National Guard" , "Lead MCM", true },
            new object[] { "8880010167", "eCase", "National Guard", "Medical Case Manager", true },
            new object[] { "8880010167", "eCase", "National Guard", "Medical Readiness NCO", true },
            new object[] { "8880010167", "eCase", "National Guard", "Provider", true },
            new object[] { "8880010167", "eCase", "National Guard", "Unit Administrator", true },
            new object[] { "8880010167", "eCase", "Army Reserve", "eCase USAR Manager", true },
            new object[] { "8880010167", "eCase", "Army Reserve", "Administrative Support", true },
            new object[] { "8880010167", "eCase", "Army Reserve", "Auditor", false },
            new object[] { "8880010167", "eCase", "Army Reserve", "Lead Nurse Case Manager", true },
            new object[] { "8880010167", "eCase", "Army Reserve", "Medical Reviewer", true },
            new object[] { "8880010167", "eCase", "Army Reserve", "Nurse Case Manager", true },
            new object[] { "8880010167", "eCase", "Army Reserve", "Provider", true },
            new object[] { "8880010167", "eCase", "Army Reserve", "Supervisor", true },
            new object[] { "3330012345", "HRR", "National Guard", "HRR Sys Admin", true },
            new object[] { "3330012345", "HRR", "National Guard", "HRR ARNG Manager", true },
            new object[] { "3330012345", "HRR", "National Guard", "HRR ARNG User", true },
            new object[] { "3330012345", "HRR", "National Guard", "DSS", true },
            new object[] { "3330012345", "HRR", "National Guard", "ARNG Contractor", true },
            new object[] { "3330012345", "HRR", "National Guard", "PAD Officer", true },
            new object[] { "3330012345", "HRR", "National Guard", "PAD Specialist", true },
            new object[] { "3330012345", "HRR", "National Guard", "MEB/PEB", true },
            new object[] { "3330012345", "HRR", "National Guard", "ARNG MOB Station", true },
            new object[] { "3330012345", "HRR", "National Guard", "ARNG Provider", true },
            new object[] { "3330012345", "HRR", "National Guard", "Behavioral Health Admin", true },
            new object[] { "3330012345", "HRR", "National Guard", "Behavioral Health Officer", true },
            new object[] { "3330012345", "HRR", "National Guard", "ARNG DPH", true },
            new object[] { "3330012345", "HRR", "National Guard", "ARNG ARPC", true },
            new object[] { "3330012345", "HRR", "National Guard", "Case Manager", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "HRR USAR Manager", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR Admin", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR Commander", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR Surgeon", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR MEB/PEB", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR MOB Station", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR HRR User", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR Contractor", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR DPH", true },
            new object[] { "3330012345", "HRR", "Army Reserve", "USAR ARPC", true },
            };

        public static IEnumerable<object[]> SearchFunctionVerifyResultsData =>
            new List<object[]>
            {
                //		| Filter     | Value    | Result  | Column  |
                new object[] { "SSN", "8971", "8971", "SSN" },
                new object[] { "First Name", "AL", "AL", "Soldier" },
                new object[] { "Last Name", "Le", "Le", "Soldier" },
                new object[] { "First Name", "Jackson", "Jackson", "Soldier" },
                new object[] { "Last Name", "Harris", "Harris", "Soldier" },
                new object[] { "First Name", "klwjqegl", "none", "Soldier" },
                new object[] { "Last Name", "gnwloekn", "none", "Soldier" },
                new object[] { "SSN", "8971", "Select", null },
            };


    }


}
