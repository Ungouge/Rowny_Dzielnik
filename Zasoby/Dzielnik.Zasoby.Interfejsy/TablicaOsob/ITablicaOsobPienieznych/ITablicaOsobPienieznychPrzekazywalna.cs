using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Interfejsy.TablicaOsob
{
    /// <summary>
    /// Intefejs dla tablic osob wyronujacych 
    /// </summary>
    public interface ITablicaOsobPienieznychPrzekazywalna : ITablicaOsob
    {
        /// <summary>
        /// Zwraca nowa tablice osob z przekazana wartosc naleznoci podanego swiadczenia pienieznego pomiedzy podanymi osobami podanych osob.
        /// </summary>
        ITablicaOsobPienieznych PrzekazNaleznosciPomiedzyOsobami(IOsobaID osobaKorzen, IOsobaID osobaPotomek,
            INaleznoscPieniezna naleznoscPieniezna);
    }
}