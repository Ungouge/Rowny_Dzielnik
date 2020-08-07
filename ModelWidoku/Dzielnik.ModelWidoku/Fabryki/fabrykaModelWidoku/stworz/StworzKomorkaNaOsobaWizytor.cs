using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Konwertery;
using Dzielnik.Zasoby.Wyjatki;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Fabryki
{
    partial class FabrykaModelWidoku
    {
        private IKonwerterKomorkaNaOsobaWizytator StworzKomorkaNaOsobaWizytor(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik)
        {
            switch (rodzajNaleznosciWylicznik)
            {
                case RodzajNaleznosciWylicznik.NaleznoscPieniezna:
                    return new KomorkaNaOsobaPienieznaWizytator(fabrykaOsobaPieniezna);
            }

            throw new ZlyTypNaleznosciWyjatek(this, rodzajNaleznosciWylicznik.GetType());
        }
    }
}
