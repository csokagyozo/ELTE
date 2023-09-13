using System;
public class IdoMasodperc
{
    //static void Main(string[] args)
    public IdoMasodperc()
    {
        //Deklaráció
        int h, m, s;
        int sum;

        //Beolvasás
        Console.Write("Ora: ");
        int.TryParse(Console.ReadLine(), out h);

        if (!(h >= 0))
        {
            Console.WriteLine("Rossz érték!");
            return;
        }

        Console.Write("Perc: ");
        int.TryParse(Console.ReadLine(), out m);

        if (!(m >= 0))
        {
            Console.WriteLine("Rossz érték!");
            System.Environment.Exit(1);
        }

        Console.Write("Masodperc: ");
        int.TryParse(Console.ReadLine(), out s);

        if (!(s >= 0))
        {
            Console.WriteLine("Rossz érték!");
            System.Environment.Exit(1);
        }

        // Feldolgozás
        sum = 3600 * h + 60 * m + s;

        // Kiírás
        Console.WriteLine("Masodpercben: {0}", sum);
    }
}