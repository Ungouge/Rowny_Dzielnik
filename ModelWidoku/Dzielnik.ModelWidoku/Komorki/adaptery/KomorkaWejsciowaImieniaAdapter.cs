using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adapter komorki zawierajacej wlasciwosc z modyfikowalnym tekstem imienia.
    /// </summary>
    internal class KomorkaWejsciowaImieniaAdapter : KomorkaZKolorowymTlemTekstuBaza, IKomorkaWejsciowaImienia
    {
        IKomorkaWejsciowaImienia komorkaAdaptowana;

        /// <summary>
        /// Stworz adapter komorki wejsciowej imienia.
        /// </summary>
        internal KomorkaWejsciowaImieniaAdapter(IKomorkaWejsciowaImienia komorkaWejsciowaImieniaAdaptowalna) : base(komorkaWejsciowaImieniaAdaptowalna)
        {
            komorkaAdaptowana = komorkaWejsciowaImieniaAdaptowalna;
        }

        public override byte Kolumna => komorkaAdaptowana.Kolumna;

        public override byte Rzad => komorkaAdaptowana.Rzad;

        public new string Tekst
        {
            get => komorkaAdaptowana.Tekst;
            set => komorkaAdaptowana.Tekst = value;
        }

        public override Brush KolorTla => komorkaAdaptowana.KolorTla;
    }
}