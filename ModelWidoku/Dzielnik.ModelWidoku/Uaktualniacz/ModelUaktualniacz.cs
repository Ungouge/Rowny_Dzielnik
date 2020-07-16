using Dzielnik.Model.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.ModelWidoku.Uaktualniacz
{
    /// <summary>
    /// Uaktualniacz przenaczony dla uaktualniania modelu.
    /// </summary>
    internal class ModelUaktualniacz : IModelUaktualniacz
    {
        private readonly IModelDzielnikaDlaUaktualniaczModelu model;

        /// <summary>
        /// Stworz ukatalniacz przeslanego modelu.
        /// </summary>
        public ModelUaktualniacz(IModelDzielnikaDlaUaktualniaczModelu model)
        {
            this.model = model;
        }
        
        public void Uaktualnij(ITablicaOsobBaza tablicaOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            model.Uaktualnij(tablicaOsob, kryteriumWyboruTabeliNaleznosci);
        }
    }
}