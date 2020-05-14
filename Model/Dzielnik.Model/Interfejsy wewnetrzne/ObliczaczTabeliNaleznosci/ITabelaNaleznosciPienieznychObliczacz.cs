using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci
{
    /// <summary>
    /// Interfejs dla obliczacza tabeli nalezcnosci pienieznych.
    /// </summary>
    internal interface ITabelaNaleznosciPienieznychObliczacz : ITabelaNaleznosciObliczacz
    {
        /// <summary>
        /// Zwraca obliczone naleznosci dla podanej tabeli osob i obecnych ustawien.
        /// </summary>
        ITabelaNaleznosciPienieznejZwrotna ObliczNaleznosci(ITablicaOsobPienieznych tablicaOsob);
    }
}