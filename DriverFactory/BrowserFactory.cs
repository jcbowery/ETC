using OpenQA.Selenium;
using System;

namespace DriverFactory
{
    public static class BrowserFactory
    {
        private static BrowserBase Browser { get; set; }
        public static IWebDriver Set()
        {
            if (BrowserConfig.IsRemote)
            {
                switch (BrowserConfig.Browser.ToLower())
                {
                    case "chrome":
                        Browser = new RemoteChromeBrowser();
                        break;
                    case "firefox":
                        Browser = new RemoteFirefoxBrowser();
                        break;
                    default:
                        throw new ArgumentException($"{BrowserConfig.Browser} is not a proper browser selection");
                }
            }
            else
            {
                switch (BrowserConfig.Browser.ToLower())
                {
                    case "chrome":
                        Browser = new ChromeBrowser();
                        break;
                    case "firefox":
                        Browser = new FirefoxBrowser();
                        break;
                    default:
                        throw new ArgumentException($"{BrowserConfig.Browser} is not a proper browser selection");
                }
            }
            return Browser.Build();

        }
    }
}
