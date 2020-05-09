using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    partial class KryteriumIlosciWymian
    {
        public IKryteriumIlosciWymian DodajPolozenieZmienionejNaleznosci(IPolozenieGornotrojkatneWTabeliNaleznosci zmienionePolozeniaWTabeli)
        {
            foreach (IPolozenieGornotrojkatneWTabeliNaleznosci polozeniaWTabeli in zmienionePolozeniaKolekcja)
                if (polozeniaWTabeli.Indeks_X == zmienionePolozeniaWTabeli.Indeks_X)
                    if (polozeniaWTabeli.Indeks_Y == zmienionePolozeniaWTabeli.Indeks_Y)
                        return this;

            return new KryteriumIlosciWymian(zmienionePolozeniaKolekcja, zmienionePolozeniaWTabeli);
        }
    }
}