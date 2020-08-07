using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej : IKomorkaWejsciowaImienia
    {
        byte IKomorkaWejsciowaImienia.Kolumna
        {
            get
            {
                return 0;
            }
        }

        string IKomorkaWejsciowaImienia.Tekst
        {
            get
            {
                return Imie;
            }
            set
            {
                if (Imie == value)
                    return;

                Imie = value;

                NaZmianeWlasciwosci();
            }
        }

        Brush IKomorkaWejsciowaImienia.KolorTla => Brushes.Transparent;
    }
}