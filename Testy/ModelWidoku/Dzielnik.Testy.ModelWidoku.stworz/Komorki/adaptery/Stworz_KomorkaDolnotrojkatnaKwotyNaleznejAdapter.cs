using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaDolnotrojkatnaKwotyNaleznejAdapter
    {
        public static IKomorkaDolnotrojkatnaKwotyNaleznej Stworz(IKomorkaDolnotrojkatnaKwotyNaleznej xyzAdaptowalna)
        {
            return new KomorkaDolnotrojkatnaKwotyNaleznejAdapter(xyzAdaptowalna);
        }
    }
}