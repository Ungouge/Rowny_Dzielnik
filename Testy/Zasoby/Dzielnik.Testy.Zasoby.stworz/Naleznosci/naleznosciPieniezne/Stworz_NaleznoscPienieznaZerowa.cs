using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    public static class Stworz_NaleznoscPienieznaZerowa
    {
        private static readonly IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa = new FabrykaNaleznoscPienieznaZerowa();

        public static INaleznoscPieniezna Stworz()
        {
            return fabrykaNaleznoscPienieznaZerowa.StworzNaleznoscZerowa();
        }
    }
}