using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Distancecalc
{
    public struct Dist
    {
        public int foot;
        public int inch;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dist first;
            Console.WriteLine("Enter first foot value");
            string foot1 = Console.ReadLine();
            Console.WriteLine("Enter first inch value");
            string inch1 = Console.ReadLine();
            first.foot = int.Parse(foot1);
            first.inch = int.Parse(inch1);
            Dist second;
            Console.WriteLine("Enter second foot value");
            string foot2 = Console.ReadLine();
            Console.WriteLine("Enter second inch value");
            string inch2 = Console.ReadLine();
            second.foot = int.Parse(foot2);
            second.inch = int.Parse(inch2);
            Dist third;
            third.foot = first.foot+second.foot;
            third.inch = first.inch+second.inch;
            do
            {
                third.foot++;
                third.inch = third.inch - 12;
            } while (third.inch >= 12);
            Console.WriteLine($"{third.foot} ' - {third.inch} \"");
        }
    }
}
