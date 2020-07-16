
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.ModelWidoku.Konwertery;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Fabryki;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.KomorkaNaOsoba
{
    internal static class Stworz_KomorkaNaOsobaPienieznaWizytor
    {
        private static readonly IFabrykaOsobaPieniezna fabrykaOsobaPieniezna = new FabrykaOsobaPieniezna();

        internal static IKonwerterKomorkaNaOsobaWizytator Stworz()
        {
            return new KomorkaNaOsobaPienieznaWizytator(fabrykaOsobaPieniezna);
        }
    }
}
