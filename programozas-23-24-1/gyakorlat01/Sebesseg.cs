using System;

public class Sebesseg
{
    //static void Main(string[] args)
    public Sebesseg()
    {    
        //Deklaráció
        double s, t;
        double v;

        //Beolvasás
        Console.Write("Megtett út: ");
        double.TryParse(Console.ReadLine(), out s);

        if (!(s >= 0))
        {
            Console.WriteLine("Rossz érték!");
            return;
        }

        Console.Write("Eltelt idő: ");
        double.TryParse(Console.ReadLine(), out t);

        if (!(t > 0))
        {
            Console.WriteLine("Rossz érték!");
            System.Environment.Exit(1);
        }

        // Feldolgozás
        v = s / t;

        // Kiírás
        Console.WriteLine("A sebesség: {0}", v);
    }
}