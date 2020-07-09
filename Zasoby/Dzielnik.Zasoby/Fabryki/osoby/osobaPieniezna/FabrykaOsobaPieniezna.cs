using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Osoby;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Fabryka do tworzenia OsobaPieniezna.
    /// </summary>
    public class FabrykaOsobaPieniezna : IFabrykaOsobaPieniezna
    {
        public IOsobaPieniezna StworzOsoba(byte iD, INaleznoscPieniezna naleznosc)
        {
            return new OsobaPieniezna(iD, naleznosc);
        }
    }
}