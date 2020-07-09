using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.Fabryka
{
    internal class FabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada : IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada
    {
        private readonly IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz fabryka;

        private readonly byte iloscOsob;
            
        private readonly KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci;

        public FabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada(IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz fabryka, 
            byte iloscOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            this.fabryka = fabryka;

            this.iloscOsob = iloscOsob;

            this.kryteriumWyboruTabeliNaleznosci = kryteriumWyboruTabeliNaleznosci;
        }

        public IPolozenieWTabeliNaleznosci StworzPolozenieWTabeliNaleznosci(byte index_X, byte index_Y)
        {
            return fabryka.StworzPolozenieWTabeliNaleznosci(index_X, index_Y);
        }

        public ITabelaNaleznosciPienieznej StworzStartowaTabelaNaleznosciPienieznej()
        {
            return fabryka.StworzStartowaTabelaNaleznosciPienieznej(iloscOsob, kryteriumWyboruTabeliNaleznosci);
        }

        public ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull()
        {
            return fabryka.StworzTabelaNaleznosciPienieznejNull(iloscOsob);
        }
    }
}
