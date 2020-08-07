
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosc z tekstem naleznosci znajdujacej sie w dolnym trojkacie tabeli naleznosci.
    /// </summary>
    public interface IKomorkaDolnotrojkatnaKwotyNaleznej : IKomorkaZNaleznoscia
    {
        /// <summary>
        /// Zwraca tekst komorki dolnotrojkatnej.
        /// </summary>
        new string Tekst { get; }

        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka dolnotrojkatna.
        /// </summary>
        new byte Kolumna { get; }

        /// <summary>
        /// Zwraca iterator rzedu tabeli w którym powinna znajdować się komorka dolnotrojkatna.
        /// </summary>
        new byte Rzad { get; }

    }
}