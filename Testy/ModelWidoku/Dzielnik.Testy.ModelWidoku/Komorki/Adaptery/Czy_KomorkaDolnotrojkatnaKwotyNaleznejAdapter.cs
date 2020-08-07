using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Xunit;
using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptery
{
    public class Czy_KomorkaDolnotrojkatnaKwotyNaleznejAdapter
    {
        [Fact]
        public void Czy_Adaptuje_Prawidlowo()
        {
            //Ustal
            byte kolumnaZadana = default(byte);

            byte rzadZadany = default(byte);

            string tekstZadany = default(string);

            Mock<IKomorkaDolnotrojkatnaKwotyNaleznej> komorka_Mock = Stworz_KomorkaDolnotrojkatnaKwotyNaleznej_Mock.Stworz_Pola_WeryfikowalnyMock(kolumnaZadana, rzadZadany, tekstZadany);

            IKomorkaDolnotrojkatnaKwotyNaleznej komorkaDolnotrojkatnaKwotyNaleznej = Stworz_KomorkaDolnotrojkatnaKwotyNaleznejAdapter.Stworz(komorka_Mock.Object);

            //Dzialaj i Asercja
            AsertujKomorka.Asertuj(kolumnaZadana, rzadZadany, tekstZadany, komorkaDolnotrojkatnaKwotyNaleznej);

            komorka_Mock.Verify(komorka => komorka.Kolumna, Times.Once);

            komorka_Mock.Verify(komorka => komorka.Rzad, Times.Once);

            komorka_Mock.Verify(komorka => komorka.Tekst, Times.Once);
        }
    }
}
