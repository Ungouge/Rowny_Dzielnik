using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model.Fabryki
{
    partial class FabrykaModelu
    {
        public ITabelaNaleznosciPienieznej StworzStartowaTabelaNaleznosciPienieznej(byte iloscOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            return fabrykaTabelaNalezosciPienieznej.StworzTabelaNaleznosci(iloscOsob, kryteriumWyboruTabeliNaleznosci);
        }
    }
}