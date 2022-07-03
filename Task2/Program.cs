using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void GetCubeParams(double a, out double s, out double v)
        {
            s = 6 * Math.Pow(2, a);
            v = Math.Pow(3, a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetCubeParams(a, out s, out v);
            Console.WriteLine("Площадь поверхности - {0}, Объем - {1}", s, v);
            Console.ReadKey();
        }
    }
}
