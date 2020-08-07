using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaDolnotrojkatnaKwotyNaleznej_Mock
    {
        public static Mock<IKomorkaDolnotrojkatnaKwotyNaleznej> Stworz_Pola_WeryfikowalnyMock(byte kolumna, byte rzad, string tekst)
        {
            Mock<IKomorkaDolnotrojkatnaKwotyNaleznej> komorkaDolnotrojkatnaKwotyNaleznej_Mock = GetKomorkaDolnotrojkatnaKwotyNaleznej_Mock();

            komorkaDolnotrojkatnaKwotyNaleznej_Mock.
                Setup(komorka => komorka.Kolumna).
                Returns(kolumna).
                Verifiable();

            komorkaDolnotrojkatnaKwotyNaleznej_Mock.
                Setup(komorka => komorka.Rzad).
                Returns(kolumna).
                Verifiable();

            komorkaDolnotrojkatnaKwotyNaleznej_Mock.
                Setup(komorka => komorka.Tekst).
                Returns(tekst).
                Verifiable();

            komorkaDolnotrojkatnaKwotyNaleznej_Mock.
                SetupAdd(UstawieaniaAtrapZTekstemWyrazenia<IKomorkaDolnotrojkatnaKwotyNaleznej>.DodawanieObslugiZmianyUstaw);

            return komorkaDolnotrojkatnaKwotyNaleznej_Mock;
        }
    }
}