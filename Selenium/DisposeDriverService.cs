/*
 * this was taken from the Automate the Planet article:
 * https://www.automatetheplanet.com/kill-all-webdrivers/
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Selenium
{
    public static class DisposeDriverService
    {
        private static readonly List<string> _processesToCheck =
            new List<string>
            {
            "opera",
            "chrome",
            "firefox",
            "ie",
            "gecko",
            "phantomjs",
            "edge",
            "microsoftwebdriver",
            "webdriver"
            };

        /// <summary>
        /// Sets the time tests are started to prevent process before this from being killed
        /// </summary>
        public static DateTime? TestRunStartTime { get; set; }

        /// <summary>
        /// Destroys all browser processes.
        /// </summary>
        public static void FinishHim()
        {
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    Debug.WriteLine(process.ProcessName);
                    if (process.StartTime > TestRunStartTime)
                    {
                        var shouldKill = false;
                        foreach (var processName in _processesToCheck)
                        {
                            if (process.ProcessName.ToLower().Contains(processName))
                            {
                                shouldKill = true;
                                break;
                            }
                        }
                        if (shouldKill)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}
