using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Model.NajlepszaWymianaZnajdywacz;
using Dzielnik.Testy.Model.DoStanuKwitaSumator;
using Dzielnik.Testy.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz
{
    internal static class Stworz_NajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        internal static INajlepszaWymianaNalezosciPienieznejZnajdywacz Stworz(ITablicaOsobPienieznych poczatkowaTablicaOsob,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci = default(KryteriumWyboruTabeliNaleznosciWylicznik))
        {
            ITablicaOsobPienieznych koncowaTablicaOsob = TablicaOsobKoncowaPrefabrykator.Stworz_TablicaOsobPienieznaKoncowaPrefabrykator.Stworz().StworzTablicaKoncowa(poczatkowaTablicaOsob);

            byte iloscOsob = koncowaTablicaOsob.WezIloscOsob;

            ITabelaNaleznosciPienieznej stworzPustyTabelaNaleznosciPienieznej() =>
                Stworz_TabelaNaleznosciPienieznej.Stworz_Pusty(iloscOsob, kryteriumWyboruTabeliNaleznosci);

            ITabelaNaleznosciPienieznej stworzTabelaNaleznosciPienieznejNull() =>
                Stworz_TabelaNaleznosciPienieznejNull.Stworz(iloscOsob);

            IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada fabryka =
                Stworz_IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz_Mock.
                Stworz(stworzPustyTabelaNaleznosciPienieznej, stworzTabelaNaleznosciPienieznejNull);

            INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz najwiekszaMozliwaNaleznoscDoWymianyUstalacz =
                Stworz_NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz.Stworz(koncowaTablicaOsob);

            IRozniceDoStanuKwitaNaleznosciPienieznychSumator rozniceDoStanuKwitaSumator = 
                Stworz_RozniceDoStanuKwitaNaleznosciPienieznychSumator.Stworz(koncowaTablicaOsob);

            return new NajlepszaWymianaNalezosciPienieznejZnajdywacz(fabryka, najwiekszaMozliwaNaleznoscDoWymianyUstalacz, rozniceDoStanuKwitaSumator);
        }
    }
}