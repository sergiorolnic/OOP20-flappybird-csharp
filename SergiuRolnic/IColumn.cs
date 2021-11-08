using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
    /// <summary>Represent a generic Column.</summary>
    public interface IColumn: IGameObject
    {

        /// <summary>The height of the column.</summary>
        /// <returns>Return the height of the object.</returns>
        int Height
        {

            get;
           

        }
       

       

        /// <summary>The width of the column.</summary>
        /// <returns>Return the width of the object.</returns>
        int Width
        {
            get;
        }

   
        /// <summary>The rectangle which represent the column.</summary>
        /// <returns>Return the rectangle.</returns>
        Rectangle Column
        {
            get;
        }

       
        /// <summary>The type of the column.</summary>
        /// <returns>Return true if it's a lasertype.</returns>
        Boolean IsLaserType
        {
            get;
        }




    }
}
