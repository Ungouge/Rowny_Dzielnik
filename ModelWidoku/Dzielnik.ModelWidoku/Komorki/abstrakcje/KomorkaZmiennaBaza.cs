using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Abstrakcyjna klasa bazowa dla komorek zawierajacych wlasciwosci ktore moga ulegac zmiania w czasie rzeczywistym.
    /// </summary>
    internal abstract class KomorkaZmiennaBaza: KomorkaBaza, IKomorkaZmienna
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stworz KomorkaZmiennaBaza.
        /// </summary>
        internal KomorkaZmiennaBaza() { }

        /// <summary>
        /// Stworz KomorkaZmiennaBaza z wywolywaniem zmiany wlasciwosci przez podana komorke adaptowalna.
        /// </summary>
        internal KomorkaZmiennaBaza(IKomorkaZmienna komorkaAdaptowalna)
        {
            komorkaAdaptowalna.PropertyChanged += Komorka_WlasciwoscZmieniona;
        }

        protected void NaZmianeWlasciwosci([CallerMemberName] string nazwaWlasciwosci = "")
        {
            Komorka_WlasciwoscZmieniona(new PropertyChangedEventArgs(nazwaWlasciwosci));
        }

        private void Komorka_WlasciwoscZmieniona(PropertyChangedEventArgs e)
        {
            Komorka_WlasciwoscZmieniona(null, e);
        }

        protected void Komorka_WlasciwoscZmieniona(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}