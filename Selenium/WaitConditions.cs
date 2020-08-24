using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace Selenium
{
    public class WaitConditions
    {
        /// <summary>
        /// Wait till element is displayed
        /// </summary>
        /// <param name="element"></param>
        /// <returns>bool</returns>
        public static Func<IWebDriver, bool> ElementDisplayed(IWebElement element)
        {
            bool condition(IWebDriver driver)
            {
                return element.Displayed;
            }

            return condition;
        }

        /// <summary>
        /// Wait for element to not be displayed
        /// </summary>
        /// <param name="element"></param>
        /// <returns>bool</returns>
        public static Func<IWebDriver, bool> ElementNotDisplayed(IWebElement element)
        {
            bool condition(IWebDriver driver)
            {
                try
                {
                    return !element.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
            }

            return condition;
        }

        /// <summary>
        /// Waits for elements colelction to not be empty
        /// </summary>
        /// <param name="elements"></param>
        /// <returns>bool</returns>
        public static Func<IWebDriver, bool> ElementsNotEmpty(ReadOnlyCollection<IWebElement> elements)
        {
            bool condition(IWebDriver driver)
            {
                return elements.Count > 0;
            }

            return condition;
        }

        /// <summary>
        /// Waits for element to be enabled
        /// </summary>
        /// <param name="element"></param>
        /// <returns>bool</returns>
        public static Func<IWebDriver, bool> ElementEnabled(IWebElement element)
        {
            bool condition(IWebDriver driver)
            {
                return element.Enabled;
            }

            return condition;
        }

        /// <summary>
        /// Waits for element to not be enabled
        /// </summary>
        /// <param name="element"></param>
        /// <returns>bool</returns>
        public static Func<IWebDriver, bool> ElementNotEnabled(IWebElement element)
        {
            bool condition(IWebDriver driver)
            {
                return !element.Enabled;
            }

            return condition;
        }

        /// <summary>
        /// Waits for JS to be loaded
        /// </summary>
        /// <returns>bool</returns>
        public static Func<IWebDriver, bool> JSLoaded()
        {
            bool condition(IWebDriver driver)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                return js.ExecuteScript("return document.readyState").Equals("complete");

            }

            return condition;
        }
    }
}
