using System;

public class Butterbeer
{
	public Butterbeer()
    //static void Main(string[] args)
    {
        // deklarálás
        int n; int m; int[,] jegyek;
        bool van; int legjobb;
        (n, m, jegyek) = beolvas();
        (van, legjobb) = legjobb_jo_tanulo(n, m, jegyek);
        kiir(van, legjobb);
    }
    static (int n, int m, int[,] jegyek) beolvas()
    {
        int n, m;
        int[,] jegyek;
        Console.Write("Varazstanoncok szama = ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("Jegyek szama = ");
        int.TryParse(Console.ReadLine(), out m);
        jegyek = new int[n, m];
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                Console.Write("{0}. varazstanonc {1} jegye = ", i, j);
                int.TryParse(Console.ReadLine(), out jegyek[i - 1, j - 1]);
            }
        }
        return (n, m, jegyek);
    }
    static bool jo(int diak, int m, int[,] jegyek)
    {
        int tantargy = 1;
        while (tantargy <= m &&
        4 <= jegyek[diak - 1, tantargy - 1] &&
        jegyek[diak - 1, tantargy - 1] <= 5)
        {
            tantargy = tantargy + 1;
        }
        bool mind = tantargy > m;
        return mind;
    }
    static int osszeg(int diak, int m, int[,] jegyek)
    {
        int s = 0;
        for (int tantargy = 1; tantargy <= m; tantargy++)
        {
            s = s + jegyek[diak - 1, tantargy - 1];
        }
        return s;
    }
    static (bool van, int legjobb) legjobb_jo_tanulo(int n, int m, int[,] jegyek)
    {
        bool van;
        int legjobb;
        int maxert = 0;
        legjobb = 0;
        van = false;
        for (int diak = 1; diak <= n; diak++)
        {
            bool joe = jo(diak, m, jegyek);
            if (van && joe)
            {
                int ossz = osszeg(diak, m, jegyek);
                if (ossz > maxert)
                {
                    maxert = ossz;
                    legjobb = diak;
                }
            }
            else if (!van && joe)
            {
                van = true;
                maxert = osszeg(diak, m, jegyek);
                legjobb = diak;
            }
        }
        return (van, legjobb);
    }

    static void kiir(bool van, int legjobb)
    {
        if (van)
        {
            Console.WriteLine("A legjobb tanuló: {0}", legjobb);
        }
        else
        {
            Console.WriteLine("Nincs ilyen tanuló");
        }
    }
}
