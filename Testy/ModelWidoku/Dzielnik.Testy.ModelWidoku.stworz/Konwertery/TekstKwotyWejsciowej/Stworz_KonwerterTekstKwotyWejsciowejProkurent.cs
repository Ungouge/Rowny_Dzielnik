using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Konwertery;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej
{
    internal static class Stworz_KonwerterTekstKwotyWejsciowejProkurent
    {
        internal static IKonwerterTekstKwotyWejsciowejProkurent Stworz(ITekstKwotyWejsciowejKonwerter konwerter)
        {
            return new KonwerterTekstKwotyWejsciowejProkurent(konwerter);
        }
    }
}