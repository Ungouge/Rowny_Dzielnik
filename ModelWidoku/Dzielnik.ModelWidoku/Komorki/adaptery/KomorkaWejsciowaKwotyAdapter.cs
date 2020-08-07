using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adapter komorki zawierajacej wlasciwosc z modyfikowalnym tekstem naleznosci.
    /// </summary>
    internal class KomorkaWejsciowaKwotyAdapter : KomorkaZKolorowymTlemTekstuBaza, IKomorkaWejsciowaKwoty
    {
        IKomorkaWejsciowaKwoty komorkaAdaptowana;

        /// <summary>
        /// Stworz adapter komorki kwoty wejsciowej.
        /// </summary>
        internal KomorkaWejsciowaKwotyAdapter(IKomorkaWejsciowaKwoty komorkaWejsciowaKwotyAdaptowalna) : base(komorkaWejsciowaKwotyAdaptowalna)
        {
            komorkaAdaptowana = komorkaWejsciowaKwotyAdaptowalna;
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
