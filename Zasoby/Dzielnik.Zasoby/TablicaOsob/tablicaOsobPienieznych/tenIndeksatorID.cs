using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.TablicaOsob
{
    partial class TablicaOsobPienieznych : ITablicaOsobPienieznychZwrotna
    {
        public IOsobaPieniezna this[IOsobaID osobaID]
        {
            get
            {
                if (osobaID.ID == osoby[osobaID.ID].ID)
                    return osoby[osobaID.ID];

                foreach (IOsobaPieniezna osoba in osoby)
                    if (osoba.ID == osobaID.ID)
                        return osoba;

                return null;
            }
        }
    }
}