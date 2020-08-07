using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adapter komorki z tekstem imienia.
    /// </summary>
    internal class KomorkaWyjsciowaImieniaAdapter : KomorkaZTekstemBaza, IKomorkaWyjsciowaImienia
    {
        IKomorkaWyjsciowaImienia komorkaAdaptowana;

        /// <summary>
        /// Stworz adapter komorki wyjsciowej imienia.
        /// </summary>
        internal KomorkaWyjsciowaImieniaAdapter(IKomorkaWyjsciowaImienia komorkaWyjsciowaImieniaAdaptowalna) : base(komorkaWyjsciowaImieniaAdaptowalna)
        {
            komorkaAdaptowana = komorkaWyjsciowaImieniaAdaptowalna;
        }

        public override byte Kolumna => komorkaAdaptowana.Kolumna;

        public override byte Rzad => komorkaAdaptowana.Rzad;

        public override string Tekst => komorkaAdaptowana.Tekst;
    }
}
