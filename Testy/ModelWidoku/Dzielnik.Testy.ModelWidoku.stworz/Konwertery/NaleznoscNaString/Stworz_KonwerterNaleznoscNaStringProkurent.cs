using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Konwertery;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString
{
    internal static class Stworz_KonwerterNaleznoscNaStringProkurent
    {
        internal static IKonwerterNaleznoscNaStringProkurent Stworz(INaleznoscNaStringKonwerter konwerter)
        {
            return new KonwerterNaleznoscNaStringProkurent(konwerter);
        }
    }
}