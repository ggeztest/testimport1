using System;
using NUnit;
using NUnit.Framework;

namespace UnitTestProject9
{
    [TestFixture]
    public class UnitTest1
    {
        public static int i = 0;

        [Test]
        public void Pass01()
        {
            Console.WriteLine("Pass01 Test");
            Assert.IsTrue(true);
        }

        [Ignore("reason")]
        [Test]
        public void Pass02()
        {
            Console.WriteLine("Pass02 Test");
            Assert.IsTrue(true);
        }
    }
}
