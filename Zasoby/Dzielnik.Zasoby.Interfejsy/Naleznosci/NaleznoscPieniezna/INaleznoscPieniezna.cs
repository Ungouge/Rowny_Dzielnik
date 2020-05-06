
namespace Dzielnik.Zasoby.Interfejsy.Naleznosci
{
    /// <summary>
    /// Interfejs dla naleznosci pienieznych z mozliwosci obrotu ta naleznoscia.
    /// </summary>
    public interface INaleznoscPieniezna: INaleznoscPienieznaSwiadczenie 
    {
        /// <summary>
        /// Zwraca nowa INaleznoscPieniezna o swiadczeniu o bedacym odwotnoscia podanej swiadczenia naleznosci pienieznej.
        /// </summary>
        INaleznoscPieniezna Odwrotnosc();

        /// <summary>
        /// Zwraca nowa INaleznoscPieniezna o swiadczeniu bedacym suma tego i podanego swiadczenia naleznosci pienieznej
        /// </summary>
        INaleznoscPieniezna Suma(INaleznoscPieniezna naleznosc);

        /// <summary>
        /// Zwraca nowa INaleznoscPieniezna o swiadczeniu bedacym roznica tego od podanego swiadczenia naleznosci pienieznej
        /// </summary>
        INaleznoscPieniezna Roznica(INaleznoscPieniezna naleznosc);

        /// <summary>
        /// Stwierdza czy podana naleznosc posiada wieksze swiadczenie pieniezne.
        /// </summary>
        bool CzyWieksze(INaleznoscPieniezna PorownywanaNaleznosc);
    }
}
