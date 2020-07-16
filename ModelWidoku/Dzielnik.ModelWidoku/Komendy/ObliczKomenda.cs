using System;

using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komendy;
using Dzielnik.ModelWidoku.Zdarzenia;

namespace Dzielnik.ModelWidoku.Komendy
{
    /// <summary>
    /// Interfejs dla przcisku obliczania komendy.
    /// </summary>
    internal class ObliczKomenda : IObliczKomenda
    {
        private readonly Action naObliczKomendaAkcja;

        bool czyMoznaObliczac;

        public ObliczKomenda(Action naObliczKomendaAkcja, ICzyMoznaObliczacZmianaWartosci czyMoznaObliczacWkaznik)
        {
            this.naObliczKomendaAkcja = naObliczKomendaAkcja;

            czyMoznaObliczacWkaznik.ZmianaWartosci += CzyMoznaObliczacWkaznik_ZmianaWartosci;

            czyMoznaObliczac =  true;
        }

        private void CzyMoznaObliczacWkaznik_ZmianaWartosci(object sender, ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia e)
        {
            if (czyMoznaObliczac == e.CzyMoznaObliczac)
                return;

            czyMoznaObliczac = e.CzyMoznaObliczac;

            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
        
        public bool CanExecute(object parameter)
        {
            return czyMoznaObliczac;
        }

        public void Execute(object parameter)
        {
            naObliczKomendaAkcja();
        }
    }
}