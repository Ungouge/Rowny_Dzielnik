using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Zasoby.Zdarzenia;
using System;

namespace Dzielnik.Model
{
    partial class ModelDzielnika
    {
        public event EventHandler<ObliczonaTabelaNaleznosci_ArgumentZdarzenia> ObliczonaTabelNaleznocsci;

        private IObliczaczTabeliNaleznosciProkurent obliczaczTabeliNaleznosci;

        private bool czyModelZostalUaktualniony = true;
    }
}