using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.ModelWidoku.Konwertery
{
    partial class KomorkaNaOsobaPienieznaWizytator
    {
        public IOsobaTypSwiadczenia StworzOsoba(byte indeks, INaleznoscSwiadczenieBaza naleznosc)
        {
            return fabrykaOsobaPieniezna.StworzOsoba(indeks, naleznosc as INaleznoscPieniezna);
        }
    }
}