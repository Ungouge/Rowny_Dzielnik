using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    internal partial class NaleznoscPienieznaZerowa
    {
        public bool CzyWieksze(INaleznoscPieniezna PorownywanaNaleznosc)
        {
            return PorownywanaNaleznosc.Swiadczenie > 0;
        }
    }
}