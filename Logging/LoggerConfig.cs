using Newtonsoft.Json.Linq;
using System.IO;

namespace Logging
{
    public static class LoggerConfig
    {
        public static string ParentDirectory { get; set; }

        public static void SetConfig(JToken options)
        {
            ParentDirectory = options.Value<string>("ParentDirectory");
            if (ParentDirectory == null)
            {
                ParentDirectory = Path.GetFullPath(@"../../../../");
            }

        }
    }
}
