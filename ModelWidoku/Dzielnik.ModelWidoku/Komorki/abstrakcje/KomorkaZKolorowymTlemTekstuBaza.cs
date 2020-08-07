using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Abstrakcyjna klasa bazowa dla komorek zawierajacych wlasciwosc tekstu z kolorowym tlem.
    /// </summary>
    internal abstract class KomorkaZKolorowymTlemTekstuBaza : KomorkaZTekstemBaza, IKomorkaZKolorowymTlemTekstu
    {
        /// <summary>
        /// Stworz KomorkaZKolorowymTlemTekstuBaza.
        /// </summary>
        internal KomorkaZKolorowymTlemTekstuBaza() : base() { }

        /// <summary>
        /// Stworz KomorkaZKolorowymTlemTekstuBaza z wywolywaniem zmiany wlasciwosci przez podana komorke adaptowalna.
        /// </summary>
        internal KomorkaZKolorowymTlemTekstuBaza(IKomorkaZKolorowymTlemTekstu komorkaAdaptowalna) : base(komorkaAdaptowalna) { }

        // wartosc zwracana w przypadku zlej implementacji interfejsow pochodnych
        public virtual Brush KolorTla => Brushes.Transparent;
    }
}