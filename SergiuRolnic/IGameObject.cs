using System;

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
         
         
        }

        /// <summary>Update the position of the object</summary>
        /// <param name="position">The new position</param>
        void UpdatePosition(Point position);

      
    }
}
