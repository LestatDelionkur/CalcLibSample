using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib.Tests
{
    [TestClass()]
    public class TriangleAreaCalculatorTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RightTriangleZeroTest()
        {
            TriangleAreaCalculator target = new TriangleAreaCalculator();
            var area = target.RightTriangleAreaCalc(0, 1, 4);            
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RightTriangleNegativeTest()
        {
            TriangleAreaCalculator target = new TriangleAreaCalculator();
            var area = target.RightTriangleAreaCalc(-1, 1, 4);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void RightTrianglePifagorTest()
        {
            TriangleAreaCalculator target = new TriangleAreaCalculator();
            var area = target.RightTriangleAreaCalc(1, 1, 2);

        }

        [TestMethod()]
        public void RightTriangleSuccessTest()
        {
            TriangleAreaCalculator target = new TriangleAreaCalculator();
            var area = target.RightTriangleAreaCalc(3, 4, 5);

            Assert.AreEqual(6, area);

        }
    }
}