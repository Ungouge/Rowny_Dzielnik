using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs fabryki dla NaleznoscPienieznaZerowa.
    /// </summary>
    public interface IFabrykaNaleznoscPienieznaZerowa: IFabrykaNaleznosciZerowa
    {
        /// <summary>
        /// Stworz nowa instancje naleznosci pienieznej zerowej.
        /// </summary>
        INaleznoscPieniezna StworzNaleznoscZerowa();
    }
}