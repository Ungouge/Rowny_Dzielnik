using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.ModelWidoku.Fabryki
{
    partial class FabrykaModelWidoku
    {
        private readonly IFabrykaOsobaPieniezna fabrykaOsobaPieniezna;

        private readonly IFabrykaNaleznoscPieniezna fabrykaNaleznoscPieniezna;

        private readonly IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa;

        private readonly IFabrykaTablicaOsobPienieznych fabrykaTablicaOsobPienieznych;

        private readonly IFabrykaPolozeniaWTabeliNaleznosci fabrykaPolozeniaWTabeliNaleznosci;

        private IModelUaktualniacz uaktualniaczModelu;

        private ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik;
    }
}