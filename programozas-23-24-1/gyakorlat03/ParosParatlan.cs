using System;

public class ParosParatlan
{
    //public ParosParatlan()
    static void Main(string[] args)
    {
        /*  Feladat: olvassunk be n szamot, és állapítsuk meg,
            hogy több páros szám van-e köztük, mint páratlan.
         */
        // Specifikacio: http://webprogramozas.inf.elte.hu/user/gyozke/specifikacio/?data=JTdCJTIyc3BlY2lmaWNhdGlvbiUyMiUzQSUyMkJlJTNBJTIwbiVFMiU4OCU4OE4lMkMlMjBzemFtb2slRTIlODglODhOJTVCMS4ubiU1RCU1Q3IlNUNuS2klM0ElMjB0b2JiUGFyb3MlRTIlODglODhMJTVDciU1Q25FZiUzQSUyMC0lNUNyJTVDblVmJTNBJTIwdG9iYlBhcm9zJTIwJTNEJTIwKFNaVU1NQShpJTNEMS4ubiUyQyUyMDElMkMlMjBzemFtb2slNUJpJTVEJTIwJTI1JTIwMiUyMCUzRCUyMDApJTIwJTNFJTIwKG4lMjAlMkYlMjAyKSklMjIlMkMlMjJ0ZXN0cyUyMiUzQSU1QiU3QiUyMmRhdGElMjIlM0ElMjJuJTNBJTIwMyU1Q3IlNUNuc3phbW9rJTNBJTIwJTVCMSUyQyUyMDIlMkMlMjAzJTVEJTVDciU1Q250b2JiUGFyb3MlM0ElMjBmYWxzZSUyMiUyQyUyMm5hbWUlMjIlM0ElMjIlMjIlMkMlMjJyZXN1bHQlMjIlM0ExJTdEJTVEJTdE

        int n;
        Console.Write("Hány számot vizsgálunk? ");
        int.TryParse(Console.ReadLine(), out n);

        int[] szamok = new int[n];
        bool tobbParos = false;

        Console.Write("Kérek {0} számot: \n", n);
        int i = 0;
        int diffParos = 0;
        while (i < n)
        {
            Console.Write("x{0}: ", i + 1);
            int.TryParse(Console.ReadLine(), out szamok[i]);
            if (szamok[i] % 2 == 0)
            {
                diffParos += 1;
            } else
            {
                diffParos -= 1;
            }
            i += 1;
        }

        tobbParos = diffParos > 0;

        //Kiir
        if (tobbParos)
        {
            Console.WriteLine("A kapott számok között több páros szám van, mint páratlan.");
        } else
        {
            Console.WriteLine("A kapott számok között nincs több páros szám, mint páratlan.");
        }
    }
}