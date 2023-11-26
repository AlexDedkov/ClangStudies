internal class Program
{
    public static void Main()
    {
        double x1;
        double x2;
        Console.WriteLine("Enter a");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c");
        double c = Double.Parse(Console.ReadLine());
        (int, double, double) myResult = Calc(a, b, c);
        int final = myResult.Item1;
        x1 = Math.Round(myResult.Item2, 2);
        x2 = Math.Round(myResult.Item3, 2);
        Console.WriteLine("Tag: {0}", final);
        switch (final)
        {
            case -1:
                Console.WriteLine("No roots for a = {0}, b = {1}, c = {2}", a, b, c); break;
            case 0:
                Console.WriteLine("1 root for equasion a = {0}, b = {1}, c = {2} : x1 = x2 = {3}", a, b, c, x1); break;
            case 1:
                Console.WriteLine("2 roots for equasion a = {0}, b = {1}, c = {2}: x1 = {3}, x2 = {4}", a, b, c, x1, x2); break;
        }

    }
    public static (int, double, double) Calc(double x, double y, double z)
    {
        int flag;
        double x1 = 0;
        double x2 = 0;
        double D = Math.Pow(y, 2) - 4 * x * z;
        (int,double,double) NewResult;
        if (D < 0)
        {
            flag = -1;
        }
        else if (D == 0)
        {
            x1 = ((-y) + Math.Sqrt(D)) / (2 * x);
            x2 = ((-y) - Math.Sqrt(D)) / (2 * x);
            flag = 0;
        }
        else
        {
            x1 = ((-y) + Math.Sqrt(D)) / (2 * x);
            x2 = ((-y) - Math.Sqrt(D)) / (2 * x);
            flag = 1;
        }return (flag, x1, x2);
    }
}