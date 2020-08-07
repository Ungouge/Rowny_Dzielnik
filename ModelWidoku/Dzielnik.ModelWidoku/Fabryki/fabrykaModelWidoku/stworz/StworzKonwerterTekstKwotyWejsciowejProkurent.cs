using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Konwertery;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Fabryki
{
    partial class FabrykaModelWidoku
    {
        public IKonwerterTekstKwotyWejsciowejProkurent StworzKonwerterTekstKwotyWejsciowejProkurent(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik)
        {
            return new KonwerterTekstKwotyWejsciowejProkurent(StworzTekstKwotyWejsciowejKonwerter(rodzajNaleznosciWylicznik));
        }
    }
}
