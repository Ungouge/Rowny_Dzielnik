using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Osoby
{
    /// <summary>
    /// Interfejs dla osob ktorym mozna wymieniac naleznosc ze swiadczeniem pienieznym w uzywanych kolekcjach.
    /// </summary>
    public interface IOsobaPieniezna : IOsobaSwiadczeniePieniezne
    {
        /// <summary>
        /// Zwroc nowa osobe z podana wplata pieniezna.
        /// </summary>
        IOsobaPieniezna ZmienWplate(INaleznoscPieniezna nowaNaleznosc);
    }
}