using System;

using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Testy.Model.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Testy.TablicaOsob;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Xunit;

namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    public class Czy_NajlepszaWymianaNalezosciPienieznejZnajdywacz_Znajdz
    {
        [Theory]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0, new int[] { 0 }, new int[] { 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 4, 0, 0, 0 }, 3, new int[] { 1 }, new int[] { 1, 0 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 12, 0, 0, 0 }, 3, new int[] { 3 }, new int[] { 3, 0 }, new int[] { 3, 0, 0 })]
        [InlineData(new int[] { 22, 21, 19, 18 }, 2, new int[] { 0 }, new int[] { 0, 1 }, new int[] { 2, 0, 0 })]
        [InlineData(new int[] { 96, 16, 16, 0 }, 3, new int[] { 16 }, new int[] { 16, 0 }, new int[] { 32, 0, 0 })]
        [InlineData(new int[] { 0, 320, 357, 0 }, 3, new int[] { -151 }, new int[] { -19, 0 }, new int[] { 0, 0, 169 })]
        [InlineData(new int[] { 5, 8, 0, 3 }, 2, new int[] { 0 }, new int[] { 0, 4 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 5, 0, 0, 0, 0 }, 4, new int[] { 1 }, new int[] { 1, 0 }, new int[] { 1, 0, 0 }, new int[] { 1, 0, 0, 0 })]
        [InlineData(new int[] { 22, 21, 20, 19, 18 }, 2, new int[] { 0 }, new int[] { 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 2, 0, 0, 0 })]
        public void Czy_Zwraca_NajlepszTabelaNaleznosci_DlaKryteriumIlosciWymian(int[] naleznosciDoTablicyOsob, ushort oczekiwanaIloscWymian,
            params int[][] naleznosciDoTabeliNalznosci)
        {
            //Ustal
            ITablicaOsobPienieznych tablicaOsob = Stworz_TablicaOsobPienieznych.Stworz(naleznosciDoTablicyOsob);
            
            INajlepszaWymianaNalezosciPienieznejZnajdywacz znajdywacz =
                Stworz_NajlepszaWymianaNalezosciPienieznejZnajdywacz.Stworz(tablicaOsob,
                    KryteriumWyboruTabeliNaleznosciWylicznik.IlosciWymian);

            //Dzialaj
            ITabelaNaleznosciPienieznejZwrotna tabelaNaleznosciZnalezniona = znajdywacz.Znajdz(tablicaOsob);

            ushort znalezionaIloscWymian;

            if (tabelaNaleznosciZnalezniona is ITabelaNaleznosciPienieznejNull)
                znalezionaIloscWymian = 0;
            else
                znalezionaIloscWymian = ((tabelaNaleznosciZnalezniona as ITabelaNaleznosciPienieznej).
                    KryteriumWyboruTabeliNaleznosci as IKryteriumIlosciWymian).WezIlosciWymian;

            //Asercja
            AssertujZnalezionaTabeleNaleznosci(naleznosciDoTabeliNalznosci, tabelaNaleznosciZnalezniona);
            
            Assert.Equal(oczekiwanaIloscWymian, znalezionaIloscWymian);
        }

        [Theory]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0 }, new int[] { 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 4, 0, 0, 0 }, new int[] { 1 }, new int[] { 1, 0 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 12, 0, 0, 0 }, new int[] { 3 }, new int[] { 3, 0 }, new int[] { 3, 0, 0 })]
        [InlineData(new int[] { 22, 21, 19, 18 }, new int[] { 0 }, new int[] { 1, 0 }, new int[] { 1, 1, 0 })]
        [InlineData(new int[] { 96, 16, 16, 0 }, new int[] { 16 }, new int[] { 16, 0 }, new int[] { 32, 0, 0 })]
        [InlineData(new int[] { 0, 320, 357, 0 }, new int[] { -151 }, new int[] { -19, 0 }, new int[] { 0, 0, 169 })]
        [InlineData(new int[] { 5, 8, 0, 3 }, new int[] { 0 }, new int[] { 1, 3 }, new int[] { 0, 1, 0 })]
        [InlineData(new int[] { 5, 0, 0, 0, 0 }, new int[] { 1 }, new int[] { 1, 0 }, new int[] { 1, 0, 0 }, new int[] { 1, 0, 0, 0 })]
        [InlineData(new int[] { 22, 21, 20, 19, 18 }, new int[] { 0 }, new int[] { 0, 0 }, new int[] { 1, 0, 0 }, new int[] { 1, 1, 0, 0 })]
        public void Czy_Zwraca_NajlepszTabelaNaleznosci_DlaKryteriumSumyWymienionejNaleznosci(int[] naleznosciDoTablicyOsob, params int[][] naleznosciDoTabeliNalznosci)
        {
            //Ustal
            ITablicaOsobPienieznych tablicaOsob = Stworz_TablicaOsobPienieznych.Stworz(naleznosciDoTablicyOsob);

            INajlepszaWymianaNalezosciPienieznejZnajdywacz znajdywacz =
                Stworz_NajlepszaWymianaNalezosciPienieznejZnajdywacz.Stworz(tablicaOsob,
                    KryteriumWyboruTabeliNaleznosciWylicznik.KryteriumSumyWymienionejNaleznosci);

            //Dzialaj
            ITabelaNaleznosciPienieznejZwrotna tabelaNaleznosciZnalezniona = znajdywacz.Znajdz(tablicaOsob);

            //Asercja
            AssertujZnalezionaTabeleNaleznosci(naleznosciDoTabeliNalznosci, tabelaNaleznosciZnalezniona);
        }

        private static void AssertujZnalezionaTabeleNaleznosci(int[][] naleznosciDoTabeliNalznosci, ITabelaNaleznosciPienieznejZwrotna tabelaNaleznosciZnalezniona)
        {
            string komunikatOBledzie = KomuniatOBledzieKonstruktor.Sporzadz(naleznosciDoTabeliNalznosci, tabelaNaleznosciZnalezniona);

            bool czyTabeleSieZgadzaja = String.IsNullOrEmpty(komunikatOBledzie);

            Assert.True(czyTabeleSieZgadzaja, czyTabeleSieZgadzaja ? "Wszystkie wartosci wyrazone sie zgadzaja" : komunikatOBledzie);
        }
    }
}