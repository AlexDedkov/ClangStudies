using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TriangleSq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления площади треугольника");
            Console.WriteLine("Введите периметр ");
            string tempor = Console.ReadLine();
            double i = Double.Parse(tempor);
            double j = i / 3;
            double trSq = Math.Sqrt(i * (i - j) * (i - j) * (i - j));
            double trSqFin = Math.Round(trSq, 2);
            Console.WriteLine("Сторона Площадь");
            Console.WriteLine("{0,0} {1,12}",j, trSqFin);
            Console.ReadLine();
        }
    }
}
