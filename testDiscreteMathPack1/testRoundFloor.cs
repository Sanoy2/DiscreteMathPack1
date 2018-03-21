﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscreteMathPack1;

namespace testDiscreteMathPack1
{
    [TestClass]
    public class testRoundFloor
    {
        [TestMethod]
        public void floor_when_1_p_1_then_1()
        {
            int expected = 1;
            int actual = Operations.RoundFloor(1.1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void floor_when_1_p_5_then_1()
        {
            int expected = 1;
            int actual = Operations.RoundFloor(1.5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void floor_when_1_p_9_then_1()
        {
            int expected = 1;
            int actual = Operations.RoundFloor(1.9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void floor_when_NEGATIVE_1_p_1_then_N_2()
        {
            int expected = -2;
            int actual = Operations.RoundFloor(-1.1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void floor_when_NEGATIVE_1_p_5_then_N_2()
        {
            int expected = -2;
            int actual = Operations.RoundFloor(-1.5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void floor_when_NEGATIVE_1_p_9_then_N_2()
        {
            int expected = -2;
            int actual = Operations.RoundFloor(-1.9);
            Assert.AreEqual(expected, actual);
        }
    }
}
