using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Model.NajlepszaWymianaZnajdywacz;
using Dzielnik.Testy.Model.DoStanuKwitaSumator;
using Dzielnik.Testy.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Testy.Model.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    public static class Stworz_NajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        internal static INajlepszaWymianaNalezosciPienieznejZnajdywacz Stworz(ITablicaOsobPienieznych poczatkowaTablicaOsob,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci = default(KryteriumWyboruTabeliNaleznosciWylicznik))
        {
            ITablicaOsobPienieznych koncowaTablicaOsob =
                    Stworz_TablicaOsobPienieznaKoncowaPrefabrykator.Stworz().StworzTablicaKoncowa(poczatkowaTablicaOsob);

            IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz fabryka =
                Stworz_IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz_Mock.Stworz(koncowaTablicaOsob.WezIloscOsob, kryteriumWyboruTabeliNaleznosci);

            INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz najwiekszaMozliwaNaleznoscDoWymianyUstalacz =
                Stworz_NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz.Stworz(koncowaTablicaOsob);

            IRozniceDoStanuKwitaNaleznosciPienieznychSumator rozniceDoStanuKwitaSumator =
                Stworz_RozniceDoStanuKwitaNaleznosciPienieznychSumator.Stworz(koncowaTablicaOsob);

            return new NajlepszaWymianaNalezosciPienieznejZnajdywacz(fabryka, najwiekszaMozliwaNaleznoscDoWymianyUstalacz, rozniceDoStanuKwitaSumator);
        }

    }
}