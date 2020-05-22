using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject9
{
    [TestClass]
    public class UnitTest1
    {
        public static int i = 0;

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass01()
        {
            Console.WriteLine("Pass01 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass02()
        {
            Console.WriteLine("Pass02 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Inconclusive01()
        {
            Console.WriteLine("Inconclusive01 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Fail01()
        {
            Console.WriteLine("Fail01 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass03()
        {
            Console.WriteLine("Pass03 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Fail02()
        {
            Console.WriteLine("Fail02 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass04()
        {
            Console.WriteLine("Pass04 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Fail03()
        {
            Console.WriteLine("Fail03 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass05()
        {
            Console.WriteLine("Pass05 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass06()
        {
            Console.WriteLine("Pass06 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass07()
        {
            Console.WriteLine("Pass07 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Inconclusive02()
        {
            Console.WriteLine("Inconclusive02 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Fail04()
        {
            Console.WriteLine("Fail04 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass08()
        {
            Console.WriteLine("Pass08 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Fail05()
        {
            Console.WriteLine("Fail05 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass09()
        {
            Console.WriteLine("Pass09 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Fail06()
        {
            Console.WriteLine("Fail06 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass10()
        {
            Console.WriteLine("Pass10 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Fail07()
        {
            Console.WriteLine("Fail07 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass11()
        {
            Console.WriteLine("Pass11 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass12()
        {
            Console.WriteLine("Pass12 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Inconclusive03()
        {
            Console.WriteLine("Inconclusive03 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Fail08()
        {
            Console.WriteLine("Fail08 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass13()
        {
            Console.WriteLine("Pass13 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Fail09()
        {
            Console.WriteLine("Fail09 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass14()
        {
            Console.WriteLine("Pass14 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Fail10()
        {
            Console.WriteLine("Fail10 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass15()
        {
            Console.WriteLine("Pass15 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Fail11()
        {
            Console.WriteLine("Fail11 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass16()
        {
            Console.WriteLine("Pass16 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass17()
        {
            Console.WriteLine("Pass17 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Fail12()
        {
            Console.WriteLine("Fail12 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass18()
        {
            Console.WriteLine("Pass18 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass19()
        {
            Console.WriteLine("Pass19 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass20()
        {
            Console.WriteLine("Pass20 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass21()
        {
            Console.WriteLine("Pass21 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void PassOnRerun01()
        {
            Console.WriteLine("PassOnRerun01 Test");
            Assert.IsTrue(i++ % 4 == 0);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void PassOnRerun02()
        {
            Console.WriteLine("PassOnRerun02 Test");
            Assert.IsTrue(i++ % 4 == 0);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void PassOnRerun03()
        {
            Console.WriteLine("PassOnRerun02 Test");
            Assert.IsTrue(i++ % 4 == 0);
        }


        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void PassOnRerun04()
        {
            Console.WriteLine("PassOnRerun04 Test");
            Assert.AreEqual(i++ % 4, 0, string.Format("value of i = {0}", i));
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass22()
        {
            Console.WriteLine("Pass22 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass23()
        {
            Console.WriteLine("Pass23 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Inconclusive04()
        {
            Console.WriteLine("Inconclusive04 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Fail13()
        {
            Console.WriteLine("Fail13 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass24()
        {
            Console.WriteLine("Pass24 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Fail15()
        {
            Console.WriteLine("Fail15 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass25()
        {
            Console.WriteLine("Pass25 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Fail16()
        {
            Console.WriteLine("Fail16 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass26()
        {
            Console.WriteLine("Pass26 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass27()
        {
            Console.WriteLine("Pass27 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass28()
        {
            Console.WriteLine("Pass28 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass29()
        {
            Console.WriteLine("Pass29 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Inconclusive05()
        {
            Console.WriteLine("Inconclusive05 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Fail17()
        {
            Console.WriteLine("Fail01 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass30()
        {
            Console.WriteLine("Pass30 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Fail18()
        {
            Console.WriteLine("Fail18 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass31()
        {
            Console.WriteLine("Pass31 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Fail19()
        {
            Console.WriteLine("Fail19 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass32()
        {
            Console.WriteLine("Pass32 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass33()
        {
            Console.WriteLine("Pass33 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass34()
        {
            Console.WriteLine("Pass34 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Inconclusive06()
        {
            Console.WriteLine("Inconclusive06 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Fail20()
        {
            Console.WriteLine("Fail20 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass35()
        {
            Console.WriteLine("Pass35 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Fail21()
        {
            Console.WriteLine("Fail21 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass36()
        {
            Console.WriteLine("Pass36 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Fail22()
        {
            Console.WriteLine("Fail22 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass37()
        {
            Console.WriteLine("Pass37 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Fail23()
        {
            Console.WriteLine("Fail23 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass38()
        {
            Console.WriteLine("Pass38 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass39()
        {
            Console.WriteLine("Pass39 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Inconclusive07()
        {
            Console.WriteLine("Inconclusive07 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Fail24()
        {
            Console.WriteLine("Fail24 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass40()
        {
            Console.WriteLine("Pass40 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Fail25()
        {
            Console.WriteLine("Fail25 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass41()
        {
            Console.WriteLine("Pass41 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Fail26()
        {
            Console.WriteLine("Fail26 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass42()
        {
            Console.WriteLine("Pass42 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Fail27()
        {
            Console.WriteLine("Fail127Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass43()
        {
            Console.WriteLine("Pass43 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass44()
        {
            Console.WriteLine("Pass44 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Fail28()
        {
            Console.WriteLine("Fail28 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass45()
        {
            Console.WriteLine("Pass45 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Pass46()
        {
            Console.WriteLine("Pass46 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass47()
        {
            Console.WriteLine("Pass47 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Pass48()
        {
            Console.WriteLine("Pass48 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void PassOnRerun05()
        {
            Console.WriteLine("PassOnRerun05 Test");
            Assert.IsTrue(i++ % 4 == 0);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void PassOnRerun06()
        {
            Console.WriteLine("PassOnRerun06 Test");
            Assert.IsTrue(i++ % 4 == 0);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void PassOnRerun07()
        {
            Console.WriteLine("PassOnRerun07 Test");
            Assert.IsTrue(i++ % 4 == 0);
        }


        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void PassOnRerun08()
        {
            Console.WriteLine("PassOnRerun08 Test");
            Assert.AreEqual(i++ % 4, 0, string.Format("value of i = {0}", i));
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass49()
        {
            Console.WriteLine("Pass49 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Pass50()
        {
            Console.WriteLine("Pass50 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Inconclusive08()
        {
            Console.WriteLine("Inconclusive08 Test");
            Assert.Inconclusive("Inconclusive");
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(1)]
        public void Fail29()
        {
            Console.WriteLine("Fail29 Test");
            Assert.IsTrue(false);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(2)]
        public void Pass51()
        {
            Console.WriteLine("Pass51 Test");
            Assert.IsFalse(false);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(3)]
        public void Fail30()
        {
            Console.WriteLine("Fail30 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(1)]
        public void Pass52()
        {
            Console.WriteLine("Pass52 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("BANDI")]
        [Priority(2)]
        public void Fail31()
        {
            Console.WriteLine("Fail31 Test");
            Assert.IsFalse(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass53()
        {
            Console.WriteLine("Pass53 Test");
            Assert.IsTrue(true);
        }

        [TestMethod]
        [Owner("NAGA")]
        [Priority(3)]
        public void Pass54()
        {
            Console.WriteLine("Pass54 Test");
            Assert.IsTrue(true);
        }
        [TestMethod]
        [Owner("susaluj")]
        [Priority(3)]
        public void abort()
        {
            abc();
        }
        public void abc()
        {
            abort();
        }
    }
}
