using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryk do obliczaczy tabel naleznosci pienieznych.
    /// </summary>
    internal interface IFabrykaDlaTabelaNaleznosciPienieznychObliczacz
    {
        /// <summary>
        /// Tworzy instancje znajdywacza najlepszej wymiany naleznosci pienieznej.
        /// </summary>
        INajlepszaWymianaNalezosciPienieznejZnajdywacz StworzNajlepszaWymianaNalezosciPienieznejZnajdywacz(ITablicaOsobPienieznych tablicaOsobKoncowa,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci);
    }
}