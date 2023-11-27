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
        Triangle.Print(Trian);
    }
}
public class Triangle
{
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public static bool Check(int side1, int side2, int side3)
    {
        Console.WriteLine("Entering method to check sides");
        if (side1 != 0 & side2 != 0 & side3 != 0)
            return true;
        else
            return false;
    }
    public static double Square(int side1, int side2, int side3)
    {
        double per = Per(side1, side2, side3);
        double s = Math.Sqrt(per * (per - side1) * (per - side2) * (per - side3));
        return s;
    }
    public static int Per(int side1, int side2, int side3)
    {
        int sum = side1 + side2 + side3;
        return sum;
    }
    public static void Print(Triangle Write)
    {
        Console.WriteLine("Side a: {0}", Write.x);
        Console.WriteLine("Side b: {0}", Write.y);
        Console.WriteLine("Side b: {0}", Write.z);
        Console.WriteLine("Perimeter {0}", Per(Write.x, Write.y, Write.z));
        Console.WriteLine("Square is {0:F2}", Square(Write.x, Write.y, Write.z));
    }
}