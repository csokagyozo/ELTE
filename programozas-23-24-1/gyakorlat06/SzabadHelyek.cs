// Mester / Eldöntés / 4: Szomszédos szabad helyek
// https://mester.inf.elte.hu:8181/faces/leiras.xhtml?jfwid=cde5adb407bd048b00c858ea954d:20

using System;

public class SzabadHelyek
{
	//public SzabadHelyek()
    static void Main(string[] args)
    {
        // Deklaráció: spec be, ki
        int n;
        int m;
        int[,] helyek;
        bool vanSzomszedos = false;

        // Beolvasás
        String sor = Console.ReadLine();
        n = int.Parse(sor.Split(" ")[0]);
        m = int.Parse(sor.Split(" ")[1]);
        helyek = new int[n,2*m];

        for (int i = 0; i < n; ++i)
        {
            sor = Console.ReadLine();
            String[] balsor = new String[m];
            balsor = sor.Split(" ");
            
            for (int j = 0; j < m; j++)
            {
                helyek[i,j] = int.Parse(balsor[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            sor = Console.ReadLine();
            String[] jobbsor = new String[m];
            jobbsor = sor.Split(" ");

            for (int j = 0; j < m; j++)
            {
                helyek[i,2*m - j - 1] = int.Parse(jobbsor[j]);
            }
        }

        // Ellenorzes:
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 2 * m; j++)
            {
                Console.Error.Write(helyek[i, j]);
            }
            Console.Error.Write("\n");
        }

        // Feldolgozas
                for (int i = 0; !vanSzomszedos && i < n; i++)
        {
            for (int j = 0; !vanSzomszedos && j < 2*m-1; j++)
            {
                if (helyek[i,j] == 0 && helyek[i,j+1] == 0)
                {
                    vanSzomszedos = true;
                }
            }
        }

        // Kiiras
        Console.Write("{0}", vanSzomszedos ? "IGEN" : "NEM");
    }
}
