using Dzielnik.Zasoby.Zdarzenia;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika
    {
        private void ModelDzielnika_ObliczonaTabelNaleznocsci(object sender, ObliczonaTabelaNaleznosci_ArgumentZdarzenia e)
        {
            tabelaKomorek.UaktualnijTabelaNaleznocsci(e.TabelaNaleznosciZwrotna);
        }
    }
}