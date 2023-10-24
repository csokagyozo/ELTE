// Mester / Kiválogatás / 4: Díjazottak
// https://mester.inf.elte.hu:8181/faces/leiras.xhtml?jfwid=cde5adb407bd048b00c858ea954d:14

using System;

public class Dijazottak
{
    struct Eredmeny
    {
        public String nev;
        public int pont;
    }
    //public Dijazottak()
    static void Main(string[] args)
    {
        // Deklaráció: spec be, ki
        int n;
        int teljesPont;
        Eredmeny[] eredmenyek;

        List<String> elso = new List<String>();
        List<String> masodik = new List<String>();
        List<String> harmadik = new List<String>();
        List<String> negyedik = new List<String>();
        
        // átírhatjuk:
        //List<String>[] listak = new List<String>[4];

        // Beolvasás
        String elsoSor = Console.ReadLine();
        n = int.Parse(elsoSor.Split(" ")[0]);
        teljesPont = int.Parse(elsoSor.Split(" ")[1]);

        eredmenyek = new Eredmeny[n];
        for (int i = 0; i < n; i++)
        {
            String sor = Console.ReadLine();
            eredmenyek[i].nev = sor.Split(" ")[0];
            eredmenyek[i].pont = int.Parse(sor.Split(" ")[1]);
        }

        // Feldolgozas
        for (int i = 0; i < n; i++)
        {
            if (teljesPont * 0.9 <= eredmenyek[i].pont)
            {
                elso.Add(eredmenyek[i].nev);
            }
            if (teljesPont * 0.8 <= eredmenyek[i].pont && eredmenyek[i].pont < teljesPont * 0.9)
            {
                masodik.Add(eredmenyek[i].nev);
            }
            if (teljesPont * 0.7 <= eredmenyek[i].pont && eredmenyek[i].pont < teljesPont * 0.8)
            {
                harmadik.Add(eredmenyek[i].nev);
            }
            if (eredmenyek[i].pont < teljesPont * 0.7)
            {
                negyedik.Add(eredmenyek[i].nev);
            }
        }

        // Kiiras
        Console.Write("{0};", elso.Count);
        for (int i = 0; i < elso.Count; i++)
        {
            Console.Write("{0};", elso[i]);
        }
        Console.WriteLine();

        Console.Write("{0};", masodik.Count);
        for (int i = 0; i < masodik.Count; i++)
        {
            Console.Write("{0};", masodik[i]);
        }
        Console.WriteLine();

        Console.Write("{0};", harmadik.Count);
        for (int i = 0; i < harmadik.Count; i++)
        {
            Console.Write("{0};", harmadik[i]);
        }
        Console.WriteLine();

        Console.Write("{0};", negyedik.Count);
        for (int i = 0; i < negyedik.Count; i++)
        {
            Console.Write("{0};", negyedik[i]);
        }
        Console.WriteLine();
    }
}
