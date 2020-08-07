using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaWejsciowaKwotyAdapter
    {
        public static IKomorkaWejsciowaKwoty Stworz(IKomorkaWejsciowaKwoty komorkaWejsciowaKwotyAdaptowalna)
        {
            return new KomorkaWejsciowaKwotyAdapter(komorkaWejsciowaKwotyAdaptowalna);
        }
    }
}