using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    public static class Stworz_NaleznoscPienieznaDiagonalna
    {
        private static readonly IFabrykaNaleznoscPienieznaDiagonalna fabrykaNaleznoscPienieznaDiagonalna = new FabrykaNaleznoscPienieznaDiagonalna();

        public static INaleznoscPienieznaDiagonalnaSwiadczenie Stworz()
        {
            return fabrykaNaleznoscPienieznaDiagonalna.StworzNaleznoscDiagonalna();
        }
    }
}