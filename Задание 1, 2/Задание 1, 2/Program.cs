using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1__2
{
    class Program
    {
        static void Decore()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        static double CalculateArea(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            else
                throw new Exception("Треугольник невозможен");
        }
        static string DetermineTriangleType(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    return "Прямоугольный";
                }
                if (a * a + b * b > c * c && a * a + c * c > b * b && b * b + c * c > a * a)
                {
                    return "Остроугольный";
                }
                else
                {
                    return "Тупоугольный";
                }
            }
            else
                throw new Exception("Треугольник невозможен");
        }


        static void Main(string[] args)
        {
            try
            {
                Decore();
                Console.WriteLine("Введите стороны треугольника:");
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c: ");
                double c = double.Parse(Console.ReadLine());
                Decore();
                double area = CalculateArea(a, b, c);
                Console.WriteLine("Площадь треугольника: " + area);
                string type = DetermineTriangleType(a, b, c);
                Console.WriteLine("Тип треугольника: " + type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            Decore();
            Console.ReadLine();
        }
    }
}
