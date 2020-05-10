using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    /// <summary>
    /// Dwuwymiarowa tabela zawierajacych naleznosci pienieznej osobom względem siebie.
    /// </summary>
    internal partial class TabelaNaleznosciPienieznej : TabelaNaleznosciPienieznejBaza, ITabelaNaleznosciPienieznej
    {
        public IKryteriumWyboruTabeliNaleznosciPienieznej KryteriumWyboruTabeliNaleznosci { get; private set; }

        private readonly INaleznoscPieniezna[][] tabelaKomorekNaleznosci;

        public TabelaNaleznosciPienieznej(byte iloscOsob,
            IKryteriumWyboruTabeliNaleznosciPienieznej kryteriumWyboruTabeliNaleznosci,
            IAbstrakcyjnaFabrykaNaleznosciPienieznaDlaTabeliNaleznosci abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci):
            base(iloscOsob, abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci)
        {
            this.KryteriumWyboruTabeliNaleznosci = kryteriumWyboruTabeliNaleznosci;

            tabelaKomorekNaleznosci = new INaleznoscPieniezna[Rozmiar][];

            ZainicjalizujRzedyTabeliNaleznosci();
        }

        private void ZainicjalizujRzedyTabeliNaleznosci()
        {
            for (byte indeks_X = 0; indeks_X < Rozmiar; indeks_X++)
                tabelaKomorekNaleznosci[indeks_X] = new INaleznoscPieniezna[indeks_X];
        }
    }
}