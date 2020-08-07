using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaWejsciowaImienia_Mock
    {
        public static Mock<IKomorkaWejsciowaImienia> Stworz_Pola_WeryfikowalnyMock(byte kolumna, byte rzad, string tekst, Brush kolorTla)
        {
            Mock<IKomorkaWejsciowaImienia> komorkaWejsciowaImienia_Mock = GetKomorkaWejsciowaImienia_Mock();

            komorkaWejsciowaImienia_Mock.
                Setup(komorka => komorka.Kolumna).
                Returns(kolumna).
                Verifiable();

            komorkaWejsciowaImienia_Mock.
                Setup(komorka => komorka.Rzad).
                Returns(kolumna).
                Verifiable();

            komorkaWejsciowaImienia_Mock.
                Setup(komorka => komorka.Tekst).
                Returns(tekst).
                Verifiable();

            komorkaWejsciowaImienia_Mock.
                Setup(komorka => komorka.KolorTla).
                Returns(kolorTla).
                Verifiable();

            komorkaWejsciowaImienia_Mock.
                SetupAdd(UstawieaniaAtrapZTekstemWyrazenia<IKomorkaWejsciowaImienia>.DodawanieObslugiZmianyUstaw);

            return komorkaWejsciowaImienia_Mock;
        }
    }
}