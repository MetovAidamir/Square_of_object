using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public abstract class Square
    {
        public abstract double Square_obj();

    }
    public class Square_of_circle : Square
    {
        double Radius;
        double S;
        public Square_of_circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double Square_obj()
        {
            if (Radius <= 0)
            {
                Console.WriteLine("Не введен радиус");
                return 0;
            }
            else
            {
                S = Math.PI * Math.Pow(Radius, 2);
                Console.WriteLine($"Радиус круга:{S:f}");
                return Math.Round(S, 2);
            }
        }
    }
    public class Square_of_triangle : Square
    {
        double a, b, c;
        double S;
        public Square_of_triangle(double a1, double b1, double c1)
        {
            this.a = a1;
            this.b = b1;
            this.c = c1;
            if (a > b) (a, b) = (b, a); if (b > c) (b, c) = (c, b); if (a > b) (a, b) = (b, a);
        }
        public override double Square_obj()
        {
            
            if (a + b <= c)
            {
                Console.WriteLine("Это не треугольник");
                return 0;
            }
            else
            if (a == c)
            {
                S = ((Math.Sqrt(3) / 4) * Math.Pow(a, 2));
                Console.WriteLine($"Площадь равносторонего треугольника:{S:f}");
                return Math.Round(S, 2);
            }
            else
            if (a == b)
            {
                //(c / 4) Math.Sqrt((4 *) - (Math.Pow(c, 2)) 
                S = (c / 4) * Math.Sqrt((4 * Math.Pow(a, 2)) - Math.Pow(c, 2));
                Console.WriteLine($"Площадь равнобедренного треугольника:{S:f}");
                return Math.Round(S, 2);
            }
            else
                if (b == c)
            {
                S = (a / 4) * Math.Sqrt((4 * Math.Pow(b, 2)) - Math.Pow(a, 2));
                Console.WriteLine($"Площадь равнобедренного треугольника:{S:f}");
                return Math.Round(S, 2);
            }
            else
            if (a * a + b * b == c * c)
            {
                S = 0.5 * a * b;

                Console.WriteLine($"Площадь прямоугольного треугольника:{S:f}");
                return Math.Round(S, 2);
            }
            else return 0;


        }
    }
}






