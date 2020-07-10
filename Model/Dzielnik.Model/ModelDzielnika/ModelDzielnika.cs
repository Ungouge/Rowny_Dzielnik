using Dzielnik.Model.Interfejsy;
using Dzielnik.Model.Interfejsy.Fabryki;

namespace Dzielnik.Model
{
    /// <summary>
    /// Model dzielnika.
    /// </summary>
    internal partial class ModelDzielnika : IModelDzielnika
    {
        /// <summary>
        /// Tworzy instancje ModelDzielnika dla podanej w argumencie fabryki.
        /// </summary>
        internal ModelDzielnika(IFabrykaModelu fabrykaModelu)
        {
            obliczaczTabeliNaleznosci = fabrykaModelu.StworzObliczaczTabeliNaleznosciProkurent();
        }
    }
}