using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
    /// <summary>The basic column class</summary>
    public class BasicColumn : AbstractColumn


    {
        /// <summary>The abstract class of columns</summary>
        /// <param name="position">The new position</param>
        /// /// <param name="type">True if the column is lasertype</param>
        public BasicColumn(Point position, bool type)
            :base(position,type)
        {

        }

        /// <summary>Set the height of the column</summary>
        public override int UpdateHeight()
        {
            return 0;
        }
    }
}
