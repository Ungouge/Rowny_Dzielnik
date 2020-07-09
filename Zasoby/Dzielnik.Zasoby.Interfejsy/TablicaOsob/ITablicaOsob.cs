using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob.
    /// </summary>
    public interface ITablicaOsob<TOsobaWymienna> : ITablicaOsobBaza, ITablicaOsobZwrotna<TOsobaWymienna>, ITablicaOsobIterowalna<TOsobaWymienna>
        where TOsobaWymienna : IOsobaTypSwiadczenia
    {
    }
}