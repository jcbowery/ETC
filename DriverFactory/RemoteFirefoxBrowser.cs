using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace DriverFactory
{
    internal class RemoteFirefoxBrowser : BrowserBase
    {
        internal override IWebDriver Build()
        {
            var options = OptionsFactory.GetFirefoxOptions();
            return new RemoteWebDriver(
                new Uri(BrowserConfig.DriverLocation), options.ToCapabilities(), TimeSpan.FromSeconds(BrowserConfig.TimeOut));
        }
    }
}
