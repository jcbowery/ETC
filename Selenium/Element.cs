using Asserts;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium.Contracts;
using System.Drawing;

namespace Selenium
{
    public class Element : IElement
    {
        private IWebElement _Element;
        public Element(IWebElement element)
        {
            _Element = element;
        }

        public IWebElement WrappedElement => _Element;

        /// <summary>
        /// get tagname
        /// </summary>
        public string TagName => _Element.TagName;

        /// <summary>
        /// get the element text
        /// </summary>
        public string Text => _Element.Text;

        /// <summary>
        /// get if element enabled
        /// </summary>
        public bool Enabled => _Element.Enabled;

        /// <summary>
        /// get if element selected
        /// </summary>
        public bool Selected => _Element.Selected;

        /// <summary>
        /// give a point of element location
        /// </summary>
        public Point Location => _Element.Location;

        /// <summary>
        /// givea size of element size
        /// </summary>
        public Size Size => _Element.Size;

        /// <summary>
        /// get if element displayed
        /// </summary>
        public bool Displayed => _Element.Displayed;

        /// <summary>
        /// clears an element
        /// </summary>
        public void Clear()
        {
            _Element.Clear();
        }

        /// <summary>
        /// clicks an element
        /// </summary>
        public void Click()//todo create and hook up a custom element clickable condition
        {
            //wait for element to be clickable
            Driver.Wait.Until(WaitConditions.ElementClickable(_Element));
            //move to element
            Actions actions = new Actions(Driver.WrappedDriver);
            actions.MoveToElement(_Element);
            actions.Perform();
            //click element
            _Element.Click();
        }

        /// <summary>
        /// READFIRST!!! This is to only be used if normal clicking methods wont work and you need a js work around
        /// </summary>
        public void ForceClick()
        {
            //wait for element to be clickable
            Driver.Wait.Until(WaitConditions.ElementClickable(_Element));
            //move to element
            Actions actions = new Actions(Driver.WrappedDriver);
            actions.MoveToElement(_Element);
            actions.Perform();
            //click the element through js
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver.WrappedDriver;
            executor.ExecuteScript("arguments[0].click();", _Element);
        }

        /// <summary>
        /// Find inner element
        /// </summary>
        /// <param name="by"></param>
        /// <returns>IElement Interface</returns>
        public IElement FindElement(By by)
        {
            return new Element(_Element.FindElement(by));
        }

        /// <summary>
        /// find inner elements
        /// </summary>
        /// <param name="by"></param>
        /// <returns>IElementsList interface</returns>
        public IElementsList FindElements(By by)
        {
            return new Elements(_Element.FindElements(by));
        }

        /// <summary>
        /// get attribute
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns>string of attribute</returns>
        public string GetAttribute(string attributeName)
        {
            return _Element.GetAttribute(attributeName);
        }

        /// <summary>
        /// Sends text to element
        /// </summary>
        /// <param name="text"></param>
        public void SendKeys(string text)
        {
            this.Clear();
            _Element.SendKeys(text);
        }

        /// <summary>
        /// submit form
        /// </summary>
        public void Submit()
        {
            _Element.Submit();
        }

        //todo finsih asserts
        public void AssertBackgroundColor(string expectedBackgroundColor)
        {
            Assert.AreEqual(expectedBackgroundColor, _Element.GetCssValue("background-color"));
        }

        public void AssertBorderColor(string expectedBorderColor)
        {
            Assert.AreEqual(expectedBorderColor, _Element.GetCssValue("border-color"));
        }

        public void AssertColor(string expectedColor)
        {
            throw new System.NotImplementedException();
        }

        public void AssertFontFamily(string expectedFontFamily)
        {
            throw new System.NotImplementedException();
        }

        public void AssertFontSize(string expectedFontSize)
        {
            throw new System.NotImplementedException();
        }

        public void AssertFontWeight(string expectedFontWeight)
        {
            throw new System.NotImplementedException();
        }

        public void AssertTextAlign(string expectedTextAlign)
        {
            throw new System.NotImplementedException();
        }

        public void AssertVerticalAlign(string expectedVerticalAlign)
        {
            throw new System.NotImplementedException();
        }


    }
}
