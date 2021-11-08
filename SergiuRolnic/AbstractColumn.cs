using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
    /// <summary>The abstract class of columns</summary>

    public abstract class AbstractColumn : IColumn
    {
        private readonly static int width = 50;
        private readonly static int genericHeight = 200;
        private readonly Boolean laserType;
        private Rectangle column;
        private int height;

        /// <summary>The abstract class of columns</summary>
        /// <param name="position">The new position</param>
        /// /// <param name="type">True if the column is lasertype</param>
        public AbstractColumn( Point position, Boolean type)
        {
            this.laserType = type;
            this.height = genericHeight;
            this.column = new Rectangle
            {
                X = position.X,
                Y = position.Y,
                Width = width,
                Height = this.height
            };

        }

        /// <summary>Get the height of the column</summary>
        /// <returns>Return the height.</returns>
        public int Height
        {
            get { return height; }
            
        }

        /// <summary>Set the height of the column</summary>
        public void SetHeight()
        {
            height = UpdateHeight();
        }



        /// <summary>Abstract method to calculate the new height</summary>
        /// <returns>Return the height.</returns>
        public abstract int UpdateHeight();

        /// <summary>Width properties</summary>
        public int Width => this.column.Width;

        /// <summary>Column properties</summary>
        public Rectangle Column => this.column;

        /// <summary>Check if column is lasertype</summary>
        /// <returns>Return true if lasertype</returns>
        public bool IsLaserType => this.laserType;

        /// <summary>Column position</summary>
        /// <returns>Return the position</returns>
        public Point Position 
        {
            get { return column.Location; } 
        }


        /// <summary>Update the position</summary>
        public virtual void UpdatePosition(Point point)
        {
            column.Location = point;
        }



        
    }
}
