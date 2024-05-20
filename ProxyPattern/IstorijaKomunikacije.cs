using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Interfejs za pristup istoriji komunikacije i pregovorima
    public interface IstorijaKomunikacije
    {
        void PrikaziIstorijuKomunikacije(Korisnik korisnik);
    }
}

