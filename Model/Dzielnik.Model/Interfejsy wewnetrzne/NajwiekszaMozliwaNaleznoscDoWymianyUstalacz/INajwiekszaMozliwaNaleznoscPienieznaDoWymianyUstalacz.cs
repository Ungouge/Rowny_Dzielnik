using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.NajwiekszaMozliwaNaleznoscDoWymianyUstalacz
{
    /// <summary>
    /// Interfejs dla ustalacza najwiekszej mozliwej naleznosci pienieznej jaka mozna wymienic pomiedzy osobami.
    /// </summary>
    internal interface INajwiekszaMozliwaNaleznoscPienieznaDoWymianyUstalacz
    {
        /// <summary>
        /// Ustal najwieksza mozliwa naleznosc pieniezna jaka mozna wymienic pomiedzy osobami.
        /// </summary>
        INaleznoscPieniezna UstalNaleznoscDoWymiany(ITablicaOsobPienieznychZwrotna tablicaOsob, IOsobaID osobaKorzen, IOsobaID osobaPotomek);
    }
}