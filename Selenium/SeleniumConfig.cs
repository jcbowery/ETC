using Logging;
using Newtonsoft.Json.Linq;

namespace Selenium
{
    public static class SeleniumConfig
    {
        public static int WaitTime = 15;

        public static void SetConfigs(JToken options)
        {
            if (options.Value<int>("WaitTime").Equals(0)) { LogHelper.Log?.Warning("Wait time is set to 0"); }
            WaitTime = options.Value<int>("WaitTime");
        }
    }
}
