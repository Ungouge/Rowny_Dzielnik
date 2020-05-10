using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Model.TabelaNaleznosci
{
    /// <summary>
    /// abstrakcyjna 
    /// </summary>
    internal abstract partial class TabelaNaleznosciPienieznejBaza
    {
        public byte Rozmiar { get; }

        protected readonly IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;

        protected TabelaNaleznosciPienieznejBaza(byte iloscOsob, 
            IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci)
        {
            Rozmiar = iloscOsob;

            this.abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci = abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci;
        }
    }
}
