using System;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Wyliczniki;
using Dzielnik.Zasoby.Zdarzenia;

namespace Dzielnik.Inicjalizator.Interfejsy
{
    public interface IUstawienia : IUstawieniaDlaModelWidoku
    {
        int ElementSzerokosc { get; }
    }

    public interface IUstawieniaDlaModelWidoku : IUstawieniaDlaModel, IUstawieniaDlaTabelaKomorek
    {
        event EventHandler<ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia> ZmianaIloscOsob_ObslugaZdarzenia;

        event EventHandler<ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia> ZmianaKryteriumWyboru_ObslugaZdarzenia;

        new byte IloscOsob { get; set; }

        new KryteriumWyboruTabeliNaleznosciWylicznik KryteriumWyboruTabeliNaleznosci { get; set; }

        new RodzajNaleznosciWylicznik RodzajNaleznosciWylicznik { get; set; }
    }
    
    public interface IUstawieniaRodzajNaleznosciNaZmiane: IUstawieniaRodzajNaleznosciWylicznik
    {
        event EventHandler<ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia> ZmianaRodzajuNaleznosci_ObslugaZdarzenia;
    }

    public interface IUstawieniaDlaModel : IUstawieniaKryteriumWyboruTabeliNaleznosciWylicznik, IUstawieniaIloscOsob
    {
    }

    public interface IUstawieniaKryteriumWyboruTabeliNaleznosciWylicznik
    {
        KryteriumWyboruTabeliNaleznosciWylicznik KryteriumWyboruTabeliNaleznosci { get; }
    }

    public interface IUstawieniaIloscOsob
    {
        byte IloscOsob { get; }
    }
}