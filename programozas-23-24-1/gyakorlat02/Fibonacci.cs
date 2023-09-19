using System;

public class Fibonacci
{
    //static void Main(string[] args)
    public Fibonacci()
	{
        int n;
        int f = 0;

        Console.Write("n: ");
        int.TryParse(Console.ReadLine(), out n);

        if (n < 1)
        {
            Console.WriteLine("n >= 1");
            return;
        }

        if (n == 1 || n == 2)
        {
            f = 1;
        }
        else
        {
            // Fibonacci számok: 1 1 2 3 5 8 13 21 ...
            // i == 2
            int fibIMinus2 = 0;
            int fibIMinus1 = 1;
            int fibI = 1;

            for (int i = 3; i <= n; i++)
            {
                fibIMinus2 = fibIMinus1;
                fibIMinus1 = fibI;
                fibI = fibIMinus1 + fibIMinus2;
            }

            f = fibI;
        }

        Console.WriteLine("Az {0}. Fibonacci szám: {1}", n, f);

    }
}
