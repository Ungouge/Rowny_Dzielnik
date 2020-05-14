using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    partial class Stworz_KryteriumWymienionejNaleznosciPienieznej
    {
        public static IKryteriumIlosciWymian Stworz_KryteriumIlosciWymian()
        {
            return (abstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych.
                StworzKryteriumWyboruTabeliNaleznosci(KryteriumWyboruTabeliNaleznosciWylicznik.IlosciWymian)) as IKryteriumIlosciWymian;
        }

        public static IKryteriumIlosciWymian Stworz_KryteriumIlosciWymian(ushort iloscWymian)
        {
            return Stworz_KryteriumIlosciWymian(iloscWymian, Stworz_NaleznoscPienieznaZerowa.Stworz());
        }

        public static IKryteriumIlosciWymian Stworz_KryteriumIlosciWymian(ushort iloscWymian, INaleznoscPieniezna wymienionaNaleznosc)
        {
            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumIlosciWymian();

            foreach (IPolozenieWTabeliNaleznosci polozenie in PolozeniaWymianWTabeli_Generator.GenerujKolejnePolozeniaWymianWtabeli(iloscWymian))
                kryteriumIlosciWymian = kryteriumIlosciWymian.DodajPolozenieZmienionejNaleznosci(polozenie, wymienionaNaleznosc);

            return kryteriumIlosciWymian;
        }
    }
}