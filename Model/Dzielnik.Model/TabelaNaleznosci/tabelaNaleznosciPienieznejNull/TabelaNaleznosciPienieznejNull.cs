using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model.TabelaNaleznosci
{
    /// <summary>
    /// Dwuwymiarowa tabela zawierajaca naleznosci pieniezne osob względem siebie z zachowaniem pustym.
    /// </summary>
    internal partial class TabelaNaleznosciPienieznejNull : TabelaNaleznosciPienieznejBaza, ITabelaNaleznosciPienieznejNull
    {
        public IKryteriumWyboruTabeliNaleznosciPienieznej KryteriumWyboruTabeliNaleznosci { get; }

        public TabelaNaleznosciPienieznejNull(byte iloscOsob,
            IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci,
            IKryteriumWyboruTabeliNaleznosciPienieznej kryteriumWyboruTabeliNaleznosci) :
            base(iloscOsob, abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci)
        {
            KryteriumWyboruTabeliNaleznosci = kryteriumWyboruTabeliNaleznosci;
        }
    }
}