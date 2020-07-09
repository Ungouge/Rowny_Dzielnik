using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator
{
    /// <summary>
    /// Interfejs dla prefabrykatora tworzaczego tablice osob jaka jest oczekiwana pod koniec wyrownywania naleznosci.
    /// </summary>
    internal interface ITablicaOsobPienieznaKoncowaPrefabrykator
    {
        /// <summary>
        /// Tworzy tablice osob jaka jest oczekiwana pod koniec wyrownywania naleznosci.
        /// </summary>
        ITablicaOsobPienieznych StworzTablicaKoncowa(ITablicaOsobPienieznych tablicaOsob);
    }
}