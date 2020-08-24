using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DriverFactory
{
    internal class ChromeBrowser : BrowserBase
    {
        internal override IWebDriver Build()
        {
            if (BrowserConfig.DriverLocation != null) { return new ChromeDriver(BrowserConfig.DriverLocation, OptionsFactory.GetChromeOptions()); }
            return new ChromeDriver(OptionsFactory.GetChromeOptions());
        }




    }
}
