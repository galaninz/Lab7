using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольник");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetArea(x1, y1, z1);
            Console.WriteLine("Введите стороны второго треугольник");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetArea(x2, y2, z2);

            if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника - {0} больше", s1);
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Площадь второго треугольника - {0} больше", s2);
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadKey();

        }
    }
}
