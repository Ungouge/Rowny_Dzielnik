using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;
using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptery
{
    public class Czy_KomorkaWyjsciowaImieniaAdapter
    {
        [Fact]
        public void Czy_Adaptuje_Prawidlowo()
        {
            //Ustal
            byte kolumnaZadana = default(byte);

            byte rzadZadany = default(byte);

            string tekstZadany = default(string);

            Mock<IKomorkaWyjsciowaImienia> komorkaAdaptowalna_Mock = Stworz_KomorkaWyjsciowaImienia_Mock.Stworz_Pola_WeryfikowalnyMock(kolumnaZadana, rzadZadany, tekstZadany);

            IKomorkaWyjsciowaImienia komorkaWyjsciowaImienia = Stworz_KomorkaWyjsciowaImieniaAdapter.Stworz(komorkaAdaptowalna_Mock.Object);

            //Dzialaj i Asercja
            AsertujKomorka.Asertuj(kolumnaZadana, rzadZadany, tekstZadany, komorkaWyjsciowaImienia);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Kolumna, Times.Once);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Rzad, Times.Once);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Tekst, Times.Once);
        }
    }
}
