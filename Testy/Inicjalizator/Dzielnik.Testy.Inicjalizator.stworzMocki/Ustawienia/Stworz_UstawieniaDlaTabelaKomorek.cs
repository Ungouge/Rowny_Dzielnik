using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Zasoby.Wyliczniki;
using Dzielnik.Zasoby.Zdarzenia;

using Moq;

namespace Dzielnik.Testy.Inicjalizator.Ustawienia
{
    public static class Stworz_UstawieniaDlaTabelaKomorek
    {
        public static IUstawieniaDlaTabelaKomorek Stworz(byte iloscOsob, RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik = default(RodzajNaleznosciWylicznik))
        {
            Mock<IUstawieniaDlaTabelaKomorek> ustawienia_Mock = new Mock<IUstawieniaDlaTabelaKomorek>();

            ustawienia_Mock.
                Setup(ustawienia => ustawienia.RodzajNaleznosciWylicznik).
                Returns(rodzajNaleznosciWylicznik);

            ustawienia_Mock.
                Setup(ustawienia => ustawienia.IloscOsob).
                Returns(iloscOsob);
            
            ustawienia_Mock.
                Raise(ustawienia => ustawienia.ZmianaRodzajuNaleznosci_ObslugaZdarzenia += null, ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia.Empty);

            return ustawienia_Mock.Object;
        }
    }
}