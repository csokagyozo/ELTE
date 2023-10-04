using System;

public class JegyekAtlag
{
    static void Main(string[] args)
    {
        /*  Feladat: olvassuk be egy tanuló jegyeit,
            és írjunk ki statisztikát (jegyenként darabszám, átlag).
         */
        // Specifikacio: http://progalap.elte.hu/specifikacio/?data=JTdCJTIyc3BlY2lmaWNhdGlvbiUyMiUzQSUyMkJlJTNBJTIwbiVFMiU4OCU4OE4lMkMlMjBqZWd5ZWslRTIlODglODhOJTVCMS4ubiU1RCU1Q3IlNUNuS2klM0ElMjBhdGxhZyVFMiU4OCU4OFIlMkMlMjBkYXJhYiVFMiU4OCU4OE4lNUIxLi41JTVEJTVDciU1Q25FZiUzQSUyMG4lM0UwJTIwJUMzJUE5cyUyMCVFMiU4OCU4MGklRTIlODglODglNUIxLi5uJTVEJTNBKGplZ3llayU1QmklNUQlM0UlM0QxJTIwJUMzJUE5cyUyMGplZ3llayU1QmklNUQlMjAlM0MlM0Q1KSU1Q3IlNUNuVWYlM0ElMjBhdGxhZyUyMCUzRCUyMFNaVU1NQShpJTNEMS4ubiUyQyUyMGplZ3llayU1QmklNUQpJTIwJTJGJTIwbiUyMCVDMyVBOXMlMjAlRTIlODglODBpJUUyJTg4JTg4JTVCMS4uNSU1RCUzQShkYXJhYiU1QmklNUQlMjAlM0QlMjBTWlVNTUEoaiUzRDEuLm4lMkMlMjAxJTJDJTIwamVneWVrJTVCaiU1RCUyMCUzRCUyMGkpKSUyMiUyQyUyMnRlc3RzJTIyJTNBJTVCJTdCJTIyZGF0YSUyMiUzQSUyMmplZ3llayUzQSUyMCU1QjUlMkM1JTJDNSUyQzElNUQlNUNyJTVDbm4lM0ElMjA0JTVDciU1Q25hdGxhZyUzQSUyMDQuMCU1Q3IlNUNuZGFyYWIlM0ElMjAlNUIxJTJDMCUyQzAlMkMwJTJDMyU1RCUyMiUyQyUyMm5hbWUlMjIlM0ElMjIlMjIlMkMlMjJyZXN1bHQlMjIlM0ExJTdEJTVEJTdE

        int n;
        Console.Write("Hány jegye van a tanulónak? ");
        int.TryParse(Console.ReadLine(), out n);

        int[] jegyek = new int[n];
        int[] darab = new int[5];
        float atlag;

        Console.Write("Kérem a jegyeket: \n", n);
        int i = 0;
        while (i < n)
        {
            Console.Write("{0}. jegy: ", i + 1);
            int.TryParse(Console.ReadLine(), out jegyek[i]);
            i += 1;
        }

        i = 0;
        float sum = 0;
        while (i < n)
        {
            sum += jegyek[i];
            darab[jegyek[i] - 1] += 1;
            i += 1;
        }

        atlag = sum / n;

        //Kiir
        for (int k = 0; k < 5; k++)
        {
            Console.Write("Érdemjegy: {0}, darab: {1}\n", k + 1, darab[k]);
        }
        Console.Write("Átlag: {0}", atlag);

    }
}
