using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Model.Fabryki
{
    partial class FabrykaModelu // wartosci
    {
        private readonly IFabrykaTabelaNalezosciPienieznej fabrykaTabelaNalezosciPienieznej;

        private readonly IFabrykaTabelaNalezosciPienieznejNull fabrykaTabelaNalezosciPienieznejNull;

        private readonly IFabrykaPolozeniaWTabeliNaleznosci fabrykaPolozeniaWTabeliNaleznosci;

        private readonly IFabrykaTablicaOsobPienieznych fabrykaTablicaOsobPienieznych;

        private readonly IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa;

        private readonly IFabrykaNaleznoscPieniezna fabrykaNaleznosci;
    }
}