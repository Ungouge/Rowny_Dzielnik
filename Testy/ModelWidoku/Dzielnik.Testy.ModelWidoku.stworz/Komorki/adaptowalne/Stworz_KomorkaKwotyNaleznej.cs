using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Komorki;
using Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString;
using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    internal static class Stworz_KomorkaKwotyNaleznej
    {
        internal static IKomorkaKwotyNaleznej Stworz(byte kolumna, byte rzad, string tekstZwrotny)
        {
            INaleznoscSwiadczenieBaza naleznosc = Stworz_NaleznoscSwiadczenieBaza_Mock.Stworz_Mock();

            IKonwerterNaleznoscNaStringProkurent prokurent = Stworz_KonwerterNaleznoscNaStringProkurent_Mock.Stworz_NaString_Mock(tekstZwrotny);

            return new KomorkaKwotyNaleznej(naleznosc, kolumna, rzad, prokurent);
        }

        internal static IKomorkaKwotyNaleznej Stworz(IKonwerterNaleznoscNaStringProkurent prokurent)
        {
            byte kolumna = default(byte);

            byte rzad = default(byte);

            INaleznoscSwiadczenieBaza naleznosc = Stworz_NaleznoscSwiadczenieBaza_Mock.Stworz_Mock();

            return new KomorkaKwotyNaleznej(naleznosc, kolumna, rzad, prokurent);
        }
    }
}