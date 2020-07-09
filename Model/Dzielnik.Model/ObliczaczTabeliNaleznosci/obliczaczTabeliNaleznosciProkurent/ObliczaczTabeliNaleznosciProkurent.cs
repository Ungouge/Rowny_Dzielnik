using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Model.ObliczaczTabeliNaleznosci
{
    /// <summary>
    /// Prokurent wybierajacego odpowiedni obliczacz tabeli naleznosci w zaleznosci od obecnych ustawien.
    /// </summary>
    internal partial class ObliczaczTabeliNaleznosciProkurent : IObliczaczTabeliNaleznosciProkurent
    {
        private IFabrykaDlaObliczaczTabeliNaleznosciProkurent fabryka;

        public ObliczaczTabeliNaleznosciProkurent(IFabrykaDlaObliczaczTabeliNaleznosciProkurent fabryka)
        {
            this.fabryka = fabryka;
        }
    }
}