using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.ObliczaczTabeliNaleznosci
{
    /// <summary>
    /// Obliczacza tabeli nalezcnosci pienieznych.
    /// </summary>
    internal class TabelaNaleznosciPienieznychObliczacz : ITabelaNaleznosciPienieznychObliczacz
    {
        private readonly IFabrykaDlaTabelaNaleznosciPienieznychObliczacz fabryka;

        private readonly ITablicaOsobPienieznaKoncowaPrefabrykator tablicaOsobKoncowaPrefabrykator;

        public TabelaNaleznosciPienieznychObliczacz(IFabrykaDlaTabelaNaleznosciPienieznychObliczacz fabryka)
        {
            this.fabryka = fabryka;

            tablicaOsobKoncowaPrefabrykator = fabryka.StworzTablicaOsobPienieznaKoncowaPrefabrykator();
        }

        public ITabelaNaleznosciPienieznejZwrotna ObliczNaleznosci(ITablicaOsobPienieznych tablicaOsob)
        {
            INajlepszaWymianaNalezosciPienieznejZnajdywacz znajdywacz =
                fabryka.StworzNajlepszaWymianaNalezosciPienieznejZnajdywacz(tablicaOsobKoncowaPrefabrykator.StworzTablicaKoncowa(tablicaOsob));

            return znajdywacz.Znajdz(tablicaOsob);
        }
    }
}