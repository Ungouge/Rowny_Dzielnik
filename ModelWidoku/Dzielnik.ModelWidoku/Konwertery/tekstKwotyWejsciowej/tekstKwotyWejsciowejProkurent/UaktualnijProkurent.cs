using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Zdarzenia;

namespace Dzielnik.ModelWidoku.Konwertery
{
    partial class KonwerterTekstKwotyWejsciowejProkurent
    {
        public void UaktualnijProkurent(ITekstKwotyWejsciowejKonwerter konwerter)
        {
            this.konwerter = konwerter;

            ZmianaTekstKwotyWejsciowejKonwerter_ObslugaZdarzenia?.Invoke(this, new ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia());
        }
    }
}