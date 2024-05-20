using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Konkretna implementacija istorije komunikacije i pregovora
    public class IstorijaKomunikacijeImplementacija : IstorijaKomunikacije
    {
        public void PrikaziIstorijuKomunikacije(Korisnik korisnik)
        {
            Console.WriteLine($"Prikazivanje istorije komunikacije za korisnika {korisnik.KorisnickoIme}");
            // Implementacija prikaza istorije komunikacije
        }
    }
}
