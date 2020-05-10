using Dzielnik.Model.Fabryki;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Fabryki;

namespace Dzielnik.Testy.Model.TabeleNaleznosci
{
    public static class Stworz_TabelaNaleznosciPienieznejNull
    {
        private static readonly IFabrykaTabelaNalezosciPienieznejNull fabrykaTabelaNalezosciPienieznejNull = new FabrykaTabelaNalezosciPienieznejNull(
            new FabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull(),
            new AbstrakcyjnaFabrykaNaleznosciPienieznejDlaTabeliNaleznosci(
                new FabrykaNaleznoscPienieznaDiagonalna(), new FabrykaNaleznoscPienieznaZerowa()));

        internal static ITabelaNaleznosciPienieznej Stworz(byte iloscOsob = 4)
        {
            return fabrykaTabelaNalezosciPienieznejNull.StworzTabelaNaleznosciPienieznejNull(iloscOsob);
        }
    }
}
