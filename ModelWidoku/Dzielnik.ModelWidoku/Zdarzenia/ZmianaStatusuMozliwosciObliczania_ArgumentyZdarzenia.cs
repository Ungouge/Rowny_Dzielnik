using System;

namespace Dzielnik.ModelWidoku.Zdarzenia
{
    /// <summary>
    /// Argument zdarzenie dla obslugi zdarzenia notyfikacji zmiany moznosci obliczania przez model widoku.
    /// </summary>
    internal class ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia : EventArgs
    {
        public bool CzyMoznaObliczac { get; }

        public static ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia WezPusty { get { return new ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia(true); } }

        public new static readonly ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia Empty = WezPusty;

        /// <summary>
        /// Stworz argument notyfikacji zmiany moznosci obliczania przez model widoku.
        /// </summary>
        public ZmianaStatusuMozliwosciObliczania_ArgumentyZdarzenia(bool czyMoznaObliczac)
        {
            CzyMoznaObliczac = czyMoznaObliczac;
        }
    }
}