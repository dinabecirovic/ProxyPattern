using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // Kreiranje instance konkretne implementacije klase istorije komunikacije
            IstorijaKomunikacije istorijaKomunikacije = new IstorijaKomunikacijeImplementacija();

            // Kreiranje instance proxy-ja za istoriju komunikacije
            List<string> adminKorisnickaImena = new List<string> { "admin1", "admin2" }; // Primer administratorskih korisnika
            ProxyIstorijaKomunikacije proxyIstorijaKomunikacije = new ProxyIstorijaKomunikacije(istorijaKomunikacije, adminKorisnickaImena);

            // Kreiranje korisnika
            Korisnik adminKorisnik = new Korisnik { KorisnickoIme = "admin1" };
            Korisnik obicanKorisnik = new Korisnik { KorisnickoIme = "korisnik123" };

            // Prikazivanje istorije komunikacije korisnika
            proxyIstorijaKomunikacije.PrikaziIstorijuKomunikacije(adminKorisnik); // Dozvoljeno
            proxyIstorijaKomunikacije.PrikaziIstorijuKomunikacije(obicanKorisnik); // Odbijeno

        }
    }
}
