using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy
{
    /// <summary>
    /// Interfejs modelu dzielnika przeznaczony dla uaktualniacz modelu.
    /// </summary>
    public interface IModelDzielnikaDlaUaktualniaczModelu
    {
        /// <summary>
        /// Interfejs modelu dzielnika przeznaczony dla udostępniania publicznych zasobow uaktaulniaczowi modelu.
        /// </summary>
        void Uaktualnij(ITablicaOsobBaza tablicaOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci);
    }
}
