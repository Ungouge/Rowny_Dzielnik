using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaKwotyNaleznej : IKomorkaDolnotrojkatnaKwotyNaleznej
    {
        private string tekstKomorkiDolnotrojkatnej;

        string IKomorkaDolnotrojkatnaKwotyNaleznej.Tekst
        {
            get
            {
                return tekstKomorkiDolnotrojkatnej;
            }            
        }

        byte IKomorkaDolnotrojkatnaKwotyNaleznej.Kolumna
        {
            get
            {
                return (byte) (rzad + 2);
            }
        }

        byte IKomorkaDolnotrojkatnaKwotyNaleznej.Rzad
        {
            get
            {
                return (byte) (kolumna + 1);
            }
        }
    }
}