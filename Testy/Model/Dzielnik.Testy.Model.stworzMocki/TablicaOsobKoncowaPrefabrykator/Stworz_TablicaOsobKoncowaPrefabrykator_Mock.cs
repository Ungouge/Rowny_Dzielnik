using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;

using Moq;

namespace Dzielnik.Testy.Model.TablicaOsobKoncowaPrefabrykator
{
    public static class Stworz_TablicaOsobKoncowaPrefabrykator_Mock
    {
        internal static Mock<ITablicaOsobPienieznaKoncowaPrefabrykator> Stworz_Weryfikator_Mock()
        {
            Mock<ITablicaOsobPienieznaKoncowaPrefabrykator> prefabrykator_Mock = new Mock<ITablicaOsobPienieznaKoncowaPrefabrykator>();

            prefabrykator_Mock.Setup(prefabrykator => prefabrykator.StworzTablicaKoncowa(It.IsAny<ITablicaOsobPienieznych>())).Verifiable();

            return prefabrykator_Mock;
        }
    }
}
