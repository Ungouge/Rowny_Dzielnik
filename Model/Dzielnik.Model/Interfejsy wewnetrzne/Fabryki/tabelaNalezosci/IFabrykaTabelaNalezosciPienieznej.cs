using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryk TabelaNaleznosciPienieznej.
    /// </summary>
    internal interface IFabrykaTabelaNalezosciPienieznej : IFabrykaTabelaNalezosciBaza
    {
        /// <summary>
        /// Tworzy instancje ITabelaNaleznosciPienieznej.
        /// </summary>
        ITabelaNaleznosciPienieznej StworzTabelaNaleznosci(byte iloscOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci);
    }
}