using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
     [TestClass]
    class ColumnTest
    {
        [TestMethod]
        public void UpdatePosTest()
        {
            Point p = new Point
            {
                X = 200,
                Y = 100
            };
            IColumn col = new BasicColumn(p, false);

            Assert.AreEqual(200, col.Position.X);
            Console.WriteLine(col.Position.X);
            Point c = col.Position;
            c.X--;
            col.Position = c;
            Assert.AreEqual(199, col.Position.X);
            c.X--;
            col.Position = c;
            Assert.AreEqual(198, col.Position.X);
        }

    }
}
