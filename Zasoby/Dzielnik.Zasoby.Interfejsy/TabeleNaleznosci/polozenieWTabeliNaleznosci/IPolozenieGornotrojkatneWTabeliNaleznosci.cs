
namespace Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci
{
    /// <summary>
    /// Interfejs do struktury zawierajacej koordynaty gornotrojkatne w tabeli naleznosci.
    /// </summary>
    public interface IPolozenieGornotrojkatneWTabeliNaleznosci
    {
        byte Indeks_X { get; }

        byte Indeks_Y { get; }

        /// <summary>
        /// Stwierdza czy przechowywabe koordynaty sa polozone na osi diagonalnej tabeli. Czyli czy oba koordynaty sa sobie rowne.
        /// </summary>
        bool CzyKoordynatyDiagonalne { get; }

        /// <summary>
        /// Stwierdza czy przechowywabe koordynaty sa polozone na gornymtrojkacie tabeli. Czyli czy indeks na osi X jest wiekszy od tego osi Y.
        /// </summary>
        bool CzyKoordynatyGorntrojkatne { get; }
    }
}