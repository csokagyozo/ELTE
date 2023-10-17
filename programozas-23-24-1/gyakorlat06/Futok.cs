// Mester/Kiválogatás/9: Első osztályú futók
// https://mester.inf.elte.hu:8181/faces/leiras.xhtml?jfwid=cde5adb407bd048b00c858ea954d:15

using System;
internal class Futok
{
    //public Futok()
    static void Main(string[] args)
    {
        // Deklaráció: spec be, ki
        int n;
        int szint;
        int[] eredmenyek;
        int[] teljesitok;

        // Beolvasás
        bool jo;
        Console.Error.Write("versenyzok szama, szintido space-el elvalasztva ");
        String sor = Console.ReadLine();
        n = int.Parse(sor.Split(" ")[0]);
        szint = int.Parse(sor.Split(" ")[1]);
        
        eredmenyek = new int[n];
        for (int i = 1; i <= n; i++)
        {
            do
            {
                Console.Error.Write("{0}. eredmeny: ", i);
                jo = int.TryParse(Console.ReadLine(), out eredmenyek[i - 1]) && eredmenyek[i - 1] >= 0;
            } while (!jo);
        }

        // Feldolgozas:
        teljesitok = new int[n];
        int teljesitok_szama = 0;
        for (int i = 0; i < n; i++)
        {
            if (eredmenyek[i] >= szint)
            {
                teljesitok[teljesitok_szama] = i;
                teljesitok_szama = teljesitok_szama + 1;
            }
        }

        // Kiiras:
        Console.Write("{0} ",teljesitok_szama);
        for (int j = 0; j<teljesitok_szama; j++)
        {
            Console.Write("{0} ",teljesitok[j] + 1);
        }
    }
}