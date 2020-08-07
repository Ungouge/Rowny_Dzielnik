using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Wyjatki;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Fabryki
{
    partial class FabrykaModelWidoku
    {
        public ITekstKwotyWejsciowejKonwerter StworzTekstKwotyWejsciowejKonwerter(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik)
        {
            switch (rodzajNaleznosciWylicznik)  
            {
                case RodzajNaleznosciWylicznik.NaleznoscPieniezna:
                    return StworzTekstKwotyWejsciowejNaleznosciPienieznejKonwerter();
            }
            throw new ZlyTypNaleznosciWyjatek(this, rodzajNaleznosciWylicznik.GetType());
        }

        private ITekstKwotyWejsciowejKonwerter StworzTekstKwotyWejsciowejNaleznosciPienieznejKonwerter()
        { 
            return new Konwertery.TekstKwotyWejsciowejNaleznosciPienieznejKonwerter(fabrykaNaleznoscPieniezna, fabrykaNaleznoscPienieznaZerowa.StworzNaleznoscZerowa());
        }
    }
}