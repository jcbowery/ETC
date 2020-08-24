using System;
using Unity;
using Utilities;

namespace Asserts
{
    public static class Assert
    {
        private static readonly IAssert assert;
        static Assert()
        {
            assert = UnityContainerFactory.GetContainer().Resolve<IAssert>();
        }
        public static void AreEqual(object expected, object actual)
        {
            assert.AreEqual(expected, actual);
        }
        public static void AreEqual(object expected, object actual, string message)
        {
            assert.AreEqual(expected, actual, message);
        }
        public static void AreEqual<T>(T expected, T actual) where T : class
        {
            assert.AreEqual<T>(expected, actual);
        }
        public static void AreEqual<T>(T expected, T actual, string message) where T : class
        {
            assert.AreEqual<T>(expected, actual, message);
        }
        public static void AreNotEqual(object expected, object actual)
        {
            assert.AreNotEqual(expected, actual);
        }
        public static void AreNotEqual(object expected, object actual, string message)
        {
            assert.AreNotEqual(expected, actual, message);
        }
        public static void AreNotEqual<T>(T expected, T actual) where T : class
        {
            assert.AreNotEqual<T>(expected, actual);
        }
        public static void AreNotEqual<T>(T expected, T actual, string message) where T : class
        {
            assert.AreNotEqual<T>(expected, actual, message);
        }
        public static void IsFalse(bool condition)
        {
            assert.IsFalse(condition);
        }
        public static void IsFalse(bool condition, string message)
        {
            assert.IsFalse(condition, message);
        }
        public static void IsTrue(bool condition)
        {
            assert.IsTrue(condition);
        }
        public static void IsTrue(bool condition, string message)
        {
            assert.IsTrue(condition, message);
        }
        public static void IsNull(object value)
        {
            assert.IsNull(value);
        }
        public static void IsNull(object value, string message)
        {
            assert.IsNull(value, message);
        }
        public static void IsNotNull(object value)
        {
            assert.IsNotNull(value);
        }
        public static void IsNotNull(object value, string message)
        {
            assert.IsNotNull(value, message);
        }
        public static void Fail(string message)
        {
            assert.Fail(message);
        }
        public static void IsInstanceOfType(object value, Type expectedType)
        {
            assert.IsInstanceOfType(value, expectedType);
        }
        public static void IsInstanceOfType(object value, Type expectedType, string message)
        {
            assert.IsInstanceOfType(value, expectedType, message);
        }
    }
}
