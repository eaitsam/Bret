using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MedchartSeleniumAutomationCore.Core_Settings
{
    /// <summary>
    /// A Class designed to help organize and manage test input and output files
    /// </summary>
    public static class TestFolders
    {

        /// <summary>
        /// Makes string path-compatible, ie removes characters not allowed in path and replaces whitespace with '_'
        /// </summary>
        public static string ToPath(string s)
        {
            var builder = new StringBuilder(s);
            foreach (var invalidChar in Path.GetInvalidFileNameChars())
            {
                builder.Replace(invalidChar.ToString(), "");
            }
            builder.Replace(' ', '_');
            return builder.ToString();
        }

        public static readonly string UniqueId = DateTime.Now.ToString("s", CultureInfo.InvariantCulture).Replace(":", "");

        public static string InputFolder
        {
            get { return Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath); }
        }

        public static string OutputFolder
        {
            //a simple solution that puts everyting to the output folder directly would look like this:
            //get { return Directory.GetCurrentDirectory(); }
            get
            {
                var outputFolder = Path.Combine(Directory.GetCurrentDirectory(), UniqueId);
                if (!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder);
                return outputFolder;
            }
        }

        public static string TempFolder
        {
            get { return Path.GetTempPath(); }
        }

        // very simple helper methods that can improve the test code readability

        public static string GetInputFilePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(InputFolder, fileName));
        }

        public static string GetOutputFilePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(OutputFolder, fileName));
        }

        public static string GetTempFilePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(TempFolder, fileName));
        }
    }
}
