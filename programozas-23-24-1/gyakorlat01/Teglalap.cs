using System;

public class Teglalap
{
    //static void Main(string[] args)
    public Teglalap()
    {
        //Deklaráció
        double a, b;
        double A;

        //Beolvasás
        Console.Write("a: ");
        double.TryParse(Console.ReadLine(), out a);

        if (!(a > 0))
        {
            Console.WriteLine("Rossz érték!");
            return;
        }

        Console.Write("b: ");
        double.TryParse(Console.ReadLine(), out b);

        if (!(b > 0))
        {
            Console.WriteLine("Rossz érték!");
            System.Environment.Exit(1);
        }

        // Feldolgozás
        A = a * b;

        // Kiírás
        Console.WriteLine("A terület: {0}", A);
    }
}
