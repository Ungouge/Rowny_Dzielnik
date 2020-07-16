using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Konwertery
{
    partial class KonwerterNaleznoscNaStringProkurent
    {
        public string NaString(INaleznoscSwiadczenieBaza naleznosc)
        {
            return konwerter.NaString(naleznosc);
        }
    }
}