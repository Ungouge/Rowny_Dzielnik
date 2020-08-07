using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adapter komorki zawierajacych wlasciwosc z tekstem naleznoscia znajdujaca sie na diagonalnej tabeli naleznosci.
    /// </summary>
    internal class KomorkaDiagonalnaAdapter: KomorkaZTekstemBaza, IKomorkaDiagonalna
    {
        IKomorkaDiagonalna komorkaAdaptowana;

        /// <summary>
        /// Stworz adapter komorki diagonalnej.
        /// </summary>
        internal KomorkaDiagonalnaAdapter(IKomorkaDiagonalna komorkaDiagonalnaAdaptowalna) : base(komorkaDiagonalnaAdaptowalna)
        {
            komorkaAdaptowana = komorkaDiagonalnaAdaptowalna;
        }

        public override byte Kolumna => komorkaAdaptowana.Kolumna;

        public override byte Rzad => komorkaAdaptowana.Rzad;

        public override string Tekst => komorkaAdaptowana.Tekst;
    }
}