using System;

public class Sorrend
{
    //static void Main(string[] args)
    public Sorrend()
	{
        //Deklaráció
        int[] x = new int[3];
        int[] a = new int[3];

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

        Console.Write("harmadik szam: ");
        int.TryParse(Console.ReadLine(), out x[2]);

        if (!(x[2] > 0))
        {
            Console.WriteLine("Rossz érték!");
            System.Environment.Exit(1);
        }

        // Feldolgozás
        // Feladat: roviditsd le
        if (x[0] >= x[1] && x[1] >= x[2])
        {
            a[0] = x[0];
            a[1] = x[1];
            a[2] = x[2];
        }

        if (x[0] >= x[2] && x[2] >= x[1])
        {
            a[0] = x[0];
            a[1] = x[2];
            a[2] = x[1];
        }
        
        if (x[1] >= x[0] && x[0] >= x[2])
        {
            a[0] = x[1];
            a[1] = x[0];
            a[2] = x[2];
        }

        if (x[1] >= x[2] && x[2] >= x[0])
        {
            a[0] = x[1];
            a[1] = x[2];
            a[2] = x[0];
        }

        if (x[2] >= x[0] && x[0] >= x[1])
        {
            a[0] = x[2];
            a[1] = x[0];
            a[2] = x[1];
        }

        if (x[2] >= x[1] && x[1] >= x[0])
        {
            a[0] = x[2];
            a[1] = x[1];
            a[2] = x[0];
        }

        // Kiírás
        Console.WriteLine("Novekvo sorrendben: {0} {1} {2}", a[2], a[1], a[0]);
    }
}
