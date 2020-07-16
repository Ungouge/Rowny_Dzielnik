using System;
using System.Collections.Generic;

using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Zdarzenia;

namespace Dzielnik.ModelWidoku.CzyMoznaObliczac
{
    /// <summary>
    /// Wskaznik wskazujacy czy mozna obliczac.
    /// </summary>
    internal partial class CzyMoznaObliczacWkaznik : ICzyMoznaObliczacWkaznik
    {
        private bool czyMoznaObliczacWkaznik = true;

        private readonly List<IKomorkaWejsciowaKwoty> zabraniajacaKomorkiKwotyWejsciowej = new List<IKomorkaWejsciowaKwoty>();

        public event EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia> ZmianaWartosci;

        public bool CzyMoznaObliczac
        {
            get
            {
                return czyMoznaObliczacWkaznik;
            }
            private set
            {
                if (czyMoznaObliczacWkaznik == value)
                    return;

                czyMoznaObliczacWkaznik = value;

                NaZmianeWlasciwosci();
            }
        }

        protected void NaZmianeWlasciwosci()
        {
            ZmianaWartosci?.Invoke(this, new ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia(CzyMoznaObliczac));
        }
    }
}