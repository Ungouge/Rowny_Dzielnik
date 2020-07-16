
namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    /// <summary>
    /// Interfejs dla prokuretnta konwertera przeslanej naleznosci na tekstu w odpowiedni sposob dla przeslanej implementacji konwerteara.
    /// </summary>
    internal interface IKonwerterNaleznoscNaStringProkurent : INaleznoscNaStringKonwerter
    {
        /// <summary>
        /// Uaktualnij implentacje konwertera ktora bedzie prokurowana.
        /// </summary>
        void UaktualnijProkurent(INaleznoscNaStringKonwerter konwerter);
    }
}