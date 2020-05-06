using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    partial class NaleznoscPieniezna
    {
        public INaleznoscPieniezna Odwrotnosc()
        {
            return new NaleznoscPieniezna(this.Swiadczenie * -1);
        }
    }
}