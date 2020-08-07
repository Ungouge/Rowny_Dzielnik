using System;
using System.Globalization;
using System.Windows.Data;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Widok.Konwertery
{
    internal class KryteriumWyboruNaStringKonwerter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboru )
            {
                switch (kryteriumWyboru)    
                {
                    case KryteriumWyboruTabeliNaleznosciWylicznik.KryteriumSumyWymienionejNaleznosci:
                        return "Suma wymienionej naleznosci";
                    case KryteriumWyboruTabeliNaleznosciWylicznik.IlosciWymian:
                        return "Ilosc wymian";
                    default:
                        return kryteriumWyboru.ToString();
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
