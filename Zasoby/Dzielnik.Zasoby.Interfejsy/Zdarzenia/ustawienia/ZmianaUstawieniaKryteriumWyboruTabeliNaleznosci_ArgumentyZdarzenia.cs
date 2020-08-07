using System;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Zasoby.Zdarzenia
{
    /// <summary>
    /// Argument zadrzenia dla obslugi zmiany kryterium wyboru w ustawieniach.
    /// </summary>
    public class ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia : EventArgs
    {
        public KryteriumWyboruTabeliNaleznosciWylicznik KryteriumWyboruTabeliNaleznosci { get; }

        private static ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia WezPusty =>
            new ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia(default(KryteriumWyboruTabeliNaleznosciWylicznik));

        public static new readonly ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia Empty = WezPusty;

        /// <summary>
        /// Stworz argument zmiany kryterium wyboru w ustawieniach.
        /// </summary>
        public ZmianaUstawieniaKryteriumWyboruTabeliNaleznosci_ArgumentyZdarzenia(KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            KryteriumWyboruTabeliNaleznosci = kryteriumWyboruTabeliNaleznosci;
        }
    }
}