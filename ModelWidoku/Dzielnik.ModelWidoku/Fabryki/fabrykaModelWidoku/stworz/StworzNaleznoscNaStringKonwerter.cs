using System;

using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Konwertery;
using Dzielnik.Zasoby.Wyjatki;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Fabryki
{
    internal partial class FabrykaModelWidoku
    {
        public IKonwerterNaleznoscNaStringProkurent StworzNaleznoscNaStringProkurentProkurent(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik)
        {
            return new KonwerterNaleznoscNaStringProkurent(StworzNaleznoscNaStringKonwerter(rodzajNaleznosciWylicznik));
        }

        public INaleznoscNaStringKonwerter StworzNaleznoscNaStringKonwerter(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik)
        {
            switch (rodzajNaleznosciWylicznik)
            {
                case RodzajNaleznosciWylicznik.NaleznoscPieniezna:
                    return StworzNaleznoscPienieznaNaStringKonwerter();
            }

            throw new ZlyTypNaleznosciWyjatek(this, rodzajNaleznosciWylicznik.GetType());
        }

        public INaleznoscNaStringKonwerter StworzNaleznoscPienieznaNaStringKonwerter()
        {
            return new NaleznoscPienieznaNaStringKonwerter();
        }
        

    }
}
