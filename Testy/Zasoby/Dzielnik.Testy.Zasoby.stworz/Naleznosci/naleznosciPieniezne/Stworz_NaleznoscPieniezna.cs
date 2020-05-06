using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    public static class Stworz_NaleznoscPieniezna
    {
        private static readonly IFabrykaNaleznoscPieniezna fabrykaNaleznoscPieniezna = new FabrykaNaleznoscPieniezna();

        public static INaleznoscPieniezna Stworz(int wplataWGroszach)
        {
            return fabrykaNaleznoscPieniezna.StworzNaleznosc(wplataWGroszach);
        }
    }
}