using System;

using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.KomorkaNaOsoba
{
    public class Czy_KomorkaNaOsobaPienieznaWizytor_StworzOsobaCzyOdpowiadaRodzajowiNaleznosci
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(1, -1)]
        [InlineData(2, -2)]
        [InlineData(4, -5)]
        [InlineData(byte.MinValue, 357)]
        [InlineData(byte.MaxValue, Int32.MaxValue)]
        public void Czy_StworzOsoba_Tworzy_Prawidlowo(byte iD, int grosze)
        {
            //Ustal
            IKonwerterKomorkaNaOsobaWizytator konwerter = Stworz_KomorkaNaOsobaPienieznaWizytor.Stworz();

            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(grosze);

            //Dzialaj
            IOsobaTypSwiadczenia osoba = konwerter.StworzOsoba(iD, naleznosc);

            //Asercja
            Assert.Equal(iD, osoba.ID);

            if (osoba is IOsobaSwiadczeniePieniezne osobaPieniezna)
                Assert.Equal(grosze, osobaPieniezna.Wplata.Swiadczenie);
            else
                Assert.IsAssignableFrom<IOsobaSwiadczeniePieniezne>(osoba);
        }
    }
}