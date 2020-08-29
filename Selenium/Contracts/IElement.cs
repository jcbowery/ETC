using OpenQA.Selenium;
using System.Drawing;

namespace Selenium.Contracts
{
    public interface IElement : IStyleAssertedElement
    {
        string Text { get; }
        IWebElement WrappedElement { get; }
        string TagName { get; }
        bool Enabled { get; }
        bool Selected { get; }
        Point Location { get; }
        Size Size { get; }
        bool Displayed { get; }
        void SendKeys(string text);
        IElement FindElement(By locator);
        IElementsList FindElements(By locator);
        string GetAttribute(string attributeName);
        void Submit();
        void Click();
        void Clear();
        void ForceClick();
    }
}
