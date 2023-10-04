using System;

internal class EsosNapokSzama
{
    static void Main(string[] args)
    {
        // Deklaráció: spec be, ki
        int n;
        int[] m;
        int esosdb;
        // Beolvasás
        bool jo;
        Console.Error.Write("Hány nap: ");
        int.TryParse(Console.ReadLine(), out n);
        m = new int[n];
        for (int i = 1; i <= n; i++)
        {
            do
            {
                Console.Error.Write("{0}. menny: ", i);
                jo = int.TryParse(Console.ReadLine(), out m[i - 1]) && m[i - 1] >= 0;
            } while (!jo);
        }
        // Feldolgozás: stuki
        esosdb = 0;
        for (int i = 1; i <= n; i++)
        {
            if (m[i - 1] > 0)
            {
                esosdb = esosdb + 1;
            }
        }
        // Kiírás
        Console.Error.Write("Esős napok száma: ");
        Console.WriteLine(esosdb);
    }
}