using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Adaptowalna zbiorcza komorka kwoty naleznej.
    /// </summary>
    internal partial class KomorkaKwotyNaleznej: KomorkaZTekstemBaza, IKomorkaKwotyNaleznej
    {
        byte kolumna;

        byte rzad;

        private readonly IKonwerterNaleznoscNaStringProkurent naleznoscNaStringProkurent;

        /// <summary>
        /// Stworz komorke kwoty naleznej.
        /// </summary>
        internal KomorkaKwotyNaleznej(INaleznoscSwiadczenieBaza naleznosc, byte kolumna, byte rzad,
            IKonwerterNaleznoscNaStringProkurent naleznoscNaStringProkurent)
        {
            this.naleznoscNaStringProkurent = naleznoscNaStringProkurent;

            this.kolumna = kolumna;
            
            this.rzad = rzad;

            UstalNaleznosc(naleznosc);
        }
    }
}