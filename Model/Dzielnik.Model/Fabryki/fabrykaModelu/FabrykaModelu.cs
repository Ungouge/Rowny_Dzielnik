using Dzielnik.Model.Inicjalizator;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.Inicjalizator;

namespace Dzielnik.Model.Fabryki
{
    internal partial class FabrykaModelu: IFabrykaModelu
    {
        public FabrykaModelu(IInicjaliztorDlaFabrykaModelu inicjalizator)
        {
            fabrykaTabelaNalezosciPienieznej = InicjalizatorModelu.FabrykaTabelaNalezosciPienieznej;

            fabrykaTabelaNalezosciPienieznejNull = InicjalizatorModelu.FabrykaTabelaNalezosciPienieznejNull;

            fabrykaPolozeniaWTabeliNaleznosci = inicjalizator.FabrykaPolozeniaWTabeliNaleznosci;

            fabrykaNaleznosci = inicjalizator.FabrykaNaleznoscPieniezna;

            fabrykaTablicaOsobPienieznych = inicjalizator.FabrykaTablicaOsob;

            fabrykaNaleznoscPienieznaZerowa = inicjalizator.FabrykaNaleznoscPienieznaZerowa;
        }
    }
}