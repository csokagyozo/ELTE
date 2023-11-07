using System;
//1) hány napon emelkedett minden árfolyam
//https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACm1R3WrCMBh9lZArZTE0P03TMAeKG4xtXgi7qr2otoWiTaXthCne%2Bxp7ib2Ab7InWT4rMoY3%2Bc538p1zwpc9bjbZssiLZdIWlcUGjzOD7M%2FxOCWo7Mrpq86r9WdSVitHzCJGqSXuKON5PbcvhUHpAiahe9oaVBY2tafvbbZqdsXKTAcPr%2BQf2aua3bra9Idvz9NJr6nq4dn0T1LkSNJNxfe3%2BTsW9yHzMTdoAOA9h6cMJ6PZaHxJAN9ywMjt%2BD4muM2atsEm2uM0aRO3AGuQBLfSIB%2Fqn3CDImAQinggKPcZQTzwqdRQJVU%2BByCoFLxjAi5jcpGIgFHhOQkAGWoAknIBjPIp83V3JWRw1TDmeufFuOcmoYJUAQiopxmAkHohvyqUe4%2Fg7kJpfQGBokxIB%2FyQMnBRyqMe153m%2FInpwiDulmGTMnMrcKjOmo91iw07xIdfs1jhSyUCAAA%3D
//2) hanyadik napokon emelkedett minden árfolyam
// https://progalap.elte.hu/specifikacio/?data=H4sIAAAAAAAACm2Ry2rCUBCGX%2BWQlaHHQ84lt0MttPSCaC2UtpuYRWIiBE0iSSqouOjO1%2BhL9AV8kz5JZ4yIFDeZL%2F%2FMPzOZbIx6kU6yaTaJmqwsDG3cpZoUv7vdiJK8DfvvalrOV1FezkB4DThjBYVHHo6rcTHINEnitnKFAfNJfMg9LjXJsyIp9j%2FLdFavs5kedW%2BG9J%2FYKev1vFyYvef%2B6L5Tl1XvMOJsbgAibavC68v6FQ9NnPkw1aSL8A7QSWK6MnuD%2Fsf%2Ba%2FjydPt2HIUD8i6nl%2FcwDWo0ad3Uhg42RhI1Edyl0ERh21wTG%2BPZFpoEqBASCFcyYXNKhGsz5WFUzLEFgmRKilZxhQrp0SJdzqQFFgTlewiKCYmKYzNue21KKvfk4RzeoRcXFlRiRKuD4DLL4wg%2Bs3xxcjiwjxSQcDzvCK7DuFQAts84dnEci1nCaz2H%2F5fEmgiEFXwieFQIlymiPIV7AFVp%2FTlvDM234fYPoMG1WkkCAAA%3D
public class Arfolyamok
{
    public Arfolyamok()
    //static void Main(string[] args)
    {
        // Be:
        const int n = 4;
        const int m = 5;

        double[,] adatok = new double[n, m]{
            { 273.251, 275.48, 274.652, 273.432, 274.724},
            { 371.301, 371.498, 374.231, 365.158, 371.347},
            { 111.32, 120.23, 121.496, 127.081, 129.092},
            { 675.321, 688.321, 676.134, 659.123, 660.028}
        };

        // Ki:
        int db = 0;

        // Feldolgozás:
        // TODO

        // Kiírás
        Console.Write("{0}", db);
    }
}
