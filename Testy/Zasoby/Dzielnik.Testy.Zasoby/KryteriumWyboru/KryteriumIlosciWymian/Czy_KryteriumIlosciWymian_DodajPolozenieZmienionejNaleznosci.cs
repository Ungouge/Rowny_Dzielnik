using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Xunit;


namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumIlosciWymian
{
    public class Czy_KryteriumIlosciWymian_DodajPolozenieZmienionejNaleznosci
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 2)]
        [InlineData(0, 5)]
        [InlineData(0, 357)]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(1, 5)]
        [InlineData(1, 357)]
        [InlineData(2, 0)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        [InlineData(2, 5)]
        [InlineData(2, 357)]
        [InlineData(5, 0)]
        [InlineData(5, 1)]
        [InlineData(5, 2)]
        [InlineData(5, 5)]
        [InlineData(5, 357)]
        [InlineData(357, 0)]
        [InlineData(357, 1)]
        [InlineData(357, 2)]
        [InlineData(357, 5)]
        [InlineData(357, 357)]
        public void Czy_Prawidlowo_DodajeRoznePolozenia(ushort iloscWymian, ushort dodanaIloscWymian)
        {
            //Ustal i
            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumIlosciWymian(iloscWymian);

            // Dzialaj
            foreach
                (
                    IPolozenieGornotrojkatneWTabeliNaleznosci polozenie in
                    PolozeniaWymianWTabeli_Generator.GenerujKolejnePolozeniaWymianWtabeli(dodanaIloscWymian, iloscWymian)
                )
                kryteriumIlosciWymian = kryteriumIlosciWymian.DodajPolozenieZmienionejNaleznosci(polozenie);

            //Asercja
            Assert.Equal(iloscWymian + dodanaIloscWymian, kryteriumIlosciWymian.WezIlosciWymian);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 2)]
        [InlineData(0, 5)]
        [InlineData(0, 357)]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(1, 5)]
        [InlineData(1, 357)]
        [InlineData(2, 0)]
        [InlineData(2, 1)]
        [InlineData(2, 2)]
        [InlineData(2, 5)]
        [InlineData(2, 357)]
        [InlineData(5, 0)]
        [InlineData(5, 1)]
        [InlineData(5, 2)]
        [InlineData(5, 5)]
        [InlineData(5, 357)]
        [InlineData(357, 0)]
        [InlineData(357, 1)]
        [InlineData(357, 2)]
        [InlineData(357, 5)]
        [InlineData(357, 357)]
        public void Czy_Prawidlowo_DodajeCzesciowaTeSamePolozenia(ushort iloscWymian, ushort dodanaIloscWymian)
        {
            //Ustal i
            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumIlosciWymian(iloscWymian);

            // Dzialaj
            foreach
                (
                    IPolozenieGornotrojkatneWTabeliNaleznosci polozenie in
                    PolozeniaWymianWTabeli_Generator.GenerujKolejnePolozeniaWymianWtabeli(dodanaIloscWymian)
                )
                kryteriumIlosciWymian = kryteriumIlosciWymian.DodajPolozenieZmienionejNaleznosci(polozenie);

            //Asercja
            Assert.Equal(iloscWymian > dodanaIloscWymian ? iloscWymian : dodanaIloscWymian, kryteriumIlosciWymian.WezIlosciWymian);
        }
    }
}