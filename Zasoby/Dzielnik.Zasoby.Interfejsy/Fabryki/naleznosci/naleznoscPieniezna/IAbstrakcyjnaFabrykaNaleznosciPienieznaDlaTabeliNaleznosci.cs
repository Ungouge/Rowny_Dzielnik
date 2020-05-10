using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla abstrakcyjnej fabryki dla tabel naleznosci pieniezncyh do tworzenia naleznosci w zaleznosci od polozenia w tabeli.
    /// </summary>
    public interface IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci: IAbstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci
    {
        /// <summary>
        /// Stworz nowa instancje naleznosci zerowej lub diagonalnej w zaleznosci od docelowego polozenia w tabeli.
        /// </summary>
        INaleznoscPienieznaSwiadczenie StworzNaleznoscPienieznaZwrotna(IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeli);

        /// <summary>
        /// Stworz nowa instancje naleznosci zerowej.
        /// </summary>
        INaleznoscPieniezna StworzNaleznoscPienieznaZerowa();
    }
}