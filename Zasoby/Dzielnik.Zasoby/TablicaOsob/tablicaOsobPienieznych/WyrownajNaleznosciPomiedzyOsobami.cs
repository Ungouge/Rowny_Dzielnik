using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.TablicaOsob
{
    partial class TablicaOsobPienieznych: ITablicaOsobPienieznychIterowalna
    {
        public ITablicaOsobPienieznych PrzekazNaleznosciPomiedzyOsobami(IOsobaID osobaKorzen, IOsobaID osobaPotomek, INaleznoscPieniezna naleznosc)
        {
            return new TablicaOsobPienieznych(OsobyZWymienionymiNaleznosciami(osobaKorzen.ID, osobaPotomek.ID, naleznosc));
        }

        private IOsobaPieniezna[] OsobyZWymienionymiNaleznosciami(byte iDOsobaKorzen, byte iDOsobaPotomek,
            INaleznoscPieniezna naleznosc)
        {
            IOsobaPieniezna[] nowaTablica = new IOsobaPieniezna[osoby.Length];

            for (int iD = 0; iD < nowaTablica.Length; iD++)
                nowaTablica[iD] = WymienNaleznoscOsobie(osoby[iD], iDOsobaKorzen, iDOsobaPotomek, naleznosc);

            return nowaTablica;
        }

        private IOsobaPieniezna WymienNaleznoscOsobie(IOsobaPieniezna porownywanaOsoba, byte iDOsobaKorzen, byte iDOsobaPotomek, INaleznoscPieniezna naleznosc)
        {
            if (porownywanaOsoba.ID == iDOsobaKorzen)
                return porownywanaOsoba.ZmienWplate(porownywanaOsoba.Wplata.Roznica(naleznosc));
            
            if (porownywanaOsoba.ID == iDOsobaPotomek)
                return porownywanaOsoba.ZmienWplate(porownywanaOsoba.Wplata.Suma(naleznosc));

            return porownywanaOsoba;
        }
    }
}