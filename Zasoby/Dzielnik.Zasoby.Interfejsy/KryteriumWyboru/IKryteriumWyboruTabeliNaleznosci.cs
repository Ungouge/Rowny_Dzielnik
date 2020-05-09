
namespace Dzielnik.Zasoby.Interfejsy.KryteriumWyboru
{
    /// <summary>
    /// Interfejs bazowy dla kryteriow wyboru tabel naleznosci.
    /// </summary>
    public interface IKryteriumWyboruTabeliNaleznosci
    {
        /// <summary>
        /// Stwierdza czy porownywane kryterium jest lepsze.
        /// </summary>
        bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosci porownywaneKryterium);
    }
}
