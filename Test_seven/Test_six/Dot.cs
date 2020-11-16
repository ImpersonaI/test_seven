using System;
using System.Collections.Generic;
using System.Text;

namespace Test_six
{
    class Dot
    {
        double x, y, x1, y1, z, z1;
        public double X { get; set; }
        public double Y { get; set; }

        public double X1 { get; set; }
        public double Y1 { get; set; }
               
        public Dot ()
        {

            Console.WriteLine("Input x =");
            X = Convert.ToDouble(Console.ReadLine());
            this.x = X;
            Console.WriteLine("Input y =");
            Y = Convert.ToDouble(Console.ReadLine());
            this.y = Y;
        }

        public Dot(double x, double y)
        {

            z = Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
            Console.WriteLine("Расстояние до начала координат = " + z);
            Console.WriteLine("Input x1 =");
            X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y1 =");
            Y1 = Convert.ToDouble(Console.ReadLine());

        }

        public void Do(double x1, double y1)
        {

            z1 = Math.Sqrt((X1 - X)* (X1 - X) + (Y1 - Y)* (Y1 - Y));

        }

        public void Do()
        {

            Console.WriteLine("Расстояние от точки (X1;Y1) до точки (X;Y) = " + z1);
        }

       
        
    }
}
