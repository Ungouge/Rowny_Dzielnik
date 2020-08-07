using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    /// <summary>
    /// Komorka nie posiadajacej zadnej zawrtosci.
    /// </summary>
    internal class KomorkaPusta : IKomorkaPusta
    {
        public byte Rzad
        {
            get
            {
                return 0;
            }
        }

        public byte Kolumna
        {
            get
            {
                return 1;
            }
        }
    }
}