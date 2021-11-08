using System;
namespace AriannaZannoni
{
    public interface IBird
    {

        /// <summary>The Y coordinate of bird.</summary>
        /// <param name="posY">Param posY current Y coordinate of bird.</param>
        int UpdatePosition(double posY);



        /// <returns>Return value of the property centerX of bird.</returns>
        int CenterX
        {
            get;
        }


        /// <returns>Return value of the property centerY of bird.</returns>
        int CenterY
        {
            get;
        }


        /// <returns>Return value of the property radius of bird.</returns>
        int Radius
        {
            get;
        }
        
    }
}
