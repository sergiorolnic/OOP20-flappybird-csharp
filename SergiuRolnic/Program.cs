using System;
using System.Drawing;

namespace SergiuRolnic
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point
            {
                X = 200,
                Y = 100
            };
            IColumn col = new BasicColumn(p,false);

            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(col.Position.X);
                Point c = col.Position;
                c.X--;
                col.Position = c;
            }

           
        }
    }
}
