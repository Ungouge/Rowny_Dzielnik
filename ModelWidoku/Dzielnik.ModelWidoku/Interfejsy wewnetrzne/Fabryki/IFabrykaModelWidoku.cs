using System;

using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Komendy;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.ModelWidoku.Fabryki
{
    internal interface IFabrykaModelWidoku : IFabrykaModeluWidokuDlaTabelaKomorek
    {
        IObliczKomenda StworzObliczKomenda(Action naObliczKomendaAkcja, ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik);

        ITabelaKomorek StworzTabelaKomorek(IUstawieniaDlaTabelaKomorek ustawienia);

        ICzyMoznaObliczacWkaznik StworzCzyMoznaObliczacWkaznik();

        ITablicaOsobPienieznych StworzTablicaOsobPienieznych(IOsobaTypSwiadczenia[] szeregOsob);

        IKonwerterKomorkaNaOsobaWizytator WezKomorkaNaOsobaWizytor(IUstawieniaRodzajNaleznosciWylicznik ustawienia);

        IModelUaktualniacz StworzModelUaktualniacz();
    }
}