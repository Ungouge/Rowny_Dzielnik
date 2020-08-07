using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej : IKomorkaWyjsciowaImienia
    {
        byte IKomorkaWyjsciowaImienia.Rzad
        {
            get
            {
                return 0;
            }
        }

        byte IKomorkaWyjsciowaImienia.Kolumna
        {
            get
            {
                return (byte)(indeks + 2);
            }
        }
    }
}