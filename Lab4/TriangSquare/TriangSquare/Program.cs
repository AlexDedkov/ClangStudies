using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

internal class Operation
{
    static bool Check(double x, double y, double z)
    {
        if (x != 0 & y != 0 & z != 0)
            return true;
        else
            return false;
    }

    public static double Square(double x, double y, double z)
    {
        if (Operation.Check(x, y, z) == true)
        {
            double p = x + y + z;
            double fin = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return fin;
        } 
        else
        {
            Console.WriteLine("Its not a triangle");
            return 0;
        }

    }
    public static double Square(double x)
    {
        if (x !=0)
        {
            double temp = x * 3;
            double s = Math.Sqrt(temp * (temp - x) * (temp - x) * (temp - x));
            return s;
        }
        else
        {
            Console.WriteLine("Not a triangle");
            return 0;
        }

    }
}
internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter first side:");
        double z = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second side:");
        double y = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third side:");
        double x = Double.Parse(Console.ReadLine());
        if (x == y && y == z)
        {
            double squaresame = Operation.Square(x);
            Console.WriteLine("Triangle has same sides, square:" + squaresame);
        }
        else
        {
            double squaredif = Operation.Square(x, y, z);
            Console.WriteLine("Triangle has different sides, square:" + squaredif);
        }
    }
}