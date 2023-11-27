using System;

public class Madarak
{
	//public Madarak()
	static void Main(string[] args)
    {
        // deklarálás
        int n;
        int m;
        int[,] eszlelesek;
        int db = 0;
        (n, m, eszlelesek) = teszt1();
        //(n, m, matrix) = beolvas();
        for (int i = 0; i < n; i++)
        {
            if (mindegyik(i,eszlelesek,m))
            {
                db = db + 1;
            }
        }
        Console.Write(db);
    }

    static (int n, int m, int[,] matrix) teszt1()
    {
        int n = 5, m = 6;
        int[,] matrix = {
            { 0, 4, 15, 2, 2, 3 },
            { 4, 4, 5, 2, 1, 7 },
            { 5, 0, 0, 2, 4, 5 },
            { 2, 2, 10, 0, 0, 8 },
            { 4, 1, 5, 6, 9, 3 }
        };
        return (n, m, matrix);
    }
    static (int n, int m, int[,] eszlelesek) beolvas()
    {
        int n, m;
        int[,] eszlelesek;
        Console.Write("települések száma (n) = ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("madárfajok száma (m) = ");
        int.TryParse(Console.ReadLine(), out m);
        eszlelesek = new int[n, m];
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                Console.Write("{0}. település, {1}. faj észlelések száma= ", i, j);
                int.TryParse(Console.ReadLine(), out eszlelesek[i - 1, j - 1]);
            }
        }
        return (n, m, eszlelesek);
    }

    static bool mindegyik(in int telepules, in int[,] eszlelesek, in int m)
    {
        bool mind = true;
        int j = 0;
        while (mind && j < m)
        {
            if (eszlelesek[telepules, j] == 0)
            {
                mind = false;
            }
            j++;
        }
        return mind;
    }
}
