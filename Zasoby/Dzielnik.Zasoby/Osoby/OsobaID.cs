using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.Osoby
{
    /// <summary>
    /// Abstrakcyjna klasa dla osob z numer identyfikacyjny,
    /// ktory powinien odpowiadac numerowi kolejnosci w tabeli z danymi wejsciowymi. 
    /// </summary>
    internal abstract class OsobaID : IOsobaID
    {
        public byte ID { get; }

        protected OsobaID(byte iD)
        {
            ID = iD;
        }

        public bool CzyToTaSamaOsoba(IOsobaID osobaID)
        {
            return ID == osobaID.ID;
        }
    }
}