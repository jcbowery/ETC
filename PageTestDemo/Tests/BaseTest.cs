using Asserts;
using Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTests.Asserts;
using PageTestDemo.Pages.Base;
using Unity;
using Utilities;

namespace PageTestDemo.Tests
{
    [TestClass]
    public class BaseTest : Assembly
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassSetup(TestContext TestContext)
        {
            UnityContainerFactory.GetContainer().RegisterType<IAssert, MSTestAssert>();
            IOCClass.LoadIoC();

        }

        [TestInitialize]
        public void StartTest()
        {
            LogHelper.SetLogger(TestContext.TestName, "1"); ;
            ui.StartDriver();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            ui.CloseBrowser();
        }
    }
}
