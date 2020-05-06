using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Osoby
{
    /// <summary>
    /// Interfejs dla osob ktorym mozna wymieniac naleznosc ze swiadczeniem pienieznym w uzywanych kolekcjach.
    /// </summary>
    public interface IOsobaPienieznaWymienna : IOsobaPieniezna, IOsobaPienieznaUstalWplata
    {
        /// <summary>
        /// Wplata dokonana przez osobe w swiadczeniu wyrazonym w walucie podzielnej na setki.
        /// </summary>
        new INaleznoscPieniezna Wplata { get; set; }
    }
}
