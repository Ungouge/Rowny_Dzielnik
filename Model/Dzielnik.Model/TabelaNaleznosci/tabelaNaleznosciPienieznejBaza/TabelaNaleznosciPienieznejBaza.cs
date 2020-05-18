using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model.TabelaNaleznosci
{
    /// <summary>
    /// abstrakcyjna 
    /// </summary>
    internal abstract partial class TabelaNaleznosciPienieznejBaza
    {
        protected readonly IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;
        
        public byte Rozmiar { get; }
        
        protected TabelaNaleznosciPienieznejBaza(byte iloscOsob, 
            IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci)
        {
            Rozmiar = iloscOsob;

            this.abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci = abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;
        }
    }
}