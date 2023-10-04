using System;
internal class LegmelegebbNap
{
    static void Main(string[] args)
    {
        int n;
        int.TryParse(Console.ReadLine(), out n);
        int[] adatok = new int[n];
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out adatok[i]);
        }

        int maxhely = 0;
        int max = adatok[0];

        for (int j = 0; j < n; j++)
        {
            if (adatok[j] > max)
            {
                maxhely = j;
                max = adatok[j];
            }
        }

        maxhely = maxhely + 1;
        Console.WriteLine(maxhely);
    }
}