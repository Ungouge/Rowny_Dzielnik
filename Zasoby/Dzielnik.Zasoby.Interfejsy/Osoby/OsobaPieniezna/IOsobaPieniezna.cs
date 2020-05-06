using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Osoby
{
    /// <summary>
    /// Interfejs dla osob mogacych dodawac i odejmowac naleznosci w swiadczeniu pienieznym.
    /// </summary>
    public interface IOsobaPieniezna : IOsobaSwiadczeniePieniezne
    {
        /// <summary>
        /// Zwraca nowa osobe z naleznoscia pieniezna dopowiadajaca sumie naleznosci tej osoby i danej.
        /// </summary>
        IOsobaPienieznaWymienna DodajNaleznoscPienieznaOsobie(INaleznoscPieniezna naleznosc);

        /// <summary>
        /// Zwraca nowa osobe z naleznoscia pieniezna dopowiadajaca roznicy danej naleznosci odjetej od naleznosci tej osoby.
        /// </summary>
        IOsobaPienieznaWymienna OdejmnijNaleznoscPienieznaOsobie(INaleznoscPieniezna naleznosc);
    }
}