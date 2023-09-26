using System;

public class Gps
{
	//public Gps()
    static void Main(string[] args)
    {
        /*  Feladat: olvassuk be egy gps magasságadatait, és határozzuk meg
         *  az útvonal legmagasabb pontját.
         */
        // Specifikáció: http://webprogramozas.inf.elte.hu/user/gyozke/specifikacio/?data=JTdCJTIyc3BlY2lmaWNhdGlvbiUyMiUzQSUyMkJlJTNBJTIwbiVFMiU4OCU4OE4lMkMlMjBtYWdhc3NhZyVFMiU4OCU4OFIlNUIxLi5uJTVEJTVDciU1Q25LaSUzQSUyMG1heCVFMiU4OCU4OFIlMkMlMjBtYXhoZWx5JUUyJTg4JTg4TiU1Q3IlNUNuRWYlM0ElMjBuJTIwJTNFJTIwMCU1Q3IlNUNuVWYlM0ElMjBNQVgoaSUzRDEuLm4lMkMlMjBtYWdhc3NhZyU1QmklNUQpJTIwJTNEJTIwbWF4JTIwJUMzJUE5cyUyMG1hZ2Fzc2FnJTVCbWF4aGVseSU1RCUyMCUzRCUyMG1heCUyMiUyQyUyMnRlc3RzJTIyJTNBJTVCJTdCJTIyZGF0YSUyMiUzQSUyMm1hZ2Fzc2FnJTNBJTIwJTVCMC4xMiUyQzEwLjMyJTJDMTUuODclMkMxNy4wMiUyQzE2LjEwMSU1RCU1Q3IlNUNubiUzQSUyMDUlNUNyJTVDbm1heCUzQSUyMDE3LjAyJTVDciU1Q25tYXhoZWx5JTNBJTIwNCUyMiUyQyUyMm5hbWUlMjIlM0ElMjIlMjIlMkMlMjJyZXN1bHQlMjIlM0EyJTdEJTVEJTdE

        int n;
        Console.Write("Hány mérésünk van? ");
        int.TryParse(Console.ReadLine(), out n);

        float[] szint = new float[n];
        int maxhely;
        float max;

        Console.Write("Kérem a magasságokat (m): \n", n);
        int i = 0;
        while (i < n)
        {
            Console.Write("{0}. magasság: ", i + 1);
            float.TryParse(Console.ReadLine(), out szint[i]);
            i += 1;
        }

        max = szint[0];
        maxhely = 0;

        i = 0;
        while (i < n)
        {
            if (szint[i] > max)
            {
                maxhely = i;
                max = szint[i];
            }
            i += 1;
        }

        Console.Write("A legnagyobb a {0}. magasság, értéke {1}: ", maxhely + 1, max);
    }
}
