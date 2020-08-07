using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaDiagonalna_Mock
    {
        public static Mock<IKomorkaDiagonalna> Stworz_Pola_WeryfikowalnyMock(byte kolumna, byte rzad, string tekst)
        {
            Mock<IKomorkaDiagonalna> komorkaDiagonalna_Mock = GetKomorkaDiagonalna_Mock();

            komorkaDiagonalna_Mock.
                Setup(komorka => komorka.Kolumna).
                Returns(kolumna).
                Verifiable();

            komorkaDiagonalna_Mock.
                Setup(komorka => komorka.Rzad).
                Returns(kolumna).
                Verifiable();

            komorkaDiagonalna_Mock.
                Setup(komorka => komorka.Tekst).
                Returns(tekst).
                Verifiable();

            komorkaDiagonalna_Mock.
                SetupAdd(UstawieaniaAtrapZTekstemWyrazenia<IKomorkaDiagonalna>.DodawanieObslugiZmianyUstaw);

            return komorkaDiagonalna_Mock;
        }
    }
}