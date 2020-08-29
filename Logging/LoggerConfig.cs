using Newtonsoft.Json.Linq;
using System.IO;

namespace Logging
{
    public static class LoggerConfig
    {
        public static string ParentDirectory = Path.GetFullPath(@"../../../../");

        public static void SetConfig(JToken options)
        {
            if (options.Value<string>("ParentDirectory") != null)
            {
                ParentDirectory = options.Value<string>("ParentDirectory");
            }

        }
    }
}
