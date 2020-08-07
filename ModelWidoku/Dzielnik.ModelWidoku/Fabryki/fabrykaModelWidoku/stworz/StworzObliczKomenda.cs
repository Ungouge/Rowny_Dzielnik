using System;

using Dzielnik.ModelWidoku.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komendy;
using Dzielnik.ModelWidoku.Komendy;

namespace Dzielnik.ModelWidoku.Fabryki
{
    partial class FabrykaModelWidoku
    {
        public IObliczKomenda StworzObliczKomenda(Action naObliczKomendaAkcja, ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik)
        {
            return new ObliczKomenda(naObliczKomendaAkcja, czyMoznaObliczacWkaznik);
        }
    }
}
