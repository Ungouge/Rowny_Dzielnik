using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej : IKomorkaWejsciowaKwoty
    {
        private INaleznoscSwiadczenieBaza naleznoscKomorki;

        byte IKomorkaWejsciowaKwoty.Kolumna
        {
            get
            {
                return 1;
            }
        }
    }
}