using Dzielnik.Model.Interfejsy;
using Dzielnik.Model.Interfejsy.Fabryki;

namespace Dzielnik.Testy.Model.ModelDzielnika
{
    internal static class Stworz_ModelDzielnika
    {
        internal static IModelDzielnika Stworz(IFabrykaModelu fabrykaModelu)
        {
            return new Dzielnik.Model.ModelDzielnika(fabrykaModelu);
        }
    }
}
