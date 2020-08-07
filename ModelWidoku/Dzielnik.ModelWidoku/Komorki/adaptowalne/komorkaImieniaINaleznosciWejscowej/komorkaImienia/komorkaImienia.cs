using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej : IKomorkaImienia
    {
        private string imie;
        
        private string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                imie = value;

                NaZmianeWlasciwosci();
            }
        }
        
        string IKomorkaImienia.Tekst
        {
            get
            {
                return Imie;
            }
        }
    }
}