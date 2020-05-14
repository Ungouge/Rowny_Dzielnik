using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.NajlepszaWymianaZnajdywacz;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    public static class Stworz_NajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        internal static INajlepszaWymianaNalezosciPienieznejZnajdywacz Stworz(ITablicaOsobPienieznych tablicaOsobKoncowa,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci = default(KryteriumWyboruTabeliNaleznosciWylicznik))
        {
            IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz fabryka =
                Stworz_IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz_Mock.Stworz(tablicaOsobKoncowa.WezIloscOsob, kryteriumWyboruTabeliNaleznosci);

            return new NajlepszaWymianaNalezosciPienieznejZnajdywacz(fabryka, tablicaOsobKoncowa);
        }

    }
}