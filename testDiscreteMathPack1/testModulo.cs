using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscreteMathPack1;

namespace testDiscreteMathPack1
{
    [TestClass]
    public class testModulo
    {
        /*
         * Exceptions
         */

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void modulo_when_10_by_0_then_exception()
        {
            Modulo.Division(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void modulo_when_neg_10_by_0_then_exception()
        {
            Modulo.Division(-10, 0);
        }

        /*
         * Natural numbers
         */

        [TestMethod]
        public void modulo_when_1_by_1_then_0()
        {
            int expected = 1 % 1;
            int actual = Modulo.Division(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_1_by_2_then_1()
        {
            int expected = 1 % 2;
            int actual = Modulo.Division(1, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_1_by_3_then_1()
        {
            int expected = 1 % 3;
            int actual = Modulo.Division(1, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_1_then_0()
        {
            int expected = 12 % 1;
            int actual = Modulo.Division(12, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_2_then_0()
        {
            int expected = 12 % 2;
            int actual = Modulo.Division(12, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_3_then_0()
        {
            int expected = 12 % 3;
            int actual = Modulo.Division(12, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_4_then_0()
        {
            int expected = 12 % 4;
            int actual = Modulo.Division(12, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_5_then_2()
        {
            int expected = 12 % 5;
            int actual = Modulo.Division(12, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_6_then_0()
        {
            int expected = 12 % 6;
            int actual = Modulo.Division(12, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_7_then_5()
        {
            int expected = 12 % 7;
            int actual = Modulo.Division(12, 7);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_8_then_4()
        {
            int expected = 12 % 8;
            int actual = Modulo.Division(12, 8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_9_then_3()
        {
            int expected = 12 % 9;
            int actual = Modulo.Division(12, 9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_10_then_2()
        {
            int expected = 12 % 10;
            int actual = Modulo.Division(12, 10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_11_then_1()
        {
            int expected = 12 % 11;
            int actual = Modulo.Division(12, 11);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_12_then_0()
        {
            int expected = 12 % 12;
            int actual = Modulo.Division(12, 12);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void modulo_when_12_by_13_then_12()
        {
            int expected = 12 % 13;
            int actual = Modulo.Division(12, 13);
            Assert.AreEqual(expected, actual);
        }

        /*
         * Bigger natural numbers
         */

        [TestMethod]
        public void modulo_when_37196_by_347()
        {
            int expected = 37196 % 347;
            int actual = Modulo.Division(37196, 347);
            Assert.AreEqual(expected, actual);
        }

    }
}
