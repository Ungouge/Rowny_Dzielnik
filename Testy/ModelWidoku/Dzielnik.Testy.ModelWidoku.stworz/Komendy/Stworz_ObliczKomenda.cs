using System;

using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komendy;
using Dzielnik.ModelWidoku.Komendy;
using Dzielnik.Testy.ModelWidoku.CzyMoznaObliczac;

namespace Dzielnik.Testy.ModelWidoku.Komendy
{
    internal static class Stworz_ObliczKomenda
    {
        internal static IObliczKomenda Stworz(Action naObliczKomendaAkcja)
        {
            ICzyMoznaObliczacWkaznik czyMoznaObliczac = Stworz_CzyMoznaObliczacWkaznik_Mock.Stworz_Mock();

            return Stworz(naObliczKomendaAkcja,czyMoznaObliczac);
        }

        internal static IObliczKomenda Stworz()
        {
            ICzyMoznaObliczacWkaznik czyMoznaObliczac = Stworz_CzyMoznaObliczacWkaznik_Mock.Stworz_Mock();

            return Stworz(czyMoznaObliczac);
        }

        internal static IObliczKomenda Stworz(ICzyMoznaObliczacWkaznik czyMoznaObliczac)
        {
            return Stworz(default(Action), czyMoznaObliczac);
        }

        internal static IObliczKomenda Stworz(Action naObliczKomendaAkcja, ICzyMoznaObliczacWkaznik czyMoznaObliczac)
        {
            return new ObliczKomenda(naObliczKomendaAkcja, czyMoznaObliczac);
        }
    }
}
