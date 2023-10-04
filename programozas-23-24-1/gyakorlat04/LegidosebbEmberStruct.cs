using System;
internal class LegidosebbEmber
{
    static void Main(string[] args)
    {
        int n;
        int.TryParse(Console.ReadLine(), out n);
        int[] ev = new int[n];
        int[] ho = new int[n];
        int[] nap = new int[n];

        for (int i = 0; i < n; i++)
        {
            String sor = Console.ReadLine();
            ev[i] = int.Parse(sor.Split(" ")[0]);
            ho[i] = int.Parse(sor.Split(" ")[1]);
            nap[i] = int.Parse(sor.Split(" ")[2]);
        }

        int minHely = 0;
        int minDatumEv = ev[0];
        int minDatumHo = ho[0];
        int minDatumNap = nap[0];

        for (int j = 0; j < n; j++)
        {
            if (ev[j] < minDatumEv || (ev[j] == minDatumEv && ho[j] < minDatumHo) || (ev[j] == minDatumEv && ho[j] == minDatumHo && nap[j] < minDatumNap))
            {
                minHely = j;
                minDatumEv = ev[j];
                minDatumHo = ho[j];
                minDatumNap = nap[j];
            }
        }

        minHely = minHely + 1;
        Console.WriteLine(minHely);
    }
}