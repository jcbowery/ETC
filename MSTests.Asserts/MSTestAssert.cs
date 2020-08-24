using Asserts;
using System;
using MST = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.Asserts
{
    public class MSTestAssert : IAssert
    {
        public void AreEqual(object expected, object actual)
        {
            MST.Assert.AreEqual(expected, actual);
        }
        public void AreEqual(object expected, object actual, string message)
        {
            MST.Assert.AreEqual(expected, actual, message);
        }
        public void AreEqual<T>(T expected, T actual) where T : class
        {
            MST.Assert.AreEqual<T>(expected, actual);
        }
        public void AreEqual<T>(T expected, T actual, string message) where T : class
        {
            MST.Assert.AreEqual<T>(expected, actual, message);
        }
        public void AreNotEqual(object expected, object actual)
        {
            MST.Assert.AreNotEqual(expected, actual);
        }
        public void AreNotEqual(object expected, object actual, string message)
        {
            MST.Assert.AreNotEqual(expected, actual, message);
        }
        public void AreNotEqual<T>(T expected, T actual) where T : class
        {
            MST.Assert.AreNotEqual<T>(expected, actual);
        }
        public void AreNotEqual<T>(T expected, T actual, string message) where T : class
        {
            MST.Assert.AreNotEqual<T>(expected, actual, message);
        }
        public void Fail(string message)
        {
            MST.Assert.Fail(message);
        }
        public void IsFalse(bool condition)
        {
            MST.Assert.IsFalse(condition);
        }
        public void IsFalse(bool condition, string message)
        {
            MST.Assert.IsFalse(condition, message);
        }
        public void IsInstanceOfType(object value, Type expectedType)
        {
            MST.Assert.IsInstanceOfType(value, expectedType);
        }
        public void IsInstanceOfType(object value, Type expectedType, string message)
        {
            MST.Assert.IsInstanceOfType(value, expectedType, message);
        }
        public void IsNotNull(object value)
        {
            MST.Assert.IsNotNull(value);
        }
        public void IsNotNull(object value, string message)
        {
            MST.Assert.IsNotNull(value, message);
        }
        public void IsNull(object value)
        {
            MST.Assert.IsNull(value);
        }
        public void IsNull(object value, string message)
        {
            MST.Assert.IsNull(value, message);
        }
        public void IsTrue(bool condition)
        {
            MST.Assert.IsTrue(condition);
        }
        public void IsTrue(bool condition, string message)
        {
            MST.Assert.IsTrue(condition, message);
        }
    }
}
