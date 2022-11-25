﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTask;

namespace MathTaskTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            int actual = Geometry.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
