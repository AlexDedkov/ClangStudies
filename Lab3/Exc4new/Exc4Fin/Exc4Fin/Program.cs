
internal class TargetShot
{
    public struct shots
    {
        public int x;
        public int y;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter amount of shots made:");
        int shotCount = Int32.Parse(Console.ReadLine());
        int[,] Shoot = new int[shotCount, 2];
        for (int i = 0; i < shotCount; i++)
        {
            Console.WriteLine("Shot number {0}", i + 1);
            Console.WriteLine("Enter x coordinate");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter y coordinate");
            int y = Int32.Parse(Console.ReadLine());
            Shoot[i,0] = x;
            Shoot[i,1] = y;
            Console.WriteLine("x , y : {0},{1}", Shoot[i,0], Shoot[i,1]);
        }
        int sum = 0;
        for (int i = 0;i < shotCount;i++)
        {
            Console.WriteLine("Attempt No {0}", i+1);
            shots temp;
            temp.x = Shoot[i,0];
            temp.y = Shoot[i,1];
            int Score = Scorefin(temp);
            sum += Score;

        }
        Console.WriteLine("Score: {0}", sum);
        Console.ReadLine();

    }
    public static int Scorefin(shots t)
    {
        int result = 0;
        switch (t.x, t.y)
        {
            case ( < 5, < 5):
                result = 10; break;
            case ( < 10, < 5):
                result = 5; break;
            case ( < 5, < 10):
                result = 5; break;
            case ( < 10, < 10):
                result = 1; break;
        }
        Console.WriteLine("Score for attempt:{0}", result);
        return result;
    }

}
