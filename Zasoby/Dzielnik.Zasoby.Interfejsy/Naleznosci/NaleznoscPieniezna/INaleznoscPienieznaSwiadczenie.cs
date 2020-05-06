
namespace Dzielnik.Zasoby.Interfejsy.Naleznosci
{
    /// <summary>
    /// Interfejs dla naleznosci pienieznych zwracajacy jedyne swoją wartosc bez mozliwosci obrotu ta naleznoscia.
    /// </summary>
    public interface INaleznoscPienieznaSwiadczenie : INaleznoscSwiadczenieBaza
    {
        /// <summary>
        /// Zwraca wartosc swiadczenia pienieznego wyrazona w jednostce monetarnej bedaca jedna setna podstawowej jednoscki monetarnej
        /// domyslnie Polski Zloty, Euro czy Dolar Amerykanski.
        /// </summary>
        int Swiadczenie { get; }
    }
}
