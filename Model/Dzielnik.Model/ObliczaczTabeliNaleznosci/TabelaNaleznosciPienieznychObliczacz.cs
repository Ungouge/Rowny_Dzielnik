using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model.ObliczaczTabeliNaleznosci
{
    /// <summary>
    /// Obliczacza tabeli nalezcnosci pienieznych.
    /// </summary>
    internal class TabelaNaleznosciPienieznychObliczacz : ITabelaNaleznosciPienieznychObliczacz
    {
        private readonly IFabrykaDlaTabelaNaleznosciPienieznychObliczacz fabryka;

        private readonly ITablicaOsobPienieznaKoncowaPrefabrykator tablicaOsobKoncowaPrefabrykator;

        public TabelaNaleznosciPienieznychObliczacz(IFabrykaDlaTabelaNaleznosciPienieznychObliczacz fabryka, ITablicaOsobPienieznaKoncowaPrefabrykator tablicaOsobKoncowaPrefabrykator)
        {
            this.fabryka = fabryka;

            this.tablicaOsobKoncowaPrefabrykator = tablicaOsobKoncowaPrefabrykator;
        }

        public ITabelaNaleznosciPienieznejZwrotna ObliczNaleznosci(ITablicaOsobPienieznych tablicaOsob,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            ITablicaOsobPienieznych koncowaTablicaOsob = tablicaOsobKoncowaPrefabrykator.StworzTablicaKoncowa(tablicaOsob);

            INajlepszaWymianaNalezosciPienieznejZnajdywacz znajdywacz =
                fabryka.StworzNajlepszaWymianaNalezosciPienieznejZnajdywacz(koncowaTablicaOsob, kryteriumWyboruTabeliNaleznosci);

            return znajdywacz.Znajdz(tablicaOsob);
        }
    }
}