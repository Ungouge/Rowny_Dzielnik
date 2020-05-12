using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Testy.TablicaOsob;
using Dzielnik.Testy.Zasoby.Osoby;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Xunit;

namespace Dzielnik.Testy.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz
{
    public class Czy_NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz_UstalNaleznoscDoWymiany
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { 4, 0, 0, 0 }, 0, 1, 1)]
        [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { 2, 2, 0, 0 }, 0, 3, 1)]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 8, 0, 0, 0 }, 0, 3, 2)]
        [InlineData(new int[] { 6, 0, 3, 3 }, new int[] { 12, 0, 0, 0 }, 0, 1, 0)]
        [InlineData(new int[] { 101, 101, 100, 100 }, new int[] { 207, 50, 50, 95 }, 0, 3, 5)]
        [InlineData(new int[] { 101, 101, 100, 100 }, new int[] { 207, 50, 50, 95 }, 3, 0, 0)]
        [InlineData(new int[] { 101, 101, 100, 100 }, new int[] { 262, 50, 50, 40 }, 0, 3, 60)]
        [InlineData(new int[] { 101, 101, 100, 100 }, new int[] { 262, 50, 50, 40 }, 3, 0, 0)]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 4, 2, 2, 0 }, 0, 3, 2)]
        public void Czy_UstalNaleznoscDoWymiany_Ustala_Prawidlowo(int[] koncowaTabelaSwiadczen, int[] tabelaSwiadczen, byte iDKorzen, byte iDPotomek,
            int oczekiwanaNaleznoscDoWymiany )
        {
            //Ustal
            ITablicaOsobPienieznychZwrotna koncowaTablicaOsob = Stworz_TablicaOsobPienieznych.Stworz(koncowaTabelaSwiadczen);

            ITablicaOsobPienieznychZwrotna tablicaOsob = Stworz_TablicaOsobPienieznych.Stworz(tabelaSwiadczen);

            //Dzialaj i Asercja
            Czy_UstalNaleznoscDoWymiany_Ustala(iDKorzen, iDPotomek, oczekiwanaNaleznoscDoWymiany, tablicaOsob, koncowaTablicaOsob);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 0, 4, 4, 0 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 2, 3, 3, 0 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 0, 3, 3, 2 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 2, 2, 2, 2 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 4, 1, 1, 2 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 2, 1, 1, 4 })]
        [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { 0, 0, 2, 2 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 0, 0, 0, 8 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 2, 0, 0, 6 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 5, 0, 0, 3 })]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 0, 2, 2, 4 })]
        public void Czy_UstalNaleznoscDoWymiany_Ustala_NaleznoscZerowa(int[] koncowaTabelaSwiadczen, int[] tabelaSwiadczen )
        {
            //Ustal
            ITablicaOsobPienieznychZwrotna koncowaTablicaOsob = Stworz_TablicaOsobPienieznych.Stworz(koncowaTabelaSwiadczen);

            ITablicaOsobPienieznychZwrotna tablicaOsob = Stworz_TablicaOsobPienieznych.Stworz(tabelaSwiadczen);

            //Dzialaj i Asercja
            Czy_UstalNaleznoscDoWymiany_Ustala(0, 3, 0, tablicaOsob, koncowaTablicaOsob);
        }

        private static void Czy_UstalNaleznoscDoWymiany_Ustala(byte iDKorzen, byte iDPotomek, int oczekiwanaNaleznoscDoWymiany,
            ITablicaOsobPienieznychZwrotna poczatkowatablicaOsob, ITablicaOsobPienieznychZwrotna koncowaTablicaOsob)
        {
            IOsobaID osobaKorzen = Stworz_OsobaID_Moq.Stworz_ID_Moq(iDKorzen);

            IOsobaID osobaPotomek = Stworz_OsobaID_Moq.Stworz_ID_Moq(iDPotomek);

            INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz najwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz =
               Stworz_NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz.Stworz(koncowaTablicaOsob);

            //Dzialaj
            INaleznoscPieniezna naleznoscDoWymiany =
                najwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz.UstalNaleznoscDoWymiany(poczatkowatablicaOsob, osobaKorzen, osobaPotomek);

            //Asercja
            Assert.Equal(oczekiwanaNaleznoscDoWymiany, naleznoscDoWymiany.Swiadczenie);
        }
    }
}
