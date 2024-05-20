using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Proxy klasa koja kontroliše pristup istoriji komunikacije
    public class ProxyIstorijaKomunikacije : IstorijaKomunikacije
    {

        // Proxy klasa koja kontroliše pristup istoriji komunikacije

            private readonly IstorijaKomunikacije _istorijaKomunikacije;
            private readonly List<string> _adminKorisnickaImena; // Liste korisnika sa administratorskim pravima

            public ProxyIstorijaKomunikacije(IstorijaKomunikacije istorijaKomunikacije, List<string> adminKorisnickaImena)
            {
                _istorijaKomunikacije = istorijaKomunikacije;
                _adminKorisnickaImena = adminKorisnickaImena;
            }

            public void PrikaziIstorijuKomunikacije(Korisnik korisnik)
            {
                if (_adminKorisnickaImena.Contains(korisnik.KorisnickoIme))
                {
                    _istorijaKomunikacije.PrikaziIstorijuKomunikacije(korisnik);
                }
                else
                {
                    Console.WriteLine($"Nemate dozvolu da pristupite istoriji komunikacije.");
                }
            }
        }
    }


