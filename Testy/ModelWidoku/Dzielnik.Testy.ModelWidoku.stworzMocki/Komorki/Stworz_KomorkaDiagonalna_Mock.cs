using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaDiagonalna_Mock
    {
        public static IKomorkaDiagonalna Stworz_Mock()
        {
            return GetKomorkaDiagonalna_Mock().Object;
        }

        private static Mock<IKomorkaDiagonalna> GetKomorkaDiagonalna_Mock()
        {
            return new Mock<IKomorkaDiagonalna>();
        }
    }
}