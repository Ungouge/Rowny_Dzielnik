
namespace Dzielnik.Zasoby.Interfejsy.KryteriumWyboru
{
    /// <summary>
    /// Interfejs bazowy dla kryteriow wyboru tabel naleznosci ze swiadczeniem pienieznym.
    /// </summary>
    public interface IKryteriumWyboruTabeliNaleznosciPienieznej: IKryteriumWyboruTabeliNaleznosci
    {
        /// <summary>
        /// Stwierdza czy porownywane kryterium naleznosci pienieznej jest lepsze.
        /// </summary>
        bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosciPienieznej porownywaneKryterium);
    }
}