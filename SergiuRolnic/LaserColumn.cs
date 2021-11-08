using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
  
    /// <summary>Represent a laser Column</summary>
    public class LaserColumn : AbstractColumn
    {
        private readonly int floorHeight = 550;
        private readonly double probability = 0.01;
        private readonly int  minHeight = 50;
        private readonly int maxHeight = 350;
        private readonly Random random;
        private bool upDownSwitch;
        private bool  typeUp;

        /// <summary>The abstract class of columns</summary>
        /// <param name="position">The new position</param>
        /// <param name="type">True if the column is lasertype</param>
        public LaserColumn(Point position, bool type)
            : base(position, type)
        {
            if (position.Y == 0)
            {
                typeUp = true;
            } else
            {
                typeUp = false;
            }

            upDownSwitch = false;
            random = new Random();

        }

        /// <summary>Update the position of the object</summary>
        /// <param name="position">The new position</param>
        public override void UpdatePosition(Point position)
        {
            Point point = new Point();

            if (this.random.NextDouble() < probability)
            {
                base.SetHeight();
            }

            if (!this.typeUp)
            {
                point.X = position.X;
                point.Y = floorHeight - Height;
          
            }
            else
            {
                point = position;
            }

            base.UpdatePosition(point);
        }

        /// <summary>Set the height of the column</summary>
        public override int UpdateHeight()
        {
            if (this.upDownSwitch)
            {
                this.upDownSwitch = false;
                return minHeight;
            }

            this.upDownSwitch = true;
            return maxHeight;
        }
    }
}
