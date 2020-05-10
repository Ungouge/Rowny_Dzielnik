
namespace Dzielnik.Zasoby.TabeleNaleznosci
{
    partial struct PolozenieWTabeliNaleznosci
    {
        public bool CzyKoordynatyGorntrojkatne
        {
            get
            {
                return Indeks_Y < Indeks_X;
            }
        }
    }
}