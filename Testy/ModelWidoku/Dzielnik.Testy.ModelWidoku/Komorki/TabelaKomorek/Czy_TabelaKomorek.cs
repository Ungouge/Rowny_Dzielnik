using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.Testy.ModelWidoku.Fabryki;
using Dzielnik.Testy.Inicjalizator.Ustawienia;

using Xunit;
using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki.TabelaKomorek
{
    public class Czy_TabelaKomorek
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(31)]
        [InlineData(63)]
        public void Czy_TabelaKomorek_Tworzy_Prawidlowo(byte iloscOsob)
        {
            //Ustal
            Mock<IFabrykaModeluWidokuDlaTabelaKomorek> fabryka_Mock = Stworz_FabrykaModeluWidokuDlaTabelaKomorek_Mock.Stworz_StworzKomorki_WeryfikowalnyMock();

            IUstawieniaDlaTabelaKomorek ustawienia = Stworz_UstawieniaDlaTabelaKomorek.Stworz(iloscOsob);

            ITabelaKomorek tabelaKomorek = Stworz_TabelaKomorek.Stworz(fabryka_Mock.Object, ustawienia);

            short iloscKomorekPozadiagonalnych = (short)((iloscOsob * (iloscOsob - 1)) / 2);

            //Asercja
            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkaDiagonalna(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>()), Times.Exactly(iloscOsob));

            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkaDolnotrojkatnaKwotyNaleznej(It.IsAny<IKomorkaKwotyNaleznej>()), Times.Exactly(iloscKomorekPozadiagonalnych));

            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkaGornotrojkatnaKwotyNaleznej(It.IsAny<IKomorkaKwotyNaleznej>()), Times.Exactly(iloscKomorekPozadiagonalnych));

            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkaWejsciowaKwoty(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>()), Times.Exactly(iloscOsob));

            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkaWejsciowaImienia(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>()), Times.Exactly(iloscOsob));

            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkaWyjsciowaImienia(It.IsAny<IKomorkaImieniaINaleznosciWejscowej>()), Times.Exactly(iloscOsob));

            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkaKwotyNaleznej(It.IsAny<byte>(), It.IsAny<byte>(), It.IsAny<IKonwerterNaleznoscNaStringProkurent>()), Times.Exactly(iloscKomorekPozadiagonalnych));

            fabryka_Mock.
                Verify(fabryka => fabryka.StworzKomorkiImieniaINaleznosciWejscowej(It.IsAny<byte>(), It.IsAny<IKonwerterTekstKwotyWejsciowejProkurent>()), Times.Exactly(iloscOsob));
        }
    }
}
