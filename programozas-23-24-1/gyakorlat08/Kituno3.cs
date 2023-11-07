using System;

// https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACoWQwUrDQBCGX2XYUwJrIW1yGbpCSxVEzUHwlOaQJhuJbTYluwpaCh7zRH2BvkmfxJlEpOpBWHZnvhn%2B%2BXd2wm51XpVVnrmqMQLFXCOYU9fFEurhedZPb3rNcRKMRkbSVafLdmluK4RixQXOrl8Rcputjwd3PFiMLy7v5BnwbNP66v4mXniNfd80W8U6chBPqCgHnKrIZ7mrEuHUfVCBBvSDU%2FQIDF1frCYWTNVfkSmp9DKPJXtUi9nDbM4WVP%2BFX7Z8IYXT1lmByU4UmctoEQYhYoUaIeR3GIKQcAKQRBLohBImqfyB%2BJyjiYQxNf7fFX6jfr3FCmFMzkxWa%2FJDUavty8YJDPbp%2FhMp7IKmugEAAA%3D%3D

public class Kituno3
{
    public Kituno3()
    //static void Main(string[] args)
    {
        // deklarálás
        int[,] jegyek;
        int db;

        jegyek = beolvas();
        db = kituno_tanulok_szama(jegyek);
        kiir(db);
    }
    static int[,] beolvas()
    {
        int n; int m;
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
        return jegyek;
    }

    static int kituno_tanulok_szama(int[,] jegyek)
    {
        int n = jegyek.GetLength(0);
        int db = 0;
        for (int sor = 1; sor <= n; sor++)
        {
            if (csakotos(sor, jegyek))
            {
                db = db + 1;
            }
        }
        return db;
    }
    static bool csakotos(int sor, int[,] jegyek)
    {
        int m = jegyek.GetLength(1);
        int oszlop = 1;
        while (oszlop <= m &&
               jegyek[sor - 1, oszlop - 1] == 5)
        {
            oszlop = oszlop + 1;
        }
        bool mind = oszlop > m;
        return mind;
    }
    static void kiir(int db)
    {
        Console.WriteLine("{0} db zacsko cukrot kell venni.", db);
    }
}
