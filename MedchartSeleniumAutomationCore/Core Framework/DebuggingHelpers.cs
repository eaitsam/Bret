using log4net;
using log4net.Config;
using MedchartSeleniumAutomationCore.Core_Settings;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;

namespace MedchartSeleniumAutomationCore.Core_Framework
{
    public class DebuggingHelpers
    {
        public static void LogWorkflowError(Exception ex, string methodErrorOccuredIn, string edipin, string id)
        {
            string message = string.Format("Time: {0} EDIPIN = {1}, Id = {2}, Error occured in: {3},  ", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), edipin, id, methodErrorOccuredIn);
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"EmmpsAutomation\Dataseed\Parameter Files\workflowErrorLog.txt"));
            //string path = @"C:\workflowErrorLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
                writer.Close();
            }
        }

        private static void WriteAttributesToConsole(By x, string name)
        {
            Console.WriteLine($">>{name}<< Is Present:  " + ObjectRepository.Driver.FindElement(x).Displayed);
            Console.WriteLine($">>{name}<< Text: " + UIActions.GetElement(x).Text);
            Console.WriteLine($">>{name}<< Is Displayed: " + UIActions.GetElement(x).Displayed);
        }

        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Serializable]
        public class NoSuchKeywordFoundException : Exception
        {
            public NoSuchKeywordFoundException(string msg) : base(msg)
            {
            }
            protected NoSuchKeywordFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }

        [Serializable]
        public class NoSutiableDriverFound : Exception
        {
            public NoSutiableDriverFound(string msg) : base(msg)
            {
            }

            public NoSutiableDriverFound()
            {
            }

            public NoSutiableDriverFound(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected NoSutiableDriverFound(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }


        }

        #region .NetCore

        public static ILog Logger()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            return LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        #endregion .NetCore
    }
}