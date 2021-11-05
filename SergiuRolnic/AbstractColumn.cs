using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
    abstract class AbstractColumn : IColumn
    {
        private readonly static int width = 50;
        private readonly static int genericHeight = 200;
        private readonly Boolean laserType;
        private Rectangle column;
        private int height;

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
       
        public int Height
        {
            get { return height; }
            set { height = UpdateHeight(); }
        }

        public abstract int UpdateHeight();
       

        public int Width => this.column.Width;

        public Rectangle Column => this.column;

        public bool IsLaserType => this.laserType;

        public Point Position 
        {
            get { return column.Location; } 
            set => column.Location = value; 
        }
    }
}
