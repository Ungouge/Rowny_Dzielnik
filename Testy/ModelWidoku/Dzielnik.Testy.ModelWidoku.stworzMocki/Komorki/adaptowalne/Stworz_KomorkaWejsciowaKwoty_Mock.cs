using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaWejsciowaKwoty_Mock
    {
        public static Mock<IKomorkaWejsciowaKwoty> Stworz_Pola_WeryfikowalnyMock(byte kolumna, byte rzad, string tekst, Brush kolorTla)
        {
            Mock<IKomorkaWejsciowaKwoty> komorkaWejsciowaKwoty_Mock = GetKomorkaWejsciowaKwoty_Mock();

            komorkaWejsciowaKwoty_Mock.
                Setup(komorka => komorka.Kolumna).
                Returns(kolumna).
                Verifiable();

            komorkaWejsciowaKwoty_Mock.
                Setup(komorka => komorka.Rzad).
                Returns(kolumna).
                Verifiable();

            komorkaWejsciowaKwoty_Mock.
                Setup(komorka => komorka.Tekst).
                Returns(tekst).
                Verifiable();

            komorkaWejsciowaKwoty_Mock.
                Setup(komorka => komorka.KolorTla).
                Returns(kolorTla).
                Verifiable();

            komorkaWejsciowaKwoty_Mock.
                SetupAdd(UstawieaniaAtrapZTekstemWyrazenia<IKomorkaWejsciowaKwoty>.DodawanieObslugiZmianyUstaw);

            return komorkaWejsciowaKwoty_Mock;
        }
    }
}