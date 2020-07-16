using Dzielnik.ModelWidoku.Interfejsy.Konwertery;

namespace Dzielnik.ModelWidoku.Konwertery
{
    partial class KonwerterNaleznoscNaStringProkurent
    {
        public void UaktualnijProkurent(INaleznoscNaStringKonwerter konwerter)
        {
            this.konwerter = konwerter; ;
        }
    }
}