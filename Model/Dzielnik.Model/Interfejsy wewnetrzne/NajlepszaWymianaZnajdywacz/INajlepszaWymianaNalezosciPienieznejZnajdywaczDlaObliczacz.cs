using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz
{
    /// <summary>
    /// Interfejs dla znajdywacza najlepszej wymiany naleznosci pienieznej przeznaczonej dla obliczacza tabeli naleznosci.
    /// </summary>
    internal interface INajlepszaWymianaNalezosciPienieznejZnajdywaczDlaObliczacz
    {
        /// <summary>
        /// Zwraca znaleziona najlepsza wymiane naleznosci pienieznej wedlug obenie ustawionego kryterium wyboru.
        /// </summary>
        ITabelaNaleznosciPienieznejZwrotna Znajdz(ITablicaOsobPienieznych tablicaOsob);
    }
}