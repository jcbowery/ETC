using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace DriverFactory
{
    internal class RemoteChromeBrowser : BrowserBase
    {
        internal override IWebDriver Build()
        {
            var options = OptionsFactory.GetChromeOptions();
            return new RemoteWebDriver(
                new Uri(BrowserConfig.DriverLocation), options.ToCapabilities(), TimeSpan.FromSeconds(BrowserConfig.TimeOut));
        }
    }
}
