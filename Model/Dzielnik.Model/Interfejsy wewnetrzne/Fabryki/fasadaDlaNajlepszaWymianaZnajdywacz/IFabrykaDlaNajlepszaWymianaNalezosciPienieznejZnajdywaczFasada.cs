using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fasady fabryki do tworzenia potrzebnych obiektow dla NajlepszaWymianaNalezosciPienieznejZnajdywacz.
    /// </summary>
    internal interface IFabrykaDlaNajlepszaWymianaNalezosciPienieznejZnajdywaczFasada
    {
        /// <summary>
        /// Tworzy instancje ITabelaNaleznosciPienieznej.
        /// </summary>
        ITabelaNaleznosciPienieznej StworzStartowaTabelaNaleznosciPienieznej();

        /// <summary>
        /// Tworzy instancje ITabelaNaleznosciPienieznej z zachowaniem pustym.
        /// </summary>
        ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull();

        /// <summary>
        /// Tworzy instancje PolozenieWTabeliNaleznosci dla podanych koordynatow.
        /// </summary>
        IPolozenieWTabeliNaleznosci StworzPolozenieWTabeliNaleznosci(byte index_X, byte index_Y);
    }
}