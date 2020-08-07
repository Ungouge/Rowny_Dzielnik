using System;
using System.Globalization;
using System.Windows.Data;

using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.Widok.Konwertery
{
    internal class RodzajNaleznosciNaStringKonwerter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is RodzajNaleznosciWylicznik rodzajNaleznosci )
            {
                switch (rodzajNaleznosci)    
                {
                    case RodzajNaleznosciWylicznik.NaleznoscPieniezna:
                        return "Naleznosc pieniezna";
                    default:
                        return rodzajNaleznosci.ToString();
                }
            }

            return String.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
