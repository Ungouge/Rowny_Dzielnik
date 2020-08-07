using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static class Stworz_KomorkaDiagonalnaAdapter
    {
        public static IKomorkaDiagonalna Stworz(IKomorkaDiagonalna komorkaDiagonalnaAdaptowalna)
        {
            return new KomorkaDiagonalnaAdapter(komorkaDiagonalnaAdaptowalna);
        }
    }
}