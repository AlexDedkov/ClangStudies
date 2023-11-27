using System.ComponentModel;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        Triangle Trian = new Triangle();
        Console.Write("Enter three sides, a:");
        Trian.x = int.Parse(Console.ReadLine());
        Console.Write("b:");
        Trian.y = int.Parse(Console.ReadLine());
        Console.Write("c:");
        Trian.z = int.Parse(Console.ReadLine());
        Trian.PrintExist(Trian);
    }
}
public class Triangle
{
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public bool Check(int side1, int side2, int side3)
    {
        if (side1 != 0 & side2 != 0 & side3 != 0)
            return true;
        else
            return false;
    }
    public double Square(int side1, int side2, int side3)
    {
        Check (side1, side2, side3);
        double per = Per(side1, side2, side3);
        double s = Math.Sqrt(per * (per - side1) * (per - side2) * (per - side3));
        return s;
    }
    public int Per(int side1, int side2, int side3)
    {
        int sum = side1 + side2 + side3;
        return sum;
    }
    public void PrintExist(Triangle Print)
    {
        Console.WriteLine("Triangle exists?");
        bool checkedvalue = Check(Print.x, Print.y, Print.z);
        if (checkedvalue == true)
        {
            Console.WriteLine("Side a: {0}", Print.x);
            Console.WriteLine("Side b: {0}", Print.y);
            Console.WriteLine("Side b: {0}", Print.z);
            Console.WriteLine("Triangle exists!");
            Console.WriteLine("Perimeter {0}", Per(Print.x, Print.y, Print.z));
            Console.WriteLine("Square is {0:F2}", Square(Print.x, Print.y, Print.z));
        } else PrintNotExist(Print);
    }
    public void PrintNotExist(Triangle Print)
    {
        Console.WriteLine("Side a: {0}", Print.x);
        Console.WriteLine("Side b: {0}", Print.y);
        Console.WriteLine("Side b: {0}", Print.z);
        Console.WriteLine("One of the sides is 0, triangle doesnt exist");
    }
}