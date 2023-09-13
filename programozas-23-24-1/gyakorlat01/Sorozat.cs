using System;

public class Sorozat
{
    static void Main(string[] args)
    //public Sorozat()
    {
        //Deklaráció
        int[] x = new int[3];
        bool szamtani = false;
        bool mertani = false;

        //Beolvasás
        Console.Write("elso szam: ");
        int.TryParse(Console.ReadLine(), out x[0]);

        if (!(x[0] > 0))
        {
            Console.WriteLine("Rossz érték!");
            return;
        }

        Console.Write("masodik szam: ");
        int.TryParse(Console.ReadLine(), out x[1]);

        if (!(x[1] > 0))
        {
            Console.WriteLine("Rossz érték!");
            System.Environment.Exit(1);
        }

        if (!(x[1] >= x[0]))
        {
            Console.WriteLine("Nem novekvo a sorrend");
            System.Environment.Exit(1);
        }

        Console.Write("harmadik szam: ");
        int.TryParse(Console.ReadLine(), out x[2]);

        if (!(x[2] > 0))
        {
            Console.WriteLine("Rossz érték!");
            System.Environment.Exit(1);
        }

        if (!(x[2] >= x[1]))
        {
            Console.WriteLine("Nem novekvo a sorrend");
            System.Environment.Exit(1);
        }

        // Feldolgozás
        if (x[1] - x[0] == x[2] - x[1])
        {
            szamtani = true;
        }

        if (x[1] / x[0] == x[2] / x[1])
        {
            mertani = true;
        }

        // Kiírás
        if (szamtani)
        {
            Console.WriteLine("Szamtani sorozat");
        }
        else
        {
            Console.WriteLine("Nem szamtani sorozat");
        }

        if (mertani)
        {
            Console.WriteLine("Mertani sorozat");
        }
        else
        {
            Console.WriteLine("Nem mertani sorozat");
        }
    }
}
