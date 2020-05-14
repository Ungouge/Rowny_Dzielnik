using System.Collections.Generic;

using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.NajlepszaWymianaZnajdywacz
{
    partial class NajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        public ITabelaNaleznosciPienieznejZwrotna Znajdz(ITablicaOsobPienieznych tablicaOsob)
        {
            return Znajdz(tablicaOsob, rozniceDoStanuKwitaSumator.SumujRoznice(tablicaOsob));
        }

        private ITabelaNaleznosciPienieznej Znajdz(ITablicaOsobPienieznych tablicaOsob, long staraRozniceDoPoczatkowej)
        {
            ITabelaNaleznosciPienieznej najlepszaTabelaNaleznosci = fabryka.StworzTabelaNaleznosciPienieznejNull();

            foreach (IOsobaPieniezna osobaKorzen in (tablicaOsob as IEnumerable<IOsobaPieniezna>))
            {
                foreach (IOsobaPieniezna osobaPotomek in tablicaOsob)
                {
                    INaleznoscPieniezna roznicaNaleznosci = najwiekszaMozliwaNaleznoscDoWymianyUstalacz.UstalNaleznoscDoWymiany(tablicaOsob, osobaKorzen, osobaPotomek);

                    if (roznicaNaleznosci.Swiadczenie == 0)
                        continue;

                    ITablicaOsobPienieznych nowaTablicaOsob = tablicaOsob.PrzekazNaleznosciPomiedzyOsobami(osobaKorzen, osobaPotomek, roznicaNaleznosci);

                    long rozniceDoPoczatkowej = rozniceDoStanuKwitaSumator.SumujRoznice(nowaTablicaOsob);

                    if (rozniceDoPoczatkowej >= staraRozniceDoPoczatkowej)
                        continue;

                    ITabelaNaleznosciPienieznej NowaTabelaNaleznosci = ZnajdzTabeleNaleznosciDlaNoweTablicyOsob(nowaTablicaOsob, rozniceDoPoczatkowej);

                    NowaTabelaNaleznosci.DodajWymianeNalzenosciUaktualniajacKryterium(roznicaNaleznosci,
                        fabryka.StworzPolozenieWTabeliNaleznosci(osobaPotomek.ID, osobaKorzen.ID));

                    najlepszaTabelaNaleznosci = najlepszaTabelaNaleznosci.ZwrocLepszeKryterium( NowaTabelaNaleznosci);
                }
            }

            return najlepszaTabelaNaleznosci;
        }

        private ITabelaNaleznosciPienieznej ZnajdzTabeleNaleznosciDlaNoweTablicyOsob(ITablicaOsobPienieznych nowaTablicaOsob, long rozniceDoPoczatkowej)
        {
            if (rozniceDoPoczatkowej == 0)
                return fabryka.StworzStartowaTabelaNaleznosciPienieznej();

            return Znajdz(nowaTablicaOsob, rozniceDoPoczatkowej);
        }
    }
}