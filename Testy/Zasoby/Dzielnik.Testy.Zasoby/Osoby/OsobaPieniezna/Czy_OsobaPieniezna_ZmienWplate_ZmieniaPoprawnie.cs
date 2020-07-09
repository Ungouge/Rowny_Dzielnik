using System;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Osoby.OsobaPieniezna
{
    public class Czy_OsobaPieniezna_ZmienWplate
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-5)]
        [InlineData(128)]
        [InlineData(357)]
        [InlineData(Int32.MaxValue)]
        [InlineData(Int32.MinValue)]
        public void Czy_OsobaPieniezna_ZmienWplate_ZmieniaPoprawnie(int nowaNaleznosc)
        {
            //Ustal
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Mock();

            IOsobaPieniezna osoba = Stworz_OsobaPieniezna.Stworz(naleznosc);

            INaleznoscPieniezna dodawanaNaleznosc_Mock = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(nowaNaleznosc);

            //Dzialaj
            IOsobaPieniezna OsobaAktualna = osoba.ZmienWplate(dodawanaNaleznosc_Mock);

            //Asercja
            Assert.Equal(nowaNaleznosc, OsobaAktualna.Wplata.Swiadczenie);
        }
    }
}