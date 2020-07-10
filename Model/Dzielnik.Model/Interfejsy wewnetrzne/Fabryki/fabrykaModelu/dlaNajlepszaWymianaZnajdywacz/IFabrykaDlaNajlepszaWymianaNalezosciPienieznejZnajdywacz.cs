using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryki do tworzenia potrzebnych obiektow dla NajlepszaWymianaNalezosciPienieznejZnajdywacz.
    /// </summary>
    internal interface IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywacz
    {
        /// <summary>
        /// Stworz instancje ITabelaNaleznosciPienieznej dla podanych argumentow.
        /// </summary>
        ITabelaNaleznosciPienieznej StworzStartowaTabelaNaleznosciPienieznej(byte iloscOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci);

        /// <summary>
        /// Tworzy instancje ITabelaNaleznosciPienieznej z zachowaniem pustym dla podanego argument.
        /// </summary>
        ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull(byte iloscOsob);
        
        /// <summary>
        /// Tworzy instancje PolozenieWTabeliNaleznosci dla podanych koordynatow.
        /// </summary>
        IPolozenieWTabeliNaleznosci StworzPolozenieWTabeliNaleznosci(byte index_X, byte index_Y);
    }
}