using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;

namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    public static class Stworz_NajlepszaWymianaNalezosciPienieznejZnajdywacz_Mock
    {
        internal static Mock<INajlepszaWymianaNalezosciPienieznejZnajdywacz> Stworz_Weryfikator_Mock()
        {
            Mock<INajlepszaWymianaNalezosciPienieznejZnajdywacz> znajdywacz_Mock = new Mock<INajlepszaWymianaNalezosciPienieznejZnajdywacz>();

            znajdywacz_Mock.Setup(znajdywacz => znajdywacz.Znajdz(It.IsAny<ITablicaOsobPienieznych>())).Verifiable();

            return znajdywacz_Mock;
        }
    }
}