using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

using Moq;

namespace Dzielnik.Testy.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz
{
    public static class Stworz_FabrykaNaleznoscPienieznaZerowa_Mock
    {
        public static IFabrykaNaleznoscPienieznaZerowa Stworz()
        {
            Mock<IFabrykaNaleznoscPienieznaZerowa> fabryka_Mock = new Mock<IFabrykaNaleznoscPienieznaZerowa>
            {
                CallBase = true
            };

            fabryka_Mock.Setup
            (
                fabryka => fabryka.StworzNaleznoscZerowa()).
                Returns(() => Stworz_NaleznoscPienieznaZerowa.Stworz()
            );

            return fabryka_Mock.Object;
        }
    }
}