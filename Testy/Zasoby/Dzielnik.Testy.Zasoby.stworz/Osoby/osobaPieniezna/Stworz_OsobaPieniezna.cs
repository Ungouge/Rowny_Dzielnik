using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Testy.Zasoby.Osoby
{
    public static class Stworz_OsobaPieniezna
    {
        private static readonly IFabrykaOsobaPieniezna fabrykaOsobaPieniezna = new FabrykaOsobaPieniezna();
        
        public static IOsobaPieniezna Stworz(INaleznoscPieniezna naleznosc, byte iD = 0)
        {
            return fabrykaOsobaPieniezna.StworzOsoba(iD, naleznosc);
        }
    }
}
