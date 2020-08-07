using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaWyjsciowaImieniaAdapter
    {
        public static IKomorkaWyjsciowaImienia Stworz(IKomorkaWyjsciowaImienia komorkaWyjsciowaImieniaAdaptowalna)
        {
            return new KomorkaWyjsciowaImieniaAdapter(komorkaWyjsciowaImieniaAdaptowalna);
        }
    }
}