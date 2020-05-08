using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.TablicaOsob
{
    partial class TablicaOsobPienieznych : ITablicaOsobPienieznychZwrotna
    {
        IOsobaWymiennaBaza ITablicaOsobZwrotna.this[byte iD]
        {
            get
            {
                return (this as ITablicaOsobPienieznychZwrotna)[iD] as IOsobaPienieznaWymienna;
            }
        }

        public IOsobaPienieznaWymienna this[byte iD]
        {
            get
            {
                return osoby[iD];
            }
        }
    }
}