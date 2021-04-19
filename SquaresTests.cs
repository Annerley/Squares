using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squares;
using System;
using System.Collections.Generic;
using System.Text;

namespace Squares.Tests
{
    [TestClass()]
    public class MySquaresTests
    {
        [TestMethod()]
        public void triangle_usual_int_test()
        {
            //arrange
            double x = 3;
            double y = 4;
            double z = 5;
            double expected = 6;

            //act

            Squares c = new Squares();
            double actual = c.areaOfTriangle(x,y,z);
            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void triangle_double_test()
        {
            //arrange
            double x = 3.5;
            double y = 4.5;
            double z = 5.5;
            double expected = 7.854885024620029;

            //act

            Squares c = new Squares();
            double actual = c.areaOfTriangle(x, y, z);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void circle_10r_test()
        {
            //arrange
            double x = 10;
            double expected = 314.1592653589793;

            //act

            Squares c = new Squares();
            double actual = c.areaOfCircle(x);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void circle_100r_test()
        {
            //arrange
            double x = 100;
            double expected = 31415.926535897932;

            //act

            Squares c = new Squares();
            double actual = c.areaOfCircle(x);
            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
