
namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryki do tworzenia potrzebnych obiektow w Modelu.
    /// </summary>
    interface IFabrykaModelu : IFabrykaDlaObliczaczTabeliNaleznosciProkurent, IFabrykaDlaTabelaNaleznosciObliczacz,
        IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz, IFabrykaDlaModelu
    {
    }
}