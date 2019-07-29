using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private int[] array;

        [SetUp]
        public void TestSetUp()
        {
            array = new int[] { 1, 2, 3, 4 };
        }

        [TearDown]
        public void TestTearDown()
        {
            array = null;
        }

        [Test]
        public void TestWithEqual()
        {
            Assert.AreEqual(4, array.Length);
            Assert.That(array.Length, Is.EqualTo(4));
        }

        [Test]
        public void TestWithExactly()
        {
            Assert.That(array, Has.Exactly(1).EqualTo(3));
            Assert.That(array, Has.Exactly(3).GreaterThan(1));
            Assert.That(array, Has.Exactly(4).LessThan(100));
        }
    }
}
