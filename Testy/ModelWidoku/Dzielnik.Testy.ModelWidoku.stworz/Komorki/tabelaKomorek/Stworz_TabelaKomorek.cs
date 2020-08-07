using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    internal static class Stworz_TabelaKomorek
    {
        internal static ITabelaKomorek Stworz(IFabrykaModeluWidokuDlaTabelaKomorek fabryka, IUstawieniaDlaTabelaKomorek ustawienia)
        {
            return new TabelaKomorek(fabryka, ustawienia);
        }
    }
}