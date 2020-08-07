using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;
using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptery
{
    public class Czy_KomorkaWejsciowaImieniaAdapter
    {
        [Fact]
        public void Czy_Adaptuje_Prawidlowo()
        {
            //Ustal
            byte kolumnaZadana = default(byte);

            byte rzadZadany = default(byte);

            string tekstZadany = default(string);

            Brush kolorTlaZadany = default(Brush);

            Mock<IKomorkaWejsciowaImienia> komorkaAdaptowalna_Mock = Stworz_KomorkaWejsciowaImienia_Mock.Stworz_Pola_WeryfikowalnyMock(kolumnaZadana, rzadZadany, tekstZadany, kolorTlaZadany);

            IKomorkaWejsciowaImienia komorkaWejsciowaImienia = Stworz_KomorkaWejsciowaImieniaAdapter.Stworz(komorkaAdaptowalna_Mock.Object);
            
            //Dzialaj i Asercja
            AsertujKomorka.Asertuj(kolumnaZadana, rzadZadany, tekstZadany, kolorTlaZadany, komorkaWejsciowaImienia);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Kolumna, Times.Once);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Rzad, Times.Once);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Tekst, Times.Once);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.KolorTla, Times.Once);
        }
    }
}
