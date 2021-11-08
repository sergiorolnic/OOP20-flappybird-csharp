using System;
namespace AriannaZannoni
{
    public class BirdImpl : IBird
    {
        private readonly static double POS_X= 300;
        private readonly double genericPosy= 200;
        private readonly static double RADIUS = 25;
        private double posy;

        public BirdImpl(Point position, Boolean type)
        {
            this.posy = genericPosy;
        }

        public void UpdatePosition(double posY)
        {
            
            this.posy = posY;
        }

        public int CenterX()
        {
            
            get { return POS_X; }
        }

        public int CenterY()
        {

            get { return posy; }
        }

        public int Radius()
        {

            get { return RADIUS; }
        }
    }
}
