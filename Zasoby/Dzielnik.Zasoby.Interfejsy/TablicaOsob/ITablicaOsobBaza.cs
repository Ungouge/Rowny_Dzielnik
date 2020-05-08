
namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob.
    /// </summary>
    public interface ITablicaOsobBaza
    {
        /// <summary>
        /// Zwaraca ilosc osob w tablicy.
        /// </summary>
        byte WezIloscOsob { get; }
    }
}