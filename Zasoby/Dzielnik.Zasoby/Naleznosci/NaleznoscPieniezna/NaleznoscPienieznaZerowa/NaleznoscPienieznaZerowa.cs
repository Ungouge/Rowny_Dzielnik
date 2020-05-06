using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using System.Collections.Generic;
using System.Linq;

namespace Dzielnik.Zasoby.Naleznosci
{
    /// <summary>
    /// Naleznosc ze swiadczeniem pienieznym, gdzie wartosc swiadczenia jest na stałe przypisana zero.
    /// </summary>
    internal partial class NaleznoscPienieznaZerowa : INaleznoscPieniezna
    {
        public int Swiadczenie
        {
            get
            {
                return 0;
            }
        }
    }
}