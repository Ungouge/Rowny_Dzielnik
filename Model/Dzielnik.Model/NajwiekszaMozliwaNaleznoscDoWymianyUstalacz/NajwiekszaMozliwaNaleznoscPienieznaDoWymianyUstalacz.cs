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

        internal NajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz(IFabrykaNaleznoscPienieznaZerowa fabrykaNaleznoscPienieznaZerowa,
            ITablicaOsobPienieznychZwrotna koncowaTablicaOsob)
        {
            this.koncowaTablicaOsob = koncowaTablicaOsob;

            naleznoscPienieznaZerowa = fabrykaNaleznoscPienieznaZerowa.StworzNaleznoscZerowa();
        }

        public INaleznoscPieniezna UstalNaleznoscDoWymiany(ITablicaOsobPienieznychZwrotna tablicaOsob, IOsobaID osobaKorzen, IOsobaID osobaPotomek)
        {
            INaleznoscPieniezna roznicaNaleznosciKorzenia =
                tablicaOsob[osobaKorzen].Wplata.Roznica(koncowaTablicaOsob[osobaKorzen].Wplata);

            INaleznoscPieniezna roznicaNaleznosciPotomka =
                koncowaTablicaOsob[osobaPotomek].Wplata.Roznica(tablicaOsob[osobaPotomek].Wplata);

            if (naleznoscPienieznaZerowa.CzyWieksze(roznicaNaleznosciPotomka))
                if (naleznoscPienieznaZerowa.CzyWieksze(roznicaNaleznosciKorzenia))
                    return roznicaNaleznosciKorzenia.CzyWieksze(roznicaNaleznosciPotomka) ? roznicaNaleznosciKorzenia : roznicaNaleznosciPotomka;
            
            return naleznoscPienieznaZerowa;
        }
    }
}