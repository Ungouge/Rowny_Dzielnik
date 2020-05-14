using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.NajlepszaWymianaZnajdywacz
{
    /// <summary>
    /// Znajdywacza najlepszej wymiany naleznosci pienieznej.
    /// </summary>
    internal partial class NajlepszaWymianaNalezosciPienieznejZnajdywacz : INajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        private readonly IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz fabryka;

        private readonly INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz najwiekszaMozliwaNaleznoscDoWymianyUstalacz;

        private readonly IRozniceDoStanuKwitaNaleznosciPienieznychSumator rozniceDoStanuKwitaSumator;

        internal NajlepszaWymianaNalezosciPienieznejZnajdywacz(IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz fabryka,
            ITablicaOsobPienieznych tablicaOsobKoncowa)
        {
            this.fabryka = fabryka;

            najwiekszaMozliwaNaleznoscDoWymianyUstalacz = this.fabryka.StworzNajwiekszaMozliwaNaleznoscDoWymianyUstalacz(tablicaOsobKoncowa);

            rozniceDoStanuKwitaSumator = this.fabryka.StworzRozniceDoStanuKwitaNaleznosciPienieznychSumator(tablicaOsobKoncowa);
        }
    }
}