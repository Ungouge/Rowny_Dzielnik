using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej
    {
        private void UaktualnijNaleznosc()
        {
            CzyKomorkaCzytelna = konwerterTekstKwotyWejsciowej.Konwertuj(tekstKomorkiNaleznosci, out INaleznoscSwiadczenieBaza nowaNaleznosc);

            naleznoscKomorki = nowaNaleznosc;
        }
    }
}