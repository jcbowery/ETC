using AventStack.ExtentReports;
using System;
using System.Runtime.CompilerServices;

namespace ReportingLibrary
{
    public class ExtentTestManager
    {
        [ThreadStatic]
        private static ExtentTest _parentTest;

        [ThreadStatic]
        private static ExtentTest _childTest;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateParentTest(string testName, string description = null)
        {
            _parentTest = ExtentManager.Instance.CreateTest(testName, description);
            return _parentTest;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest CreateTest(string testName, string description = null)
        {
            _childTest = _parentTest.CreateNode(testName, description);
            return _childTest;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ExtentTest GetTest()
        {
            return _childTest;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void SetTestStatusFail(string filePath, string message)
        {
            GetTest().AddScreenCaptureFromPath(filePath);
            GetTest().Fail(message);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void SetTestStatusPass()
        {
            _parentTest.Pass("Test Passed");
        }
    }
}
