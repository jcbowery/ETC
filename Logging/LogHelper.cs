using System;
using System.IO;

namespace Logging
{
    public static class LogHelper
    {
        public static string WORKSPACE_DIRECTORY = LoggerConfig.ParentDirectory;

        public static Logger Log => _logger;

        [ThreadStatic]
        public static DirectoryInfo CurrentTestDirectory;

        [ThreadStatic]
        private static Logger _logger;

        /// <summary>
        /// Creates a test results directory in workspace directory
        /// </summary>
        /// <returns>The Test Results Directory location</returns>
        public static DirectoryInfo CreateTestResultsDirectory()
        {
            var testDirectory = WORKSPACE_DIRECTORY + "TestResults";

            if (Directory.Exists(testDirectory))
            {
                Directory.Delete(testDirectory, recursive: true);
            }

            return Directory.CreateDirectory(testDirectory);
        }

        /// <summary>
        /// Creates test Directory and starts the log
        /// </summary>
        /// <param name="testName"></param>
        /// <param name="testId"></param>
        public static void SetLogger(string testName, string testId)
        {
            lock (_setLoggerLock)
            {
                var testResultsDir = WORKSPACE_DIRECTORY + "TestResults";
                var fullPath = $"{testResultsDir}\\{testName}";

                if (Directory.Exists(fullPath))
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath + testId);
                }
                else
                {
                    CurrentTestDirectory = Directory.CreateDirectory(fullPath);
                }

                _logger = new Logger(testName, CurrentTestDirectory.FullName + "/" + testName + ".txt");
            }
        }

        public static void SetAppLogger()
        {
            lock (_setLoggerLock2)
            {
                var testResultsDir = WORKSPACE_DIRECTORY + "TestResults";


                _logger = new Logger("app", testResultsDir + "/" + "app" + ".txt");
            }
        }

        private static object _setLoggerLock = new object();
        private static object _setLoggerLock2 = new object();
    }
}
