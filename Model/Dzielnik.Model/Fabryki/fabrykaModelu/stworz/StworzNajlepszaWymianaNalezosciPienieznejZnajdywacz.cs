using Dzielnik.Model.DoStanuKwitaSumator;
using Dzielnik.Model.Fabryka;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Model.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Fabryki
{
    partial class FabrykaModelu
    {
        public INajlepszaWymianaNalezosciPienieznejZnajdywacz StworzNajlepszaWymianaNalezosciPienieznejZnajdywacz(ITablicaOsobPienieznych koncowaTablicaOsob,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz ustalacz = StworzNajwiekszaMozliwaNaleznoscDoWymianyUstalacz(koncowaTablicaOsob);

            IRozniceDoStanuKwitaNaleznosciPienieznychSumator sumator = StworzRozniceDoStanuKwitaNaleznosciPienieznychSumator(koncowaTablicaOsob);

            IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada fasadaFabryki =
                StworzFasadaFabrykiDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz(koncowaTablicaOsob.WezIloscOsob, kryteriumWyboruTabeliNaleznosci);

            return new NajlepszaWymianaNalezosciPienieznejZnajdywacz(fasadaFabryki, ustalacz, sumator);
        }

        private INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz StworzNajwiekszaMozliwaNaleznoscDoWymianyUstalacz(ITablicaOsobPienieznychZwrotna koncowaTablicaOsob)
        {
            return new NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz(fabrykaNaleznoscPienieznaZerowa, koncowaTablicaOsob);
        }

        private IRozniceDoStanuKwitaNaleznosciPienieznychSumator StworzRozniceDoStanuKwitaNaleznosciPienieznychSumator(ITablicaOsobPienieznychIterowalna koncowaTablicaOsob)
        {
            return new RozniceDoStanuKwitaNaleznosciPienieznychSumator(koncowaTablicaOsob);
        }

        private IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada StworzFasadaFabrykiDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz(byte iloscOsob,
            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            return new FabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada(this, iloscOsob, kryteriumWyboruTabeliNaleznosci);
        }
    }
}