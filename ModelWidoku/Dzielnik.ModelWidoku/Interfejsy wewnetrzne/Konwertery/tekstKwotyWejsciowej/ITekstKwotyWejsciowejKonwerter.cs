using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    /// <summary>
    /// Interfejs dla konwerterow tekstu z komorki kwoty wejsciowe na odpowiedni typ nalznosci.
    /// </summary>
    internal interface ITekstKwotyWejsciowejKonwerter
    {
        /// <summary>
        /// Konwertuje tekstu z komorki kwoty wejsciowe do odpowiedniego typu naleznosci w zalenosci od impementacji konwertera oraz przeslanego tekstu.
        /// Zwrocoona wartosc wskazuje czy konwersja sie udala badz nie powiodla.
        /// </summary>
        bool Konwertuj(string tekstKwotyWejsciowej, out INaleznoscSwiadczenieBaza naleznosc);
    }
}