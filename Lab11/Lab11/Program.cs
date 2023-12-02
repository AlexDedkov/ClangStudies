using System;

namespace Distancecalc
{
    public class Distance
    {
        public int Feet { get; set; }
        public double Inches { get; set; }

        // Default constructor
        public Distance()
        {
            Feet = 0;
            Inches = 0;
        }

        // Constructor accepting parameters for feet and inches
        public Distance(int feet, double inches)
        {
            Feet = feet;
            Inches = inches;
        }

        // Addition operator
        public static Distance operator +(Distance distance1, Distance distance2)
        {
            Distance result = new Distance
            {
                Feet = distance1.Feet + distance2.Feet,
                Inches = distance1.Inches + distance2.Inches
            };

            while (result.Inches >= 12)
            {
                result.Feet++;
                result.Inches -= 12;
            }

            return result;
        }

        // Subtraction operator
        public static Distance operator -(Distance distance1, Distance distance2)
        {
            Distance result = new Distance
            {
                Feet = distance1.Feet - distance2.Feet,
                Inches = distance1.Inches - distance2.Inches
            };

            while (result.Inches < 0)
            {
                result.Feet--;
                result.Inches += 12;
            }

            return result;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"{Feet}' - {Inches}\"";
        }
        public static bool operator ==(Distance distance1, Distance distance2)
        {
            if (ReferenceEquals(distance1, null))
                return ReferenceEquals(distance2, null);

            return distance1.Feet == distance2.Feet && distance1.Inches == distance2.Inches;
        }

        // Inequality operator
        public static bool operator !=(Distance distance1, Distance distance2)
        {
            return !(distance1 == distance2);
        }

        // Less than operator
        public static bool operator <(Distance distance1, Distance distance2)
        {
            if (distance1.Feet < distance2.Feet)
                return true;

            return distance1.Feet == distance2.Feet && distance1.Inches < distance2.Inches;
        }

        // Less than or equal to operator
        public static bool operator <=(Distance distance1, Distance distance2)
        {
            return distance1 < distance2 || distance1 == distance2;
        }

        // Greater than operator
        public static bool operator >(Distance distance1, Distance distance2)
        {
            return !(distance1 <= distance2);
        }

        // Greater than or equal to operator
        public static bool operator >=(Distance distance1, Distance distance2)
        {
            return !(distance1 < distance2);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize two objects using a method of your choice
            Distance first = GetDistanceFromUser("first");
            Distance second = GetDistanceFromUser("second");

            // Initialize two more objects using the default constructor
            Distance third = new Distance();
            Distance fourth = new Distance();

            // Assign the third object the value of the sum of the first two using the addition operator
            third = first + second;

            // Assign the fourth object the value of the difference of the first two using the subtraction operator
            fourth = first - second;

            // Display the distances
            Console.WriteLine($"First distance: {first}");
            Console.WriteLine($"Second distance: {second}");
            Console.WriteLine($"Sum of first and second: {third}");
            Console.WriteLine($"Difference of first and second: {fourth}");

            // Display comparisons
            Console.WriteLine($"Comparison: first == second: {first == second}");
            Console.WriteLine($"Comparison: first != second: {first != second}");
            Console.WriteLine($"Comparison: first < second: {first < second}");
            Console.WriteLine($"Comparison: first <= second: {first <= second}");
            Console.WriteLine($"Comparison: first > second: {first > second}");
            Console.WriteLine($"Comparison: first >= second: {first >= second}");

        }


        static Distance GetDistanceFromUser(string ordinal)
        {
            Console.WriteLine($"Enter {ordinal} feet value:");
            string feetInput = Console.ReadLine();
            Console.WriteLine($"Enter {ordinal} inches value:");
            string inchesInput = Console.ReadLine();

            int feet = int.Parse(feetInput);
            double inches = double.Parse(inchesInput);

            return new Distance(feet, inches);
        }

    }
}