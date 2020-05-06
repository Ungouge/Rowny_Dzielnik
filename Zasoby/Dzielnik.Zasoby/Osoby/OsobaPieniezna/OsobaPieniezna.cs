using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Osoby
{
    /// <summary>
    /// Osoba posiadajca wplate swiadczenia pienieznym.
    /// </summary>
    internal class OsobaPieniezna: OsobaID, IOsobaPienieznaWymienna, IOsobaPieniezna
    {
        public INaleznoscPieniezna Wplata { get; set; }

        public OsobaPieniezna(byte iD, INaleznoscPieniezna naleznosc): base(iD)
        {
            Wplata = naleznosc;
        }

        public IOsobaPienieznaWymienna DodajNaleznoscPienieznaOsobie(INaleznoscPieniezna naleznosc)
        {
            return new OsobaPieniezna(ID, Wplata.Suma(naleznosc));
        }

        public IOsobaPienieznaWymienna OdejmnijNaleznoscPienieznaOsobie(INaleznoscPieniezna naleznosc)
        {
            return new OsobaPieniezna(ID, Wplata.Roznica(naleznosc));
        }
    }
}