using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs fabryki dla NaleznoscDiagonalna.
    /// </summary>
    public interface IFabrykaNaleznoscPienieznaDiagonalna: IFabrykaNaleznoscDiagonalna
    {
        /// <summary>
        /// Stworz nowa instancje naleznosci pienieznej diagonalnej.
        /// </summary>
        INaleznoscPienieznaDiagonalnaSwiadczenie StworzNaleznoscDiagonalna();
    }
}