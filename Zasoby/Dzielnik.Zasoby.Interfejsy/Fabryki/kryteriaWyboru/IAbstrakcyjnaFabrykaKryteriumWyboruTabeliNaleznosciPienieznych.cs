using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs dla abstrakcyjnych fabryk kryteriow wyboru tabeli naleznosci.
    /// </summary>
    public interface IAbstrakcyjnaFabrykaKryteriumWyboruTabeliNaleznosciPienieznych
    {
        /// <summary>
        /// Stworz instancje kryterium wyboru tabeli naleznosci odpowiedni przeslanemu wylicznikowi kryterium.
        /// </summary>
        IKryteriumWyboruTabeliNaleznosciPienieznej StworzKryteriumWyboruTabeliNaleznosci(KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci);
    }
}