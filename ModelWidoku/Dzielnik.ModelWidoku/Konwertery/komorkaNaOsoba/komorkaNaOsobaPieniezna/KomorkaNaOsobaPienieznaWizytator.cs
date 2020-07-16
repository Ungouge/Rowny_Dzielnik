using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.ModelWidoku.Konwertery
{
    /// <summary>
    /// Wizytator konwertujacy przeslana komorke na odpowiedni typ osoby. 
    /// </summary>
    internal partial class KomorkaNaOsobaPienieznaWizytator : IKonwerterKomorkaNaOsobaWizytator
    {
        private readonly IFabrykaOsobaPieniezna fabrykaOsobaPieniezna;

        public KomorkaNaOsobaPienieznaWizytator(IFabrykaOsobaPieniezna fabrykaOsobaPieniezna)
        {
            this.fabrykaOsobaPieniezna = fabrykaOsobaPieniezna;
        }
    }
}