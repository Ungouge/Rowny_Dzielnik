using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaGornotrojkatnaKwotyNaleznej_Mock
    {
        public static IKomorkaGornotrojkatnaKwotyNaleznej Stworz_Mock()
        {
            return GetKomorkaGornotrojkatnaKwotyNaleznej_Mock().Object;
        }

        private static Mock<IKomorkaGornotrojkatnaKwotyNaleznej> GetKomorkaGornotrojkatnaKwotyNaleznej_Mock()
        {
            return new Mock<IKomorkaGornotrojkatnaKwotyNaleznej>();
        }
    }
}