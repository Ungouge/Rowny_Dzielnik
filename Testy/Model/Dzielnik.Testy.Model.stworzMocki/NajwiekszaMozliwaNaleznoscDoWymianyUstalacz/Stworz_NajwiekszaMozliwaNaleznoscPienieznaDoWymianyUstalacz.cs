using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Testy.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz
{
    internal static class Stworz_NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz
    {
        private static readonly IFabrykaNaleznoscPienieznaZerowa fabryka = Stworz_FabrykaNaleznoscPienieznaZerowa_Mock.Stworz();

        public static INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz Stworz(ITablicaOsobPienieznychZwrotna tablicaOsobPoczatkowa)
        {
            return new NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz(fabryka, tablicaOsobPoczatkowa);
        }
    }
}