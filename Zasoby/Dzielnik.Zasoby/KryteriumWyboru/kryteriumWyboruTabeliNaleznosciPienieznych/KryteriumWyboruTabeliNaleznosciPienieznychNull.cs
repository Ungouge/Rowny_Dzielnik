using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    /// <summary>
    /// Kryteriow wyboru tabel naleznosci ze swiadczeniem pienieznym z zachowaniem pustym.
    /// </summary>
    internal class KryteriumWyboruTabeliNaleznosciPienieznychNull: KryteriumWyboruTabeliNaleznosciPienieznychBaza, IKryteriumWyboruTabeliNaleznosciPienieznej
    {
        public override bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosciPienieznej porownywaneKryterium)
        {
            return false;
        }
    }
}