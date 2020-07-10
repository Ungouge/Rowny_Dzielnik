using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Model.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.TablicaOsobKoncowaPrefabrykator;

namespace Dzielnik.Model.Fabryki
{
    partial class FabrykaModelu
    {
        public ITabelaNaleznosciPienieznychObliczacz StworzObliczaczTabeliNaleznosciPienieznych()
        {
            ITablicaOsobPienieznaKoncowaPrefabrykator prefabrykator = StworzTablicaOsobPienieznaKoncowaPrefabrykator();

            return new TabelaNaleznosciPienieznychObliczacz(this, prefabrykator);
        }

        // Tworzy instancje prefabrykatora tablic osob pienieznych.
        private ITablicaOsobPienieznaKoncowaPrefabrykator StworzTablicaOsobPienieznaKoncowaPrefabrykator()
        {
            return new TablicaOsobPienieznaKoncowaPrefabrykator(fabrykaTablicaOsobPienieznych, fabrykaNaleznosci);
        }
    }
}