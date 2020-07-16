using System;

using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Zdarzenia;
using Dzielnik.Testy.ModelWidoku.Pomocnicze;
using Dzielnik.Testy.ModelWidoku.Zdarzenia;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.CzyMoznaObliczac
{
    internal static class DodajSubskrypcjeWydarzeniuZmianaWartosci
    {
        internal static Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> DodajAtrapeOslugiaZdarzenia(ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik)
        {
            Mock<EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia>> obslugaZdarzenia = Stworz_ZmianaStatusuMozliwosciObliczania_ObslugaZdarzenia_Mock.Stworz_WeryfikalnyMock();

            czyMoznaObliczacWkaznik.ZmianaWartosci += obslugaZdarzenia.Object;

            return obslugaZdarzenia;
        }

        internal static LicznikWywolan DodajLicznikWywolan(ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik, bool NaKtoraZmianeCzyMoznaObliczac)
        {
            LicznikWywolan licznik = new LicznikWywolan();

            czyMoznaObliczacWkaznik.ZmianaWartosci += (senderx, e) =>
            {
                if (e.CzyMoznaObliczac == NaKtoraZmianeCzyMoznaObliczac)
                    licznik.DodajWywolanie();
            };

            return licznik;
        }
    }
}