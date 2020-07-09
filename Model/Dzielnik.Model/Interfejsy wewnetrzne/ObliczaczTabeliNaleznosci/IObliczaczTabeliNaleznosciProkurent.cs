using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci
{
    /// <summary>
    /// Interfejs dla prokurenta wybierajacego odpowiedni obliczacz tabeli naleznosci w zaleznosci od obecnych ustawien.
    /// </summary>
    internal interface IObliczaczTabeliNaleznosciProkurent
    {
        ITabelaNaleznosciZwrotna ObliczNaleznosci(ITablicaOsobBaza tablicaOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci);
    }
}