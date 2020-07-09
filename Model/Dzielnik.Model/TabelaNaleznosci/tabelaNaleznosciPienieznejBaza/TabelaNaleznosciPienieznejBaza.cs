using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Model.TabelaNaleznosci
{
    /// <summary>
    /// Abstrakcyjna klasa dla dwuwymiarowych tabeli zawierajacych naleznosci pieniezne osob względem siebie.
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