using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    /// <summary>
    /// Naleznosc ze swiadczeniem pienieznym wyrazonym w walucie podzielnej na setki.
    /// </summary>
    internal partial class NaleznoscPieniezna: INaleznoscPieniezna
    {
        public int Swiadczenie { get; }

        internal NaleznoscPieniezna(int grosze)
        {
            Swiadczenie = grosze;
        }
    }
}