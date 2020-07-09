using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Interfejs dla tablic osob posiadajcych wplate swiadczenia pienieznego.
    /// </summary>
    public interface ITablicaOsobPienieznych : ITablicaOsobPienieznychPrzekazywalna,
        ITablicaOsobPienieznychZwrotna, ITablicaOsobPienieznychIterowalna
    {
    }
}