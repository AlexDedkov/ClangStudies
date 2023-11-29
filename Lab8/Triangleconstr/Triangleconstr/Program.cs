using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Creating a triangle with set sides
        Triangle Trian = new Triangle(3, 4, 5);
        Trian.PrintExist(Trian);

        // Creating a triangle with equal sides
        Triangle Trian1 = new Triangle(6);
        Trian1.PrintExist(Trian1);

        Triangle Trian2 = new Triangle(6,0,3);
        Trian2.PrintExist(Trian2);

    }
}

public class Triangle
{
    public int x;
    public int y;
    public int z;

    // Constructor for a triangle with different sides
    public Triangle(int sideA, int sideB, int sideC)
    {
        x = sideA;
        y = sideB;
        z = sideC;
    }

    // Constructor for a triangle with equal sides
    public Triangle(int equalSide)
    {
        x = y = z = equalSide;
    }

    private bool Check()
    {
        return x != 0 && y != 0 && z != 0;
    }

    private double Square()
    {
        if (!Check()) return 0; // If the triangle doesn't exist, square is 0
        double per = Per();
        return Math.Sqrt(per * (per - x) * (per - y) * (per - z));
    }

    private int Per()
    {
        return x + y + z;
    }
    public void PrintExist(Triangle Print)
    {
        Console.WriteLine("Triangle exists?");
        bool checkedValue = Check();
        if (checkedValue)
        {
            Console.WriteLine("Side a: {0}", Print.x);
            Console.WriteLine("Side b: {0}", Print.y);
            Console.WriteLine("Side c: {0}", Print.z);
            Console.WriteLine("Triangle exists!");
            Console.WriteLine("Perimeter {0}", Per());
            Console.WriteLine("Square is {0:F2}", Square());
        }
        else
        {
            PrintNotExist(Print);
        }
    }
    public void PrintNotExist(Triangle Print)
    {
        Console.WriteLine("Side a: {0}", Print.x);
        Console.WriteLine("Side b: {0}", Print.y);
        Console.WriteLine("Side c: {0}", Print.z);
        Console.WriteLine("One of the sides is 0, triangle doesn't exist");
    }
}