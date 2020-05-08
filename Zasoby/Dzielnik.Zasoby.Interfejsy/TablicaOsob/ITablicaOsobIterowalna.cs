using System.Collections;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob iterujacych zawierajace osoby.
    /// </summary>
    public interface ITablicaOsobIterowalna : ITablicaOsobBaza, IEnumerable
    {
    }
}