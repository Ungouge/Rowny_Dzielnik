using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaWejsciowaImieniaAdapter
    {
        public static IKomorkaWejsciowaImienia Stworz(IKomorkaWejsciowaImienia komorkaWejsciowaImieniaAdaptowalna)
        {
            return new KomorkaWejsciowaImieniaAdapter(komorkaWejsciowaImieniaAdaptowalna);
        }
    }
}