using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Testy.Model.DoStanuKwitaSumator;
using Dzielnik.Testy.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Testy.Zasoby.TabelaNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;


namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    public static class Stworz_IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz_Mock
    {
        internal static IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz Stworz(byte iloscOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            Mock<IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz> fabryka_Mock =
                new Mock<IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz>
            {
                CallBase = true
            };

            fabryka_Mock.Setup
            (
                fabryka => fabryka.StworzRozniceDoStanuKwitaNaleznosciPienieznychSumator(It.IsAny<ITablicaOsobPienieznychIterowalna>())
            ).Returns
            (
                (ITablicaOsobPienieznychIterowalna tablicaOsobPoczatkowa) =>
                Stworz_RozniceDoStanuKwitaNaleznosciPienieznychSumator.Stworz(tablicaOsobPoczatkowa)
            );

            fabryka_Mock.Setup
            (
                fabryka => fabryka.StworzNajwiekszaMozliwaNaleznoscDoWymianyUstalacz(It.IsAny<ITablicaOsobPienieznych>())
            ).Returns
            (
                (ITablicaOsobPienieznychZwrotna tablicaOsobPoczatkowa) =>
                Stworz_NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz.Stworz(tablicaOsobPoczatkowa)
            );

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