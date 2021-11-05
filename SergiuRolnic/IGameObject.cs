using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{


    /// <summary>Represent a generic object.</summary>
    public interface IGameObject
    {



        /// <summary>The position of the object.</summary>
        /// <returns>Return the point position of the object.</returns>
        Point Position
        {
         
             get;
             set;
         
        }




    }
}
