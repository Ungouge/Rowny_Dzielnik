using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Naleznosci
{
    /// <summary>
    /// Kukla odpowiadjaca naleznosci, ze swiadczeniem pieniznym, osoby wzgledem samej siebie,
    /// ktora to powinna znajdowac sie na diagonalnej tabel z naleznosciami osob.
    /// </summary>
    internal class NaleznoscPienieznaDiagonalna : INaleznoscPienieznaDiagonalnaSwiadczenie
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