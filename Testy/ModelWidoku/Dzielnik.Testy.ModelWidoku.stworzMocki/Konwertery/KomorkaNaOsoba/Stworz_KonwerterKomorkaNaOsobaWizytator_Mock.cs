using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.KomorkaNaOsoba
{
    internal static class Stworz_KonwerterKomorkaNaOsobaWizytator_Mock
    {
        internal static IKonwerterKomorkaNaOsobaWizytator Stworz_StworzOsoba_Mock(IOsobaTypSwiadczenia osoba)
        {
            Mock<IKonwerterKomorkaNaOsobaWizytator> wizytator_Mock = Stworz_MockWlasciwy();

            wizytator_Mock.
                Setup(wizytator => wizytator.StworzOsoba(It.IsAny<byte>(), It.IsAny<INaleznoscSwiadczenieBaza>())).
                Returns(osoba);

            return wizytator_Mock.Object;
        }

        public static IKonwerterKomorkaNaOsobaWizytator Stworz_Mock()
        {
            return Stworz_MockWlasciwy().Object;
        }

        private static Mock<IKonwerterKomorkaNaOsobaWizytator> Stworz_MockWlasciwy()
        {
            return new Mock<IKonwerterKomorkaNaOsobaWizytator>();
        }
    }
}