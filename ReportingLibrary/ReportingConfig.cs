using Logging;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ReportingLibrary
{
    public static class ReportingConfig
    {
        public static string ReportLocation { get; set; }

        public static void SetConfig(JToken options)
        {
            ReportLocation = options.Value<string>("ReportLocation");
            if (ReportLocation == null)
            {
                LogHelper.Log?.Warning($"ReportLocation was left blank. Defaulting to {Path.GetFullPath(@"../../../../") + "/TestResults/ExtentReport"}");
                ReportLocation = Path.GetFullPath(@"../../../../") + "/TestResults/ExtentReport";
            }
        }
    }
}
