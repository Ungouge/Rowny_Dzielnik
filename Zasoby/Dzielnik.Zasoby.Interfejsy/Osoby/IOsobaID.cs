
namespace Dzielnik.Zasoby.Interfejsy.Osoby
{
    /// <summary>
    /// Interfejs bazowy dla osob z przypisanym numerem ID.
    /// </summary>
    public interface IOsobaID
    {
        /// <summary>
        /// Zwraca numer identyfikacyjny osoby, ktory powinien odpowiadac numerowi kolejnosci w tabeli z danymi wejsciowymi.
        /// </summary>
        byte ID { get; }

        /// <summary>
        /// Zwraca czy podana osoba posiada to samo ID.
        /// </summary>
        bool CzyToTaSamaOsoba(IOsobaID osobaID);
    }
}