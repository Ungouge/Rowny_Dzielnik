using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.ModelWidoku.Konwertery
{
    partial class TekstKwotyWejsciowejNaleznosciPienieznejKonwerter
    {
        public bool Konwertuj(string tekstKwotyWejsciowej, out INaleznoscSwiadczenieBaza naleznosc)
        {
            bool walidacjaFlaga = KonwertujNaZmiennoprzcinkowy(tekstKwotyWejsciowej, out float swiadczeniePieniezne);

            naleznosc = WezNaleznoscDlaSwiadczenia(swiadczeniePieniezne);

            return walidacjaFlaga;
        }

        private static bool KonwertujNaZmiennoprzcinkowy(string tekstKwotyWejsciowej, out float swiadczeniePieniezne)
        {
            if (String.IsNullOrEmpty(tekstKwotyWejsciowej))
            {
                swiadczeniePieniezne = 0;

                return true;
            }

            return float.TryParse(tekstKwotyWejsciowej, out swiadczeniePieniezne);
        }

        private INaleznoscSwiadczenieBaza WezNaleznoscDlaSwiadczenia(float swiadczeniePieniezne)
        {
            if (swiadczeniePieniezne == 0)
                return naleznoscZerowa;

            return fabryka.StworzNaleznosc((int)Math.Round(1e2 * swiadczeniePieniezne));
        }
    }
}