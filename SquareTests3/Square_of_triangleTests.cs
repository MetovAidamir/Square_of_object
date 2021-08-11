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
    public class Square_of_triangleTests
    {
        [TestMethod()]
        public void Square_objTest()
        {
            double a = 4;
            double b = 4;
            double c = 6;
            double expected = 7.94;

            Square_of_triangle square_Of_Triangle = new Square_of_triangle(a,b,c);
            double actual = square_Of_Triangle.Square_obj();

            Assert.AreEqual(expected, actual);
        }
    }
}