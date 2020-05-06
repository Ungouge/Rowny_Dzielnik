using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    partial class NaleznoscPienieznaZerowa
    {
        public INaleznoscPieniezna Roznica(INaleznoscPieniezna naleznosc)
        {
            return naleznosc.Odwrotnosc();
        }
    }
}