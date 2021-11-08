using Microsoft.VisualStudio.TestTools.UnitTesting;
using SergiuRolnic;
using System;
using System.Drawing;

namespace SergiuRolnicTest
{
    [TestClass]
    public class ColumnTest
    {
        [TestMethod]
        public void TestBasic()
        {
            Point p = new Point
            {
                X = 200,
                Y = 100
            };
            IColumn col = new BasicColumn(p, false);
            Assert.AreEqual(200, col.Position.X);

            Point c = col.Position;
            c.X--;
            col.UpdatePosition(c);
            Assert.AreEqual(199, col.Position.X);

            c.X--;
            col.UpdatePosition(c);
            Assert.AreEqual(198, col.Position.X);

            c.X--;
            col.UpdatePosition(c);
            Assert.AreNotEqual(198, col.Position.X);
        }

        [TestMethod]
        public void TestLaser()
        {
            Point p = new Point
            {
                X = 200,
                Y = 100
            };
            IColumn col = new LaserColumn(p, false);
            Assert.AreEqual(200, col.Position.X);

            Point c = col.Position;
            c.X--;
            col.UpdatePosition(c);
            Assert.AreEqual(199, col.Position.X);

            c.X--;
            col.UpdatePosition(c);
            Assert.AreEqual(198, col.Position.X);

            c.X--;
            col.UpdatePosition(c);
            Assert.AreNotEqual(198, col.Position.X);
        }
    }
}
