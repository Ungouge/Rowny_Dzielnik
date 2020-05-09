using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using System;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    /// <summary>
    /// Abstrakcja kryteriow wyboru tabel naleznosci ze swiadczeniem pienieznym.
    /// </summary>
    internal abstract class KryteriumWyboruTabeliNaleznosciPienieznychBaza : IKryteriumWyboruTabeliNaleznosciPienieznej
    {
        public abstract bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosciPienieznej porownywaneKryterium);
        
        bool IKryteriumWyboruTabeliNaleznosci.CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosci porownywaneKryterium)
        {
            if (porownywaneKryterium is IKryteriumWyboruTabeliNaleznosciPienieznej kryteriumWyboruTabeliNaleznosciPienieznej)
                return (this as IKryteriumWyboruTabeliNaleznosciPienieznej).CzyPorownywaneKyrteriumLepsze(kryteriumWyboruTabeliNaleznosciPienieznej);

            throw new TypeAccessException();
        }
    }
}