using Selenium;
using System;

namespace TestApp.Ui
{
    public class ETCUi : IDisposable
    {
        public ETCUi()
        {
            DisposeDriverService.TestRunStartTime = DateTime.Now;
        }

        /// <summary>
        /// clean driver processes
        /// </summary>
        public void Dispose()
        {
            DisposeDriverService.FinishHim();
        }

        /// <summary>
        /// close browser window
        /// </summary>
        public void CloseBrowser()
        {
            Driver.Close();
        }

        /// <summary>
        /// start driver
        /// </summary>
        public void StartDriver()
        {
            Driver.SetDriver();
        }
    }
}
