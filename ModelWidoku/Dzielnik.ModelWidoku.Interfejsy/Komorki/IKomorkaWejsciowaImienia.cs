using System.Windows.Media;

namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla komorek zawierajacych wlasciwosc z modyfikowalnym tekstem imienia.
    /// </summary>
    public interface IKomorkaWejsciowaImienia: IKomorkaZKolorowymTlemTekstu, IKomorkaZWejsciemTekstu
    {
        /// <summary>
        /// Zwraca i przypisuje tekst komorki wejsciowej imienia.
        /// </summary>
        new string Tekst { get; set; }

        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka wejsciowa imienia.
        /// </summary>
        new byte Kolumna { get; }

        /// <summary>
        /// Zwraca kolor tla komorki wejsciowej imienia.
        /// </summary>
        new Brush KolorTla { get; }
    }
}