using System;

public class Primes
{ 
    public Primes()
    //static void Main(string[] args)
    {
        // deklarálás
        int n; int m; int[,] matrix;
        bool van; int legjobb;
        (n, m, matrix) = teszt1();
        //(n, m, matrix) = beolvas();

        // TODO: feldolgozás, kiírás
    }

    static (int n, int m, int[,] matrix) teszt1()
    {
        int n = 5, m = 6;
        int[,] matrix = {
            { 7, 4, 5, 2, 12, 7 },
            { 22, 4, 5, 2, 21, 17 },
            { 5, 14, 3, 2, 18, 5 },
            { 59, 58, 5, 2, 6, 8 },
            { 5, 3, 3, 2, 13, 7 }
        };
        return (n, m, matrix);
    }
    static (int n, int m, int[,] matrix) beolvas()
    {
        int n, m;
        int[,] matrix;
        Console.Write("sorok száma (n) = ");
        int.TryParse(Console.ReadLine(), out n);
        Console.Write("oszlopok száma (m) = ");
        int.TryParse(Console.ReadLine(), out m);
        matrix = new int[n, m];
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                Console.Write("mátrix[{0},{1}]. eleme = ", i, j);
                int.TryParse(Console.ReadLine(), out matrix[i - 1, j - 1]);
            }
        }
        return (n, m, matrix);
    }
}
