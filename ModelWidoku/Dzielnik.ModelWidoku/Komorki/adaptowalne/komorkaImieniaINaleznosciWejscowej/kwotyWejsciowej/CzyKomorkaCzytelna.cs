
namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej
    {
        private bool czyKomorkaCzytelna = true;

        private bool CzyKomorkaCzytelna
        {
            get
            {
                return czyKomorkaCzytelna;
            }
            set
            {
                if (czyKomorkaCzytelna != value)
                {
                    czyKomorkaCzytelna = value;

                    czyMoznaObliczacUstal.ZmienMozliwoscOblicznia(this, czyKomorkaCzytelna);

                    NaZmianeWlasciwosci("KolorTla");
                }
            }
        }
    }
}