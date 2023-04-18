using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;


namespace hw10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            //arrange
            Point p1 = new Point { x = 0, y = 0 };
            Point p2 = new Point { x = 1, y = 0 };
            double expected = 1.0;
            //act
            double res = hw10.Point.Triangle.Distance(p1, p2);

            //assert
           Assert.AreEqual(expected, res);

        }
    }
}
