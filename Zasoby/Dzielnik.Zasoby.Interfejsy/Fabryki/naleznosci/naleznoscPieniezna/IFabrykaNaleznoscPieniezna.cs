using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs fabryki dla NaleznoscPieniezna.
    /// </summary>
    public interface IFabrykaNaleznoscPieniezna: IFabrykaNaleznosci
    {
        /// <summary>
        /// Stworz nowa instancje naleznosci pienieznej.
        /// </summary>
        INaleznoscPieniezna StworzNaleznosc(int grosze = 0);
    }
}