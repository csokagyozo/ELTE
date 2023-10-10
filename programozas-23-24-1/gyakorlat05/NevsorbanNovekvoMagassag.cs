using System;

public class NevsorbanNovekvoMagassag
{
	public NevsorbanNovekvoMagassag()
    //static void Main(string[] args)
    {
        // Deklaráció: spec be, ki
        int n;
        int[] magassag;
        bool mind;

        // Beolvasás
        Console.Error.Write("Hány tanuló: ");
        int.TryParse(Console.ReadLine(), out n);
        magassag = new int[n];
        for (int i = 1; i <= n; i++)
        {
            Console.Error.Write("{0}. tanuló neve, magassága : ", i);
            String sor = Console.ReadLine();
            magassag[i - 1] = int.Parse(sor.Split(" ")[1]);
        }

        // Feldolgozás:
        int ind = 1;
        mind = true;
        while (ind < n && magassag[ind - 1] <= magassag[ind])
        {
            ind++;
        }
        mind = ind == n;

        // Kiírás
        Console.Error.Write("Magasság szerint is növekvő sorban vannak: ");
        Console.WriteLine(mind ? "IGEN" : "NEM");
    }
}
