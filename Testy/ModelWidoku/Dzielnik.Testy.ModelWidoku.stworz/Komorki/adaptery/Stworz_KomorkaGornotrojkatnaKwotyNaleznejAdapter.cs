using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaGornotrojkatnaKwotyNaleznejAdapter
    {
        public static IKomorkaGornotrojkatnaKwotyNaleznej Stworz(IKomorkaGornotrojkatnaKwotyNaleznej xyzAdaptowalna)
        {
            return new KomorkaGornotrojkatnaKwotyNaleznejAdapter(xyzAdaptowalna);
        }
    }
}