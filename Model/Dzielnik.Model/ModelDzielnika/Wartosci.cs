using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Zasoby.Zdarzenia;

namespace Dzielnik.Model
{
    partial class ModelDzielnika
    {
        public event ObliczonaTabelaNaleznosci_ObslugaZdarzenia ObliczonaTabelNaleznocsci;
        
        private IObliczaczTabeliNaleznosciProkurent obliczaczTabeliNaleznosci;

        private bool czyModelZostalUaktualniony = true;
    }
}