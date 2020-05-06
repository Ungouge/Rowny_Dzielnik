using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryk osob pienieznych.
    /// </summary>
    public interface IFabrykaOsobaPieniezna : IFabrykaOsoba
    {
        /// <summary>
        /// Stworz nowa instancje osoby pienieznej.
        /// </summary>
        IOsobaPienieznaWymienna StworzOsoba(byte iD, INaleznoscPieniezna naleznosc);
    }
}