using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Konwertery
{
    partial class KonwerterTekstKwotyWejsciowejProkurent
    {
        public bool Konwertuj(string tekstKwotyWejsciowej, out INaleznoscSwiadczenieBaza naleznosc)
        {
            return konwerter.Konwertuj(tekstKwotyWejsciowej, out naleznosc);
        }
    }
}