using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    partial class KryteriumIlosciWymian
    {
        public IKryteriumIlosciWymian DodajPolozenieZmienionejNaleznosci(IPolozenieGornotrojkatneWTabeliNaleznosci zmienionePolozeniaWTabeli,
            INaleznoscPieniezna wymienionaNaleznosc)
        {
            foreach (IPolozenieGornotrojkatneWTabeliNaleznosci polozeniaWTabeli in zmienionePolozeniaKolekcja)
                if (polozeniaWTabeli.Indeks_X == zmienionePolozeniaWTabeli.Indeks_X)
                    if (polozeniaWTabeli.Indeks_Y == zmienionePolozeniaWTabeli.Indeks_Y)
                        return new KryteriumIlosciWymian(zmienionePolozeniaKolekcja, wymienionaNaleznosc);

            return new KryteriumIlosciWymian(zmienionePolozeniaKolekcja, zmienionePolozeniaWTabeli, wymienionaNaleznosc);
        }
    }
}