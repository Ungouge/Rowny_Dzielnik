using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryki do tworzenia potrzebnych obiektow dla ObliczaczTabeliNaleznosciProkurent.
    /// </summary>
    internal interface IFabrykaDlaObliczaczTabeliNaleznosciProkurent
    {
        ITabelaNaleznosciPienieznychObliczacz StworzObliczaczTabeliNaleznosciPienieznych();
    }
}