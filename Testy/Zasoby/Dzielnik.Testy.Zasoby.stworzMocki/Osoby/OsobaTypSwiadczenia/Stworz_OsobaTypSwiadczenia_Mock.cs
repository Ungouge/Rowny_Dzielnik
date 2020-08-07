using Dzielnik.Zasoby.Interfejsy.Osoby;

using Moq;

namespace Dzielnik.Testy.Zasoby.Osoby.OsobaTypSwiadczenia
{
    public static class Stworz_OsobaTypSwiadczenia_Mock
    {
        public static IOsobaTypSwiadczenia Stworz_Mock()
        {
            return new Mock<IOsobaTypSwiadczenia>().Object;
        }
    }
}