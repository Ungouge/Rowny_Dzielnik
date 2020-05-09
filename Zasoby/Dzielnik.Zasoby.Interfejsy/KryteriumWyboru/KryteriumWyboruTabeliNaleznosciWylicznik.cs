using System.ComponentModel;

namespace Dzielnik.Zasoby.Interfejsy.KryteriumWyboru
{
    /// <summary>
    /// Enumerator zawierajacy kryteria wyboru tabeli naleznosci.
    /// </summary>
    [DefaultValue(0)]
    public enum KryteriumWyboruTabeliNaleznosciWylicznik
    {
        KryteriumSumyWymienionejNaleznosci = 0,
        IlosciWymian
    }
}