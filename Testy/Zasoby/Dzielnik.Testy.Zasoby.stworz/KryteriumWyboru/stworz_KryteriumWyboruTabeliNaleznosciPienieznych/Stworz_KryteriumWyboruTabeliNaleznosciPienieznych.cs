using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    public static partial class Stworz_KryteriumWyboruTabeliNaleznosciPienieznych
    {
        private static IAbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych abstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych =
            new AbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych(new FabrykaNaleznoscPienieznaZerowa());
    }
}