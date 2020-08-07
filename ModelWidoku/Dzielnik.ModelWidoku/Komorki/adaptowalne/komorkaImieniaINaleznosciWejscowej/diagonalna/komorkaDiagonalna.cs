using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej : IKomorkaDiagonalna
    {
        string IKomorkaDiagonalna.Tekst
        {
            get
            {
                return "—";
            }
        }

        byte IKomorkaDiagonalna.Kolumna
        {
            get
            {
                return (byte)(indeks + 2);
            }
        }

        byte IKomorkaDiagonalna.Rzad
        {
            get
            {
                return (byte)(indeks +1);
            }
        }
    }
}