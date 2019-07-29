using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void HelloMe()
        {
            int[] array = new int[]{1, 2, 3, 4, 5};
            // it can custom assert message and result :)
            Assert.That(false, "HelloMe Array", array);
        }
    }
}
