public class MasodpercIdo
{
    static void Main(string[] args)
    //public MasodpercIdo()
    {
        //Deklaráció
        // be
        int sum;
        // ki:
        int h, m, s;

        //Beolvasás
        Console.Write("Masodpercek: ");
        int.TryParse(Console.ReadLine(), out sum);

        if (!(sum >= 0))
        {
            Console.WriteLine("Rossz érték!");
            return;
        }

        // Feldolgozás
        h = sum / 3600;
        sum = sum % 3600;
        m = sum / 60;
        sum = sum % 60;
        s = sum;

        // Kiírás
        Console.WriteLine("Ora: {0} Perc: {1} Masodperc: {2}", h, m, s);
    }
}
