using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Model.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Testy.Model.TablicaOsobKoncowaPrefabrykator
{
    public static class Stworz_TablicaOsobPienieznaKoncowaPrefabrykator
    {
        private static readonly IFabrykaTablicaOsobPienieznych fabrykaTablicaOsobPienieznych =
            new FabrykaTablicaOsobPienieznych(new FabrykaOsobaPieniezna());

        private static readonly IFabrykaNaleznoscPieniezna fabrykaNaleznosci = new FabrykaNaleznoscPieniezna();

        internal static ITablicaOsobPienieznaKoncowaPrefabrykator Stworz()
        {
            return new TablicaOsobPienieznaKoncowaPrefabrykator(fabrykaTablicaOsobPienieznych, fabrykaNaleznosci);
        }
    }
}