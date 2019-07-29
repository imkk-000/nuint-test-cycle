using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void HelloMe()
        {
            Assert.Pass("Hello Me!");
        }

        [Test]
        public void HelloWorld()
        {
            Assert.Pass("Hello World!");
        }

        [Test]
        public void HelloCat()
        {
            Assert.Pass("Hello Cat!");
        }
    }
}
