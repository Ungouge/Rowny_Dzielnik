using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob zwracajacych osobe o danym ID.
    /// </summary>
    public interface ITablicaOsobZwrotna : ITablicaOsobBaza
    {
        IOsobaWymiennaBaza this[byte iD] { get; }
    }
}