using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Xunit;


namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumIlosciWymian
{
    public class Czy_KryteriumIlosciWymian_DodajPolozenieZmienionejNaleznosci
    {
        [Theory]
        [InlineData(0, 1, 5)]
        [InlineData(0, 2, 2)]
        [InlineData(0, 5, 1)]
        [InlineData(0, 357, 1)]
        [InlineData(1, 1, 5)]
        [InlineData(1, 2, 2)]
        [InlineData(1, 5, 1)]
        [InlineData(1, 357, 1)]
        [InlineData(2, 1, 5)]
        [InlineData(2, 2, 2)]
        [InlineData(2, 5, 1)]
        [InlineData(2, 357, 1)]
        [InlineData(5, 1, 5)]
        [InlineData(5, 2, 2)]
        [InlineData(5, 5, 1)]
        [InlineData(5, 357, 1)]
        [InlineData(357, 1, 5)]
        [InlineData(357, 2, 2)]
        [InlineData(357, 5, 1)]
        [InlineData(357, 357, 1)]
        public void Czy_Prawidlowo_DodajeRoznePolozenia(ushort iloscWymian, ushort dodanaIloscWymian, int swiadczenieWGroszach)
        {
            //Ustal
            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumIlosciWymian(iloscWymian);

            INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(swiadczenieWGroszach);

            // Dzialaj
            foreach
            (
                IPolozenieGornotrojkatneWTabeliNaleznosci polozenie in
                PolozeniaWymianWTabeli_Generator.GenerujKolejnePolozeniaWymianWtabeli(dodanaIloscWymian, iloscWymian)
            )
                kryteriumIlosciWymian = kryteriumIlosciWymian.DodajPolozenieZmienionejNaleznosci(polozenie, naleznoscPieniezna);

            //Asercja
            Assert.Equal(iloscWymian + dodanaIloscWymian, kryteriumIlosciWymian.WezIlosciWymian);
            Assert.Equal(naleznoscPieniezna.Swiadczenie, kryteriumIlosciWymian.WezWymienionaNaleznosc.Swiadczenie);
        }

        [Theory]
        [InlineData(1, 1, 5)]
        [InlineData(1, 357, 1)]
        [InlineData(2, 1, 5)]
        [InlineData(2, 2, 2)]
        [InlineData(5, 1, 5)]
        [InlineData(5, 2, 2)]
        [InlineData(5, 5, 1)]
        [InlineData(357, 1, 5)]
        [InlineData(357, 2, 2)]
        [InlineData(357, 5, 1)]
        [InlineData(357, 357, 1)]
        public void Czy_Prawidlowo_DodajeTeSamePolozenia(ushort iloscWymian, ushort dodanaIloscWymian, int swiadczenieWGroszach)
        {
            //Ustal
            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumIlosciWymian(iloscWymian);

            INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(swiadczenieWGroszach);

            // Dzialaj
            foreach
            (
                IPolozenieGornotrojkatneWTabeliNaleznosci polozenie in
                PolozeniaWymianWTabeli_Generator.GenerujKolejnePolozeniaWymianWtabeli(dodanaIloscWymian)
            )
                kryteriumIlosciWymian = kryteriumIlosciWymian.DodajPolozenieZmienionejNaleznosci(polozenie, naleznoscPieniezna);

            //Asercja
            Assert.Equal(iloscWymian > dodanaIloscWymian ? iloscWymian : dodanaIloscWymian, kryteriumIlosciWymian.WezIlosciWymian);
            Assert.Equal(naleznoscPieniezna.Swiadczenie, kryteriumIlosciWymian.WezWymienionaNaleznosc.Swiadczenie);
        }
    }
}