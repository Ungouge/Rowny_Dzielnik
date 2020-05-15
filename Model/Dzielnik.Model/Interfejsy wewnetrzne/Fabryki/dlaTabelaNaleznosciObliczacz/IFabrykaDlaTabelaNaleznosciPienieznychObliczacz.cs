using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
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
        INajlepszaWymianaNalezosciPienieznejZnajdywacz StworzNajlepszaWymianaNalezosciPienieznejZnajdywacz(ITablicaOsobPienieznych tablicaOsobKoncowa);

        /// <summary>
        /// Tworzy instancje prefabrykatora tablic osob pienieznych.
        /// </summary>
        ITablicaOsobPienieznaKoncowaPrefabrykator StworzTablicaOsobPienieznaKoncowaPrefabrykator();
    }
}