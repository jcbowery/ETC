using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace DriverFactory
{
    internal class OptionsFactory
    {
        internal static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();

            if (BrowserConfig.Headless) { options.AddArguments("--headless"); }
            if (BrowserConfig.Incognito) { options.AddArguments("--incognito"); }
            return options;
        }

        internal static FirefoxOptions GetFirefoxOptions()
        {
            FirefoxOptions options = new FirefoxOptions();


            if (BrowserConfig.Headless) { options.AddArguments("--headless"); }
            if (BrowserConfig.Incognito) { options.AddArguments("--incognito"); }
            return options;
        }
    }
}
