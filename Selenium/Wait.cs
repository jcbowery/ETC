using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium
{
    public class Wait
    {
        private readonly WebDriverWait _wait;

        /// <summary>
        /// Creates a Wait to be used in Drvier Wrapper
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="waitSeconds"></param>
        public Wait(IWebDriver driver, int waitSeconds)
        {
            _wait = new WebDriverWait(new SystemClock(), driver, TimeSpan.FromSeconds(waitSeconds), TimeSpan.FromSeconds(2));

            _wait.IgnoreExceptionTypes(
                typeof(NoSuchElementException),
                typeof(ElementNotVisibleException),
                typeof(StaleElementReferenceException)
            );
        }

        /// <summary>
        /// Used to enter a condition
        /// </summary>
        /// <param name="condition"></param>
        /// <returns>bool</returns>
        public bool Until(Func<IWebDriver, bool> condition)
        {
            return _wait.Until(condition);
        }

        /// <summary>
        /// Used to enter a condition
        /// </summary>
        /// <param name="condition"></param>
        /// <returns>IWebElement</returns>
        public IWebElement Until(Func<IWebDriver, IWebElement> condition)
        {
            return _wait.Until(condition);
        }
    }
}
