using System;
internal class LegidosebbEmberStruct
{
    struct Datum
    {
        public int ev;
        public int ho;
        public int nap;
    }
    static void Main(string[] args)
    { 
        int n;
        int.TryParse(Console.ReadLine(), out n);
        Datum[] szuletesiDatumok = new Datum[n];

        for (int i = 0; i < n; i++)
        {
            String sor = Console.ReadLine();
            szuletesiDatumok[i].ev = int.Parse(sor.Split(" ")[0]);
            szuletesiDatumok[i].ho = int.Parse(sor.Split(" ")[1]);
            szuletesiDatumok[i].nap = int.Parse(sor.Split(" ")[2]);
        }

        int minHely = 0;
        Datum minDatum = szuletesiDatumok[0];

        for (int j = 0; j < n; j++)
        {
            if ((szuletesiDatumok[j].ev < minDatum.ev) ||
                (szuletesiDatumok[j].ev == minDatum.ev && szuletesiDatumok[j].ho < minDatum.ho) ||
                (szuletesiDatumok[j].ev == minDatum.ev && szuletesiDatumok[j].ho == minDatum.ho && szuletesiDatumok[j].nap < minDatum.nap))
            {
                minHely = j;
                minDatum = szuletesiDatumok[j];
            }
        }

        minHely = minHely + 1;
        Console.WriteLine(minHely);
    }
}