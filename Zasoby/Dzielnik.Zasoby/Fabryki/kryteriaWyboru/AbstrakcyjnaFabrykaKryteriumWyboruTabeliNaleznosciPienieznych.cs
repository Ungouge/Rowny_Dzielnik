using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.KryteriumWyboru;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Abstrakcyjna fabryka kryteriow wyboru tabeli naleznosci.
    /// </summary>
    public class AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych: IAbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych
    {
        private readonly IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPieniezna;

        public AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych(IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPieniezna)
        {
            this.fabrykaNaleznoscPieniezna = fabrykaNaleznoscPieniezna;
        }

        public IKryteriumWyboruTabeliNaleznosciPienieznej StworzKryteriumWyboruTabeliNaleznosci(KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci )
        {
            switch (kryteriumWyboruTabeliNaleznosci)
            {
                case KryteriumWyboruTabeliNaleznosciWylicznik.KryteriumSumyWymienionejNaleznosci:
                    goto default;
                case KryteriumWyboruTabeliNaleznosciWylicznik.IlosciWymian:
                    return new KryteriumIlosciWymian(fabrykaNaleznoscPieniezna.StworzNaleznoscZerowa());
                default:
                    return new KryteriumSumyWymienionejNaleznosciPienieznej(fabrykaNaleznoscPieniezna.StworzNaleznoscZerowa());
            }
        }
    }
}