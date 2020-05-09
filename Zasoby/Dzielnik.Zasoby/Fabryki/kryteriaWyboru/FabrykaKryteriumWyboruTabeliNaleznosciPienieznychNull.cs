using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.KryteriumWyboru;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Interface dla fabryk kryteriow wyboru ze swiadczeniem pienieznym z zachowaniem pustym.
    /// </summary>
    public class FabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull : IFabrykaKryteriumWyboruTabeliNaleznosciPienieznychNull
    {
        public IKryteriumWyboruTabeliNaleznosciPienieznej StworzKryteriumWyboruTabeliNaleznosciPienieznychNull()
        {
            return new KryteriumWyboruTabeliNaleznosciPienieznychNull();
        }
    }
}