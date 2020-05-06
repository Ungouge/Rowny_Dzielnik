using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Naleznosci;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Fabryka do tworzenia NaleznoscPienieznaZerowa.
    /// </summary>
    public class FabrykaNaleznoscPienieznaZerowa : IFabrykaNaleznoscPienieznaZerowa
    {
        public INaleznoscPieniezna StworzNaleznoscZerowa()
        {
            return new NaleznoscPienieznaZerowa();
        }
    }
}