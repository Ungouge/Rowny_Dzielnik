using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaDolnotrojkatnaKwotyNaleznej_Mock
    {
        public static IKomorkaDolnotrojkatnaKwotyNaleznej Stworz_Mock()
        {
            return GetKomorkaDolnotrojkatnaKwotyNaleznej_Mock().Object;
        }
        
        private static Mock<IKomorkaDolnotrojkatnaKwotyNaleznej> GetKomorkaDolnotrojkatnaKwotyNaleznej_Mock()
        {
            return new Mock<IKomorkaDolnotrojkatnaKwotyNaleznej>();
        }
    }
}