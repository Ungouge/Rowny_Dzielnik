using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Konwertery
{
    partial class KomorkaNaOsobaPienieznaWizytator
    {
        public bool CzyOdpowiadaRodzajowiNaleznosci(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik)
        {
            if (rodzajNaleznosciWylicznik == RodzajNaleznosciWylicznik.NaleznoscPieniezna)
                return true;

            return false;
        }
    }
}