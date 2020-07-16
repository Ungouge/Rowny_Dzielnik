using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Moq;

namespace Dzielnik.Testy.ModelWidoku.CzyMoznaObliczac
{
    internal static class Stworz_CzyMoznaObliczacWkaznik_Mock
    {
        internal static ICzyMoznaObliczacWkaznik Stworz_Mock()
        {
            Mock<ICzyMoznaObliczacWkaznik> czyMoznaObliczac_Mock = new Mock<ICzyMoznaObliczacWkaznik>();

            return czyMoznaObliczac_Mock.Object;
        }
    }
}