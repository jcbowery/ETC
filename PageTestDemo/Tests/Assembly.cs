using Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp.Ui;

namespace PageTestDemo.Tests
{
    [TestClass]
    public class Assembly
    {
        public static ETCUi ui;

        [AssemblyInitialize]
        public static void AssemblyStart(TestContext TestContext)
        {
            ui = new ETCUi();
            LogHelper.CreateTestResultsDirectory();
        }

        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
            ui.Dispose();
        }
    }
}
