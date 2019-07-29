using System;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void HelloMe()
        {
            int[] array = new int[] { 1, 2, 3, 4 };
            Assert.That(array, Has.Exactly(1).EqualTo(3));
            Assert.That(array, Has.Exactly(3).GreaterThan(1));
            Assert.That(array, Has.Exactly(4).LessThan(100));
        }
    }
}
