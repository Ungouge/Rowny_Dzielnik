using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Testy.Zasoby.TabelaNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

using Moq;


namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    public static class Stworz_IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz_Mock
    {
        internal static IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada Stworz(byte iloscOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            Mock<IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada> fabryka_Mock =
                new Mock<IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada>
            {
                CallBase = true
            };

            fabryka_Mock.Setup
            (
                fabryka => fabryka.StworzStartowaTabelaNaleznosciPienieznej()
            ).Returns
            (
                () => Stworz_TabelaNaleznosciPienieznej.Stworz_Pusty(iloscOsob, kryteriumWyboruTabeliNaleznosci)
            );

            fabryka_Mock.Setup
            (
                fabryka => fabryka.StworzTabelaNaleznosciPienieznejNull()
            ).Returns
            (
                () => Stworz_TabelaNaleznosciPienieznejNull.Stworz(iloscOsob)
            );

            fabryka_Mock.Setup
            (
                fabryka => fabryka.StworzPolozenieWTabeliNaleznosci(It.IsAny<byte>(), It.IsAny<byte>())
            ).Returns
            (
                (byte indeks_X, byte indeks_Y) =>
                Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y)
            );

            return fabryka_Mock.Object;
        }
    }
}