using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Osoby
{
    /// <summary>
    /// Osoba posiadajca wplate swiadczenia pienieznym.
    /// </summary>
    internal partial class OsobaPieniezna: OsobaID, IOsobaPieniezna
    {
        public INaleznoscPieniezna Wplata { get; }

        public OsobaPieniezna(byte iD, INaleznoscPieniezna naleznosc): base(iD)
        {
            Wplata = naleznosc;
        }
    }
}