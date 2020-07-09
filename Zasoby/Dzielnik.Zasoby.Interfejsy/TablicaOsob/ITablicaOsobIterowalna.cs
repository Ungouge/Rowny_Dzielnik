using System.Collections.Generic;

using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs bazowy dla tablic osob iterujacych zawierajace osoby.
    /// </summary>
    public interface ITablicaOsobIterowalna<TOsoba> : ITablicaOsobBaza, IEnumerable<TOsoba> where TOsoba :IOsobaTypSwiadczenia
    {
    }
}