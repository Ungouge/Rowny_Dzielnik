
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosc z tekstem naleznosci znajdujacej sie w gornym trojkacie tabeli naleznosci.
    /// </summary>
    public interface IKomorkaGornotrojkatnaKwotyNaleznej : IKomorkaZNaleznoscia
    {
        /// <summary>
        /// Zwraca tekst komorki gornotrojkatnej.
        /// </summary>
        new string Tekst { get; }

        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka gornotrojkatna.
        /// </summary>
        new byte Kolumna { get; }

        /// <summary>
        /// Zwraca iterator rzedu tabeli w którym powinna znajdować się komorka gornotrojkatna.
        /// </summary>
        new byte Rzad { get; }
    }
}