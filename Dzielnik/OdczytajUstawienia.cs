using Dzielnik.Inicjalizator;
using Dzielnik.Properties;
using System.Configuration;
using System.Windows;
using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik
{
    partial class Dzielnik : Application
    {
        private const KryteriumWyboruTabeliNaleznosciWylicznik KRYTERIUM_WYBORU_TABELI_NALEZNOSCI_DOMYSLNA_WARTOSC =
            default(KryteriumWyboruTabeliNaleznosciWylicznik);

        private const byte ILOSC_OSOB_DOMYSLNA_WARTOSC = 4;

        private const RodzajNaleznosciWylicznik RODZAJ_NALEZNOSCI_DOMYSLNA_WARTOSC =
            default(RodzajNaleznosciWylicznik);
        
        private static IUstawienia OdczytajUstawienia
        {
            get
            {
                ApplicationSettingsBase ustawienia = Settings.Default;

                return new Ustawienia
                (
                    ustawienia["KryteriumWyboru"] is KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci ?
                    kryteriumWyboruTabeliNaleznosci : KRYTERIUM_WYBORU_TABELI_NALEZNOSCI_DOMYSLNA_WARTOSC,

                    ustawienia["RodzajNaleznosci"] is RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik ?
                    rodzajNaleznosciWylicznik : RODZAJ_NALEZNOSCI_DOMYSLNA_WARTOSC,

                    ustawienia["IloscOsob"] is byte iloscOsob ? iloscOsob : ILOSC_OSOB_DOMYSLNA_WARTOSC

                );
            }
        }
    }
}
