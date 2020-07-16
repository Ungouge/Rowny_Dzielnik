using System.Linq;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.CzyMoznaObliczac
{
    partial class CzyMoznaObliczacWkaznik
    {
        public void ZmienMozliwoscOblicznia(IKomorkaWejsciowaKwoty komorkaKwotyWejsciowej, bool czyPozwala)
        {
            if (czyPozwala == true)
                ZezwolMozliwoscOblicznia(komorkaKwotyWejsciowej);
            else
                ZabronMozliwoscOblicznia(komorkaKwotyWejsciowej);
        }

        private void ZezwolMozliwoscOblicznia(IKomorkaWejsciowaKwoty komorkaKwotyWejsciowej)
        {
            zabraniajacaKomorkiKwotyWejsciowej.RemoveAll(komorka => komorka == komorkaKwotyWejsciowej);

            if (zabraniajacaKomorkiKwotyWejsciowej.Any() == false)
                CzyMoznaObliczac = true;
        }

        private void ZabronMozliwoscOblicznia(IKomorkaWejsciowaKwoty komorkaKwotyWejsciowej)
        {
            zabraniajacaKomorkiKwotyWejsciowej.Add(komorkaKwotyWejsciowej);

            CzyMoznaObliczac = false;
        }
    }
}