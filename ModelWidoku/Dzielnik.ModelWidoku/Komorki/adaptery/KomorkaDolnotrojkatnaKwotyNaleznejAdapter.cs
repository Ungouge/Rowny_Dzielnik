using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adapter komorki zawierajacej wlasciwosc z tekstem naleznosci znajdujacej sie w dolnym trojkacie tabeli naleznosci.
    /// </summary>
    internal class KomorkaDolnotrojkatnaKwotyNaleznejAdapter : KomorkaZTekstemBaza, IKomorkaDolnotrojkatnaKwotyNaleznej
    {
        private readonly IKomorkaDolnotrojkatnaKwotyNaleznej komorkaAdaptowana;

        /// <summary>
        /// Stworz adapter komorki dolnotrojkatnej kwoty naleznosci.
        /// </summary>
        internal KomorkaDolnotrojkatnaKwotyNaleznejAdapter(IKomorkaDolnotrojkatnaKwotyNaleznej komorkaDolnotrojkatnaKwotyNaleznejAdaptowalna) :
            base(komorkaDolnotrojkatnaKwotyNaleznejAdaptowalna)
        {
            komorkaAdaptowana = komorkaDolnotrojkatnaKwotyNaleznejAdaptowalna;
        }

        public override byte Kolumna => komorkaAdaptowana.Kolumna;

        public override byte Rzad => komorkaAdaptowana.Rzad;

        public override string Tekst => komorkaAdaptowana.Tekst;
    }
}