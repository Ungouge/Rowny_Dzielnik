using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.TablicaOsob;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Fabryka do tworzena ITablicaOsobPienieznych.
    /// </summary>
    public class FabrykaTablicaOsobPienieznych : IFabrykaTablicaOsobPienieznych
    {
        public ITablicaOsobPienieznych StworzTablicaOsob(IOsobaPieniezna[] szeregOsob)
        {
            return new TablicaOsobPienieznych(szeregOsob);
        }
    }
}