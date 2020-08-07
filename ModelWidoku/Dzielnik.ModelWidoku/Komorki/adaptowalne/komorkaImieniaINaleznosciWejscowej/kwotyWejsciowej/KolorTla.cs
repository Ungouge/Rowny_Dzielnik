using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej
    {
        Brush IKomorkaWejsciowaKwoty.KolorTla
        {
            get
            {
                if (CzyKomorkaCzytelna == false)
                    return Brushes.Red;

                return Brushes.Transparent;
            }
        }
    }
}