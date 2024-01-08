using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAreaAndVolume
{
    class Program
    {
        static void GetAreaAndVolume (double a, out double S, out double V)
        {
            S = 6 * a * a;
            V = a * a * a;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double s;
            double v;
            GetAreaAndVolume((double)a, out s, out v);
            Console.WriteLine("Площадь поверхности куба равна: {0:.00}. Объем куба равен {1:.00}.",s,v);
            Console.ReadKey();

        }
    }
}
