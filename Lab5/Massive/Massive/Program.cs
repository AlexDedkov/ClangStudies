using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

class Massive
{
    static void Main()
    {
        Console.WriteLine("Enter amount of numbers in array: ");
        int ar = int.Parse(Console.ReadLine());
        int[] a = new int[ar];
        InputArray(a);
        Output(a);
        Aver(a);
        PosandNeg(a);
        OddEven(a);

    }
    public static void InputArray(int[] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
                Console.Write("Enter value for [{0}] : ", i);
                a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }
    public static void Output(int[] result)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.Write("{0} ", result[i]);
            Console.WriteLine();
        }
    }
    public static int Summ(int[] a)
    {
        int sum = a.Sum();
        Console.WriteLine("Here summ of array: {0}",sum);
        return sum;
    }
    public static decimal Aver(int[] a)
    {
        int sum = Summ(a);
        decimal result = (decimal)sum / a.Length;
        Console.WriteLine("Here average of array: {0}", result);
        return result;
    }
    public static void PosandNeg(int[] a)
    {
        var pos = a.Where(x => x > 0);
        var neg = a.Where(x => x < 0);
        Console.WriteLine("Here is positive element summ :{0}", pos.Sum());
        Console.WriteLine("Here is negative element summ: {0}", neg.Sum());
    }
    public static void OddEven(int[] a)
    {
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 != 0)
            {
                sumOdd += a[i];
            }
            else
            {
                sumEven += a[i];
            }
        }
        Console.WriteLine("Here is Odd numbers summ: {0}", sumOdd);
        Console.WriteLine("Here is Even numbers summ: {0}", sumEven);
    }

}