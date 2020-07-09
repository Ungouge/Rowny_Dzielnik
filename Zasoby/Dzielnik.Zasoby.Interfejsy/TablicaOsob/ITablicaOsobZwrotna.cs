using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob zwracajacych osobe o danym ID.
    /// </summary>
    public interface ITablicaOsobZwrotna<TOsobaTypSwiadczenia> : ITablicaOsobBaza where TOsobaTypSwiadczenia : IOsobaTypSwiadczenia
    {
        TOsobaTypSwiadczenia this[IOsobaID osobaID] { get; }
    }
}