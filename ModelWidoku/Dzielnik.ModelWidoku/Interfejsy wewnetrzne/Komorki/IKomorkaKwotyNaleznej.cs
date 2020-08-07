using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla adaptowalnej zbiorczej komorki kwoty naleznosci.
    /// </summary>
    internal interface IKomorkaKwotyNaleznej : IKomorkaGornotrojkatnaKwotyNaleznej, IKomorkaDolnotrojkatnaKwotyNaleznej
    {
        /// <summary>
        /// Ustala naleznosc dla komorki.
        /// </summary>
        void UstalNaleznosc(INaleznoscSwiadczenieBaza nowaNaleznosc);
    }
}
