using Logging;
using Newtonsoft.Json.Linq;

namespace DriverFactory
{
    public static class BrowserConfig
    {
        public static string Browser = "chrome";

        public static bool Incognito = false;

        public static bool Headless = false;

        public static int TimeOut = 600;

        public static string DriverLocation = null;

        public static bool IsRemote = false;

        public static void SetBrowserOptions(JToken options)
        {
            if (options.Value<string>("Browser") != null)
            {
                Browser = (options.Value<string>("Browser"));
            }
            Incognito = options.Value<bool>("Incognito");
            Headless = options.Value<bool>("Headless");
            if (options.Value<int>("TimeOut")>0 && options.Value<bool>("IsRemote").Equals(true))
            {
                TimeOut = options.Value<int>("TimeOut");
            }
            DriverLocation = options.Value<string>("DriverLocation");
            IsRemote = options.Value<bool>("IsRemote");


        }
    }


}
