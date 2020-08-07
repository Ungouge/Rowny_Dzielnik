using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Wyliczniki;
using Dzielnik.Zasoby.Zdarzenia;
using System;

namespace Dzielnik.Inicjalizator
{
    public class Ustawienia : IUstawienia
    {
        private byte iloscOsob;

        private KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci;

        private RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik;

        public event EventHandler<ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia> ZmianaIloscOsob_ObslugaZdarzenia;

        public event EventHandler<ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia>  ZmianaKryteriumWyboru_ObslugaZdarzenia;

        public event EventHandler<ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia> ZmianaRodzajuNaleznosci_ObslugaZdarzenia;

        public Ustawienia(KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci, RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik, byte iloscOsob)
        {
            KryteriumWyboruTabeliNaleznosci = kryteriumWyboruTabeliNaleznosci;

            IloscOsob = iloscOsob;

            RodzajNaleznosciWylicznik = rodzajNaleznosciWylicznik;
        }

        public KryteriumWyboruTabeliNaleznosciWylicznik KryteriumWyboruTabeliNaleznosci
        {
            get
            {
                return kryteriumWyboruTabeliNaleznosci;
            }
            set
            {
                kryteriumWyboruTabeliNaleznosci = value;

                NaZmianeKryteriumWyboruTabeliNaleznosci();
            }
        }

        private void NaZmianeKryteriumWyboruTabeliNaleznosci()
        {
            ZmianaKryteriumWyboru_ObslugaZdarzenia?.Invoke(this, new ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia(KryteriumWyboruTabeliNaleznosci));
        }

        public RodzajNaleznosciWylicznik RodzajNaleznosciWylicznik
        {
            get
            {
                return rodzajNaleznosciWylicznik;
            }
            set
            {
                rodzajNaleznosciWylicznik = value;

                NaZmianeRodzajNaleznosciWylicznik();
            }
        }

        private void NaZmianeRodzajNaleznosciWylicznik()
        {
            ZmianaRodzajuNaleznosci_ObslugaZdarzenia?.Invoke(this, new ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia(RodzajNaleznosciWylicznik));
        }

        public byte IloscOsob
        {
            get
            {
                return iloscOsob;
            }
            set
            {
                iloscOsob = value;

                NaZmianeIloscOsob();
            }
        }

        public int ElementSzerokosc => 25;

        private void NaZmianeIloscOsob()
        {
            ZmianaIloscOsob_ObslugaZdarzenia?.Invoke(this, new ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia(IloscOsob));
        }
    }
}
