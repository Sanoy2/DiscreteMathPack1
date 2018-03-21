using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscreteMathPack1;
using System.Collections.Generic;

namespace testDiscreteMathPack1
{
    [TestClass]
    public class testPrimes
    {
        [TestMethod]
        public void primes_first_1_number()
        {
            var actual = Primes.GeneratePrimes(1);
            var expected = Primes.WritePrimes(1);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_2_numbers()
        {
            var actual = Primes.GeneratePrimes(2);
            var expected = Primes.WritePrimes(2);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_3_numbers()
        {
            var actual = Primes.GeneratePrimes(3);
            var expected = Primes.WritePrimes(3);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_4_numbers()
        {
            var actual = Primes.GeneratePrimes(4);
            var expected = Primes.WritePrimes(4);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_5_numbers()
        {
            var actual = Primes.GeneratePrimes(5);
            var expected = Primes.WritePrimes(5);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_6_numbers()
        {
            var actual = Primes.GeneratePrimes(6);
            var expected = Primes.WritePrimes(6);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_7_numbers()
        {
            var actual = Primes.GeneratePrimes(7);
            var expected = Primes.WritePrimes(7);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_8_numbers()
        {
            var actual = Primes.GeneratePrimes(8);
            var expected = Primes.WritePrimes(8);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_9_numbers()
        {
            var actual = Primes.GeneratePrimes(9);
            var expected = Primes.WritePrimes(9);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_10_numbers()
        {
            var actual = Primes.GeneratePrimes(10);
            var expected = Primes.WritePrimes(10);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_46_numbers()
        {
            var actual = Primes.GeneratePrimes(46);
            var expected = Primes.WritePrimes(46);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_177_numbers()
        {
            var actual = Primes.GeneratePrimes(177);
            var expected = Primes.WritePrimes(177);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_231_numbers()
        {
            var actual = Primes.GeneratePrimes(231);
            var expected = Primes.WritePrimes(231);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_666_numbers()
        {
            var actual = Primes.GeneratePrimes(666);
            var expected = Primes.WritePrimes(666);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        [TestMethod]
        public void primes_first_1000_numbers()
        {
            var actual = Primes.GeneratePrimes(1000);
            var expected = Primes.WritePrimes(1000);
            Assert.IsTrue(ElementsOnListsAreTheSame(actual, expected));
        }

        private bool ElementsOnListsAreTheSame(List<int> list1, List<int> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
