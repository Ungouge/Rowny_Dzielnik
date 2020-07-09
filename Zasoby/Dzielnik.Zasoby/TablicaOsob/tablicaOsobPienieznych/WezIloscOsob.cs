using System.Linq;

using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.TablicaOsob
{
    partial class TablicaOsobPienieznych : ITablicaOsob<IOsobaPieniezna>
    {
        public byte WezIloscOsob
        {
            get
            {
                return (byte)osoby.Count();
            }
        }
    }
}