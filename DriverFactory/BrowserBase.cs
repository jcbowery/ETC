using OpenQA.Selenium;

namespace DriverFactory
{
    internal abstract class BrowserBase
    {
        internal abstract IWebDriver Build();

    }
}
