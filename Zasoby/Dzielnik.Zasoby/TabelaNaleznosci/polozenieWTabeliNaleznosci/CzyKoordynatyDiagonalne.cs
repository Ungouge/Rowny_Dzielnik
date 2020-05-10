using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.TabeleNaleznosci
{
    partial struct PolozenieWTabeliNaleznosci : IPolozenieWTabeliNaleznosci, IPolozenieGornotrojkatneWTabeliNaleznosci
    {
        public bool CzyKoordynatyDiagonalne
        {
            get
            {
                return Indeks_X == Indeks_Y;
            }
        }
    }
}