using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    partial class NaleznoscPieniezna
    {
        public INaleznoscPieniezna Roznica(INaleznoscPieniezna naleznosc)
        {
            return new NaleznoscPieniezna(Swiadczenie - naleznosc.Swiadczenie);
        }
    }
}