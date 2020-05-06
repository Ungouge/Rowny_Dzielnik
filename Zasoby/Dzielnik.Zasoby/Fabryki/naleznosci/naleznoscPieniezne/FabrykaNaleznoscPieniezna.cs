using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Naleznosci;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Fabryka do tworzenia NaleznoscPieniezna.
    /// </summary>
    public class FabrykaNaleznoscPieniezna : IFabrykaNaleznoscPieniezna
    {
        public INaleznoscPieniezna StworzNaleznosc(int grosze = 0)
        {
            return new NaleznoscPieniezna(grosze);
        }
    }
}