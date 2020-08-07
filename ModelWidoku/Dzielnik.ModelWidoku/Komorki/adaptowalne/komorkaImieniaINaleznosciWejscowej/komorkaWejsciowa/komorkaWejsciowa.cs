using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej : IKomorkaZWejsciemTekstu
    {
        byte IKomorkaZWejsciemTekstu.Rzad
        {
            get
            {
                return (byte)( indeks + 1);
            }
        }
    }
}