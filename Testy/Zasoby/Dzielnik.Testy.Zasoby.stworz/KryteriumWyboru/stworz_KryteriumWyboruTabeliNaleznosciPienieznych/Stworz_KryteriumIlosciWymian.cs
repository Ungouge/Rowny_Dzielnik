using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    partial class Stworz_KryteriumWyboruTabeliNaleznosciPienieznych
    {
        public static IKryteriumIlosciWymian Stworz_KryteriumIlosciWymian()
        {
            return (abstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych.
                StworzKryteriumWyboruTabeliNaleznosci(KryteriumWyboruTabeliNaleznosciWylicznik.IlosciWymian)) as IKryteriumIlosciWymian;
        }

        public static IKryteriumIlosciWymian Stworz_KryteriumIlosciWymian(ushort iloscWymian)
        {
            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumIlosciWymian();

            foreach (IPolozenieWTabeliNaleznosci polozenie in PolozeniaWymianWTabeli_Generator.GenerujKolejnePolozeniaWymianWtabeli(iloscWymian))
                kryteriumIlosciWymian = kryteriumIlosciWymian.DodajPolozenieZmienionejNaleznosci(polozenie);

            return kryteriumIlosciWymian;
        }
    }
}