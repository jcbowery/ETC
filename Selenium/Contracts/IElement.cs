using OpenQA.Selenium;

namespace Selenium.Contracts
{
    public interface IElement : IStyleAssertedElement
    {
        string Text { get; }
        IWebElement WrappedElement { get; }
        void SendKeys(string text);
        IElement FindElement(By locator);
        void Click();

        void ForceClick();
    }
}
