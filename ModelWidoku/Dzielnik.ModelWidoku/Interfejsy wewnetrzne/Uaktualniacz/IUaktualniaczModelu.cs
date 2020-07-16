using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz
{
    /// <summary>
    /// Interfejs dla uaktualniaczy modelu.
    /// </summary>
    internal interface IModelUaktualniacz
    {
        /// <summary>
        /// Uaktulanij model.
        /// </summary>
        void Uaktualnij(ITablicaOsobBaza tablicaOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci);
    }
}