using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.TabeleNaleznosci
{
    partial struct PolozenieWTabeliNaleznosci
    {
        byte IPolozenieGornotrojkatneWTabeliNaleznosci.Indeks_X
        {
            get
            {
                return indeks_Y > indeks_X ? indeks_Y : indeks_X;
            }
        }

        byte IPolozenieGornotrojkatneWTabeliNaleznosci.Indeks_Y
        {
            get
            {
                return indeks_Y > indeks_X ? indeks_X : indeks_Y;
            }
        }
    }
}