using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace ReportingLibrary
{
    public class ExtentManager
    {
        private static readonly Lazy<AventStack.ExtentReports.ExtentReports> _lazy = new Lazy<AventStack.ExtentReports.ExtentReports>(() => new AventStack.ExtentReports.ExtentReports());

        public static AventStack.ExtentReports.ExtentReports Instance { get { return _lazy.Value; } }

        static ExtentManager()
        {
            if (!Directory.Exists(ReportingConfig.ReportLocation)) { Directory.CreateDirectory(ReportingConfig.ReportLocation); }

            var htmlReporter = new ExtentHtmlReporter(ReportingConfig.ReportLocation + "\\extentreport.html");
            htmlReporter.Config.DocumentTitle = "Extent Report";
            htmlReporter.Config.ReportName = "test Results";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            Instance.AttachReporter(htmlReporter);
        }

        public ExtentManager()
        {
        }
    }
}
