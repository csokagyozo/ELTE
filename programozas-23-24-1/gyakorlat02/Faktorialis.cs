using System;

public class Faktorialis
{
    //static void Main(string[] args)
    public Faktorialis()
	{
        int n;
        int fakt = 1;

        Console.Write("n: ");
        int.TryParse(Console.ReadLine(), out n);

        if (n < 0 || n > 14)
        {
            Console.WriteLine("0 <= n <= 14");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            fakt = fakt * i;
        }
        
        Console.WriteLine("{0} faktoriális = {1}", n, fakt);
    }
}
