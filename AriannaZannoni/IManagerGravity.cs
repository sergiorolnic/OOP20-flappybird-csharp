using System;
namespace AriannaZannoni
{
    public interface IManagerGravity
    {
        /// <summary>Set the gravity to the bird.</summary>
        /// <param name="bird">Param bird Bird..</param>
        double Gravity(IBird bird)
        {
            set;
        }
    }
}
