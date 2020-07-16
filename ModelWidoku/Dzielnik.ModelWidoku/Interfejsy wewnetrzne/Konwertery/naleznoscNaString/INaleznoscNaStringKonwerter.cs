using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    /// <summary>
    /// Interfejs dla konwertera przeslanej naleznosci na tekstu w odpowiedni dla implementacji sposob.
    /// </summary>
    internal interface INaleznoscNaStringKonwerter
    {
        /// <summary>
        /// Konwertuj przeslana naleznosc na tekstu w odpowiedni dla implementacji sposob.
        /// </summary>
        string NaString(INaleznoscSwiadczenieBaza naleznosc);

        /// <summary>
        /// Konwertuj odwrotnosc przeslanej naleznosc na tekstu w odpowiedni dla implementacji sposob.
        /// </summary>
        string NaStringOdwrotnosc(INaleznoscSwiadczenieBaza naleznosc);
    }
}