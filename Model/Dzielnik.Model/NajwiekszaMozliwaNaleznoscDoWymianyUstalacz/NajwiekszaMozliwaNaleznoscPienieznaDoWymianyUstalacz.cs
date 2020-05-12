using Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz
{
    /// <summary>
    /// Ustalacza najwiekszej mozliwej naleznosci pienieznej jaka mozna wymienic pomiedzy osobami.
    /// </summary>
    internal class NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz : INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz
    {
        private readonly ITablicaOsobPienieznychZwrotna koncowaTablicaOsob;

        private readonly INaleznoscPieniezna naleznoscPienieznaZerowa;

        public NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz(IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa,
            ITablicaOsobPienieznychZwrotna koncowaTablicaOsob)
        {
            this.koncowaTablicaOsob = koncowaTablicaOsob;

            naleznoscPienieznaZerowa = fabrykaNaleznoscPienieznaZerowa.StworzNaleznoscZerowa();
        }

        public INaleznoscPieniezna UstalNaleznoscDoWymiany(ITablicaOsobPienieznychZwrotna tablicaOsob, IOsobaID osobaKorzen, IOsobaID osobaPotomek)
        {
            INaleznoscPieniezna roznicaNaleznosciKorzenia =
                tablicaOsob[osobaKorzen.ID].Wplata.Roznica(koncowaTablicaOsob[osobaKorzen.ID].Wplata);

            INaleznoscPieniezna roznicaNaleznosciPotomka =
                koncowaTablicaOsob[osobaPotomek.ID].Wplata.Roznica(tablicaOsob[osobaPotomek.ID].Wplata);

            if (naleznoscPienieznaZerowa.CzyWieksze(roznicaNaleznosciPotomka))
                if (naleznoscPienieznaZerowa.CzyWieksze(roznicaNaleznosciKorzenia))
                    return roznicaNaleznosciKorzenia.CzyWieksze(roznicaNaleznosciPotomka) ? roznicaNaleznosciKorzenia : roznicaNaleznosciPotomka;
            
            return naleznoscPienieznaZerowa;
        }
    }
}