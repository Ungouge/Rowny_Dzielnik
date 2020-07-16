using Dzielnik.ModelWidoku.Interfejsy.Konwertery;

namespace Dzielnik.ModelWidoku.Konwertery
{
    /// <summary>
    /// Prokuretnta konwertera przeslanej naleznosci na tekstu w odpowiedni sposob dla przeslanej implementacji konwerteara.
    /// </summary>
    internal partial class KonwerterNaleznoscNaStringProkurent : IKonwerterNaleznoscNaStringProkurent
    {
        private INaleznoscNaStringKonwerter konwerter;

        public KonwerterNaleznoscNaStringProkurent(INaleznoscNaStringKonwerter konwerter )
        {
            this.konwerter = konwerter;
        }
    }
}