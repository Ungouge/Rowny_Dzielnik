using System.Windows;

using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Komendy;
using Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika // Wartosci
    {
        public int ElementWysokosc { get; private set; }

        public int ElementSzerokosc => ElementWysokosc * 4;

        public double OknoMaksymalnaWysokosc => (ElementWysokosc + 1)* (ustawienia.IloscOsob + 2) + ramkaOknaWysokosc;

        public double OknoMaksymalnaSzerokosc => (ElementSzerokosc + 1) * (ustawienia.IloscOsob + 2) + ramkaOknaSzerokosc;

        public int CzcionkaRozmiar => (ElementWysokosc - 1) / 2;

        private double ramkaOknaSzerokosc = SystemParameters.WindowNonClientFrameThickness.Left + SystemParameters.WindowNonClientFrameThickness.Right;

        private double ramkaOknaWysokosc = SystemParameters.WindowNonClientFrameThickness.Top + SystemParameters.WindowNonClientFrameThickness.Bottom;

        private readonly IFabrykaModelWidoku fabrykaModelWidoku;

        private readonly IUstawienia ustawienia;

        public IObliczKomenda ObliczKomenda { get; private set; }

        private IModelUaktualniacz uaktualniacz;
    }
}
