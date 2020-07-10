using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Model.Fabryki
{
    partial class FabrykaModelu
    {
        public IObliczaczTabeliNaleznosciProkurent StworzObliczaczTabeliNaleznosciProkurent()
        {
            return new ObliczaczTabeliNaleznosciProkurent(this);
        }
    }
}