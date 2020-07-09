using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;

namespace Dzielnik.Model.NajlepszaWymianaZnajdywacz
{
    /// <summary>
    /// Znajdywacza najlepszej wymiany naleznosci pienieznej.
    /// </summary>
    internal partial class NajlepszaWymianaNalezosciPienieznejZnajdywacz : INajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        private readonly IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada fabryka;

        private readonly INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz najwiekszaMozliwaNaleznoscDoWymianyUstalacz;

        private readonly IRozniceDoStanuKwitaNaleznosciPienieznychSumator rozniceDoStanuKwitaSumator;

        internal NajlepszaWymianaNalezosciPienieznejZnajdywacz(IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada fabryka,
            INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz najwiekszaMozliwaNaleznoscDoWymianyUstalacz,
            IRozniceDoStanuKwitaNaleznosciPienieznychSumator rozniceDoStanuKwitaSumator)
        {
            this.fabryka = fabryka;

            this.najwiekszaMozliwaNaleznoscDoWymianyUstalacz = najwiekszaMozliwaNaleznoscDoWymianyUstalacz;

            this.rozniceDoStanuKwitaSumator = rozniceDoStanuKwitaSumator;
        }
    }
}