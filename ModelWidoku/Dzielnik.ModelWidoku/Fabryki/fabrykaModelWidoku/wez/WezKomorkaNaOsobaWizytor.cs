using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Fabryki
{
    partial class FabrykaModelWidoku
    {
        public IKonwerterKomorkaNaOsobaWizytator WezKomorkaNaOsobaWizytor(IUstawieniaRodzajNaleznosciWylicznik ustawienia)
        {
            RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik = ustawienia.RodzajNaleznosciWylicznik;

            if (komorkaNaOsobaWizytor.CzyOdpowiadaRodzajowiNaleznosci(rodzajNaleznosciWylicznik) == false)
                komorkaNaOsobaWizytor = StworzKomorkaNaOsobaWizytor(rodzajNaleznosciWylicznik);

            return komorkaNaOsobaWizytor;
        }
    }
}
