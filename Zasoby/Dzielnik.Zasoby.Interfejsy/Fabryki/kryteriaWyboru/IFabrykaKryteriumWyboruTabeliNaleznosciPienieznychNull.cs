using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interface dla fabryk kryteriow wyboru z naleznoscia pieniezna 
    /// </summary>
    public interface IFabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull
    {
        /// <summary>
        /// Tworzy instancje kryteriium wyboru tabel naleznosci ze swiadczeniem pienieznym z zachowaniem pustym.
        /// </summary>
        IKryteriumWyboruTabeliNaleznosciPienieznej StworzKryteriumWyboruTabeliNaleznosciPienieznychNull();
    }
}