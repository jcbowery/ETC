using Logging;
using Newtonsoft.Json.Linq;

namespace DriverFactory
{
    public static class BrowserConfig
    {
        public static string Browser { get; set; }

        public static bool Incognito { get; set; }

        public static bool Headless { get; set; }

        public static int TimeOut { get; set; }

        public static string DriverLocation { get; set; }

        public static bool IsRemote { get; set; }

        public static void SetBrowserOptions(JToken options)
        {
            var browser = options.Value<string>("Browser");
            if (browser == null)
            {
                LogHelper.Log?.Warning("Browser option was left empty. Defaulting to Chrome");
                browser = "chrome";
            }
            Browser = browser;
            Incognito = options.Value<bool>("Incognito");
            Headless = options.Value<bool>("Headless");
            TimeOut = options.Value<int>("TimeOut");
            if (options.Value<int>("TimeOut").Equals(0) && options.Value<bool>("IsRemote").Equals(true))
            {
                LogHelper.Log?.Warning("TimeOut is set to 0. Will default to 600");
                TimeOut = 600;
            }
            DriverLocation = options.Value<string>("DriverLocation");
            IsRemote = options.Value<bool>("IsRemote");


        }
    }


}
