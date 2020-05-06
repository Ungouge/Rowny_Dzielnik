using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Osoby
{
    /// <summary>
    /// Interfejs dla osob ktore moga ustalac naleznosc ze swiaczeniem pienieznym.
    /// </summary>
    public interface IOsobaPienieznaUstalWplata : IOsobaSwiadczeniePieniezne, IOsobaWymiennaBaza
    {
        /// <summary>
        /// Ustal wplate dokonana przez osobe w swiadczeniu pieniezym.
        /// </summary>
        new INaleznoscPieniezna Wplata { set; }
    }
}