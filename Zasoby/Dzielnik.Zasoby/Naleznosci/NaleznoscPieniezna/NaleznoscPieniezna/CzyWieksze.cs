using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    partial class NaleznoscPieniezna
    {
        public bool CzyWieksze(INaleznoscPieniezna PorownywanaNaleznosc)
        {
            return this.Swiadczenie < PorownywanaNaleznosc.Swiadczenie;
        }
    }
}