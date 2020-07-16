using System;

using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Wyliczniki;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.KomorkaNaOsoba
{
    public class Czy_KomorkaNaOsobaPienieznaWizytor_CzyOdpowiadaRodzajowiNaleznosci
    {
        [Fact]
        public void Czy_CzyOdpowiadaRodzajowiNaleznosci_Zwraca_Prawde()
        {
            //Ustal
            IKonwerterKomorkaNaOsobaWizytator konwerter = Stworz_KomorkaNaOsobaPienieznaWizytor.Stworz();

            //Dzialaj
            bool czyOdpowiadaRodzajowiNaleznosci = konwerter.CzyOdpowiadaRodzajowiNaleznosci(RodzajNaleznosciWylicznik.NaleznoscPieniezna);

            //Asercja
            Assert.True(czyOdpowiadaRodzajowiNaleznosci);
        }

        [Fact]
        public void Czy_CzyOdpowiadaRodzajowiNaleznosci_Zwraca_Falsz()
        {
            //Ustal
            IKonwerterKomorkaNaOsobaWizytator konwerter = Stworz_KomorkaNaOsobaPienieznaWizytor.Stworz();

            //Dzialaj
            bool czyOdpowiadaRodzajowiNaleznosci = konwerter.CzyOdpowiadaRodzajowiNaleznosci((RodzajNaleznosciWylicznik) Int32.MaxValue);

            //Asercja
            Assert.False(czyOdpowiadaRodzajowiNaleznosci);
        }
    }
}
