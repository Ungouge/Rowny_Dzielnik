using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Osoby
{
    partial class OsobaPieniezna
    {
        public IOsobaPieniezna ZmienWplate(INaleznoscPieniezna nowaNaleznosc)
        {
            return new OsobaPieniezna(ID, nowaNaleznosc);
        }
    }
}