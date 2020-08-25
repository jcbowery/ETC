using DriverFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using Selenium.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Selenium
{
    public static partial class Driver
    {
        [ThreadStatic]
        static private EventFiringWebDriver _DriverListener;

        /// <summary>
        /// Used for waiting
        /// </summary>
        [ThreadStatic]
        static public Wait Wait;
        public static void SetDriver()
        {
            //set driver based on configs
            _DriverListener = new EventFiringWebDriver(BrowserFactory.Set());

            //setup all the driver listeners
            _DriverListener.Navigating += FiringDriver_Navigating;
            _DriverListener.Navigated += FiringDriver_Navigated;
            _DriverListener.FindingElement += FiringDriver_Looking;
            _DriverListener.FindElementCompleted += FiringDriver_Looked;
            _DriverListener.ElementClicking += Clicking_Element;
            _DriverListener.ElementClicked += Clicked_Element;
            _DriverListener.ElementValueChanging += Element_Changing;
            _DriverListener.ElementValueChanged += Element_Changed;
            _DriverListener.ExceptionThrown += Exception_Thrown;

            //set wait
            Wait = new Wait(_DriverListener, SeleniumConfig.WaitTime);
        }

        /// <summary>
        /// Get the Url of page
        /// </summary>
        static public Uri Url
        {
            get => new Uri(_DriverListener.Url);
            set => _DriverListener.Url = value.ToString();
        }

        /// <summary>
        /// Get the page title
        /// </summary>
        static public string Title => _DriverListener.Title;


        /// <summary>
        /// Get the page source
        /// </summary>
        static public string PageSource => _DriverListener.PageSource;


        /// <summary>
        /// get the current window handle
        /// </summary>
        static public string CurrentWindowHandle => _DriverListener.CurrentWindowHandle;


        /// <summary>
        /// Get a collection of the window handles
        /// </summary>
        static public ReadOnlyCollection<string> WindowHandles => _DriverListener.WindowHandles;


        /// <summary>
        /// Close the current window handle
        /// </summary>
        static public void Close()
        {
            _DriverListener.Close();
        }


        /// <summary>
        /// Kills process...I think
        /// </summary>
        static public void Dispose()
        {
            _DriverListener.Dispose();
        }


        /// <summary>
        /// Find an element on the page
        /// </summary>
        /// <param name="by"></param>
        /// <returns>Element class</returns>
        static public IElement FindElement(By by)
        {
            var element = Wait.Until(drv => drv.FindElement(by));
            return new Element(element);
        }


        /// <summary>
        /// Find a collection of elements on the page
        /// </summary>
        /// <param name="by"></param>
        /// <returns>ReadOnlyCollection of IWebElement</returns>
        static public IElementsList FindElements(By by)
        {
            return new Elements(_DriverListener.FindElements(by));
        }


        /// <summary>
        /// Manage the driver
        /// </summary>
        /// <returns>Ioptions interface</returns>
        static public IOptions Manage()
        {
            return _DriverListener.Manage();
        }

        /// <summary>
        /// Quit whole browser and kill process
        /// </summary>
        static public void Quit()
        {
            _DriverListener.Quit();
        }

        /// <summary>
        /// switch between handles
        /// </summary>
        /// <returns>ITargetLocator interface</returns>
        static public ITargetLocator SwitchTo()
        {
            return _DriverListener.SwitchTo();
        }

        /// <summary>
        /// executes java script
        /// </summary>
        /// <param name="script"></param>
        /// <returns>return an object</returns>
        [ObsoleteAttribute("Method is most likely not in a good state", false)]
        static public object ExecuteJavaScript(string script)
        {
            IJavaScriptExecutor js = _DriverListener;
            return js.ExecuteScript(script);
        }

        [ObsoleteAttribute("Method is most likely not in a good state", false)]
        static public void TakeScreenshot(string name)
        {
            var ss = _DriverListener.GetScreenshot();
            ss.SaveAsFile(name, ScreenshotImageFormat.Png);
        }

        /// <summary>
        /// Naviagte to given url
        /// </summary>
        /// <param name="url"></param>
        static public void GoToUrl(string url)
        {
            _DriverListener.Navigate().GoToUrl(url);
        }


        /// <summary>
        /// Wait for ajax to finish loading before continueing.
        /// </summary>
        static public void WaitForAjax()//todo hook into wait class
        {
            var timeout = TimeSpan.FromSeconds(30);
            var sleepInterval = TimeSpan.FromSeconds(2);
            var webDriverWait = new WebDriverWait(new SystemClock(), _DriverListener, timeout, sleepInterval);
            var js = (IJavaScriptExecutor)_DriverListener;
            webDriverWait.Until(wd => js.ExecuteScript("return jQuery.active").ToString() == "0");
        }
    }
}
