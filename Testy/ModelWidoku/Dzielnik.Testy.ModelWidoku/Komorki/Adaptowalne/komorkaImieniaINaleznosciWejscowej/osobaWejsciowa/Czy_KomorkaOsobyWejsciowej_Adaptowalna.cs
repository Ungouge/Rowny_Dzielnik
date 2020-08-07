using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Testy.ModelWidoku.Konwertery.KomorkaNaOsoba;
using Dzielnik.Testy.Zasoby.Osoby.OsobaTypSwiadczenia;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaOsobyWejsciowej_Adaptowalna
    {
        [Fact]
        public void Czy_Tworzy_Prawidlowo()
        {
            //Ustal
            byte indeks = default(byte);

            IKomorkaOsobyWejsciowej komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz(indeks) as IKomorkaOsobyWejsciowej;

            IOsobaTypSwiadczenia osoba = Stworz_OsobaTypSwiadczenia_Mock.Stworz_Mock();

            IKonwerterKomorkaNaOsobaWizytator wizytator = Stworz_KonwerterKomorkaNaOsobaWizytator_Mock.Stworz_StworzOsoba_Mock(osoba);

            //Dzialaj
            IOsobaTypSwiadczenia osobaZwrocona = komorka.WezOsoba(wizytator);

            //Asercja
            Assert.Same(osoba, osobaZwrocona);

            Assert.Same(osoba, osobaZwrocona);
        }
    }
}
