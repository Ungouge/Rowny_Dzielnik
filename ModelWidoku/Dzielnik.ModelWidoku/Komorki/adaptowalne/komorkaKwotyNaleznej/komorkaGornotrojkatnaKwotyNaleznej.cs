using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaKwotyNaleznej : IKomorkaGornotrojkatnaKwotyNaleznej
    {
        private string tekstKomorkiGornotrojkatnej;

        string IKomorkaGornotrojkatnaKwotyNaleznej.Tekst
        {
            get
            {
                return tekstKomorkiGornotrojkatnej;
            }
        }

        byte IKomorkaGornotrojkatnaKwotyNaleznej.Kolumna
        {
            get
            {
                return (byte)(kolumna + 2);
            }
        }

        byte IKomorkaGornotrojkatnaKwotyNaleznej.Rzad
        {
            get
            {
                return (byte)(rzad + 1);
            }
        }
    }
}