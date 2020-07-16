using System;

using Dzielnik.ModelWidoku.Zdarzenia;

namespace Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac
{
    /// <summary>
    /// Interfejs dla wskaznika wskazujacego czy mozna obliczac z obsluga zdarzeniem zmiany statusu.
    /// </summary>
    interface ICzyMoznaObliczacZmianaWartosci
    {
        /// <summary>
        /// Obsluga zdarzenia zmiany statusu wskaznika czy mozna obliczac.
        /// </summary>
        event EventHandler<ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia> ZmianaWartosci;
    }
}