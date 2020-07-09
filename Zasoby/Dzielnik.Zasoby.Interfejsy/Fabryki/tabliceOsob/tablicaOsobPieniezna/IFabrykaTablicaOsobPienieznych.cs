using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryki tablic osob posiadajcych naleznosci swiadzczenia pienieznego.
    /// </summary>
    public interface IFabrykaTablicaOsobPienieznych: IFabrykaTablicaOsobBaza
    {
        /// <summary>
        /// Stworz instancje tablicy osob pienieznych dla osob.
        /// </summary>
        ITablicaOsobPienieznych StworzTablicaOsob(IOsobaPieniezna[] szeregOsob);
    }
}