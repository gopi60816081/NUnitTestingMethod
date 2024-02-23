using NUnit.Framework;
using NumberSystem;

namespace NumberTest
{
    [TestFixture]
    public class NumberTests
    {
        [Test]
        public void Even()
        {
            string expected = "Even";
            Number n = new Number(16);
            string actual = n.EvenOrOdd();
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Odd()
        {
            string expected = "Odd";
            Number n = new Number(13);
            string actual = n.EvenOrOdd();
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
