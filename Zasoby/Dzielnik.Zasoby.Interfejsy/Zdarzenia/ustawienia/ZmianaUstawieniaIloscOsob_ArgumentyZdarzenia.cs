using System;

namespace Dzielnik.Zasoby.Zdarzenia
{
    /// <summary>
    /// Argument zadrzenia dla obslugi zmiany ilosci osob w ustawieniach.
    /// </summary>
    public class ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia : EventArgs
    {
        public byte IloscOsob { get; }

        private static ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia WezPusty => new ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia(4);

        public static new readonly ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia Empty = WezPusty;

        /// <summary>
        /// Stworz argument zmiany ilosci osob w ustawieniach.
        /// </summary>
        public ZmianaUstawieniaIloscOsob_ArgumentyZdarzenia(byte iloscOsob)
        {
            IloscOsob = iloscOsob;
        }
    }
}
