using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAreasOf2Triangles
{
    class Program
    {
        static double CalculateArea (double a, double b, double c)
        {
            if (a<=0||b<=0||c<=0)
            {
                Console.WriteLine("Длины сторон треугольника должны быть положительными числами");
            }
            if (a+b<=c||a+c<=b||b+c<=a)
            {
                Console.WriteLine("Данные стороны не могут образовывать треугольник");
            }
            double semiPerimter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimter * (semiPerimter - a) * (semiPerimter - b) * (semiPerimter - c));
            return area;
        }
        static string CompareTriangles (double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double area1 = CalculateArea(a1, b1, c1);
            double area2 = CalculateArea(a2, b2, c2);
            if (area1 >area2)
            {
                return "Площадь первого треугольника больше второго";
            }
            else if (area1<area2)
            {
                return "Площадь второго треугольника больше первого";
            }
            else
            {
                return "Площади треугольников равны";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Введите длины сторон второго треугольника:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            string result = CompareTriangles(a1, b1, c1, a2, b2, c2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
