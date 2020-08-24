using Asserts;
using System;
using NU = NUnit.Framework;

namespace NUnit.Asserts
{
    public class NunitAssert : IAssert
    {
        public void AreEqual(object expected, object actual)
        {
            NU.Assert.That(actual, NU.Is.EqualTo(expected));
        }

        public void AreEqual(object expected, object actual, string message)
        {
            NU.Assert.That(actual, NU.Is.EqualTo(expected), message);
        }
        public void AreEqual<T>(T expected, T actual) where T : class
        {
            NU.Assert.That<T>(actual, NU.Is.EqualTo(expected));
        }
        public void AreEqual<T>(T expected, T actual, string message) where T : class
        {
            NU.Assert.That<T>(actual, NU.Is.EqualTo(expected), message);
        }
        public void AreNotEqual(object expected, object actual)
        {
            NU.Assert.That(actual, NU.Is.Not.EqualTo(expected));
        }
        public void AreNotEqual(object expected, object actual, string message)
        {
            NU.Assert.That(actual, NU.Is.Not.EqualTo(expected), message);
        }
        public void AreNotEqual<T>(T expected, T actual) where T : class
        {
            NU.Assert.That<T>(actual, NU.Is.Not.EqualTo(expected));
        }
        public void AreNotEqual<T>(T expected, T actual, string message) where T : class
        {
            NU.Assert.That<T>(actual, NU.Is.Not.EqualTo(expected), message);
        }
        public void Fail(string message)
        {
            NU.Assert.Fail(message);
        }
        public void IsFalse(bool condition)
        {
            NU.Assert.That(condition, NU.Is.False);
        }
        public void IsFalse(bool condition, string message)
        {
            NU.Assert.That(condition, NU.Is.False, message);
        }
        public void IsInstanceOfType(object value, Type expectedType)
        {
            NU.Assert.That(value, NU.Is.TypeOf(expectedType));
        }
        public void IsInstanceOfType(object value, Type expectedType, string message)
        {
            NU.Assert.That(value, NU.Is.TypeOf(expectedType), message);
        }
        public void IsNotNull(object value)
        {
            NU.Assert.That(value, NU.Is.Not.Null);
        }
        public void IsNotNull(object value, string message)
        {
            NU.Assert.That(value, NU.Is.Not.Null, message);
        }
        public void IsNull(object value)
        {
            NU.Assert.That(value, NU.Is.Null);
        }
        public void IsNull(object value, string message)
        {
            NU.Assert.That(value, NU.Is.Null, message);
        }
        public void IsTrue(bool condition)
        {
            NU.Assert.That(condition, NU.Is.True);
        }
        public void IsTrue(bool condition, string message)
        {
            NU.Assert.That(condition, NU.Is.True, message);
        }
    }
}
