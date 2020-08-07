using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Abstrakcyjna klasa bazowa dla komorek zawierajacych wlasciwosc z tekstem.
    /// </summary>
    internal abstract class KomorkaZTekstemBaza : KomorkaZmiennaBaza, IKomorkaZTekstem
    {
        /// <summary>
        /// Stworz KomorkaZTekstemBaza.
        /// </summary>
        public KomorkaZTekstemBaza() : base() { }

        /// <summary>
        /// Stworz KomorkaZTekstemBaza z wywolywaniem zmiany wlasciwosci przez podana komorke adaptowalna.
        /// </summary>
        public KomorkaZTekstemBaza(IKomorkaZTekstem komorkaAdaptowalna) : base(komorkaAdaptowalna) { }

        // wartosc zwracana w przypadku zlej implementacji interfejsow pochodnych
        public virtual string Tekst => default(string);
    }
}
