using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    partial class Stworz_KryteriumWyboruTabeliNaleznosciPienieznych
    {
        public static IKryteriumSumyWymienionejNaleznosciPienieznej Stworz_KryteriumSumyWymienionejNaleznosci()
        {
            return Stworz_KryteriumSumyWymienionejNaleznosci(Stworz_NaleznoscPienieznaZerowa.Stworz());
        }

        public static IKryteriumSumyWymienionejNaleznosciPienieznej Stworz_KryteriumSumyWymienionejNaleznosci(INaleznoscPieniezna naleznosc)
        {
            return 
                (
                    (
                        abstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych
                        .StworzKryteriumWyboruTabeliNaleznosci(KryteriumWyboruTabeliNaleznosciWylicznik.KryteriumSumyWymienionejNaleznosci)
                    )as IKryteriumSumyWymienionejNaleznosciPienieznej
                ).DodajNaleznoscDoSumyWymienionejNaleznosci(naleznosc);
        }
    }
}