using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryki tablic osob posiadajcych naleznosci swiadzczenia pienieznego.
    /// </summary>
    public interface IFabrykaTablicaOsobPienieznych: IFabrykaTablicaOsobBaza
    {
        /// <summary>
        /// Stworz instancje tablicy osob pienieznych.
        /// </summary>
        ITablicaOsobPienieznych StworzTablicaOsob(INaleznoscPieniezna[] wplaty);
    }
}