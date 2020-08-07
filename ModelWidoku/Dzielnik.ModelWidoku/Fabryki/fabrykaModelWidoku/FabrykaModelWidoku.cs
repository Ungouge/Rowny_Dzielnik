using System;
using System.Collections.Generic;
using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Model.Interfejsy;
using Dzielnik.ModelWidoku.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Inicjalizator;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz;
using Dzielnik.ModelWidoku.Konwertery;
using Dzielnik.ModelWidoku.Komorki;
using Dzielnik.ModelWidoku.Uaktualniacz;
using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.Wyjatki;

namespace Dzielnik.ModelWidoku.Fabryki
{
    internal partial class FabrykaModelWidoku: IFabrykaModelWidoku
    {
        internal FabrykaModelWidoku(IModelDzielnikaDlaUaktualniaczModelu modelDzielnika, IInicjalizatorDlaFabrykaModelWidoku inicjalizator, IUstawienia ustawienia)
        {
            fabrykaNaleznoscPieniezna = inicjalizator.FabrykaNaleznoscPieniezna;

            fabrykaNaleznoscPienieznaZerowa = inicjalizator.FabrykaNaleznoscPienieznaZerowa;

            fabrykaOsobaPieniezna = inicjalizator.FabrykaOsobaPieniezna;

            fabrykaTablicaOsobPienieznych = inicjalizator.FabrykaTablicaOsob;

            fabrykaPolozeniaWTabeliNaleznosci = inicjalizator.FabrykaPolozeniaWTabeliNaleznosci;

            uaktualniaczModelu = new ModelUaktualniacz(modelDzielnika);

            czyMoznaObliczacWkaznik = new CzyMoznaObliczacWkaznik();

            komorkaNaOsobaWizytor = StworzKomorkaNaOsobaWizytor(ustawienia.RodzajNaleznosciWylicznik);
        }

        public ICzyMoznaObliczacWkaznik StworzCzyMoznaObliczacWkaznik()
        {
            return czyMoznaObliczacWkaznik;
        }

        private IKonwerterKomorkaNaOsobaWizytator komorkaNaOsobaWizytor;
        
        public IKomorkaKwotyNaleznej StworzKomorkaKwotyNaleznej( byte kolumna, byte rzad, IKonwerterNaleznoscNaStringProkurent NaleznoscNaStringProkurent)
        {
            return new KomorkaKwotyNaleznej(fabrykaNaleznoscPienieznaZerowa.StworzNaleznoscZerowa(), kolumna, rzad, NaleznoscNaStringProkurent);
        }

        public IKomorkaImieniaINaleznosciWejscowej StworzKomorkiImieniaINaleznosciWejscowej(byte indeks, IKonwerterTekstKwotyWejsciowejProkurent konwerterTekstKwotyWejsciowej)
        {
            return new KomorkaImieniaINaleznosciWejscowej(indeks, konwerterTekstKwotyWejsciowej, czyMoznaObliczacWkaznik);
        }

        public ITabelaKomorek StworzTabelaKomorek(IUstawieniaDlaTabelaKomorek ustawienia)
        {
            return new TabelaKomorek(this, ustawienia);
        }

        public ITablicaOsobPienieznych StworzTablicaOsobPienieznych(IOsobaTypSwiadczenia[] szeregOsob)
        {
            switch (szeregOsob)
            {
                case IOsobaPieniezna[] szeregOsobPienieznycha:
                    return fabrykaTablicaOsobPienieznych.StworzTablicaOsob(szeregOsobPienieznycha);
            }

            throw new ZlyTypNaleznosciWyjatek(this, szeregOsob.GetType());
        }

        public IModelUaktualniacz StworzModelUaktualniacz()
        {
            return uaktualniaczModelu;
        }

        public IKomorkaDolnotrojkatnaKwotyNaleznej StworzKomorkaDolnotrojkatnaKwotyNaleznej(IKomorkaKwotyNaleznej komorka)
        {
            return new KomorkaDolnotrojkatnaKwotyNaleznejAdapter(komorka);
        }

        public IKomorkaGornotrojkatnaKwotyNaleznej StworzKomorkaGornotrojkatnaKwotyNaleznej(IKomorkaKwotyNaleznej komorka)
        {
            return new KomorkaGornotrojkatnaKwotyNaleznejAdapter(komorka);
        }

        public IKomorkaDiagonalna StworzKomorkaDiagonalna(IKomorkaImieniaINaleznosciWejscowej komorka)
        {
            return new KomorkaDiagonalnaAdapter(komorka);
        }

        public IKomorkaWejsciowaKwoty StworzKomorkaWejsciowaKwoty(IKomorkaImieniaINaleznosciWejscowej komorka)
        {
            return new KomorkaWejsciowaKwotyAdapter(komorka);
        }

        public IKomorkaWejsciowaImienia StworzKomorkaWejsciowaImienia(IKomorkaImieniaINaleznosciWejscowej komorka)
        {
            return new KomorkaWejsciowaImieniaAdapter(komorka);
        }

        public IKomorkaWyjsciowaImienia StworzKomorkaWyjsciowaImienia(IKomorkaImieniaINaleznosciWejscowej komorka)
        {
            return new KomorkaWyjsciowaImieniaAdapter(komorka);
        }

        public IKomorkaListyKryteriumWyboru StworzKomorkaListyKryteriumWyboru()
        {
            return new KomorkaListyKryteriumWyboru();
        }

        public IKomorkaListyRodzajuNaleznosci StworzKomorkaListyRodzajuNaleznosci()
        {
            return new KomorkaListyRodzajuNaleznosci();
        }
    }
}
