using System.ComponentModel;

using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Model.Interfejsy;
using Dzielnik.ModelWidoku.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;

namespace Dzielnik.ModelWidoku
{
    internal partial class ModelWidokuDzielnika : IModelWidokuDzielnikaWewnetrzny, INotifyPropertyChanged
    {
        internal ModelWidokuDzielnika(IFabrykaModelWidoku fabrykaModelWidoku, IUstawienia ustawienia,
            IModelDzielnikaDlaModelWidoku model,
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik)
        {
            this.fabrykaModelWidoku = fabrykaModelWidoku;

            this.ustawienia = ustawienia;

            ElementWysokosc = ustawienia.ElementSzerokosc;

            tabelaKomorek = fabrykaModelWidoku.StworzTabelaKomorek(ustawienia);

            ObliczKomenda = fabrykaModelWidoku.StworzObliczKomenda(UaktualnijModel, czyMoznaObliczacWkaznik);

            model.ObliczonaTabelNaleznocsci += ModelDzielnika_ObliczonaTabelNaleznocsci;

            uaktualniacz = fabrykaModelWidoku.StworzModelUaktualniacz();
        }
    }
}