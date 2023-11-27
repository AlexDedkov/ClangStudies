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
    public bool Check()
    {
        if (x != 0 & y != 0 & z != 0)
            return true;
        else
            return false;
    }
    public double Square()
    {
        Check();
        double per = this.Per();
        double s = Math.Sqrt(per * (per - x) * (per - y) * (per - z));
        return s;
    }
    public int Per()
    {
        int sum = x + y + z;
        return sum;
    }
    public void PrintExist(Triangle Print)
    {
        Console.WriteLine("Triangle exists?");
        bool checkedvalue = this.Check();
        if (checkedvalue == true)
        {
            Console.WriteLine("Side a: {0}", Print.x);
            Console.WriteLine("Side b: {0}", Print.y);
            Console.WriteLine("Side b: {0}", Print.z);
            Console.WriteLine("Triangle exists!");
            Console.WriteLine("Perimeter {0}", this.Per());
            Console.WriteLine("Square is {0:F2}", this.Square());
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