using System.Windows.Media;

namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla komorek zawierajacych wlasciwosc z modyfikowalnym tekstem naleznosci.
    /// </summary>
    public interface IKomorkaWejsciowaKwoty : IKomorkaZWejsciemTekstu, IKomorkaZKolorowymTlemTekstu
    {
        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka wejsciowa kwoty.
        /// </summary>
        new byte Kolumna { get; }

        /// <summary>
        /// Zwraca i przypisuje tekst komorki wejsciowej wejsciowej kwoty.
        /// </summary>
        new string Tekst { get; set; }

        /// <summary>
        /// Zwraca kolor tla komorki wejsciowej kwoty.
        /// </summary>
        new Brush KolorTla { get; }
    }
}