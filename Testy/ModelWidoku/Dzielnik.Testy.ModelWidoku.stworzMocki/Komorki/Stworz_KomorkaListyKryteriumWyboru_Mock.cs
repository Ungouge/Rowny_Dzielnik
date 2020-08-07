using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaListyKryteriumWyboru_Mock
    {
        public static IKomorkaListyKryteriumWyboru Stworz_Mock()
        {
            return new Mock<IKomorkaListyKryteriumWyboru>().Object;
        }
    }
}
