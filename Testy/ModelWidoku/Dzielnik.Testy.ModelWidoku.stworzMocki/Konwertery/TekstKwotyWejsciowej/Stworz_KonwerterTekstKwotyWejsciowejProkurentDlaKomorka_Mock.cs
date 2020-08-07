using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Zdarzenia;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej
{
    public static class Stworz_KonwerterTekstKwotyWejsciowejProkurentDlaKomorka_Mock
    {
        static readonly System.Linq.Expressions.Expression<System.Func<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka, bool>> _expression =
            prokurent => prokurent.Konwertuj(It.IsAny<string>(), out It.Ref<INaleznoscSwiadczenieBaza>.IsAny);

        static Mock<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka> Prokurent_Mock => new Mock<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka>();

        internal static IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka Stworz_Mock()
        {
            Mock<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka> prokurent_Mock = Prokurent_Mock;

            return prokurent_Mock.Object;
        }

        internal static IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka Stworz_Konwertuj_Mock(bool czyKonwertuje)
        {
            Mock<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka> prokurent_Mock = Prokurent_Mock;

            prokurent_Mock.
                Setup(_expression).
                Returns(czyKonwertuje);

            return prokurent_Mock.Object;
        }

        internal static Mock<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka> Stworz_Konwertuj_WeryfikowalnyMock()
        {
            Mock<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka> prokurent_Mock = Prokurent_Mock;

            prokurent_Mock.
                Setup(_expression).
                Verifiable();

            return prokurent_Mock;
        }

        internal static void Podnies_ZmianaTekstKwotyWejsciowejKonwerter(IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka prokurent)
        {
            Mock.
                Get(prokurent).
                Raise(x => x.ZmianaTekstKwotyWejsciowejKonwerter_ObslugaZdarzenia += null, new ZmianaTekstKwotyWejsciowejKonwerter_ArgumentyZdarzenia());
        }
    }
}