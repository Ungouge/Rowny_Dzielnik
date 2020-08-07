using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    internal static class Stworz_KomorkaImieniaINaleznosciWejscowej_Mock
    {
        internal static IKomorkaImieniaINaleznosciWejscowej Stworz_Mock()
        {
            return Stworz_MockWlasciwy().Object;
        }

        internal static IKomorkaImieniaINaleznosciWejscowej Stworz_WezOsoba_Mock(IOsobaTypSwiadczenia osoba)
        {
            Mock<IKomorkaImieniaINaleznosciWejscowej> komorka_Mock = Stworz_MockWlasciwy();

            komorka_Mock.
                Setup(komorka => komorka.WezOsoba(It.IsAny<IKonwerterKomorkaNaOsobaWizytator>())).
                Returns(osoba).
                Verifiable();

            return komorka_Mock.Object;
        }

        private static Mock<IKomorkaImieniaINaleznosciWejscowej> Stworz_MockWlasciwy()
        {
            return new Mock<IKomorkaImieniaINaleznosciWejscowej>();
        }
    }
}
