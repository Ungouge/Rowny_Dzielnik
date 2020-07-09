using System.Collections.Generic;

using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs dla tablic osob ze swiadczeniem pienieznym iterujacych zawierajace osoby.
    /// </summary>
    public interface ITablicaOsobPienieznychIterowalna : ITablicaOsobIterowalna<IOsobaPieniezna>
    {
    }
}