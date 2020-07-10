using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Model.Interfejsy.Inicjalizator
{
    /// <summary>
    /// Interfejs inicjalizatora fabryki modelu.
    /// </summary>
    public interface IInicjaliztorDlaFabrykaModelu :IInicjalizatorFabrykaNaleznosci, IInicjalizatorFabrykaTablicaOsob
    {
        IFabrykaPolozeniaWTabeliNaleznosci FabrykaPolozeniaWTabeliNaleznosci { get; }
    }
}