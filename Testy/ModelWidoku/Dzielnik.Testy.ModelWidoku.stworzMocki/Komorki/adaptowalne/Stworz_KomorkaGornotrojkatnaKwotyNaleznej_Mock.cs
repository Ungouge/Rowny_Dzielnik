using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaGornotrojkatnaKwotyNaleznej_Mock
    {
        public static Mock<IKomorkaGornotrojkatnaKwotyNaleznej> Stworz_Pola_WeryfikowalnyMock(byte kolumna, byte rzad, string tekst)
        {
            Mock<IKomorkaGornotrojkatnaKwotyNaleznej> komorkaGornotrojkatnaKwotyNaleznej_Mock = GetKomorkaGornotrojkatnaKwotyNaleznej_Mock();

            komorkaGornotrojkatnaKwotyNaleznej_Mock.
                Setup(komorka => komorka.Kolumna).
                Returns(kolumna).
                Verifiable();

            komorkaGornotrojkatnaKwotyNaleznej_Mock.
                Setup(komorka => komorka.Rzad).
                Returns(kolumna).
                Verifiable();

            komorkaGornotrojkatnaKwotyNaleznej_Mock.
                Setup(komorka => komorka.Tekst).
                Returns(tekst).
                Verifiable();

            komorkaGornotrojkatnaKwotyNaleznej_Mock.
                SetupAdd(UstawieaniaAtrapZTekstemWyrazenia<IKomorkaGornotrojkatnaKwotyNaleznej>.DodawanieObslugiZmianyUstaw);

            return komorkaGornotrojkatnaKwotyNaleznej_Mock;
        }
    }
}