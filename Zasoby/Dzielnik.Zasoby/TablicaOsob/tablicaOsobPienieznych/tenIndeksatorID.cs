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
                return osoby[osobaID.ID];
            }
        }
    }
}