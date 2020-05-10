using Dzielnik.Model.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla fabryk TabelaNaleznosciPienieznejNull.
    /// </summary>
    internal interface IFabrykaTabelaNalezosciPienieznejNull
    {
        /// <summary>
        /// Tworzy instancje ITabelaNaleznosciPienieznejNull.
        /// </summary>
        ITabelaNaleznosciPienieznej StworzTabelaNaleznosciPienieznejNull(byte iloscOsob);
    }
}