using System.Windows;
using System.Windows.Controls;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.Widok.SelektorSzablonuKomorki
{
    class SelektorSzablonuKomorki: DataTemplateSelector
    {
        public DataTemplate SzablonKomorkiImienia { get; set; }
        public DataTemplate SzablonKomorkiListyKryteriumWyboru { get; set; }
        public DataTemplate SzablonKomorkiListyRodzajuNaleznosci { get; set; }
        public DataTemplate SzablonKomorkiNaleznejKwoty { get; set; }
        public DataTemplate SzablonKomorkiPustej { get; set; }
        public DataTemplate SzablonKomorkiWejsciowejImienia { get; set; }
        public DataTemplate SzablonKomorkiWejsciowejKwoty { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null)
                if (item is IKomorka Komorka)
                    switch (Komorka)
                    {
                        case IKomorkaDolnotrojkatnaKwotyNaleznej komorkaDolnotrojkatnaKwotyNaleznej:
                        case IKomorkaGornotrojkatnaKwotyNaleznej komorkaGornotrojkatnaKwotyNaleznej:
                        case IKomorkaDiagonalna komorkaDiagonalna:
                            return SzablonKomorkiNaleznejKwoty;
                        case IKomorkaWejsciowaKwoty komorkaKwotyWejsciowej:
                            return SzablonKomorkiWejsciowejKwoty;
                        case IKomorkaWejsciowaImienia komorkaWejsciowaImienia:
                            return SzablonKomorkiWejsciowejImienia;
                        case IKomorkaWyjsciowaImienia komorkaImienia:
                            return SzablonKomorkiImienia;
                        case IKomorkaListyKryteriumWyboru komorkaListyKryteriumWyboru:
                            return SzablonKomorkiListyKryteriumWyboru;
                        case IKomorkaListyRodzajuNaleznosci komorkaListyRodzajuNaleznosci:
                            return SzablonKomorkiListyRodzajuNaleznosci;
                    }

            return SzablonKomorkiPustej;
        }
    }
}
