using System.Linq;

using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.TablicaOsob
{
    partial class TablicaOsobPienieznych : ITablicaOsob
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