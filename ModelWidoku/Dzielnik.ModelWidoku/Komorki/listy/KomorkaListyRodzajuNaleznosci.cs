using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Komorka z polem wyboru rodzaju naleznosci.
    /// </summary>
    internal class KomorkaListyRodzajuNaleznosci : IKomorkaListyRodzajuNaleznosci
    {
        public byte Rzad => 0;

        public byte Kolumna => 1;
    }
}