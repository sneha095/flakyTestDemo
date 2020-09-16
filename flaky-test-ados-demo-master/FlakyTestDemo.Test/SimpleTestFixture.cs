using NUnit.Framework;
using System;
using NUnit.Framework.Constraints;

namespace FlakyTestDemo.Test
{
    [TestFixture]
    public class SimpleTestFixture
    {
        [Test]
        public void DeliberateFlakyTest()
        {
            var randomNumber = new Random().Next();
            var result = randomNumber % 5;

            Assert.That(result, Is.Not.EqualTo(0));
        }

        [Test]
        public void NotFlakyTest0()
        {
            Assert.That(0, Is.EqualTo(0));
        }
        
        [Test]
        public void NotFlakyTest1()
        {
            Assert.That(1, Is.EqualTo(1));
        }
        
        [Test]
        public void NotFlakyTest2()
        {
            Assert.That(2, Is.EqualTo(2));
        }
        
        [Test]
        public void NotFlakyTest()
        {
            Assert.That(2, Is.EqualTo(2));
        }
    }
}
