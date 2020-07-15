using System;
using System.Runtime.InteropServices;

using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.Zdarzenia
{
    /// <summary>
    /// Argument zdarzenie dla obslugi zdarzenia notyfikacji obliczenie nowej tabeli naleznosci przez model.
    /// </summary>
    [ComVisible(true)]
    public class ObliczonaTabelaNaleznosci_ArgumentZdarzenia: EventArgs
    {
        public ITabelaNaleznosciZwrotna TabelaNaleznosciZwrotna { get; }
        
        private static ObliczonaTabelaNaleznosci_ArgumentZdarzenia WezPusty =>
            new ObliczonaTabelaNaleznosci_ArgumentZdarzenia(null);

        public static new readonly ObliczonaTabelaNaleznosci_ArgumentZdarzenia Empty = WezPusty;

        /// <summary>
        /// Stworz argument zdarzenia dla obliczonej tabeli naleznosci.
        /// </summary>
        public ObliczonaTabelaNaleznosci_ArgumentZdarzenia(ITabelaNaleznosciZwrotna tabelaNaleznosciZwrotna)
        {
            TabelaNaleznosciZwrotna = tabelaNaleznosciZwrotna;
        }
    }
}
