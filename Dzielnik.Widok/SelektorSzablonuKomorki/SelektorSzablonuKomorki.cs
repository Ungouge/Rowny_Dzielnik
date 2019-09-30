using System.Windows;
using System.Windows.Controls;

using Dzielnik.ModelWidoku;

namespace Dzielnik.Widok.SelektorSzablonuKomorki
{
    class SelektorSzablonuKomorki: DataTemplateSelector
    {
        public DataTemplate SzablonKomorkiWejsciowejImienia { get; set; }
        public DataTemplate SzablonKomorkiKwotyWejsciowej { get; set; }
        public DataTemplate SzablonKomorkiImienia { get; set; }
        public DataTemplate SzablonKomorkiWyjsciowej { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null)
                if (item is IKomorka Komorka)
                    switch (Komorka)
                    {
                        case IKomorkaWejsciowaImienia komorkaWejsciowaImienia:
                            return SzablonKomorkiWejsciowejImienia;
                        case IKomorkaKwotyWejsciowej komorkaKwotyWejsciowej:
                            return SzablonKomorkiKwotyWejsciowej;
                        case IKomorkaImienia komorkaImienia:
                            return SzablonKomorkiImienia;
                        case IKomorkaWyjsciowa komorkaWyjsciowa:
                            return SzablonKomorkiWyjsciowej; 
                    }

            return null;
        }
    }
}
