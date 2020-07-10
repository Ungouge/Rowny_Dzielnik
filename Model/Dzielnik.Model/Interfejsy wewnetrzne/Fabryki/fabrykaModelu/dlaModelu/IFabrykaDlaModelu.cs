
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryki do tworzenia potrzebnych obiektow dla ModelDzielnika.
    /// </summary>
    interface IFabrykaDlaModelu
    {
        /// <summary>
        /// Stworz instancje ObliczaczTabeliNaleznosciProkurent.
        /// </summary>
        IObliczaczTabeliNaleznosciProkurent StworzObliczaczTabeliNaleznosciProkurent();
    }
}