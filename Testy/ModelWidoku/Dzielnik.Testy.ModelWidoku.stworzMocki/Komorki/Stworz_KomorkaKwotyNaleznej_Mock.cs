using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    internal static class Stworz_KomorkaKwotyNaleznej_Mock
    {
        internal static IKomorkaKwotyNaleznej Stworz_Mock()
        {
            return Stworz_MockWlasciwy().Object;
        }

        internal static IKomorkaKwotyNaleznej Stworz_UstalNaleznosc_WeryfikowalnyMock(IPolozenieWTabeliNaleznosci polozenia, TabelaZNaleznoscia_ObslugaSlownika obslugaListyKomorek)
        {
            Mock<IKomorkaKwotyNaleznej> komorka_Mock = Stworz_MockWlasciwy();

            komorka_Mock.
                Setup(komorka => komorka.UstalNaleznosc(It.IsAny<INaleznoscSwiadczenieBaza>()))
                .Callback((INaleznoscSwiadczenieBaza naleznosc) => obslugaListyKomorek.NaleznoscZeSlwonika(polozenia));

            return komorka_Mock.Object;
        }

        private static Mock<IKomorkaKwotyNaleznej> Stworz_MockWlasciwy()
        {
            return new Mock<IKomorkaKwotyNaleznej>();
        }
    }
}
