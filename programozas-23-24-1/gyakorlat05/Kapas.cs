using System;

public class Kapas
{
	public Kapas()
    //static void Main(string[] args)
    {
        // Deklaráció: spec be, ki
        int n;
        int[] fogasok_szama;
        bool van;
        int ind;

        // Beolvasás
        Console.Error.Write("Hány nap: ");
        int.TryParse(Console.ReadLine(), out n);
        fogasok_szama = new int[n];
        for (int i = 1; i <= n; i++)
        {
            Console.Error.Write("{0}. napi fogások száma: ", i);
            int.TryParse(Console.ReadLine(), out fogasok_szama[i - 1]);
        }

        // Feldolgozás:
        ind = 1;
        van = false;
        while (!van && ind <= n)
        {
            if (fogasok_szama[ind - 1] == 0)
            {
                van = true;
            }
            else
            {
                ind++;
            }
        }

        // Kiírás
        Console.Error.Write("Az első nap fogás nélkül: ");
        Console.WriteLine(van ? ind : -1);
    }
}
