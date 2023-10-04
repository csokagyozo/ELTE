using System;

public class Gps
{
    static void Main(string[] args)
    {
        /*  Feladat: olvassuk be egy gps magasságadatait, és határozzuk meg
         *  az útvonal legmagasabb pontját.
         */
        // Specifikáció: http://progalap.elte.hu/specifikacio/?data=JTdCJTIyc3BlY2lmaWNhdGlvbiUyMiUzQSUyMkJlJTNBJTIwbiVFMiU4OCU4OE4lMkMlMjBtYWdhc3NhZyVFMiU4OCU4OFIlNUIxLi5uJTVEJTVDciU1Q25LaSUzQSUyMG1heCVFMiU4OCU4OFIlMkMlMjBtYXhoZWx5JUUyJTg4JTg4TiU1Q3IlNUNuRWYlM0ElMjBuJTIwJTNFJTIwMCU1Q3IlNUNuVWYlM0ElMjBNQVgoaSUzRDEuLm4lMkMlMjBtYWdhc3NhZyU1QmklNUQpLm1heCUyMCUzRCUyMG1heCUyMCVDMyVBOXMlMjBtYWdhc3NhZyU1Qm1heGhlbHklNUQlMjAlM0QlMjBtYXglMjIlMkMlMjJ0ZXN0cyUyMiUzQSU1QiU3QiUyMmRhdGElMjIlM0ElMjJtYWdhc3NhZyUzQSUyMCU1QjAuMTIlMkMxMC4zMiUyQzE1Ljg3JTJDMTcuMDIlMkMxNi4xMDElNUQlNUNyJTVDbm4lM0ElMjA1JTVDciU1Q25tYXglM0ElMjAxNy4wMiU1Q3IlNUNubWF4aGVseSUzQSUyMDQlMjIlMkMlMjJuYW1lJTIyJTNBJTIyJTIyJTJDJTIycmVzdWx0JTIyJTNBMSU3RCU1RCU3RA%3D%3D

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
