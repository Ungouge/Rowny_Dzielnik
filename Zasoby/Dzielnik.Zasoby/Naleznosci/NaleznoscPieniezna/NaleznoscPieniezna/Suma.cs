using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    partial class NaleznoscPieniezna
    {
        public INaleznoscPieniezna Suma(INaleznoscPieniezna naleznosc)
        {
            return new NaleznoscPieniezna(Swiadczenie + naleznosc.Swiadczenie);
        }
    }
}