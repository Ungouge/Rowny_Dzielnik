using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    partial class TabelaNaleznosciPienieznejNull
    {
        INaleznoscSwiadczenieBaza ITabelaNaleznosciZwrotna.this[IPolozenieWTabeliNaleznosci polozenieWTabeli] =>
            abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci.StworzNaleznoscPienieznaZwrotna(polozenieWTabeli);
    }
}