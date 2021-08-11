using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Tests
{
    [TestClass()]
    public class Square_of_circleTests
    {
        [TestMethod()]
        public void Square_objTest()
        {
            double R = 30;
            double expected = 2827.43;

            Square_of_circle square_Of_Circle = new Square_of_circle(R);
            double actual= square_Of_Circle.Square_obj();

            Assert.AreEqual(expected, actual);
        }
    }
}