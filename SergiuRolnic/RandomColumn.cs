using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
    public class RandomColumn : AbstractColumn
    {

        private static readonly double minHeight = 50;
        private static readonly double maxHeight = 350;
        private readonly Random random;
        private double newHeight;

        /// <summary>The abstract class of columns</summary>
        /// <param name="position">The new position</param>
        /// <param name="type">True if the column is lasertype</param>
        /// /// <param name="height">The height</param>
        public RandomColumn(Point position, bool type, double height)
            : base(position, type)
        {
            this.newHeight = height;
            this.random = new Random();
        }

        /// <summary>Set the height of the column</summary>
        public override int UpdateHeight()
        {
            return (int)(this.newHeight == 0 ? (minHeight + (maxHeight - minHeight) * random.NextDouble()) : this.newHeight);
        }
    }
}
