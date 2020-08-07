using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Inicjalizator.Interfejsy
{
    public interface IInicjalizatorFabrykaOsob
    {
        IFabrykaOsobaPieniezna FabrykaOsobaPieniezna { get; }
    }
}