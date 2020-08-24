using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DriverFactory
{
    internal class FirefoxBrowser : BrowserBase
    {
        internal override IWebDriver Build()
        {
            if (BrowserConfig.DriverLocation != null) { return new FirefoxDriver(BrowserConfig.DriverLocation, OptionsFactory.GetFirefoxOptions()); }
            return new FirefoxDriver(OptionsFactory.GetFirefoxOptions());
        }
    }
}
