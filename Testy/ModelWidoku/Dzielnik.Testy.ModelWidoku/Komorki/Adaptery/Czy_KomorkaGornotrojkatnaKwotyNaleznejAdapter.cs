using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;
using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptery
{
    public class Czy_KomorkaGornotrojkatnaKwotyNaleznejAdapter
    {
        [Fact]
        public void Czy_Adaptuje_Prawidlowo()
        {
            //Ustal
            byte kolumnaZadana = default(byte);

            byte rzadZadany = default(byte);

            string tekstZadany = default(string);

            Mock<IKomorkaGornotrojkatnaKwotyNaleznej> komorkaAdaptowalna_Mock = Stworz_KomorkaGornotrojkatnaKwotyNaleznej_Mock.Stworz_Pola_WeryfikowalnyMock(kolumnaZadana, rzadZadany, tekstZadany);

            IKomorkaGornotrojkatnaKwotyNaleznej komorkaGornotrojkatnaKwotyNaleznej = Stworz_KomorkaGornotrojkatnaKwotyNaleznejAdapter.Stworz(komorkaAdaptowalna_Mock.Object);

            //Dzialaj i Asercja
            AsertujKomorka.Asertuj(kolumnaZadana, rzadZadany, tekstZadany, komorkaGornotrojkatnaKwotyNaleznej);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Kolumna, Times.Once);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Rzad, Times.Once);

            komorkaAdaptowalna_Mock.Verify(komorka => komorka.Tekst, Times.Once);
        }
    }
}
