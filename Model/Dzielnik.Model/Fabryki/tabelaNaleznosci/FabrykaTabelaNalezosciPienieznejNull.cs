using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Model.TabelaNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model.Fabryki
{
    /// <summary>
    /// Fabryka do tworzenia TabelaNaleznosciPienieznejNull.
    /// </summary>
    internal class FabrykaTabelaNalezosciPienieznejNull : IFabrykaTabelaNalezosciPienieznejNull
    {
        private readonly IFabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull fabrykaKryteriumWyboruTabeliNaleznosciNull;

        private readonly IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;

        public FabrykaTabelaNalezosciPienieznejNull(IFabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull fabrykaKryteriumWyboruTabeliNaleznosciNull,
            IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci)
        {
            this.fabrykaKryteriumWyboruTabeliNaleznosciNull = fabrykaKryteriumWyboruTabeliNaleznosciNull;

            this.abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci = abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;
        }

        public ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull(byte iloscOsob)
        {
            IKryteriumWyboruTabeliNaleznosciPienieznej kryterium =
                fabrykaKryteriumWyboruTabeliNaleznosciNull.StworzKryteriumWyboruTabeliNaleznosciPienieznychNull();

            return new TabelaNaleznosciPienieznejNull(iloscOsob, abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci, kryterium);
        }
    }
}