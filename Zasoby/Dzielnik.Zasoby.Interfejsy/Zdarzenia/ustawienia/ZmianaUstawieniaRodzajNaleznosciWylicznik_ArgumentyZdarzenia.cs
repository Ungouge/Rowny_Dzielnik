using System;

using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.Zasoby.Zdarzenia
{
    /// <summary>
    /// Argument zadrzenia dla obslugi zmiany rodzaju naleznosci w ustawieniach.
    /// </summary>
    public class ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia : EventArgs
    {
        public RodzajNaleznosciWylicznik RodzajNaleznosci { get; }

        private static ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia WezPusty => new ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia(default(RodzajNaleznosciWylicznik));

        public new static readonly ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia Empty = WezPusty;

        /// <summary>
        /// Stworz argument miany rodzaju naleznosci w ustawieniach.
        /// </summary>
        public ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia(RodzajNaleznosciWylicznik rodzajNaleznosci)
        {
            RodzajNaleznosci = rodzajNaleznosci;
        }
    }
}