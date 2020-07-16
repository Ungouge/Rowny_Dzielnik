using System;

using Dzielnik.ModelWidoku.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Testy.ModelWidoku.Komorka;

namespace Dzielnik.Testy.ModelWidoku.CzyMoznaObliczac
{
    internal static class Stworz_CzyMoznaObliczacWkaznik
    {
        internal static ICzyMoznaObliczacWkaznik Stworz(bool[] poczatkoweWskazniki, out IKomorkaWejsciowaKwoty[] komorkiTabela)
        {
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik = Stworz_CzyMoznaObliczacWkaznik.Stworz();

            byte rozmiarTableliKomorek = (byte)poczatkoweWskazniki.Length;

            komorkiTabela = new IKomorkaWejsciowaKwoty[rozmiarTableliKomorek];

            for (byte indeks = 0; indeks < rozmiarTableliKomorek; indeks++)
                komorkiTabela[indeks] = Stworz_KomorkaWejsciowaKwoty_Mock.Stworz_Mock();

            for (byte indeks = 0; indeks < rozmiarTableliKomorek; indeks++)
                czyMoznaObliczacWkaznik.ZmienMozliwoscOblicznia(komorkiTabela[indeks], poczatkoweWskazniki[indeks]);

            return czyMoznaObliczacWkaznik;
        }

        internal static ICzyMoznaObliczacWkaznik Stworz()
        {
            return new CzyMoznaObliczacWkaznik();
        }
    }
}