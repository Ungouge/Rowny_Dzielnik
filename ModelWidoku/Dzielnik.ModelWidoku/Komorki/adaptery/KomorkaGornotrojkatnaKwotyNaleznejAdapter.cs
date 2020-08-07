using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adapter komorki zawierajacej wlasciwosc z tekstem naleznosci znajdujacej sie w gornym trojkacie tabeli naleznosci.
    /// </summary>
    internal class KomorkaGornotrojkatnaKwotyNaleznejAdapter : KomorkaZTekstemBaza, IKomorkaGornotrojkatnaKwotyNaleznej
    {
        private readonly IKomorkaGornotrojkatnaKwotyNaleznej komorkaAdaptowana;

        /// <summary>
        /// Stworz adapter gornotrojkatna kwota naleznosci.
        /// </summary>
        internal KomorkaGornotrojkatnaKwotyNaleznejAdapter(IKomorkaGornotrojkatnaKwotyNaleznej komorkaGornotrojkatnaKwotyNaleznejAdaptowalna) :
            base(komorkaGornotrojkatnaKwotyNaleznejAdaptowalna)
        {
            komorkaAdaptowana = komorkaGornotrojkatnaKwotyNaleznejAdaptowalna;
        }

        public override byte Kolumna => komorkaAdaptowana.Kolumna;

        public override byte Rzad => komorkaAdaptowana.Rzad;

        public override string Tekst => komorkaAdaptowana.Tekst;
    }
}
