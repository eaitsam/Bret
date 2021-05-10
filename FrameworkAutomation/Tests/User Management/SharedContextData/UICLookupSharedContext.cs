using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.User_Management.SharedContextData
{
    public class UICLookupSharedContext
    {
        public static IEnumerable<object[]> OrgChartHierarchyData =>
        new List<object[]>
        {
            new object[] { "W00QAA", "Ancestor", "W77743", "NATIONAL GUARD BUREAU;349466;0"},
            new object[] { "W8BJAA", "Ancestor", "W77743", "VAARNG ELEMENT, JF HQ;7455;175"},
            new object[] { "W777AA", "Ancestor", "W77743", "VIRGINIA REC & RET;129;111" },
            new object[] { "W77743", null, null, "RI ARNG REC RET CMD;0;0" },
        };

        public static IEnumerable<object[]> OrgChartColoringData =>
        new List<object[]>
        {
            new object[] { "W00QAA", "W00QAA", "Parent"},
            new object[] { "W00QAA;W8BJAA", "W8BJAA", "Parent"},
            new object[] { "W00QAA;W8BJAA;W777AA", "W777AA", "Parent"},
            new object[] { "W00QAA;W8BJAA;W777AA;W77743", "W77743", "Child"},
        };

    }
}
