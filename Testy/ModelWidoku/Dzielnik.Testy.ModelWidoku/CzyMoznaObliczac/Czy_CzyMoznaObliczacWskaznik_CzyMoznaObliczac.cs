using System;

using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Zdarzenia;
using Dzielnik.Testy.ModelWidoku.Komorki;
using Dzielnik.Testy.ModelWidoku.Pomocnicze;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.CzyMoznaObliczac
{
    public class Czy_CzyMoznaObliczacWskaznik_CzyMoznaObliczac
    {
        [Fact]
        public void Czy_CzyMoznaObliczacWskaznik_CzyMoznaObliczac_Zwraca_Prawde_PoStworzeniu()
        {
            //Ustal
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik = Stworz_CzyMoznaObliczacWkaznik.Stworz();

            Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajAtrapeOslugiaZdarzenia(czyMoznaObliczacWkaznik);

            LicznikWywolan licznik = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajLicznikWywolan(czyMoznaObliczacWkaznik, default(bool));

            //Asercja
            WeryfikujZdarzenie(obslugaZdarzenia, licznik);
        }

        [Fact]
        public void Czy_CzyMoznaObliczacWskaznik_CzyMoznaObliczac_Zwraca_Prawde_PoZmianieNaPrawde()
        {
            //Ustal
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik = Stworz_CzyMoznaObliczacWkaznik.Stworz();

            Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajAtrapeOslugiaZdarzenia(czyMoznaObliczacWkaznik);

            bool NaKtoraZmianeCzyMoznaObliczac = true;

            LicznikWywolan licznik = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajLicznikWywolan(czyMoznaObliczacWkaznik, NaKtoraZmianeCzyMoznaObliczac);

            //Dzialaj
            czyMoznaObliczacWkaznik.ZmienMozliwoscOblicznia(Stworz_KomorkaWejsciowaKwoty_Mock.Stworz_Mock(), NaKtoraZmianeCzyMoznaObliczac);

            //Asercja
            WeryfikujZdarzenie(obslugaZdarzenia, licznik);
        }

        [Fact]
        public void Czy_CzyMoznaObliczacWskaznik_CzyMoznaObliczac_Zwraca_Falsz__PoZmianieNaFalsz()
        {
            //Ustal
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik = Stworz_CzyMoznaObliczacWkaznik.Stworz();

            Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajAtrapeOslugiaZdarzenia(czyMoznaObliczacWkaznik);
            
            bool NaKtoraZmianeCzyMoznaObliczac = true;

            LicznikWywolan licznik = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajLicznikWywolan(czyMoznaObliczacWkaznik, NaKtoraZmianeCzyMoznaObliczac);

            //Dzialaj
            czyMoznaObliczacWkaznik.ZmienMozliwoscOblicznia(Stworz_KomorkaWejsciowaKwoty_Mock.Stworz_Mock(), NaKtoraZmianeCzyMoznaObliczac);

            //Asercja
            WeryfikujZdarzenie(obslugaZdarzenia, licznik);
        }

        [Theory]
        [InlineData(new bool[] { false, true, true, true })]
        [InlineData(new bool[] { true, false, true, true })]
        [InlineData(new bool[] { true, true, false, true })]
        [InlineData(new bool[] { true, true, true, false })]
        [InlineData(new bool[] { false, false, true, true })]
        [InlineData(new bool[] { true, false, false, true })]
        [InlineData(new bool[] { true, true, false, false })]
        [InlineData(new bool[] { false, false, false, true })]
        [InlineData(new bool[] { true, false, false, false })]
        [InlineData(new bool[] { false, false, false, false })]
        public void Czy_CzyMoznaObliczacWskaznik_CzyMoznaObliczac_Zwraca_Falsz_PoSeriiZmian(bool[] Wskazniki)
        {
            //Ustal
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik = Stworz_CzyMoznaObliczacWkaznik.Stworz();

            Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajAtrapeOslugiaZdarzenia(czyMoznaObliczacWkaznik);
            
            bool NaKtoraZmianeCzyMoznaObliczac = false;

            LicznikWywolan licznik = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajLicznikWywolan(czyMoznaObliczacWkaznik, NaKtoraZmianeCzyMoznaObliczac);

            //Dzialaj
            czyMoznaObliczacWkaznik.ZmienMozliwoscOblicznia(Stworz_KomorkaWejsciowaKwoty_Mock.Stworz_Mock(), NaKtoraZmianeCzyMoznaObliczac);

            //Dzialaj
            for (byte indeks = 0; indeks < (byte)Wskazniki.Length; indeks++)
                if (Wskazniki[indeks] == false)
                    czyMoznaObliczacWkaznik.ZmienMozliwoscOblicznia(Stworz_KomorkaWejsciowaKwoty_Mock.Stworz_Mock(), NaKtoraZmianeCzyMoznaObliczac);

            //Asercja
            WeryfikujZdarzenie(obslugaZdarzenia, licznik);
        }

        [Theory]
        [InlineData(new bool[] { true, true, true, true })]
        [InlineData(new bool[] { false, true, true, true })]
        [InlineData(new bool[] { true, false, true, true })]
        [InlineData(new bool[] { true, true, false, true })]
        [InlineData(new bool[] { true, true, true, false })]
        [InlineData(new bool[] { false, false, true, true })]
        [InlineData(new bool[] { true, false, false, true })]
        [InlineData(new bool[] { true, true, false, false })]
        [InlineData(new bool[] { false, false, false, true })]
        [InlineData(new bool[] { true, false, false, false })]
        [InlineData(new bool[] { false, false, false, false })]
        public void Czy_CzyMoznaObliczacWskaznik_CzyMoznaObliczac_Zwraca_Prawda_PoSeriiZmianPrzywracajacychPrawde(bool[] poczatkoweWskazniki)
        {
            //Ustal
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik = Stworz_CzyMoznaObliczacWkaznik.Stworz(poczatkoweWskazniki, out IKomorkaWejsciowaKwoty[] komorkiTabela);

            Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajAtrapeOslugiaZdarzenia(czyMoznaObliczacWkaznik);

            bool NaKtoraZmianeCzyMoznaObliczac = true;

            LicznikWywolan licznik = DodajSubskrypcjeWydarzeniuZmianaWartosci.DodajLicznikWywolan(czyMoznaObliczacWkaznik, NaKtoraZmianeCzyMoznaObliczac);

            //Dzialaj
            for (byte indeks = 0; indeks < poczatkoweWskazniki.Length; indeks++)
                czyMoznaObliczacWkaznik.ZmienMozliwoscOblicznia(komorkiTabela[indeks], NaKtoraZmianeCzyMoznaObliczac);

            //Asercja
            WeryfikujZdarzenie(obslugaZdarzenia, licznik);
        }

        private static void WeryfikujZdarzenie(Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia, LicznikWywolan licznik)
        {
            obslugaZdarzenia.Verify(x => x(It.IsAny<object>(), It.IsAny<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>()), IleRazy(licznik));
        }

        private static Times IleRazy(LicznikWywolan licznik)
        {
            switch (licznik.Licznik)
            {
                case 0:
                    return Times.Never();
                case 1:
                    return Times.Once();
            }

            return Times.Exactly(licznik.Licznik);
        }
    }
}