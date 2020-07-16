using Dzielnik.Model.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz;
using Dzielnik.ModelWidoku.Uaktualniacz;

namespace Dzielnik.Testy.ModelWidoku.Uaktualniacz
{
    internal static class Stworz_ModelUaktualniacz
    {
        internal static IModelUaktualniacz Stworz(IModelDzielnikaDlaUaktualniaczModelu model)
        {
            return new ModelUaktualniacz(model);
        }
    }
}
