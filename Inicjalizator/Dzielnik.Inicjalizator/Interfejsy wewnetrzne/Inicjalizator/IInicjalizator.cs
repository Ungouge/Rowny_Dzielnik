using Dzielnik.Model.Interfejsy.Inicjalizator;
using Dzielnik.ModelWidoku.Interfejsy.Inicjalizator;

namespace Dzielnik.Inicjalizator.Interfejsy
{
    internal interface IInicjalizator : IInicjalizatorDzielnika, IInicjaliztorDlaModelu, IInicjalizatorDlaFabrykaModelWidoku
    {
    }
}
