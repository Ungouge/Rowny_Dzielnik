using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaWyjsciowaImienia_Mock
    {
        public static Mock<IKomorkaWyjsciowaImienia> Stworz_Pola_WeryfikowalnyMock(byte kolumna, byte rzad, string tekst)
        {
            Mock<IKomorkaWyjsciowaImienia> komorkaWyjsciowaImienia_Mock = GetKomorkaWyjsciowaImienia_Mock();

            komorkaWyjsciowaImienia_Mock.
                Setup(komorka => komorka.Kolumna).
                Returns(kolumna).
                Verifiable();

            komorkaWyjsciowaImienia_Mock.
                Setup(komorka => komorka.Rzad).
                Returns(kolumna).
                Verifiable();

            komorkaWyjsciowaImienia_Mock.
                Setup(komorka => komorka.Tekst).
                Returns(tekst).
                Verifiable();

            komorkaWyjsciowaImienia_Mock.
                SetupAdd(UstawieaniaAtrapZTekstemWyrazenia<IKomorkaWyjsciowaImienia>.DodawanieObslugiZmianyUstaw);

            return komorkaWyjsciowaImienia_Mock;
        }
    }
}