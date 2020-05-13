using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.Interfejsy.KryteriumWyboru
{
    /// <summary>
    /// Interfejs dla kryteriow wyboru tabel naleznosci najmniejszej ilosci wymian potrzebnych do wyrownania naleznosci.
    /// </summary>
    public interface IKryteriumIlosciWymian: IKryteriumWezWymienionejNaleznosciPienieznejBaza
    {
        /// <summary>
        /// Zwraca ilosci wymian potrzebnych do wyrownania naleznosci.
        /// </summary>
        ushort WezIlosciWymian { get; }

        /// <summary>
        /// Zwraca nowe kryterium z suma wymienionych naleznosci pienieznych powiekszoną o podane polozenie w tabeli.
        /// </summary>
        IKryteriumIlosciWymian DodajPolozenieZmienionejNaleznosci(IPolozenieGornotrojkatneWTabeliNaleznosci zmienionePolozeniaWTabeli,
            INaleznoscPieniezna wymienionaNaleznosc);
    }
}