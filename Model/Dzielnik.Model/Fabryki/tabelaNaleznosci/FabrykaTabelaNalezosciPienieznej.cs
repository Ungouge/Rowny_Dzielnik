using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Model.TabelaNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model.Fabryki
{
    /// <summary>
    /// Fabryka do tworzenia TabelaNaleznosciPienieznej.
    /// </summary>
    internal class FabrykaTabelaNalezosciPienieznej : IFabrykaTabelaNalezosciPienieznej
    {
        private readonly IAbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych fabrykaKryteriumWyboruTabeliNaleznosci;

        private readonly IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;

        public FabrykaTabelaNalezosciPienieznej(IAbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych fabrykaKryteriumWyboruTabeliNaleznosci,
            IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci)
        {
            this.fabrykaKryteriumWyboruTabeliNaleznosci = fabrykaKryteriumWyboruTabeliNaleznosci;

            this.abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci = abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;
        }

        public ITabelaNaleznosciPienieznej StworzTabelaNaleznosci(byte iloscOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            IKryteriumWyboruTabeliNaleznosciPienieznej kryterium =
                fabrykaKryteriumWyboruTabeliNaleznosci.StworzKryteriumWyboruTabeliNaleznosci(kryteriumWyboruTabeliNaleznosci);

            return new TabelaNaleznosciPienieznej(iloscOsob, kryterium, abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci);
        }
    }
}
