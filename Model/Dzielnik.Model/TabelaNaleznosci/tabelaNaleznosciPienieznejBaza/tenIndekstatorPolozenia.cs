using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    partial class TabelaNaleznosciPienieznejBaza
    {
        public virtual INaleznoscPienieznaSwiadczenie this[IPolozenieWTabeliNaleznosci polozenieWTabeli]
        {
            get
            {
                return polozenieWTabeli.CzyKoordynatyDiagonalne ?
                    abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci.StworzNaleznoscPienieznaZwrotna(polozenieWTabeli)
                    : abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci.StworzNaleznoscPienieznaZerowa();
            }
        }
    }
}