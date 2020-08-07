using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaKwotyNaleznej : IKomorkaKwotyNaleznej
    {
        public void UstalNaleznosc(INaleznoscSwiadczenieBaza nowaNaleznosc)
        {
            tekstKomorkiGornotrojkatnej = naleznoscNaStringProkurent.NaString(nowaNaleznosc);

            tekstKomorkiDolnotrojkatnej = naleznoscNaStringProkurent.NaStringOdwrotnosc(nowaNaleznosc);

            NaZmianeWlasciwosci("Tekst");
        }
    }
}