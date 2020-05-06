using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Naleznosci;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Fabryka do tworzenia NaleznoscPienieznaDiagonalna.
    /// </summary>
    public class FabrykaNaleznoscPienieznaDiagonalna : IFabrykaNaleznoscPienieznaDiagonalna
    {
        public INaleznoscPienieznaDiagonalnaSwiadczenie StworzNaleznoscDiagonalna()
        {
            return new NaleznoscPienieznaDiagonalna();
        }
    }
}